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
    public class DanhMucQuanHuyenProcessBll : DanhMucQuanHuyenTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucQuanHuyenProcessBll";
            }
        }

        public override DanhMucQuanHuyenCls[] Reading(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Reading(ActionSqlParam, ODanhMucQuanHuyenFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucQuanHuyenCls ODanhMucQuanHuyen)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Add(ActionSqlParam, ODanhMucQuanHuyen);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucQuanHuyenCls ODanhMucQuanHuyen)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Save(ActionSqlParam, Id, ODanhMucQuanHuyen);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucQuanHuyenCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucQuanHuyenCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().ReadingWithPaging(ActionSqlParam, ODanhMucQuanHuyenFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Count(ActionSqlParam, ODanhMucQuanHuyenFilter);
        }
        public override DanhMucQuanHuyenCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().PageReading(ActionSqlParam, ODanhMucQuanHuyenFilter, ref recordTotal);
        }
        public override DanhMucQuanHuyenCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
