// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
// System.Drawing.carbonFunctions.cs
//
// Authors:
//      Geoff Norton (gnorton@customerdna.com>
//
// Copyright (C) 2007 Novell, Inc. (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Collections;
using System.Runtime.InteropServices;

namespace System.Drawing
{
    internal static class MacSupport
    {
        internal static readonly Hashtable contextReference = new Hashtable();
        internal static readonly object lockobj = new object();

        internal static CocoaContext GetCGContextForNSView(IntPtr handle)
        {
            IntPtr graphicsContext = intptr_objc_msgSend(objc_getClass("NSGraphicsContext"), sel_registerName("currentContext"));
            IntPtr ctx = intptr_objc_msgSend(graphicsContext, sel_registerName("graphicsPort"));

            CGContextSaveGState(ctx);

            Rect_objc_msgSend_stret(out Rect bounds, handle, sel_registerName("bounds"));

            var isFlipped = bool_objc_msgSend(handle, sel_registerName("isFlipped"));
            if (isFlipped)
            {
                CGContextTranslateCTM(ctx, bounds.origin.x, bounds.size.height);
                CGContextScaleCTM(ctx, 1.0f, -1.0f);
            }

            return new CocoaContext(ctx, (int)bounds.size.width, (int)bounds.size.height);
        }

        internal static CarbonContext GetCGContextForView(IntPtr handle)
        {
            IntPtr context = IntPtr.Zero;
            IntPtr port = IntPtr.Zero;
            IntPtr window = IntPtr.Zero;

            window = GetControlOwner(handle);

            if (handle == IntPtr.Zero || window == IntPtr.Zero)
            {
                // FIXME: Can we actually get a CGContextRef for the desktop?  this makes context IntPtr.Zero
                port = GetQDGlobalsThePort();
                CreateCGContextForPort(port, ref context);

                Rect desktop_bounds = CGDisplayBounds(CGMainDisplayID());

                return new CarbonContext(port, context, (int)desktop_bounds.size.width, (int)desktop_bounds.size.height);
            }

            QDRect window_bounds = default(QDRect);
            Rect view_bounds = default(Rect);

            port = GetWindowPort(window);

            context = GetContext(port);

            GetWindowBounds(window, 32, ref window_bounds);

            HIViewGetBounds(handle, ref view_bounds);

            HIViewConvertRect(ref view_bounds, handle, IntPtr.Zero);

            if (view_bounds.size.height < 0)
                view_bounds.size.height = 0;
            if (view_bounds.size.width < 0)
                view_bounds.size.width = 0;

            CGContextTranslateCTM(context, view_bounds.origin.x, (window_bounds.bottom - window_bounds.top) - (view_bounds.origin.y + view_bounds.size.height));

            // Create the original rect path and clip to it
            Rect rc_clip = new Rect(0, 0, view_bounds.size.width, view_bounds.size.height);

            CGContextSaveGState(context);

            CGContextBeginPath(context);
            CGContextAddRect(context, rc_clip);
            CGContextClosePath(context);
            CGContextClip(context);

            return new CarbonContext(port, context, (int)view_bounds.size.width, (int)view_bounds.size.height);
        }

        internal static IntPtr GetContext(IntPtr port)
        {
            IntPtr context = IntPtr.Zero;

            lock (lockobj)
            {
#if FALSE
                if (contextReference [port] != null) {
                    CreateCGContextForPort (port, ref context);
                } else {
                    QDBeginCGContext (port, ref context);
                    contextReference [port] = context;
                }
#else
                CreateCGContextForPort(port, ref context);
#endif
            }

            return context;
        }

        internal static void ReleaseContext(IntPtr port, IntPtr context)
        {
            CGContextRestoreGState(context);

            lock (lockobj)
            {
#if FALSE
                if (contextReference [port] != null && context == (IntPtr) contextReference [port]) {
                    QDEndCGContext (port, ref context);
                    contextReference [port] = null;
                } else {
                    CFRelease (context);
                }
#else
                CFRelease(context);
#endif
            }
        }

        #region Cocoa Methods
        [DllImport("libobjc.dylib")]
        public static extern IntPtr objc_getClass(string className);
        [DllImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
        public static extern IntPtr intptr_objc_msgSend(IntPtr basePtr, IntPtr selector);
        [DllImport("libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
        public static extern void Rect_objc_msgSend_stret(out Rect arect, IntPtr basePtr, IntPtr selector);
        [DllImport("libobjc.dylib", EntryPoint = "objc_msgSend")]
        [return:MarshalAs(UnmanagedType.U1)]
        public static extern bool bool_objc_msgSend(IntPtr handle, IntPtr selector);
        [DllImport("libobjc.dylib")]
        public static extern IntPtr sel_registerName(string selectorName);
        #endregion

        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern IntPtr CGMainDisplayID();
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern Rect CGDisplayBounds(IntPtr display);

        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern int HIViewGetBounds(IntPtr vHnd, ref Rect r);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern int HIViewConvertRect(ref Rect r, IntPtr a, IntPtr b);

        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern IntPtr GetControlOwner(IntPtr aView);

        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern int GetWindowBounds(IntPtr wHnd, uint reg, ref QDRect rect);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern IntPtr GetWindowPort(IntPtr hWnd);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern IntPtr GetQDGlobalsThePort();
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CreateCGContextForPort(IntPtr port, ref IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CFRelease(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void QDBeginCGContext(IntPtr port, ref IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void QDEndCGContext(IntPtr port, ref IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern int CGContextClipToRect(IntPtr context, Rect clip);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern int CGContextClipToRects(IntPtr context, Rect[] clip_rects, int count);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextTranslateCTM(IntPtr context, float tx, float ty);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextScaleCTM(IntPtr context, float x, float y);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextFlush(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextSynchronize(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern IntPtr CGPathCreateMutable();
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGPathAddRects(IntPtr path, IntPtr _void, Rect[] rects, int count);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGPathAddRect(IntPtr path, IntPtr _void, Rect rect);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextAddRects(IntPtr context, Rect[] rects, int count);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextAddRect(IntPtr context, Rect rect);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextBeginPath(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextClosePath(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextAddPath(IntPtr context, IntPtr path);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextClip(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextEOClip(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextEOFillPath(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextSaveGState(IntPtr context);
        [DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
        internal static extern void CGContextRestoreGState(IntPtr context);
    }

    internal struct CGSize
    {
        public float width;
        public float height;
    }

    internal struct CGPoint
    {
        public float x;
        public float y;
    }

    internal struct Rect
    {
        public Rect(float x, float y, float width, float height)
        {
            this.origin.x = x;
            this.origin.y = y;
            this.size.width = width;
            this.size.height = height;
        }

        public CGPoint origin;
        public CGSize size;
    }

    internal struct QDRect
    {
        public short top;
        public short left;
        public short bottom;
        public short right;
    }

    internal struct CarbonContext : IMacContext
    {
        public IntPtr port;
        public IntPtr ctx;
        public int width;
        public int height;

        public CarbonContext(IntPtr port, IntPtr ctx, int width, int height)
        {
            this.port = port;
            this.ctx = ctx;
            this.width = width;
            this.height = height;
        }

        public void Synchronize()
        {
            MacSupport.CGContextSynchronize(ctx);
        }

        public void Release()
        {
            MacSupport.ReleaseContext(port, ctx);
        }
    }

    internal struct CocoaContext : IMacContext
    {
        public IntPtr ctx;
        public int width;
        public int height;

        public CocoaContext(IntPtr ctx, int width, int height)
        {
            this.ctx = ctx;
            this.width = width;
            this.height = height;
        }

        public void Synchronize()
        {
            MacSupport.CGContextSynchronize(ctx);
        }

        public void Release()
        {
            MacSupport.CGContextRestoreGState(ctx);
        }
    }

    internal interface IMacContext
    {
        void Synchronize();
        void Release();
    }
}
