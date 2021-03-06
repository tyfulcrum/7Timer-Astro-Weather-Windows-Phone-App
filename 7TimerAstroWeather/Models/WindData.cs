﻿using Newtonsoft.Json;
namespace SevenTimerAstroWeather.Models
{
    public class WindData
    {
        [JsonProperty(PropertyName = "direction")]
        public WindDirection Direction { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public int Speed { get; set; }

    #region DisplayProperties

        public int DirectionDegrees
        {
            get
            {
                switch (Direction)
                {
                    case WindDirection.N: return 180;
                    case WindDirection.NE: return 225;
                    case WindDirection.E: return 270;
                    case WindDirection.SE: return 315;
                    case WindDirection.S: return 0;
                    case WindDirection.SW: return 45;
                    case WindDirection.W: return 90;
                    case WindDirection.NW: return 135;
                    default: return 0;
                }
            }
        }

        public int SpeedArrowSize
        {
            get
            {
                return 15 + (Speed * 5);
            }
        }

        public string SpeedColor
        {
            get
            {
                string[] colors = { "#FFFFFFFF", "#FFFFFFFF", "#FFFFFFFF", "#FFE6DC33", "#FFF08229", "#FFF00000", "#FFF00000", "#FFF00000" };
                if (Speed <= colors.Length && Speed >= 0)
                {
                    return colors[Speed - 1];
                }
                else
                {
                    return "#FFFFFFFF";
                }
            }
        }

    #endregion

    }
}
