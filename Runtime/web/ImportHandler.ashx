﻿<%@ WebHandler Language="C#" Class="ImportHandler" %>
using System;
using System.Web;

public class ImportHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        OneFRAME.UploadUtility.ProcessImportHandlerUtility.ProcessRequestSessionImportFile(context);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}

