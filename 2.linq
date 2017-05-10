<Query Kind="Statements">
  <Connection>
    <ID>861f7a58-4a25-4496-b783-647660235e92</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new
			  {
				 TracksCount=g.Tracks.Count(),
				 Tracks = from t in g.Tracks
				          select new
				{
				    TrackName = t.Name,
					AlumName = t.Album.Title,
					Milliseconds = t.Milliseconds,
					Size = (t.Bytes/1000) + " kb",
					Price = t.UnitPrice
				}
			  };
results.Dump("More math");