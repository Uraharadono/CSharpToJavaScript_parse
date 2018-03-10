﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Utility
{
    public class JsGeneratorOptions
    {
        public bool CamelCase { get; set; } = false;
        public string OutputNamespace { get; set; } = "models";
        public bool IncludeMergeFunction { get; set; } = true;
        public bool IncludeEqualsFunction { get; set; } = false;
        public List<string> ClassNameConstantsToRemove { get; set; } = new List<string>();
        public bool RespectDataMemberAttribute { get; set; } = true;
        public bool RespectDefaultValueAttribute { get; set; } = true;
        public List<Action<StringBuilder, IEnumerable<PropertyBag>, JsGeneratorOptions>> CustomFunctionProcessors { get; set; }
        public bool TreatEnumsAsStrings { get; set; }
        public EGenerateOptions ConversionType { get; set; }
    }

    public enum EGenerateOptions
    {
        [Description("Javascript")]
        Javascript = 0,
        [Description("Ecma6 Javascript")]
        Ecma6 = 1,
        [Description("Ecma6 with Knockout")]
        KnockoutEcma6 = 2
    }
}
