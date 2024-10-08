﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucKyThuatXetNghiemProcess
    {
        string ServiceId { get; }
        DanhMucKyThuatXetNghiemCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem);
        void Save(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId);
        DanhMucKyThuatXetNghiemCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId);
        DanhMucKyThuatXetNghiemCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, ref int recordTotal);
        DanhMucKyThuatXetNghiemCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter);
    }

    public class DanhMucKyThuatXetNghiemTemplate : IDanhMucKyThuatXetNghiemProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKyThuatXetNghiemCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId) { }
        public virtual DanhMucKyThuatXetNghiemCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKyThuatXetNghiemId) { return null; }
        public virtual DanhMucKyThuatXetNghiemCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, ref int recordTotal) { return null; }
        public virtual DanhMucKyThuatXetNghiemCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter) { return 0; }
    }
}
