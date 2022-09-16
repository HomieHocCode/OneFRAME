using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IDanhMucDonViHanhChinhProcess
    {
        string ServiceId { get; }
        DanhMucDonViHanhChinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter);
        void Add(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh);
        void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh);
        void Delete(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucDonViHanhChinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string Id);
        DanhMucDonViHanhChinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize);
        long Count(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter);
        DanhMucDonViHanhChinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref long recordTotal);
        DanhMucDonViHanhChinhCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten);
    }

    public class DanhMucDonViHanhChinhTemplate : IDanhMucDonViHanhChinhProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual DanhMucDonViHanhChinhCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id) { }
        public virtual DanhMucDonViHanhChinhCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id) { return null; }
        public virtual DanhMucDonViHanhChinhCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, int PageIndex, int PageSize) { return null; }
        public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter) { return 0; }
        public virtual DanhMucDonViHanhChinhCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter, ref long recordTotal) { return null; }
        public virtual DanhMucDonViHanhChinhCls CreateModelByTen(ActionSqlParamCls ActionSqlParam, string Ten) { return null; }
    }
}
