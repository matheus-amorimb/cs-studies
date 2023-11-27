// See https://aka.ms/new-console-template for more information
public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        return word1 + word2;

    }


    static void Main()
    {

        string result = new Solution().MergeAlternately("party", "rock");

        Console.WriteLine(result);
    
    }

}