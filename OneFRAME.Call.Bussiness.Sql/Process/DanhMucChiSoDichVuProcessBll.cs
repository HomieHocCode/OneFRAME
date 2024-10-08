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
    public class DanhMucChiSoDichVuProcessBll : DanhMucChiSoDichVuTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucChiSoDichVuProcessBll";
            }
        }

        public override DanhMucChiSoDichVuCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().Reading(ActionSqlParam, ODanhMucChiSoDichVuFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().Add(ActionSqlParam, ODanhMucChiSoDichVu);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string DichVuId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().Delete(ActionSqlParam, ChiSoId, DichVuId);
        }

        public override DanhMucChiSoDichVuCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string[] ChiSoIdByDichVuId(RenderInfoCls ORenderInfo, string dichvuid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ChiSoIdByDichVuId(ActionSqlParam, dichvuid);
        }

        public override string[] DichVuIdByChiSoId(RenderInfoCls ORenderInfo, string chisoid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().DichVuIdByChiSoId(ActionSqlParam, chisoid);
        }

        public override DanhMucChiSoDichVuCls[] ChiSo(RenderInfoCls ORenderInfo)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ChiSo(ActionSqlParam);
        }

        public override string[] GetChiSoIdsByParentId(RenderInfoCls ORenderInfo, string ParentId)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().GetChiSoIdsByParentId(ActionSqlParam, ParentId);
        }

        public override DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(RenderInfoCls ORenderInfo, string dichvuid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ReadingChiSoByDichVu(ActionSqlParam, dichvuid);
        }

        public override DanhMucChiSoDichVuCls[] Reading(SiteParam OSiteParam, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().Reading(ActionSqlParam, ODanhMucChiSoDichVuFilter);
        }

        public override void Add(SiteParam OSiteParam, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().Add(ActionSqlParam, ODanhMucChiSoDichVu);
        }

        public override void Delete(SiteParam OSiteParam, string ChiSoId, string DichVuId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().Delete(ActionSqlParam, ChiSoId, DichVuId);
        }

        public override DanhMucChiSoDichVuCls CreateModel(SiteParam OSiteParam, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string[] ChiSoIdByDichVuId(SiteParam OSiteParam, string dichvuid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ChiSoIdByDichVuId(ActionSqlParam, dichvuid);
        }

        public override string[] DichVuIdByChiSoId(SiteParam OSiteParam, string chisoid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().DichVuIdByChiSoId(ActionSqlParam, chisoid);
        }

        public override DanhMucChiSoDichVuCls[] ChiSo(SiteParam OSiteParam)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ChiSo(ActionSqlParam);
        }

        public override string[] GetChiSoIdsByParentId(SiteParam OSiteParam, string ParentId)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().GetChiSoIdsByParentId(ActionSqlParam, ParentId);
        }

        public override DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(SiteParam OSiteParam, string dichvuid)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ReadingChiSoByDichVu(ActionSqlParam, dichvuid);
        }

        public override string[] ChiSoIdByDichVuId(string connectstring, string dichvuid)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().ChiSoIdByDichVuId(connectstring, dichvuid);
        }

        public override string[] DichVuIdByChiSoId(string connectstring, string chisoid)
        {
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucChiSoDichVuProcess().DichVuIdByChiSoId(connectstring, chisoid);
        }
    }
}
