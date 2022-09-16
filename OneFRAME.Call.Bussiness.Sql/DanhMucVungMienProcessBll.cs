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
    public class DanhMucVungMienProcessBll : DanhMucVungMienTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucVungMienProcessBll";
            }
        }

        public override DanhMucVungMienCls[] Reading(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Reading(ActionSqlParam, ODanhMucVungMienFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucVungMienCls ODanhMucVungMien)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Add(ActionSqlParam, ODanhMucVungMien);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucVungMienCls ODanhMucVungMien)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Save(ActionSqlParam, Id, ODanhMucVungMien);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucVungMienCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucVungMienCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().ReadingWithPaging(ActionSqlParam, ODanhMucVungMienFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().Count(ActionSqlParam, ODanhMucVungMienFilter);
        }
        public override DanhMucVungMienCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().PageReading(ActionSqlParam, ODanhMucVungMienFilter, ref recordTotal);
        }
        public override DanhMucVungMienCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
