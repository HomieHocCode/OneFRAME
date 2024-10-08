﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucKyThuatXetNghiemProcess
    {
        string ServiceId { get; }
        DanhMucKyThuatXetNghiemCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKyThuatXetNghiemCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucKyThuatXetNghiemCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucKyThuatXetNghiemCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, bool HasCommit = false);
    }

    public class DanhMucKyThuatXetNghiemTemplate : IDanhMucKyThuatXetNghiemProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucKyThuatXetNghiemCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucKyThuatXetNghiemCls ODanhMucKyThuatXetNghiem, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucKyThuatXetNghiemCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucKyThuatXetNghiemCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucKyThuatXetNghiemCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucKyThuatXetNghiemFilterCls ODanhMucKyThuatXetNghiemFilter, bool HasCommit = false) { return 0; }
    }
}
