// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: conversations_cache.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Uplay.ConversationsCache {

  /// <summary>Holder for reflection information generated from conversations_cache.proto</summary>
  public static partial class ConversationsCacheReflection {

    #region Descriptor
    /// <summary>File descriptor for conversations_cache.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversationsCacheReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chljb252ZXJzYXRpb25zX2NhY2hlLnByb3RvEh9tZy5wcm90b2NvbC5jb252",
            "ZXJzYXRpb25zX2NhY2hlIjkKEkNvbnZlcnNhdGlvbnNDYWNoZRIPCgd2ZXJz",
            "aW9uGAEgAigNEhIKCmNoYW5uZWxJZHMYAiADKAkqQgoZQ29udmVyc2F0aW9u",
            "c0NhY2hlVmVyc2lvbhIlCiFDb252ZXJzYXRpb25zQ2FjaGVWZXJzaW9uX0Rl",
            "ZmF1bHQQAg=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Uplay.ConversationsCache.ConversationsCacheVersion), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.ConversationsCache.ConversationsCache), global::Uplay.ConversationsCache.ConversationsCache.Parser, new[]{ "Version", "ChannelIds" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ConversationsCacheVersion {
    [pbr::OriginalName("ConversationsCacheVersion_Default")] Default = 2,
  }

  #endregion

  #region Messages
  public sealed partial class ConversationsCache : pb::IMessage<ConversationsCache>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversationsCache> _parser = new pb::MessageParser<ConversationsCache>(() => new ConversationsCache());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversationsCache> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.ConversationsCache.ConversationsCacheReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversationsCache() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversationsCache(ConversationsCache other) : this() {
      _hasBits0 = other._hasBits0;
      version_ = other.version_;
      channelIds_ = other.channelIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversationsCache Clone() {
      return new ConversationsCache(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private readonly static uint VersionDefaultValue = 0;

    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { if ((_hasBits0 & 1) != 0) { return version_; } else { return VersionDefaultValue; } }
      set {
        _hasBits0 |= 1;
        version_ = value;
      }
    }
    /// <summary>Gets whether the "version" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasVersion {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "version" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearVersion() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "channelIds" field.</summary>
    public const int ChannelIdsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_channelIds_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> channelIds_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ChannelIds {
      get { return channelIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversationsCache);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversationsCache other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if(!channelIds_.Equals(other.channelIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasVersion) hash ^= Version.GetHashCode();
      hash ^= channelIds_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasVersion) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      channelIds_.WriteTo(output, _repeated_channelIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasVersion) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      channelIds_.WriteTo(ref output, _repeated_channelIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasVersion) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      size += channelIds_.CalculateSize(_repeated_channelIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConversationsCache other) {
      if (other == null) {
        return;
      }
      if (other.HasVersion) {
        Version = other.Version;
      }
      channelIds_.Add(other.channelIds_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Version = input.ReadUInt32();
            break;
          }
          case 18: {
            channelIds_.AddEntriesFrom(input, _repeated_channelIds_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Version = input.ReadUInt32();
            break;
          }
          case 18: {
            channelIds_.AddEntriesFrom(ref input, _repeated_channelIds_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
