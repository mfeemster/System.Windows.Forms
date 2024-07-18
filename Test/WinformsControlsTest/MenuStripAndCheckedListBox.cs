// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing;

namespace WinformsControlsTest;

[DesignerCategory("Default")]
public partial class MenuStripAndCheckedListBox : Form
{
	public MenuStripAndCheckedListBox()
	{
		InitializeComponent();
	}

	private void MenuStripScaling_Load(object sender, EventArgs e)
	{
		//currentDpiLabel.Text = $"Current scaling = {(int)Math.Round((DeviceDpi / 96.0) * 100)}%";
		using (var graphics = Graphics.FromHwnd(IntPtr.Zero))//This will only get the DPI for the first screen.
		{
			var x = graphics.DpiX;
			currentDpiLabel.Text = $"Current scaling is {(int)Math.Round((graphics.DpiX / 96.0) * 100)}%";
		}

	}

	//private void MenuStripAndCheckedListBox_DpiChanged(object sender, DpiChangedEventArgs e)
	//{
	//    currentDpiLabel.Text = $"Current scaling = {(int)Math.Round((DeviceDpi / 96.0) * 100)}%";

	//    menuStrip1.SuspendLayout();

	//    float factor = (float)e.DeviceDpiNew / e.DeviceDpiOld;

	//    // foreach (ToolStripMenuItem item in menuStrip1.Items)
	//    // {
	//    //    item.Size = new Size((int)Math.Round(factor * item.Width), (int)Math.Round(factor * item.Height));
	//    // }

	//    // int width = menuStrip1.Width;
	//    // int height = menuStrip1.Height;
	//    // menuStrip1.Size = new Size((int)Math.Round(factor * menuStrip1.Width), (int)Math.Round(factor * menuStrip1.Height));

	//    Font f = menuStrip1.Font;
	//    menuStrip1.Font = new Font(f.FontFamily, f.Size * factor, f.Style);

	//    menuStrip1.ResumeLayout();
	//}
}
