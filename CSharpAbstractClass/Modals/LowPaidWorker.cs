using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAbstractClass.Modals
{
    public class LowPaidWorker : Worker
    {
        public override double CalculateSalary()
        {
            return (2000 * 1);
        }
    }
}
