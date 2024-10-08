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
    public class DanhMucChiDinhMauProcessBll : DanhMucChiDinhMauTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucChiDinhMauProcessBll";
            }
        }

        public override DanhMucChiDinhMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().Reading(ActionSqlParam, ODanhMucChiDinhMauFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucChiDinhMauCls ODanhMucChiDinhMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().Add(ActionSqlParam, ODanhMucChiDinhMau);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucChiDinhMauCls ODanhMucChiDinhMau)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().Save(ActionSqlParam, Id, ODanhMucChiDinhMau);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucChiDinhMauCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucChiDinhMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().PageReading(ActionSqlParam, ODanhMucChiDinhMauFilter, ref recordTotal);
        }

        public override DanhMucChiDinhMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().ReadingWithPaging(ActionSqlParam, ODanhMucChiDinhMauFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiDinhMauProcess().Count(ActionSqlParam, ODanhMucChiDinhMauFilter);
        }
    }
}
