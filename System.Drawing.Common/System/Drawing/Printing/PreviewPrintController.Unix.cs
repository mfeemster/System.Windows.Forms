// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

//
// System.Drawing.PreviewPrintController.cs
//
// Author:
//   Dennis Hayes (dennish@Raytek.com)
//
// (C) 2002 Ximian, Inc
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
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

namespace System.Drawing.Printing
{
    public partial class PreviewPrintController : PrintController
    {
        public override void OnEndPage(PrintDocument document, PrintPageEventArgs e)
        {
        }

        public override void OnStartPrint(PrintDocument document, PrintEventArgs e)
        {
            if (!document.PrinterSettings.IsValid)
            {
                throw new InvalidPrinterException(document.PrinterSettings);
            }

            foreach (PreviewPageInfo? pi in _list)
            {
                pi!.Image.Dispose();
            }

            _list.Clear();
        }

        public override void OnEndPrint(PrintDocument document, PrintEventArgs e)
        {
        }

        public override Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e)
        {
            Image image = new Bitmap(e.PageSettings.PaperSize.Width, e.PageSettings.PaperSize.Height);

            PreviewPageInfo info = new PreviewPageInfo(image, new Size(e.PageSettings.PaperSize.Width,
                                             e.PageSettings.PaperSize.Height));

            _list.Add(info);

            Graphics g = Graphics.FromImage(info.Image);
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(new Point(0, 0), new Size(image.Width, image.Height)));

            return g;
        }
    }
}
