//
// ToolStripItemImageRenderEventArgs.cs
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
// Copyright (c) 2006 Jonathan Pobst
//
// Authors:
//  Jonathan Pobst (monkey@jpobst.com)
//

namespace System.Windows.Forms
{
	public class ToolStripItemImageRenderEventArgs : ToolStripItemRenderEventArgs
	{
		private Image image;
		private Rectangle image_rectangle;

		public ToolStripItemImageRenderEventArgs (Graphics g, ToolStripItem item, Rectangle imageRectangle)
			: this (g, item, null, imageRectangle)
		{
		}

		public ToolStripItemImageRenderEventArgs (Graphics g, ToolStripItem item, Image image, Rectangle imageRectangle)
			: base (g, item)
		{
			this.image = image;
			this.image_rectangle = imageRectangle;
		}

		#region Public Properties
		public Image Image
		{
			get { return this.image; }
		}

		public Rectangle ImageRectangle
		{
			get { return this.image_rectangle; }
		}
		#endregion
	}
}
