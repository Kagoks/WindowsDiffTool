﻿using System.Collections.Generic;
using System.Linq;
using WindowsSystemDiffToolsCore;

namespace InstalledPrograms64bitsScanner
{
    public class InstalledProgram64bitsDiff : DiffCore
    {
        public InstalledProgram64bitsDiff(){}


        List<InstalledProgram64bits> beforeList;
        List<InstalledProgram64bits> afterList;


        public override List<DiffResult> Start()
        {
            List<DiffResult> results = new List<DiffResult>();

            beforeList = GetBeforeData<InstalledProgram64bits>();
            afterList = GetAfterData<InstalledProgram64bits>();


            foreach(InstalledProgram64bits beforeItem in beforeList)
            {
                InstalledProgram64bits afterItem = afterList.FirstOrDefault(x => x.UninstallKey == beforeItem.UninstallKey);

                if (afterItem == null)
                {
                    //Product has been uninstalled, no longer exists in the registry
                    results.Add(DiffResult.Removed(beforeItem));
                    continue;
                }


                if((beforeItem.DisplayName != afterItem.DisplayName) || (beforeItem.DisplayVersion != afterItem.DisplayVersion))
                {
                    //DisplayName or DisplayVersion modified
                    results.Add(DiffResult.Modified(beforeItem, afterItem));
                    continue;
                }   
            }

            foreach(InstalledProgram64bits afterItem in afterList)
            {
                InstalledProgram64bits beforeItem = beforeList.FirstOrDefault(x => x.UninstallKey == afterItem.UninstallKey);

                if(beforeItem == null)
                {
                    //Product didn't exist before, it has been installed
                    results.Add(DiffResult.Added(afterItem));
                }


            }

            return results;
        }


        
    }
}
