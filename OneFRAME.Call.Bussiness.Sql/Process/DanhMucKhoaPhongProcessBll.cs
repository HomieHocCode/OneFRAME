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
    public class DanhMucKhoaPhongProcessBll : DanhMucKhoaPhongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucKhoaPhongProcessBll";
            }
        }

        public override DanhMucKhoaPhongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Reading(ActionSqlParam, ODanhMucKhoaPhongFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucKhoaPhongCls ODanhMucKhoaPhong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Add(ActionSqlParam, ODanhMucKhoaPhong);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucKhoaPhongCls ODanhMucKhoaPhong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Save(ActionSqlParam, Id, ODanhMucKhoaPhong);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucKhoaPhongCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucKhoaPhongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().PageReading(ActionSqlParam, ODanhMucKhoaPhongFilter, ref recordTotal);
        }

        public override DanhMucKhoaPhongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().ReadingWithPaging(ActionSqlParam, ODanhMucKhoaPhongFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Count(ActionSqlParam, ODanhMucKhoaPhongFilter);
        }
        public override DanhMucKhoaPhongCls[] PageReading(RenderInfoCls ORenderInfo, string sqlContent, int PageIndex, int PageSize, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().PageReading(ActionSqlParam, sqlContent, PageIndex, PageSize, ref recordTotal);
        }

        public override DanhMucKhoaPhongCls[] Reading(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Reading(ActionSqlParam, ODanhMucKhoaPhongFilter);
        }

        public override void Add(SiteParam OSiteParam, DanhMucKhoaPhongCls ODanhMucKhoaPhong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Add(ActionSqlParam, ODanhMucKhoaPhong);
        }

        public override void Save(SiteParam OSiteParam, string Id, DanhMucKhoaPhongCls ODanhMucKhoaPhong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Save(ActionSqlParam, Id, ODanhMucKhoaPhong);
        }

        public override void Delete(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucKhoaPhongCls CreateModel(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucKhoaPhongCls[] PageReading(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().PageReading(ActionSqlParam, ODanhMucKhoaPhongFilter, ref recordTotal);
        }

        public override DanhMucKhoaPhongCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().ReadingWithPaging(ActionSqlParam, ODanhMucKhoaPhongFilter, PageIndex, PageSize);
        }

        public override long Count(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().Count(ActionSqlParam, ODanhMucKhoaPhongFilter);
        }
        public override DanhMucKhoaPhongCls[] PageReading(SiteParam OSiteParam, string sqlContent, int PageIndex, int PageSize, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().PageReading(ActionSqlParam, sqlContent, PageIndex, PageSize, ref recordTotal);
        }

        public override DanhMucKhoaPhongCls CreateModel(string connectstring, string Id)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhoaPhongProcess().CreateModel(connectstring, Id);
        }
    }
}
