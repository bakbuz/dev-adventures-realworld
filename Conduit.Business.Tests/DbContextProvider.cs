﻿using Conduit.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Conduit.Business.Tests
{
    public static class DbContextProvider
    {
        public static ApplicationDbContext GetInMemoryDbContext() =>
            new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase($"Business.Tests-{Guid.NewGuid().ToString()}").Options);
    }
}
