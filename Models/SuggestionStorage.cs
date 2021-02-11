﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public static class SuggestionStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestions => suggestions;

        public static void AddSuggestion(Suggestion s)
        {
            suggestions.Add(s);
        }
    }
}
