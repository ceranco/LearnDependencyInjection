using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDI
{
    class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer;
        }

        public void Exclaim()
        {
            writer.Write("Hello DI");
        }
    }
}
