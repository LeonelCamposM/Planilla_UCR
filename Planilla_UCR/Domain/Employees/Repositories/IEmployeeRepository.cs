﻿using Domain.Core.Repositories;
using Domain.Employees.DTOs;
using Domain.Employees.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employees.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task CreateAsync(String email, int id, String name, String bankAccount);
    }
}
