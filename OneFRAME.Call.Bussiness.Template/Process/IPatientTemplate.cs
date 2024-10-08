﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Call.Bussiness.Template
{
    public interface IPatientProcess
    {
        string ServiceId { get; }
        PatientCls[] Reading(RenderInfoCls ORenderInfo,  PatientFilterCls OPatientFilter);
        StartWorkflowRetCls Add(RenderInfoCls ORenderInfo, PatientCls OPatient);
        void Save(RenderInfoCls ORenderInfo,   string PatientId,PatientCls OPatient);
        void Delete(RenderInfoCls ORenderInfo,   string PatientId);
        PatientCls CreateModel(RenderInfoCls ORenderInfo,  string PatientId);
        string Duplicate(RenderInfoCls ORenderInfo, string PatientId);
    }

    public class PatientTemplate : IPatientProcess
    {
        public virtual string ServiceId { get { return null; } }
        public virtual PatientCls[] Reading(RenderInfoCls ORenderInfo,  PatientFilterCls OPatientFilter) { return null; }
        public virtual StartWorkflowRetCls Add(RenderInfoCls ORenderInfo, PatientCls OPatient) { return null; }
        public virtual void Save(RenderInfoCls ORenderInfo,  string PatientId, PatientCls OPatient) { }
        public virtual void Delete(RenderInfoCls ORenderInfo,  string PatientId) { }
        public virtual PatientCls CreateModel(RenderInfoCls ORenderInfo,  string PatientId) { return null; }
        public virtual string Duplicate(RenderInfoCls ORenderInfo, string PatientId) { return null; }
    }
}
