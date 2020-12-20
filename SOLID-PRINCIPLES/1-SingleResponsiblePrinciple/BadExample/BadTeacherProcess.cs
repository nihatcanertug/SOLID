using SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES._1_SingleResponsiblePrinciple.BadExample
{
    public class BadTeacherProcess
    {
        public void InsertTeacher(Teacher newTeacher)

        {
            StringBuilder sb = new StringBuilder();
            try
            {
                #region 1.Process=>Recording the Teacher's personal information
                sb.Append(newTeacher.Id);
                sb.AppendLine();
                sb.Append(newTeacher.FirstName);
                sb.AppendLine();
                sb.Append(newTeacher.LastName);
                sb.AppendLine();
                sb.Append(newTeacher.HireDate);
                File.WriteAllText(@"C:\SolidTeacherData.txt", sb.ToString());
                #endregion
                
            }
            catch (Exception ex)
            {
                #region 2.Process=>Logging of errors to be received during the insertion process
                sb = new StringBuilder();
                sb.Append("Error Date:");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Error Message:");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\SolidLog.txt", ToString());
                System.Windows.Forms.MessageBox.Show("Warning Error!");
                #endregion

            }
        }
    }
}
