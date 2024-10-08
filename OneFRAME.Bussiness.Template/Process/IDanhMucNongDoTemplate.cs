﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucNongDoProcess
    {
        string ServiceId { get; }
        DanhMucNongDoCls[] Reading(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucNongDoCls ODanhMucNongDo, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucNongDoCls ODanhMucNongDo, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucNongDoCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucNongDoCls[] PageReading(ActionSqlParamCls ActionSqlParam, string chisoid, int PageIndex, ref int recordTotal, bool HasCommit = false);
        DanhMucNongDoCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, string chisoid, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false);
    }

    public class DanhMucNongDoTemplate : IDanhMucNongDoProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucNongDoCls[] Reading(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucNongDoCls ODanhMucNongDo, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucNongDoCls ODanhMucNongDo, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucNongDoCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucNongDoCls[] PageReading(ActionSqlParamCls ActionSqlParam, string chisoid, int PageIndex, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucNongDoCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, string chisoid, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, string chisoid, bool HasCommit = false) { return 0; }
    }
}
