using System;

namespace LibraryDecorator {
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    class Decorator:LibraryItem {
        protected LibraryItem libraryItem;
        public Decorator(LibraryItem libraryItem) {
            this.libraryItem=libraryItem;
        }
        public override void Display() {
            libraryItem.Display();
        }
    }
}