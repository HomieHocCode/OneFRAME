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
    public class DanhMucQuocGiaProcessBll : DanhMucQuocGiaTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucQuocGiaProcessBll";
            }
        }

        public override DanhMucQuocGiaCls[] Reading(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Reading(ActionSqlParam, ODanhMucQuocGiaFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucQuocGiaCls ODanhMucQuocGia)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Add(ActionSqlParam, ODanhMucQuocGia);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucQuocGiaCls ODanhMucQuocGia)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Save(ActionSqlParam, Id, ODanhMucQuocGia);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucQuocGiaCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucQuocGiaCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().ReadingWithPaging(ActionSqlParam, ODanhMucQuocGiaFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().Count(ActionSqlParam, ODanhMucQuocGiaFilter);
        }
        public override DanhMucQuocGiaCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().PageReading(ActionSqlParam, ODanhMucQuocGiaFilter, ref recordTotal);
        }
        public override DanhMucQuocGiaCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
