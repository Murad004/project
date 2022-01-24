using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Exceptions
{
    public class WrongSelectedFileException:Exception
    {
        public WrongSelectedFileException(string msg) : base(msg)
        {

        }
    }
}
