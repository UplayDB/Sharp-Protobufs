// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: game_activations_cache.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Uplay.GameActivationsCache {

  /// <summary>Holder for reflection information generated from game_activations_cache.proto</summary>
  public static partial class GameActivationsCacheReflection {

    #region Descriptor
    /// <summary>File descriptor for game_activations_cache.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameActivationsCacheReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxnYW1lX2FjdGl2YXRpb25zX2NhY2hlLnByb3RvEiJtZy5wcm90b2NvbC5n",
            "YW1lX2FjdGl2YXRpb25zX2NhY2hlIjgKD0V4ZWN1dGFibGVUb2tlbhIRCgll",
            "eGVfaW5kZXgYASACKA0SEgoKZ2FtZV90b2tlbhgDIAEoCSJzCg5HYW1lQWN0",
            "aXZhdGlvbhISCgpwcm9kdWN0X2lkGAEgAigNEk0KEGV4ZWN1dGFibGVfdG9r",
            "ZW4YAiADKAsyMy5tZy5wcm90b2NvbC5nYW1lX2FjdGl2YXRpb25zX2NhY2hl",
            "LkV4ZWN1dGFibGVUb2tlbiJmChdHYW1lQWN0aXZhdGlvbkxpc3RDYWNoZRJL",
            "Cg9nYW1lX2FjdGl2YXRpb24YASADKAsyMi5tZy5wcm90b2NvbC5nYW1lX2Fj",
            "dGl2YXRpb25zX2NhY2hlLkdhbWVBY3RpdmF0aW9u"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.GameActivationsCache.ExecutableToken), global::Uplay.GameActivationsCache.ExecutableToken.Parser, new[]{ "ExeIndex", "GameToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.GameActivationsCache.GameActivation), global::Uplay.GameActivationsCache.GameActivation.Parser, new[]{ "ProductId", "ExecutableToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Uplay.GameActivationsCache.GameActivationListCache), global::Uplay.GameActivationsCache.GameActivationListCache.Parser, new[]{ "GameActivation" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExecutableToken : pb::IMessage<ExecutableToken>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExecutableToken> _parser = new pb::MessageParser<ExecutableToken>(() => new ExecutableToken());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExecutableToken> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.GameActivationsCache.GameActivationsCacheReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecutableToken() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecutableToken(ExecutableToken other) : this() {
      _hasBits0 = other._hasBits0;
      exeIndex_ = other.exeIndex_;
      gameToken_ = other.gameToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecutableToken Clone() {
      return new ExecutableToken(this);
    }

    /// <summary>Field number for the "exe_index" field.</summary>
    public const int ExeIndexFieldNumber = 1;
    private readonly static uint ExeIndexDefaultValue = 0;

    private uint exeIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExeIndex {
      get { if ((_hasBits0 & 1) != 0) { return exeIndex_; } else { return ExeIndexDefaultValue; } }
      set {
        _hasBits0 |= 1;
        exeIndex_ = value;
      }
    }
    /// <summary>Gets whether the "exe_index" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasExeIndex {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "exe_index" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearExeIndex() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "game_token" field.</summary>
    public const int GameTokenFieldNumber = 3;
    private readonly static string GameTokenDefaultValue = "";

    private string gameToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GameToken {
      get { return gameToken_ ?? GameTokenDefaultValue; }
      set {
        gameToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "game_token" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasGameToken {
      get { return gameToken_ != null; }
    }
    /// <summary>Clears the value of the "game_token" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearGameToken() {
      gameToken_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExecutableToken);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExecutableToken other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ExeIndex != other.ExeIndex) return false;
      if (GameToken != other.GameToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasExeIndex) hash ^= ExeIndex.GetHashCode();
      if (HasGameToken) hash ^= GameToken.GetHashCode();
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
      if (HasExeIndex) {
        output.WriteRawTag(8);
        output.WriteUInt32(ExeIndex);
      }
      if (HasGameToken) {
        output.WriteRawTag(26);
        output.WriteString(GameToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasExeIndex) {
        output.WriteRawTag(8);
        output.WriteUInt32(ExeIndex);
      }
      if (HasGameToken) {
        output.WriteRawTag(26);
        output.WriteString(GameToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasExeIndex) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExeIndex);
      }
      if (HasGameToken) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExecutableToken other) {
      if (other == null) {
        return;
      }
      if (other.HasExeIndex) {
        ExeIndex = other.ExeIndex;
      }
      if (other.HasGameToken) {
        GameToken = other.GameToken;
      }
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
            ExeIndex = input.ReadUInt32();
            break;
          }
          case 26: {
            GameToken = input.ReadString();
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
            ExeIndex = input.ReadUInt32();
            break;
          }
          case 26: {
            GameToken = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GameActivation : pb::IMessage<GameActivation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameActivation> _parser = new pb::MessageParser<GameActivation>(() => new GameActivation());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameActivation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.GameActivationsCache.GameActivationsCacheReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameActivation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameActivation(GameActivation other) : this() {
      _hasBits0 = other._hasBits0;
      productId_ = other.productId_;
      executableToken_ = other.executableToken_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameActivation Clone() {
      return new GameActivation(this);
    }

    /// <summary>Field number for the "product_id" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private readonly static uint ProductIdDefaultValue = 0;

    private uint productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ProductId {
      get { if ((_hasBits0 & 1) != 0) { return productId_; } else { return ProductIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        productId_ = value;
      }
    }
    /// <summary>Gets whether the "product_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasProductId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "product_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearProductId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "executable_token" field.</summary>
    public const int ExecutableTokenFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Uplay.GameActivationsCache.ExecutableToken> _repeated_executableToken_codec
        = pb::FieldCodec.ForMessage(18, global::Uplay.GameActivationsCache.ExecutableToken.Parser);
    private readonly pbc::RepeatedField<global::Uplay.GameActivationsCache.ExecutableToken> executableToken_ = new pbc::RepeatedField<global::Uplay.GameActivationsCache.ExecutableToken>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Uplay.GameActivationsCache.ExecutableToken> ExecutableToken {
      get { return executableToken_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameActivation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameActivation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if(!executableToken_.Equals(other.executableToken_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasProductId) hash ^= ProductId.GetHashCode();
      hash ^= executableToken_.GetHashCode();
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
      if (HasProductId) {
        output.WriteRawTag(8);
        output.WriteUInt32(ProductId);
      }
      executableToken_.WriteTo(output, _repeated_executableToken_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasProductId) {
        output.WriteRawTag(8);
        output.WriteUInt32(ProductId);
      }
      executableToken_.WriteTo(ref output, _repeated_executableToken_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasProductId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProductId);
      }
      size += executableToken_.CalculateSize(_repeated_executableToken_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameActivation other) {
      if (other == null) {
        return;
      }
      if (other.HasProductId) {
        ProductId = other.ProductId;
      }
      executableToken_.Add(other.executableToken_);
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
            ProductId = input.ReadUInt32();
            break;
          }
          case 18: {
            executableToken_.AddEntriesFrom(input, _repeated_executableToken_codec);
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
            ProductId = input.ReadUInt32();
            break;
          }
          case 18: {
            executableToken_.AddEntriesFrom(ref input, _repeated_executableToken_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GameActivationListCache : pb::IMessage<GameActivationListCache>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameActivationListCache> _parser = new pb::MessageParser<GameActivationListCache>(() => new GameActivationListCache());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameActivationListCache> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Uplay.GameActivationsCache.GameActivationsCacheReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameActivationListCache() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameActivationListCache(GameActivationListCache other) : this() {
      gameActivation_ = other.gameActivation_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameActivationListCache Clone() {
      return new GameActivationListCache(this);
    }

    /// <summary>Field number for the "game_activation" field.</summary>
    public const int GameActivationFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Uplay.GameActivationsCache.GameActivation> _repeated_gameActivation_codec
        = pb::FieldCodec.ForMessage(10, global::Uplay.GameActivationsCache.GameActivation.Parser);
    private readonly pbc::RepeatedField<global::Uplay.GameActivationsCache.GameActivation> gameActivation_ = new pbc::RepeatedField<global::Uplay.GameActivationsCache.GameActivation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Uplay.GameActivationsCache.GameActivation> GameActivation {
      get { return gameActivation_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameActivationListCache);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameActivationListCache other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gameActivation_.Equals(other.gameActivation_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gameActivation_.GetHashCode();
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
      gameActivation_.WriteTo(output, _repeated_gameActivation_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      gameActivation_.WriteTo(ref output, _repeated_gameActivation_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += gameActivation_.CalculateSize(_repeated_gameActivation_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameActivationListCache other) {
      if (other == null) {
        return;
      }
      gameActivation_.Add(other.gameActivation_);
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
          case 10: {
            gameActivation_.AddEntriesFrom(input, _repeated_gameActivation_codec);
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
          case 10: {
            gameActivation_.AddEntriesFrom(ref input, _repeated_gameActivation_codec);
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
