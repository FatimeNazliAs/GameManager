using GameManager.Abstract;
using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameManager.Concrete
{
    public class PromotionManager :IPromotion
    {
        List<Promotion> promotions = new List<Promotion>();

        public void Update(Promotion promotion)
        {
       
            Console.WriteLine(promotion.Name + "is updated");

        }
        public void Delete(Promotion promotion)
        {
            Console.WriteLine(promotion.Name + "is deleted");
            promotions.Remove(promotion);
            

        }

        public void Add(Promotion promotion)
        {
            promotions.Add(promotion);
            Console.WriteLine(promotion.Name + "is added");
        }
    }
}





























