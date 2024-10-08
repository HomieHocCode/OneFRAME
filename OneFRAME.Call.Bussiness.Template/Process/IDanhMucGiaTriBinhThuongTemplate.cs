﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucGiaTriBinhThuongProcess
    {
        string ServiceId { get; }
        DanhMucGiaTriBinhThuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong);
        void Save(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId);
        DanhMucGiaTriBinhThuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId);
        DanhMucGiaTriBinhThuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, ref int recordTotal);
        DanhMucGiaTriBinhThuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter);
        DanhMucGiaTriBinhThuongCls CreateModel(RenderInfoCls ORenderInfo, string ChiSoId, string ThietBiId);
    }

    public class DanhMucGiaTriBinhThuongTemplate : IDanhMucGiaTriBinhThuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucGiaTriBinhThuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId) { }
        public virtual DanhMucGiaTriBinhThuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucGiaTriBinhThuongId) { return null; }
        public virtual DanhMucGiaTriBinhThuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, ref int recordTotal) { return null; }
        public virtual DanhMucGiaTriBinhThuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter) { return 0; }
        public virtual DanhMucGiaTriBinhThuongCls CreateModel(RenderInfoCls ORenderInfo, string ChiSoId, string ThietBiId) { return null; }
    }
}
