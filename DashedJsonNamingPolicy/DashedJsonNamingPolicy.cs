// <copyright file="DashedJsonNamingPolicy.cs" company="Balazs Keresztury">
// Copyright (c) Balazs Keresztury. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Text.Json;

namespace DashedJsonNamingPolicy
{
    /// <summary>
    /// Implements a JSON naming policy where a property named IsEnabled becomes is-enabled.
    /// </summary>
    public class DashedJsonNamingPolicy : JsonNamingPolicy
    {
        /// <inheritdoc />
        public override string ConvertName(string name)
        {
            // use built-in converter to normalize to camelCase first
            string camel = JsonNamingPolicy.CamelCase.ConvertName(name);
            string result = string.Empty;
            for (int i = 0; i < camel.Length; i++)
            {
                // loop through each character
                if (char.IsUpper(camel[i]))
                {
                    // if it's uppercase, add a dash in front of it
                    result += "-";

                    // make it lowercase
                    result += char.ToLower(camel[i]);
                }
                else
                {
                    // otherwise just add the character as-is
                    result += camel[i];
                }
            }

            return result;
        }
    }
}
