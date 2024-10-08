﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;

namespace OneLIS.Bussiness.Template
{
   public interface IPatientProcess
   {
       string ServiceId { get; }
       PatientCls[] Reading(ActionSqlParamCls ActionSqlParam, PatientFilterCls OPatientFilter, bool HasCommit = false);
       StartWorkflowRetCls Add(ActionSqlParamCls ActionSqlParam, PatientCls OPatient, bool HasCommit = false);
       void Save(ActionSqlParamCls ActionSqlParam,  string PatientId,PatientCls OPatient, bool HasCommit = false);
       void Delete(ActionSqlParamCls ActionSqlParam,  string PatientId, bool HasCommit = false);
       PatientCls CreateModel(ActionSqlParamCls ActionSqlParam, string PatientId, bool HasCommit = false);
       string Duplicate(ActionSqlParamCls ActionSqlParam, string PatientId, bool HasCommit = false);
   }
   
   public class PatientTemplate : IPatientProcess
   {
       public virtual string ServiceId { get { return null; } }
       public virtual PatientCls[] Reading(ActionSqlParamCls ActionSqlParam, PatientFilterCls OPatientFilter, bool HasCommit = false) { return null; }
       public virtual StartWorkflowRetCls Add(ActionSqlParamCls ActionSqlParam, PatientCls OPatient, bool HasCommit = false) { return null; }
       public virtual void Save(ActionSqlParamCls ActionSqlParam, string PatientId, PatientCls OPatient, bool HasCommit = false) { }
       public virtual void Delete(ActionSqlParamCls ActionSqlParam, string PatientId, bool HasCommit = false) { }
       public virtual PatientCls CreateModel(ActionSqlParamCls ActionSqlParam, string PatientId, bool HasCommit = false) { return null; }
       public virtual string Duplicate(ActionSqlParamCls ActionSqlParam, string PatientId, bool HasCommit = false) { return null; }
   }
}
