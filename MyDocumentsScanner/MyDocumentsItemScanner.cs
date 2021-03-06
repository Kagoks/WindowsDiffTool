﻿using System;
using System.Collections.Generic;
using System.IO;
using WindowsSystemDiffToolsCore;

namespace MyDocumentsScanner
{
    public class MyDocumentsItemScanner : ComponentScanner
    {



        protected override string Name { get { return "My Documents folder"; } }

        public override string ComponentName { get { return "MyDocumentsItem"; } }
        public override string ComponentNamespace { get { return "MyDocumentsScanner"; } }

        List<Component> items = new List<Component>();

        public override List<Component> Scan()
        {           
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            GetItems(path);

            Listener.sendStringToUI($"Scanned {items.Count} items in the My Documents folder");

            return items;
        }

        private void GetItems(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            if (!dir.Attributes.HasFlag(FileAttributes.ReparsePoint))
            {
                foreach (DirectoryInfo d in dir.GetDirectories())
                    GetItems(d.FullName);

                foreach (FileSystemInfo fsInfo in dir.GetFileSystemInfos())
                {
                    items.Add(new MyDocumentsItem(fsInfo));
                }
            }




        }



        public override Type TypeOfComponent()
        {
            return typeof(MyDocumentsItem);
        }

        public override Type TypeOfComponentDiff()
        {
            return typeof(MyDocumentsItemScanner);
        }
    }
}
