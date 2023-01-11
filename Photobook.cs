using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    internal class Photobook
    {
            protected int numPages;

            public Photobook()
            {
                numPages = 16;
            }

            public Photobook(int numPages)
            {
                this.numPages = numPages;
            }

            public int GetNumberPages()
            {
                return numPages;
            }

    }
}
