using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;
using OneFRAME.Call.Bussiness.Template;
using OneFRAME.Utility;
using OneFRAME.Bussiness.Utility;

namespace OneFRAME.Call.Bussiness.Ws
{
    public class UnitProcessBll : UnitTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlUnitProcessBll";
            }
        }


        public override UnitCls[] Reading(
            RenderInfoCls ORenderInfo,
            UnitFilterCls OUnitFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Reading(ActionSqlParam, OUnitFilter);
        }

        public override AjaxOut ReadingWithPage(RenderInfoCls ORenderInfo, UnitFilterCls OUnitFilter)
        {
            ActionSqlParamCls
               ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().ReadingWithPage(ActionSqlParam, OUnitFilter);
        }
        public override void Add(RenderInfoCls ORenderInfo, UnitCls OUnit)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Add(ActionSqlParam, OUnit);
        }

        public override void Save(RenderInfoCls ORenderInfo, string UnitId, UnitCls OUnit)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Save(ActionSqlParam, UnitId, OUnit);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string UnitId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Delete(ActionSqlParam, UnitId);
        }

        public override UnitCls CreateModel(RenderInfoCls ORenderInfo, string UnitId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().CreateModel(ActionSqlParam, UnitId);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string UnitId)
        {
            ActionSqlParamCls
               ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Duplicate(ActionSqlParam, UnitId);
        }
    }
}
