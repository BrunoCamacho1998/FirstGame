﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Servicios
{
    interface IUserServices 
    {
        bool updateUser(int id, int score);
    }
}
