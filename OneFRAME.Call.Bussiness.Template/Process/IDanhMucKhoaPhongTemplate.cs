﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucKhoaPhongProcess
    {
        string ServiceId { get; }
        DanhMucKhoaPhongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucKhoaPhongCls ODanhMucKhoaPhong);
        void Save(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId, DanhMucKhoaPhongCls ODanhMucKhoaPhong);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId);
        DanhMucKhoaPhongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId);
        DanhMucKhoaPhongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal);
        DanhMucKhoaPhongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter);
        DanhMucKhoaPhongCls[] PageReading(RenderInfoCls ORenderInfo, string sqlContent, int PageIndex, int PageSize, ref int recordTotal);

        DanhMucKhoaPhongCls[] Reading(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter);
        void Add(SiteParam OSiteParam, DanhMucKhoaPhongCls ODanhMucKhoaPhong);
        void Save(SiteParam OSiteParam, string DanhMucKhoaPhongId, DanhMucKhoaPhongCls ODanhMucKhoaPhong);
        void Delete(SiteParam OSiteParam, string DanhMucKhoaPhongId);
        DanhMucKhoaPhongCls CreateModel(SiteParam OSiteParam, string DanhMucKhoaPhongId);
        string Duplicate(SiteParam OSiteParam, string DanhMucKhoaPhongId);
        DanhMucKhoaPhongCls[] PageReading(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal);
        DanhMucKhoaPhongCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize);
        long Count(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter);
        DanhMucKhoaPhongCls[] PageReading(SiteParam OSiteParam, string sqlContent, int PageIndex, int PageSize, ref int recordTotal);

        DanhMucKhoaPhongCls CreateModel(string connectstring, string DanhMucKhoaPhongId);
    }

    public class DanhMucKhoaPhongTemplate : IDanhMucKhoaPhongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKhoaPhongCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucKhoaPhongCls ODanhMucKhoaPhong) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId, DanhMucKhoaPhongCls ODanhMucKhoaPhong) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId) { }
        public virtual DanhMucKhoaPhongCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKhoaPhongId) { return null; }
        public virtual DanhMucKhoaPhongCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal) { return null; }
        public virtual DanhMucKhoaPhongCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter) { return 0; }
        public virtual DanhMucKhoaPhongCls[] PageReading(RenderInfoCls ORenderInfo, string sqlContent, int PageIndex, int PageSize, ref int recordTotal) { return null; }

        public virtual DanhMucKhoaPhongCls[] Reading(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter) { return null; }
        public virtual void Add(SiteParam OSiteParam, DanhMucKhoaPhongCls ODanhMucKhoaPhong) { }
        public virtual void Save(SiteParam OSiteParam, string DanhMucKhoaPhongId, DanhMucKhoaPhongCls ODanhMucKhoaPhong) { }
        public virtual void Delete(SiteParam OSiteParam, string DanhMucKhoaPhongId) { }
        public virtual DanhMucKhoaPhongCls CreateModel(SiteParam OSiteParam, string DanhMucKhoaPhongId) { return null; }
        public virtual string Duplicate(SiteParam OSiteParam, string DanhMucKhoaPhongId) { return null; }
        public virtual DanhMucKhoaPhongCls[] PageReading(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal) { return null; }
        public virtual DanhMucKhoaPhongCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(SiteParam OSiteParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter) { return 0; }
        public virtual DanhMucKhoaPhongCls[] PageReading(SiteParam OSiteParam, string sqlContent, int PageIndex, int PageSize, ref int recordTotal) { return null; }

        public virtual DanhMucKhoaPhongCls CreateModel(string connectstring, string DanhMucKhoaPhongId) { return null; }
    }
}
