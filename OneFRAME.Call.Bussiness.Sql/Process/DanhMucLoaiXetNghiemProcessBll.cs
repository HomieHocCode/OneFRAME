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
    public class DanhMucLoaiXetNghiemProcessBll : DanhMucLoaiXetNghiemTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucLoaiXetNghiemProcessBll";
            }
        }

        public override DanhMucLoaiXetNghiemCls[] Reading(RenderInfoCls ORenderInfo, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Reading(ActionSqlParam, ODanhMucLoaiXetNghiemFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Add(ActionSqlParam, ODanhMucLoaiXetNghiem);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Save(ActionSqlParam, Id, ODanhMucLoaiXetNghiem);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucLoaiXetNghiemCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucLoaiXetNghiemCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().PageReading(ActionSqlParam, ODanhMucLoaiXetNghiemFilter, ref recordTotal);
        }

        public override DanhMucLoaiXetNghiemCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().ReadingWithPaging(ActionSqlParam, ODanhMucLoaiXetNghiemFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Count(ActionSqlParam, ODanhMucLoaiXetNghiemFilter);
        }

        public override DanhMucLoaiXetNghiemCls[] Reading(SiteParam OSiteParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Reading(ActionSqlParam, ODanhMucLoaiXetNghiemFilter);
        }

        public override void Add(SiteParam OSiteParam, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Add(ActionSqlParam, ODanhMucLoaiXetNghiem);
        }

        public override void Save(SiteParam OSiteParam, string Id, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Save(ActionSqlParam, Id, ODanhMucLoaiXetNghiem);
        }

        public override void Delete(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucLoaiXetNghiemCls CreateModel(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucLoaiXetNghiemCls[] PageReading(SiteParam OSiteParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().PageReading(ActionSqlParam, ODanhMucLoaiXetNghiemFilter, ref recordTotal);
        }

        public override DanhMucLoaiXetNghiemCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().ReadingWithPaging(ActionSqlParam, ODanhMucLoaiXetNghiemFilter, PageIndex, PageSize);
        }

        public override long Count(SiteParam OSiteParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().Count(ActionSqlParam, ODanhMucLoaiXetNghiemFilter);
        }

        public override DanhMucLoaiXetNghiemCls CreateModel(string connectstring, string Id)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiXetNghiemProcess().CreateModel(connectstring, Id);
        }
    }
}
