using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucICDChuongProcess
    {
        string ServiceId { get; }
        DanhMucICDChuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongCls ODanhMucICDChuong);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucICDChuongCls ODanhMucICDChuong);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucICDChuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucICDChuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter);
        //----------
        DanhMucICDChuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, ref int recordTotal);
       //-------------
        DanhMucICDChuongCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucICDChuongTemplate : IDanhMucICDChuongProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucICDChuongCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongCls ODanhMucICDChuong) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucICDChuongCls ODanhMucICDChuong) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucICDChuongCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucICDChuongCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter) { return 0; }
        public virtual DanhMucICDChuongCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucICDChuongFilterCls ODanhMucICDChuongFilter, ref int recordTotal) { return null; }//----
        public virtual DanhMucICDChuongCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
