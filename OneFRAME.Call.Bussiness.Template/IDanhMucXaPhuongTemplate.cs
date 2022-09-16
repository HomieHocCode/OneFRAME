using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IDanhMucXaPhuongProcess
    {
        string ServiceId { get; }
        DanhMucXaPhuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucXaPhuongCls ODanhMucXaPhuong);
        void Save(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId, DanhMucXaPhuongCls ODanhMucXaPhuong);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId);
        DanhMucXaPhuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId);
        DanhMucXaPhuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter);
        DanhMucXaPhuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, ref long recordTotal);
        DanhMucXaPhuongCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten);
    }

    public class DanhMucXaPhuongTemplate : IDanhMucXaPhuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucXaPhuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucXaPhuongCls ODanhMucXaPhuong) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId, DanhMucXaPhuongCls ODanhMucXaPhuong) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId) { }
        public virtual DanhMucXaPhuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucXaPhuongId) { return null; }
        public virtual DanhMucXaPhuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter) { return 0; }
        public virtual DanhMucXaPhuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, ref long  recordTotal) { return null; }
        public virtual DanhMucXaPhuongCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten) { return null; }
    }
}
