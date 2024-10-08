﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucMauKetQuaProcess
    {
        string ServiceId { get; }
        DanhMucMauKetQuaCls[] Reading(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucMauKetQuaCls ODanhMucMauKetQua);
        void Save(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId, DanhMucMauKetQuaCls ODanhMucMauKetQua);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId);
        DanhMucMauKetQuaCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId);
        DanhMucMauKetQuaCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, ref int recordTotal);
        DanhMucMauKetQuaCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter);
    }

    public class DanhMucMauKetQuaTemplate : IDanhMucMauKetQuaProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucMauKetQuaCls[] Reading(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucMauKetQuaCls ODanhMucMauKetQua) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId, DanhMucMauKetQuaCls ODanhMucMauKetQua) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId) { }
        public virtual DanhMucMauKetQuaCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucMauKetQuaId) { return null; }
        public virtual DanhMucMauKetQuaCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, ref int recordTotal) { return null; }
        public virtual DanhMucMauKetQuaCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter) { return 0; }
    }
}
