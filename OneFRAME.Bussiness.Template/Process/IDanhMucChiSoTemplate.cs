﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
    public interface IDanhMucChiSoProcess
    {
        string ServiceId { get; }
        DanhMucChiSoCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiSoCls ODanhMucChiSo, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucChiSoCls ODanhMucChiSo, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucChiSoCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
        DanhMucChiSoCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, int PageIndex, int PageSize, bool HasCommit = false);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, bool HasCommit = false);
        DanhMucChiSoCls[] Reading(ActionSqlParamCls ActionSqlParam, string DichVuId, bool HasCommit = false);
        DanhMucChiSoCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, ref int recordTotal, bool HasCommit = false);
        DanhMucChiSoKiemTraChatLuongCls[] ReadingChiSoKiemTraChatLuong(ActionSqlParamCls ActionSqlParam, string kiemtraid, int level, bool HasCommit = false);

        DanhMucChiSoCls CreateModel(string connectstring, string Id, bool HasCommit = false);
        string[] ReadingMaChiSoByChiSoIds(ActionSqlParamCls ActionSqlParam, string[] Ids, bool HasCommit = false);
    }

    public class DanhMucChiSoTemplate : IDanhMucChiSoProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucChiSoCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucChiSoCls ODanhMucChiSo, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucChiSoCls ODanhMucChiSo, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
        public virtual DanhMucChiSoCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
        public virtual DanhMucChiSoCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, bool HasCommit = false) { return 0; }
        public virtual DanhMucChiSoCls[] Reading(ActionSqlParamCls ActionSqlParam, string DichVuId, bool HasCommit = false) { return null; }
        public virtual DanhMucChiSoCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucChiSoFilterCls ODanhMucChiSoFilter, ref int recordTotal, bool HasCommit = false) { return null; }
        public virtual DanhMucChiSoKiemTraChatLuongCls[] ReadingChiSoKiemTraChatLuong(ActionSqlParamCls ActionSqlParam, string kiemtraid, int level, bool HasCommit = false) { return null; }

        public virtual DanhMucChiSoCls CreateModel(string connectstring, string Id, bool HasCommit = false) { return null; }
        public virtual string[] ReadingMaChiSoByChiSoIds(ActionSqlParamCls ActionSqlParam, string[] Ids, bool HasCommit = false) { return null; }
    }
}
