﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

//Database Context.
namespace EchoBox.Models
{
    public class EchoDb : DbContext
    {

        string[] SpotifyGenreSeeds = new string[] { "acoustic", "afrobeat", "alt-rock","alternative","ambient","anime","black-metal","bluegrass","blues",
       "blues","bossanova","brazil","breakbeat","british","cantopop","chicago-house","children","chill","classical","comedy","country","dance","dancehall",
       "death-metal","deep-house","detroit-techno","disco","disney","drum-and-bass","dub","dubstep","edm","electro","electronic","emo","folk","forro","french",
       "funk","garage","german","gospel","goth","grindcore","groove","grunge","guitar","happy","hard-rock","hardcore","hardstyle","heavy-metal","hip-hop","holidays",
       "honky-tonk","house","idm","indian","indie","indie-pop","industrial","iranian","j-dance","j-idol","j-pop","j-rock","jazz","k-pop","kids","latin","latino","malay",
       "mandopop","metal","metal-music","metalcore","minimal-techno","movies","mpb","new-age","new-release","opera","pagode","part","phillipenes-opm","piano","pop",
       "pop-film","post-dubstep","power-pop","progressive-house","psycho-rock","punk","punk-rock","r-n-b","rainy-day","reggae","reggaeton","road-trip","rock",
       "rock-n-roll","rockabilly","romance","sad","salsa","samba","sertanejo","show-tunes","singer-songwriter","ska","sleep","songwriter","soul","soundtracks",
       "spanish","study","summer","swedish","synth-pop","tango","techno","trance","trip-hop","turkish","work-out","world-music"};

        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}