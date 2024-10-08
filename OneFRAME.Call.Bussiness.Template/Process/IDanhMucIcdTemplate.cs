﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucIcdProcess
    {
        string ServiceId { get; }
        DanhMucIcdCls[] Reading(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucIcdCls ODanhMucIcd);
        void Save(RenderInfoCls ORenderInfo, string DanhMucIcdId, DanhMucIcdCls ODanhMucIcd);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucIcdId);
        DanhMucIcdCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucIcdId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucIcdId);
        DanhMucIcdCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter, ref int recordTotal);
        DanhMucIcdCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter);
    }

    public class DanhMucIcdTemplate : IDanhMucIcdProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucIcdCls[] Reading(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucIcdCls ODanhMucIcd) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucIcdId, DanhMucIcdCls ODanhMucIcd) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucIcdId) { }
        public virtual DanhMucIcdCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucIcdId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucIcdId) { return null; }
        public virtual DanhMucIcdCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter, ref int recordTotal) { return null; }
        public virtual DanhMucIcdCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucIcdFilterCls ODanhMucIcdFilter) { return 0; }
    }
}
