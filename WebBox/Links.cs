using System;
using System.Collections.Generic;

namespace WebBox
{
    public class Links
    {
        // Some links (for auth) need to be run internally, not in a new window
        // but we want all other links to open externally.
        public static IEnumerable<String> ExternalLinks = new List<string>()
        {
            "accounts.google",
            "calendar.google",
            "okta",
            "corp.mongodb"
        };
    }
}

