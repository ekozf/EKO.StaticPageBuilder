﻿using EKO_ContentParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKO.StaticPageBuilder
{
    internal sealed class Page
    {
        public string Content { get; set; } = string.Empty;
        public string Template { get; set; } = string.Empty;
        public MarkdownMetaData MetaData { get; set; }
        public List<PageVar> PageVars { get; set; } = new();
        public string GeneratedHTML { get; set; } = string.Empty;
        public string SavePath { get; set; } = string.Empty;
    }
}