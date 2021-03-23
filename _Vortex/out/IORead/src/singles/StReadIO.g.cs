using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace IORead
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "StReadIO", "IORead", TypeComplexityEnum.Complex)]
	public partial class StReadIO : Vortex.Connector.IVortexObject, IStReadIO, IShadowStReadIO, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _st_ReadIO;
		public Vortex.Connector.ValueTypes.OnlinerBool st_ReadIO
		{
			get
			{
				return _st_ReadIO;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStReadIO.st_ReadIO
		{
			get
			{
				return st_ReadIO;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStReadIO.st_ReadIO
		{
			get
			{
				return st_ReadIO;
			}
		}

		public void LazyOnlineToShadow()
		{
			st_ReadIO.Shadow = st_ReadIO.LastValue;
		}

		public void LazyShadowToOnline()
		{
			st_ReadIO.Cyclic = st_ReadIO.Shadow;
		}

		public PlainStReadIO CreatePlainerType()
		{
			var cloned = new PlainStReadIO();
			return cloned;
		}

		protected PlainStReadIO CreatePlainerType(PlainStReadIO cloned)
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

		public void FlushPlainToOnline(IORead.PlainStReadIO source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(IORead.PlainStReadIO source)
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

		public void FlushOnlineToPlain(IORead.PlainStReadIO source)
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

		public StReadIO(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_st_ReadIO = @Connector.Online.Adapter.CreateBOOL(this, "<#Actual IO Staus #>", "st_ReadIO");
			st_ReadIO.AttributeName = "<#Actual IO Staus #>";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public StReadIO()
		{
			PexPreConstructorParameterless();
			_st_ReadIO = Vortex.Connector.IConnectorFactory.CreateBOOL();
			st_ReadIO.AttributeName = "<#Actual IO Staus #>";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcStReadIO
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcStReadIO()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IStReadIO : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool st_ReadIO
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainStReadIO CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(IORead.PlainStReadIO source);
		void FlushOnlineToPlain(IORead.PlainStReadIO source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowStReadIO : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool st_ReadIO
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		IORead.PlainStReadIO CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(IORead.PlainStReadIO source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStReadIO : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _st_ReadIO;
		public System.Boolean st_ReadIO
		{
			get
			{
				return _st_ReadIO;
			}

			set
			{
				if (_st_ReadIO != value)
				{
					_st_ReadIO = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(st_ReadIO)));
				}
			}
		}

		public void CopyPlainToCyclic(IORead.StReadIO target)
		{
			target.st_ReadIO.Cyclic = st_ReadIO;
		}

		public void CopyPlainToCyclic(IORead.IStReadIO target)
		{
			this.CopyPlainToCyclic((IORead.StReadIO)target);
		}

		public void CopyPlainToShadow(IORead.StReadIO target)
		{
			target.st_ReadIO.Shadow = st_ReadIO;
		}

		public void CopyPlainToShadow(IORead.IShadowStReadIO target)
		{
			this.CopyPlainToShadow((IORead.StReadIO)target);
		}

		public void CopyCyclicToPlain(IORead.StReadIO source)
		{
			st_ReadIO = source.st_ReadIO.LastValue;
		}

		public void CopyCyclicToPlain(IORead.IStReadIO source)
		{
			this.CopyCyclicToPlain((IORead.StReadIO)source);
		}

		public void CopyShadowToPlain(IORead.StReadIO source)
		{
			st_ReadIO = source.st_ReadIO.Shadow;
		}

		public void CopyShadowToPlain(IORead.IShadowStReadIO source)
		{
			this.CopyShadowToPlain((IORead.StReadIO)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainStReadIO()
		{
		}
	}
}