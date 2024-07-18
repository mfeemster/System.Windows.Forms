// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing;
using WinformsControlsTest;

// Set STAThread
//Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
//Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
//ApplicationConfiguration.Initialize();
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

try
{
	MainForm form = new ()
	{
		//Icon = SystemIcons.GetStockIcon(StockIconId.Shield, StockIconOptions.SmallIcon)
		//Icon = SystemIcons.Application
	};
	Application.Run(form);
}
catch (Exception ex)
{
	MessageBox.Show("Uncaught exception: " + ex.Message, "Winforms Controls Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
	Console.WriteLine(ex.Message);
	Environment.Exit(-1);
}

Environment.Exit(0);

