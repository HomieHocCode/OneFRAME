using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucVungMienProcess
    {
        string ServiceId { get; }
        DanhMucVungMienCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucVungMienCls ODanhMucVungMien);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucVungMienCls ODanhMucVungMien);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucVungMienCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucVungMienCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter);
        DanhMucVungMienCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter, ref int recordTotal);
        DanhMucVungMienCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucVungMienTemplate : IDanhMucVungMienProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucVungMienCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucVungMienCls ODanhMucVungMien) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucVungMienCls ODanhMucVungMien) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucVungMienCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucVungMienCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter) { return 0; }
        public virtual DanhMucVungMienCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucVungMienFilterCls ODanhMucVungMienFilter, ref int recordTotal) { return null; }
        public virtual DanhMucVungMienCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
