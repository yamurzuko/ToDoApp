using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class Board
    {
        private List<CardInformation>? todoLine;
        private List<CardInformation>? inProgressLine;
        private List<CardInformation>? doneLine;
        
        public Board(List<CardInformation>? todoLine, List<CardInformation>? inProgressLine, List<CardInformation>? doneLine)
        {
            this.TodoLine = todoLine;
            this.InProgressLine = inProgressLine;
            this.DoneLine = doneLine;
        }
        public List<CardInformation>? TodoLine { get => todoLine; set => todoLine = value; }
        public List<CardInformation>? InProgressLine { get => inProgressLine; set => inProgressLine = value; }
        public List<CardInformation>? DoneLine { get => doneLine; set => doneLine = value; }
    }
}