﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucKiemTraProcess
    {
        string ServiceId { get; }
        DanhMucKiemTraCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraCls ODanhMucKiemTra, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKiemTraCls ODanhMucKiemTra, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKiemTraCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKiemTraCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucKiemTraCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, bool HasCommit = false);
        DanhMucKiemTraChiSoCls[] ReadingKiemTraChiSo(ActionSqlParamCls ActionSqlParam, bool HasCommit = false);
    }

    public class DanhMucKiemTraTemplate : IDanhMucKiemTraProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKiemTraCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraCls ODanhMucKiemTra, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKiemTraCls ODanhMucKiemTra, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucKiemTraCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucKiemTraCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucKiemTraCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucKiemTraFilterCls ODanhMucKiemTraFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucKiemTraChiSoCls[] ReadingKiemTraChiSo(ActionSqlParamCls ActionSqlParam, bool HasCommit = false) { return null; }
    }
}
