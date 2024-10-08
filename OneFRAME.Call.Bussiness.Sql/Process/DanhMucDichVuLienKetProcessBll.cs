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
    public class DanhMucDichVuLienKetProcessBll : DanhMucDichVuLienKetTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucDichVuLienKetProcessBll";
            }
        }

        public override DanhMucDichVuLienKetCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Reading(ActionSqlParam, ODanhMucDichVuLienKetFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Add(ActionSqlParam, ODanhMucDichVuLienKet);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Save(ActionSqlParam, Id, ODanhMucDichVuLienKet);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucDichVuLienKetCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucDichVuLienKetCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().PageReading(ActionSqlParam, ODanhMucDichVuLienKetFilter, ref recordTotal);
        }

        public override DanhMucDichVuLienKetCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().ReadingWithPaging(ActionSqlParam, ODanhMucDichVuLienKetFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Count(ActionSqlParam, ODanhMucDichVuLienKetFilter);
        }
        public override DanhMucDichVuLienKetCls[] Reading(string connectstring)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuLienKetProcess().Reading(connectstring);
        }
    }
}
