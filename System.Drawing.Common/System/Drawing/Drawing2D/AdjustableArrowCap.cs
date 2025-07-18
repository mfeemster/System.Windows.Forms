// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Gdip = System.Drawing.SafeNativeMethods.Gdip;

namespace System.Drawing.Drawing2D
{
    public sealed partial class AdjustableArrowCap : CustomLineCap
    {
        internal AdjustableArrowCap(IntPtr nativeCap) : base(nativeCap) { }

        public AdjustableArrowCap(float width, float height) : this(width, height, true) { }

        public AdjustableArrowCap(float width, float height, bool isFilled)
        {
            IntPtr nativeCap;
            int status = Gdip.GdipCreateAdjustableArrowCap(height, width, isFilled, out nativeCap);
            Gdip.CheckStatus(status);
            SetNativeLineCap(nativeCap);
        }

        public float Height
        {
            get
            {
                int status = Gdip.GdipGetAdjustableArrowCapHeight(new HandleRef(this, nativeCap), out float height);
                Gdip.CheckStatus(status);
                return height;
            }
            set
            {
                int status = Gdip.GdipSetAdjustableArrowCapHeight(new HandleRef(this, nativeCap), value);
                Gdip.CheckStatus(status);
            }
        }

        public float Width
        {
            get
            {
                int status = Gdip.GdipGetAdjustableArrowCapWidth(new HandleRef(this, nativeCap), out float width);
                Gdip.CheckStatus(status);
                return width;
            }
            set
            {
                int status = Gdip.GdipSetAdjustableArrowCapWidth(new HandleRef(this, nativeCap), value);
                Gdip.CheckStatus(status);
            }
        }

        public float MiddleInset
        {
            get
            {
                int status = Gdip.GdipGetAdjustableArrowCapMiddleInset(new HandleRef(this, nativeCap), out float middleInset);
                Gdip.CheckStatus(status);
                return middleInset;
            }
            set
            {
                int status = Gdip.GdipSetAdjustableArrowCapMiddleInset(new HandleRef(this, nativeCap), value);
                Gdip.CheckStatus(status);
            }
        }

        public bool Filled
        {
            get
            {
                int status = Gdip.GdipGetAdjustableArrowCapFillState(new HandleRef(this, nativeCap), out bool isFilled);
                Gdip.CheckStatus(status);
                return isFilled;
            }
            set
            {
                int status = Gdip.GdipSetAdjustableArrowCapFillState(new HandleRef(this, nativeCap), value);
                Gdip.CheckStatus(status);
            }
        }
    }
}
