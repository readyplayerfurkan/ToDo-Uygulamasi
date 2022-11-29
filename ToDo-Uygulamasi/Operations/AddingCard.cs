using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ToDo_Uygulamasi.Data;

namespace ToDo_Uygulamasi.Operations
{
    public class AddingNewCard : AllOperations
    {
        Card newCard = new();
        public override void AddingCard()
        {
        againId:
            Console.WriteLine("Kart Ekleme Alanı");
            Console.WriteLine("********************************");

            Console.WriteLine("Başlığını giriniz          :");
            newCard.Header = Console.ReadLine();

            Console.WriteLine("İçeriğini giriniz          :");
            newCard.Content = Console.ReadLine();

            Console.WriteLine("Kişiyi seçiniz             :");
            newCard.Person = Console.ReadLine();

            Console.WriteLine("Lütfen durumunu seçiniz (1) To-Do (2) In Progress (3) Done :");
            int choosingStatus = int.Parse(Console.ReadLine());
            if (choosingStatus == 1)
                newCard.Status = "ToDo";
            else if (choosingStatus == 2)
                newCard.Status = "InProgress";
            else if (choosingStatus == 3)
                newCard.Status = "Done";
            else
                Console.WriteLine("Yanlış bir karakter girdiniz.");

            Console.WriteLine("Boyutunu seçiniz (1)XS (2)S (3)M (4)L (5)XL");
            int choosingSize = int.Parse(Console.ReadLine());
            string choosingSizeString = Enum.GetName(typeof(size), choosingSize);
            newCard.Size = choosingSizeString;
            CheckingTheId();
        }

        public void CheckingTheId()
        {
        againId:
            Database ıdCheck = new();
            Console.WriteLine("Lütfen ID numaranızı giriniz    :");
            int id = int.Parse(Console.ReadLine());
            var item = Database.Person.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                Database.Card.Add(newCard);
                Console.WriteLine("Yeni kart {0} tarafından oluşturulmuştur.", item.Name );
            }
            else
            {
                Console.WriteLine("Yanlış bir değer girdiniz. Tekrar denemek için (1)");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    goto againId;
            }
        }
    }
    enum size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
