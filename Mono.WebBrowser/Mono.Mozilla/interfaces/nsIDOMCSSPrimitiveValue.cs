// THIS FILE AUTOMATICALLY GENERATED BY xpidl2cs.pl
// EDITING IS PROBABLY UNWISE
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
// Copyright (c) 2007, 2008 Novell, Inc.
//
// Authors:
//  Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Mozilla
{

	[Guid ("e249031f-8df9-4e7a-b644-18946dce0019")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport ()]
	internal interface nsIDOMCSSPrimitiveValue : nsIDOMCSSValue
	{
		#region nsIDOMCSSValue
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getCssText ( /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setCssText (/*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getCssValueType (out ushort ret);

		#endregion

		#region nsIDOMCSSPrimitiveValue
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getPrimitiveType (out ushort ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int setFloatValue ( ushort unitType,
							float floatValue);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getFloatValue ( ushort unitType,
							out float ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int setStringValue ( ushort stringType,
							 /*DOMString*/ HandleRef stringValue);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getStringValue ( /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getCounterValue ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMCounter ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getRectValue ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMRect ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getRGBColorValue ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMRGBColor ret);

		#endregion
	}


	internal class nsDOMCSSPrimitiveValue
	{
		public static nsIDOMCSSPrimitiveValue GetProxy (Mono.WebBrowser.IWebBrowser control, nsIDOMCSSPrimitiveValue obj)
		{
			object o = Base.GetProxyForObject (control, typeof(nsIDOMCSSPrimitiveValue).GUID, obj);
			return o as nsIDOMCSSPrimitiveValue;
		}
	}
}
#if example

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

internal class DOMCSSPrimitiveValue : nsIDOMCSSPrimitiveValue
{

	#region nsIDOMCSSPrimitiveValue
	int nsIDOMCSSPrimitiveValue.getPrimitiveType (out ushort ret)

	{
		return 0;
	}

	int nsIDOMCSSPrimitiveValue.setFloatValue ( ushort unitType,
			float floatValue)
	{
		return ;
	}



	int nsIDOMCSSPrimitiveValue.getFloatValue ( ushort unitType,
			out float ret)
	{
		return ;
	}



	int nsIDOMCSSPrimitiveValue.setStringValue ( ushort stringType,
			/*DOMString*/ HandleRef stringValue)
	{
		return ;
	}



	int nsIDOMCSSPrimitiveValue.getStringValue ( /*DOMString*/ HandleRef ret)
	{
		return ;
	}



	int nsIDOMCSSPrimitiveValue.getCounterValue ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMCounter ret)
	{
		return ;
	}



	int nsIDOMCSSPrimitiveValue.getRectValue ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMRect ret)
	{
		return ;
	}



	int nsIDOMCSSPrimitiveValue.getRGBColorValue ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMRGBColor ret)
	{
		return ;
	}



	#endregion
}
#endif
