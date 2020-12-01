using System;
using System.Threading.Tasks;

namespace ComicStripDownloader
{
    public interface IComicStripService
    {
        Task<ComicStripResponse> GetComicStripUrlAsync(DateTime dateTime, ComicStripType comicStripType);
        Task<ComicStripResponse> GetLastComicStripUrlAsync(ComicStripType comicStripType);
    }
}