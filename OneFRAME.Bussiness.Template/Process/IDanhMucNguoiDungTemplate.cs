﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucNguoiDungProcess
    {
        string ServiceId { get; }
        DanhMucNguoiDungCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungCls ODanhMucNguoiDung, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucNguoiDungCls ODanhMucNguoiDung, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucNguoiDungCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucNguoiDungCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucNguoiDungCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, bool HasCommit = false);

        DanhMucNguoiDungCls CreateModel(string connectstring, string Id, bool HasCommit = false);
    }

    public class DanhMucNguoiDungTemplate : IDanhMucNguoiDungProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucNguoiDungCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungCls ODanhMucNguoiDung, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucNguoiDungCls ODanhMucNguoiDung, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucNguoiDungCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucNguoiDungCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucNguoiDungCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucNguoiDungFilterCls ODanhMucNguoiDungFilter, bool HasCommit = false) { return 0; }

        public virtual DanhMucNguoiDungCls CreateModel(string connectstring, string Id, bool HasCommit = false) { return null; }
    }
}
