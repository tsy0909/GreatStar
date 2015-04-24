﻿

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;
using UFIDA.U9.Cust.GS.FT.AllEnumBE;

#endregion

namespace UFIDA.U9.Cust.GS.FT.InstalledArkBE
{

    public partial class InstalledArkHead
    {

        #region Custom Constructor

        public override UFIDA.U9.Base.Doc.DocType DocType
        {
            get
            {
                return this.DocumentType;//DocType为单据上的单据类型属性名
            }
        }
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
            if (this.Org == null)
                this.Org = UFIDA.U9.Base.Context.LoginOrg;
        }
        /// <summary>
        /// before Insert
        /// </summary>
        protected override void OnInserting()
        {
            base.OnInserting();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// after Insert
        /// </summary>
        protected override void OnInserted()
        {
            //预装柜表产生后，根据发票号所对应的出运明细单行产生出运差异表中的计划数据，

            base.OnInserted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// before Update
        /// </summary>
        protected override void OnUpdating()
        {
            base.OnUpdating();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// after Update
        /// </summary>
        protected override void OnUpdated()
        {
            base.OnUpdated();
            // TO DO: write your business code here...
        }


        /// <summary>
        /// before Delete
        /// </summary>
        protected override void OnDeleting()
        {
            ShipPlanDetailHead.EntityList headList = ShipPlanDetailHead.Finder.FindAll("BillNoItem=" + this.BillNoItemHead.ID + "");
            foreach (ShipPlanDetailHead head in headList)
            {
                if (head.ShipPlanState == ShipPlanStateEnum.IssuedStorage)
                {
                    throw new Exception("出运明细单" + head.DocNo + "已下发仓库无法取消预装柜");
                }
                foreach (ShipPlanDetailLine line in head.ShipPlanDetailLine)
                {
                    if (line.IsWms)
                        throw new Exception("出运明细单" + head.DocNo + "行" + line.RowNo + "已同步WMS，不能取消预装柜");
                    line.IsShipping = false;
                }
            }
            base.OnDeleting();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// after Delete
        /// </summary>
        protected override void OnDeleted()
        {
            base.OnDeleted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// on Validate
        /// </summary>
        protected override void OnValidate()
        {
            base.OnValidate();
            this.SelfEntityValidator();
            // TO DO: write your business code here...
        }
        #endregion

        #region 异常处理，开发人员可以重新封装异常
        public override void DealException(Exception e)
        {
            base.DealException(e);
            throw e;
        }
        #endregion

        #region  扩展属性代码区

        #endregion

        #region CreateDefault
        private static InstalledArkHead CreateDefault_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create DefaultComponent
        /// </summary>
        /// <returns>DefaultComponent Instance</returns>
        private static InstalledArkHead CreateDefaultComponent_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }

        #endregion






        #region Model Methods
        #endregion
    }
}