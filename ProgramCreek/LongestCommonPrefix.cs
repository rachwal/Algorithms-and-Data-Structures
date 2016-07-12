namespace ProgramCreek
{
    public class LongestCommonPrefix
    {
        public string FindPrefix(string[] input)
        {
            if (input == null || input.Length == 0)
            {
                return string.Empty;
            }

            if (input.Length == 1)
            {
                return input[0];
            }

            var shortestElementLength = input.Length + 1;

            foreach (var text in input)
            {
                if (shortestElementLength > text.Length)
                {
                    shortestElementLength = text.Length;
                }
            }

            for (var prefixLength = 0; prefixLength < shortestElementLength; prefixLength++)
            {
                for (var textId = 0; textId < input.Length - 1; textId++)
                {
                    var currentText = input[textId];
                    var nextText = input[textId + 1];

                    if (currentText[prefixLength] != nextText[prefixLength])
                    {
                        return currentText.Substring(0, prefixLength);
                    }
                }
            }

            return input[0].Substring(0, shortestElementLength);
        }
    }
}