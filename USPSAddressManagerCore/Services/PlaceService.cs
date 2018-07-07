using System;
using USPSAddressManagerCore.Models;
using USPSAddressManagerCore.Repos;

namespace USPSAddressManagerCore.Services
{
    public class PlaceService
    {
        private Repo<Place> repo;

        public PlaceService(Repo<Place> repo)
        {
            this.repo = repo;
        }

        public void With
        (
            int id, 
            Action<Place> handlePlace,
            Action<int, Exception> handleNoPlace = null
        )
        {
            try
            {
                var place = repo.Get(id);
                handlePlace(place);
            }
            catch (Exception e)
            {
                if (handleNoPlace == null)
                    throw e;

                handleNoPlace(id, e);
            }
        }
    }
}
