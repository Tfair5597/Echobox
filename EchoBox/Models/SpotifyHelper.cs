using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EchoBox.Models
{
    public class SpotifyHelper
    {
        //all of spotify's genre seeds.
        string[] SpotifyGenreSeeds = new string[] { "acoustic", "afrobeat", "alt-rock","alternative","ambient","anime","black-metal","bluegrass","blues",
       "blues","bossanova","brazil","breakbeat","british","cantopop","chicago-house","children","chill","classical","comedy","country","dance","dancehall",
       "death-metal","deep-house","detroit-techno","disco","disney","drum-and-bass","dub","dubstep","edm","electro","electronic","emo","folk","forro","french",
       "funk","garage","german","gospel","goth","grindcore","groove","grunge","guitar","happy","hard-rock","hardcore","hardstyle","heavy-metal","hip-hop","holidays",
       "honky-tonk","house","idm","indian","indie","indie-pop","industrial","iranian","j-dance","j-idol","j-pop","j-rock","jazz","k-pop","kids","latin","latino","malay",
       "mandopop","metal","metal-music","metalcore","minimal-techno","movies","mpb","new-age","new-release","opera","pagode","part","phillipenes-opm","piano","pop",
       "pop-film","post-dubstep","power-pop","progressive-house","psycho-rock","punk","punk-rock","r-n-b","rainy-day","reggae","reggaeton","road-trip","rock",
       "rock-n-roll","rockabilly","romance","sad","salsa","samba","sertanejo","show-tunes","singer-songwriter","ska","sleep","songwriter","soul","soundtracks",
       "spanish","study","summer","swedish","synth-pop","tango","techno","trance","trip-hop","turkish","work-out","world-music"};

        public static async Task<string> GetGenre() //get first recommended genre
        {
            var genreGetter = new SpotifyWebAPI();
            string GenreToReturn = "";


            //implict grant auth 
            WebAPIFactory webAPIFactory = new WebAPIFactory(
               "http://localhost",
               8000,
               "e81fba25bb5742d0a872e6813c55eb49",
               Scope.UserReadPrivate,
               TimeSpan.FromSeconds(20));

            try
            {
                genreGetter = await webAPIFactory.GetWebApi();

            }
            catch (Exception ex)
            {

            }

            if (genreGetter == null)
            {
                throw new NullReferenceException("Something went wrong... Sorry! Make sure you are authorized correctly.");
            }

            Task<RecommendationSeedGenres> asyncronousGenre = genreGetter.GetRecommendationSeedsGenresAsync();
            genreGetter.UseAuth = true;
            string AccessTest = genreGetter.AccessToken;

            RecommendationSeedGenres ReccoGenres = asyncronousGenre.Result;

            string[] arrayOfGenres = new string[145];


            arrayOfGenres = ReccoGenres.Genres.ToArray();
            Random rand = new Random();
            GenreToReturn = arrayOfGenres[rand.Next(146)];

            return GenreToReturn;
        }


        public static async Task<SearchItem> GrabArtists(string Search) //search for first 50 artists by name
        {
            var artistGetter = new SpotifyWebAPI();



            //implict grant auth 
            WebAPIFactory webAPIFactory = new WebAPIFactory(
               "http://localhost",
               8000,
               "e81fba25bb5742d0a872e6813c55eb49",
               Scope.UserReadPrivate,
               TimeSpan.FromSeconds(20));

            try
            {
                artistGetter = await webAPIFactory.GetWebApi();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " this is what went wrong."); //display exception description.
            }

            if (Search != "" || Search != null)
            {
                SearchItem artistsToReturn = artistGetter.SearchItems(Search, SearchType.Artist, 50);


                return artistsToReturn;

            }
            else
            {
                throw new Exception("Error-B182S4139GA921P - User failed to input a genre");
            }
        }
    }
}
//the URI issue is found here: https://github.com/JohnnyCrazy/SpotifyAPI-NET/issues/254 
//to get started searching go here: https://johnnycrazy.github.io/SpotifyAPI-NET/SpotifyWebAPI/search/
//to extract one object takes a lot of peeling back layers as seen in testAlbum
//Try to do implicit grant auth in the method as opposed to make it's own method!