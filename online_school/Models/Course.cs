using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_school.Models
{
    public class Course
    {
        private string _id;

        public Course()
        {

        }
        public Course(string id)
        {
            _id = id;
        }
        public void GetCourseDescription()
        {
            Console.WriteLine("ID Curs: " + _id);

        }
        public string GetId()
        {
            return _id;
        }
        public void SetId(string id)
        {
            _id = id;
        }
    }
}
