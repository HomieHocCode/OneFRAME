using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;
using OneFRAME.Call.Bussiness.Template;
using OneFRAME.Utility;
using OneFRAME.Bussiness.Utility;

namespace OneFRAME.Call.Bussiness.Sql
{
    public class DanhMucICDChuongProcessBll : DanhMucICDChuongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucICDChuongProcessBll";
            }
        }

        public override DanhMucICDChuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().Reading(ActionSqlParam, ODanhMucICDChuongFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucICDChuongCls ODanhMucICDChuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
             OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().Add(ActionSqlParam, ODanhMucICDChuong);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucICDChuongCls ODanhMucICDChuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().Save(ActionSqlParam, Id, ODanhMucICDChuong);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucICDChuongCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucICDChuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().ReadingWithPaging(ActionSqlParam, ODanhMucICDChuongFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().Count(ActionSqlParam, ODanhMucICDChuongFilter);
        }
        public override DanhMucICDChuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().PageReading(ActionSqlParam, ODanhMucICDChuongFilter, ref recordTotal);
        }
        public override DanhMucICDChuongCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
