using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCIS_Class_Room_Management_System
{
    public class user
    {
        public int user_id;
        public string user_name;
        public string user_email;
        public string user_pass;
        public int user_type;
        public string user_kind;

        public user() { }
        public user(int user_id,string user_name,string user_email,string user_pass,int user_type,string user_kind)
        {
            this.user_id = user_id;
            this.user_name = user_name;
            this.user_email = user_email;
            this.user_pass = user_pass;
            this.user_type = user_type;
            this.user_kind = user_kind;
        }
    }
}
