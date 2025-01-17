// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/bookinformation.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BookInformationService {
  /// <summary>
  /// The BookInformation gRPC service definition.
  /// </summary>
  public static partial class BookInformationGrpc
  {
    static readonly string __ServiceName = "bookinformationgrpcservice.BookInformationGrpc";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.GetBookInformationRequest> __Marshaller_bookinformationgrpcservice_GetBookInformationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.GetBookInformationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.GetBookInformationResponse> __Marshaller_bookinformationgrpcservice_GetBookInformationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.GetBookInformationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.ListBookInformationRequest> __Marshaller_bookinformationgrpcservice_ListBookInformationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.ListBookInformationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.ListBookInformationResponse> __Marshaller_bookinformationgrpcservice_ListBookInformationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.ListBookInformationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.CreateBookInformationRequest> __Marshaller_bookinformationgrpcservice_CreateBookInformationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.CreateBookInformationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.CreateBookInformationResponse> __Marshaller_bookinformationgrpcservice_CreateBookInformationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.CreateBookInformationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.UpdateBookInformationRequest> __Marshaller_bookinformationgrpcservice_UpdateBookInformationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.UpdateBookInformationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.UpdateBookInformationResponse> __Marshaller_bookinformationgrpcservice_UpdateBookInformationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.UpdateBookInformationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.DeleteBookInformationRequest> __Marshaller_bookinformationgrpcservice_DeleteBookInformationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.DeleteBookInformationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookInformationService.DeleteBookInformationResponse> __Marshaller_bookinformationgrpcservice_DeleteBookInformationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookInformationService.DeleteBookInformationResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookInformationService.GetBookInformationRequest, global::BookInformationService.GetBookInformationResponse> __Method_GetBookInformation = new grpc::Method<global::BookInformationService.GetBookInformationRequest, global::BookInformationService.GetBookInformationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBookInformation",
        __Marshaller_bookinformationgrpcservice_GetBookInformationRequest,
        __Marshaller_bookinformationgrpcservice_GetBookInformationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookInformationService.ListBookInformationRequest, global::BookInformationService.ListBookInformationResponse> __Method_ListBookInformation = new grpc::Method<global::BookInformationService.ListBookInformationRequest, global::BookInformationService.ListBookInformationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListBookInformation",
        __Marshaller_bookinformationgrpcservice_ListBookInformationRequest,
        __Marshaller_bookinformationgrpcservice_ListBookInformationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookInformationService.CreateBookInformationRequest, global::BookInformationService.CreateBookInformationResponse> __Method_CreateBookInformation = new grpc::Method<global::BookInformationService.CreateBookInformationRequest, global::BookInformationService.CreateBookInformationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateBookInformation",
        __Marshaller_bookinformationgrpcservice_CreateBookInformationRequest,
        __Marshaller_bookinformationgrpcservice_CreateBookInformationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookInformationService.UpdateBookInformationRequest, global::BookInformationService.UpdateBookInformationResponse> __Method_UpdateBookInformation = new grpc::Method<global::BookInformationService.UpdateBookInformationRequest, global::BookInformationService.UpdateBookInformationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBookInformation",
        __Marshaller_bookinformationgrpcservice_UpdateBookInformationRequest,
        __Marshaller_bookinformationgrpcservice_UpdateBookInformationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookInformationService.DeleteBookInformationRequest, global::BookInformationService.DeleteBookInformationResponse> __Method_DeleteBookInformation = new grpc::Method<global::BookInformationService.DeleteBookInformationRequest, global::BookInformationService.DeleteBookInformationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBookInformation",
        __Marshaller_bookinformationgrpcservice_DeleteBookInformationRequest,
        __Marshaller_bookinformationgrpcservice_DeleteBookInformationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BookInformationService.BookinformationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BookInformationGrpc</summary>
    [grpc::BindServiceMethod(typeof(BookInformationGrpc), "BindService")]
    public abstract partial class BookInformationGrpcBase
    {
      /// <summary>
      /// Retrieves book information by ID.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookInformationService.GetBookInformationResponse> GetBookInformation(global::BookInformationService.GetBookInformationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves a list of all book informations.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookInformationService.ListBookInformationResponse> ListBookInformation(global::BookInformationService.ListBookInformationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new book information record.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookInformationService.CreateBookInformationResponse> CreateBookInformation(global::BookInformationService.CreateBookInformationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an existing book information record.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookInformationService.UpdateBookInformationResponse> UpdateBookInformation(global::BookInformationService.UpdateBookInformationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a book information record by ID.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookInformationService.DeleteBookInformationResponse> DeleteBookInformation(global::BookInformationService.DeleteBookInformationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BookInformationGrpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetBookInformation, serviceImpl.GetBookInformation)
          .AddMethod(__Method_ListBookInformation, serviceImpl.ListBookInformation)
          .AddMethod(__Method_CreateBookInformation, serviceImpl.CreateBookInformation)
          .AddMethod(__Method_UpdateBookInformation, serviceImpl.UpdateBookInformation)
          .AddMethod(__Method_DeleteBookInformation, serviceImpl.DeleteBookInformation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BookInformationGrpcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetBookInformation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookInformationService.GetBookInformationRequest, global::BookInformationService.GetBookInformationResponse>(serviceImpl.GetBookInformation));
      serviceBinder.AddMethod(__Method_ListBookInformation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookInformationService.ListBookInformationRequest, global::BookInformationService.ListBookInformationResponse>(serviceImpl.ListBookInformation));
      serviceBinder.AddMethod(__Method_CreateBookInformation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookInformationService.CreateBookInformationRequest, global::BookInformationService.CreateBookInformationResponse>(serviceImpl.CreateBookInformation));
      serviceBinder.AddMethod(__Method_UpdateBookInformation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookInformationService.UpdateBookInformationRequest, global::BookInformationService.UpdateBookInformationResponse>(serviceImpl.UpdateBookInformation));
      serviceBinder.AddMethod(__Method_DeleteBookInformation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookInformationService.DeleteBookInformationRequest, global::BookInformationService.DeleteBookInformationResponse>(serviceImpl.DeleteBookInformation));
    }

  }
}
#endregion
