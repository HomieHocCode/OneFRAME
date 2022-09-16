﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucIcdProcess
    {
        string ServiceId { get; }
        DanhMucIcdCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucIcdCls ODanhMucIcd, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucIcdCls ODanhMucIcd, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucIcdCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucIcdCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucIcdCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, bool HasCommit = false);
    }

    public class DanhMucIcdTemplate : IDanhMucIcdProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucIcdCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucIcdCls ODanhMucIcd, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucIcdCls ODanhMucIcd, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucIcdCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucIcdCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucIcdCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucIcdFilterCls ODanhMucIcdFilter, bool HasCommit = false) { return 0; }
    }
}
