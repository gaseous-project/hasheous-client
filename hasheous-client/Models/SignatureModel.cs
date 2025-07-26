using System;
using Newtonsoft.Json;

namespace HasheousClient.Models
{
    public class SignatureModel
    {
        public SignatureModel()
        {
        }

        public GameItem? Game { get; set; }
        public RomItem? Rom { get; set; }

        public class GameItem
        {
            public long? Id { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            public string? Year { get; set; }
            public string? Publisher { get; set; }
            public DemoTypes Demo { get; set; }
            public string? System { get; set; }
            public long? SystemId { get; set; }
            public string? SystemVariant { get; set; }
            public string? Video { get; set; }
            public Dictionary<string, string>? Countries { get; set; }
            public Dictionary<string, string>? Languages { get; set; }
            public string? Copyright { get; set; }

            public enum DemoTypes
            {
                NotDemo = 0,
                demo = 1,
                demo_kiosk = 2,
                demo_playable = 3,
                demo_rolling = 4,
                demo_slideshow = 5
            }
        }

        public class RomItem
        {
            public long? Id { get; set; }
            public string? Name { get; set; }
            public long? Size { get; set; }
            public string? Crc { get; set; }
            public string? Md5 { get; set; }
            public string? Sha1 { get; set; }
            public string? Sha256 { get; set; }

            public string? DevelopmentStatus { get; set; }

            public Dictionary<string, object>? Attributes { get; set; }

            public RomTypes RomType { get; set; }
            public string? RomTypeMedia { get; set; }
            public MediaType? MediaDetail { get; set; }
            public string? MediaLabel { get; set; }

            public SignatureSourceType SignatureSource { get; set; }

            public enum RomTypes
            {
                Unknown,
                Disc,
                Disk,
                File,
                Part,
                Tape,
                Side
            }

            public enum SignatureSourceType
            {
                None = 0,
                TOSEC = 1,
                MAMEArcade = 2,
                MAMEMess = 3,
                NoIntros = 4,
                Redump = 5,
                WHDLoad = 6,
                RetroAchievements = 7,
                FBNeo = 8,
                PureDOSDAT = 9,
                Pleasuredome = 10,
                Generic = 99
            }

            public class MediaType
            {
                public MediaType(SignatureSourceType Source, string MediaTypeString)
                {
                    switch (Source)
                    {
                        case SignatureSourceType.TOSEC:
                        case SignatureSourceType.NoIntros:
                        case SignatureSourceType.Redump:
                            string[] typeString = MediaTypeString.Split(" ");

                            string inType = "";
                            foreach (string typeStringVal in typeString)
                            {
                                if (inType == "")
                                {
                                    switch (typeStringVal.ToLower())
                                    {
                                        case "disk":
                                            Media = RomTypes.Disk;

                                            inType = typeStringVal;
                                            break;
                                        case "disc":
                                            Media = RomTypes.Disc;

                                            inType = typeStringVal;
                                            break;
                                        case "file":
                                            Media = RomTypes.File;

                                            inType = typeStringVal;
                                            break;
                                        case "part":
                                            Media = RomTypes.Part;

                                            inType = typeStringVal;
                                            break;
                                        case "tape":
                                            Media = RomTypes.Tape;

                                            inType = typeStringVal;
                                            break;
                                        case "of":
                                            inType = typeStringVal;
                                            break;
                                        case "side":
                                            inType = typeStringVal;
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (inType.ToLower())
                                    {
                                        case "disk":
                                        case "disc":
                                        case "file":
                                        case "part":
                                        case "tape":
                                            Number = int.Parse(typeStringVal);
                                            break;
                                        case "of":
                                            Count = int.Parse(typeStringVal);
                                            break;
                                        case "side":
                                            Side = typeStringVal;
                                            break;
                                    }
                                    inType = "";
                                }
                            }

                            break;

                        default:
                            break;

                    }
                }

                public RomTypes? Media { get; set; }

                public int? Number { get; set; }

                public int? Count { get; set; }

                public string? Side { get; set; }
            }
        }
    }
}