﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace DocxMerge
{
    class Options
    {
        [Option('i', "input", Required = true, HelpText = "A list of docx files to merge in order")]
        public IEnumerable<string> InputFiles { get; set; }

        [Option('o', "output", Required = false, HelpText = "Output file [Default: output.docx]")]
        public string Output { get; set; }

        [Option('v', "Verbose", Required = false, HelpText = "Show more information when executing")]
        public bool Verbose { get; set; }
    }
}
