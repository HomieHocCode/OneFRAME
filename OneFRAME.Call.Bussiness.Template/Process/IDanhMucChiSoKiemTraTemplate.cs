﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IDanhMucChiSoKiemTraProcess
    {
        string ServiceId { get; }
        void Add(RenderInfoCls ORenderInfo, DanhMucChiSoKiemTraCls ODanhMucChiSoKiemTra);
        void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string KiemTraId);
        DanhMucChiSoKiemTraCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiSoKiemTraId);
        string[] ChiSoIdByKiemTraId(RenderInfoCls ORenderInfo, string KiemTraid);
        string[] KiemTraIdByChiSoId(RenderInfoCls ORenderInfo, string chisoid);
        DanhMucChiSoKiemTraCls[] ReadingChiSoByKiemTra(RenderInfoCls ORenderInfo, string KiemTraid);
    }

    public class DanhMucChiSoKiemTraTemplate : IDanhMucChiSoKiemTraProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual void Add(RenderInfoCls ORenderInfo, DanhMucChiSoKiemTraCls ODanhMucChiSoKiemTra) { }
        public virtual void Delete(RenderInfoCls ORenderInfo, string ChiSoId, string KiemTraId) { }
        public virtual DanhMucChiSoKiemTraCls CreateModel(RenderInfoCls ORenderInfo, string DanhMucChiSoKiemTraId) { return null; }
        public virtual string[] ChiSoIdByKiemTraId(RenderInfoCls ORenderInfo, string KiemTraid) { return null; }
        public virtual string[] KiemTraIdByChiSoId(RenderInfoCls ORenderInfo, string chisoid) { return null; }
        public virtual DanhMucChiSoKiemTraCls[] ReadingChiSoByKiemTra(RenderInfoCls ORenderInfo, string KiemTraid) { return null; }
    }
}
