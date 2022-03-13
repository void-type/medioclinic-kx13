﻿using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedioClinic.Components.Widgets
{
    public class TextProperties : IWidgetProperties
    {
        /// <summary>
        /// Textual content of the widget.
        /// </summary>
        public string? Text { get; set; }
    }
}
