public class Kata
{
  public static string MyFirstInterpreter(string code)
  {
   string ch = "";
            int i = 0;
            foreach (var item in code)
            {
                
                if (item == '+') { i = (i + 1) % 256; }
                else if(item == '.'){ ch += (char)i; }
            }

           
            return ch;
  }
}