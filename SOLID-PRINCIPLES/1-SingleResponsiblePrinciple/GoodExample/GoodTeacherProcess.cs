using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.GoodExample
{
    public class GoodTeacherProcess:GoodLogerProcess
    {
        GoodTeacherProcess logger;
        public GoodTeacherProcess()
        {
            logger = new GoodTeacherProcess();
        }

        string log;
        public bool InsertTeacher(Teacher newTeacher)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(newTeacher.Id);
                sb.AppendLine();
                sb.Append(newTeacher.FirstName);
                sb.AppendLine();
                sb.Append(newTeacher.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SolidLog.txt", log);

                log = logger.BuildLog($"Teacher insert successfull => {newTeacher.Id}");
                logger.LogFile(@"C:\SolidLog.txt", log);
                return true;

            }
            catch (Exception ex)
            {

                log = logger.BuildLog("Error Message:" + ex.Message);
                logger.LogFile(@"C:\SolidLog.txt", log);

                return false;

            }
        }
    }
}
