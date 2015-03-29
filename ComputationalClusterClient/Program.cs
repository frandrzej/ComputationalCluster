﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalClusterClient {
    class Program {

        static void Main(string[] args) 
        {
            // get config file from runtime args
            // or if none provided, request config
            // via console
            // Test comment from Abramus
            setConfigFileAtRuntime(args);
        }

        protected static void setConfigFileAtRuntime(string[] args) {

            string runtimeconfigfile;

            if (args.Length == 0) {
                Console.WriteLine("Please specify a config file:");
                Console.Write("> "); // prompt
                runtimeconfigfile = Console.ReadLine();
            } else {
                runtimeconfigfile = args[0];
            }

            
        }


    }



}
