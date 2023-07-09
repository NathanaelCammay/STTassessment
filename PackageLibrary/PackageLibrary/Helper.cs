namespace PackageLibrary
{
    public class Helper {
        public static string GetStringBetweenCharacters(string input, char charFrom, char charTo) // method will assist with getting values inside brackets
        {
            int posFrom = input.IndexOf(charFrom);
            if (posFrom != -1) //if found char
            {
                int posTo = input.IndexOf(charTo, posFrom + 1);
                if (posTo != -1) //if found char
                {
                    return input.Substring(posFrom + 1, posTo - posFrom - 1);
                }
            }

            return string.Empty;
        }
    }
}
