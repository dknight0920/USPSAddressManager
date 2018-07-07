using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USPSAddressManagerCore.Models;
using USPSAddressManagerCore.Repos;

namespace USPSAddressManagerData.Repos
{
    public class PlaceRepo : Repo<Place>
    {
        public void Add(Place item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Place item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Place> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Place> Get(string query)
        {
            throw new NotImplementedException();
        }

        public Place Get(int id)
        {
            Place place = null;

            string sql = "select * from places where id = @id";

            using (var connection = new SqlConnection(@"Server=xxx;Database=xxx;Uid=xxx;Pwd=xxx;"))
            {
                connection.Open();

                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandTimeout = 0;
                    command.Parameters.AddWithValue("@id", id);

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        place =
                            new Place
                            (
                                id:
                                    reader.GetFieldValue<int>(0),
                                name:
                                    reader.GetFieldValue<string>(1),
                                date:
                                    reader.GetFieldValue<DateTime?>(2)
                            );
                    }
                }
            }

            if (place == null)
            {
                throw new ApplicationException
                (
                    "A Place with Id: " + id + " does not exist."
                );
            }

            return place;
        }

        public void Update(Place item)
        {
            throw new NotImplementedException();
        }
    }
}
