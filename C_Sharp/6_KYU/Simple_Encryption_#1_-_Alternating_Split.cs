using System;
public class Kata
{
  public static string Encrypt(string text, int n)
  {
  if (text == null || n == 0 || n<=0) { return text; } 
   char[] temp = text.ToCharArray();

            for (int i = 0; i < n; i++)
            {
                String a = "", b = "";
                for (int j = 0; j < temp.Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        a += temp[j];
                    }
                    else
                    {
                        b += temp[j];
                    }
                }
                temp = (a + b).ToCharArray();
            }
            return new String(temp);
  }
  
  public static string Decrypt(string encryptedText, int n)
  {
  if (encryptedText == null || n == 0 || n <= 0) { return encryptedText; }
     char[] temp = encryptedText.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                char[] first = new String(temp).Substring(0, encryptedText.Length/ 2).ToCharArray();
                char[] second = new String(temp).Substring(encryptedText.Length / 2).ToCharArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (j%2 == 0)
                    {
                        temp[j] = second[j / 2];
                    }
                    else
                    {
                        temp[j] = first[j / 2];
                    }
                }
            }
            return new String(temp);
  }
}