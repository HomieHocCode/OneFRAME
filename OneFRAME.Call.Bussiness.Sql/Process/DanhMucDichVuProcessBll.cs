using System;
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
public class DanhMucDichVuProcessBll : DanhMucDichVuTemplate
{
public override string ServiceId
{
    get
    {
        return "SqlDanhMucDichVuProcessBll";
    }
}


public override DanhMucDichVuCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Reading(ActionSqlParam, ODanhMucDichVuFilter);
}


public override void Add(RenderInfoCls ORenderInfo, DanhMucDichVuCls ODanhMucDichVu)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Add(ActionSqlParam, ODanhMucDichVu);
}


public override void Save(RenderInfoCls ORenderInfo, string Id, DanhMucDichVuCls ODanhMucDichVu)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Save(ActionSqlParam, Id, ODanhMucDichVu);
}


public override void Delete(RenderInfoCls ORenderInfo, string Id)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Delete(ActionSqlParam, Id);
}


public override DanhMucDichVuCls CreateModel(RenderInfoCls ORenderInfo, string Id)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().CreateModel(ActionSqlParam, Id);
}


public override string Duplicate(RenderInfoCls ORenderInfo, string Id)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Duplicate(ActionSqlParam, Id);
}

public override DanhMucDichVuCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().ReadingWithPaging(ActionSqlParam, ODanhMucDichVuFilter);
}

public override long Count(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Count(ActionSqlParam, ODanhMucDichVuFilter);
}

public override DanhMucDichVuCls[] ReadingWithPagingDichVu(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().ReadingWithPagingDichVu(ActionSqlParam, ODanhMucDichVuFilter, PageIndex, PageSize);
}

public override DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(RenderInfoCls ORenderInfo)
{
    ActionSqlParamCls
       ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().ReadingLoaiDichVuXetNghiem(ActionSqlParam);
}
public override long CountDichVu(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().CountDichVu(ActionSqlParam, ODanhMucDichVuFilter);
}
public override DanhMucDichVuCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().PageReading(ActionSqlParam, ODanhMucDichVuFilter, ref recordTotal);
}

public override DanhMucDichVuCls[] Reading(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Reading(ActionSqlParam, ODanhMucDichVuFilter);
}


public override void Add(SiteParam OSiteParam, DanhMucDichVuCls ODanhMucDichVu)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Add(ActionSqlParam, ODanhMucDichVu);
}


public override void Save(SiteParam OSiteParam, string Id, DanhMucDichVuCls ODanhMucDichVu)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Save(ActionSqlParam, Id, ODanhMucDichVu);
}


public override void Delete(SiteParam OSiteParam, string Id)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Delete(ActionSqlParam, Id);
}


public override DanhMucDichVuCls CreateModel(SiteParam OSiteParam, string Id)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().CreateModel(ActionSqlParam, Id);
}


public override string Duplicate(SiteParam OSiteParam, string Id)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Duplicate(ActionSqlParam, Id);
}

public override DanhMucDichVuCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().ReadingWithPaging(ActionSqlParam, ODanhMucDichVuFilter);
}

public override long Count(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().Count(ActionSqlParam, ODanhMucDichVuFilter);
}

public override DanhMucDichVuCls[] ReadingWithPagingDichVu(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().ReadingWithPagingDichVu(ActionSqlParam, ODanhMucDichVuFilter, PageIndex, PageSize);
}

public override DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(SiteParam OSiteParam)
{
    ActionSqlParamCls
       ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().ReadingLoaiDichVuXetNghiem(ActionSqlParam);
}
public override long CountDichVu(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().CountDichVu(ActionSqlParam, ODanhMucDichVuFilter);
}
public override DanhMucDichVuCls[] PageReading(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal)
{
    ActionSqlParamCls
        ActionSqlParam = WebEnvironments.CreateActionSqlParam(OSiteParam);
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().PageReading(ActionSqlParam, ODanhMucDichVuFilter, ref recordTotal);
}

public override DanhMucDichVuCls CreateModel(string connectstring, string Id)
{
    return OneLISBussinessUtility.CreateBussinessProcess().CreateDanhMucDichVuProcess().CreateModel(connectstring, Id);
}
}
}
