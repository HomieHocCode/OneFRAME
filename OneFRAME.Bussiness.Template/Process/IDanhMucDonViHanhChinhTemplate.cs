﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucDonViHanhChinhProcess
    {
        string ServiceId { get; }
        DanhMucDonViHanhChinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucDonViHanhChinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucDonViHanhChinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, bool HasCommit = false);
        DanhMucDonViHanhChinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref int recordTotal, bool HasCommit = false);
    }

    public class DanhMucDonViHanhChinhTemplate : IDanhMucDonViHanhChinhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDonViHanhChinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucDonViHanhChinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucDonViHanhChinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucDonViHanhChinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref int recordTotal, bool HasCommit = false) { return null; }
    }
}
