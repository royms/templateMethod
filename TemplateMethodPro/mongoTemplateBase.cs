﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public abstract class mongoTemplateBase : TemplateQueryRunner
    {
        protected override void CreateDbConnection()
        {
            Console.WriteLine("Creating Mongo connection ... ");
        }
        protected override void OpenDbConnection()
        {
            Console.WriteLine("Opening Mongo connection ... ");
        }
        protected override void CloseDbConnection()
        {
            Console.WriteLine("Closing Mongo connection ... ");
        }

    }
}
