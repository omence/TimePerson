using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TimePerson.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Catagory { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int beginYear, int endYear)
        {
            List<TimePerson> timePerson = new List<TimePerson>();
           
            string path = @"C:\Users\jason\source\repos\TimePerson\TimePerson\TimePerson\wwwroot\PersonOfTheYear.csv";

            string[] data = File.ReadAllLines(path);

            for (int i = 1; i < data.Length; i++)
            {
                var fields = data[i].Split(',');
                if (Convert.ToInt32(fields[0]) >= beginYear && Convert.ToInt32(fields[0]) <= endYear)
                {
                    timePerson.Add(new TimePerson
                    {
                        Year = Convert.ToInt32(fields[0]),
                        Honor = fields[1],
                        Name = fields[2],
                        Country = fields[3],
                        BirthYear = Convert.ToInt32(fields[4]),
                        DeathYear = Convert.ToInt32(fields[5]),
                        Title = fields[6],
                        Catagory = fields[7],
                        Context = fields[8],
                    });
                }
            }
            return timePerson;
        }

    }

  
}
