// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Click.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Shared.Protos {

  /// <summary>Holder for reflection information generated from Click.proto</summary>
  public static partial class ClickReflection {

    #region Descriptor
    /// <summary>File descriptor for Click.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClickReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtDbGljay5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90",
            "byJ9ChJDcmVhdGVDbGlja1JlcXVlc3QSDgoGTGlua0lkGAEgASgFEjEKDUNs",
            "aWNrRGF0ZVRpbWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "EhEKCUlwQWRkcmVzcxgDIAEoCRIRCglVc2VyQWdlbnQYBCABKAkiRAoTQ3Jl",
            "YXRlQ2xpY2tSZXNwb25zZRItCgxDcmVhdGVkQ2xpY2sYASABKAsyFy5DcmVh",
            "dGVDbGlja1Jlc3BvbnNlRFRPIo0BChZDcmVhdGVDbGlja1Jlc3BvbnNlRFRP",
            "EgoKAklkGAEgASgFEg4KBkxpbmtJZBgCIAEoBRIxCg1DbGlja0RhdGVUaW1l",
            "GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIRCglJcEFkZHJl",
            "c3MYBCABKAkSEQoJVXNlckFnZW50GAUgASgJMk0KEUNsaWNrUHJvdG9TZXJ2",
            "aWNlEjgKC0NyZWF0ZUNsaWNrEhMuQ3JlYXRlQ2xpY2tSZXF1ZXN0GhQuQ3Jl",
            "YXRlQ2xpY2tSZXNwb25zZUIQqgINU2hhcmVkLlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Shared.Protos.CreateClickRequest), global::Shared.Protos.CreateClickRequest.Parser, new[]{ "LinkId", "ClickDateTime", "IpAddress", "UserAgent" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Shared.Protos.CreateClickResponse), global::Shared.Protos.CreateClickResponse.Parser, new[]{ "CreatedClick" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Shared.Protos.CreateClickResponseDTO), global::Shared.Protos.CreateClickResponseDTO.Parser, new[]{ "Id", "LinkId", "ClickDateTime", "IpAddress", "UserAgent" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CreateClickRequest : pb::IMessage<CreateClickRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateClickRequest> _parser = new pb::MessageParser<CreateClickRequest>(() => new CreateClickRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateClickRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Shared.Protos.ClickReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickRequest(CreateClickRequest other) : this() {
      linkId_ = other.linkId_;
      clickDateTime_ = other.clickDateTime_ != null ? other.clickDateTime_.Clone() : null;
      ipAddress_ = other.ipAddress_;
      userAgent_ = other.userAgent_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickRequest Clone() {
      return new CreateClickRequest(this);
    }

    /// <summary>Field number for the "LinkId" field.</summary>
    public const int LinkIdFieldNumber = 1;
    private int linkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LinkId {
      get { return linkId_; }
      set {
        linkId_ = value;
      }
    }

    /// <summary>Field number for the "ClickDateTime" field.</summary>
    public const int ClickDateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp clickDateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ClickDateTime {
      get { return clickDateTime_; }
      set {
        clickDateTime_ = value;
      }
    }

    /// <summary>Field number for the "IpAddress" field.</summary>
    public const int IpAddressFieldNumber = 3;
    private string ipAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IpAddress {
      get { return ipAddress_; }
      set {
        ipAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserAgent" field.</summary>
    public const int UserAgentFieldNumber = 4;
    private string userAgent_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserAgent {
      get { return userAgent_; }
      set {
        userAgent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateClickRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateClickRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LinkId != other.LinkId) return false;
      if (!object.Equals(ClickDateTime, other.ClickDateTime)) return false;
      if (IpAddress != other.IpAddress) return false;
      if (UserAgent != other.UserAgent) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LinkId != 0) hash ^= LinkId.GetHashCode();
      if (clickDateTime_ != null) hash ^= ClickDateTime.GetHashCode();
      if (IpAddress.Length != 0) hash ^= IpAddress.GetHashCode();
      if (UserAgent.Length != 0) hash ^= UserAgent.GetHashCode();
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
      if (LinkId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LinkId);
      }
      if (clickDateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClickDateTime);
      }
      if (IpAddress.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IpAddress);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserAgent);
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
      if (LinkId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LinkId);
      }
      if (clickDateTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClickDateTime);
      }
      if (IpAddress.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IpAddress);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UserAgent);
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
      if (LinkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LinkId);
      }
      if (clickDateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClickDateTime);
      }
      if (IpAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IpAddress);
      }
      if (UserAgent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserAgent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateClickRequest other) {
      if (other == null) {
        return;
      }
      if (other.LinkId != 0) {
        LinkId = other.LinkId;
      }
      if (other.clickDateTime_ != null) {
        if (clickDateTime_ == null) {
          ClickDateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ClickDateTime.MergeFrom(other.ClickDateTime);
      }
      if (other.IpAddress.Length != 0) {
        IpAddress = other.IpAddress;
      }
      if (other.UserAgent.Length != 0) {
        UserAgent = other.UserAgent;
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
            LinkId = input.ReadInt32();
            break;
          }
          case 18: {
            if (clickDateTime_ == null) {
              ClickDateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ClickDateTime);
            break;
          }
          case 26: {
            IpAddress = input.ReadString();
            break;
          }
          case 34: {
            UserAgent = input.ReadString();
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
            LinkId = input.ReadInt32();
            break;
          }
          case 18: {
            if (clickDateTime_ == null) {
              ClickDateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ClickDateTime);
            break;
          }
          case 26: {
            IpAddress = input.ReadString();
            break;
          }
          case 34: {
            UserAgent = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CreateClickResponse : pb::IMessage<CreateClickResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateClickResponse> _parser = new pb::MessageParser<CreateClickResponse>(() => new CreateClickResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateClickResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Shared.Protos.ClickReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickResponse(CreateClickResponse other) : this() {
      createdClick_ = other.createdClick_ != null ? other.createdClick_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickResponse Clone() {
      return new CreateClickResponse(this);
    }

    /// <summary>Field number for the "CreatedClick" field.</summary>
    public const int CreatedClickFieldNumber = 1;
    private global::Shared.Protos.CreateClickResponseDTO createdClick_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Shared.Protos.CreateClickResponseDTO CreatedClick {
      get { return createdClick_; }
      set {
        createdClick_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateClickResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateClickResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CreatedClick, other.CreatedClick)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (createdClick_ != null) hash ^= CreatedClick.GetHashCode();
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
      if (createdClick_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreatedClick);
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
      if (createdClick_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CreatedClick);
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
      if (createdClick_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedClick);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateClickResponse other) {
      if (other == null) {
        return;
      }
      if (other.createdClick_ != null) {
        if (createdClick_ == null) {
          CreatedClick = new global::Shared.Protos.CreateClickResponseDTO();
        }
        CreatedClick.MergeFrom(other.CreatedClick);
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
          case 10: {
            if (createdClick_ == null) {
              CreatedClick = new global::Shared.Protos.CreateClickResponseDTO();
            }
            input.ReadMessage(CreatedClick);
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
            if (createdClick_ == null) {
              CreatedClick = new global::Shared.Protos.CreateClickResponseDTO();
            }
            input.ReadMessage(CreatedClick);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CreateClickResponseDTO : pb::IMessage<CreateClickResponseDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateClickResponseDTO> _parser = new pb::MessageParser<CreateClickResponseDTO>(() => new CreateClickResponseDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateClickResponseDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Shared.Protos.ClickReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickResponseDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickResponseDTO(CreateClickResponseDTO other) : this() {
      id_ = other.id_;
      linkId_ = other.linkId_;
      clickDateTime_ = other.clickDateTime_ != null ? other.clickDateTime_.Clone() : null;
      ipAddress_ = other.ipAddress_;
      userAgent_ = other.userAgent_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateClickResponseDTO Clone() {
      return new CreateClickResponseDTO(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "LinkId" field.</summary>
    public const int LinkIdFieldNumber = 2;
    private int linkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LinkId {
      get { return linkId_; }
      set {
        linkId_ = value;
      }
    }

    /// <summary>Field number for the "ClickDateTime" field.</summary>
    public const int ClickDateTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp clickDateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ClickDateTime {
      get { return clickDateTime_; }
      set {
        clickDateTime_ = value;
      }
    }

    /// <summary>Field number for the "IpAddress" field.</summary>
    public const int IpAddressFieldNumber = 4;
    private string ipAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IpAddress {
      get { return ipAddress_; }
      set {
        ipAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserAgent" field.</summary>
    public const int UserAgentFieldNumber = 5;
    private string userAgent_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserAgent {
      get { return userAgent_; }
      set {
        userAgent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateClickResponseDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateClickResponseDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (LinkId != other.LinkId) return false;
      if (!object.Equals(ClickDateTime, other.ClickDateTime)) return false;
      if (IpAddress != other.IpAddress) return false;
      if (UserAgent != other.UserAgent) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (LinkId != 0) hash ^= LinkId.GetHashCode();
      if (clickDateTime_ != null) hash ^= ClickDateTime.GetHashCode();
      if (IpAddress.Length != 0) hash ^= IpAddress.GetHashCode();
      if (UserAgent.Length != 0) hash ^= UserAgent.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (LinkId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(LinkId);
      }
      if (clickDateTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ClickDateTime);
      }
      if (IpAddress.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(IpAddress);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserAgent);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (LinkId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(LinkId);
      }
      if (clickDateTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ClickDateTime);
      }
      if (IpAddress.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(IpAddress);
      }
      if (UserAgent.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserAgent);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (LinkId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LinkId);
      }
      if (clickDateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClickDateTime);
      }
      if (IpAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IpAddress);
      }
      if (UserAgent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserAgent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateClickResponseDTO other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.LinkId != 0) {
        LinkId = other.LinkId;
      }
      if (other.clickDateTime_ != null) {
        if (clickDateTime_ == null) {
          ClickDateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ClickDateTime.MergeFrom(other.ClickDateTime);
      }
      if (other.IpAddress.Length != 0) {
        IpAddress = other.IpAddress;
      }
      if (other.UserAgent.Length != 0) {
        UserAgent = other.UserAgent;
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
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            LinkId = input.ReadInt32();
            break;
          }
          case 26: {
            if (clickDateTime_ == null) {
              ClickDateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ClickDateTime);
            break;
          }
          case 34: {
            IpAddress = input.ReadString();
            break;
          }
          case 42: {
            UserAgent = input.ReadString();
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
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            LinkId = input.ReadInt32();
            break;
          }
          case 26: {
            if (clickDateTime_ == null) {
              ClickDateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ClickDateTime);
            break;
          }
          case 34: {
            IpAddress = input.ReadString();
            break;
          }
          case 42: {
            UserAgent = input.ReadString();
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