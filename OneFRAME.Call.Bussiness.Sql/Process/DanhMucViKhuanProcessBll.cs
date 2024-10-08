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
    public class DanhMucViKhuanProcessBll : DanhMucViKhuanTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucViKhuanProcessBll";
            }
        }

        public override DanhMucViKhuanCls[] Reading(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().Reading(ActionSqlParam, ODanhMucViKhuanFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucViKhuanCls ODanhMucViKhuan)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().Add(ActionSqlParam, ODanhMucViKhuan);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucViKhuanCls ODanhMucViKhuan)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().Save(ActionSqlParam, Id, ODanhMucViKhuan);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucViKhuanCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucViKhuanCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().PageReading(ActionSqlParam, ODanhMucViKhuanFilter, ref recordTotal);
        }

        public override DanhMucViKhuanCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().ReadingWithPaging(ActionSqlParam, ODanhMucViKhuanFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucViKhuanProcess().Count(ActionSqlParam, ODanhMucViKhuanFilter);
        }
    }
}
