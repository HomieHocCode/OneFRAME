using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucTinhThanhProcess
    {
        string ServiceId { get; }
        DanhMucTinhThanhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhCls ODanhMucTinhThanh);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucTinhThanhCls ODanhMucTinhThanh);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucTinhThanhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucTinhThanhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter);
        DanhMucTinhThanhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, ref int recordTotal);
        DanhMucTinhThanhCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucTinhThanhTemplate : IDanhMucTinhThanhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucTinhThanhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhCls ODanhMucTinhThanh) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucTinhThanhCls ODanhMucTinhThanh) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucTinhThanhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucTinhThanhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter) { return 0; }
        public virtual DanhMucTinhThanhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter, ref int recordTotal) { return null; }
        public virtual DanhMucTinhThanhCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
