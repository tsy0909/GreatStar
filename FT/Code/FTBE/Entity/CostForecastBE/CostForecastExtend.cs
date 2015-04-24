﻿

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;

#endregion

namespace UFIDA.U9.Cust.GS.FT.CostForecastBE {

	public partial class CostForecast{

		#region Custom Constructor

		#endregion

		#region before & after CUD V 
		/*	实体提交的事件顺序示例(QHELP) 主实体A 组合 非主实体B .
		/ (新增A和B两个实例)A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnInserting ->B.OnInserting ->产生提交SQL ->B.OnInserted ->A.OnInserted
		/ (仅修改B,A也会被修改))A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnUpdating ->B.OnUpdating ->产生提交SQL ->B.OnUpdated ->A.OnUpdated
		/ (删除A,B会被级联删除))A.OnDeleting ->B.OnDeleting ->产生提交SQL ->B.OnDeleted ->A.OnDeleted
		/	产生提交SQL顺序则看其外键，增修一对多先A后B，一对一先B后A。　删除一对多先B后A，一对一先A后B .
		*/	
		/// <summary>
		/// 设置默认值
		/// </summary>
		protected override void OnSetDefaultValue()
		{
			base.OnSetDefaultValue();
		}
		/// <summary>
		/// before Insert
		/// </summary>
		protected override void OnInserting() {
			base.OnInserting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
            using (ISession sesion = Session.Open())
            {
                if (this.SOLine != null)
                {
                    SM.SO.SOLine line = SM.SO.SOLine.Finder.FindByID(this.SOLine.ID);
                    if (line != null)
                        line.DescFlexField.PrivateDescSeg18 = AllEnumBE.ForecastStateEnum.Y.Name.ToString();
                }
                sesion.Commit();
            }
			base.OnInserted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
			base.OnUpdated();
			// TO DO: write your business code here...
		}


		/// <summary>
		/// before Delete
		/// </summary>
		protected override void OnDeleting() {
			base.OnDeleting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Delete
		/// </summary>
		protected override void OnDeleted() {
            using (ISession session = Session.Open())
            {
                if (this.OriginalData.SOLine != null)
                {
                    CostForecastBE.CostForecast.EntityList lineList = CostForecastBE.CostForecast.Finder.FindAll("SOLine=" + this.OriginalData.SOLine.ID + "");
                    SM.SO.SOLine line = SM.SO.SOLine.Finder.FindByID(this.OriginalData.SOLine.ID);
                    if (line != null)
                    {
                        if (lineList == null || lineList.Count == 0)
                        {
                            line.DescFlexField.PrivateDescSeg18 = AllEnumBE.ForecastStateEnum.N.Name.ToString();
                        }
                        else
                        {
                            line.DescFlexField.PrivateDescSeg18 = AllEnumBE.ForecastStateEnum.Y.Name.ToString();
                        }
                    }

                }
                session.Commit();
            }
			base.OnDeleted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
			base.OnValidate();
			this.SelfEntityValidator();
			// TO DO: write your business code here...
		}
		#endregion
		
		#region 异常处理，开发人员可以重新封装异常
		public override void  DealException(Exception e)
        	{
          		base.DealException(e);
          		throw e;
        	}
		#endregion

		#region  扩展属性代码区
		
		#endregion

		#region CreateDefault
		private static CostForecast CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static CostForecast CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods
		#endregion		
	}
}