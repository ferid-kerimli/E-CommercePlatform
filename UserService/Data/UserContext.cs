﻿using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }

    public DbSet<UsersModel> Users { get; set; }
}