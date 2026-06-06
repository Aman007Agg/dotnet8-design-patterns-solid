using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// Card Iterator class that implements the iterator pattern to traverse through the CardCollection.
    /// </summary>
    internal class CardIterator
    {
        private CardCollection collection;

        private int position = 0;

        public CardIterator(CardCollection collection)
        {
            this.collection = collection;
        }

        public bool HasNext()
        {
            return position < collection.GetCards().Count;
        }

        public string Next()
        {
            if (HasNext())
            {
                return collection.GetCards()[position++];
            }
            else
            {
                throw new InvalidOperationException("No more cards in the collection.");
            }
        }

    }
}
