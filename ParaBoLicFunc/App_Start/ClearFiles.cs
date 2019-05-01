using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ParaBoLicFunc.App_Start
{
    public static class ClearFiles
    {
        public static void ClearFile()
        {
            string pathofDataSet = HostingEnvironment.MapPath("~/Data/DataSet.json");
            if (File.Exists(pathofDataSet))
            {
                File.WriteAllText(pathofDataSet, string.Empty);
            }
        }
    }
}