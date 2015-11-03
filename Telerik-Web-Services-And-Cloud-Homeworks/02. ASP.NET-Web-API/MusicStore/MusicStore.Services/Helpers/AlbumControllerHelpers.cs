namespace MusicStore.Services.Helpers
{
    using Data.Repositories;
    using MusicStore.Models;

    public class AlbumControllerHelpers
    {
        public static Album AddSongsToAlbum(int[] songIds, Album album, IMusicStoreData data)
        {
            album.Songs.Clear();

            foreach (var songId in songIds)
            {
                var songToAdd = data.Songs.Find(songId);

                if (songToAdd == null)
                {
                    return null;
                }

                album.Songs.Add(songToAdd);
            }

            return album;
        }

        public static Album AddArtistsToAlbum(int[] artistIds, Album album, IMusicStoreData data)
        {
            album.Artists.Clear();

            foreach (var artistId in artistIds)
            {
                var artistToAdd = data.Artists.Find(artistId);

                if (artistToAdd == null)
                {
                    return null;
                }

                album.Artists.Add(artistToAdd);
            }

            return album;
        }
    }
}