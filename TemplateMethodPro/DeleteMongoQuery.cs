using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class DeleteMongoQuery : mongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("delete query  in Mongo .....");
        }
    }
}
