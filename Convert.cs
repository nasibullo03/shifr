public class Convert
    {
        public string Text { get; set; }
        public string ConvertedText { get; set; }
        
        public static readonly Dictionary<char, int> keys = new Dictionary<char, int>()
        {
            {'a',11},{'A',11},
            {'b',22 },{'B',22 },
            {'c',21 },{'C',21 },
            {'d',25 },{'D',25 },
            {'e',27 },{'E',27 },
            {'f',29 },{'F',29 },
            {'g',36 },{'G',36 },
            {'h',38 },{'H',38 },
            {'i',51 },{'I',51 },
            {'j',61 },{'J',61 },
            {'k',62 },
            {'l',64 },
            {'m',67 },
            {'n',69 },
            {'o',72 },
            {'p',76 },
            {'q',79 },
            {'r',81 },
            {'s',86 },
            {'t',89 },
            {'u',92 },
            {'v',93 },
            {'w',18 },
            {'x',26 },
            {'y',73 },
            {'z',99 },
            
        };

        public string ConvertText(string text)
        {
            foreach(char ch in keys.Keys)
            {
                if(text.Contains(ch))
                {
                    text.Replace(ch.ToString(), keys[ch].ToString());
                }
            }

            return text;
        }
    }
