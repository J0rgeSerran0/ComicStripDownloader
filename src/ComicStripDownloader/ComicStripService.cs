using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ComicStripDownloader
{
    public class ComicStripService : IComicStripService
    {
        public async Task<ComicStripResponse> GetComicStripUrlAsync(DateTime dateTime, ComicStripType comicStripType)
        {
            var dilbertStripResponse = await GetHtmlSourceCodeAsync(new Uri(String.Format(comicStripType.Url, dateTime.ToString(comicStripType.Parameter))));

            if (!dilbertStripResponse.HasErrors)
            {
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(dilbertStripResponse.Source);

                return GetImageUri(htmlDocument, comicStripType);
            }

            return dilbertStripResponse;
        }

        public async Task<ComicStripResponse> GetLastComicStripUrlAsync(ComicStripType comicStripType)
        {
            var dateTime = DateTime.UtcNow;
            var comicStripResponse = await GetComicStripUrlAsync(dateTime, comicStripType);

            if (comicStripResponse.HasErrors)
                comicStripResponse = await GetComicStripUrlAsync(dateTime.AddDays(-1), comicStripType);

            return comicStripResponse;
        }

        private async Task<ComicStripResponse> GetHtmlSourceCodeAsync(Uri url)
        {
            if (url == null)
                return new ComicStripResponse(null, true, "Url invalid");

            var source = String.Empty;

            try
            {
                using (var httpClient = new HttpClient())
                    source = await httpClient.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                return new ComicStripResponse(null, true, ex.Message);
            }

            return new ComicStripResponse(source);
        }

        private ComicStripResponse GetImageUri(HtmlDocument htmlDocument, ComicStripType comicStripType)
        {
            HtmlNodeCollection imagesNodeCollection = htmlDocument.DocumentNode.SelectNodes(comicStripType.HtmlImageClass);

            if (imagesNodeCollection is null ||
                imagesNodeCollection.Count != 1)
                return new ComicStripResponse(String.Empty, true, "Resource not found");

            var imageLink = String.Empty;

            if (comicStripType.IsInChildNodes)
                imageLink = imagesNodeCollection[0].ChildNodes[0].GetAttributeValue("src", "");
            else
                imageLink = imagesNodeCollection[0].GetAttributeValue("src", "");

            return new ComicStripResponse($"{imageLink}.png");
        }
    }
}