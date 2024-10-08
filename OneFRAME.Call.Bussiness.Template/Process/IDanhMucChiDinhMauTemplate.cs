﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucChiDinhMauProcess
    {
        string ServiceId { get; }
        DanhMucChiDinhMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucChiDinhMauCls ODanhMucChiDinhMau);
        void Save(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId, DanhMucChiDinhMauCls ODanhMucChiDinhMau);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId);
        DanhMucChiDinhMauCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId);
        DanhMucChiDinhMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, ref int recordTotal);
        DanhMucChiDinhMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter);
    }

    public class DanhMucChiDinhMauTemplate : IDanhMucChiDinhMauProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiDinhMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucChiDinhMauCls ODanhMucChiDinhMau) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId, DanhMucChiDinhMauCls ODanhMucChiDinhMau) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId) { }
        public virtual DanhMucChiDinhMauCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauId) { return null; }
        public virtual DanhMucChiDinhMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, ref int recordTotal) { return null; }
        public virtual DanhMucChiDinhMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter) { return 0; }
    }
}
