﻿using Domain.Agreements.Repositories;
using Domain.Agreements.Entities;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Application.Agreements.Implementations
{
    internal class AgreementService : IAgreementService
    {
        private readonly IAgreementRepository _agreementRepository;

        public AgreementService(IAgreementRepository agreementRepository)
        {
            _agreementRepository = agreementRepository;
        }

        public async Task CreateAgreementAsync(Agreement agreement)

        {
            await _agreementRepository.CreateAgreementAsync(agreement);
        }

        public async Task<Agreement?> GetContractee(Agreement agreement)
        {
            return await _agreementRepository.GetContractee(agreement);
        }
        public async Task<IEnumerable<Agreement?>> GetAllAgreementsByProjectAndEmployer(string projectName, string employerEmail)
        {
            return await _agreementRepository.GetAllAgreementsByProjectAndEmployer(projectName, employerEmail);
        }

        public async Task DesactivateAgreement(string employeeEmail, string employerEmail, string projectName, string justification)
        {
            await _agreementRepository.DesactivateAgreement(employeeEmail, employerEmail, projectName, justification);
        }

        public Task<IEnumerable<Agreement>> GetEmployeeAgreements(string employeeEmail)
        {
            return _agreementRepository.GetEmployeeAgreements(employeeEmail);
        }
        public Task<IEnumerable<Agreement>> GetEmployerAgreements(string employerEmail)
        {
            return _agreementRepository.GetEmployerAgreements(employerEmail);
        }

        public Task<Agreement?> GetFirstProjectAgreement(Agreement searchAgreement)
        {
            return _agreementRepository.GetFirstProjectAgreement(searchAgreement);
        }

        public Task<IList<Agreement>> GetProjectAgreements(string projectName, string employerEmail)
        {
            return _agreementRepository.GetProjectAgreements(projectName, employerEmail);
        }
    }
}
