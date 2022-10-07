
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace _04
{
    class MenuItem : IMenuItem
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public bool Selected { get; set; }
        public bool Clicked { get; set; }

        public MenuItem(string title)
        {
            Title = title;
            Selected = false;
            Clicked = false;
        }
        public MenuItem(string title, string content) : this(title)
        {
            Content = content;
        }

        public void Select ()
        {
            Selected = true;
        }
        public void DeSelect()
        {
            Selected = false;
        }
        public void Click ()
        {
            Clicked = !Clicked;
            if (Clicked)
            {
                //Do something
            }
        }

        public void Print ()
        {
            ConsoleColor originalColor = Console.BackgroundColor;
            if (Selected)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("Item: " + Title);
            Console.BackgroundColor = originalColor;
            if (Clicked)
            {
                Console.WriteLine(" - " + Content);
            }
        }

    }
}
