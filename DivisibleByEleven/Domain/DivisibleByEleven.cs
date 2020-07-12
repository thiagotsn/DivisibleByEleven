using System;
using System.Collections.Generic;

namespace IsDivisibleByEleven.Domain
{
    public class Response
    {
        public IEnumerable<Result> Result { get; set; }
    }

    public class Result
    {
        public string Number { get; set; }
        public string IsMultiple { get; set; }
    }

    public class DivisibleByEleven
    {
        public IEnumerable<string> Numbers { get; set; }

        internal Response CheckDivisibility()
        {
            var result = new List<Result>();

            if (Numbers == null)
            {
                return null;
            }

            foreach (var number in Numbers)
            {
                try
                {
                    var isMultiple = CheckDivisibility(Math.Abs(Convert.ToInt64(number)));
                    result.Add(new Result { Number = number, IsMultiple = isMultiple.ToString() });
                }
                catch (FormatException)
                {
                    result.Add(new Result { Number = number, IsMultiple = "Invalid Number" });
                }
                catch (OverflowException)
                {
                    result.Add(new Result { Number = number, IsMultiple = "Number Too Big" });
                }
                catch (Exception)
                {
                    result.Add(new Result { Number = number, IsMultiple = "Unknown Excelption" });
                }
            }

            var response = new Response { Result = result };

            return response;
        }

        internal bool CheckDivisibility(long number)
        {
            if (number < 10)
                return false;

            long part = (number / 10) - (number % 10);

            if (part > 99)
                return CheckDivisibility(part);
            else if ((part / 10) == (part % 10))
                return true;

            return false;
        }
    }
}
