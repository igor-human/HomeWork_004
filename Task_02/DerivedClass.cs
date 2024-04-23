﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML");
        }
        public override void Change()
        {
            Console.WriteLine("Change XML");
        }
        public override void Create()
        {
            Console.WriteLine("Create XML");
        }
        public override void Save()
        {
            Console.WriteLine("Save XML");
        }

    }
    internal class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
    internal class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }
}
