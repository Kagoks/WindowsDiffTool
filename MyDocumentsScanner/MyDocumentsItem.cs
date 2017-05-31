﻿using System;
using System.Collections.Generic;
using System.IO;
using WindowsSystemDiffToolsCore;

namespace MyDocumentsScanner
{
    public class MyDocumentsItem : Component
    {

        public string Path { get; set; }
        public DateTime LastWriteDate { get; set; }

        public MyDocumentsItem() { }

        public MyDocumentsItem(FileSystemInfo fsInfo)
        {
            this.Path = fsInfo.FullName;
            this.LastWriteDate = fsInfo.LastWriteTime;
        }

        public override string getDisplayName()
        {
            return $"{this.Path}";
        }

        public override Dictionary<string, string> getItems()
        {
            return new Dictionary<string, string>()
            {
                { "Last Write Time", this.LastWriteDate.ToString("yyyy-MM-dd HH:mm:ss") }
            };
        }
    }
}
