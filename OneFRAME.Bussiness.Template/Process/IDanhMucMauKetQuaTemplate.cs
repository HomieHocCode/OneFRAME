﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucMauKetQuaProcess
    {
        string ServiceId { get; }
        DanhMucMauKetQuaCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaCls ODanhMucMauKetQua, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucMauKetQuaCls ODanhMucMauKetQua, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucMauKetQuaCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucMauKetQuaCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucMauKetQuaCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, bool HasCommit = false);
    }

    public class DanhMucMauKetQuaTemplate : IDanhMucMauKetQuaProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucMauKetQuaCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaCls ODanhMucMauKetQua, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucMauKetQuaCls ODanhMucMauKetQua, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucMauKetQuaCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucMauKetQuaCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucMauKetQuaCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucMauKetQuaFilterCls ODanhMucMauKetQuaFilter, bool HasCommit = false) { return 0; }
    }
}
