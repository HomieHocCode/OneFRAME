﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucChiDinhMauChiTietProcess
    {
        string ServiceId { get; }
        DanhMucChiDinhMauChiTietCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauChiTietFilterCls ODanhMucChiDinhMauChiTietFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucChiDinhMauChiTietCls ODanhMucChiDinhMauChiTiet);
        void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string DichVuId);
        DanhMucChiDinhMauChiTietCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauChiTietId);
        string[] ChiSoIdByDichVuId(RenderInfoCls ORenderInfo, string dichvuid);
        DanhMucChiDinhMauChiTietCls[] ChiSo(RenderInfoCls ORenderInfo);
        string[] GetChiSoIdsByParentId(RenderInfoCls ORenderInfo, string ParentId);
        DanhMucChiDinhMauChiTietCls[] ReadingChiSoByDichVu(RenderInfoCls ORenderInfo, string dichvuid);
    }

    public class DanhMucChiDinhMauChiTietTemplate : IDanhMucChiDinhMauChiTietProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiDinhMauChiTietCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiDinhMauChiTietFilterCls ODanhMucChiDinhMauChiTietFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucChiDinhMauChiTietCls ODanhMucChiDinhMauChiTiet) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string DichVuId) { }
        public virtual DanhMucChiDinhMauChiTietCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiDinhMauChiTietId) { return null; }
        public virtual string[] ChiSoIdByDichVuId(RenderInfoCls ORenderInfo, string dichvuid) { return null; }
        public virtual DanhMucChiDinhMauChiTietCls[] ChiSo(RenderInfoCls ORenderInfo) { return null; }
        public virtual string[] GetChiSoIdsByParentId(RenderInfoCls ORenderInfo, string ParentId) { return null; }
        public virtual DanhMucChiDinhMauChiTietCls[] ReadingChiSoByDichVu(RenderInfoCls ORenderInfo, string dichvuid) { return null; }
    }
}
