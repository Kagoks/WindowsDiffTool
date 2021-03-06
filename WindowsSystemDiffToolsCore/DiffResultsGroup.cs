﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsSystemDiffToolsCore
{
    public class DiffResultsGroup
    {
        public List<DiffResult> DiffResults { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        public DiffResultsGroup() { }

        public DiffResultsGroup(List<DiffResult> results, string name)
        {
            DiffResults = results;
            Name = name;
        }
    }
}
