using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
   public interface IDanhMucDichVuProcess
   {
       string ServiceId { get; }
       DanhMucDichVuCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false);
       void Add(ActionSqlParamCls ActionSqlParam,  DanhMucDichVuCls ODanhMucDichVu, bool HasCommit = false);
       void Save(ActionSqlParamCls ActionSqlParam,  string Id,DanhMucDichVuCls ODanhMucDichVu, bool HasCommit = false);
       void Delete(ActionSqlParamCls ActionSqlParam,  string Id, bool HasCommit = false);
       DanhMucDichVuCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
       string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false);
       DanhMucDichVuCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false);
       long Count(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false);
       DanhMucDichVuCls[] ReadingWithPagingDichVu(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize, bool HasCommit = false);
       long CountDichVu(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false);
       DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(ActionSqlParamCls ActionSqlParam, bool HasCommit = false);
       DanhMucDichVuCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal, bool HasCommit = false);

       DanhMucDichVuCls CreateModel(string connectstring, string Id, bool HasCommit = false);
   }
   
   public class DanhMucDichVuTemplate : IDanhMucDichVuProcess
   {
       public virtual string ServiceId { get { return null; } }
       public virtual DanhMucDichVuCls[] Reading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false) { return null; }
       public virtual void Add(ActionSqlParamCls ActionSqlParam, DanhMucDichVuCls ODanhMucDichVu, bool HasCommit = false) { }
       public virtual void Save(ActionSqlParamCls ActionSqlParam, string Id, DanhMucDichVuCls ODanhMucDichVu, bool HasCommit = false) { }
       public virtual void Delete(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { }
       public virtual DanhMucDichVuCls CreateModel(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
       public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string Id, bool HasCommit = false) { return null; }
       public virtual DanhMucDichVuCls[] ReadingWithPaging(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false) { return null; }
       public virtual long Count(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false) { return 0; }
       public virtual DanhMucDichVuCls[] ReadingWithPagingDichVu(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, int PageIndex, int PageSize, bool HasCommit = false) { return null; }
       public virtual long CountDichVu(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, bool HasCommit = false) { return 0; }
       public virtual DanhMucLoaiDichVuXetNghiemCls[] ReadingLoaiDichVuXetNghiem(ActionSqlParamCls ActionSqlParam, bool HasCommit = false) { return null; }
       public virtual DanhMucDichVuCls[] PageReading(ActionSqlParamCls ActionSqlParam, DanhMucDichVuFilterCls ODanhMucDichVuFilter, ref int recordTotal, bool HasCommit = false) { return null; }

       public virtual DanhMucDichVuCls CreateModel(string connectstring, string Id, bool HasCommit = false) { return null; }
   }
}
