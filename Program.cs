using System;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Dictionary<int, IMenuAction> menuActions = new Dictionary<int, IMenuAction>();
            menuActions.Add(1, new BoardListingAction(database));
            menuActions.Add(2, new AddCardAction(database));
            menuActions.Add(3, new RemoveCardAction(database));
            menuActions.Add(4, new MoveCardAction(database));

            while (true)
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçin.");
                Console.WriteLine("***************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                int choise;

                if(int.TryParse(Console.ReadLine(), out choise))
                {
                    if(menuActions.ContainsKey(choise))
                    {
                        menuActions[choise].Run();
                    }
                }
            }
            
        }
    }
}