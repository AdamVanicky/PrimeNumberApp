using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberApp
{
    public class PrimeNumberCalculator
    {
        public List<int> Prime_Numbers_Lower_Than_Ten(int max)
        {
            
            bool[] is_prime = MakeSieve(max);
            List<int> prime_nums = new List<int>();
            for (int i = 2; i < is_prime.Length; i++)
            {
                if(is_prime[i] is true)
                {
                    prime_nums.Add(i);
                }
            }
            return prime_nums;
        }
        public List<int> Prime_Numbers_With_Two_Ones_Together_Up_To_OneHundredFifty(int max)
        {

            bool[] is_prime = MakeSieve(max);
            List<int> prime_nums = new List<int>();
            for (int i = 2; i < is_prime.Length; i++)
            {
                string s = i.ToString();
                if (is_prime[i] && s.Contains("11"))
                {
                    prime_nums.Add(i);
                }
            }
            return prime_nums;
        }
        public List<int> Two_Digit_Prime_Numbers_Up_To_Thirty(int max)
        {
            bool[] is_prime = MakeSieve(max);
            List<int> prime_nums = new List<int>();
            for (int i = 2; i < is_prime.Length; i++)
            {
                if (is_prime[i] && i >= 10)
                {
                    prime_nums.Add(i);
                }
            }
            return prime_nums;
        }

        private bool[] MakeSieve(int max)
        {

            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;


            for (int i = 2; i <= max; i++)
            {

                if (is_prime[i])
                {

                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
    }
}
