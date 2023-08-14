﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino

{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    //defined emum Suit
    public enum Suit
    {
        Clubs, 
        Diamonds,
        Hearts,
        Spades
    }
    //defined enum Face
    public enum Face
    {
        Two,
        Three, 
        Four,
        Five, 
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen, 
        King, 
        Ace
    }
}
