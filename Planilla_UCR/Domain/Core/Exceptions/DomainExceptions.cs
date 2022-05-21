﻿using System;


namespace Domain.Core.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string? message) : base(message)
        {

        }
    }
}
