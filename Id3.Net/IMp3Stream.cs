using Id3.Id3;
using System;
namespace Id3
{
    public interface IMp3Stream
    {
        AudioStreamProperties Audio { get; }
        System.Collections.Generic.IEnumerable<Version> AvailableTagVersions { get; }
        void DeleteAllTags();
        void DeleteTag(Id3TagFamily family);
        void DeleteTag(int majorVersion, int minorVersion);
        void Dispose();
        System.Collections.Generic.IEnumerable<Id3Tag> GetAllTags();
        byte[] GetAudioStream();
        Id3Tag GetTag(Id3TagFamily family);
        IId3Tag GetTag(int majorVersion, int minorVersion);
        byte[] GetTagBytes(int majorVersion, int minorVersion);
        bool HasTagOfFamily(Id3TagFamily family);
        bool HasTagOfVersion(int majorVersion, int minorVersion);
        bool HasTags { get; }
        bool WriteTag(Id3Tag tag, WriteConflictAction conflictAction = WriteConflictAction.NoAction);
        bool WriteTag(Id3Tag tag, int majorVersion, int minorVersion, WriteConflictAction conflictAction = WriteConflictAction.NoAction);
    }
}
