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
    public class DanhMucKiemTraProcessBll : DanhMucKiemTraTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucKiemTraProcessBll";
            }
        }

        public override DanhMucKiemTraCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().Reading(ActionSqlParam, ODanhMucKiemTraFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucKiemTraCls ODanhMucKiemTra)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().Add(ActionSqlParam, ODanhMucKiemTra);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucKiemTraCls ODanhMucKiemTra)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().Save(ActionSqlParam, Id, ODanhMucKiemTra);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucKiemTraCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucKiemTraCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().PageReading(ActionSqlParam, ODanhMucKiemTraFilter, ref recordTotal);
        }

        public override DanhMucKiemTraCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().ReadingWithPaging(ActionSqlParam, ODanhMucKiemTraFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().Count(ActionSqlParam, ODanhMucKiemTraFilter);
        }
        public override DanhMucKiemTraChiSoCls[] ReadingKiemTraChiSo(RenderInfoCls ORenderInfo)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKiemTraProcess().ReadingKiemTraChiSo(ActionSqlParam);
        }
    }
}
