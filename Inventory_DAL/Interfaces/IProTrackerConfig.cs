﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ProTracker_DAL
{
    public interface IProTrackerConfig
    {
        String SQLConnection { get; }
       // String GetConnectionString();
        IConfigurationSection GetConfigurationSection(string Key);
    }
}
