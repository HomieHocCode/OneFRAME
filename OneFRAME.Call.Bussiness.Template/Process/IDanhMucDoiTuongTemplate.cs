﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucDoiTuongProcess
    {
        string ServiceId { get; }
        DanhMucDoiTuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucDoiTuongCls ODanhMucDoiTuong);
        void Save(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId, DanhMucDoiTuongCls ODanhMucDoiTuong);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId);
        DanhMucDoiTuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId);
        DanhMucDoiTuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, ref int recordTotal);
        DanhMucDoiTuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter);
        DanhMucDoiTuongCls CreateModel(string connectstring, string DanhMucDoiTuongId);

    }

    public class DanhMucDoiTuongTemplate : IDanhMucDoiTuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDoiTuongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucDoiTuongCls ODanhMucDoiTuong) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId, DanhMucDoiTuongCls ODanhMucDoiTuong) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId) { }
        public virtual DanhMucDoiTuongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDoiTuongId) { return null; }
        public virtual DanhMucDoiTuongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, ref int recordTotal) { return null; }
        public virtual DanhMucDoiTuongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter) { return 0; }
        public virtual DanhMucDoiTuongCls CreateModel(string connectstring, string DanhMucDoiTuongId) { return null; }
    }
}
