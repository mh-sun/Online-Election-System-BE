using ElectionSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionSys.Repository
{
    public class DatabaseRepo
    {
        protected DatabaseContext DatabaseContext = new DatabaseContext();
    }
}
