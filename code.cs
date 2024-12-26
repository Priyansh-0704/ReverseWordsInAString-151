public class Solution {
    public string ReverseWords(string s) {
        // splitting the words in string and storing them in a array of strings
        // also removing any empty entries along the way
        string[] strArray = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        // reversing the array strArray, so that all the order of the words is reversed
        Array.Reverse(strArray);
        // joining the array elements (words) with each word separated by a space
        return string.Join(" ", strArray);
    }
}
