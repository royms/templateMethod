using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public class insertMongoQuery : mongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("insert query  in Mongo .....");
        }
    }
}
