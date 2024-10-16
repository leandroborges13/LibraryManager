﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Core.Services
{
    public interface IAuthService
    {
        string GenerateJWTToken(string email, string role);
        string ComputeSha256Hash(string password);
    }
}
