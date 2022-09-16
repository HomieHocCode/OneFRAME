using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Bussiness.Template
{
    public interface IUnitProcess
    {
        string ServiceId { get; }
        UnitCls[] Reading(ActionSqlParamCls ActionSqlParam, UnitFilterCls OUnitFilter, bool HasCommit = false);
        AjaxOut ReadingWithPage(ActionSqlParamCls ActionSqlParam, UnitFilterCls OUnitFilter, bool HasCommit = false);
        void Add(ActionSqlParamCls ActionSqlParam,  UnitCls OUnit, bool HasCommit = false);
        void Save(ActionSqlParamCls ActionSqlParam,  string UnitId,UnitCls OUnit, bool HasCommit = false);
        void Delete(ActionSqlParamCls ActionSqlParam,  string UnitId, bool HasCommit = false);
        UnitCls CreateModel(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false);
        string Duplicate(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false);
    }

    public class UnitTemplate : IUnitProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual UnitCls[] Reading(ActionSqlParamCls ActionSqlParam, UnitFilterCls OUnitFilter, bool HasCommit = false) { return null; }
        public virtual AjaxOut ReadingWithPage(ActionSqlParamCls ActionSqlParam, UnitFilterCls OUnitFilter, bool HasCommit = false) { return null; }
        public virtual void Add(ActionSqlParamCls ActionSqlParam, UnitCls OUnit, bool HasCommit = false) { }
        public virtual void Save(ActionSqlParamCls ActionSqlParam, string UnitId, UnitCls OUnit, bool HasCommit = false) { }
        public virtual void Delete(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false) { }
        public virtual UnitCls CreateModel(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false) { return null; }
        public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string UnitId, bool HasCommit = false) { return null; }
    }
}
