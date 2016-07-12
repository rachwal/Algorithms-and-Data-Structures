using System.Collections.Generic;

namespace LeetCode.Algorithms.ArrayAndString
{
    public class WordNode
    {
        public WordNode(string words, int numSteps)
        {
            Word = words;
            NumSteps = numSteps;
        }

        public string Word { get; set; }
        public int NumSteps { get; set; }
    }

    public class WordsLadder
    {
        public int LadderLength(string beginWord, string endWord, ISet<string> wordDict)
        {
            var queue = new Queue<WordNode>();
            queue.Enqueue(new WordNode(beginWord, 1));

            wordDict.Add(endWord);

            while (queue.Count > 0)
            {
                var top = queue.Dequeue();
                var word = top.Word;

                if (word.Equals(endWord))
                {
                    return top.NumSteps;
                }

                var arr = word.ToCharArray();
                for (var i = 0; i < arr.Length; i++)
                {
                    for (var c = 'a'; c <= 'z'; c++)
                    {
                        var temp = arr[i];
                        if (!arr[i].Equals(c))
                        {
                            arr[i] = c;
                        }

                        var newWord = new string(arr);
                        if (wordDict.Contains(newWord))
                        {
                            queue.Enqueue(new WordNode(newWord, top.NumSteps + 1));
                            wordDict.Remove(newWord);
                        }

                        arr[i] = temp;
                    }
                }
            }

            return 0;
        }
    }
}