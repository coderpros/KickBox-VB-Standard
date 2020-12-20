Imports System.Runtime.Serialization

Namespace Models

    ''' <summary>
    ''' The result from KickBox.
    ''' </summary>
    Public Enum Result
        ''' <summary>
        ''' The email address was identified as deliverable.
        ''' </summary>
        <EnumMember(Value:="deliverable")>
        Deliverable

        ''' <summary>
        ''' The email address was identified as undeliverable.
        ''' </summary>
        <EnumMember(Value:="undeliverable")>
        Undeliverable

        ''' <summary>
        ''' The email address was identified as risky.
        ''' </summary>
        <EnumMember(Value:="risky")>
        Risky

        ''' <summary>
        ''' The email address was identified as unknown.
        ''' </summary>
        <EnumMember(Value:="unknown")>
        Unknown
    End Enum
End Namespace
