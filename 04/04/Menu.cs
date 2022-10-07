using System;
using System.Collections.Generic;

namespace _04
{
    class Menu : IMenuItem
    {

        public string MenuPath { get; set; }
        public string Title { get; set; }
        public int SelectedIndex { get; set; }
        public bool Selected { get; set; }
        public bool Clicked { get; set; }
        public int Level { get; set; }

        internal bool running { get; set; }

        internal List<IMenuItem> menuItems = new List<IMenuItem>();

        public Menu(string title)
        {
            MenuPath = "Root" + Title;
            Level = 1;
            Title = title;
        }
        public Menu(string title, params MenuItem[] menuItems) : this(title)
        {
            foreach (MenuItem item in menuItems)
            {
                Add(item);
            }
        }

        public void Add(IMenuItem menuItem)
        {
            if (menuItem is Menu menu)
            {
                menu.MenuPath = MenuPath + "/" + menu.Title;
                menu.Level = Level + 1;
            }
            menuItems.Add(menuItem);
        }

        public virtual void Start()
        {
            Selected = false;
            Clicked = true;
            running = true;
            SelectedIndex = 0;
            if (menuItems.Count > 0)
            {
                menuItems[SelectedIndex].Select();
            }
            Print();
            do
            {
                HandleInput();
                Print();
            } while (running);
            MenuBack();
        }

        internal void MenuBack()
        {
            Clicked = false;
            Selected = true;
            foreach (IMenuItem menuItem in menuItems)
            {
                menuItem.Selected = false;
                menuItem.Clicked = false;
            }
        }

        internal void MenuUp()
        {
            if (SelectedIndex > 0)
            {
                menuItems[SelectedIndex].DeSelect();
                SelectedIndex--;
                menuItems[SelectedIndex].Select();
            }
        }
        internal void MenuDown()
        {
            if (SelectedIndex < menuItems.Count - 1)
            {
                menuItems[SelectedIndex].DeSelect();
                SelectedIndex++;
                menuItems[SelectedIndex].Select();
            }
        }

        public void HandleInput ()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.UpArrow:
                    MenuUp();
                    break;
                case ConsoleKey.DownArrow:
                    MenuDown();
                    break;
                case ConsoleKey.Enter:
                    if (menuItems.Count > 0)
                    {
                        menuItems[SelectedIndex].Click();
                    }
                    break;
                case ConsoleKey.Escape:
                    running = false;
                    break;
                default:
                    break;
            }
        }

        public void Print ()
        {
            if (Clicked)
            {
                Console.Clear();
            }
            ConsoleColor originalColor = Console.BackgroundColor;
            if (Selected)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(Title);
            Console.BackgroundColor = originalColor;
            if (Clicked)
            {
                Console.WriteLine("Path: " + MenuPath);
                if (menuItems.Count > 0)
                {
                    foreach (IMenuItem item in menuItems)
                    {
                        Console.Write(new String(' ', Level * 2));
                        item.Print();
                    }
                }
                else
                {
                    Console.WriteLine(" - Empty");
                }
            }
            
        }

        public void Select()
        {
            Selected = true;
        }
        public void DeSelect()
        {
            Selected = false;
        }
        public void Click()
        {
            Clicked = !Clicked;
            if (Clicked)
            {
                Start();
            }
        }
    }
}
