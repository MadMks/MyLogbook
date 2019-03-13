using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    /// <summary>
    /// Преподаваемый предмет.
    /// </summary>
    [Table("subjects")]
    public class Subject : DbEntity
    {
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }

        public virtual List<TeacherSubject> Teachers { get; set; }
    }
}
