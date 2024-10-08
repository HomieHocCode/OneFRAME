﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucChiSoDichVuProcess
    {
        string ServiceId { get; }
        DanhMucChiSoDichVuCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu);
        void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string DichVuId);
        DanhMucChiSoDichVuCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiSoDichVuId);
        string[] ChiSoIdByDichVuId(RenderInfoCls ORenderInfo, string dichvuid);
        string[] DichVuIdByChiSoId(RenderInfoCls ORenderInfo, string chisoid);
        DanhMucChiSoDichVuCls[] ChiSo(RenderInfoCls ORenderInfo);
        string[] GetChiSoIdsByParentId(RenderInfoCls ORenderInfo, string ParentId);
        DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(RenderInfoCls ORenderInfo, string dichvuid);

        DanhMucChiSoDichVuCls[] Reading(SiteParam OSiteParam, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter);
        void Add(SiteParam OSiteParam, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu);
        void Delete(SiteParam OSiteParam, string ChiSoId, string DichVuId);
        DanhMucChiSoDichVuCls CreateModel(SiteParam OSiteParam, string DanhMucChiSoDichVuId);
        string[] ChiSoIdByDichVuId(SiteParam OSiteParam, string dichvuid);
        string[] DichVuIdByChiSoId(SiteParam OSiteParam, string chisoid);
        DanhMucChiSoDichVuCls[] ChiSo(SiteParam OSiteParam);
        string[] GetChiSoIdsByParentId(SiteParam OSiteParam, string ParentId);
        DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(SiteParam OSiteParam, string dichvuid);

        string[] ChiSoIdByDichVuId(string connectstring, string dichvuid);
        string[] DichVuIdByChiSoId(string connectstring, string chisoid);
    }

    public class DanhMucChiSoDichVuTemplate : IDanhMucChiSoDichVuProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiSoDichVuCls[] Reading(RenderInfoCls ORenderInfo, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string DichVuId) { }
        public virtual DanhMucChiSoDichVuCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiSoDichVuId) { return null; }
        public virtual string[] ChiSoIdByDichVuId(RenderInfoCls ORenderInfo, string dichvuid) { return null; }
        public virtual string[] DichVuIdByChiSoId(RenderInfoCls ORenderInfo, string chisoid) { return null; }
        public virtual DanhMucChiSoDichVuCls[] ChiSo(RenderInfoCls ORenderInfo) { return null; }
        public virtual string[] GetChiSoIdsByParentId(RenderInfoCls ORenderInfo, string ParentId) { return null; }
        public virtual DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(RenderInfoCls ORenderInfo, string dichvuid) { return null; }

        public virtual DanhMucChiSoDichVuCls[] Reading(SiteParam OSiteParam, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter) { return null; }
        public virtual void Add(SiteParam OSiteParam, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu) { }
        public virtual void Delete(SiteParam OSiteParam, string ChiSoId, string DichVuId) { }
        public virtual DanhMucChiSoDichVuCls CreateModel(SiteParam OSiteParam, string DanhMucChiSoDichVuId) { return null; }
        public virtual string[] ChiSoIdByDichVuId(SiteParam OSiteParam, string dichvuid) { return null; }
        public virtual string[] DichVuIdByChiSoId(SiteParam OSiteParam, string chisoid) { return null; }
        public virtual DanhMucChiSoDichVuCls[] ChiSo(SiteParam OSiteParam) { return null; }
        public virtual string[] GetChiSoIdsByParentId(SiteParam OSiteParam, string ParentId) { return null; }
        public virtual DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(SiteParam OSiteParam, string dichvuid) { return null; }

        public virtual string[] ChiSoIdByDichVuId(string connectstring, string dichvuid) { return null; }
        public virtual string[] DichVuIdByChiSoId(string connectstring, string chisoid) { return null; }
    }
}
