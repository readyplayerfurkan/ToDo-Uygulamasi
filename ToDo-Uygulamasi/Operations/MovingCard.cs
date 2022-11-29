using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Uygulamasi.Data;

namespace ToDo_Uygulamasi.Operations
{
    public class MovingTheCard : AllOperations
    {
        public override void MovingCard()
        {
        againMove:
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını giriniz            :");
            string? choice = Console.ReadLine();
            var item = Database.Card.FirstOrDefault(person => person.Header == choice);
            if(item == null)
            {
            againFail:
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                    goto end;
                else if (choice2 == 2)
                    goto againMove;
                else
                {
                    Console.WriteLine("Geçersiz bir karakter girdiniz. Lütfen tekrar deneyiniz.");
                    goto againFail;
                }
            }
            else
            {
            againStatus:
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("***********************");
                Console.WriteLine("Başlık       : {0}", item.Header);
                Console.WriteLine("İçerik       : {0}", item.Content);
                Console.WriteLine("Atanan Kişi  : {0}", item.Person);
                Console.WriteLine("Büyüklük     : {0}", item.Size);
                Console.WriteLine("Line     : {0}", item.Status);
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int choiceStatus = int.Parse(Console.ReadLine());
                if (choiceStatus == 1)
                    item.Status = "ToDo";
                else if (choiceStatus == 2)
                    item.Status = "InProgress";
                else if (choiceStatus == 3)
                    item.Status = "Done";
                else
                {
                    Console.WriteLine("Yanlış bir karakter girdiniz.");
                    Console.WriteLine("Çıkmak için : (1)");
                    Console.WriteLine("Yeniden denemek için : (2)");
                    int choiceExitOrNot = int.Parse(Console.ReadLine());
                    if (choiceExitOrNot == 1)
                        goto end;
                    else if (choiceExitOrNot == 2)
                        goto againStatus;
                }
                ListingAllCards list = new();
                list.ListingCard();
            }
        end:;
        }
    }
}
