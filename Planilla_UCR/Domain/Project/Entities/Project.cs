﻿using Domain.Core.Entities;
using Domain.Core.ValueObjects;
using Domain.Projects.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Projects.Entities
{
    public class Project /*: AggregateRoot*/
    {
        public String EmployerEmail { get; }
        public String ProjectName { get; }
        public String ProjectDescription { get; }
        public int MaximumAmountForBenefits { get; }
        public int MaximumBenefitAmount { get; }
        public String PaymentInterval { get; }

        public Project(String Email, String Name,
                        String Description, int MaxAmountForBenefits,
                        int MaxBenefitAmount, String PayInterval)
        {
            EmployerEmail = Email;
            ProjectName = Name;
            ProjectDescription = Description;
            MaximumAmountForBenefits = MaxAmountForBenefits;
            MaximumBenefitAmount = MaxBenefitAmount;
            PaymentInterval = PayInterval;
        }
    }
}
