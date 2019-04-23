namespace LeetSpeak
{
    public class LeetSpeakTranslator
    {
        public string Translate(string letter)
        {
        

            
                if (letter.Contains("e")) 
                {
                    return "3";
                } 
                else if (letter.Contains("o"))
                {
                    return "0";
                } 
                else if (letter.Contains("t"))
                {
                    return "7";
                }
                else if (letter.Contains("s"))
                {
                    return "z";
                }
                else if (letter.Contains("I"))
                {
                    return "1";
                }
                else 
                {
                    return "else";
                }
            
        }
    }   
}