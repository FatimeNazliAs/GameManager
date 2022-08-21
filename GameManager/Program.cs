using GameManager.Abstract;
using GameManager.Concrete;
using GameManager.Entities;
using System;

namespace GameManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer=new Gamer() { GamerId=1,Name="nazli",LastName=" as"};

           
            Game game = new Game() { GameId = 1, GamePrice = 300, GameName = "valorant " };
            GameManager2 gameManager2 = new GameManager2();
            gameManager2.Add(game);

            Promotion promotion = new Promotion() {PromotionId=1,Name="fifty Percent ",Discount=50};
          


            RegisterManager registerManager = new RegisterManager();
            registerManager.Register(gamer);
            
          

            PromotionManager promotionManager = new PromotionManager();
            promotionManager.Add(promotion);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(promotion, gamer, game);


            
            Game game2 = new Game() { GameId = 1, GamePrice = 500, GameName = "dont starve " };
            
            Gamer gamer2 = new Gamer() { GamerId = 2, Name = "melis", LastName = " yılmaz " };
            
            RegisterManager registerManager2 = new RegisterManager();
            registerManager2.Register(gamer2);
            
            GameManager2 gameManager3 = new GameManager2();
            gameManager3.Add(game2);

            Promotion promotion2 = new Promotion() { PromotionId = 1, Name = "25 Percent ", Discount = 25 };

            PromotionManager promotionManager2 = new PromotionManager();
            promotionManager2.Add(promotion2);

            SalesManager salesManager2 = new SalesManager();
            
            salesManager2.Sales(promotion2, gamer2, game2);






        }
    }
}
