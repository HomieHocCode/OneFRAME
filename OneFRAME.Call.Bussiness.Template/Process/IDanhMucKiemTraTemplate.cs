﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucKiemTraProcess
    {
        string ServiceId { get; }
        DanhMucKiemTraCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucKiemTraCls ODanhMucKiemTra);
        void Save(RenderInfoCls ORenderInfo, string DanhMucKiemTraId, DanhMucKiemTraCls ODanhMucKiemTra);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucKiemTraId);
        DanhMucKiemTraCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKiemTraId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKiemTraId);
        DanhMucKiemTraCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, ref int recordTotal);
        DanhMucKiemTraCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter);
        DanhMucKiemTraChiSoCls[] ReadingKiemTraChiSo(RenderInfoCls ORenderInfo);
    }

    public class DanhMucKiemTraTemplate : IDanhMucKiemTraProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKiemTraCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucKiemTraCls ODanhMucKiemTra) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucKiemTraId, DanhMucKiemTraCls ODanhMucKiemTra) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucKiemTraId) { }
        public virtual DanhMucKiemTraCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKiemTraId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKiemTraId) { return null; }
        public virtual DanhMucKiemTraCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, ref int recordTotal) { return null; }
        public virtual DanhMucKiemTraCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter) { return 0; }
        public virtual DanhMucKiemTraChiSoCls[] ReadingKiemTraChiSo(RenderInfoCls ORenderInfo) { return null; }
    }
}
