using System;
using online_school.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_school.Services
{
    internal class ServiceCourse
    {
        private List<Course> _courseList;

        public string GetDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();            
                // Combine the path to the "Data" folder
            string dataFolderPath = Path.Combine(currentDirectory, "Data");
            string filePath = Path.Combine(dataFolderPath, "courses.txt");
            return filePath;

            // Check if the "Data" folder exists
        }
        public void ReadCourses()
        {
            try
            {
                // Specify the path to the file you want to read
                string filePath = GetDirectory();

                // Create a StreamReader to read from the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read and process the file line by line
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line); // You can process the line here
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }

    }
}
