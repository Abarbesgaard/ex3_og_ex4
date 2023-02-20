using System;
using System.Security.Cryptography.X509Certificates;
namespace ex3_og_ex4
{ 
    class Program
    {
        static void Main(string[] args)
        {

            /* øvelse 2.2 forgrening med switch
            * 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Pick of of the 4 doors");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("");

            string userInput = Console.ReadLine();
            int userIntInput = int.Parse(userInput);
            string message = "";

            switch (userIntInput)
            {
            case 1:
            message = "This is party 1";
            break;
            case 2:
            message = "This is party 2";
            break;
            case 3:
            message = "This is party 3";
            break;
            case 4:
            message = "This is party 4";
            break;
            default:
            message = "Here's no party at all";
            break;
            }
            Console.WriteLine("You picked door number: {0}. {1}", userIntInput, message);
            */

            /*øvelse 2.4 
            string testString = "dette_er_en_test";
            char ch = testString[1]; 
            char ch2 = testString[3];
            char ch3 = testString[5];
            Console.WriteLine(ch);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            */

            /*Øvelse 2.5: While-løkke: Gennemløb alle karakterer i en tekststreng
            string str = Console.ReadLine();
            int index = 0;
            char karakter;
            int strLength = str.Length;

            while (index < strLength)
            {
                karakter= str[index++];
                Console.WriteLine(index + ": " + karakter);

            }
            */

            /*Øvelse 2.6: Do-while-løkke: Gennemløb alle karakterer i en tekststreng

            string str = Console.ReadLine();
            int index = 0;
            char karakter;
            int strLength = str.Length;

            do
            {
                karakter = str[index++];
                Console.WriteLine(index + ": " + karakter);

            }
            while (index < strLength);
            */

            /*Øvelse 2.7 Heltalsdivision'

            Console.Write("skriv første heltal: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("skriv andet heltal: ");
            int b = int.Parse(Console.ReadLine());

            //Beregn og gem (i passende variabel) heltalskvotienten ved heltalsdivisionen a/b
            int heltalsDivision = a / b;
            Console.WriteLine(heltalsDivision);

            //Beregn og gem (i passende variabel) rest-delen ved heltalsdivisionen a/b
            int heltalsDivisionRest = a % b;
            Console.WriteLine(heltalsDivisionRest);
            */

            /* øvelse 2.8 Hold programmet kørende indtil at brugeren afslutter der
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Menu");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Pick of of the 4 doors");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("");
                string userInput = Console.ReadLine();

            string message = "";

            switch (userInput)
            {
                case "1":
                    message = "This is party 1";
                    break;
                case "2":
                    message = "This is party 2";
                    break;
                case "3":
                    message = "This is party 3";
                    break;
                case "4":
                    message = "This is party 4";
                    break;
                default:
                    message = "Here's no party at all";
                    break;
            }
            Console.WriteLine("You picked door number: {0}. {1}", userInput, message);
            Console.ReadLine();
            Console.Clear();
            } while ( Console.ReadLine() != "q");
            */

            /*Øvelse 2.9: Udskriv hver ande n karakter i en tekststreng

            string str = Console.ReadLine();
            int index = 0;
            char karakter = ' ';
            int strLength = str.Length;
            int indexRemainder;


            while (index < strLength)
            {
                indexRemainder = index % 2;
                karakter = str[index];
                if (indexRemainder != 0)
                {
                    Console.WriteLine(index + ": " + karakter);
                    //Console.WriteLine("        " + "Dette er indexRemainder: " + indexRemainder + "           Dette er index: " + index);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                index++;
            }
            Console.ReadLine();
            */

            /* Øvelse 2.10: Tekststrenge med cifre

            //få en tilfældig streng fra bruger
            // programmet reqistrer og noterer hvor alle tal er fra 0 til 9 og 
            //Udskriv ciffer-karakter på formen ”<index>: ’<karakter>’ (ciffer)”

            string str = Console.ReadLine();
            int index = 0;
            char karakter;
            int strLength = str.Length;
            int ciffer;
            while (index < strLength)
            {
                karakter = str[index++];
                if (karakter >= '0' && karakter <='9')
                {
                    
                    Console.WriteLine(index + ": " + karakter);
                }


            }
            */

            /*Øvelse 2.12: Skan og udregn simple regneudtryk (lidt sværere)
             *Brugeren indtaster et regnestykke fx 3+8 
             * systemet scanner koden og kommer med resultatet
             * Krav:
             * et udtryk skal starte og slutte med et ciffer
             * Et ciffer skal efterfølges af en operator med mindre, at det er det sidste ciffer i udtrykket
             * En operator skal følges af et ciffer
             * Alle karakterer, der ikke er et ciffer, ’+’ eller ’-’, er ugyldige
             * Sørg for at meddele brugeren, at der er angivet et ugyldigt udtryk, hvis en ugyldig karakter forekommer i udtrykket.
             


            Console.Write("Enter equation: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("");
            int index = 0;
            char c = ' ';
            int ciffer = 0;
            int result = 0;
            char op = '+';
            int number = 0;



            while (index < userInput.Length)
            {
                // c er her userInput som er strengens første plads 0, hvis strengen er "Hej" er userInput[index] "H"
                c = userInput[index];

                /*I følgende if statement er der 3 trin
                 * 1: scan efter og se om der er +
                 * 2: scan og se om der er tal fra 0 til 9
                 * 3: scan og se om der er en anden karakter
                 

                if (c == '+' || c == '-') // i dette if statement kan det enten være at c er + eller c er -
                {
                    {
                        //hvis der + så kører den koden result += number; hvis det er '-' laver den else-delen
                         
                        if (op == '+')
                        {
                            // i denne kode lægger den nummeret til resultatet
                            result += number;
                        }
                        else
                        {
                            // i denne kode trækker den nummeret fra resultatet
                            result -= number;
                        }
                        op = c; // her er sættes op til at være c, som afhængig af if statementet er enten + eller -
                        number = 0; // number resettes
                        index++;
                    }
                }
                // dette tjekker om karakteren er et tal fra 0 til 9             
                else if (c >= '0' && c <= '9')
                {                        
                        number = c - '0';
                        index++;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            //dette er for at få det sidste tal med
            if (op == '+')
            {
                result += number;
            }
            else if (op == '-')
            {
                result -= number;
            }
            Console.WriteLine(result);
            */
      
            /* Øvelse 2.13 */
            Console.Write("Enter equation: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("");

            int index = 0;
            char c = ' ';
            int ciffer = 0;
            double result = 0;
            char op = '+';
            double number = 0;

            while (index < userInput.Length)
            {
                c = userInput[index];
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    switch (op)
                    {
                        case '+':
                            //op = '+';
                            result += number;
                            index++;
                            break;

                        case '-':
                            //op = '-';
                            result -= number;
                            index++;
                            break;

                        case '*':
                            //op = '*';
                            result *= number;
                            index++;
                            break;

                        case '/':

                            if (number == 0)
                            {

                                Console.WriteLine("Error: Division by zero.");
                                return;
                            }
                            //op = '/';
                            result /= number;
                            index++;
                            break;
                    }

                    op = c;
                }

                else if (c >= '0' && c <= '9')
                {
                    number = c - '0';
                    index++;
                }
            }

            switch (op)
            {
                case '+':
                    result += number;
                    break;
                case '-':
                    result -= number;
                    break;
                case '*':
                    result *= number;
                    break;
                case '/':

                    if (number == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        Console.ReadLine();
                        return;
                    }

                    result /= number;
                    break;
            }



            Console.WriteLine("Result: " + result);
            Console.ReadLine();
            

            Console.ReadLine();

        }
    }
}
