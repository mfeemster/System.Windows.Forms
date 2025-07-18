﻿// created on 07/04/2003 at 17:16
//
//  System.Runtime.Serialization.Formatters.Soap.SoapFormatter
//
//  Authors:
//      Jean-Marc Andre (jean-marc.andre@polymtl.ca)
//

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

namespace System.Runtime.Serialization.Formatters.Soap
{
	public interface ISoapMessage
	{
		// Name of parameters, if null the default param names will be used

		String[] ParamNames { get; set; }

		// Parameter Values
		Object[] ParamValues { get; set; }

		// Parameter Types
		Type[] ParamTypes { get; set; }

		// MethodName
		String MethodName { get; set; }

		// MethodName XmlNameSpace
		String XmlNameSpace { get; set; }

		// Headers
		Header[] Headers { get; set; }
	}

	enum RemMessageType
	{
		MethodCall, MethodResponse, ServerFault, NotRecognize
	}

	public sealed class SoapFormatter : IRemotingFormatter, IFormatter
	{
		private SerializationBinder _binder;
		private StreamingContext _context;
		private ISurrogateSelector _selector;
		private FormatterAssemblyStyle _assemblyFormat = FormatterAssemblyStyle.Full;
		private FormatterTypeStyle _typeFormat = FormatterTypeStyle.TypesWhenNeeded;
		private ISoapMessage _topObject = null;

		TypeFilterLevel _filterLevel = TypeFilterLevel.Low;

		public SoapFormatter()
		{
			_selector = null;
			_context = new StreamingContext(StreamingContextStates.All);
		}

		public SoapFormatter(ISurrogateSelector selector, StreamingContext context)
		{
			_selector = selector;
			_context = context;
		}

		public object Deserialize(Stream serializationStream)
		{
			return Deserialize(serializationStream, null);
		}

		public object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			/*  SoapReader soapReader = new SoapReader(_binder, _selector, _context);
			    return soapReader.Deserialize(serializationStream, _topObject);*/
			return new object();
		}

		public void Serialize(Stream serializationStream, object graph)
		{
			Serialize(serializationStream, graph, null);
		}

		public void Serialize(Stream serializationStream, object graph, Header[] headers)
		{
			if (serializationStream == null)
				throw new ArgumentNullException("serializationStream");

			if (!serializationStream.CanWrite)
				throw new SerializationException("Can't write in the serialization stream");

			if (graph == null)
				throw new ArgumentNullException("graph");

			/*  SoapWriter soapWriter = new SoapWriter(serializationStream, _selector, _context, _topObject);
			    soapWriter.Serialize(graph, headers, _typeFormat, _assemblyFormat);*/
		}

		public ISurrogateSelector SurrogateSelector
		{
			get
			{
				return _selector;
			}
			set
			{
				_selector = value;
			}
		}


		public SerializationBinder Binder
		{
			get
			{
				return _binder;
			}
			set
			{
				_binder = value;
			}
		}

		public StreamingContext Context
		{
			get
			{
				return _context;
			}
			set
			{
				_context = value;
			}
		}

		public ISoapMessage TopObject
		{
			get
			{
				return _topObject;
			}
			set
			{
				_topObject = value;
			}
		}

		[MonoTODO("Interpret this")]
		public TypeFilterLevel FilterLevel
		{
			get
			{
				return _filterLevel;
			}
			set
			{
				_filterLevel = value;
			}
		}

		public FormatterAssemblyStyle AssemblyFormat
		{
			get
			{
				return _assemblyFormat;
			}
			set
			{
				_assemblyFormat = value;
			}
		}

		public FormatterTypeStyle TypeFormat
		{
			get
			{
				return _typeFormat;
			}
			set
			{
				_typeFormat = value;
			}
		}

	}

}
