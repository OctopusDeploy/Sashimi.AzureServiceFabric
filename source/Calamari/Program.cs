﻿using System.Collections.Generic;
 using System.Reflection;
 using System.Threading.Tasks;
 using Calamari.AzureScripting;
 using Calamari.Common;
using Calamari.Common.Plumbing.Logging;

namespace Calamari.AzureServiceFabric
{
    public class Program : CalamariFlavourProgramAsync
    {
        public Program(ILog log) : base(log)
        {
        }

        public static Task<int> Main(string[] args)
        {
            return new Program(ConsoleLog.Instance).Run(args);
        }

        protected override IEnumerable<Assembly> GetProgramAssembliesToRegister()
        {
            yield return typeof(AzureContextScriptWrapper).Assembly;
            yield return typeof(Program).Assembly;
        }
    }
}