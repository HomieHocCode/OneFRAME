using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Call.Bussiness.Template
{
    public interface IUnitProcess
    {
        string ServiceId { get; }
        UnitCls[] Reading(RenderInfoCls ORenderInfo,  UnitFilterCls OUnitFilter);
        AjaxOut ReadingWithPage(RenderInfoCls ORenderInfo, UnitFilterCls OUnitFilter);
        void Add(RenderInfoCls ORenderInfo,   UnitCls OUnit);
        void Save(RenderInfoCls ORenderInfo,   string UnitId,UnitCls OUnit);
        void Delete(RenderInfoCls ORenderInfo,   string UnitId);
        UnitCls CreateModel(RenderInfoCls ORenderInfo,  string UnitId);
        string Duplicate(RenderInfoCls ORenderInfo, string UnitId);
    }

    public class UnitTemplate : IUnitProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual UnitCls[] Reading(RenderInfoCls ORenderInfo,  UnitFilterCls OUnitFilter) { return null; }
        public virtual AjaxOut ReadingWithPage(RenderInfoCls ORenderInfo, UnitFilterCls OUnitFilter) { return null; }
        public virtual void Add(RenderInfoCls ORenderInfo,  UnitCls OUnit) { }
        public virtual void Save(RenderInfoCls ORenderInfo,  string UnitId, UnitCls OUnit) { }
        public virtual void Delete(RenderInfoCls ORenderInfo,  string UnitId) { }
        public virtual UnitCls CreateModel(RenderInfoCls ORenderInfo,  string UnitId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string UnitId) { return null; }
    }
}
