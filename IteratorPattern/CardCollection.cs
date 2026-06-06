using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// Cards Collection class that holds a list of cards and provides methods to add and retrieve cards. 
    /// This class is used by the CardIterator to iterate through the collection of cards.
    /// </summary>
    internal class CardCollection
    {
        private List<string> cards = new List<string>();
        public void AddCard(string card)
        {
            cards.Add(card);
        }

        public List<string> GetCards()
        {
            return cards;
        }
    }
}
