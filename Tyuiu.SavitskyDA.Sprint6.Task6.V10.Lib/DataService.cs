﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SavitskyDA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] itog = line.Split(' ');
                    for (int i = 0; i < itog.Length; i++)
                    {
                        if (itog[i].Contains("w") || itog[i].Contains("W"))
                        {
                            resStr =  resStr + " " + itog[i];
                        }
                    }
                }
                return resStr;
            }
        }
    }
}
