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
    public class DanhMucKhangSinhProcessBll : DanhMucKhangSinhTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucKhangSinhProcessBll";
            }
        }

        public override DanhMucKhangSinhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Reading(ActionSqlParam, ODanhMucKhangSinhFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucKhangSinhCls ODanhMucKhangSinh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Add(ActionSqlParam, ODanhMucKhangSinh);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucKhangSinhCls ODanhMucKhangSinh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Save(ActionSqlParam, Id, ODanhMucKhangSinh);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucKhangSinhCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucKhangSinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().PageReading(ActionSqlParam, ODanhMucKhangSinhFilter, ref recordTotal);
        }

        public override DanhMucKhangSinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().ReadingWithPaging(ActionSqlParam, ODanhMucKhangSinhFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Count(ActionSqlParam, ODanhMucKhangSinhFilter);
        }
        public override string[] GetKhangSinhIdsByViKhuanId(RenderInfoCls ORenderInfo, string DanhMucViKhuanId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().GetKhangSinhIdsByViKhuanId(ActionSqlParam, DanhMucViKhuanId);
        }
        public override DanhMucViKhuanKhangSinhCls[] Reading(RenderInfoCls ORenderInfo)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Reading(ActionSqlParam);
        }
        public override void Add(RenderInfoCls ORenderInfo, string khangsinhid, string vikhuanid)
        {
            ActionSqlParamCls
               ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Add(ActionSqlParam, khangsinhid, vikhuanid);
        }
        public override void Delete(RenderInfoCls ORenderInfo, string khangsinhid, string vikhuanid)
        {
            ActionSqlParamCls
               ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucKhangSinhProcess().Delete(ActionSqlParam, khangsinhid, vikhuanid);
        }
    }
}
