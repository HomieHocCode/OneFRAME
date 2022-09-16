using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;
using OneFRAME.Call.Bussiness.Template;
using OneFRAME.Utility;
using OneFRAME.Bussiness.Utility;

namespace OneFRAME.Call.Bussiness.Sql 
{
    public class DanhMucTinhThanhProcessBll : DanhMucTinhThanhTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucTinhThanhProcessBll";
            }
        }

        public override DanhMucTinhThanhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Reading(ActionSqlParam, ODanhMucTinhThanhFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucTinhThanhCls ODanhMucTinhThanh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Add(ActionSqlParam, ODanhMucTinhThanh);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucTinhThanhCls ODanhMucTinhThanh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Save(ActionSqlParam, Id, ODanhMucTinhThanh);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucTinhThanhCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucTinhThanhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().ReadingWithPaging(ActionSqlParam, ODanhMucTinhThanhFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().Count(ActionSqlParam, ODanhMucTinhThanhFilter);
        }
        public override DanhMucTinhThanhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().PageReading(ActionSqlParam, ODanhMucTinhThanhFilter, ref recordTotal);
        }
        public override DanhMucTinhThanhCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
