using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucQuocGiaProcess
    {
        string ServiceId { get; }
        DanhMucQuocGiaCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaCls ODanhMucQuocGia);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucQuocGiaCls ODanhMucQuocGia);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucQuocGiaCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucQuocGiaCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter);
        DanhMucQuocGiaCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, ref int recordTotal);
        DanhMucQuocGiaCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucQuocGiaTemplate : IDanhMucQuocGiaProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucQuocGiaCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaCls ODanhMucQuocGia) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucQuocGiaCls ODanhMucQuocGia) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucQuocGiaCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucQuocGiaCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter) { return 0; }
        public virtual DanhMucQuocGiaCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter, ref int recordTotal) { return null; }
        public virtual DanhMucQuocGiaCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
