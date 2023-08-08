using System;
//06_15_27//
class Kalkulator_06_15_27
{
    static void Main()
    {
        string YN, YN2;
        int B1_06_15_27;
        int B2_06_15_27;
        Console.Clear();
        int i = 0;
        while (i < 5)
        {

        

        Console.WriteLine("------------------------------");
        Console.WriteLine("||   Kalkulator Sederhana   ||");
        Console.WriteLine("------------------------------");
        Console.Write("Masukkan Bilangan 1: ");
        B1_06_15_27 = int.Parse(Console.ReadLine());
        Console.Write("Masukkan Bilangan 2: ");
        B2_06_15_27 = int.Parse(Console.ReadLine());


        var Satu_06_15_27 = B1_06_15_27 + B2_06_15_27;
        var Dua_06_15_27 = B1_06_15_27 - B2_06_15_27;
        var Tiga_06_15_27 = B1_06_15_27 / B2_06_15_27;
        var Empat_06_15_27 = B1_06_15_27 * B2_06_15_27;
        var Lima_06_15_27 = B1_06_15_27 % B2_06_15_27;;
        var Enam_06_15_27 = Math.Sqrt(B1_06_15_27);
        var Tujuh_06_15_27 = Math.Sqrt(B2_06_15_27);
        var HP_06_15_27 = Math.Pow(B1_06_15_27, B2_06_15_27);


        Console.WriteLine("==============================");
        Console.WriteLine("|| Pilih Operasi Aritmatika ||");
        Console.WriteLine("==============================");
        Console.WriteLine("|| 1. Penjumlahan           ||");
        Console.WriteLine("|| 2. Pengurangan           ||");
        Console.WriteLine("|| 3. Pembagian             ||");
        Console.WriteLine("|| 4. Perkalian             ||");
        Console.WriteLine("|| 5. Sisa Hasil Bagi       ||");
        Console.WriteLine("|| 6. Pangkat               ||");
        Console.WriteLine("|| 7. Akar Pangkat          ||");
        Console.WriteLine("==============================");
        Console.Write("Pilih Nomor Operasinya: ");
        int NoOP = int.Parse(Console.ReadLine());
        Console.WriteLine("==============================");
        if ((NoOP >= 8) || (NoOP <= 0))
        {
            Console.WriteLine("Nomor Tidak Terdefinisi");
        }else if (NoOP == 2)
        {
            Console.WriteLine("Hasil Pengurangan: " + B1_06_15_27 + " - " + B2_06_15_27 + " = " + Dua_06_15_27);
        }else if (NoOP == 3)
        {
            Console.WriteLine("Hasil Pembagian: " + B1_06_15_27 + " / " + B2_06_15_27 + " = " + Tiga_06_15_27);
        }else if (NoOP == 4)
        {
            Console.WriteLine("Hasil Perkalian: " + B1_06_15_27 + " * " + B2_06_15_27 + " = " + Empat_06_15_27);
        }else if (NoOP == 5)
        {
            Console.WriteLine("Hasil Sisa Bagi: " + B1_06_15_27 + " % " + B2_06_15_27 + " = " + Lima_06_15_27);
        } else if ( NoOP == 6)
        {
            Console.WriteLine("Hasil Pangkat: " + B1_06_15_27 + " ^ " + B2_06_15_27 + " = " + HP_06_15_27);
            
        } else if (NoOP == 7)
        {
            Console.WriteLine("Hasil Akar Pangkat Bilangan 1: " + B1_06_15_27 + " = " + Enam_06_15_27);
            Console.WriteLine("Hasil Akar Pangkat Bilangan 2: " + B2_06_15_27 + " = " + Tujuh_06_15_27);
        }
        else
        {
            Console.WriteLine("Hasil Penjumlahan: " + B1_06_15_27 + " + " + B2_06_15_27 + " = " + Satu_06_15_27);
        }
        Console.WriteLine("==============================");
            //06_15_27//
            Console.WriteLine("Apakah Anda Ingin Mengulangi Lagi?");
            Console.WriteLine();
            Console.Write("Y Untuk Mengulangi Atau N Untuk Berhenti: ");
            YN = Console.ReadLine();
            YN2 = YN.ToLower();
            switch (YN2)
            {
                case "y": i = 1; break;
                default:
                    {
                        Console.WriteLine("OKEH");
                        Environment.Exit(1);
                        break;
                    }
            }
            i++;
        }
    }
}