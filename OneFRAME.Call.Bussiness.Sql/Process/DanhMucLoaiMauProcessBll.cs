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
    public class DanhMucLoaiMauProcessBll : DanhMucLoaiMauTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucLoaiMauProcessBll";
            }
        }

        public override DanhMucLoaiMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Reading(ActionSqlParam, ODanhMucLoaiMauFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucLoaiMauCls ODanhMucLoaiMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Add(ActionSqlParam, ODanhMucLoaiMau);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucLoaiMauCls ODanhMucLoaiMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Save(ActionSqlParam, Id, ODanhMucLoaiMau);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucLoaiMauCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucLoaiMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().PageReading(ActionSqlParam, ODanhMucLoaiMauFilter, ref recordTotal);
        }

        public override DanhMucLoaiMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().ReadingWithPaging(ActionSqlParam, ODanhMucLoaiMauFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Count(ActionSqlParam, ODanhMucLoaiMauFilter);
        }

        public override DanhMucLoaiMauCls[] Reading(SiteParam OSiteParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Reading(ActionSqlParam, ODanhMucLoaiMauFilter);
        }

        public override void Add(SiteParam OSiteParam, DanhMucLoaiMauCls ODanhMucLoaiMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Add(ActionSqlParam, ODanhMucLoaiMau);
        }

        public override void Save(SiteParam OSiteParam, string Id, DanhMucLoaiMauCls ODanhMucLoaiMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Save(ActionSqlParam, Id, ODanhMucLoaiMau);
        }

        public override void Delete(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucLoaiMauCls CreateModel(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucLoaiMauCls[] PageReading(SiteParam OSiteParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().PageReading(ActionSqlParam, ODanhMucLoaiMauFilter, ref recordTotal);
        }

        public override DanhMucLoaiMauCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().ReadingWithPaging(ActionSqlParam, ODanhMucLoaiMauFilter, PageIndex, PageSize);
        }

        public override long Count(SiteParam OSiteParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().Count(ActionSqlParam, ODanhMucLoaiMauFilter);
        }

        public override DanhMucLoaiMauCls CreateModel(string connectstring, string Id)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucLoaiMauProcess().CreateModel(connectstring, Id);
        }
    }
}
