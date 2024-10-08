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
    public class DanhMucThietBiProcessBll : DanhMucThietBiTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucThietBiProcessBll";
            }
        }

        public override DanhMucThietBiCls[] Reading(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().Reading(ActionSqlParam, ODanhMucThietBiFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucThietBiCls ODanhMucThietBi)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().Add(ActionSqlParam, ODanhMucThietBi);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucThietBiCls ODanhMucThietBi)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().Save(ActionSqlParam, Id, ODanhMucThietBi);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucThietBiCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucThietBiCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().PageReading(ActionSqlParam, ODanhMucThietBiFilter, ref recordTotal);
        }

        public override DanhMucThietBiCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().ReadingWithPaging(ActionSqlParam, ODanhMucThietBiFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucThietBiProcess().Count(ActionSqlParam, ODanhMucThietBiFilter);
        }
    }
}
