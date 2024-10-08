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
    public class DanhMucDoiTuongProcessBll : DanhMucDoiTuongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucDoiTuongProcessBll";
            }
        }

        public override DanhMucDoiTuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().Reading(ActionSqlParam, ODanhMucDoiTuongFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucDoiTuongCls ODanhMucDoiTuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().Add(ActionSqlParam, ODanhMucDoiTuong);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucDoiTuongCls ODanhMucDoiTuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().Save(ActionSqlParam, Id, ODanhMucDoiTuong);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucDoiTuongCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucDoiTuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().PageReading(ActionSqlParam, ODanhMucDoiTuongFilter, ref recordTotal);
        }

        public override DanhMucDoiTuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().ReadingWithPaging(ActionSqlParam, ODanhMucDoiTuongFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().Count(ActionSqlParam, ODanhMucDoiTuongFilter);
        }
        public override DanhMucDoiTuongCls CreateModel(string connectstring, string DanhMucDoiTuongId)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDoiTuongProcess().CreateModel(connectstring, DanhMucDoiTuongId);
        }
    }
}
