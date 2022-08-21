using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameManager.Concrete
{
    public class SalesManager : ISales
    {
        public void Sales(Promotion promotion, Gamer gamer, Game game)
        {
            int sumPrice = (int)(game.GamePrice - ((promotion.Discount * game.GamePrice) / 100));

               
            Console.WriteLine("Price with discount is "+ sumPrice);
            
             
            


        
        }
        public void Sales( Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name+" choose "+game.GameName);
            Console.WriteLine(game.GameName+ " price is "+game.GamePrice);
        }






    }

}
