using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IDanhMucTinhThanhProcess
    {
        string ServiceId { get; }
        DanhMucTinhThanhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucTinhThanhCls ODanhMucTinhThanh);
        void Save(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId, DanhMucTinhThanhCls ODanhMucTinhThanh);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId);
        DanhMucTinhThanhCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId);
        DanhMucTinhThanhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter);
        DanhMucTinhThanhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, ref int recordTotal);
        DanhMucTinhThanhCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten);
    }

    public class DanhMucTinhThanhTemplate : IDanhMucTinhThanhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucTinhThanhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucTinhThanhCls ODanhMucTinhThanh) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId, DanhMucTinhThanhCls ODanhMucTinhThanh) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId) { }
        public virtual DanhMucTinhThanhCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucTinhThanhId) { return null; }
        public virtual DanhMucTinhThanhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter) { return 0; }
        public virtual DanhMucTinhThanhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, ref int recordTotal) { return null; }
        public virtual DanhMucTinhThanhCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten) { return null; }
    }
}
