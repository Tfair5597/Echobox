using EchoBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EchoBox.Controllers
{
    public class SpotifyController : Controller
    {
        // GET: Spotify
        public ActionResult Spotify()
        {
            return View();
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<ActionResult> AuthorizeSpotify()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            SpotifyHelper.SpotAuth(); // send implicit grant authorization to Spotify.
            return RedirectToAction("Spotify");
        }
    }
}