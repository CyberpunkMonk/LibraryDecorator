using System;

namespace LibraryDecorator {
    class Book:LibraryItem{
        private string _author;
        private string _title;
        //C'tor
        public Book(string author, string title, int numCopies) {
            this._author=author;
            this._title=title;
            this.NumCopies=numCopies;
        }

        public override void Display() {
            Console.WriteLine($"{_title}-----\n---{_author}\n# Copies: {NumCopies}.");
        }
    }
}