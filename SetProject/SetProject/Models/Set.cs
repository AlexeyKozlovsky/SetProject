using System;
using System.Collections.Generic;
using System.Linq;

namespace SetProject.Models
{
    class Set
    {
        private List<object> values;
        public object this[int index]
        {
            get { return this.values[index]; }
            set { this.values[index] = value; }
        }

        public bool IsEmpty
        {
            get
            {
                return this.Mod == 0;
            }
        }


        public int Mod { get { return this.values.Count; } }

        public Set(List<object> values)
        {
            this.values = values;
            this.values.Sort();
            this.DeleteSameElemnts();
        }

        public Set(string strSet, char sep = ',')
        {
            strSet = this.DeleteAllSpaces(strSet);
            this.values = strSet.Split(sep).ToList<object>();
            this.values.Sort();
            this.DeleteSameElemnts();
        }

        private string DeleteAllSpaces(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ') result += s[i];

            return result;
        }

        private void DeleteSameElemnts()
        {
            for (int i = 1; i < this.values.Count; i++)
                if (this[i].Equals(this[i - 1])) this.values.RemoveAt(i--);
        }

        private bool isSubset(Set subSet)
        {
            if (subSet.Mod == 0) return true;

            int j = 0;
            for (int i = 0; i < this.Mod; i++)
                if (this[i].Equals(subSet[j]) && ++j >= subSet.Mod) return true;

            return j >= subSet.Mod ? true : false;
        }

        public static bool operator <(Set set1, Set set2)
        {
            return set2.isSubset(set1);
        }

        public static bool operator >(Set set1, Set set2)
        {
            return set1.isSubset(set2);
        }

        

        public override string ToString()
        {
            if (this.Mod == 0) return "{}";

            string result = "{";
            for (int i = 0; i < this.Mod; i++) result += $"{this[i]}, ";
            result = result.Substring(0, result.Length - 2);
            result += "}";
            return result; 
        }

    }
}
