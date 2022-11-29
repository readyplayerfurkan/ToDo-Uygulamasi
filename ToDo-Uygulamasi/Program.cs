using System.Diagnostics;
using System.Linq.Expressions;
using ToDo_Uygulamasi.Operations;

while (true)
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Board Listelemek");
    Console.WriteLine("(2) Board'a Kart Eklemek");
    Console.WriteLine("(3) Board'dan Kart Silmek");
    Console.WriteLine("(4) Kart Taşımak");
    Console.WriteLine("(5) Uygulamadan Çıkış Yapmak");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ListingAllCards list = new();
            list.ListingCard();
            break;
        case "2":
            AddingNewCard add = new();
            add.AddingCard();
            break;
        case "3":
            DeletingTheCard delete = new();
            delete.DeletingCard();
            break;
        case "4":
            MovingTheCard move = new();
            move.MovingCard();
            break;
        case "5":
            goto end;           
    }
}
end:;
