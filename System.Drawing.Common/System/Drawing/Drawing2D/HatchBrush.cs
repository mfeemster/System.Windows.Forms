// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Diagnostics;
using Gdip = System.Drawing.SafeNativeMethods.Gdip;

namespace System.Drawing.Drawing2D
{
    public sealed class HatchBrush : Brush
    {
        public HatchBrush(HatchStyle hatchstyle, Color foreColor) : this(hatchstyle, foreColor, Color.FromArgb(unchecked((int)0xff000000)))
        {
        }

        public HatchBrush(HatchStyle hatchstyle, Color foreColor, Color backColor)
        {
            if (hatchstyle < HatchStyle.Min || hatchstyle > HatchStyle.SolidDiamond)
            {
                throw new ArgumentException(SR.Format(SR.InvalidEnumArgument, nameof(hatchstyle), hatchstyle, nameof(HatchStyle)), nameof(hatchstyle));
            }

            IntPtr nativeBrush;
            int status = Gdip.GdipCreateHatchBrush(unchecked((int)hatchstyle), foreColor.ToArgb(), backColor.ToArgb(), out nativeBrush);
            Gdip.CheckStatus(status);

            SetNativeBrushInternal(nativeBrush);
        }

        internal HatchBrush(IntPtr nativeBrush)
        {
            Debug.Assert(nativeBrush != IntPtr.Zero, "Initializing native brush with null.");
            SetNativeBrushInternal(nativeBrush);
        }

        public override object Clone()
        {
            IntPtr clonedBrush = IntPtr.Zero;
            int status = Gdip.GdipCloneBrush(new HandleRef(this, NativeBrush), out clonedBrush);
            Gdip.CheckStatus(status);

            return new HatchBrush(clonedBrush);
        }

        public HatchStyle HatchStyle
        {
            get
            {
                int hatchStyle;
                int status = Gdip.GdipGetHatchStyle(new HandleRef(this, NativeBrush), out hatchStyle);
                Gdip.CheckStatus(status);

                return (HatchStyle)hatchStyle;
            }
        }

        public Color ForegroundColor
        {
            get
            {
                int foregroundArgb;
                int status = Gdip.GdipGetHatchForegroundColor(new HandleRef(this, NativeBrush), out foregroundArgb);
                Gdip.CheckStatus(status);

                return Color.FromArgb(foregroundArgb);
            }
        }

        public Color BackgroundColor
        {
            get
            {
                int backgroundArgb;
                int status = Gdip.GdipGetHatchBackgroundColor(new HandleRef(this, NativeBrush), out backgroundArgb);
                Gdip.CheckStatus(status);

                return Color.FromArgb(backgroundArgb);
            }
        }
    }
}
