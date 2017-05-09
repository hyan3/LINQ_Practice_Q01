<Query Kind="Statements">
  <Connection>
    <ID>bfca81ff-9223-43c7-807d-f85560b7f6dc</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
              where x.ArtistId==1
			  orderby x.Name
			  select new
			  {
			      Artist = x.Name,
				  Albums = from t in x.Albums
				  orderby t.Title
				  select new
				  {  
				      Title = t.Title,
					  Tracks=from tr in t.Tracks
					         select new
				      {
					      TrackName = tr.Name,
						  GenreId = tr.GenreId,
						  Composer = tr.Composer,
						  Milliseconds = tr.Milliseconds
					}
				}
			};
results.Dump();