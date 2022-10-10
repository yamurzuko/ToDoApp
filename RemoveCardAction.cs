using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class RemoveCardAction : IMenuAction
    {
        private readonly Database database;
        public RemoveCardAction(Database database)
        {
            this.database = database;
        }
        public void Run()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string input = Console.ReadLine();
            if(database.RemoveCard(input))
            {
                Console.WriteLine("Kart Silindi");
            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
                Console.WriteLine("* Yeniden denemek için : (2) ");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                }
                else if (choice == 2)
                {
                    Run();
                }
            }
            
        }
    }
}