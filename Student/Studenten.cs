using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Studenten
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        //public string LastName { get; set; }

        //public string FullName => $"{FirstName} {LastName}";
        private List<Studenten> studentenList;
        public override string ToString()
        {
            return $"{Id} {Level} {Name} ";
        }
        public Studenten(int id, int level, string name)
        {
            Id = id ;
            Level = level ;
            Name = name ;
        }
        public List<Studenten> GetRandomStudent(int count)
        {
            Random random = new Random();
            return studentenList.OrderBy(s => random.Next(count)).Take(count).ToList();
        }

        //public int CompareTo(Studenten other)
        //{
        //    return Name.CompareTo(other.Name);
        //}
        //public static  List<string> GetStrings
        //{
        //    get
        //    {
        //        return new List<string>();
        //    }


        //}

    }
}
