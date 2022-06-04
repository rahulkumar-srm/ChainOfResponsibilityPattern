using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Chain
    {
        Processor processorChain;

        public Chain()
        {
            BuildChain();
        }

        private void BuildChain()
        {
            processorChain = new NegativeProcessor(new ZeroProcessor(new PositiveProcessor(null)));
        }

        public void Process(Number request)
        {
            processorChain.Process(request);
        }

    }
}
