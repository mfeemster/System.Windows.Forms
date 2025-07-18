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

	[Guid ("a6cf908d-15b3-11d2-932e-00805f8add32")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport ()]
	internal interface nsIDOMHTMLStyleElement : nsIDOMHTMLElement
	{
		#region nsIDOMNode
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getNodeName (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getNodeValue (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setNodeValue ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getNodeType ( out ushort ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getParentNode ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getChildNodes ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNodeList ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getFirstChild ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getLastChild ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getPreviousSibling ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getNextSibling ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getAttributes ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMNamedNodeMap ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getOwnerDocument ([MarshalAs (UnmanagedType.Interface)]  out nsIDOMDocument ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int insertBefore (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMNode newChild,
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMNode refChild, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int replaceChild (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMNode newChild,
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMNode oldChild, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int removeChild (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMNode oldChild, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int appendChild (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMNode newChild, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int hasChildNodes ( out bool ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int cloneNode (
			bool deep, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int normalize ();

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int isSupported (
			/*DOMString*/ HandleRef feature,
			/*DOMString*/ HandleRef version, out bool ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getNamespaceURI (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getPrefix (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setPrefix ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getLocalName (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int hasAttributes ( out bool ret);

		#endregion

		#region nsIDOMElement
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getTagName (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getAttribute (
			/*DOMString*/ HandleRef name,  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setAttribute (
			/*DOMString*/ HandleRef name,
			/*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int removeAttribute (
			/*DOMString*/ HandleRef name);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getAttributeNode (
			/*DOMString*/ HandleRef name, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMAttr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setAttributeNode (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMAttr newAttr, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMAttr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int removeAttributeNode (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMAttr oldAttr, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMAttr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getElementsByTagName (
			/*DOMString*/ HandleRef name, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNodeList ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getAttributeNS (
			/*DOMString*/ HandleRef namespaceURI,
			/*DOMString*/ HandleRef localName,  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setAttributeNS (
			/*DOMString*/ HandleRef namespaceURI,
			/*DOMString*/ HandleRef qualifiedName,
			/*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int removeAttributeNS (
			/*DOMString*/ HandleRef namespaceURI,
			/*DOMString*/ HandleRef localName);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getAttributeNodeNS (
			/*DOMString*/ HandleRef namespaceURI,
			/*DOMString*/ HandleRef localName, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMAttr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setAttributeNodeNS (
			[MarshalAs (UnmanagedType.Interface)]   nsIDOMAttr newAttr, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMAttr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getElementsByTagNameNS (
			/*DOMString*/ HandleRef namespaceURI,
			/*DOMString*/ HandleRef localName, [MarshalAs (UnmanagedType.Interface)]  out nsIDOMNodeList ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int hasAttribute (
			/*DOMString*/ HandleRef name, out bool ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int hasAttributeNS (
			/*DOMString*/ HandleRef namespaceURI,
			/*DOMString*/ HandleRef localName, out bool ret);

		#endregion

		#region nsIDOMHTMLElement
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getId (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setId ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getTitle (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setTitle ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getLang (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setLang ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getDir (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setDir ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int getClassName (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new int setClassName ( /*DOMString*/ HandleRef value);

		#endregion

		#region nsIDOMHTMLStyleElement
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getDisabled ( out bool ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int setDisabled ( bool value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getMedia (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int setMedia ( /*DOMString*/ HandleRef value);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getType (  /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int setType ( /*DOMString*/ HandleRef value);

		#endregion
	}


	internal class nsDOMHTMLStyleElement
	{
		public static nsIDOMHTMLStyleElement GetProxy (Mono.WebBrowser.IWebBrowser control, nsIDOMHTMLStyleElement obj)
		{
			object o = Base.GetProxyForObject (control, typeof(nsIDOMHTMLStyleElement).GUID, obj);
			return o as nsIDOMHTMLStyleElement;
		}
	}
}
