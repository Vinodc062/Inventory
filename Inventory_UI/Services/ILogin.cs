﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTracker_TO;

namespace ProTracker_UI.Services
{
    public interface ILogin
    {
        Task<Int32> Authenticateuser(Authenticate authenticate);
    }
}
