using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace IORead
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "IO", "IORead", TypeComplexityEnum.Complex)]
	public partial class IO : Vortex.Connector.IVortexObject, IIO, IShadowIO, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _g_ReadIO;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool g_ReadIO
		{
			get
			{
				return _g_ReadIO;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IIO.g_ReadIO
		{
			get
			{
				return g_ReadIO;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowIO.g_ReadIO
		{
			get
			{
				return g_ReadIO;
			}
		}

		public void LazyOnlineToShadow()
		{
			g_ReadIO.Shadow = g_ReadIO.LastValue;
		}

		public void LazyShadowToOnline()
		{
			g_ReadIO.Cyclic = g_ReadIO.Shadow;
		}

		public PlainIO CreatePlainerType()
		{
			var cloned = new PlainIO();
			return cloned;
		}

		protected PlainIO CreatePlainerType(PlainIO cloned)
		{
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

		public void FlushPlainToOnline(IORead.PlainIO source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(IORead.PlainIO source)
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

		public void FlushOnlineToPlain(IORead.PlainIO source)
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

		public IO(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_g_ReadIO = @Connector.Online.Adapter.CreateBOOL(this, "", "g_ReadIO");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public IO()
		{
			PexPreConstructorParameterless();
			_g_ReadIO = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcIO
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcIO()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IIO : Vortex.Connector.IVortexOnlineObject
	{
		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool g_ReadIO
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainIO CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(IORead.PlainIO source);
		void FlushOnlineToPlain(IORead.PlainIO source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowIO : Vortex.Connector.IVortexShadowObject
	{
		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool g_ReadIO
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainIO CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(IORead.PlainIO source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainIO : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _g_ReadIO;
		[IoLinkable("Inputs")]
		public System.Boolean g_ReadIO
		{
			get
			{
				return _g_ReadIO;
			}

			set
			{
				if (_g_ReadIO != value)
				{
					_g_ReadIO = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(g_ReadIO)));
				}
			}
		}

		public void CopyPlainToCyclic(IORead.IO target)
		{
			target.g_ReadIO.Cyclic = g_ReadIO;
		}

		public void CopyPlainToCyclic(IORead.IIO target)
		{
			this.CopyPlainToCyclic((IORead.IO)target);
		}

		public void CopyPlainToShadow(IORead.IO target)
		{
			target.g_ReadIO.Shadow = g_ReadIO;
		}

		public void CopyPlainToShadow(IORead.IShadowIO target)
		{
			this.CopyPlainToShadow((IORead.IO)target);
		}

		public void CopyCyclicToPlain(IORead.IO source)
		{
			g_ReadIO = source.g_ReadIO.LastValue;
		}

		public void CopyCyclicToPlain(IORead.IIO source)
		{
			this.CopyCyclicToPlain((IORead.IO)source);
		}

		public void CopyShadowToPlain(IORead.IO source)
		{
			g_ReadIO = source.g_ReadIO.Shadow;
		}

		public void CopyShadowToPlain(IORead.IShadowIO source)
		{
			this.CopyShadowToPlain((IORead.IO)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainIO()
		{
		}
	}
}