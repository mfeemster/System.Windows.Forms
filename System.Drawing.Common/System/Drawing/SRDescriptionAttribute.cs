// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Drawing
{
	//This was copied from the file of the same name in System.Drawing.Common because it seems to be implemented better.
	[AttributeUsage(AttributeTargets.All)]
	internal sealed class SRDescriptionAttribute : DescriptionAttribute
	{
		private bool _replaced;

		public override string Description
		{
			get
			{
				if (!_replaced)
				{
					_replaced = true;
					DescriptionValue = SR.Format(base.Description);
				}

				return base.Description;
			}
		}

		public SRDescriptionAttribute(string description) : base(description)
		{
		}
	}
}
