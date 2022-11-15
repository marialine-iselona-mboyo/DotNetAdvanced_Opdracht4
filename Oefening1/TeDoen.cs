using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class TeDoen
    {
        private int id;
        private static int count = 0;
        private DateTime? TijdStip;
        private string Title;
        private string[] Information;


        public TeDoen(DateTime tijdStip, string title, string[] informatie)
        {
            if(tijdStip != DateTime.Now)
            {
                TijdStip = tijdStip;
            } else
            {
                TijdStip = null;
            }

            Title = title;
            Information = informatie;
            count++;
            id = count;
        }

        public override string ToString()
        {
            return Title.ToString();
        }
    }
}
