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
    public class DanhMucDonViHanhChinhProcessBll : DanhMucDonViHanhChinhTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucDonViHanhChinhProcessBll";
            }
        }

        public override DanhMucDonViHanhChinhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Reading(ActionSqlParam, ODanhMucDonViHanhChinhFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Add(ActionSqlParam, ODanhMucDonViHanhChinh);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Save(ActionSqlParam, Id, ODanhMucDonViHanhChinh);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucDonViHanhChinhCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucDonViHanhChinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().ReadingWithPaging(ActionSqlParam, ODanhMucDonViHanhChinhFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Count(ActionSqlParam, ODanhMucDonViHanhChinhFilter);
        }
        public override DanhMucDonViHanhChinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().PageReading(ActionSqlParam, ODanhMucDonViHanhChinhFilter, ref recordTotal);
        }
    }
}
