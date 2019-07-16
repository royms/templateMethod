using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class MongogetQuery : mongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("get query  in Mongo .....");
        }
    }
}
