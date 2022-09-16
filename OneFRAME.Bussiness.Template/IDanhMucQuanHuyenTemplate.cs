using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucQuanHuyenProcess
    {
        string ServiceId { get; }
        DanhMucQuanHuyenCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenCls ODanhMucQuanHuyen);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucQuanHuyenCls ODanhMucQuanHuyen);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucQuanHuyenCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucQuanHuyenCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter);
        DanhMucQuanHuyenCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, ref int recordTotal);
        DanhMucQuanHuyenCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucQuanHuyenTemplate : IDanhMucQuanHuyenProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucQuanHuyenCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenCls ODanhMucQuanHuyen) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucQuanHuyenCls ODanhMucQuanHuyen) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucQuanHuyenCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucQuanHuyenCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter) { return 0; }
        public virtual DanhMucQuanHuyenCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter, ref int recordTotal) { return null; }
        public virtual DanhMucQuanHuyenCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
