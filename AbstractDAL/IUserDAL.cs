﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentStatusManageSystem.Model;

namespace StudentStatusManageSystem.AbstractDAL
{
    public interface IUserDAL
    {
       User GetUserByUserName();

        User GetUserrByUserId();

    }
}
