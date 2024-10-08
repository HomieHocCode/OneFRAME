﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucDoiTuongProcess
    {
        string ServiceId { get; }
        DanhMucDoiTuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongCls ODanhMucDoiTuong, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDoiTuongCls ODanhMucDoiTuong, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucDoiTuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucDoiTuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucDoiTuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, bool HasCommit = false);
        DanhMucDoiTuongCls CreateModel(string connectstring, string DanhMucDoiTuongId, bool HasCommit = false);
    }

    public class DanhMucDoiTuongTemplate : IDanhMucDoiTuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDoiTuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongCls ODanhMucDoiTuong, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDoiTuongCls ODanhMucDoiTuong, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucDoiTuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucDoiTuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucDoiTuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucDoiTuongFilterCls ODanhMucDoiTuongFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucDoiTuongCls CreateModel(string connectstring, string DanhMucDoiTuongId, bool HasCommit = false) { return null; }
    }
}
