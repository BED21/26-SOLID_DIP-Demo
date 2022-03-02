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
            catch (IOException ex)
            {
                ExceptionLogger.LogIntoDatabase(ex);
            }
            catch (Exception ex)
            {
                ExceptionLogger.LogIntoFile(ex);
            }
        }
    }
}
