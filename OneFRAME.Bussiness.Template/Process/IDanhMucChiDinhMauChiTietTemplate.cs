﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucChiDinhMauChiTietProcess
    {
        string ServiceId { get; }
        DanhMucChiDinhMauChiTietCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauChiTietFilterCls ODanhMucChiDinhMauChiTietFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauChiTietCls ODanhMucChiDinhMauChiTiet, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string ChiSoId, string DichVuId, bool HasCommit = false);
        DanhMucChiDinhMauChiTietCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string[] ChiSoIdByDichVuId(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false);
        DanhMucChiDinhMauChiTietCls[] ChiSo(ActionSqlParamCls ActionSqlParam, bool HasCommit = false);
        string[] GetChiSoIdsByParentId(ActionSqlParamCls ActionSqlParam, string ParentId, bool HasCommit = false);
        DanhMucChiDinhMauChiTietCls[] ReadingChiSoByDichVu(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false);
    }

    public class DanhMucChiDinhMauChiTietTemplate : IDanhMucChiDinhMauChiTietProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiDinhMauChiTietCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauChiTietFilterCls ODanhMucChiDinhMauChiTietFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauChiTietCls ODanhMucChiDinhMauChiTiet, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string ChiSoId, string DichVuId, bool HasCommit = false) { }
        public virtual DanhMucChiDinhMauChiTietCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string[] ChiSoIdByDichVuId(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false) { return null; }
        public virtual DanhMucChiDinhMauChiTietCls[] ChiSo(ActionSqlParamCls ActionSqlParam, bool HasCommit = false) { return null; }
        public virtual string[] GetChiSoIdsByParentId(ActionSqlParamCls ActionSqlParam, string ParentId, bool HasCommit = false) { return null; }
        public virtual DanhMucChiDinhMauChiTietCls[] ReadingChiSoByDichVu(ActionSqlParamCls ActionSqlParam, string dichvuid, bool HasCommit = false) { return null; }
    }
}
