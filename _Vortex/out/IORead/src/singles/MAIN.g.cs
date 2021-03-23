using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace IORead
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "IORead", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		StReadIO _MainReadIO;
		public StReadIO MainReadIO
		{
			get
			{
				return _MainReadIO;
			}
		}

		IStReadIO IMAIN.MainReadIO
		{
			get
			{
				return MainReadIO;
			}
		}

		IShadowStReadIO IShadowMAIN.MainReadIO
		{
			get
			{
				return MainReadIO;
			}
		}

		SystemTest _FB_SystemTest;
		public SystemTest FB_SystemTest
		{
			get
			{
				return _FB_SystemTest;
			}
		}

		ISystemTest IMAIN.FB_SystemTest
		{
			get
			{
				return FB_SystemTest;
			}
		}

		IShadowSystemTest IShadowMAIN.FB_SystemTest
		{
			get
			{
				return FB_SystemTest;
			}
		}

		public void LazyOnlineToShadow()
		{
			MainReadIO.LazyOnlineToShadow();
			FB_SystemTest.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			MainReadIO.LazyShadowToOnline();
			FB_SystemTest.LazyShadowToOnline();
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned.MainReadIO = MainReadIO.CreatePlainerType();
			cloned.FB_SystemTest = FB_SystemTest.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned.MainReadIO = MainReadIO.CreatePlainerType();
			cloned.FB_SystemTest = FB_SystemTest.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(IORead.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(IORead.PlainMAIN source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(IORead.PlainMAIN source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
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

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_MainReadIO = new StReadIO(this, "", "MainReadIO");
			_FB_SystemTest = new SystemTest(this, "", "FB_SystemTest");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			_MainReadIO = new StReadIO();
			_FB_SystemTest = new SystemTest();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		IStReadIO MainReadIO
		{
			get;
		}

		ISystemTest FB_SystemTest
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(IORead.PlainMAIN source);
		void FlushOnlineToPlain(IORead.PlainMAIN source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		IShadowStReadIO MainReadIO
		{
			get;
		}

		IShadowSystemTest FB_SystemTest
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(IORead.PlainMAIN source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainStReadIO _MainReadIO;
		public PlainStReadIO MainReadIO
		{
			get
			{
				return _MainReadIO;
			}

			set
			{
				if (_MainReadIO != value)
				{
					_MainReadIO = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MainReadIO)));
				}
			}
		}

		PlainSystemTest _FB_SystemTest;
		public PlainSystemTest FB_SystemTest
		{
			get
			{
				return _FB_SystemTest;
			}

			set
			{
				if (_FB_SystemTest != value)
				{
					_FB_SystemTest = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(FB_SystemTest)));
				}
			}
		}

		public void CopyPlainToCyclic(IORead.MAIN target)
		{
			MainReadIO.CopyPlainToCyclic(target.MainReadIO);
			FB_SystemTest.CopyPlainToCyclic(target.FB_SystemTest);
		}

		public void CopyPlainToCyclic(IORead.IMAIN target)
		{
			this.CopyPlainToCyclic((IORead.MAIN)target);
		}

		public void CopyPlainToShadow(IORead.MAIN target)
		{
			MainReadIO.CopyPlainToShadow(target.MainReadIO);
			FB_SystemTest.CopyPlainToShadow(target.FB_SystemTest);
		}

		public void CopyPlainToShadow(IORead.IShadowMAIN target)
		{
			this.CopyPlainToShadow((IORead.MAIN)target);
		}

		public void CopyCyclicToPlain(IORead.MAIN source)
		{
			MainReadIO.CopyCyclicToPlain(source.MainReadIO);
			FB_SystemTest.CopyCyclicToPlain(source.FB_SystemTest);
		}

		public void CopyCyclicToPlain(IORead.IMAIN source)
		{
			this.CopyCyclicToPlain((IORead.MAIN)source);
		}

		public void CopyShadowToPlain(IORead.MAIN source)
		{
			MainReadIO.CopyShadowToPlain(source.MainReadIO);
			FB_SystemTest.CopyShadowToPlain(source.FB_SystemTest);
		}

		public void CopyShadowToPlain(IORead.IShadowMAIN source)
		{
			this.CopyShadowToPlain((IORead.MAIN)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
			_MainReadIO = new PlainStReadIO();
			_FB_SystemTest = new PlainSystemTest();
		}
	}
}