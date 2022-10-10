using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class AddCardAction : IMenuAction
    {
        private readonly Database database;
        public AddCardAction(Database database)
        {
            this.database = database;
        }
        public void Run()
        {
            List<PersonInformation> persons = database.PersonList();
            List<CardInformation> cards =database.CardList();

            Console.WriteLine("Kart Ekleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.Write(" Başlık Giriniz                                  : ");
            string Title = Console.ReadLine();

            Console.Write(" İçerik Giriniz                                  : ");
            string Content = Console.ReadLine();

            Console.Write(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string sizeValue = Enum.GetName(typeof(Sizes), size);

            Console.WriteLine("İşleme devam edebilmek için ID nizi giriniz ");
            int id = Convert.ToInt32(Console.ReadLine());
            

            foreach (var item in persons)
            {
                if(id == item.id)
                {
                    CardInformation newCard = new CardInformation(Title, Content, item.name, sizeValue, "");
                    database.AddCard(newCard);
                    Console.WriteLine("Kart Oluşturuldu.");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı ID girdiniz.");
                }
            }
        }
        enum Sizes
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
    }
}