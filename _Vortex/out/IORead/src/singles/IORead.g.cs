using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using IOReadConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"SystemTest\",\r\n      \"Namespace\": \"IORead\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"StReadIO\",\r\n      \"Namespace\": \"IORead\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"IO\",\r\n      \"Namespace\": \"IORead\",\r\n      \"TypeMetaInfo\": 0\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN\",\r\n      \"Namespace\": \"IORead\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"IORead\",\r\n  \"Namespace\": \"IORead\"\r\n}")]
namespace IORead
{
	public partial class IOReadTwinController : Vortex.Connector.ITwinController, IIOReadTwinController, IShadowIOReadTwinController
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return IOReadTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		IO _IO;
		public IO IO
		{
			get
			{
				return _IO;
			}
		}

		IIO IIOReadTwinController.IO
		{
			get
			{
				return IO;
			}
		}

		IShadowIO IShadowIOReadTwinController.IO
		{
			get
			{
				return IO;
			}
		}

		MAIN _MAIN;
		public MAIN MAIN
		{
			get
			{
				return _MAIN;
			}
		}

		IMAIN IIOReadTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		IShadowMAIN IShadowIOReadTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		public void LazyOnlineToShadow()
		{
			IO.LazyOnlineToShadow();
			MAIN.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			IO.LazyShadowToOnline();
			MAIN.LazyShadowToOnline();
		}

		public PlainIOReadTwinController CreatePlainerType()
		{
			var cloned = new PlainIOReadTwinController();
			cloned.IO = IO.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		protected PlainIOReadTwinController CreatePlainerType(PlainIOReadTwinController cloned)
		{
			cloned.IO = IO.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			return cloned;
		}

		public System.String AttributeName
		{
			get
			{
				return IOReadTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public IIOReadTwinController Online
		{
			get
			{
				return (IIOReadTwinController)this;
			}
		}

		public IShadowIOReadTwinController Shadow
		{
			get
			{
				return (IShadowIOReadTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public IOReadTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_IO = new IO(this.Connector, "", "IO");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public IOReadTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_IO = new IO(this.Connector, "", "IO");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public IOReadTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_IO = new IO(this.Connector, "", "IO");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
		}

		public static string LocalizationDirectory
		{
			get;
			set;
		}

		private static Vortex.Localizations.Abstractions.ITranslator _translator
		{
			get;
			set;
		}

		internal static Vortex.Localizations.Abstractions.ITranslator Translator
		{
			get
			{
				if (_translator == null)
				{
					_translator = Vortex.Localizations.Abstractions.ITranslator.Get(typeof (Localizations));
				} return  _translator ; 

			}
		}
	}

	public partial interface IIOReadTwinController
	{
		IIO IO
		{
			get;
		}

		IMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainIOReadTwinController CreatePlainerType();
	}

	public partial interface IShadowIOReadTwinController
	{
		IShadowIO IO
		{
			get;
		}

		IShadowMAIN MAIN
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainIOReadTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainIOReadTwinController : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainIO _IO;
		public PlainIO IO
		{
			get
			{
				return _IO;
			}

			set
			{
				if (_IO != value)
				{
					_IO = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(IO)));
				}
			}
		}

		PlainMAIN _MAIN;
		public PlainMAIN MAIN
		{
			get
			{
				return _MAIN;
			}

			set
			{
				if (_MAIN != value)
				{
					_MAIN = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MAIN)));
				}
			}
		}

		public void CopyPlainToCyclic(IORead.IOReadTwinController target)
		{
			IO.CopyPlainToCyclic(target.IO);
			MAIN.CopyPlainToCyclic(target.MAIN);
		}

		public void CopyPlainToCyclic(IORead.IIOReadTwinController target)
		{
			this.CopyPlainToCyclic((IORead.IOReadTwinController)target);
		}

		public void CopyPlainToShadow(IORead.IOReadTwinController target)
		{
			IO.CopyPlainToShadow(target.IO);
			MAIN.CopyPlainToShadow(target.MAIN);
		}

		public void CopyPlainToShadow(IORead.IShadowIOReadTwinController target)
		{
			this.CopyPlainToShadow((IORead.IOReadTwinController)target);
		}

		public void CopyCyclicToPlain(IORead.IOReadTwinController source)
		{
			IO.CopyCyclicToPlain(source.IO);
			MAIN.CopyCyclicToPlain(source.MAIN);
		}

		public void CopyCyclicToPlain(IORead.IIOReadTwinController source)
		{
			this.CopyCyclicToPlain((IORead.IOReadTwinController)source);
		}

		public void CopyShadowToPlain(IORead.IOReadTwinController source)
		{
			IO.CopyShadowToPlain(source.IO);
			MAIN.CopyShadowToPlain(source.MAIN);
		}

		public void CopyShadowToPlain(IORead.IShadowIOReadTwinController source)
		{
			this.CopyShadowToPlain((IORead.IOReadTwinController)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainIOReadTwinController()
		{
			_IO = new PlainIO();
			_MAIN = new PlainMAIN();
		}
	}
}