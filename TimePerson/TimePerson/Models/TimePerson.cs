using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TimePerson.Models
{
    public class TimePerson
    {
        /// <summary>
        /// Properties of the Time Person object
        /// </summary>
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Catagory { get; set; }
        public string Context { get; set; }

        /// <summary>
        /// Reads the CSV file and creates a lits containing all time person objects.
        /// </summary>
        /// <param name="beginYear">User selection</param>
        /// <param name="endYear">Selection</param>
        /// <returns></returns>
        public static List<TimePerson> GetPersons(int beginYear, int endYear)
        {
            //New time person instance
            List<TimePerson> timePerson = new List<TimePerson>();
           
            //File path of the csv fie
            string path = @"C:\Users\jason\source\repos\TimePerson\TimePerson\TimePerson\wwwroot\PersonOfTheYear.csv";

            //Array to hold contents of csv file
            string[] data = File.ReadAllLines(path);

            for (int i = 1; i < data.Length; i++)
            {
                var fields = data[i].Split(',');
                    
                    //Sets values of new instance properties.
                    timePerson.Add(new TimePerson
                    {   

                        Year = (fields[0] == "") ? 0 : Convert.ToInt32(fields[0]),
                        Honor = fields[1],
                        Name = fields[2],
                        Country = fields[3],
                        BirthYear = (fields[4] == "") ? 0 : Convert.ToInt32(fields[4]),
                        DeathYear = (fields[5] == "") ? 0 : Convert.ToInt32(fields[5]),
                        Title = fields[6],
                        Catagory = fields[7],
                        Context = fields[8],
                    });
                
            }
            if (beginYear < endYear)
            {
                //if user does not error return their selected years
                List<TimePerson> people = timePerson.Where(j => (j.Year >= beginYear) && (j.Year <= endYear)).ToList();
                return people;
            }
            else
            {
                //If user errors just return all years.
                return timePerson;
            }
            
        }   

    }

  
}
