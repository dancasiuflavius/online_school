using online_school.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_school.Services
{
    public class ServiceStudent
    {
        private List<Student> _studentList;

        public ServiceStudent()
        {
            Student student1 = new Student("Popescu", "Andrei", 18, "1A2B", "A2ferq");
            Student student2 = new Student("Calinescu", "George", 21, "1B2A", "1As2");
            Student student3 = new Student("Popa", "Dorin", 18, "2CD4", "123456");
            Student student4 = new Student("Mihailescu", "Daniel", 19, "2C5E", "1A2b3C");
            Student student5 = new Student("Flavius", "Dancasiu", 20, "D1F3", "qwer1324");

            _studentList = new List<Student>();

            _studentList.Add(student1);
            _studentList.Add(student2);
            _studentList.Add(student3);
            _studentList.Add(student4);
            _studentList.Add(student5);
        }
        public void showStudents()
        {
            for(int i=0; i < _studentList.Count; i++)
            {
                Student student = _studentList[i];
            }
        }

    }
}
