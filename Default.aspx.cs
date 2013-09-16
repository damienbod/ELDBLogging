using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Code that runs on application startup
        LogWriter defaultWriter = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();

        defaultWriter.Write(new LogEntry("An Oli Log", "MyLog", 200, 0, System.Diagnostics.TraceEventType.Critical, "LogTitle", null));
       
    }
}
