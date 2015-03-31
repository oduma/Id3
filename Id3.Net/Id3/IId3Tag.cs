using System;
namespace Id3.Id3
{
    public interface IId3Tag
    {
        object AdditionalData { get; }
        global::Id3.Frames.AlbumFrame Album { get; }
        global::Id3.Frames.ArtistsFrame Artists { get; }
        global::Id3.Frames.ArtistUrlFrameList ArtistUrls { get; }
        global::Id3.Frames.AudioFileUrlFrame AudioFileUrl { get; }
        global::Id3.Frames.AudioSourceUrlFrame AudioSourceUrl { get; }
        global::Id3.Frames.BandFrame Band { get; }
        global::Id3.Frames.BeatsPerMinuteFrame BeatsPerMinute { get; }
        void Cleanup();
        int Clear();
        global::Id3.Frames.CommentFrameList Comments { get; }
        global::Id3.Frames.CommercialUrlFrameList CommercialUrls { get; }
        int CompareTo(global::Id3.Id3Tag other);
        global::Id3.Frames.ComposersFrame Composers { get; }
        global::Id3.Frames.ConductorFrame Conductor { get; }
        bool Contains<TFrame>(global::System.Linq.Expressions.Expression<Func<global::Id3.Id3Tag, TFrame>> frameProperty) where TFrame : global::Id3.Frames.Id3Frame;
        global::Id3.Frames.ContentGroupDescriptionFrame ContentGroupDescription { get; }
        global::Id3.Id3Tag ConvertTo(int majorVersion, int minorVersion);
        global::Id3.Frames.CopyrightFrame Copyright { get; }
        global::Id3.Frames.CopyrightUrlFrame CopyrightUrl { get; }
        global::Id3.Frames.Id3SyncFrameList<global::Id3.Frames.CustomTextFrame> CustomTexts { get; }
        global::Id3.Frames.EncoderFrame Encoder { get; }
        global::Id3.Frames.EncodingSettingsFrame EncodingSettings { get; }
        bool Equals(global::Id3.Id3Tag other);
        global::Id3.Id3TagFamily Family { get; }
        global::Id3.Frames.FileOwnerFrame FileOwner { get; }
        global::Id3.Frames.FileTypeFrame FileType { get; }
        global::Id3.Frames.GenreFrame Genre { get; }
        bool IsSupported { get; }
        global::Id3.Frames.LengthFrame Length { get; }
        global::Id3.Frames.LyricistsFrame Lyricists { get; }
        global::Id3.Frames.Id3SyncFrameList<global::Id3.Frames.LyricsFrame> Lyrics { get; }
        int MajorVersion { get; }
        void MergeWith(params global::Id3.Id3Tag[] tags);
        int MinorVersion { get; }
        global::Id3.Frames.PaymentUrlFrame PaymentUrl { get; }
        global::Id3.Frames.Id3SyncFrameList<global::Id3.Frames.PictureFrame> Pictures { get; }
        global::Id3.Frames.PrivateFrameList PrivateData { get; }
        global::Id3.Frames.PublisherFrame Publisher { get; }
        global::Id3.Frames.RecordingDateFrame RecordingDate { get; }
        bool Remove<TFrame>() where TFrame : global::Id3.Frames.Id3Frame;
        int RemoveAll<TFrame>(Func<TFrame, bool> predicate = null) where TFrame : global::Id3.Frames.Id3Frame;
        global::Id3.Frames.SubtitleFrame Subtitle { get; }
        global::Id3.Frames.TitleFrame Title { get; }
        global::Id3.Frames.TrackFrame Track { get; }
        global::Id3.Frames.YearFrame Year { get; }
    }
}
