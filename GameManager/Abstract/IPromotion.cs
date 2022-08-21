using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Abstract
{
    public interface IPromotion
    {
        void Add(Promotion promotion);
        void Update(Promotion promotion);
        void Delete(Promotion promotion);


    }
}
