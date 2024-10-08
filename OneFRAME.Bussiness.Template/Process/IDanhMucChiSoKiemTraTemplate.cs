﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucChiSoKiemTraProcess
    {
        string ServiceId { get; }
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiSoKiemTraCls ODanhMucChiSoKiemTra, bool HasCommit = false);       
        void Delete(ActionSqlParamCls ActionSqlParam, string ChiSoId, string KiemTraId, bool HasCommit = false);
        DanhMucChiSoKiemTraCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string[] ChiSoIdByKiemTraId(ActionSqlParamCls ActionSqlParam, string KiemTraid, bool HasCommit = false);
        string[] KiemTraIdByChiSoId(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false);
        DanhMucChiSoKiemTraCls[] ReadingChiSoByKiemTra(ActionSqlParamCls ActionSqlParam, string KiemTraid, bool HasCommit = false);
    }

    public class DanhMucChiSoKiemTraTemplate : IDanhMucChiSoKiemTraProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiSoKiemTraCls ODanhMucChiSoKiemTra, bool HasCommit = false) { }        
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string ChiSoId, string KiemTraId, bool HasCommit = false) { }
        public virtual DanhMucChiSoKiemTraCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string[] ChiSoIdByKiemTraId(ActionSqlParamCls ActionSqlParam, string KiemTraid, bool HasCommit = false) { return null; }
        public virtual string[] KiemTraIdByChiSoId(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false) { return null; }
        public virtual DanhMucChiSoKiemTraCls[] ReadingChiSoByKiemTra(ActionSqlParamCls ActionSqlParam, string KiemTraid, bool HasCommit = false) { return null; }
    }
}
