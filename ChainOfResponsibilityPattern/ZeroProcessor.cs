using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class ZeroProcessor : Processor
    {
        public ZeroProcessor(Processor nextProcessor) : base(nextProcessor)
        {

        }

        public override void Process(Number request)
        {
            if (request.getNumber() == 0)
            {
                Console.WriteLine("ZeroProcessor : " + request.getNumber());
            }
            else
            {
                base.Process(request);
            }
        }
    }
}
