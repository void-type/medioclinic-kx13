using CMS.Core;
using Microsoft.Extensions.Logging;

namespace XperienceAdapter.Logging
{
    public class XperienceLogger : ILogger
    {
        private readonly string _name;
        private readonly IEventLogService _eventLogService;

        public XperienceLogger(string name, IEventLogService eventLogService)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _eventLogService = eventLogService ?? throw new ArgumentNullException(nameof(eventLogService));
        }
    }
}