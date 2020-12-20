Imports System.Runtime.Serialization

Namespace Models

    ''' <summary>
    ''' The status of a bulk verification.
    ''' </summary>
    Public Enum Status
        ''' <summary>
        ''' Indicates that a bulk verification is queued to start.
        ''' </summary>
        <EnumMember(Value:="starting")>
        Starting

        ''' <summary>
        ''' Indicates that a bulk verification is currently being processed.
        ''' </summary>
        <EnumMember(Value:="processing")>
        Processing

        ''' <summary>
        ''' Indicates that a bulk verification is completed.
        ''' </summary>
        <EnumMember(Value:="completed")>
        Completed

        ''' <summary>
        ''' Indicates that a bulk verification failed.
        ''' </summary>
        <EnumMember(Value:="failed")>
        Failed

        ''' <summary>
        ''' Indicates that a bulk verification is being analyzed.
        ''' </summary>
        <EnumMember(Value:="analyzing")>
        Analyzing

        ''' <summary>
        ''' Indicates that a bulk verification is uploaded.
        ''' </summary>
        <EnumMember(Value:="uploaded")>
        Uploaded

        ''' <summary>
        ''' Indicates that a bulk verification is ready.
        ''' </summary>
        <EnumMember(Value:="ready")>
        Ready
    End Enum
End Namespace
