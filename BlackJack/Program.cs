using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program4
    {
        static void Main(string[] args)
        {
            bool b = true;
            bool a = true;
            Console.WriteLine("Blackjacke Hoşgeldiniz !");
            int oyuncukart = 0; int kasakart = 0;
            int oyuncukartsayisi = 0; int kasakartsayisi = 0;
            Random rnd = new Random();
            int rastgele = rnd.Next(1, 11);
            while (oyuncukartsayisi <= 1)
            {
                switch (rastgele)
                {
                    case 1: Console.WriteLine("1 Numaralı Kart !"); oyuncukart += 1; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 2: Console.WriteLine("2 Numaralı Kart !"); oyuncukart += 2; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 3: Console.WriteLine("3 Numaralı Kart !"); oyuncukart += 3; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 4: Console.WriteLine("4 Numaralı Kart !"); oyuncukart += 4; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 5: Console.WriteLine("5 Numaralı Kart !"); oyuncukart += 5; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 6: Console.WriteLine("6 Numaralı Kart !"); oyuncukart += 6; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 7: Console.WriteLine("7 Numaralı Kart !"); oyuncukart += 7; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 8: Console.WriteLine("8 Numaralı Kart !"); oyuncukart += 8; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 9: Console.WriteLine("9 Numaralı Kart !"); oyuncukart += 9; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                    case 10: Console.WriteLine("10 Numaralı Kart !"); oyuncukart += 10; oyuncukartsayisi++; rastgele = rnd.Next(1, 11); break;
                }
                Console.WriteLine("Toplam :" + oyuncukart);
            }
            while (kasakartsayisi<=0)
            {
                int rastgele2 = rnd.Next(1, 11);
                switch (rastgele2)
                {
                    case 1: kasakart += 1; kasakartsayisi++; break;
                    case 2: kasakart += 2; kasakartsayisi++; break;
                    case 3: kasakart += 3; kasakartsayisi++; break;
                    case 4: kasakart += 4; kasakartsayisi++; break;
                    case 5: kasakart += 5; kasakartsayisi++; break;
                    case 6: kasakart += 6; kasakartsayisi++; break;
                    case 7: kasakart += 7; kasakartsayisi++; break;
                    case 8: kasakart += 8; kasakartsayisi++; break;
                    case 9: kasakart += 9; kasakartsayisi++; break;
                    case 10: kasakart += 10; kasakartsayisi++; break;
                }
                Console.WriteLine("Kasanın ilk kartı : " + kasakart);
                while(kasakartsayisi<=1)
                {
                     rastgele2 = rnd.Next(1, 11);
                    switch (rastgele2)
                    {
                        case 1: kasakart += 1; kasakartsayisi++; break;
                        case 2: kasakart += 2; kasakartsayisi++; break;
                        case 3: kasakart += 3; kasakartsayisi++; break;
                        case 4: kasakart += 4; kasakartsayisi++; break;
                        case 5: kasakart += 5; kasakartsayisi++; break;
                        case 6: kasakart += 6; kasakartsayisi++; break;
                        case 7: kasakart += 7; kasakartsayisi++; break;
                        case 8: kasakart += 8; kasakartsayisi++; break;
                        case 9: kasakart += 9; kasakartsayisi++; break;
                        case 10: kasakart += 10; kasakartsayisi++; break;
                    }
                    Console.WriteLine("Kasanın ikinci kartı : ?(Bilinmiyor)");
                    break;
                }
            }
            Console.Write("Oyuncu,kart çekmek ister misin ?"); Console.Write(" Evet Veya Hayır ");
            string secenek = Console.ReadLine();
            while (a)
            {
                if (secenek == "Evet" || secenek == "evet")
                {
                    rastgele = rnd.Next(1, 11);
                    switch (rastgele)
                    {
                        case 1: Console.WriteLine("1 Numaralı Kart !"); oyuncukart += 1; oyuncukartsayisi++; break;
                        case 2: Console.WriteLine("2 Numaralı Kart !"); oyuncukart += 2; oyuncukartsayisi++; break;
                        case 3: Console.WriteLine("3 Numaralı Kart !"); oyuncukart += 3; oyuncukartsayisi++; break;
                        case 4: Console.WriteLine("4 Numaralı Kart !"); oyuncukart += 4; oyuncukartsayisi++; break;
                        case 5: Console.WriteLine("5 Numaralı Kart !"); oyuncukart += 5; oyuncukartsayisi++; break;
                        case 6: Console.WriteLine("6 Numaralı Kart !"); oyuncukart += 6; oyuncukartsayisi++; break;
                        case 7: Console.WriteLine("7 Numaralı Kart !"); oyuncukart += 7; oyuncukartsayisi++; break;
                        case 8: Console.WriteLine("8 Numaralı Kart !"); oyuncukart += 8; oyuncukartsayisi++; break;
                        case 9: Console.WriteLine("9 Numaralı Kart !"); oyuncukart += 9; oyuncukartsayisi++; break;
                        case 10: Console.WriteLine("10 Numaralı Kart !"); oyuncukart += 10; oyuncukartsayisi++; break;
                    }
                    Console.WriteLine("Yeni Toplam :" + oyuncukart);
                    if (oyuncukart > 21)
                    {
                        Console.WriteLine("Yenildiniz...");
                        a = false;
                        b = false;
                        break;
                    }                                                       
                    Console.Write("Oyuncu,kart çekmek ister misin ?"); Console.Write(" Evet Veya Hayır ");
                    secenek = Console.ReadLine();
                }
                else if(secenek == "Hayır" || secenek == "hayır")
                {
                    Console.WriteLine("Oyuncunun son durumdaki kart numarası :"+oyuncukart);
                    Console.WriteLine("PC'nin kart numarası : "+kasakart);
                    Console.ReadKey();
                    while(b)
                    {
                        if(kasakart < 16 || kasakart < oyuncukart)
                        {
                            int rastgele2 = rnd.Next(1, 11);
                            kasakart += rastgele2;
                            Console.WriteLine("PC'nin yeni kart numarası :"+kasakart);
                            if(kasakart > 21)
                            {
                                Console.WriteLine("PC Yenildi");
                                b = false;
                                a = false;
                                break;
                            }
                            else if (kasakart == 21)
                            {
                                Console.WriteLine("Kasa Kazandı ...");
                                b = false;
                                a = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            oyuncukart = 21 - oyuncukart;
                            kasakart = 21 - kasakart;
                            if (oyuncukart == kasakart)
                            {
                                Console.WriteLine("Berabere");
                                b = false;
                                a = false;
                                break;
                            }
                            else if (oyuncukart < kasakart)
                            {
                                Console.WriteLine("Oyuncu kazandı");
                                b = false;
                                a = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kasa kazandı");
                                b = false;
                                a = false;
                                break;
                            }                                                 
                        }
                    }                   
                }              
            }            
        }
    }   
}
    
            
        








        
    

