Imports Newtonsoft.Json

Namespace Models

    ''' <summary>
    ''' The progress model.
    ''' </summary>
    Public Class ProgressModel
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
        ''' Gets or sets the number of unknown emails in a batch.
        ''' </summary>
        <JsonProperty("total")>
        Public Property Total As UInteger

        ''' <summary>
        ''' Gets or sets the number of unprocessed emails in a batch.
        ''' </summary>
        <JsonProperty("unprocessed")>
        Public Property Unprocessed As UInteger
    End Class
End Namespace
