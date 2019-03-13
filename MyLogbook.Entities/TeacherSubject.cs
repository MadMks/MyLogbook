using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("teachers_subjects")]
    public class TeacherSubject : DbEntity
    {
        [Key]
        public Guid SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        [Key]
        public Guid TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
