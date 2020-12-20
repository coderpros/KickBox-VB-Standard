Imports Newtonsoft.Json

Namespace Models

    ''' <summary>
    ''' The stats model used in completed batch verifications.
    ''' </summary>
    Public Class StatsModel
        ''' <summary>
        ''' Gets or sets the number of deliverable email addresses.
        ''' </summary>
        <JsonProperty("deliverable")>
        Public Property Deliverable As UInteger

        ''' <summary>
        ''' Gets or sets the undeliverable email addresses.
        ''' </summary>
        <JsonProperty("undeliverable")>
        Public Property Undeliverable As UInteger

        ''' <summary>
        ''' Gets or sets the number of risky emails in a batch.
        ''' </summary>
        <JsonProperty("risky")>
        Public Property Risky As UInteger

        ''' <summary>
        ''' Gets or sets the number of unknown emails in a batch.
        ''' </summary>
        <JsonProperty("unknown")>
        Public Property Unknown As UInteger

        ''' <summary>
        ''' Gets or sets the sendex of all emails in a batch.
        ''' </summary>
        <JsonProperty("sendex")>
        Public Property Sendex As UInteger

        ''' <summary>
        ''' Gets or sets the total address count in a batch.
        ''' </summary>
        <JsonProperty("addresses")>
        Public Property AddressCount As UInteger
    End Class
End Namespace
