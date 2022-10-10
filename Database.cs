using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class Database
    {
        private List<PersonInformation> _personList;
        private List<CardInformation> _cardsList;
        public Database()
        {
            _personList = new List<PersonInformation>()
            {
                new PersonInformation(1, "Ahmet", "Ali"),
                new PersonInformation(2, "Ayşe", "Bakır"),
                new PersonInformation(3, "Tuna", "Demir"),
            };

            _cardsList = new List<CardInformation>()
            {
                new CardInformation("Yazılım", "C# dilini öğrenecek", "Ahmet", "XL", "TODO"),
                new CardInformation("Kurs", "Kursun ödevini tamamlıyor..", "Ayşe", "L", "INPROGRESS"),
                new CardInformation("Meslek", "İyi bir yazılımcı olacak.", "Tuna", "M", "DONE"),
            };
        }

        public void AddCard(CardInformation cardInfo)
        {
            _cardsList.Add(cardInfo);
        }

        public List<CardInformation> CardList()
        {
            return _cardsList;
        }
        public List<PersonInformation> PersonList()
        {
            return _personList;
        }
        public void ShowList(string boardName, List<CardInformation> cardList)
        {
            Console.WriteLine(boardName);
            Console.WriteLine("******************");

            foreach (var item in cardList)
            {
                Console.WriteLine("Başlık      :  {0}", item.title);
                Console.WriteLine("İçerik      :  {0}", item.content);
                Console.WriteLine("Atanan Kişi :  {0}", item.person);
                Console.WriteLine("Büyüklük    :  {0}\n", item.size);
            }
        }
        public bool RemoveCard(string information)
        {
            CardInformation card = null;

            foreach (var item in _cardsList)
            {
                if(information == item.title)
                {
                    card = item;
                    break;
                }
            }
            if(card != null)
            {
                _cardsList.Remove(card);
                return true;
            }
            return false;
        }

        public CardInformation MoveCard(string information)
        {
            foreach (var item in _cardsList)
            {
                if(information == item.title)
                {
                    Console.WriteLine("Bulunan kart bilgiler");
                    Console.WriteLine("*******************************************");

                    Console.WriteLine("Başlık      :  {0}", item.title);
                    Console.WriteLine("İçerik      :  {0}", item.content);
                    Console.WriteLine("Atanan Kişi :  {0}", item.person);
                    Console.WriteLine("Büyüklük    :  {0}", item.size);
                    Console.WriteLine("Line        :  {0}\n", item.boardType);

                    return item;
                }
            }
            return null;
        }
    }
}