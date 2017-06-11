﻿using Newtonsoft.Json;

namespace WhatPillsBot.Model
{
    [System.Serializable]
    public class Color
    { 
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}