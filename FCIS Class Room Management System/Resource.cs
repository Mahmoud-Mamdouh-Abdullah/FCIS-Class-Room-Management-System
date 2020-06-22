using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCIS_Class_Room_Management_System
{
    class Resource
    {
        public int Res_id;
        public string Res_Name;
        public string Res_Link;
        public int Course_id;

        public Resource(int Res_id,string Res_Name,string Res_Link,int Course_id)
        {
            this.Res_id = Res_id;
            this.Res_Name = Res_Name;
            this.Res_Link = Res_Link;
            this.Course_id = Course_id;
        }
    }
}
