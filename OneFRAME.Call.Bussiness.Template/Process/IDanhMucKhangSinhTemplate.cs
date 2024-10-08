﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucKhangSinhProcess
    {
        string ServiceId { get; }
        DanhMucKhangSinhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucKhangSinhCls ODanhMucKhangSinh);
        void Save(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId, DanhMucKhangSinhCls ODanhMucKhangSinh);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId);
        DanhMucKhangSinhCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId);
        DanhMucKhangSinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, ref int recordTotal);
        DanhMucKhangSinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter);
        string[] GetKhangSinhIdsByViKhuanId(RenderInfoCls ORenderInfo, string DanhMucViKhuanId);
        DanhMucViKhuanKhangSinhCls[] Reading(RenderInfoCls ORenderInfo);
        void Add(RenderInfoCls ORenderInfo, string khangsinhid, string vikhuanid);
        void Delete(RenderInfoCls ORenderInfo, string khangsinhid, string vikhuanid);
    }

    public class DanhMucKhangSinhTemplate : IDanhMucKhangSinhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKhangSinhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucKhangSinhCls ODanhMucKhangSinh) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId, DanhMucKhangSinhCls ODanhMucKhangSinh) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId) { }
        public virtual DanhMucKhangSinhCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucKhangSinhId) { return null; }
        public virtual DanhMucKhangSinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, ref int recordTotal) { return null; }
        public virtual DanhMucKhangSinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter) { return 0; }
        public virtual string[] GetKhangSinhIdsByViKhuanId(RenderInfoCls ORenderInfo, string DanhMucViKhuanId) { return new string[] { }; }
        public virtual DanhMucViKhuanKhangSinhCls[] Reading(RenderInfoCls ORenderInfo) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, string khangsinhid, string vikhuanid) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string khangsinhid, string vikhuanid) { }
    }
}
