using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class FileNull : Exception
    {
        public FileNull(string message)
        : base(message) { }
    }
}
