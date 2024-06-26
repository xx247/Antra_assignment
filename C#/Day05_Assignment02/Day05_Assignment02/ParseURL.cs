using System;

namespace Day05_Assignment02;

public static class ParseAnURL
{
    public static void ParseURL()
    {
        string[] urls = {
            "https://www.apple.com/iphone",
            "ftp://www.example.com/employee",
            "https://google.com",
            "www.apple.com",
            
        };

        foreach (var url in urls)
        {
            ParseUrl(url);
            Console.WriteLine();
        }
    }
    static void ParseUrl(string url)
    {
        string protocol = null;
        string server = null;
        string resource = null;

        // Check for protocol
        int protocolEndIndex = url.IndexOf("://");
        if (protocolEndIndex != -1)
        {
            protocol = url.Substring(0, protocolEndIndex);
            url = url.Substring(protocolEndIndex + 3); // Remove protocol from URL
        }

        // Check for server and resource
        int resourceStartIndex = url.IndexOf('/');
        if (resourceStartIndex != -1)
        {
            server = url.Substring(0, resourceStartIndex);
            resource = url.Substring(resourceStartIndex + 1); // Remove leading '/'
        }
        else
        {
            server = url;
        }

        // Print the results
        Console.WriteLine("URL: " + url);
        Console.WriteLine("Protocol: " + (protocol ?? "(none)"));
        Console.WriteLine("Server: " + server);
        Console.WriteLine("Resource: " + (resource ?? "(none)"));
    }
}
