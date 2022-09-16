using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucXaPhuongProcess
    {
        string ServiceId { get; }
        DanhMucXaPhuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongCls ODanhMucXaPhuong);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucXaPhuongCls ODanhMucXaPhuong);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucXaPhuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucXaPhuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter);
        DanhMucXaPhuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, ref long recordTotal);
        DanhMucXaPhuongCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucXaPhuongTemplate : IDanhMucXaPhuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucXaPhuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongCls ODanhMucXaPhuong) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucXaPhuongCls ODanhMucXaPhuong) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucXaPhuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucXaPhuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter) { return 0; }
        public virtual DanhMucXaPhuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter, ref long recordTotal) { return null; }
        public virtual DanhMucXaPhuongCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
