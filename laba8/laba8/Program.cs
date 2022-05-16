using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace laba8
{
    public class Students
    {
        public int student_id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public double stipend { get; set; }
        public int kurs { get; set; }
        public string city { get; set; }
        public DateTime birthday { get; set; }
        public int univ_id { get; set; }

    }
    public class Exam_marks
    {
        public int exam_id { get; set; }
        public int student_id { get; set; }
        public int subj_id { get; set; }
        public int mark { get; set; }
        public DateTime exam_date { get; set; }
    }
    public class Lectures
    {
        public int lecturer_id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public int subj_id { get; set; }
    }
    public class Subject
    {
        public int subj_id { get; set; }
        public string subj_name { get; set; }
        public int hour { get; set; }
        public int semestr { get; set; }
    }
    class Program
    {
     
        static void Main(string[] args)
        {
            Students[] students = new Students[]
            {
                new Students{student_id=1,surname="Иванов",name="Иван",stipend=150,kurs=1,city="Орел",birthday=Convert.ToDateTime("1982.03.12"),univ_id=10},
                new Students{student_id=3,surname="Петров",name="Петр",stipend=200,kurs=3,city="Курск",birthday=Convert.ToDateTime("1980.12.01"),univ_id=10},
                new Students{student_id=6,surname="Сидоров",name="Вадим",stipend=150,kurs=4,city="Москва",birthday=Convert.ToDateTime("1979.06.07"),univ_id=22},
                new Students{student_id=55,surname="Белкин",name="Вадим",stipend=250,kurs=5,city="Воронеж",birthday=Convert.ToDateTime("1980.01.07"),univ_id=10},
                new Students{student_id=12,surname="Зейцева",name="Ольга",stipend=10000,kurs=2,city="Липецк",birthday=Convert.ToDateTime("1981.05.01"),univ_id=10},
                new Students{student_id=10,surname="Кузнецов",name="Борис",stipend=10000,kurs=2,city="Брянск",birthday=Convert.ToDateTime("1900.01.21"),univ_id=10},
                new Students{student_id=100,surname="Иванов",name="Иван",kurs=4,city="Якутск",birthday=Convert.ToDateTime("2000.12.12"),univ_id=12}
            };
            Exam_marks[] exam_Marks = new Exam_marks[]
            {
                new Exam_marks{exam_id=145,student_id=12,subj_id=10,mark=5,exam_date=Convert.ToDateTime("2000.01.12")},
                new Exam_marks{exam_id=34,student_id=32,subj_id=10,mark=4,exam_date=Convert.ToDateTime("2000.01.23")},
                new Exam_marks{exam_id=75,student_id=55,subj_id=10,mark=5,exam_date=Convert.ToDateTime("2000.01.05")},
                new Exam_marks{exam_id=238,student_id=12,subj_id=22,mark=3,exam_date=Convert.ToDateTime("1999.06.17")},
                new Exam_marks{exam_id=639,student_id=55,subj_id=22,exam_date=Convert.ToDateTime("1999.06.22")},
                new Exam_marks{exam_id=43,student_id=6,subj_id=22,mark=4,exam_date=Convert.ToDateTime("2000.01.18")}
            };
            Lectures[] lectures = new Lectures[]
            {
                new Lectures{lecturer_id=24,surname="Колесников",name="Борис",city="Воронеж",subj_id=10},
                new Lectures{lecturer_id=46,surname="Никонов",name="Иван",city="Воронеж",subj_id=10},
                new Lectures{lecturer_id=276,surname="Николаев",name="Виктор",city="Воронеж",subj_id=10},
                new Lectures{lecturer_id=74,surname="Лагутин",name="Павел",city="Москва",subj_id=22},
                new Lectures{lecturer_id=108,surname="Струков",name="Николай",city="Москва",subj_id=22},
                new Lectures{lecturer_id=328,surname="Сорокин",name="Борис",city="Орел",subj_id=10},

            };
            Subject[] subjects = new Subject[]
            {
                new Subject{subj_id=10,subj_name="Информатика",hour=56,semestr=1},
                new Subject{subj_id=22,subj_name="Физика",hour=34,semestr=1},
                new Subject{subj_id=43,subj_name="Математика",hour=56,semestr=2},
                new Subject{subj_id=94,subj_name="Английский",hour=56,semestr=3},
                new Subject{subj_id=73,subj_name="Физкультура",hour=34,semestr=5},
                new Subject{subj_id=56,subj_name="История",hour=34,semestr=4}
            };
            
            var first =
                    from c in students
                    where c.surname.StartsWith("И") || c.name.StartsWith("И")
                    select c;

            Console.WriteLine("1 задание");
           foreach(var i in first)
            {
                Console.WriteLine(i.surname + " " + i.name + " " + i.stipend + " " + i.kurs + " " + i.city + " " + i.birthday);
            }
            
            var second =
                     from c in students
                     where c.kurs == 2
                     orderby c.surname
                     join p in exam_Marks on c.student_id equals p.student_id
                     select new { c.surname, p.mark };
            Console.WriteLine("\n2 задание");
            foreach(var i in second)
            {
                Console.WriteLine(i.surname+" "+i.mark);
            }
            
            var third =
                    from c in lectures
                    join p in subjects on c.subj_id equals p.subj_id
                    select new { c.surname };
            Console.WriteLine("\n3 задание");
            foreach (var i in third)
            {
                Console.WriteLine(i.surname);
            }

            var max = students.Select(c => c.stipend).Max();
            var fourth =
                (from c in students
                 where c.kurs > 2 && c.stipend == max
                 select new { c.name, c.surname, c.kurs, c.stipend });
            Console.WriteLine("\n4 задание");
            foreach (var i in fourth)
            {
                Console.WriteLine(i.name + " " + i.surname + " " + i.kurs + " " + i.stipend);
            }

            var fiveth = exam_Marks.Where(c => c.subj_id == 10).Select(c => c.mark).Average();
            Console.WriteLine("\n5 задание");
            Console.WriteLine(fiveth.ToString());
            
        }
    }
}
