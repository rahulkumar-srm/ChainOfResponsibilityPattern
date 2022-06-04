using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class NegativeProcessor : Processor
    {
        public NegativeProcessor(Processor nextProcessor) : base(nextProcessor)
        {

        }

        public override void Process(Number request)
        {
            if (request.getNumber() < 0)
            {
                Console.WriteLine("NegativeProcessor : " + request.getNumber());
            }
            else
            {
                base.Process(request);
            }
        }
    }
}
