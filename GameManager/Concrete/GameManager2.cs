using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Concrete
{
    public class GameManager2 : IGame
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.GameName + "is added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "is deleted");
            games.Remove(game);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "is updated");
        }
    }
}
