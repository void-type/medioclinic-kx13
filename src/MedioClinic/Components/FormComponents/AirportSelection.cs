using Business.Repositories;
using Kentico.Forms.Web.Mvc;
using Kentico.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedioClinic.Components.FormComponents
{
    public class AirportSelection : DropDownComponent
    {
        private readonly IAirportRepository _airportRepository;

        public AirportSelection(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository ?? throw new ArgumentNullException(nameof(airportRepository));
        }

        protected override IEnumerable<HtmlOptionItem> GetHtmlOptions() =>
            _airportRepository
                .GetAll()
                .Select(dto => new HtmlOptionItem
                {
                    Text = dto.AirportName,
                    Value = dto.AirportIataCode
                });
    }
}
