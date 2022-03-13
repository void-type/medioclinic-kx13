using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedioClinic.Models
{
    public class PageTemplateProperties : IPageTemplateProperties
    {
        [JsonIgnore]
        public UserMessage? UserMessage { get; set; }
    }
}
