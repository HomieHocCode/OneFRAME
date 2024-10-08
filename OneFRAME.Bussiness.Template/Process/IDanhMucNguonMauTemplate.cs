﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucNguonMauProcess
    {
        string ServiceId { get; }
        DanhMucNguonMauCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauCls ODanhMucNguonMau, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucNguonMauCls ODanhMucNguonMau, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucNguonMauCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucNguonMauCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucNguonMauCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, bool HasCommit = false);
    }

    public class DanhMucNguonMauTemplate : IDanhMucNguonMauProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucNguonMauCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauCls ODanhMucNguonMau, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucNguonMauCls ODanhMucNguonMau, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucNguonMauCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucNguonMauCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucNguonMauCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucNguonMauFilterCls ODanhMucNguonMauFilter, bool HasCommit = false) { return 0; }
    }
}
