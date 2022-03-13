using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using MedioClinic.Components;
using MedioClinic.Components.FormComponents;
using MedioClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedioClinic.PageTemplates
{
    public class EventTemplateProperties : PageTemplateProperties
    {
        [EditingComponent(ComponentIdentifiers.AirportSelectionFormComponent,
            Label = "{$" + ComponentIdentifiers.AirportSelectionFormComponent + ".LocationAirport$}",
            Order = 0)]
        public string? EventLocationAirport { get; set; }
    }
}
