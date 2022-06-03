﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Authentication
{
    public class AccountsADbContext : IdentityDbContext
    {
        public AccountsADbContext(DbContextOptions<AccountsADbContext> options)
            : base(options)
        {
        }
    }
}