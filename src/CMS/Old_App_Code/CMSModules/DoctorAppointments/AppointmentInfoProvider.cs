﻿using CMS.DataEngine;

namespace DoctorAppointments
{
    /// <summary>
    /// Class providing <see cref="AppointmentInfo"/> management.
    /// </summary>
    [ProviderInterface(typeof(IAppointmentInfoProvider))]
    public partial class AppointmentInfoProvider : AbstractInfoProvider<AppointmentInfo, AppointmentInfoProvider>, IAppointmentInfoProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentInfoProvider"/> class.
        /// </summary>
        public AppointmentInfoProvider()
            : base(AppointmentInfo.TYPEINFO)
        {
        }
    }
}
