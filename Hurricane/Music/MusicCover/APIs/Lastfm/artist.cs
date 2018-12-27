﻿using System.Xml.Serialization;
// ReSharper disable InconsistentNaming

namespace Hurricane.Music.MusicCover.APIs.Lastfm
{
    /// <remarks/>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class lfm
    {
        /// <remarks/>
        public lfmArtist artist { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtist
    {
        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public string url { get; set; }

        /// <remarks/>
        [XmlElement("image")]
        public lfmArtistImage[] image { get; set; }

        /// <remarks/>
        public byte streamable { get; set; }

        /// <remarks/>
        public byte ontour { get; set; }

        /// <remarks/>
        public object similar { get; set; }

        /// <remarks/>
        [XmlArrayItem("tag", IsNullable = false)]
        public lfmArtistTag[] tags { get; set; }

        /// <remarks/>
        public lfmArtistBio bio { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtistImage
    {
        /// <remarks/>
        [XmlAttribute()]
        public string size { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtistStats
    {
        /// <remarks/>
        public long listeners { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtistTag
    {
        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public string url { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtistBio
    {
        /// <remarks/>
        public lfmArtistBioLinks links { get; set; }

        /// <remarks/>
        public string published { get; set; }

        /// <remarks/>
        public string summary { get; set; }

        /// <remarks/>
        public string content { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtistBioLinks
    {
        /// <remarks/>
        public lfmArtistBioLinksLink link { get; set; }
    }

    /// <remarks/>
    [XmlType(AnonymousType = true)]
    public class lfmArtistBioLinksLink
    {
        /// <remarks/>
        [XmlAttribute()]
        public string rel { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string href { get; set; }
    }


}
