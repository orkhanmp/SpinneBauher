using Core.Result.Abstract;
using Core.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
       public class BusinessRules
        {
        public static IResult Check(params IResult[] results)
        {
            foreach (var result in results)
            {
                if (!result.Success)
                {
                    return result;
                }
            }

            return new SuccessResult();
        }
    }
}
