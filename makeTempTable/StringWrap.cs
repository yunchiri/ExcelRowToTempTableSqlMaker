
using System;
using System.Collections.Generic;
namespace makeTempTable
{
    public static class StringWrap
    {
        public static string StringAddQuoto(string target)
        {


            
            int numberInt;
            if ( Int32.TryParse(target, out numberInt))
            {
                return string.Format("to_number('{0}')", target); 
            }

            Double numberDouble;
            if (Double.TryParse(target, out numberDouble))
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

            DateTime x;
            bool isDate = DateTime.TryParse(target, out x);

            if (isDate)
            {
                return string.Format("to_date('{0}','yyyy-mm-dd')", target);
            }


            if (target == "null") return @"CAST(''as varchar2(100))" ;


            return "\'" + target + "\'";

        }

        public static string StringAddQuoto(string target,bool isAutoToNumber, string headerType)
        {
            if (headerType != null)
            {
                switch (headerType)
                {
                    case "number" :

                        return string.Format("to_number('{0}')", target);
                        
                    case "date" : 
                        return string.Format("to_date('{0}','yyyy-mm-dd')", target);

                    default :
                            if (target.Contains(@"'") == true)
                            {
                                target = target.Replace(@"'", @"''");
                            }


                            if (target == "null") return @"CAST(''as varchar2(100))";
                            return "\'" + target + "\'";

                }
            }
    
            if (isAutoToNumber == true)
            {
                int numberInt;
                if (Int32.TryParse(target, out numberInt))
                {
                    return string.Format("to_number('{0}')", target);
                }

                Double numberDouble;
                if (Double.TryParse(target, out numberDouble))
                {
                    return string.Format("to_number('{0}')", target);
                }

                float numberfloat;
                if (float.TryParse(target, out numberfloat))
                {
                    return string.Format("to_number('{0}')", target);
                }
            }



            DateTime x;
            bool isDate = DateTime.TryParse(target, out x);

            if (isDate)
            {
                return string.Format("to_date('{0}','yyyy-mm-dd')", target);
            }



            if (target.Contains(@"'") == true)
            {
                target = target.Replace(@"'", @"''");
            }


            if (target == "null") return @"CAST(''as varchar2(100))";


            return "\'" + target + "\'";

        }
    }
}
