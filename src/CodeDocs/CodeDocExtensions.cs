﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodeDocs
{
    public static class CodeDocExtensions
    {
        public static long? ParseNullable(this long value)
            => value == long.MinValue ? (long?)null : value;

        public const int MinIsoDate = 2010_01_01;

        public static DateTime? ParseNullableIsoDate(this int value)
        {

            var max = int.Parse(DateTime.UtcNow.AddDays(1).ToString("yyyyMMdd"));

            if (value < MinIsoDate || value > max) return DateTime.MinValue.Date;

            try
            {
                return value == int.MinValue ? (DateTime?)null : DateTime.ParseExact(value.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            catch { return DateTime.MinValue.Date; }

        }

        public static readonly char[] TagDelimiters = { ',' };

        public static IEnumerable<string> ParseTags(this string value)
            => value.Trim()
                .Split(TagDelimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim().ToLowerInvariant());

    }
}
