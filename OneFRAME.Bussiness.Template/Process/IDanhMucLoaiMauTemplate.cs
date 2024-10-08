﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucLoaiMauProcess
    {
        string ServiceId { get; }
        DanhMucLoaiMauCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauCls ODanhMucLoaiMau, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucLoaiMauCls ODanhMucLoaiMau, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucLoaiMauCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucLoaiMauCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucLoaiMauCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, bool HasCommit = false);

        DanhMucLoaiMauCls CreateModel(string connectstring, string Id, bool HasCommit = false);
    }

    public class DanhMucLoaiMauTemplate : IDanhMucLoaiMauProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucLoaiMauCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauCls ODanhMucLoaiMau, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucLoaiMauCls ODanhMucLoaiMau, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucLoaiMauCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucLoaiMauCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucLoaiMauCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucLoaiMauFilterCls ODanhMucLoaiMauFilter, bool HasCommit = false) { return 0; }

        public virtual DanhMucLoaiMauCls CreateModel(string connectstring, string Id, bool HasCommit = false) { return null; }
    }
}
