﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucKhangSinhProcess
    {
        string ServiceId { get; }
        DanhMucKhangSinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhCls ODanhMucKhangSinh, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKhangSinhCls ODanhMucKhangSinh, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKhangSinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKhangSinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucKhangSinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, bool HasCommit = false);
        string[] GetKhangSinhIdsByViKhuanId(ActionSqlParamCls ActionSqlParam, string DanhMucViKhuanId, bool HasCommit = false);
        DanhMucViKhuanKhangSinhCls[] Reading(ActionSqlParamCls ActionSqlParam, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, string khangsinhid, string vikhuanid, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string khangsinhid, string vikhuanid, bool HasCommit = false);
    }

    public class DanhMucKhangSinhTemplate : IDanhMucKhangSinhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKhangSinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhCls ODanhMucKhangSinh, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKhangSinhCls ODanhMucKhangSinh, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucKhangSinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucKhangSinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucKhangSinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucKhangSinhFilterCls ODanhMucKhangSinhFilter, bool HasCommit = false) { return 0; }
        public virtual string[] GetKhangSinhIdsByViKhuanId(ActionSqlParamCls ActionSqlParam, string DanhMucViKhuanId, bool HasCommit = false) { return new string[] { }; }
        public virtual DanhMucViKhuanKhangSinhCls[] Reading(ActionSqlParamCls ActionSqlParam, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, string khangsinhid, string vikhuanid, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string khangsinhid, string vikhuanid, bool HasCommit = false) { }
    }
}
