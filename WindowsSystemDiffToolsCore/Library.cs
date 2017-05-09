﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSystemDiffToolsCore
{
    public class Library
    {
        public ComponentScanner Scanner { get; set; }
        public DiffCore Diff { get; set; }

        public Library(ComponentScanner scanner, DiffCore diff)
        {
            this.Scanner = scanner;
            this.Diff = diff;
        }

        public override string ToString()
        {
            return this.Scanner.ToString();
        }





    }
}
