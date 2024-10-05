
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("LABORATION 1 - Objektorienterad programmering C# - JAMERSON GONCALO");
Console.WriteLine("********************************************************************");
Console.WriteLine();



// VARIABLER
string text = "29535123p48723487597645723645";
long totalSum = 0; 

// LOOP
for (int i = 0; i < text.Length; i++)
{
    for (int length = 2; i + length <= text.Length; length++) 
    {
        string substring = text.Substring(i, length);

        
        if (substring.Length >= 2)
        {
            bool isValid = true;

            
            for (int j = 0; j < substring.Length; j++)
            {
                if (substring[j] < '0' || substring[j] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            
            if (isValid && substring[0] == substring[substring.Length - 1])
            {
                string middle = substring.Substring(1, substring.Length - 2);

                if (middle.IndexOf(substring[0]) == -1) 
                {
                    
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(text[k]);
                    }

                    // BYTA FÄRG
                    Console.ForegroundColor = ConsoleColor.Red;

                    
                    for (int k = 0; k < substring.Length; k++)
                    {
                        Console.Write(substring[k]);
                    }

                    // ÅTERSTÄLL FÄRGEN
                    Console.ResetColor();

                    for (int k = i + length; k < text.Length; k++)
                    {
                        Console.Write(text[k]);
                    }

                    Console.WriteLine();

                    // KONVERTERA DELSTRÄNGEN TILL TAL = SUMMA
                    long number = long.Parse(substring);
                    totalSum += number;
                }
            }
        }
    }
}


Console.WriteLine();
Console.WriteLine("*********************************************************************");

Console.WriteLine("Summa = " + totalSum); // SKRIVER UT TOTAL SUMMA

Console.WriteLine("*********************************************************************");


Console.WriteLine();
Console.Write("Press Enter to finish this program..."); // AVSLUTNING FÖR PROGRAMMET
Console.ReadKey();