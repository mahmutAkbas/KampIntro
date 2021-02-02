using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_05_GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1985 && gamer.FirstName=="MAHMUT" 
                && gamer.LastName=="AKBAŞ" && gamer.IdentityNumber == 11111111111) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
