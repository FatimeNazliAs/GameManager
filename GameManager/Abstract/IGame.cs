﻿using GameManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Abstract
{
    public interface IGame
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
