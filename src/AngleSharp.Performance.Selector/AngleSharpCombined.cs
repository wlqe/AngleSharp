﻿namespace AngleSharp.Performance.Selector
{
    using AngleSharp.Html.Parser;
    using System;

    class AngleSharpParser : ITestee
    {
        private static readonly HtmlParser parser = new HtmlParser();

        public String Name => "AngleSharp";

        public Type Library => typeof(HtmlParser);

        public void Run(String source)
        {
            var document = parser.ParseDocument(source);
            // Even using two kinds of selectors -- measure perf.
            document.QuerySelectorAll("a[href]");
            document.QuerySelectorAll("div > p > a");
        }
    }
}
