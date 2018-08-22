using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheRealWebCam
{
    public class DataAccessLayer //: IDataAccessLayer
    {
        #region Declarations

        // myDB;
        //Appointment app = new Appointment();
        //Employee emp = new Employee();
        //Client client = new Client();
        //ClientType ct = new ClientType();

        
        #endregion

        public DataAccessLayer()
        {
        }

        public bool InsertPicture(Picture pic)
        {
            DBHelper myDB = new DBHelper();
            bool myBool = false;

            string command = "uspInsertPicture";

            SqlParameter[] param = new SqlParameter[]{

                new SqlParameter ("@Image", pic.Image),
                new SqlParameter ("@Name", pic.Name)

            };
            //param.ToArray<emp>();
            myBool = myDB.ExecuteNonQuery(command, CommandType.StoredProcedure, param);
            return myBool;
        }

        //public bool UpdateCalendar(CalendarAppointment cal)
        //{
        //    DBHelper myDB = new DBHelper();
        //    bool myBool = false;

        //    string command = "uspUpdateCalendar";

        //    SqlParameter[] param = new SqlParameter[]{

        //        new SqlParameter ("@calID", cal.CalendarID),
        //        new SqlParameter ("@date", cal.Date),

        //        new SqlParameter ("@slotID",cal.SlotID),
        //        new SqlParameter ("@empID",cal.EmpID),

        //        new SqlParameter ("@available", cal.IsAvaliable),
        //        new SqlParameter ("@startTime", cal.StartTime),

        //        new SqlParameter ("@endTime", cal.EndTime)//,
        //        //new SqlParameter ("@endTime", cal.AppointmentID)


        //    };
        //    myBool = myDB.ExecuteNonQuery(command, CommandType.StoredProcedure, param);
        //    return myBool;
        //}

        //public bool UpdateCalendarBookApp(CalendarAppointment cal)
        //{
        //    DBHelper myDB = new DBHelper();
        //    bool myBool = false;

        //    string command = "uspUpdateCalendarBookApp";

        //    SqlParameter[] param = new SqlParameter[]{

        //        new SqlParameter ("@calID", cal.CalendarID),
        //        new SqlParameter ("@date", cal.Date),

        //        new SqlParameter ("@slotID",cal.SlotID),
        //        new SqlParameter ("@empID",cal.EmpID),

        //        new SqlParameter ("@available", cal.IsAvaliable),
        //        new SqlParameter ("@startTime", cal.StartTime),

        //        new SqlParameter ("@endTime", cal.EndTime)//,
        //        //new SqlParameter ("@endTime", cal.AppointmentID)


        //    };
        //    myBool = myDB.ExecuteNonQuery(command, CommandType.StoredProcedure, param);
        //    return myBool;
        //}

        //public DataTable GetCalendarByEmp(CalendarAppointment cal)
        //{
        //    DBHelper myDB = new DBHelper();
        //    string command = "uspGetCalendarByEmployee";
        //    SqlParameter[] param = new SqlParameter[]
        //    {
        //        new SqlParameter ("@empID", cal.EmpID)
        //    };

        //    return myDB.ExecuteParamerizedSelectCommand(command, CommandType.StoredProcedure, param);


        //}


    }
}



