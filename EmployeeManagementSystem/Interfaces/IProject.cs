﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IProject
    {
        IQueryable GetProjects();
    }
}
