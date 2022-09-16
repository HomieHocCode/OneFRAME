using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;
using OneLIS.Call.Bussiness.Template;
using OneLIS.Utility;
using OneLIS.Bussiness.Utility;

namespace OneLIS.Call.Bussiness.Sql
{
    public class DanhMucChiDinhMauChiTietProcessBll : DanhMucChiDinhMauChiTietTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucChiDinhMauChiTietProcessBll";
            }
        }

        public override DanhMucChiDinhMauChiTietCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauChiTietFilterCls ODanhMucChiDinhMauChiTietFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().Reading(ActionSqlParam, ODanhMucChiDinhMauChiTietFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucChiDinhMauChiTietCls ODanhMucChiDinhMauChiTiet)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().Add(ActionSqlParam, ODanhMucChiDinhMauChiTiet);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string DichVuId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().Delete(ActionSqlParam, ChiSoId, DichVuId);
        }

        public override DanhMucChiDinhMauChiTietCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string[] ChiSoIdByDichVuId(RenderInfoCls ORenderInfo, string dichvuid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().ChiSoIdByDichVuId(ActionSqlParam, dichvuid);
        }

        public override DanhMucChiDinhMauChiTietCls[] ChiSo(RenderInfoCls ORenderInfo)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().ChiSo(ActionSqlParam);
        }

        public override string[] GetChiSoIdsByParentId(RenderInfoCls ORenderInfo, string ParentId)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().GetChiSoIdsByParentId(ActionSqlParam, ParentId);
        }
        public override DanhMucChiDinhMauChiTietCls[] ReadingChiSoByDichVu(RenderInfoCls ORenderInfo, string dichvuid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauChiTietProcess().ReadingChiSoByDichVu(ActionSqlParam, dichvuid);
        }
    }
}
