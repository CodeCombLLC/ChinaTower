﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ChinaTower.StationPlanning.Models
{
    public class ChinaTowerContext : IdentityDbContext<User>
    {
    }
}