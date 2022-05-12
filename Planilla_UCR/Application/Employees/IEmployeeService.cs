﻿using Domain.Employees.DTOs;
using Domain.Employees.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees
{
    public interface IEmployeeService
    {
        Task CreateEmployeeAsync();
    }
}
