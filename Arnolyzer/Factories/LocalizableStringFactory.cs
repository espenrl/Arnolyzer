﻿using Microsoft.CodeAnalysis;

namespace Arnolyzer.Factories
{
    internal static class LocalizableStringFactory
    {
        public static LocalizableString LocalizableResourceString(string resource) =>
            new LocalizableResourceString(resource, Resources.ResourceManager, typeof(Resources));
    }
}
