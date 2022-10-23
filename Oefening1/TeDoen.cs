using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class TeDoen
    {
        private int id { get; set; }
        private static int count = 0;
        private DateTime? TijdStip { get; set; }
        private string Title { get; set; }
        private string[] Informatie;
        private string text;
        private string[] lines;

        public TeDoen(DateTime tijdStip, string title, string[] informatie)
        {
            if(tijdStip >= DateTime.Now)
            {
                TijdStip = tijdStip;
            } else
            {
                TijdStip = null;
            }

            Title = title;
            Informatie = informatie;
            count++;
            id = count;
        }

        public override string ToString()
        {
            string result = "";
            if(TijdStip != null)
            {
                return "id " + id + " title: " + Title + " information: " + result;
            } else
            {
                return "id " + id + " tijdstijd: " + TijdStip + " title: " + Title + " information: " + result;
            }
        }
    }
}
