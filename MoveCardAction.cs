using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class MoveCardAction : IMenuAction
    {
        private readonly Database database;
        public MoveCardAction(Database database)
        {
            this.database = database;
        }
        public void Run()
        {
            Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor. ");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");

            string input = Console.ReadLine();
            CardInformation cards = database.MoveCard(input);

            if(cards != null)
            {
                Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
                Console.WriteLine("(0) TODO");
                Console.WriteLine("(1) IN PROGRESS");
                Console.WriteLine("(2) DONE");

                int line = Convert.ToInt32(Console.ReadLine());

                if (line == 0) { cards.boardType = "TODO"; }
                else if (line == 1) { cards.boardType = "IN PROGRESS"; }
                else if (line == 2) { cards.boardType = "DONE"; }
                else { cards.boardType = "Hatalı bir seçim yaptınız!"; }
            }
            else
            {
                 Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                 Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                 Console.WriteLine("Yeniden denemek için : (2)");
                 int choice = Convert.ToInt32(Console.ReadLine());
                 if(choice == 2)
                 {
                    Run();
                 }
            }

            


            
        }
    }
}