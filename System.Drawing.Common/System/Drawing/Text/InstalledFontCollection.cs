// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using Gdip = System.Drawing.SafeNativeMethods.Gdip;

namespace System.Drawing.Text
{
    /// <summary>
    /// Represents the fonts installed on the system.
    /// </summary>
    public sealed class InstalledFontCollection : FontCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref='System.Drawing.Text.InstalledFontCollection'/> class.
        /// </summary>
        public InstalledFontCollection() : base()
        {
            int status = Gdip.GdipNewInstalledFontCollection(out _nativeFontCollection);
            Gdip.CheckStatus(status);
        }
    }
}
