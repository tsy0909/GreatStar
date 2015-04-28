using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace ExchangeRateTableBE
{
	
	/// <summary>
	/// 实体: 汇率表头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ExchangeRateTable : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ExchangeRateTable(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static ExchangeRateTable Create() {
			ExchangeRateTable entity = (ExchangeRateTable)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																														 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ExchangeRateTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static ExchangeRateTable CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static ExchangeRateTable CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "ExchangeRateTableBE.ExchangeRateTable"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("ExchangeRateTableBE.ExchangeRateTable");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ExchangeRateTable EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "ExchangeRateTableBE.ExchangeRateTable")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ExchangeRateTable GetEntity()
			{
				return (ExchangeRateTable)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ExchangeRateTable> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ExchangeRateTable>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private ExchangeRateTable ContainerEntity ;
		    public  new ExchangeRateTable ContainerEntity 
		    {
				get { return  (ExchangeRateTable)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ExchangeRateTable container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 汇率表头.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 汇率表头.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 汇率表头.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 汇率表头.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 汇率表头.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 汇率表头.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性可为空,且无默认值)
			/// 汇率表头.Misc.组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Organization
			{
				get
				{
					if (OrganizationKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)OrganizationKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrganizationKey ;
		/// <summary>
		/// EntityKey 属性
		/// 组织 的Key (该属性可为空,且无默认值)
		/// 汇率表头.Misc.组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrganizationKey
		{
			get 
			{
				object obj = base.GetValue("Organization") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrganizationKey==null || m_OrganizationKey.ID != key )
					m_OrganizationKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrganizationKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 原币 (该属性可为空,且无默认值)
			/// 汇率表头.Misc.原币
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency OriginalCurrency
			{
				get
				{
					if (OriginalCurrencyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)OriginalCurrencyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_OriginalCurrencyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 原币 的Key (该属性可为空,且无默认值)
		/// 汇率表头.Misc.原币
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey OriginalCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("OriginalCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OriginalCurrencyKey==null || m_OriginalCurrencyKey.ID != key )
					m_OriginalCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_OriginalCurrencyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 目标币 (该属性可为空,且无默认值)
			/// 汇率表头.Misc.目标币
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency TargetCurrency
			{
				get
				{
					if (TargetCurrencyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)TargetCurrencyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_TargetCurrencyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 目标币 的Key (该属性可为空,且无默认值)
		/// 汇率表头.Misc.目标币
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey TargetCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("TargetCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TargetCurrencyKey==null || m_TargetCurrencyKey.ID != key )
					m_TargetCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_TargetCurrencyKey ;
			}
		}

		

			#endregion

			#region List member						
		
			
			private List<ExchangeRateTableBE.ExchangeRateTableLine> m_ExchangeRateTableLine  ;
			/// <summary>
			/// 汇率表行 (该属性可为空,且无默认值)
			/// 汇率表头.Misc.汇率表行
			/// </summary>
			/// <value></value>
			public  List<ExchangeRateTableBE.ExchangeRateTableLine> ExchangeRateTableLine
			{
				get
				{
					if (m_ExchangeRateTableLine == null)
						m_ExchangeRateTableLine = new List<ExchangeRateTableBE.ExchangeRateTableLine>();
					m_ExchangeRateTableLine.Clear();	
					foreach (ExchangeRateTableBE.ExchangeRateTableLine child in ContainerEntity.ExchangeRateTableLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_ExchangeRateTableLine.Add(child);
					}
					foreach (ExchangeRateTableBE.ExchangeRateTableLine child in ContainerEntity.ExchangeRateTableLine.DelLists)
					{
						m_ExchangeRateTableLine.Add(child);
					}
					return m_ExchangeRateTableLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 汇率表头.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 汇率表头.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 汇率表头.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 汇率表头.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 汇率表头.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 汇率表头.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 汇率表头.Misc.组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Organization
		{
			get
			{
				object  obj = this.GetRelation("Organization");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Organization.Organization value  = (UFIDA.U9.Base.Organization.Organization)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Organization", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrganizationKey ;
		/// <summary>
		/// 组织 的Key (该属性可为空,且无默认值)
		/// 汇率表头.Misc.组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrganizationKey
		{
			get 
			{
				object obj = base.GetValue("Organization") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrganizationKey==null || m_OrganizationKey.ID != key )
					m_OrganizationKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrganizationKey ;
			}
			set
			{	
				if (OrganizationKey==value)
					return ;
				this.SetRelation("Organization", null);
				m_OrganizationKey = value ;
				if (value != null) 
				{
					base.SetValue("Organization",value.ID);
				}
				else
					base.SetValue("Organization",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 原币 (该属性可为空,且无默认值)
		/// 汇率表头.Misc.原币
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency OriginalCurrency
		{
			get
			{
				object  obj = this.GetRelation("OriginalCurrency");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Currency.Currency value  = (UFIDA.U9.Base.Currency.Currency)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("OriginalCurrency", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_OriginalCurrencyKey ;
		/// <summary>
		/// 原币 的Key (该属性可为空,且无默认值)
		/// 汇率表头.Misc.原币
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey OriginalCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("OriginalCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OriginalCurrencyKey==null || m_OriginalCurrencyKey.ID != key )
					m_OriginalCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_OriginalCurrencyKey ;
			}
			set
			{	
				if (OriginalCurrencyKey==value)
					return ;
				this.SetRelation("OriginalCurrency", null);
				m_OriginalCurrencyKey = value ;
				if (value != null) 
				{
					base.SetValue("OriginalCurrency",value.ID);
				}
				else
					base.SetValue("OriginalCurrency",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 目标币 (该属性可为空,且无默认值)
		/// 汇率表头.Misc.目标币
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency TargetCurrency
		{
			get
			{
				object  obj = this.GetRelation("TargetCurrency");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Currency.Currency value  = (UFIDA.U9.Base.Currency.Currency)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("TargetCurrency", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_TargetCurrencyKey ;
		/// <summary>
		/// 目标币 的Key (该属性可为空,且无默认值)
		/// 汇率表头.Misc.目标币
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey TargetCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("TargetCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TargetCurrencyKey==null || m_TargetCurrencyKey.ID != key )
					m_TargetCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_TargetCurrencyKey ;
			}
			set
			{	
				if (TargetCurrencyKey==value)
					return ;
				this.SetRelation("TargetCurrency", null);
				m_TargetCurrencyKey = value ;
				if (value != null) 
				{
					base.SetValue("TargetCurrency",value.ID);
				}
				else
					base.SetValue("TargetCurrency",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

	

		#endregion

		#region List member						
	
		
		private ExchangeRateTableBE.ExchangeRateTableLine.EntityList m_ExchangeRateTableLine  ;
		/// <summary>
		/// 汇率表行 (该属性可为空,且无默认值)
		/// 汇率表头.Misc.汇率表行
		/// </summary>
		/// <value></value>
		public  ExchangeRateTableBE.ExchangeRateTableLine.EntityList ExchangeRateTableLine
		{
			get
			{
				if (m_ExchangeRateTableLine == null)
					m_ExchangeRateTableLine = new ExchangeRateTableBE.ExchangeRateTableLine.EntityList("ExchangeRateTable",this,"ExchangeRateTableLine",(IList)this.GetRelation("ExchangeRateTableLine"));
				else
					m_ExchangeRateTableLine.InnerList = (IList)this.GetRelation("ExchangeRateTableLine");
				return m_ExchangeRateTableLine;
			}
		}
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("ExchangeRateTableBE.ExchangeRateTable")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Organization")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Organization　{ get { return EntityRes.GetResource("Organization");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OriginalCurrency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OriginalCurrency　{ get { return EntityRes.GetResource("OriginalCurrency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TargetCurrency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TargetCurrency　{ get { return EntityRes.GetResource("TargetCurrency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExchangeRateTableLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExchangeRateTableLine　{ get { return EntityRes.GetResource("ExchangeRateTableLine");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ExchangeRateTable";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "ExchangeRateTableBE.ExchangeRateTable";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Organization　{ get { return "Organization";　}　}
				
			/// <summary>
			/// 属性: 原币 的名称
			/// </summary>
			public static string OriginalCurrency　{ get { return "OriginalCurrency";　}　}
				
			/// <summary>
			/// 属性: 目标币 的名称
			/// </summary>
			public static string TargetCurrency　{ get { return "TargetCurrency";　}　}
				
			/// <summary>
			/// 属性: 汇率表行 的名称
			/// </summary>
			public static string ExchangeRateTableLine　{ get { return "ExchangeRateTableLine";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																				
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("Organization","Organization");
			this.exdMultiLangAttrs.Add("OriginalCurrency","OriginalCurrency");
			this.exdMultiLangAttrs.Add("TargetCurrency","TargetCurrency");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																											

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(ExchangeRateTableData data)
		{
		
			

			

			

			

			

			

			if (data.Organization == -1 && data.Organization_SKey!=null)
				data.Organization = data.Organization_SKey.GetEntity().ID ;
	

			if (data.OriginalCurrency == -1 && data.OriginalCurrency_SKey!=null)
				data.OriginalCurrency = data.OriginalCurrency_SKey.GetEntity().ID ;
	

			if (data.TargetCurrency == -1 && data.TargetCurrency_SKey!=null)
				data.TargetCurrency = data.TargetCurrency_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ExchangeRateTableData data = dto as ExchangeRateTableData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ExchangeRateTableData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ExchangeRateTableData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
								this.SetTypeValue("Organization",data.Organization);
		
								this.SetTypeValue("OriginalCurrency",data.OriginalCurrency);
		
								this.SetTypeValue("TargetCurrency",data.TargetCurrency);
		
			#endregion 

			#region 组件内属性
	
					if (data.ExchangeRateTableLine != null)
			{	
				foreach(ExchangeRateTableBE.ExchangeRateTableLineData obj in data.ExchangeRateTableLine )
				{
					ExchangeRateTableBE.ExchangeRateTableLine child = dict[obj] as ExchangeRateTableBE.ExchangeRateTableLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (ExchangeRateTableBE.ExchangeRateTableLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (ExchangeRateTableBE.ExchangeRateTableLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (ExchangeRateTableBE.ExchangeRateTableLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.ExchangeRateTableLine.Remove(child);
						this.ExchangeRateTableLine.DelLists.Add(child);
					}
					else
						this.ExchangeRateTableLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ExchangeRateTableData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ExchangeRateTableData ToEntityData(ExchangeRateTableData data, IDictionary dict){
			if (data == null)
				data = new ExchangeRateTableData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["ExchangeRateTableBE.ExchangeRateTable"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Organization");
				if (obj != null)
					data.Organization=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OriginalCurrency");
				if (obj != null)
					data.OriginalCurrency=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TargetCurrency");
				if (obj != null)
					data.TargetCurrency=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.ExchangeRateTableLine != null)
			{	
				List<ExchangeRateTableBE.ExchangeRateTableLineData> listExchangeRateTableLine = new List<ExchangeRateTableBE.ExchangeRateTableLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(ExchangeRateTableBE.ExchangeRateTableLine obj in this.ExchangeRateTableLine ){
					if (obj == null)
						continue;
					ExchangeRateTableBE.ExchangeRateTableLineData old = dict["ExchangeRateTableBE.ExchangeRateTableLine"+obj.ID.ToString()] as ExchangeRateTableBE.ExchangeRateTableLineData;
					listExchangeRateTableLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.ExchangeRateTableLine = listExchangeRateTableLine;
			}	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        










			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}