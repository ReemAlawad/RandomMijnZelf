using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Info
    {



        #region file
        //public static void WriteToFile(List<Studenten> students, string path)
        //{
        //    using (StreamWriter sw = new StreamWriter(path, true))
        //    {
        //        for (int index = 0; index < students.Count; index++)
        //        {
        //            sw.WriteLine(students[index].Id);
        //            sw.WriteLine(students[index].Level);
        //            sw.WriteLine(students[index].Name);

        //        }
        //    }

        //}
        //public static void WriteToFile(List<Studenten> students, string path, bool overwrite)
        //{
        //    using (StreamWriter sw = new StreamWriter(path, overwrite))
        //    {
        //        for (int index = 0; index < students.Count; index++)
        //        {
        //            sw.WriteLine(students[index].Id);
        //            sw.WriteLine(students[index].Level);
        //            sw.WriteLine(students[index].Name);
        //            //sw.WriteLine(books[index]);
        //        }
        //    }

        //}
        //public static List<Studenten> ReadFromFile(string path)
        //{
        //    using (StreamReader sr = new StreamReader(path))
        //    {

        //        List<Studenten> lines = new List<Studenten>();
        //        while (!sr.EndOfStream)
        //        {
        //            Studenten b = new Studenten();
        //            b.Id = Convert.ToInt32(sr.ReadLine());
        //            b.Level = Convert.ToInt32(sr.ReadLine());
        //            b.Name = sr.ReadLine();
        //            lines.Add(b);
        //        }
        //        return lines;
        //    }
        //}
        //string fileStudent = @"c:\TempTest\Studenten.txt";
        //List<Studenten> info = Info.PopulateStudents();
        //public void WriteToFile()//string fileList, string content)
        //{
        //    using (StreamWriter writer = new StreamWriter(fileStudent))
        //    {
        //        writer.WriteLine(info);
        //    }
        //}
        #endregion
        public static List<Studenten> PopulateStudents()
        {
            
            List<Studenten> students = new List<Studenten>();
            students.Add(new Studenten(1, 1, "Jon"));
            students.Add(new Studenten (  2, 1, "Jack" ));
            students.Add(new Studenten (3, 2, "Mustafa"));
            students.Add(new Studenten (4, 3, "Atilla"));
            students.Add(new Studenten (5, 2, "Quinten"));
            students.Add(new Studenten (6, 1, "Pearl"));
            students.Add(new Studenten (7, 3, "Kenan"));
            students.Add(new Studenten (8, 2, "Benedict"));
            students.Add(new Studenten (9, 3, "Manuel"));
            students.Add(new Studenten (10, 1, "Ilse"));
            students.Add(new Studenten (11, 2, "Cindy"));
            students.Add(new Studenten (12, 2, "Ruud"));

            return students;
        }
        public static List<Studenten> RandomisedGroup(List<Studenten> unsortedStudents, int txtCount)
        {
            Random random = new Random();
            List<Studenten> levelOneStudents = new List<Studenten>();
            List<Studenten> otherLevelsStudents = new List<Studenten>();
            List<Studenten> randomisedGroup = new List<Studenten>();

            //Sort level 1 in levelOneStudents list and the others in otherLevelsStudents list
            foreach (Studenten student in unsortedStudents)
            {
                if (student.Level == 1)
                {
                    levelOneStudents.Add(student);
                }
                else
                {
                    otherLevelsStudents.Add(student);
                }
            }

            //Randomise 1 person from the levelOneStudents list...
            int indexRandomLevelOneStudent = random.Next(levelOneStudents.Count);
            //...add it to randomisedGroup...
            randomisedGroup.Add(levelOneStudents[indexRandomLevelOneStudent]);
            //...remove it from levelOneStudents
            levelOneStudents.RemoveAt(indexRandomLevelOneStudent);




            for (int i = 0; i < txtCount - 1; i++)
            {
                int indexRandomOtherLevelsStudent = random.Next(otherLevelsStudents.Count);
                randomisedGroup.Add(otherLevelsStudents[indexRandomOtherLevelsStudent]);
                otherLevelsStudents.RemoveAt(indexRandomOtherLevelsStudent);
            }
            return randomisedGroup;
        }

    }
}
