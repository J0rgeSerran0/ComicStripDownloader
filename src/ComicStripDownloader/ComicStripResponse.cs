namespace ComicStripDownloader
{
    public record ComicStripResponse(string Source, bool HasErrors = false, string ErrorDescription = "");
}