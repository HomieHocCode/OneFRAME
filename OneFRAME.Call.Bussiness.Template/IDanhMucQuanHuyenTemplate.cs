using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IDanhMucQuanHuyenProcess
    {
        string ServiceId { get; }
        DanhMucQuanHuyenCls[] Reading(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucQuanHuyenCls ODanhMucQuanHuyen);
        void Save(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId, DanhMucQuanHuyenCls ODanhMucQuanHuyen);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId);
        DanhMucQuanHuyenCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId);
        DanhMucQuanHuyenCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter);
        DanhMucQuanHuyenCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, ref int recordTotal);
        DanhMucQuanHuyenCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten);
    }

    public class DanhMucQuanHuyenTemplate : IDanhMucQuanHuyenProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucQuanHuyenCls[] Reading(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucQuanHuyenCls ODanhMucQuanHuyen) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId, DanhMucQuanHuyenCls ODanhMucQuanHuyen) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId) { }
        public virtual DanhMucQuanHuyenCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucQuanHuyenId) { return null; }
        public virtual DanhMucQuanHuyenCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter) { return 0; }
        public virtual DanhMucQuanHuyenCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, ref int recordTotal) { return null; }
        public virtual DanhMucQuanHuyenCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten) { return null; }
    }
}
