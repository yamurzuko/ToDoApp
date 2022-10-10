using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class BoardListingAction : IMenuAction
    {
        private readonly Database database;
        private List<CardInformation> TodoList;
        private List<CardInformation> InProgressList;
        private List<CardInformation> DoneList;
        private Board Boards;
        public BoardListingAction(Database database)
        {
            this.database = database;
        }
        public void Run()
        {
            List<CardInformation> cardList = database.CardList();
            

            foreach (var item in cardList)
            {
                if(item.boardType == "TODO")
                {
                    TodoList = new List<CardInformation>()
                    {
                        new CardInformation(item.title, item.content, item.person, item.size, item.boardType)
                    };
                }
                else if(item.boardType == "INPROGRESS")
                {
                    InProgressList = new List<CardInformation>()
                    {
                        new CardInformation(item.title, item.content, item.person, item.size, item.boardType)
                    };
                }
                else if(item.boardType == "DONE")
                {
                    DoneList = new List<CardInformation>()
                    {
                        new CardInformation(item.title, item.content, item.person, item.size, item.boardType)
                    };
                }
            }
            Boards = new Board(TodoList, InProgressList, DoneList);
            

            database.ShowList("TODO Line", Boards.TodoLine);
            database.ShowList("IN PROGRESS Line", Boards.InProgressLine);
            database.ShowList("DONE Line", Boards.DoneLine);
        }
    }
}