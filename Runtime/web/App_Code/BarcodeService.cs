using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;
using System.Web.Http;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBarcodeService" in both code and config file together.
[ServiceContract]
public interface IBarcodeService
{
    [OperationContract]
    void DoWork();
}
public class BarcodeServiceRecord
{
    public int Token { get; set; }
    public string Message { get; set; }
}
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class BarcodeService : IBarcodeService
{
    public void DoWork() { }    
}
