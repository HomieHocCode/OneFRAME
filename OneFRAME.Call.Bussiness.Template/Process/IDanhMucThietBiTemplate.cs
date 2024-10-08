﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucThietBiProcess
    {
        string ServiceId { get; }
        DanhMucThietBiCls[] Reading(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucThietBiCls ODanhMucThietBi);
        void Save(RenderInfoCls ORenderInfo, string DanhMucThietBiId, DanhMucThietBiCls ODanhMucThietBi);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucThietBiId);
        DanhMucThietBiCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucThietBiId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucThietBiId);
        DanhMucThietBiCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter, ref int recordTotal);
        DanhMucThietBiCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter);
    }

    public class DanhMucThietBiTemplate : IDanhMucThietBiProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucThietBiCls[] Reading(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucThietBiCls ODanhMucThietBi) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucThietBiId, DanhMucThietBiCls ODanhMucThietBi) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucThietBiId) { }
        public virtual DanhMucThietBiCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucThietBiId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucThietBiId) { return null; }
        public virtual DanhMucThietBiCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter, ref int recordTotal) { return null; }
        public virtual DanhMucThietBiCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucThietBiFilterCls ODanhMucThietBiFilter) { return 0; }
    }
}
