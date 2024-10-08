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
    public class DanhMucGiaTriBinhThuongProcessBll : DanhMucGiaTriBinhThuongTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucGiaTriBinhThuongProcessBll";
            }
        }

        public override DanhMucGiaTriBinhThuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().Reading(ActionSqlParam, ODanhMucGiaTriBinhThuongFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().Add(ActionSqlParam, ODanhMucGiaTriBinhThuong);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().Save(ActionSqlParam, Id, ODanhMucGiaTriBinhThuong);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucGiaTriBinhThuongCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucGiaTriBinhThuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().PageReading(ActionSqlParam, ODanhMucGiaTriBinhThuongFilter, ref recordTotal);
        }

        public override DanhMucGiaTriBinhThuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().ReadingWithPaging(ActionSqlParam, ODanhMucGiaTriBinhThuongFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().Count(ActionSqlParam, ODanhMucGiaTriBinhThuongFilter);
        }
        public override DanhMucGiaTriBinhThuongCls CreateModel(RenderInfoCls ORenderInfo, string ChiSoId, string ThietBiId)
        {
            ActionSqlParamCls
               ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucGiaTriBinhThuongProcess().CreateModel(ActionSqlParam, ChiSoId, ThietBiId);
        }
    }
}
