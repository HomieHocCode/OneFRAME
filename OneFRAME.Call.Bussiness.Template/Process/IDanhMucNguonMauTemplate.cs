﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucNguonMauProcess
    {
        string ServiceId { get; }
        DanhMucNguonMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucNguonMauCls ODanhMucNguonMau);
        void Save(RenderInfoCls ORenderInfo, string DanhMucNguonMauId, DanhMucNguonMauCls ODanhMucNguonMau);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucNguonMauId);
        DanhMucNguonMauCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucNguonMauId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucNguonMauId);
        DanhMucNguonMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, ref int recordTotal);
        DanhMucNguonMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter);
    }

    public class DanhMucNguonMauTemplate : IDanhMucNguonMauProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucNguonMauCls[] Reading(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucNguonMauCls ODanhMucNguonMau) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucNguonMauId, DanhMucNguonMauCls ODanhMucNguonMau) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucNguonMauId) { }
        public virtual DanhMucNguonMauCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucNguonMauId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucNguonMauId) { return null; }
        public virtual DanhMucNguonMauCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, ref int recordTotal) { return null; }
        public virtual DanhMucNguonMauCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter) { return 0; }
    }
}
