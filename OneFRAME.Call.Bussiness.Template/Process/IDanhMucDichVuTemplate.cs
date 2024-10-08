using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
   public interface IDanhMucDichVuProcess
   {
       string ServiceId { get; }
       DanhMucDichVuCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       void Add(RenderInfoCls ORenderInfo,  DanhMucDichVuCls ODanhMucDichVu);
       void Save(RenderInfoCls ORenderInfo,  string DanhMucDichVuId,DanhMucDichVuCls ODanhMucDichVu);
       void Delete(RenderInfoCls ORenderInfo,  string DanhMucDichVuId);
       DanhMucDichVuCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDichVuId);
       string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDichVuId);
       DanhMucDichVuCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       long Count(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       DanhMucDichVuCls[] ReadingWithPagingDichVu(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize);
       long CountDichVu(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(RenderInfoCls ORenderInfo);
       DanhMucDichVuCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal);

       DanhMucDichVuCls[] Reading(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       void Add(SiteParam OSiteParam, DanhMucDichVuCls ODanhMucDichVu);
       void Save(SiteParam OSiteParam, string DanhMucDichVuId, DanhMucDichVuCls ODanhMucDichVu);
       void Delete(SiteParam OSiteParam, string DanhMucDichVuId);
       DanhMucDichVuCls CreateModel(SiteParam OSiteParam, string DanhMucDichVuId);
       string Duplicate(SiteParam OSiteParam, string DanhMucDichVuId);
       DanhMucDichVuCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       long Count(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       DanhMucDichVuCls[] ReadingWithPagingDichVu(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize);
       long CountDichVu(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter);
       DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(SiteParam OSiteParam);
       DanhMucDichVuCls[] PageReading(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal);

       DanhMucDichVuCls CreateModel(string connectstring, string DanhMucDichVuId);
   }
   
   public class DanhMucDichVuTemplate : IDanhMucDichVuProcess
   {
       public virtual string ServiceId { get { return null; } }
       public virtual DanhMucDichVuCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return null; }
       public virtual void Add(RenderInfoCls ORenderInfo, DanhMucDichVuCls ODanhMucDichVu) { }
       public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucDichVuId, DanhMucDichVuCls ODanhMucDichVu) { }
       public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucDichVuId) { }
       public virtual DanhMucDichVuCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDichVuId) { return null; }
       public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDichVuId) { return null; }
       public virtual DanhMucDichVuCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return null; }
       public virtual long Count(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return 0; }
       public virtual DanhMucDichVuCls[] ReadingWithPagingDichVu(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize) { return null; }
       public virtual long CountDichVu(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return 0; }
       public virtual DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(RenderInfoCls ORenderInfo) { return null; }
       public virtual DanhMucDichVuCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal) { return null; }

       public virtual DanhMucDichVuCls[] Reading(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return null; }
       public virtual void Add(SiteParam OSiteParam, DanhMucDichVuCls ODanhMucDichVu) { }
       public virtual void Save(SiteParam OSiteParam, string DanhMucDichVuId, DanhMucDichVuCls ODanhMucDichVu) { }
       public virtual void Delete(SiteParam OSiteParam, string DanhMucDichVuId) { }
       public virtual DanhMucDichVuCls CreateModel(SiteParam OSiteParam, string DanhMucDichVuId) { return null; }
       public virtual string Duplicate(SiteParam OSiteParam, string DanhMucDichVuId) { return null; }
       public virtual DanhMucDichVuCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return null; }
       public virtual long Count(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return 0; }
       public virtual DanhMucDichVuCls[] ReadingWithPagingDichVu(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize) { return null; }
       public virtual long CountDichVu(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter) { return 0; }
       public virtual DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(SiteParam OSiteParam) { return null; }
       public virtual DanhMucDichVuCls[] PageReading(SiteParam OSiteParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal) { return null; }

       public virtual DanhMucDichVuCls CreateModel(string connectstring, string DanhMucDichVuId) { return null; }
   }
}
