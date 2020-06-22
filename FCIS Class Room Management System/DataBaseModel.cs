using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
namespace FCIS_Class_Room_Management_System
{
    class DataBaseModel
    {
        private string connectionPath = "Data Source=ORCL; User ID=scott; Password=tiger";
        private OracleConnection conn;
        private List<course> courses;
        private OracleDataAdapter adapter;
        private DataSet ds;
        private OracleCommandBuilder builder;

        
        public int Registeration(string FullName, string Pass, string Re_Pass, string Email, string Gender, string Type)
        {
            if (Pass != Re_Pass)
            {
                return -1;
            }
            else
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "checkName";
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("Email", OracleDbType.Varchar2).Value = Email;
                cmd2.Parameters.Add("isin", OracleDbType.Int32).Direction = ParameterDirection.Output;
                OracleDataReader Reader = cmd2.ExecuteReader();
                var isin = cmd2.Parameters["isin"].Value;
                conn.Close();
                string check = isin.ToString();
                if (check == "1") return -2;



                int user_type = -1;
                if (Type == "Instructor")
                    user_type = 1;
                else
                    user_type = 2;

                conn = new OracleConnection(connectionPath);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO USERS (USER_ID,USER_NAME, USER_EMAIL, USER_PASS, GENDER, USER_TYPE)" +
                    "VALUES ( USERID_SEQ.nextval, :Name, :mail, :Password , :Gender , :type)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("Name", FullName);
                cmd.Parameters.Add("mail", Email);
                cmd.Parameters.Add("Password", Pass);
                cmd.Parameters.Add("Gender", Gender);
                cmd.Parameters.Add("type", user_type);
                cmd.ExecuteNonQuery();

                conn.Close();

                return 1;
            }
        }


        public user signIn(string Email, string Pass)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Takelogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("UserName", OracleDbType.Varchar2).Value = Email;
            cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = Pass;
            cmd.Parameters.Add("Kind", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("Name1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataReader objReader = cmd.ExecuteReader();
            user new_user = new user();
            var kind = cmd.Parameters["Kind"].Value;
            while (objReader.Read())
            {
                    
                int id = Convert.ToInt32(objReader["USER_ID"]); ;
                string name = objReader["USER_NAME"].ToString();
                int type = Convert.ToInt32(objReader["USER_TYPE"]);
                string email = objReader["USER_EMAIL"].ToString();
                string pass = objReader["USER_PASS"].ToString();

                new_user.user_id = id;
                new_user.user_name = name;
                new_user.user_email = email;
                new_user.user_pass = pass;
                new_user.user_type = type;
                
            }
            conn.Close();
            new_user.user_kind = kind.ToString();
            return new_user;
                
        }


        public int deleteResWhenDelCourse(int courseId)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM RESOURCES WHERE COURSE_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", courseId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }
        public int deleteEnrollWhenDelCourse(int courseId)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM ENROLLIN WHERE COURSE_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", courseId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }
        public int deleteCourse(int courseId)
        {

            try
            {
                int ans = deleteResWhenDelCourse(courseId);
                ans = deleteEnrollWhenDelCourse(courseId);
                string callstr = "DELETE FROM COURSE WHERE COURSE_ID = :id";
                adapter = new OracleDataAdapter(callstr, connectionPath);
                adapter.SelectCommand.Parameters.Add("id", courseId);
                ds = new DataSet();
                adapter.Fill(ds);
                builder = new OracleCommandBuilder(adapter);
                

            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }


        public List<course> viewCourses(int inst_id)
        {
            try
            {
                courses = new List<course>();
                string callstr = "Select * FROM COURSE WHERE USER_ID = :id";
                adapter = new OracleDataAdapter(callstr, connectionPath);
                adapter.SelectCommand.Parameters.Add("id", inst_id);
                ds = new DataSet();
                adapter.Fill(ds);
                DataTable table = ds.Tables[0];
                int x = table.Rows.Count;
                int y = table.Rows.Count - 1;
                DataRow row;

                course course;

                while (x > 0)
                {
                    row = (DataRow)table.Rows[y];
                    int id = Convert.ToInt32(row["COURSE_ID"]);
                    string name = row["C_NAME"].ToString();
                    string sub = row["SUBJECT"].ToString();
                    int user_id = Convert.ToInt32(row["USER_ID"]);

                    course = new course(id, name, sub, user_id);
                    courses.Add(course);
                    x--;
                    y--;
                }
                return courses;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public int insertCourse(course course, string name)
        {


            try
            {
                string callstr = "insert into course (COURSE_ID,C_NAME,SUBJECT,USER_ID,USER_NAME) " +
                    "values (course_seq.nextval,:Name,:subject,:id,:insName)";
                adapter = new OracleDataAdapter(callstr, connectionPath);
                adapter.SelectCommand.Parameters.Add("Name", course.courseName);
                adapter.SelectCommand.Parameters.Add("subject", course.subjectName);
                adapter.SelectCommand.Parameters.Add("id", course.userId);
                adapter.SelectCommand.Parameters.Add("insName", name);
                ds = new DataSet();
                adapter.Fill(ds);
                builder = new OracleCommandBuilder(adapter);

            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }

        
        public int add_Resource(string name,string link ,int courseID)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }


            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO RESOURCES (RES_ID,RESOURCE_NAME, RESOURCE_LINK, COURSE_ID)" +
                    "VALUES ( ResourceID_seq.nextval, :RESOURCE_NAME, :RESOURCE_LINK, :COURSE_ID)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("RESOURCE_NAME", name);
                cmd.Parameters.Add("RESOURCE_LINK", link);
                cmd.Parameters.Add("COURSE_ID", courseID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }


        public List<Resource> View_Resource(int courseID)
        {
            List<Resource> resourcesList = new List<Resource>();
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("error in connection when View rsource");
            }


            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "selectResources";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cours_ID", OracleDbType.Int32).Value = courseID;
                cmd.Parameters.Add("RES", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = cmd.ExecuteReader();
                Resource resource;
                while (objReader.Read())
                {
                    int RSEID = (int)objReader["RES_ID"];
                    string resName =(string) objReader["RESOURCE_NAME"];
                    string resLink =(string) objReader["RESOURCE_LINK"];
                    int resCourseID =(int) objReader["COURSE_ID"];
                    resource = new Resource(RSEID, resName, resLink, resCourseID);
                    resourcesList.Add(resource);
                }
                conn.Close(); 
            }
            catch (Exception)
            {
                MessageBox.Show("error in database when View resourse");
            }
            return resourcesList;
        }


        public int delete_Resource(int ResID)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
            }
            catch (Exception)
            {
                return -1;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from RESOURCES where RES_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", ResID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                return -1;
            }
            return 1;
        }


        public int update_resource(int res_id, string new_link)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE RESOURCES SET RESOURCES.RESOURCE_LINK = :new_link WHERE RESOURCES.RES_ID = :resID";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("new_link", OracleDbType.Varchar2).Value = new_link;
                cmd.Parameters.Add("resID", OracleDbType.Int32).Value = res_id;
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        public int update_user(user new_user)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE_USER";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32).Value = new_user.user_id;
                cmd.Parameters.Add("new_name", OracleDbType.Varchar2).Value = new_user.user_name;
                cmd.Parameters.Add("new_email", OracleDbType.Varchar2).Value = new_user.user_email;
                cmd.Parameters.Add("new_pass", OracleDbType.Varchar2).Value = new_user.user_pass;
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }


        public List<StdCourse> selectAllCourses()
        {
            try
            {
                List<StdCourse> CourseList = new List<StdCourse>();
                string callstr = "Select * FROM COURSE";
                adapter = new OracleDataAdapter(callstr, connectionPath);
                ds = new DataSet();
                adapter.Fill(ds);
                DataTable table = ds.Tables[0];
                int x = table.Rows.Count;
                int y = table.Rows.Count - 1;
                DataRow row;
                StdCourse course;
                while (x > 0)
                {
                    row = (DataRow)table.Rows[y];
                    int CouID = (int)row["COURSE_ID"];
                    string CouName = (string)row["C_NAME"];
                    string subject = (string)row["SUBJECT"];
                    int InsID = (int)row["USER_ID"];
                    string inst_name = (string)row["USER_NAME"];
                    course = new StdCourse(CouID, CouName, subject, inst_name, InsID);
                    CourseList.Add(course);
                    x--;
                    y--;
                }
                return CourseList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public StdCourse selectOneCourses(int id)
        {
            StdCourse Stdcourse = new StdCourse();
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECTONECOURSE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cours_id", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("cid", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = cmd.ExecuteReader();
                
                while (objReader.Read())
                {
                    int CouID = (int)objReader["COURSE_ID"];
                    string CouName = (string)objReader["C_NAME"];
                    string subject = (string)objReader["SUBJECT"];
                    int InsID = (int)objReader["USER_ID"];
                    string inst_name = (string)objReader["USER_NAME"];
                    Stdcourse.courseID = CouID;
                    Stdcourse.courseName = CouName;
                    Stdcourse.courseSub = subject;
                    Stdcourse.instID = InsID;
                    Stdcourse.instName = inst_name;
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("errore in database when select all courses");
            }
            return Stdcourse;
        }


        public List<StdCourse> selectStudentCourses(int stdID)
        {
            List<StdCourse> CourseList = new List<StdCourse>();

            //try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();

                StdCourse course;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECTSTUDENTCOURSES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32).Value = stdID;
                cmd.Parameters.Add("Cou", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataReader objReader = cmd.ExecuteReader();
                while (objReader.Read())
                {
                    int CouID = (int)objReader["COURSE_ID"];
                    string CouName = (string)objReader["C_NAME"];
                    string subject = (string)objReader["SUBJECT"];
                    int InsID = (int)objReader["USER_ID"];
                    string inst_name = objReader["USER_NAME"].ToString();
                    course = new StdCourse(CouID, CouName, subject, inst_name, InsID);
                    CourseList.Add(course);
                }
                conn.Close();
            }
            //catch (Exception)
            {
                //MessageBox.Show("errore in database when select all courses");
            }
            return CourseList;
        }
        
        
        public int enroll(int std_id,int course_id)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "ENROLL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("std_id", OracleDbType.Int32).Value = std_id;
                cmd.Parameters.Add("course_id", OracleDbType.Int32).Value = course_id;
                cmd.ExecuteNonQuery();
                conn.Close();

                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }
        
        
        public int unenroll(int std_id,int course_id)
        {
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UNENROLL";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cours_id", OracleDbType.Int32).Value = course_id;
                cmd.Parameters.Add("std_id", OracleDbType.Int32).Value = std_id;
                cmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }
        
        
        public string CheckEnrollment(int cid, int stdID)
        {
            var found = "0";
            try
            {
                conn = new OracleConnection(connectionPath);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CheckEnrollment";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cours_id", OracleDbType.Int32).Value = cid;
                cmd.Parameters.Add("std_id", OracleDbType.Int32).Value = stdID;
                cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;
                OracleDataReader objReader = cmd.ExecuteReader();
                var res = cmd.Parameters["res"].Value;
                found = res.ToString();
                if (found != "0") found = "1";
                conn.Close();
            }
            catch (Exception)
            {
                found = "-1";
            }
            return found;
        }


    }
}
