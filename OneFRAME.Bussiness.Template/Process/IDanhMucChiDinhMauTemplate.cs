﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucChiDinhMauProcess
    {
        string ServiceId { get; }
        DanhMucChiDinhMauCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauCls ODanhMucChiDinhMau, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucChiDinhMauCls ODanhMucChiDinhMau, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucChiDinhMauCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucChiDinhMauCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucChiDinhMauCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, bool HasCommit = false);
    }

    public class DanhMucChiDinhMauTemplate : IDanhMucChiDinhMauProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiDinhMauCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauCls ODanhMucChiDinhMau, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucChiDinhMauCls ODanhMucChiDinhMau, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucChiDinhMauCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucChiDinhMauCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucChiDinhMauCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucChiDinhMauFilterCls ODanhMucChiDinhMauFilter, bool HasCommit = false) { return 0; }
    }
}
