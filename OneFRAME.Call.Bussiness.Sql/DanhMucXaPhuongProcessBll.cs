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
    public class DanhMucXaPhuongProcessBll : DanhMucXaPhuongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucXaPhuongProcessBll";
            }
        }

        public override DanhMucXaPhuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Reading(ActionSqlParam, ODanhMucXaPhuongFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucXaPhuongCls ODanhMucXaPhuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Add(ActionSqlParam, ODanhMucXaPhuong);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucXaPhuongCls ODanhMucXaPhuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Save(ActionSqlParam, Id, ODanhMucXaPhuong);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucXaPhuongCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucXaPhuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().ReadingWithPaging(ActionSqlParam, ODanhMucXaPhuongFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Count(ActionSqlParam, ODanhMucXaPhuongFilter);
        }
        public override DanhMucXaPhuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, ref long  recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().PageReading(ActionSqlParam, ODanhMucXaPhuongFilter, ref  recordTotal);
        }
        public override DanhMucXaPhuongCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
