using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class FouteRij<T>
    {
        private List<T> row =  new List<T>();
        private List<T> rowcop = new List<T>();
        private T Value; 


        public T inDeRij(T element)
        {
            row.Add(element);
            if(row.Count == 1)
            {
                Value = element;
            }
            return Value;
        }

        public T Delete()
        {
            row.Remove(Value);
            if(row.Count != 0)
            {
                Value = row.First();
            }
            return Value;
        }

        public T Next()
        {
            if(row.Count > 0)
            {
                int rowNumber = row.IndexOf(Value);
                if (rowNumber == row.Count - 1)
                {
                    return row[0];
                } else
                {
                    Value = row[rowNumber + 1];
                }
            } return Value;
        }
        
        public bool isEmpty()
        {
            if(row.Count == 0)
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        public int Count()
        {
            return row.Count;
        }

        public T ZetAchteraan()
        {
            if(row.Count > 0)
            {
                row.Remove(Value);
                row.Add(Value);
                Value = row[0];
            }
            return Value;
            
        }

        public void LeegMaken()
        {
            row.Clear();
        }

        public override string ToString()
        {
            string showList = "";

            foreach(T ele in row)
            {
                showList += ele.ToString() + "\n" + " " + ", ";
            }
            
            return showList;
        }

        public List<T> rijCopy()
        {
            rowcop = row.GetRange(0, row.Count);

            return rowcop;
        }
    }
}
