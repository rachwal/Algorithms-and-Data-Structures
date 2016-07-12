namespace LeetCode.Algorithms.ArrayAndString
{
    public class OneEditDistance
    {
        public bool IsOneEdit(string original, string edited)
        {
            var originalLength = original.Length;
            var editedLength = edited.Length;

            if (originalLength > editedLength)
            {
                return IsOneEdit(edited, original);
            }

            if (editedLength - originalLength > 1)
            {
                return false;
            }

            var index = 0;
            while (index < originalLength && original[index] == edited[index])
            {
                index++;
            }

            var shift = editedLength - originalLength;
            if (index == originalLength)
            {
                return shift > 0;
            }

            if (shift == 0)
            {
                index++;
            }

            while (index < originalLength && edited[index + shift] == original[index])
            {
                index++;
            }
            return index == originalLength;
        }
    }
}