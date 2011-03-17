using System;
using AutoPoco.Engine;

namespace Datasources
{
    public class UrlSource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);

        public override string Next(IGenerationContext context)
        {
            return string.Format("http://www.{0}", Urls[_random.Next(0, Urls.Length)]);
        }

        private static readonly string[] Urls = new[]{
            "google.com",
            "facebook.com",
            "youtube.com",
            "yahoo.com",
            "live.com",
            "blogspot.com",
            "baidu.com",
            "wikipedia.org",
            "twitter.com",
            "qq.com",
            "webpirates.nl",
            "msn.com",
            "amazon.com",
            "linkedin.com.",
            "bing.com",
            "wordpress.com",
            "microsoft.com",
            "ebay.com",
            "paypal.com",
            "fc2.com",
            "flickr.com",
            "craigslist.org",
            "imdb.com",
            "bbc.co.uk",
            "vkontakte.ru",
            "schu.com",
            "apple.com",
            "livejasmin.com",
            "youku.com",
            "go.com",
            "tudou.com",
            "ask.com",
            "soso.com",
            "hotfile.com",
            "cnn.com",
            "aol.com",
            "megaupload.com",
            "tumblr.com",
            "mediafire.com",
            "godaddy.com",
            "zedo.com",
            "adobe.com",
            "about.com",
            "conduit.com",
            "myspace.com",
            "livejournal.com",
            "4shared.com",
            "espn.go.com",
            "yieldmanager.com",
            "doubleclick.com",

        };
    }
}