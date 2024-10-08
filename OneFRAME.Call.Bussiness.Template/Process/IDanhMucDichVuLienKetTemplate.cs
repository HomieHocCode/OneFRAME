﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucDichVuLienKetProcess
    {
        string ServiceId { get; }
        DanhMucDichVuLienKetCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet);
        void Save(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId);
        DanhMucDichVuLienKetCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId);
        DanhMucDichVuLienKetCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, ref int recordTotal);
        DanhMucDichVuLienKetCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter);
        DanhMucDichVuLienKetCls[] Reading(string connectstring);
    }

    public class DanhMucDichVuLienKetTemplate : IDanhMucDichVuLienKetProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDichVuLienKetCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId) { }
        public virtual DanhMucDichVuLienKetCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDichVuLienKetId) { return null; }
        public virtual DanhMucDichVuLienKetCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, ref int recordTotal) { return null; }
        public virtual DanhMucDichVuLienKetCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter) { return 0; }
        public virtual DanhMucDichVuLienKetCls[] Reading(string connectstring) { return null; }
    }
}
