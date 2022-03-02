using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP
{
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                // code to export data from files to database
            }
            catch (Exception ex)
            {
                new ExceptionLogger.LogIntoFile(ex);
            }
        }
    }
}
