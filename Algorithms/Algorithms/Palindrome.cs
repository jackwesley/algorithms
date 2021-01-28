namespace Algorithms
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            char[] wordArray = word.ToCharArray();
            int min_indice =0;
            int max_indice = wordArray.Length - 1;
            bool isPalindrome = true;

            while(min_indice < max_indice)
            {
                if(wordArray[min_indice] == wordArray[max_indice])
                {
                    min_indice++;
                    max_indice--;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
