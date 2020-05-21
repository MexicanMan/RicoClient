﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicoClient.Scripts.Decks
{
    [JsonObject]
    public class Deck
    {
        [JsonProperty("deck_header")]
        [JsonRequired]
        public DeckHeader Header { get; set; }

        [JsonProperty("deck_cards")]
        [JsonRequired]
        public Dictionary<int, int> DeckCards { get; set; }
    }
}
