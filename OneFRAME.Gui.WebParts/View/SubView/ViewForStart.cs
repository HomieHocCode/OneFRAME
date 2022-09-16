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
    public class ViewForDoctor : ViewProfileExamTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "Start";
            }
        }

        public override string ServiceName
        {
            get
            {
                return "Màn hình ở điểm start";
            }
        }

        public override string WorkflowStatus
        {
            get
            {
                return "Start";
            }
        }

        public override AjaxOut Draw(RenderInfoCls ORenderInfo, WorkflowInstanceCls OWorkflowInstance, WorkflowInstanceSessionCls OWorkflowInstanceSession, WorkflowInstanceSessionUserCls OWorkflowInstanceSessionUser)
        {
            AjaxOut
                 RetAjaxOut = new AjaxOut();

            RetAjaxOut.HtmlContent = "MAN HINH BAT DAU";

            return RetAjaxOut;
        }
    }
}
