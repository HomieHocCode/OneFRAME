﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using OneLIS.Core.Model;using OneLIS.Model;
using OneLIS.Call.Bussiness.Template;
using OneLIS.Utility;
using OneLIS.Bussiness.Utility;

namespace OneLIS.Call.Bussiness.Ws
{
    public class PatientProcessBll : PatientTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "SqlPatientProcessBll";
            }
        }


        public override PatientCls[] Reading(
            RenderInfoCls ORenderInfo,
            PatientFilterCls OPatientFilter)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreatePatientProcess().Reading(ActionSqlParam, OPatientFilter);
        }


        public override StartWorkflowRetCls Add(RenderInfoCls ORenderInfo, PatientCls OPatient)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreatePatientProcess().Add(ActionSqlParam, OPatient);
        }

        public override void Save(RenderInfoCls ORenderInfo, string PatientId, PatientCls OPatient)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreatePatientProcess().Save(ActionSqlParam, PatientId, OPatient);
        }

        public override void Delete(RenderInfoCls ORenderInfo, string PatientId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            OneLISBussinessUtility.CreateBussinessProcess().CreatePatientProcess().Delete(ActionSqlParam, PatientId);
        }

        public override PatientCls CreateModel(RenderInfoCls ORenderInfo, string PatientId)
        {
            ActionSqlParamCls
                ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreatePatientProcess().CreateModel(ActionSqlParam, PatientId);
        }

        public override string Duplicate(RenderInfoCls ORenderInfo, string PatientId)
        {
            ActionSqlParamCls
               ActionSqlParam = WebEnvironments.CreateActionSqlParam(ORenderInfo);
            return OneLISBussinessUtility.CreateBussinessProcess().CreatePatientProcess().Duplicate(ActionSqlParam, PatientId);
        }
    }
}
