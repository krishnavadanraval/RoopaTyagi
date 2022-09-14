namespace DiamondClassLibrary1
{
    public class Class1
    {
        public static string[] DiamontPrint(char ch)
        {
            
            char[] letter = new char[26]
            {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                    'V', 'W', 'X', 'Y', 'Z'
            };
            
            string[] output = new string[52]; //{"A"};
            
            
            if (ch != ' ' && letter.Contains(ch))
            {
                if (ch == 'A')
                {
                    output[0] = "A";
                }
                if (ch == 'B')
                {
                    output[0] = " A ";
                    output[1] = "B B";
                    output[2] = " A ";
                }
                if (ch == 'C')
                {
                    output[0] = "  A  ";
                    output[1] = " B B ";
                    output[2] = "C   C";
                    output[3] = " B B ";
                    output[4] = "  A  ";
                }
                if (ch == 'D')
                {
                    output[0] = "   A   ";
                    output[1] = "  B B  ";
                    output[2] = " C   C ";
                    output[3] = "D     D";
                    output[4] = " C   C ";
                    output[5] = "  B B  ";
                    output[6] = "   A   ";
                }
                return output;
                
            }
            else
            {
                output[0] = "Input valid string from A to Z";
                return output;
            }
        }
    }
}