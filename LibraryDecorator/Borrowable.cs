using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDecorator {
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable:Decorator {
        protected List<string> borrowers = new List<string>();
        //C'tor
        public Borrowable(LibraryItem libraryItem) : base(libraryItem) {}
        public void BorrowItem(string name) {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }
        public void ReturnItem(string name) {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }
        public override void Display() {
            base.Display();
            foreach(string b in borrowers) {
                Console.WriteLine($" Borrower: {b}");
            }
        }
    }
}