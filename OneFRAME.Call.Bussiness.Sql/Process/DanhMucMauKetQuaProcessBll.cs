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
    public class DanhMucMauKetQuaProcessBll : DanhMucMauKetQuaTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlDanhMucMauKetQuaProcessBll";
            }
        }

        public override DanhMucMauKetQuaCls[] Reading(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().Reading(ActionSqlParam, ODanhMucMauKetQuaFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucMauKetQuaCls ODanhMucMauKetQua)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().Add(ActionSqlParam, ODanhMucMauKetQua);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucMauKetQuaCls ODanhMucMauKetQua)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().Save(ActionSqlParam, Id, ODanhMucMauKetQua);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucMauKetQuaCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucMauKetQuaCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, ref int recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().PageReading(ActionSqlParam, ODanhMucMauKetQuaFilter, ref recordTotal);
        }

        public override DanhMucMauKetQuaCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().ReadingWithPaging(ActionSqlParam, ODanhMucMauKetQuaFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucMauKetQuaProcess().Count(ActionSqlParam, ODanhMucMauKetQuaFilter);
        }
    }
}
