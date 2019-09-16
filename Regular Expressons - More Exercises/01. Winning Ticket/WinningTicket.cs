using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Winning_Ticket
{
    class WinningTicket
    {
        static void Main()
        {
            StringBuilder result = new StringBuilder();

            string[] tickets = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex reg = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    result.Append($"invalid ticket{Environment.NewLine}");
                    continue;
                }

                Match leftMatch = reg.Match(ticket.Substring(0, 10));
                Match rightMatch = reg.Match(ticket.Substring(10));
                int minLength = Math.Min(leftMatch.Length, rightMatch.Length);

                if (!leftMatch.Success || !rightMatch.Success)
                {
                    result.Append($"ticket \"{ticket}\" - no match{Environment.NewLine}");
                    continue;
                }

                string leftSide = leftMatch.Value.Substring(0, minLength);
                string rightSide = rightMatch.Value.Substring(0, minLength);

                if (leftSide.Equals(rightSide))
                {
                    if (leftSide.Length == 10)
                    {
                        result.Append($"ticket \"{ticket}\" - {minLength}{leftSide.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                    }
                    else
                    {
                        result.Append($"ticket \"{ticket}\" - {minLength}{leftSide.Substring(0, 1)}{Environment.NewLine}");
                    }
                }
                else
                {
                    result.Append($"ticket \"{ticket}\" - no match{Environment.NewLine}");
                }
            }

            Console.Write(result.ToString());
        }
    }
}
