Imports Newtonsoft.Json

Namespace Models

    ''' <summary>
    ''' The kick box response.
    ''' </summary>
    Public Class KickBoxResponse
        ''' <summary>
        ''' Gets or sets the result.
        ''' </summary>
        <JsonProperty("result")>
        Public Property Result As Models.Result

        ''' <summary>
        ''' Gets or sets the reason.
        ''' </summary>
        <JsonProperty("reason")>
        Public Property Reason As String

        ''' <summary>
        ''' Gets or sets a value indicating whether role.
        ''' </summary>
        <JsonProperty("role")>
        Public Property Role As Boolean

        ''' <summary>
        ''' Gets or sets a value indicating whether free.
        ''' </summary>
        <JsonProperty("free")>
        Public Property Free As Boolean

        ''' <summary>
        ''' Gets or sets a value indicating whether disposable.
        ''' </summary>
        <JsonProperty("disposable")>
        Public Property Disposable As Boolean

        ''' <summary>
        ''' Gets or sets a value indicating whether accept all.
        ''' </summary>
        <JsonProperty("accept_all")>
        Public Property AcceptAll As Boolean

        ''' <summary>
        ''' Gets or sets the did you mean.
        ''' </summary>
        <JsonProperty("did_you_mean")>
        Public Property DidYouMean As String

        ''' <summary>
        ''' Gets or sets the sendex.
        ''' </summary>
        <JsonProperty("sendex")>
        Public Property Sendex As Double

        ''' <summary>
        ''' Gets or sets the email.
        ''' </summary>
        <JsonProperty("email")>
        Public Property Email As String

        ''' <summary>
        ''' Gets or sets the user.
        ''' </summary>
        <JsonProperty("user")>
        Public Property User As String

        ''' <summary>
        ''' Gets or sets the domain.
        ''' </summary>
        <JsonProperty("domain")>
        Public Property Domain As String

        ''' <summary>
        ''' Gets or sets a value indicating whether success.
        ''' </summary>
        <JsonProperty("success")>
        Public Property Success As Boolean
    End Class
End Namespace
