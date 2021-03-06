﻿/*Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and 
 * extracts from it the [protocol], [server] and [resource] elements.
Example:
                      URL	                              Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
                                                        [server] = telerikacademy.com 
                                                        [resource] = /Courses/Courses/Details/212        */

using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main(string[] args)
    {
        const string URL = @"http://telerikacademy.com/Courses/Courses/Details/212";
        Console.WriteLine("URL Address: {0}", URL);
        var fragments = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;
        
        Console.WriteLine("\n[protocol] = {0}", fragments[1]);
        Console.WriteLine("[server] = {0}", fragments[2]);
        Console.WriteLine("[resource] = {0}\n", fragments[3]);
    }
}

