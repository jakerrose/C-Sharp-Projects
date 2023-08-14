using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Deck
    {
        //Constructor
        public Deck()
        {
            Cards = new List<Card>();
            //13 possible faces
            for (int i=0; i<13; i++)
            {
                //4 suits
                for (int j =0; j<4; j++)
                {
                    //loops 52 times
                    Card card = new Card();
                    //assigns Face
                    card.Face = (Face)i;
                    //assigns Suit
                    card.Suit = (Suit)j;
                    //add to card list
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
           
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
