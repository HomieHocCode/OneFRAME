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
    public class DanhMucNongDoProcessBll : DanhMucNongDoTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucNongDoProcessBll";
            }
        }

        public override DanhMucNongDoCls[] Reading(RenderInfoCls ORenderInfo, string chiSoid)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().Reading(ActionSqlParam, chiSoid);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucNongDoCls ODanhMucNongDo)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().Add(ActionSqlParam, ODanhMucNongDo);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucNongDoCls ODanhMucNongDo)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().Save(ActionSqlParam, Id, ODanhMucNongDo);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucNongDoCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucNongDoCls[] PageReading(RenderInfoCls ORenderInfo, string chiSoid, int PageIndex, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().PageReading(ActionSqlParam, chiSoid, PageIndex, ref recordTotal);
        }

        public override DanhMucNongDoCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, string chiSoid, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().ReadingWithPaging(ActionSqlParam, chiSoid, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, string chiSoid)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucNongDoProcess().Count(ActionSqlParam, chiSoid);
        }
    }
}
