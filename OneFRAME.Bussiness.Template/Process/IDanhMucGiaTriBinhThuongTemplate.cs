﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucGiaTriBinhThuongProcess
    {
        string ServiceId { get; }
        DanhMucGiaTriBinhThuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucGiaTriBinhThuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucGiaTriBinhThuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucGiaTriBinhThuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, bool HasCommit = false);
        DanhMucGiaTriBinhThuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string ChiSoId, string ThietBiId, bool HasCommit = false);
    }

    public class DanhMucGiaTriBinhThuongTemplate : IDanhMucGiaTriBinhThuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucGiaTriBinhThuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucGiaTriBinhThuongCls ODanhMucGiaTriBinhThuong, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucGiaTriBinhThuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucGiaTriBinhThuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucGiaTriBinhThuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucGiaTriBinhThuongFilterCls ODanhMucGiaTriBinhThuongFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucGiaTriBinhThuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string ChiSoId, string ThietBiId, bool HasCommit = false) { return null; }
    }
}
