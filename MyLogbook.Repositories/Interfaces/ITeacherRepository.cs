using MyLogbook.Abstractions;
using MyLogbook.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLogbook.Repositories.Interfaces
{
    public interface ITeacherRepository : IDbRepository<Teacher>
    {
    }
}
