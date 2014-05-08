
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

            int numberInt;
            if ( Int32.TryParse(target, out numberInt))
            {
                return string.Format("to_number('{0}')", target); 
            }

            float numberfloat;
            if (float.TryParse(target, out numberfloat))
            {
                return string.Format("to_number('{0}')", target);
            }

            if (target.Contains(@"'") == true)
            {
               target =  target.Replace(@"'", @"''");
            }


            if (target == "null") return @"CAST(''as varchar2(100))" ;


            return "\'" + target + "\'";

        }
    }
}
