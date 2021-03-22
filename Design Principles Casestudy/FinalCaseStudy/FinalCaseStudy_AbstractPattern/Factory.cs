using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_AbstractPattern
{
    public interface Factory
    {
        void ProcessOrder(Channel channel, Product product);
    }
}
