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
    public class DanhMucIcdProcessBll : DanhMucIcdTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucIcdProcessBll";
            }
        }

        public override DanhMucIcdCls[] Reading(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().Reading(ActionSqlParam, ODanhMucIcdFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucIcdCls ODanhMucIcd)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().Add(ActionSqlParam, ODanhMucIcd);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucIcdCls ODanhMucIcd)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().Save(ActionSqlParam, Id, ODanhMucIcd);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucIcdCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucIcdCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().PageReading(ActionSqlParam, ODanhMucIcdFilter, ref recordTotal);
        }

        public override DanhMucIcdCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().ReadingWithPaging(ActionSqlParam, ODanhMucIcdFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucIcdProcess().Count(ActionSqlParam, ODanhMucIcdFilter);
        }
    }
}
