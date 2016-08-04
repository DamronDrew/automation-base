using automation_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteTests
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriverBase.CreateDriver("chrome");
            WebDriverBase.NavigateTo("");
        }
    }
}
