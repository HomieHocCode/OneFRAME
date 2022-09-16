using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;
using OneFRAME.Call.Bussiness.Template;
using OneFRAME.Utility;
using OneFRAME.Bussiness.Utility;

namespace OneFRAME.Call.Bussiness.Sql
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
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Reading(ActionSqlParam, ODanhMucDonViHanhChinhFilter);
        }

        public override void Add(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Add(ActionSqlParam, ODanhMucDonViHanhChinh);
        }

        public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Save(ActionSqlParam, Id, ODanhMucDonViHanhChinh);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Delete(ActionSqlParam, Id);
        }

        public override DanhMucDonViHanhChinhCls CreateModel(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().CreateModel(ActionSqlParam, Id);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Duplicate(ActionSqlParam, Id);
        }

        public override DanhMucDonViHanhChinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().ReadingWithPaging(ActionSqlParam, ODanhMucDonViHanhChinhFilter, PageIndex, PageSize);
        }

        public override long Count(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().Count(ActionSqlParam, ODanhMucDonViHanhChinhFilter);
        }
        public override DanhMucDonViHanhChinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref long  recordTotal)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().PageReading(ActionSqlParam, ODanhMucDonViHanhChinhFilter, ref recordTotal);
        }
        public override DanhMucDonViHanhChinhCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten)
        {
            ActionSqlParamCls ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneFRAMEBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().CreateModelByTen(ActionSqlParam, Ten);
        }
    }
}
