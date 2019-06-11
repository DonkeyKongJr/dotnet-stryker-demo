using System;
using System.Text;

namespace Stryker.Demo
{
    public static class BoolComparer
    {
        public static bool IsEqualMutationSurvived(bool one, bool two)
        {
            if (one == two)
            {
                return true;
            }

            return false;
        }
        
        public static bool IsEqualMutationKilled(bool one, bool two)
        {
            return one == two;
        }
    }
}