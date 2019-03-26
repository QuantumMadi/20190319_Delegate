namespace StarWars.Services.Abstract
{
    public interface IDownloader<T>
    {
        T DownloadRawJsonData(string url, int id);
    }
}
