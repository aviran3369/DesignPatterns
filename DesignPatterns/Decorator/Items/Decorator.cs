﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Items
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        // Constructor
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
