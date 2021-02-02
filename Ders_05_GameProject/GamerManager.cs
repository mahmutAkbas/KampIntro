using System;

namespace Ders_05_GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        UserValidationManager _userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
