﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucDonViHanhChinhProcess
    {
        string ServiceId { get; }
        DanhMucDonViHanhChinhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter);
        void Add(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh);
        void Save(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh);
        void Delete(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId);
        DanhMucDonViHanhChinhCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId);
        string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId);
        DanhMucDonViHanhChinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize);
        long Count(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter);
        DanhMucDonViHanhChinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref int recordTotal);
    }

    public class DanhMucDonViHanhChinhTemplate : IDanhMucDonViHanhChinhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDonViHanhChinhCls[] Reading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh) { }
        public virtual void Save(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId) { }
        public virtual DanhMucDonViHanhChinhCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string DanhMucDonViHanhChinhId) { return null; }
        public virtual DanhMucDonViHanhChinhCls[] ReadingWithPaging(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter) { return 0; }
        public virtual DanhMucDonViHanhChinhCls[] PageReading(RenderInfoCls ORenderInfo, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref int recordTotal) { return null; }
    }
}
