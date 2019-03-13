using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("marks")]
    public class Mark : DbEntity
    {
        public virtual TeacherSubject TeacherSubject { get; set; }
        public virtual Student Student { get; set; }

        [Column("value")]
        public int Value { get; set; }
    }
}
