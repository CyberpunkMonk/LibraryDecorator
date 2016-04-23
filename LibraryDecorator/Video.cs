using System;

namespace LibraryDecorator {
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class Video:LibraryItem {
        private string _director;
        private string _title;
        private int _playTime;
        public Video(string director, string title, int numCopies,int playTime) {
            this._director=director;
            this._title=title;
            this.NumCopies=numCopies;
            this._playTime=playTime;
        }
        public override void Display() {
            Console.WriteLine($"{_title} -----\n---{_director}\n# Copies: {NumCopies}\nPlaytime: {_playTime}");
        }
    }
}