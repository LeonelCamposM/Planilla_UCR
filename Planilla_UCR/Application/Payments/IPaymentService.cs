﻿using Domain.Payments.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Payments
{
    public interface IPaymentService
    {
        Task AddPayment(Payment newPayment);
        Task<Payment?> GetEmployeeLastPayment(string employeeEmail, string employerEmail, string projectName);
        Task<IList<Payment>> GetProjectPayments(Payment payment);
        Task<IList<Payment>> GetEmployerPayments(string email);
        Task<IEnumerable<Payment>> GetEmployeePayments(string email);
        Task<IEnumerable<Payment>> GetLastEmployeePayments(string email);
        Task<IEnumerable<Payment>> GetEmployerPayments(string email);
        Task<IEnumerable<Payment>> GetLastEmployerPayments(string email);
        Task<IEnumerable<Payment>> GetEmployeeLatestPayments(string employeeEmail);
    }
}