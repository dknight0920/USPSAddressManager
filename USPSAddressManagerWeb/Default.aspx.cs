using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using USPSAddressManagerCore.Models;
using USPSAddressManagerCore.Services;
using USPSAddressManagerData.Repos;

namespace USPSAddressManagerWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            new PlaceService
            (
                new PlaceRepo()
            )
            .With
            (
                id: 2,
                handlePlace:
                    place =>
                    {
                        labelPlace.Text = place.Name + " " + place.Date.ToString();
                    },
                handleNoPlace:
                    (id, err) =>
                    {
                        labelPlace.Text = err.Message;
                    }
            );
        }
    }
}