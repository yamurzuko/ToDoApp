using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class CardInformation
    {
        public string title;
        public string content;
        public string person;
        public string size;
        public string boardType;

        public CardInformation(string title, string content, string person, string size, string bordType)
        {
            this.title = title;
            this.content = content;
            this.person = person;
            this.size = size;
            this.boardType = bordType;
        }
    }
}