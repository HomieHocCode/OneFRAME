﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucChiSoDichVuProcess
    {
        string ServiceId { get; }
        DanhMucChiSoDichVuCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu, bool HasCommit = false);       
        void Delete(ActionSqlParamCls ActionSqlParam, string ChiSoId, string DichVuId, bool HasCommit = false);
        DanhMucChiSoDichVuCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string[] ChiSoIdByDichVuId(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false);
        string[] DichVuIdByChiSoId(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false);
        DanhMucChiSoDichVuCls[] ChiSo(ActionSqlParamCls ActionSqlParam, bool HasCommit = false);
        string[] GetChiSoIdsByParentId(ActionSqlParamCls ActionSqlParam, string ParentId, bool HasCommit = false);
        DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false);

        string[] ChiSoIdByDichVuId(string connectstring, string dichvuid, bool HasCommit = false);
        string[] DichVuIdByChiSoId(string connectstring, string chisoid, bool HasCommit = false);
    }

    public class DanhMucChiSoDichVuTemplate : IDanhMucChiSoDichVuProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiSoDichVuCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiSoDichVuFilterCls ODanhMucChiSoDichVuFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiSoDichVuCls ODanhMucChiSoDichVu, bool HasCommit = false) { }        
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string ChiSoId, string DichVuId, bool HasCommit = false) { }
        public virtual DanhMucChiSoDichVuCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string[] ChiSoIdByDichVuId(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false) { return null; }
        public virtual string[] DichVuIdByChiSoId(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false) { return null; }
        public virtual DanhMucChiSoDichVuCls[] ChiSo(ActionSqlParamCls ActionSqlParam, bool HasCommit = false) { return null; }
        public virtual string[] GetChiSoIdsByParentId(ActionSqlParamCls ActionSqlParam, string ParentId, bool HasCommit = false) { return null; }
        public virtual DanhMucChiSoDichVuCls[] ReadingChiSoByDichVu(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false) { return null; }

        public virtual string[] ChiSoIdByDichVuId(string connectstring, string dichvuid, bool HasCommit = false) { return null; }
        public virtual string[] DichVuIdByChiSoId(string connectstring, string chisoid, bool HasCommit = false) { return null; }
    }
}
