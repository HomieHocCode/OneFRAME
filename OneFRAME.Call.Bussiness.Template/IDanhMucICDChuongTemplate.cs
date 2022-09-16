using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IDanhMucICDChuongProcess
    {
        string ServiceId { get; }
        DanhMucICDChuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucICDChuongCls ODanhMucICDChuong);
        void Save(RenderInfoCls ORenderInfo, string DanhMucICDChuongId, DanhMucICDChuongCls ODanhMucICDChuong);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucICDChuongId);
        DanhMucICDChuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucICDChuongId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucICDChuongId);
        DanhMucICDChuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter);
        DanhMucICDChuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, ref int recordTotal);
        DanhMucICDChuongCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten);
        DanhMucICDChuongCls CreateModel(RenderInfoCls oRenderInfo, object id);
        void Save(RenderInfoCls oRenderInfo, object id, DanhMucICDChuongCls oDanhMucICDChuong);
    }

    public class DanhMucICDChuongTemplate : IDanhMucICDChuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucICDChuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucICDChuongCls ODanhMucICDChuong) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucICDChuongId, DanhMucICDChuongCls ODanhMucICDChuong) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucICDChuongId) { }
        public virtual DanhMucICDChuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucICDChuongId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucICDChuongId) { return null; }
        public virtual DanhMucICDChuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter) { return 0; }
        public virtual DanhMucICDChuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, ref int recordTotal) { return null; }
        public virtual DanhMucICDChuongCls CreateModelByTen(RenderInfoCls ORenderInfo, string Ten) { return null; }

        public DanhMucICDChuongCls CreateModel(RenderInfoCls oRenderInfo, object id)
        {
            throw new NotImplementedException();
        }

        public void Save(RenderInfoCls oRenderInfo, object id, DanhMucICDChuongCls oDanhMucICDChuong)
        {
            throw new NotImplementedException();
        }
    }
}
