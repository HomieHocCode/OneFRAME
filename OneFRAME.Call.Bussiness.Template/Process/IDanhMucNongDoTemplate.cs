﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucNongDoProcess
    {
        string ServiceId { get; }
        DanhMucNongDoCls[] Reading(RenderInfoCls ORenderInfo, string chisoid);
        void Add(RenderInfoCls ORenderInfo, DanhMucNongDoCls ODanhMucNongDo);
        void Save(RenderInfoCls ORenderInfo, string DanhMucNongDoId, DanhMucNongDoCls ODanhMucNongDo);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucNongDoId);
        DanhMucNongDoCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucNongDoId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucNongDoId);
        DanhMucNongDoCls[] PageReading(RenderInfoCls ORenderInfo, string chisoid, int PageIndex, ref int recordTotal);
        DanhMucNongDoCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, string chisoid, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, string chisoid);
    }

    public class DanhMucNongDoTemplate : IDanhMucNongDoProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucNongDoCls[] Reading(RenderInfoCls ORenderInfo, string chisoid) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucNongDoCls ODanhMucNongDo) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucNongDoId, DanhMucNongDoCls ODanhMucNongDo) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucNongDoId) { }
        public virtual DanhMucNongDoCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucNongDoId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucNongDoId) { return null; }
        public virtual DanhMucNongDoCls[] PageReading(RenderInfoCls ORenderInfo, string chisoid, int PageIndex, ref int recordTotal) { return null; }
        public virtual DanhMucNongDoCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, string chisoid, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, string chisoid) { return 0; }
    }
}
