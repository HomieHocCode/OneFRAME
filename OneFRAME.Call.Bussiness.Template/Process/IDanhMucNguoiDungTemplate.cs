﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucNguoiDungProcess
    {
        string ServiceId { get; }
        DanhMucNguoiDungCls[] Reading(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucNguoiDungCls ODanhMucNguoiDung);
        void Save(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId, DanhMucNguoiDungCls ODanhMucNguoiDung);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId);
        DanhMucNguoiDungCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId);
        DanhMucNguoiDungCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, ref int recordTotal);
        DanhMucNguoiDungCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter);

        DanhMucNguoiDungCls[] Reading(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter);
        void Add(SiteParam OSiteParam, DanhMucNguoiDungCls ODanhMucNguoiDung);
        void Save(SiteParam OSiteParam, string DanhMucNguoiDungId, DanhMucNguoiDungCls ODanhMucNguoiDung);
        void Delete(SiteParam OSiteParam, string DanhMucNguoiDungId);
        DanhMucNguoiDungCls CreateModel(SiteParam OSiteParam, string DanhMucNguoiDungId);
        string Duplicate(SiteParam OSiteParam, string DanhMucNguoiDungId);
        DanhMucNguoiDungCls[] PageReading(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, ref int recordTotal);
        DanhMucNguoiDungCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, int PageIndex, int PageSize);
        long Count(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter);

        DanhMucNguoiDungCls CreateModel(string connectstring, string DanhMucNguoiDungId);
    }

    public class DanhMucNguoiDungTemplate : IDanhMucNguoiDungProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucNguoiDungCls[] Reading(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucNguoiDungCls ODanhMucNguoiDung) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId, DanhMucNguoiDungCls ODanhMucNguoiDung) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId) { }
        public virtual DanhMucNguoiDungCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucNguoiDungId) { return null; }
        public virtual DanhMucNguoiDungCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, ref int recordTotal) { return null; }
        public virtual DanhMucNguoiDungCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter) { return 0; }

        public virtual DanhMucNguoiDungCls[] Reading(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter) { return null; }
        public virtual void Add(SiteParam OSiteParam, DanhMucNguoiDungCls ODanhMucNguoiDung) { }
        public virtual void Save(SiteParam OSiteParam, string DanhMucNguoiDungId, DanhMucNguoiDungCls ODanhMucNguoiDung) { }
        public virtual void Delete(SiteParam OSiteParam, string DanhMucNguoiDungId) { }
        public virtual DanhMucNguoiDungCls CreateModel(SiteParam OSiteParam, string DanhMucNguoiDungId) { return null; }
        public virtual string Duplicate(SiteParam OSiteParam, string DanhMucNguoiDungId) { return null; }
        public virtual DanhMucNguoiDungCls[] PageReading(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, ref int recordTotal) { return null; }
        public virtual DanhMucNguoiDungCls[] ReadingWithPaging(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(SiteParam OSiteParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter) { return 0; }

        public virtual DanhMucNguoiDungCls CreateModel(string connectstring, string DanhMucNguoiDungId) { return null; }
    }
}
