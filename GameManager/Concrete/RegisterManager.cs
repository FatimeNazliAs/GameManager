using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Concrete
{
    public class RegisterManager : IRegister
    {
        List<Gamer> gamers = new List<Gamer>();

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine(gamer.Name + gamer.LastName + " is deleted");
        }

        public void Register(Gamer gamer)
        {
            gamers.Add(gamer); 
           Console.WriteLine(gamer.Name + gamer.LastName + " is registered");
        }

        public void Update(Gamer gamer)
        {
         
            Console.WriteLine(gamer.Name + gamer.LastName + " is updated");
        }
    }
}

