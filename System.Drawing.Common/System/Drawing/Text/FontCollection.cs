// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.InteropServices;
using Gdip = System.Drawing.SafeNativeMethods.Gdip;

namespace System.Drawing.Text
{
    /// <summary>
    /// When inherited, enumerates the FontFamily objects in a collection of fonts.
    /// </summary>
    public abstract class FontCollection : IDisposable
    {
        internal IntPtr _nativeFontCollection;

        internal FontCollection() => _nativeFontCollection = IntPtr.Zero;

        /// <summary>
        /// Disposes of this <see cref='System.Drawing.Text.FontCollection'/>
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) { }

        /// <summary>
        /// Gets the array of <see cref='System.Drawing.FontFamily'/> objects associated
        /// with this <see cref='System.Drawing.Text.FontCollection'/>.
        /// </summary>
        public FontFamily[] Families
        {
            get
            {
                int numSought = 0;
                int status = Gdip.GdipGetFontCollectionFamilyCount(new HandleRef(this, _nativeFontCollection), out numSought);
                Gdip.CheckStatus(status);

                var gpfamilies = new IntPtr[numSought];
                int numFound = 0;
                status = Gdip.GdipGetFontCollectionFamilyList(new HandleRef(this, _nativeFontCollection), numSought, gpfamilies,
                                                             out numFound);
                Gdip.CheckStatus(status);

                Debug.Assert(numSought == numFound, "GDI+ can't give a straight answer about how many fonts there are");
                var families = new FontFamily[numFound];
                for (int f = 0; f < numFound; f++)
                {
                    IntPtr native;
                    Gdip.GdipCloneFontFamily(gpfamilies[f], out native);
                    families[f] = new FontFamily(native);
                }

                return families;
            }
        }

        ~FontCollection() => Dispose(false);
    }
}
