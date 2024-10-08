﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucKhoaPhongProcess
    {
        string ServiceId { get; }
        DanhMucKhoaPhongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongCls ODanhMucKhoaPhong, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKhoaPhongCls ODanhMucKhoaPhong, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKhoaPhongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKhoaPhongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucKhoaPhongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, bool HasCommit = false);
        DanhMucKhoaPhongCls[] PageReading(ActionSqlParamCls ActionSqlParam, string sqlContent, int PageIndex, int PageSize, ref int recordTotal, bool HasCommit = false);

        DanhMucKhoaPhongCls CreateModel(string connectstring, string Id, bool HasCommit = false);
    }

    public class DanhMucKhoaPhongTemplate : IDanhMucKhoaPhongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKhoaPhongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongCls ODanhMucKhoaPhong, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKhoaPhongCls ODanhMucKhoaPhong, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucKhoaPhongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucKhoaPhongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucKhoaPhongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucKhoaPhongFilterCls ODanhMucKhoaPhongFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucKhoaPhongCls[] PageReading(ActionSqlParamCls ActionSqlParam, string sqlContent, int PageIndex, int PageSize, ref int recordTotal, bool HasCommit = false) { return null; }

        public virtual DanhMucKhoaPhongCls CreateModel(string connectstring, string Id, bool HasCommit = false) { return null; }
    }
}
