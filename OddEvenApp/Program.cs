using System.Reflection.Metadata.Ecma335;

namespace OddEvenApp;

class Program
{
    /*
     * Menampilkan Menu
     */
    static void Menu()
    {
        Console.WriteLine("=====================================================");
        Console.WriteLine("                  Menu Ganjil Genap                  ");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("1. Cek Ganjil Genap");
        Console.WriteLine("2. Print Ganjil / Genap (Dengan Limit)");
        Console.WriteLine("3. Exit");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("");

        //  Console.WriteLine("Anda Exit?");
    }

    /*
     * ex: PrintEvenOdd(5, "Genap"') ;
     * output 1, 3, 5
     * x: PrintEvenOdd(5, "Ganjil");
     * output 2, 4
     * @PARAM Limit: Batas akhir. minimal 1, tidak boleh O atau negatif.
     * @PARAM choice: Pilihan, hanya boleh "Even" atau "Odd". Selain itu invalid
     */
    static void PrintEvenOdd(int limit, string choice)
    {
        // Console.WriteLine("argument masuk: " + limit + " dan " + choice);
        int modularResult;
        choice = choice.ToLower();
        switch (choice)
        {
            case "ganjil":
                modularResult = 1;
                break;
            case "genap":
                modularResult = 0;
                break;
            default:
                Console.WriteLine("Input Pilihan Invalid !!!");
                return;
        }

        Console.WriteLine("Print bilangan 1 - " + limit + " :");
        if (limit <= 0 || 1%limit == modularResult)
        {
            Console.WriteLine("Input Limit Invalid !!!!");
            return;
        }
        

        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 == modularResult)
            {
                if(i == limit || i+1 == limit)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
        Console.WriteLine("");

    }

    /*
     * ex: EvenOddCheck(5);
     * output "Even"
     * @PARAM input: Angka yang akan dicek. minimal 1, tidak boleh O atau negatif.
     * @RETURN "Genap" jika input genap, "Ganil". jika input ganjil, selain itu Invalid Input!! jika input tidak sesuai pada @PARAM input
     */
    static string CheckEvenOrOdd(int input)
    {
        if (input <= 0)
        {
            return "Input is Invalid !!!!";
        }
        if (input % 2 == 0)
        {
            return "Genap";
        }
        return "Ganjil";
    }

    static void Main(string[] args)
    {
        var input = "";
        do
        {
            Menu();
            Console.Write("Pilihan: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Masukan Bilangan yang ingin di cek: ");
                    var input_I = Console.ReadLine();
                    try
                    {
                        int convert_I = Convert.ToInt32(input_I);
                        input_I = CheckEvenOrOdd(convert_I);
                        Console.WriteLine(input_I);
                    }
                    catch
                    {
                        Console.WriteLine("Input harus numeric!!");
                    }
                    

                    break;
                case "2":
                    Console.Write("Pilih (Ganjil / Genap): ");
                    var input_II = Console.ReadLine() ?? "";
                    Console.Write("Masukan Limit: ");
                    var input_III = Console.ReadLine();
                    int convert_II;
                    try
                    {
                        convert_II = Convert.ToInt32(input_III);
                        PrintEvenOdd(convert_II, input_II);
                    }
                    catch
                    {
                        Console.WriteLine("Input Limit tidak valid!!");
                    }
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Invalit Input, Choose Listed Menu !!!!");
                    break;
            }

            Console.ReadLine();
        } while (input != "3");
    }
}