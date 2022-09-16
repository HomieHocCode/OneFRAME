using OneLIS.Bussiness.Utility;
using OneLIS.Call.Bussiness.Utility;
using OneLIS.CheckPermissionUtility;
using OneLIS.Core.Model;using OneLIS.Model;
using OneLIS.Permission;
using OneLIS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLIS.WebParts
{
    public class WorkflowPatientView:WorkflowViewTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "WorkflowPatientView";
            }
        }

        public override string ObjectType
        {
            get
            {
                return "patient.profile";
            }
        }

        public override AjaxOut Draw(
            SiteParam OSiteParam, 
            RenderInfoCls ORenderInfo, 
            WorkflowInstanceCls OWorkflowInstance, 
            WorkflowInstanceSessionCls OWorkflowInstanceSession, 
            WorkflowInstanceSessionUserCls OWorkflowInstanceSessionUser)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            string Html = "";
            try
            {
                Html = "<div>" + OWorkflowInstanceSession.WorkflowProcessParam + "</div>\r\n";
                PatientCls
                    OPatient = CallBussinessUtility.CreateBussinessProcess().CreatePatientProcess().CreateModel(ORenderInfo, OWorkflowInstance.ObjectId);
                if (OPatient == null)
                {
                    throw new Exception("HO SO BI XOA MAT ROI");
                }

                IViewProfileExam Found = WorkflowViewUtility.Find(OSiteParam, OWorkflowInstanceSession.WorkflowProcessParam);
                if (Found == null)
                {
                    throw new Exception("CALL MR ABC");
                }

                return Found.Draw(ORenderInfo, OWorkflowInstance, OWorkflowInstanceSession, OWorkflowInstanceSessionUser);

            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }

            return RetAjaxOut;
        }
    }
}
