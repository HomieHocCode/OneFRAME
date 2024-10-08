﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucLoaiXetNghiemProcess
    {
        string ServiceId { get; }
        DanhMucLoaiXetNghiemCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucLoaiXetNghiemCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucLoaiXetNghiemCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucLoaiXetNghiemCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, bool HasCommit = false);

        DanhMucLoaiXetNghiemCls CreateModel(string connectstring, string Id, bool HasCommit = false);
    }

    public class DanhMucLoaiXetNghiemTemplate : IDanhMucLoaiXetNghiemProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucLoaiXetNghiemCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucLoaiXetNghiemCls ODanhMucLoaiXetNghiem, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucLoaiXetNghiemCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucLoaiXetNghiemCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucLoaiXetNghiemCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucLoaiXetNghiemFilterCls ODanhMucLoaiXetNghiemFilter, bool HasCommit = false) { return 0; }

        public virtual DanhMucLoaiXetNghiemCls CreateModel(string connectstring, string Id, bool HasCommit = false) { return null; }
    }
}
