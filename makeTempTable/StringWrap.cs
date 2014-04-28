
using System;
namespace makeTempTable
{
    public static class StringWrap
    {
        public static string StringAddQuoto(string target)
        {
            DateTime x;
            bool isDate = DateTime.TryParse( target,out x);

            if (isDate)
            {
                return string.Format("to_date('{0}','yyyy-mm-dd')", target);
            }

            if (target == "null") return @"CAST(''as varchar2(100))" ;


            return "\'" + target + "\'";

        }
    }
}
