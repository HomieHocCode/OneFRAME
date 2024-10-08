﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucDichVuLienKetProcess
    {
        string ServiceId { get; }
        DanhMucDichVuLienKetCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucDichVuLienKetCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucDichVuLienKetCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucDichVuLienKetCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, bool HasCommit = false);
        DanhMucDichVuLienKetCls[] Reading(string connectstring, bool HasCommit = false);
    }

    public class DanhMucDichVuLienKetTemplate : IDanhMucDichVuLienKetProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDichVuLienKetCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDichVuLienKetCls ODanhMucDichVuLienKet, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucDichVuLienKetCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucDichVuLienKetCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucDichVuLienKetCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucDichVuLienKetFilterCls ODanhMucDichVuLienKetFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucDichVuLienKetCls[] Reading(string connectstring, bool HasCommit = false) { return null; }
    }
}
