﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucThietBiProcess
    {
        string ServiceId { get; }
        DanhMucThietBiCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucThietBiCls ODanhMucThietBi, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucThietBiCls ODanhMucThietBi, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucThietBiCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucThietBiCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucThietBiCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, bool HasCommit = false);
    }

    public class DanhMucThietBiTemplate : IDanhMucThietBiProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucThietBiCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucThietBiCls ODanhMucThietBi, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucThietBiCls ODanhMucThietBi, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucThietBiCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucThietBiCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucThietBiCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucThietBiFilterCls ODanhMucThietBiFilter, bool HasCommit = false) { return 0; }
    }
}
