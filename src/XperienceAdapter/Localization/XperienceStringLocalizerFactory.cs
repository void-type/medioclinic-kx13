﻿using Microsoft.Extensions.Localization;
using System;

namespace XperienceAdapter.Localization
{
    public class XperienceStringLocalizerFactory : IStringLocalizerFactory
    {
        public IStringLocalizer Create(Type resourceSource) =>
            new XperienceStringLocalizer();

        public IStringLocalizer Create(string baseName, string location) =>
            new XperienceStringLocalizer();
    }
}
