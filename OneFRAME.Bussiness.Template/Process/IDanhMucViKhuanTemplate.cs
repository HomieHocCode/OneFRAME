﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucViKhuanProcess
    {
        string ServiceId { get; }
        DanhMucViKhuanCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanCls ODanhMucViKhuan, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucViKhuanCls ODanhMucViKhuan, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucViKhuanCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucViKhuanCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucViKhuanCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, bool HasCommit = false);
    }

    public class DanhMucViKhuanTemplate : IDanhMucViKhuanProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucViKhuanCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanCls ODanhMucViKhuan, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucViKhuanCls ODanhMucViKhuan, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucViKhuanCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucViKhuanCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucViKhuanCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucViKhuanFilterCls ODanhMucViKhuanFilter, bool HasCommit = false) { return 0; }
    }
}
