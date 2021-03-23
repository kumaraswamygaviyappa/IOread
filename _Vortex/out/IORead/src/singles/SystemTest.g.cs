using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace IORead
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "SystemTest", "IORead", TypeComplexityEnum.Complex)]
	public partial class SystemTest : Vortex.Connector.IVortexObject, ISystemTest, IShadowSystemTest, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		public void LazyOnlineToShadow()
		{
		}

		public void LazyShadowToOnline()
		{
		}

		public PlainSystemTest CreatePlainerType()
		{
			var cloned = new PlainSystemTest();
			return cloned;
		}

		protected PlainSystemTest CreatePlainerType(PlainSystemTest cloned)
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

		public void FlushPlainToOnline(IORead.PlainSystemTest source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(IORead.PlainSystemTest source)
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

		public void FlushOnlineToPlain(IORead.PlainSystemTest source)
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

		public SystemTest(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public SystemTest()
		{
			PexPreConstructorParameterless();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcSystemTest
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcSystemTest()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ISystemTest : Vortex.Connector.IVortexOnlineObject
	{
		System.String AttributeName
		{
			get;
		}

		IORead.PlainSystemTest CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(IORead.PlainSystemTest source);
		void FlushOnlineToPlain(IORead.PlainSystemTest source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowSystemTest : Vortex.Connector.IVortexShadowObject
	{
		System.String AttributeName
		{
			get;
		}

		IORead.PlainSystemTest CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(IORead.PlainSystemTest source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSystemTest : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		public void CopyPlainToCyclic(IORead.SystemTest target)
		{
		}

		public void CopyPlainToCyclic(IORead.ISystemTest target)
		{
			this.CopyPlainToCyclic((IORead.SystemTest)target);
		}

		public void CopyPlainToShadow(IORead.SystemTest target)
		{
		}

		public void CopyPlainToShadow(IORead.IShadowSystemTest target)
		{
			this.CopyPlainToShadow((IORead.SystemTest)target);
		}

		public void CopyCyclicToPlain(IORead.SystemTest source)
		{
		}

		public void CopyCyclicToPlain(IORead.ISystemTest source)
		{
			this.CopyCyclicToPlain((IORead.SystemTest)source);
		}

		public void CopyShadowToPlain(IORead.SystemTest source)
		{
		}

		public void CopyShadowToPlain(IORead.IShadowSystemTest source)
		{
			this.CopyShadowToPlain((IORead.SystemTest)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainSystemTest()
		{
		}
	}
}