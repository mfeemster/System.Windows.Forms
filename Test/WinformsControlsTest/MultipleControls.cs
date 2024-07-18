// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing;

namespace WinformsControlsTest;

[DesignerCategory("Default")]
public partial class MultipleControls : Form
{
	public MultipleControls()
	{
		InitializeComponent();
		CreateMyListView();
		maskedTextBoxToolTip = new ToolTip();
		//This is needed to properly set bold/italic fonts in linux.
		var tempFont = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
		FontFamily validFontFamily = tempFont.FontFamily;

		foreach (FontFamily ff in FontFamily.Families)
		{
			if (ff.Name == tempFont.FontFamily.Name)
			{
				validFontFamily = ff;
				break;
			}
		}

		var regularfont = new Font(validFontFamily, 11F, FontStyle.Regular);
		var boldfont = new Font(regularfont, FontStyle.Bold);
		richTextBox1.Font = boldfont;
	}

	private void CreateMyListView()
	{
		// Create a new ListView control.
		ListView listView2 = new ListView
		{
			Bounds = new Rectangle(new Point(0, 0), new Size(400, 200)),

			// Set the view to show details.
			View = View.Details,
			// Allow the user to edit item text.
			LabelEdit = true,
			// Allow the user to rearrange columns.
			AllowColumnReorder = true,
			// Display check boxes.
			CheckBoxes = true,
			// Select the item and subitems when selection is made.
			FullRowSelect = true,
			// Display grid lines.
			GridLines = true,
			// Sort the items in the list in ascending order.
			Sorting = SortOrder.Ascending,

			VirtualMode = true,
			VirtualListSize = 3,
		};
		// Create three items and three sets of subitems for each item.
		ListViewItem item1 = new ("item1", 0)
		{
			// Place a check mark next to the item.
			Checked = true
		};
		item1.SubItems.Add("sub1");
		item1.SubItems.Add("sub2");
		item1.SubItems.Add("sub3");
		ListViewItem item2 = new ("item2", 1);
		item2.SubItems.Add("sub4");
		item2.SubItems.Add("sub5");
		item2.SubItems.Add("sub6");
		ListViewItem item3 = new ("item3", 0)
		{
			// Place a check mark next to the item.
			Checked = true
		};
		item3.SubItems.Add("sub7");
		item3.SubItems.Add("sub8");
		item3.SubItems.Add("sub9");
		// Add the items to the ListView, but because the listview is in Virtual Mode, we have to manage items ourselves
		// and thus, we can't call the following:
		//      listView2.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
		listView2.RetrieveVirtualItem += (s, e) =>
		{

			e.Item = e.ItemIndex switch
		{
				0 => item1,
				1 => item2,
				2 => item3,
				_ => throw new ArgumentOutOfRangeException(),
			};
		};
		// Create columns for the items and subitems.
		// Width of -2 indicates auto-size.
		listView2.Columns.Add("column1", "Item Column", -2, HorizontalAlignment.Left, 0);
		listView2.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
		listView2.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
		listView2.Columns.Add("Column 4", -2, HorizontalAlignment.Center);
		listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		// Create two ImageList objects.
		ImageList imageListSmall = new ();
		ImageList imageListLarge = new ();
		// Initialize the ImageList objects with bitmaps.
		var p = "Images" + System.IO.Path.DirectorySeparatorChar.ToString();
		imageListSmall.Images.Add(Image.FromFile($"{p}SmallA.bmp"));
		imageListSmall.Images.Add(Image.FromFile($"{p}SmallABlue.bmp"));
		imageListLarge.Images.Add(Image.FromFile($"{p}LargeA.bmp"));
		imageListLarge.Images.Add(Image.FromFile($"{p}LargeABlue.bmp"));
		// Assign the ImageList objects to the ListView.
		listView2.LargeImageList = imageListLarge;
		listView2.SmallImageList = imageListSmall;
		// Add the ListView to the control collection.
		Controls.Add(listView2);
		listView2.Dock = DockStyle.Bottom;
	}

	private void Test3_Load(object sender, EventArgs e)
	{
		backgroundWorker1.RunWorkerAsync();
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		for (int i = 1; i < 100; i++)
		{
			Thread.Sleep(100);
			backgroundWorker1.ReportProgress(i);
		}
	}

	private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		progressBar1.Value = e.ProgressPercentage;
	}

	private void Button1_Click(object sender, System.EventArgs e)
	{
		textBox1.Enabled = !textBox1.Enabled;
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		// Change the color of the link text by setting LinkVisited
		// to true.
		linkLabel1.LinkVisited = true;
		//https://stackoverflow.com/questions/1349482/how-do-i-launch-a-url-in-monodevelop-c
		System.Diagnostics.Process proc = new System.Diagnostics.Process();
		proc.EnableRaisingEvents = false;
		proc.StartInfo.FileName = "xdg-open"; //best guess
		proc.StartInfo.Arguments = "http://www.microsoft.com";
		proc.Start();
	}

	private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
		if (maskedTextBox1.MaskFull)
		{
			maskedTextBoxToolTip.ToolTipTitle = "Input Rejected - Too Much Data";
			maskedTextBoxToolTip.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", maskedTextBox1, 0, -20, 5000);
		}
		else if (e.Position == maskedTextBox1.Mask.Length)
		{
			maskedTextBoxToolTip.ToolTipTitle = "Input Rejected - End of Field";
			maskedTextBoxToolTip.Show("You cannot add extra characters to the end of this date field.", maskedTextBox1, 0, -20, 5000);
		}
		else
		{
			maskedTextBoxToolTip.ToolTipTitle = "Input Rejected";
			maskedTextBoxToolTip.Show("You can only add numeric characters (0-9) into this date field.", maskedTextBox1, 0, -20, 5000);
		}
	}

	private void MaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		maskedTextBoxToolTip.Hide(maskedTextBox1);
	}

	private void MenuStripScaling_Load(object sender, EventArgs e)
	{
		checkedListBox1.Items.Add("Pennsylvania", CheckState.Checked);
	}
}
