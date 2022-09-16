using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IDanhMucVungMienProcess
    {
        string ServiceId { get; }
        DanhMucVungMienCls[] Reading(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucVungMienCls ODanhMucVungMien);
        void Save(RenderInfoCls ORenderInfo, string DanhMucVungMienId, DanhMucVungMienCls ODanhMucVungMien);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucVungMienId);
        DanhMucVungMienCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucVungMienId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucVungMienId);
        DanhMucVungMienCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter);
        DanhMucVungMienCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter, ref int recordTotal);
        DanhMucVungMienCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten);
    }

    public class DanhMucVungMienTemplate : IDanhMucVungMienProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucVungMienCls[] Reading(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucVungMienCls ODanhMucVungMien) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucVungMienId, DanhMucVungMienCls ODanhMucVungMien) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucVungMienId) { }
        public virtual DanhMucVungMienCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucVungMienId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucVungMienId) { return null; }
        public virtual DanhMucVungMienCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter) { return 0; }
        public virtual DanhMucVungMienCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucVungMienFilterCls ODanhMucVungMienFilter, ref int recordTotal) { return null; }
        public virtual DanhMucVungMienCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten) { return null; }
    }
}
