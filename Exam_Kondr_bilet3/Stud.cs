using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Kondr_bilet3
{
    [Table("StudentInfo")]
    public class Stud
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public int Cource { get; set; }
    }
}
