using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeClassLibrary
{
    public class Anagram
    {
        /// <summary>
        /// Given two strings, determine if they are anagrams
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns>True if anagram, False otherwise</returns>
        public bool IsAnagram(string s, string t)
        {
            var d = new Dictionary<char, int>();
            if (s.Length != t.Length)
            {
                return false;
            }
            // Place in char in s into a Dictionary (char, occurances)
            foreach (char c in s)
            {
                if (d.ContainsKey(c)) { d[c]++; }
                else { d[c] = 1; }
            }

            // Deconstruct the dict based on t's chars. Return false if nothing to remove
            foreach (char c in t)
            {
                if (d.ContainsKey(c))
                {
                    if (d[c] == 1) { d.Remove(c); }
                    else if (d[c] > 1) { d[c]--; }
                }
                else return false;
            }

            if (d.Count > 0) { return false; }
            return true;
            // if Dict isn't empty, s has more chars than t. Return false
        }

        /// <summary>
        /// THIS WORKS BUT IS PAINFULLY SLOW. 2000MS COMPARED TO 50MS KIND OF SLOW
        /// LOL
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Convert input string array to List
            List<string> strList = new List<string>(strs);
            // Create temp List for anagram gathering
            List<string> group = new List<string>();
            // Create return List
            IList<IList<string>> result = new List<IList<string>>();

            while (strList.Count > 0)
            {
                group.Add(strList.First());                // Add [i] to group
                for (int j = 1; j < strList.Count;)
                {
                    if (IsAnagram(strList[0], strList[j])) // If anagram
                    {
                        group.Add(strList[j]);
                        strList.RemoveAt(j);
                    }
                    else                                 // Otherwise skip
                    {
                        j++;
                    }
                }
                strList.RemoveAt(0);                       // Remove [i] from strList


                result.Add(new List<string>(group));
                group.Clear();

            }



            return result;
        }

        public IList<IList<string>> GroupAnagramsSolution(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            var result = new List<IList<string>>();

            foreach (var str in strs)
            {
                var arr = str.ToArray();
                Array.Sort(arr);
                var key = new String(arr);

                if (map.ContainsKey(key))
                {
                    map[key].Add(str);
                }
                else
                {
                    map.Add(key, new List<string>() { str });
                }
            }

            foreach (var set in map.Values)
            {
                result.Add(set);
            }
            return result;
        }
    }
}
