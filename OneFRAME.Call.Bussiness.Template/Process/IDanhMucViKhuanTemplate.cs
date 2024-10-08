﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucViKhuanProcess
    {
        string ServiceId { get; }
        DanhMucViKhuanCls[] Reading(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucViKhuanCls ODanhMucViKhuan);
        void Save(RenderInfoCls ORenderInfo, string DanhMucViKhuanId, DanhMucViKhuanCls ODanhMucViKhuan);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucViKhuanId);
        DanhMucViKhuanCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucViKhuanId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucViKhuanId);
        DanhMucViKhuanCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, ref int recordTotal);
        DanhMucViKhuanCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter);
    }

    public class DanhMucViKhuanTemplate : IDanhMucViKhuanProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucViKhuanCls[] Reading(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucViKhuanCls ODanhMucViKhuan) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucViKhuanId, DanhMucViKhuanCls ODanhMucViKhuan) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucViKhuanId) { }
        public virtual DanhMucViKhuanCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucViKhuanId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucViKhuanId) { return null; }
        public virtual DanhMucViKhuanCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, ref int recordTotal) { return null; }
        public virtual DanhMucViKhuanCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter) { return 0; }
    }
}
