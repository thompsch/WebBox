using System;
using System.Collections.Generic;

namespace WebBox
{
    public class Links
    {
        // Some links (for auth) need to be run internally, not in a new window
        // but we want all other links to open externally.
        public static IEnumerable<String> InternalLinks = new List<string>()
        {
            "10gen.com/acs",
            "accounts.google",
            "calendar.google",
            "okta",
            "corp.mongodb"
        };
    }
}

