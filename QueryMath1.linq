<Query Kind="Statements">
  <Connection>
    <ID>861f7a58-4a25-4496-b783-647660235e92</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			     Genre = g.Name,
				 TracksCount=g.Tracks.Count()
			  };
results.Dump("Query Math");