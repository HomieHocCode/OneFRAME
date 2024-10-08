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
    public class DanhMucNguonMauProcessBll : DanhMucNguonMauTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucNguonMauProcessBll";
            }
        }

        public override DanhMucNguonMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().Reading(ActionSqlParam, ODanhMucNguonMauFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucNguonMauCls ODanhMucNguonMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().Add(ActionSqlParam, ODanhMucNguonMau);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucNguonMauCls ODanhMucNguonMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().Save(ActionSqlParam, Id, ODanhMucNguonMau);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucNguonMauCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucNguonMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().PageReading(ActionSqlParam, ODanhMucNguonMauFilter, ref recordTotal);
        }

        public override DanhMucNguonMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().ReadingWithPaging(ActionSqlParam, ODanhMucNguonMauFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNguonMauProcess().Count(ActionSqlParam, ODanhMucNguonMauFilter);
        }
    }
}
