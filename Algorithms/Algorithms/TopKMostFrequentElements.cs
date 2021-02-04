using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class TopKMostFrequentElements
    {
        public static List<int> OnLogn(int[] array, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();


            for (int i = 0; i < array.Length; i++)
            {
                if (dict.TryGetValue(array[i], out int value))
                {
                    dict[array[i]] += 1;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }


            var response = dict.ToList();
            response.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            List<int> resp = new List<int>();


            foreach (var value in response.OrderByDescending(x => x.Value))
            {
                if (k == 0)
                    break;
                resp.Add(value.Key);
                k--;
            }


            return resp;

        }

        public static List<int> On(int[] array, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            //O(n)
            for (int i = 0; i < array.Length; i++)
            {
                if (dict.TryGetValue(array[i], out int value))
                {
                    dict[array[i]] += 1;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }

            //O(n)
            Dictionary<int, List<int>> frequencia = new Dictionary<int, List<int>>();
            for (int i = 0; i < dict.Count; i++)
            {
                if (frequencia.TryGetValue(dict.ElementAt(i).Value, out List<int> freq))
                    freq.Add(dict.ElementAt(i).Key);
                else
                    frequencia.Add(dict.ElementAt(i).Value, new List<int>() { dict.ElementAt(i).Key });
            }

            //O(n)
            List<int> response = new List<int>();
            for (int i = 7; i > 0; i--)
            {
                if (response.Count == k)
                    break;

                if (frequencia.TryGetValue(i, out List<int> freq))
                {
                    response.AddRange(freq);
                }

            }

            return response;
        }
    }

}
