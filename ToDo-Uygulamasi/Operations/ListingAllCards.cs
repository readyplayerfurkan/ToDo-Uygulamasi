using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_Uygulamasi.Data;

namespace ToDo_Uygulamasi.Operations
{
    public class ListingAllCards : AllOperations
    {
        private static Board _Boards;

        public void LineTheBoard()
        {
            var toDo = Database.Card.Where(x => x.Status == "ToDo").ToList();
            var inProgress = Database.Card.Where(x => x.Status == "InProgress").ToList();
            var done = Database.Card.Where(x => x.Status == "Done").ToList();

            _Boards = new Board();
            _Boards.ToDo = toDo;
            _Boards.InProgress = inProgress;
            _Boards.Done = done;
        }
        public override void ListingCard()
        {
            LineTheBoard();
            DisplayTheCard(" TODO Line", _Boards.ToDo);
            DisplayTheCard(" IN PROGRESS Line", _Boards.InProgress);
            DisplayTheCard(" DONE Line", _Boards.Done);

        }
        public void DisplayTheCard(string boardType, List<Card>? listName)
        {
            Console.WriteLine(boardType);
            Console.WriteLine("****************************");
            foreach (var item in listName)
            {
                Console.WriteLine("Başlık      : {0}", item.Header);
                Console.WriteLine("İçerik      : {0}", item.Content);
                Console.WriteLine("Atanan Kişi : {0}", item.Person);
                Console.WriteLine("Büyüklük    : {0}", item.Size);
                Console.WriteLine("-");
            }
        }
    }
}
