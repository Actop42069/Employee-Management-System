using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ServerLibrary.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repositories.Implementation
{
    public class UserAccountRepository : IUserAccount
    {
        public Task<GeneralReponse> CreateAsync(Register user)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> SignInAsync(Register user)
        {
            throw new NotImplementedException();
        }
    }
}
