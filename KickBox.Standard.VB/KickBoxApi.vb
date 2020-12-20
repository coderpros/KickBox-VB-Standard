#Region "IMPORTS"
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Mail
Imports System.Text
Imports KickBox.Standard.VB.KickBox.Core.Models
Imports KickBox.Standard.VB.Models
Imports Newtonsoft.Json
#End Region
Public NotInheritable Class KickBoxApi
#Region "PRIVATE BACKERS"
    Private ReadOnly _apiKey As String
    Private ReadOnly _apiUrl As String
#End Region

#Region "CONSTRUCTOR"
    Public Sub New(ByVal apiKey As String, ByVal apiUrl As String)
        _apiKey = apiKey
        _apiUrl = apiUrl
    End Sub
#End Region

#Region "METHODS"
    ''' <summary>
    ''' The verify email function verifies a single email address. 
    ''' </summary>
    ''' <paramname="mailAddress">
    ''' The email address to be verified.
    ''' </param>
    ''' <paramname="timeout">
    ''' The time in seconds before a timeout (default 30 seconds).
    ''' </param>
    ''' <returns>
    ''' The <seecref="Task(OfKickBoxResponse)"/> from the API.
    ''' </returns>
    Public Async Function VerifyEmail(ByVal mailAddress As MailAddress, ByVal Optional timeout As Integer? = Nothing) As Task(Of KickBoxResponse)
        Dim httpClient = New HttpClient()
        Dim httpResponse = Await httpClient.GetAsync($"{_apiUrl}/verify?apikey={_apiKey}&email={mailAddress.Address}&timeout={timeout}").ConfigureAwait(True)

        Try
            Return JsonConvert.DeserializeObject(Of KickBox.Standard.VB.Models.KickBoxResponse)(Await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(True))
        Catch e As Exception
            ' TODO: Add logging
            Throw
        End Try
    End Function

    ''' <summary>
    ''' The verify batch method queues a list of email addresses to be verified. 
    ''' </summary>
    ''' <paramname="mailAddresses">
    ''' The email addresses to be verified.
    ''' </param>
    ''' <paramname="fileName">
    ''' The *desired* fileName.
    ''' </param>
    ''' <paramname="batchVerificationCallback">
    ''' The URL to be called after verification has completed.
    ''' </param>
    ''' <returns>
    ''' The <seecref="Task(OfBatchResponse)"/> from the API.
    ''' </returns>
    Public Async Function VerifyBatch(ByVal mailAddresses As IEnumerable(Of string), ByVal Optional fileName As string = Nothing, ByVal Optional batchVerificationCallback As Uri = Nothing) As Task(Of BatchResponse)
        ' var addresses = mailAddresses.Aggregate(string.Empty, (current, address) => current + $"{current}\n");
        Dim addresses = mailAddresses.Aggregate(String.Empty, Function(current, address) current & $"{address}
")
        Dim httpClient = New HttpClient()
        httpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("text/csv"))

        If Not String.IsNullOrEmpty(fileName) Then
            ' Add the desired file name to the header.
            httpClient.DefaultRequestHeaders.Add("X-Kickbox-Filename", fileName)
        End If

        If batchVerificationCallback IsNot Nothing Then
            ' Add the callback URL to the header
            httpClient.DefaultRequestHeaders.Add("X-Kickbox-Callback", batchVerificationCallback.ToString())
        End If

        Dim httpResponse = Await httpClient.PutAsync($"{_apiUrl}/verify-batch?apikey={_apiKey}", New StringContent(addresses, Encoding.UTF8, "text/csv")).ConfigureAwait(True)

        Try
            Return JsonConvert.DeserializeObject(Of KickBox.Standard.VB.Models.BatchResponse)(Await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(True))
        Catch e As Exception
            ' TODO: Add logging
            Throw
        End Try
    End Function

    ''' <summary>
    ''' The check status method checks the status of a bulk verification job.
    ''' </summary>
    ''' <paramname="jobId">
    ''' The id of the batch verification job.
    ''' </param>
    ''' <returns>
    ''' The <seecref="Task(OfBatchResponse)"/> from the API.
    ''' </returns>
    Public Async Function CheckStatus(ByVal jobId As Integer) As Task(Of BatchResponse)
        Dim httpClient = New HttpClient()
        Dim httpResponse = Await httpClient.GetAsync($"{_apiUrl}/verify-batch/{jobId}/?apikey={_apiKey}").ConfigureAwait(True)

        Try
            Return JsonConvert.DeserializeObject(Of BatchResponse)(Await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(True))
        Catch e As Exception
            ' TODO: Add logging
            Throw
        End Try
    End Function
#End Region
End Class