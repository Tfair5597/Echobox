using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public static async void SpotAuth() //authorization for spotify
        {
            var _spotify = new SpotifyWebAPI();

            WebAPIFactory webAPIFactory = new WebAPIFactory(
                "http://localhost",
                8000,
                "e81fba25bb5742d0a872e6813c55eb49",
                Scope.UserReadPrivate,
                TimeSpan.FromSeconds(20));

            try
            {
                _spotify = await webAPIFactory.GetWebApi();
            }
            catch (Exception ex)
            {
                
            }

            if (_spotify == null)
            {
                return;
            }
        }


    }
}