using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IDanhMucQuocGiaProcess
    {
        string ServiceId { get; }
        DanhMucQuocGiaCls[] Reading(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucQuocGiaCls ODanhMucQuocGia);
        void Save(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId, DanhMucQuocGiaCls ODanhMucQuocGia);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId);
        DanhMucQuocGiaCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId);
        DanhMucQuocGiaCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter);
        DanhMucQuocGiaCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, ref int recordTotal);
        DanhMucQuocGiaCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten);
    }

    public class DanhMucQuocGiaTemplate : IDanhMucQuocGiaProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucQuocGiaCls[] Reading(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucQuocGiaCls ODanhMucQuocGia) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId, DanhMucQuocGiaCls ODanhMucQuocGia) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId) { }
        public virtual DanhMucQuocGiaCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucQuocGiaId) { return null; }
        public virtual DanhMucQuocGiaCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter) { return 0; }
        public virtual DanhMucQuocGiaCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, ref int recordTotal) { return null; }
        public virtual DanhMucQuocGiaCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten) { return null; }
    }
}
