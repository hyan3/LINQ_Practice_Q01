<Query Kind="Statements">
  <Connection>
    <ID>861f7a58-4a25-4496-b783-647660235e92</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
			  {
			     Name =m.Name,
				 Tracks = from t in m.Tracks
				          select new
				{
				    TrackName = t.Name,
					Album =t.Album.Title,
					Artist = t.Album.Artist.Name,
					ReleaseYear = t.Album.ReleaseYear,
					ReleaseLabel =t.Album.ReleaseLabel,
					Genre = t.Genre.Name
				}
			};
results.Dump();