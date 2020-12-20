Imports Newtonsoft.Json

Namespace Models
    ''' <summary>
    ''' The batch response from the KickBox API.
    ''' </summary>
    Public Class BatchResponse
        ''' <summary>
        ''' Gets or sets the id of the job.
        ''' </summary>
        <JsonProperty("id")>
        Public Property Id As Integer

        ''' <summary>
        ''' Gets or sets the name.
        ''' </summary>
        <JsonProperty("name")>
        Public Property Name As string

        ''' <summary>
        ''' Gets or sets the download url.
        ''' </summary>
        <JsonProperty("download_url")>
        Public Property DownloadUrl As string

        ''' <summary>
        ''' Gets or sets the created at date and time.
        ''' </summary>
        <JsonProperty("created_at")>
        Public Property CreatedAt As Date?

        ''' <summary>
        ''' Gets or sets the status of the job.
        ''' </summary>
        <JsonProperty("status")>
        Public Property Status As Models.Status

        ''' <summary>
        ''' Gets or sets a value indicating whether or not the job was successful.
        ''' </summary>
        <JsonProperty("success")>
        Public Property Success As Boolean

        ''' <summary>
        ''' Gets or sets the description of any error associated with the request.
        ''' </summary>
        <JsonProperty("error")>
        Public Property [Error] As String

        ''' <summary>
        ''' Gets or sets the message.
        ''' </summary>
        <JsonProperty("message")>
        Public Property Message As String

        ''' <summary>
        ''' Gets or sets the progress of a batch verification.
        ''' </summary>
        <JsonProperty("progress")>
        Public Property Progress As Models.ProgressModel

        ''' <summary>
        ''' Gets or sets the status of a completed batch verification.
        ''' </summary>
        <JsonProperty("stats")>
        Public Property Stats As Models.StatsModel
    End Class
End Namespace
