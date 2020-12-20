Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Security.Policy

Public Class MainForm
#Region "EVENTS"
    Private Async Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
        Dim kickbox = New KickBox.Standard.VB.KickBoxApi("**********", "https://api.kickbox.com/v2")
        Dim verificationResponse = Await kickbox.VerifyEmail(
            New System.Net.Mail.MailAddress(EmailAddressTextBox.Text),
            5000).ConfigureAwait(True)

        MessageBox.Show(Me, $"Result: {verificationResponse.Result}") 'Look at the other properties in verificationResponse too!
    End Sub

    Private Async Sub BulkVerifyButton_Click(sender As Object, e As EventArgs) Handles BulkVerifyButton.Click
        Me.BulkVerificationStatusLabel.Text = "Bulk Verification in Progress"

        Dim emailAddresses = EmailAddressListView.Items.Cast(Of ListViewItem).
                Select(Function(s) s.Text).ToList

        Dim kickboxApi = New KickBox.Standard.VB.KickBoxApi("**********", "https://api.kickbox.com/v2")
        Dim verificationResponse = Await kickboxApi.VerifyBatch(
            emailAddresses,
            Nothing,
            Nothing)

        If verificationResponse.Success Then
            BulkVerificationStatusLabel.Text = "Bulk Verification Processing"

            Dim batchResponse = New KickBox.Standard.VB.Models.BatchResponse

            ' Continue checking the status of the batch process every 5 seconds and don't proceed until completed.
            Do Until batchResponse.Status = KickBox.Standard.VB.Models.Status.Completed
                Windows.Forms.Application.DoEvents()
                batchResponse = Await Me.CheckStatus(5, verificationResponse.Id)
            Loop

            BulkVerificationStatusLabel.Text = "Bulk Verification Completed"

            ' Read the CSV file from KickBox.
            Dim rawCsv = Me.GetCsv(batchResponse.DownloadUrl)
            Dim rows = rawCsv.Split(CType(Environment.NewLine, Char()), StringSplitOptions.None)

            ' Iterate through the results and Update the UI.
            Dim i = 0
            For Each row In rows
                If i > 0 And
                   Not row = "" Then
                    Dim columns = rows(i).Split(",")

                    If columns(1) = "undeliverable" Then
                        EmailAddressListView.Items(columns(0)).BackColor = Color.Red
                    End If
                End If

                i = i + 1
            Next
        Else
            BulkVerificationStatusLabel.Text = "Bulk Verification Failed"
        End If

    End Sub
#End Region
    Private Function GetCsv(url As String) As String
        Dim request As HttpWebRequest = WebRequest.Create(url)
        Dim response As HttpWebResponse = request.GetResponse()
        Dim reader = New StreamReader(response.GetResponseStream)
        Dim result = reader.ReadToEnd()

        reader.Close()

        Return result
    End Function

    Private Async Function CheckStatus(waitPeriod As UInt16, jobId As Integer) As Task(Of KickBox.Standard.VB.Models.BatchResponse)
        Dim waitUntil As DateTime = DateTime.Now.AddSeconds(waitPeriod)
        Dim kickbox = New KickBox.Standard.VB.KickBoxApi("live_a41a2e3f2c5f4aa1275769858cd215140374ca1a1154dbee8a8a6b6d882aedcc", "https://api.kickbox.com/v2")

        Do Until Date.Now() > waitUntil
            Windows.Forms.Application.DoEvents()
        Loop

        Return Await kickbox.CheckStatus(jobId)


    End Function

End Class
