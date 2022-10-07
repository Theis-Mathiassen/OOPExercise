using System;
using System.Collections.Generic;
using System.IO;

namespace _04
{
    class FileSystemMenu : Menu, IMenuItem
    {
        public DirectoryInfo directoryInfo { get; private set; }
        
        
        public FileSystemMenu(string title, DirectoryInfo _directoryInfo) : base(title)
        {
            directoryInfo = _directoryInfo;
        }
        public FileSystemMenu(string title, DirectoryInfo directoryInfo, params MenuItem[] menuItems) : this(title, directoryInfo)
        {
            foreach (MenuItem item in menuItems)
            {
                Add(item);
            }
        }

        public override void Start()
        {
            try
            {
                LoadFolderEntries();

            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            base.Start();
        }

        private void LoadFolderEntries ()
        {
            //  Loop through all the files in C.
            foreach (DirectoryInfo entry in directoryInfo.GetDirectories())
            {
                Add(new FileSystemMenu(entry.Name, entry));
            }
            //  Loop through all the files in C.
            foreach (FileInfo entry in directoryInfo.GetFiles())
            {
                Add(new MenuItem(entry.Name));
            }
        }
    }
}
