﻿using System;
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
    public class DanhMucKyThuatXetNghiemProcessBll : DanhMucKyThuatXetNghiemTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucKyThuatXetNghiemProcessBll";
            }
        }

        public override DanhMucKyThuatXetNghiemCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().Reading(ActionSqlParam, ODanhMucKyThuatXetNghiemFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().Add(ActionSqlParam, ODanhMucKyThuatXetNghiem);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().Save(ActionSqlParam, Id, ODanhMucKyThuatXetNghiem);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucKyThuatXetNghiemCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucKyThuatXetNghiemCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().PageReading(ActionSqlParam, ODanhMucKyThuatXetNghiemFilter, ref recordTotal);
        }

        public override DanhMucKyThuatXetNghiemCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().ReadingWithPaging(ActionSqlParam, ODanhMucKyThuatXetNghiemFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKyThuatXetNghiemProcess().Count(ActionSqlParam, ODanhMucKyThuatXetNghiemFilter);
        }
    }
}
