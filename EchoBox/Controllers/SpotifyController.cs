using EchoBox.Models;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
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



        public async Task<ActionResult> DisplayRandomGenre() // name needs to be changed to RandomGenre
        {

            string Genre = await SpotifyHelper.GetGenre();

            if (Genre != null)
            {
                TempData["Genre"] = Genre;
            }
            else
            {
                TempData["Genre"] = "Whoops!";
            }

            return RedirectToAction("Spotify");
        }

        public async Task<ActionResult> DisplayArtists() // grab three artists from a genre.
        {
            SearchItem ArtistSearch = await SpotifyHelper.GrabArtists("Imagine");
            List<FullArtist> searchedArtists = ArtistSearch.Artists.Items; // this list acts like an array?
            TempData["ArtistList"] = searchedArtists[0].Name + " " + searchedArtists[1].Name + " " + searchedArtists[2].Name;

            return RedirectToAction("Spotify");
        }


        //GET for search artist by genre.
        [HttpPost]
        public async Task<ActionResult> SpotifyArtistSearch(string Keyword, string Genre)
        {
            string ArtistString = "";

            if (ModelState.IsValid)
            {
                SearchItem ArtistSearch = await SpotifyHelper.GrabArtists(Keyword);
                List<FullArtist> searchedArtists = ArtistSearch.Artists.Items; // this list acts like an array?
                int arraySize = searchedArtists.Count();
                string[] ArtistArray = new string[arraySize];


                for (int i = 0; i <= arraySize - 1; i++)
                {


                    if(Genre == "") //leave genre blank to grab 50 artists
                    {
                        ArtistArray[i] = searchedArtists[i].Name;

                    } else if (searchedArtists[i].Genres.Contains(Genre))

                    {
                        ArtistString += searchedArtists[i].Name + ", ";
                        ArtistArray[i] = searchedArtists[i].Name;
                    }
                }
                TempData["ArtistsByGenre"] = ArtistArray;
            }
            else
            {
                TempData["ArtistsByGenre"] = "Whoops something went wrong!";
            }


            return View();
        }

    }

}
