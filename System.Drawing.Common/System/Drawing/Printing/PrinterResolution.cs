// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Globalization;

namespace System.Drawing.Printing
{
    /// <summary>
    /// Retrieves the resolution supported by a printer.
    /// </summary>
    public partial class PrinterResolution
    {
        private int _x;
        private int _y;
        private PrinterResolutionKind _kind;

        /// <summary>
        /// Initializes a new instance of the <see cref='PrinterResolution'/> class with default properties.
        /// </summary>
        public PrinterResolution()
        {
            _kind = PrinterResolutionKind.Custom;
        }

        internal PrinterResolution(PrinterResolutionKind kind, int x, int y)
        {
            _kind = kind;
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Gets a value indicating the kind of printer resolution.
        /// </summary>
        public PrinterResolutionKind Kind
        {
            get => _kind;
            set
            {
                if (value < PrinterResolutionKind.High || value > PrinterResolutionKind.Custom)
                {
                    throw new InvalidEnumArgumentException(nameof(value), unchecked((int)value), typeof(PrinterResolutionKind));
                }

                _kind = value;
            }
        }

        /// <summary>
        /// Gets the printer resolution in the horizontal direction, in dots per inch.
        /// </summary>
        public int X
        {
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// Gets the printer resolution in the vertical direction, in dots per inch.
        /// </summary>
        public int Y
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// Provides some interesting information about the PrinterResolution in String form.
        /// </summary>
        public override string ToString()
        {
            if (_kind != PrinterResolutionKind.Custom)
            {
                return $"[PrinterResolution {Kind}]";
            }


            return FormattableString.Invariant($"[PrinterResolution X={X} Y={Y}]");
        }
    }
}
