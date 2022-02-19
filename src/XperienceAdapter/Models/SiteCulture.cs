﻿using System;

namespace XperienceAdapter.Models
{
    public class SiteCulture : IEquatable<SiteCulture?>
    {
        public static bool operator ==(SiteCulture? a, SiteCulture? b)
        {
            if (a is null)
            {
                return b is null;
            }

            return a.Equals(b);
        }

        public static bool operator !=(SiteCulture? a, SiteCulture? b)
        {
            if (a is null)
            {
                return b is object;
            }

            return !a.Equals(b);
        }

        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public string? IsoCode { get; set; }

        public bool IsDefault { get; set; }

        public override bool Equals(object? obj) => obj is SiteCulture culture && culture.IsoCode?.Equals(IsoCode, StringComparison.InvariantCulture) == true;

        public override int GetHashCode() => HashCode.Combine(Name, ShortName, IsoCode, IsDefault);

        public bool Equals(SiteCulture? other) => other?.IsoCode?.Equals(IsoCode, StringComparison.InvariantCulture) == true;
    }
}
