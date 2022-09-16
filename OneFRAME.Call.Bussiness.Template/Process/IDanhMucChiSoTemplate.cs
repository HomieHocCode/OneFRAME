﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucChiSoProcess
    {
        string ServiceId { get; }
        DanhMucChiSoCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucChiSoCls ODanhMucChiSo);
        void Save(RenderInfoCls ORenderInfo, string DanhMucChiSoId, DanhMucChiSoCls ODanhMucChiSo);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucChiSoId);
        DanhMucChiSoCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiSoId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucChiSoId);
        DanhMucChiSoCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter);
        DanhMucChiSoCls[] Reading(RenderInfoCls ORenderInfo, string DichVuId);
        DanhMucChiSoCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter, ref int recordTotal);
        DanhMucChiSoKiemTraChatLuongCls[] ReadingChiSoKiemTraChatLuong(RenderInfoCls ORenderInfo, string kiemtraid, int level);

        DanhMucChiSoCls[] Reading(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter);
        void Add(SiteParam OSiteParam, DanhMucChiSoCls ODanhMucChiSo);
        void Save(SiteParam OSiteParam, string DanhMucChiSoId, DanhMucChiSoCls ODanhMucChiSo);
        void Delete(SiteParam OSiteParam, string DanhMucChiSoId);
        DanhMucChiSoCls CreateModel(SiteParam OSiteParam, string DanhMucChiSoId);
        string Duplicate(SiteParam OSiteParam, string DanhMucChiSoId);
        DanhMucChiSoCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, int PageIndex, int PageSize);
        long Count(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter);
        DanhMucChiSoCls[] Reading(SiteParam OSiteParam, string DichVuId);
        DanhMucChiSoCls[] PageReading(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, ref int recordTotal);
        DanhMucChiSoKiemTraChatLuongCls[] ReadingChiSoKiemTraChatLuong(SiteParam OSiteParam, string kiemtraid, int level);

        DanhMucChiSoCls CreateModel(string connectstring, string DanhMucChiSoId);
        string[] ReadingMaChiSoByChiSoIds(RenderInfoCls ORenderInfo, string[] Ids);

    }

    public class DanhMucChiSoTemplate : IDanhMucChiSoProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiSoCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucChiSoCls ODanhMucChiSo) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucChiSoId, DanhMucChiSoCls ODanhMucChiSo) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucChiSoId) { }
        public virtual DanhMucChiSoCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiSoId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucChiSoId) { return null; }
        public virtual DanhMucChiSoCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter) { return 0; }
        public virtual DanhMucChiSoCls[] Reading(RenderInfoCls ORenderInfo, string DichVuId) { return null; }
        public virtual DanhMucChiSoCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucChiSoFilterCls ODanhMucChiSoFilter, ref int recordTotal) { return null; }
        public virtual DanhMucChiSoKiemTraChatLuongCls[] ReadingChiSoKiemTraChatLuong(RenderInfoCls ORenderInfo, string kiemtraid, int level) { return null; }

        public virtual DanhMucChiSoCls[] Reading(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter) { return null; }
        public virtual void Add(SiteParam OSiteParam, DanhMucChiSoCls ODanhMucChiSo) { }
        public virtual void Save(SiteParam OSiteParam, string DanhMucChiSoId, DanhMucChiSoCls ODanhMucChiSo) { }
        public virtual void Delete(SiteParam OSiteParam, string DanhMucChiSoId) { }
        public virtual DanhMucChiSoCls CreateModel(SiteParam OSiteParam, string DanhMucChiSoId) { return null; }
        public virtual string Duplicate(SiteParam OSiteParam, string DanhMucChiSoId) { return null; }
        public virtual DanhMucChiSoCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter) { return 0; }
        public virtual DanhMucChiSoCls[] Reading(SiteParam OSiteParam, string DichVuId) { return null; }
        public virtual DanhMucChiSoCls[] PageReading(SiteParam OSiteParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, ref int recordTotal) { return null; }
        public virtual DanhMucChiSoKiemTraChatLuongCls[] ReadingChiSoKiemTraChatLuong(SiteParam OSiteParam, string kiemtraid, int level) { return null; }

        public virtual DanhMucChiSoCls CreateModel(string connectstring, string DanhMucChiSoId) { return null; }
        public virtual string[] ReadingMaChiSoByChiSoIds(RenderInfoCls ORenderInfo, string[] Ids) { return null; }
    }
}
