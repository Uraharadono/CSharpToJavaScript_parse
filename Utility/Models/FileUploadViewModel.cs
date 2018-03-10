﻿using System.Collections.Generic;
using Utility.Enums;

namespace Utility.Models
{
    /* ============================= CLASS USED ONLY WHEN EXTRACTIN DATA FROM FILE ========================== */
    public class FileLinesOverviewModel
    {
        public string ClassName { get; set; }
        public string OriginalPropertyLine { get; set; }
        public string PropertyName { get; set; }
        public LineType LineType { get; set; }
    }

    public class LineType
    {
        public PropertyType PropertyType { get; set; }
        public bool IsArray { get; set; }
        public string PropertyTypeName { get; set; }
    }

    public enum PropertyType
    {
        PrimitiveType = 0,
        ClassType = 1,
        // ArrayType = 2,
        // Object = 2,
        Undefined = 2
    }

    /* ============================= CLASS USED WHEN GENERATING JS FILE ===================================== */

    public class JSBuilderModel
    {
        public List<FileClassModel> FileClasses { get; set; }
    }

    public class FileClassModel
    {
        public string ClassName { get; set; }
        public List<FilePropertyModel> FileProperties { get; set; }
    }

    public class FilePropertyModel
    {
        public string PropertyName { get; set; }
        public PropertyType PropertyType { get; set; }
        public bool IsArray { get; set; }
        public string PropertyTypeName { get; set; }
    }

    /* ============================= OPTIONS MODEL ===================================== */

    public class ClassGeneratorOptions
    {
        public bool IncludeHeaders { get; set; }
        public bool IncludeUnmapFunctions { get; set; }
        public bool IncludeIsLoadingVar { get; set; }
        public EGenerateOptions ConversionType { get; set; }
    }
}
