﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing;

namespace WinformsControlsTest;

[DesignerCategory("Default")]
public partial class ToolStripTests : Form
{
	private int clickCount = 0;
	public ToolStripTests()
	{
		InitializeComponent();
		toolStrip1.Items.Add(new ToolStripControlHost(new RadioButton() { Text = "RadioButton" })); // RadioButton supports UIA
		toolStrip1.Items.Add(new ToolStripControlHost(new HScrollBar() { Value = 30 })); // HScrollBar doesn't support UIA
		statusStrip1.Items.Add(new ToolStripControlHost(new RadioButton() { Text = "RadioButton" })); // RadioButton supports UIA
		statusStrip1.Items.Add(new ToolStripControlHost(new HScrollBar() { Value = 30 })); // HScrollBar doesn't support UIA
		var p = "Images" + System.IO.Path.DirectorySeparatorChar.ToString();
		toolStrip2_Button4.Image = Image.FromFile($"{p}SmallA.bmp");
		toolStrip2_Button4.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
		toolStrip2_Button5.Image = Image.FromFile($"{p}SmallABlue.bmp");
		toolStrip2_Button5.DisplayStyle = ToolStripItemDisplayStyle.Image;
	}

	private void ToolStrip2_Button5_Click(object sender, EventArgs e)
	{
		toolStripStatusLabel1.Text = $"Click: {clickCount}";
	}
}
