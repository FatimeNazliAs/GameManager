using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Abstract
{
    public interface ISales
    {
        void Sales(Promotion promotion,Gamer gamer,Game game);
        void Sales( Gamer gamer, Game game);




    }
}
