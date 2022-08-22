using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationServerAPI.Services.PasswordHashers
{
    public interface IPasswordHasher
    {
        string HashPassword(string Password);

        bool VerifyPassword(string password, string passwordHash);
    }
}
