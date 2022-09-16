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
    public class ViewForStart : ViewProfileExamTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "CHUYENKHAMBENH";
            }
        }

        public override string ServiceName
        {
            get
            {
                return "Màn hình ở điểm khám bệnh";
            }
        }

        public override string WorkflowStatus
        {
            get
            {
                return "CHUYENKHAMBENH";
            }
        }

        public override AjaxOut Draw(RenderInfoCls ORenderInfo, WorkflowInstanceCls OWorkflowInstance, WorkflowInstanceSessionCls OWorkflowInstanceSession, WorkflowInstanceSessionUserCls OWorkflowInstanceSessionUser)
        {
            AjaxOut
                 RetAjaxOut = new AjaxOut();

            RetAjaxOut.HtmlContent =
                "MAN HINH KHAM BENH" +
                "<button>Chuyyển xét nghiêm</button>\r\n" +
                "<button>Chuyyển XQUang</button>\r\n";

            return RetAjaxOut;
        }
    }
}
