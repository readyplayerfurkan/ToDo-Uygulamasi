using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ToDo_Uygulamasi.Data;

namespace ToDo_Uygulamasi.Operations
{
    public class DeletingTheCard : AllOperations 
    {
        public override void DeletingCard()
        {
        againDelete:
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız             :");
            string? choose = Console.ReadLine();
            Database person = new();
            var item = Database.Card.FirstOrDefault(x => x.Header == choose);
            if (item != null)
            {
                Database.Card.Remove(item);
                Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun bir kart bulunamadı.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int chooseNumber = int.Parse(Console.ReadLine());
                if (chooseNumber == 1)
                    goto endingDelete;
                else if (chooseNumber == 2)
                    goto againDelete;

            }
        endingDelete:;
        }
    }
}
