﻿using System.Collections.Generic;
using System.Text;

namespace WindowsSystemDiffToolsCore
{
    public static class DiffResultGroupsTextWriter
    {

        public static string GetText(List<DiffResultsGroup> groups)
        {
            StringBuilder sb = new StringBuilder();

            foreach(DiffResultsGroup group in groups)
            {
                sb.Append((new DiffResultTextWriter(group)).GetText());
            }

            return sb.ToString();
        }


    }
}
