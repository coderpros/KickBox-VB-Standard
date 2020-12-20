<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("brandon.osborne@coderpro.net")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("postmaster@coderpro.net")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("asdfass@asss223.com")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("brandon.osborne@gmail.com")
        Me.EmailAddressListView = New System.Windows.Forms.ListView()
        Me.ColumnHeaderEmail = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BulkVerifyButton = New System.Windows.Forms.Button()
        Me.VerifyButton = New System.Windows.Forms.Button()
        Me.BulkVerificationStatusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'EmailAddressListView
        '
        Me.EmailAddressListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderEmail})
        Me.EmailAddressListView.FullRowSelect = true
        Me.EmailAddressListView.GridLines = true
        Me.EmailAddressListView.HideSelection = false
        Me.EmailAddressListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.EmailAddressListView.Location = New System.Drawing.Point(12, 73)
        Me.EmailAddressListView.Name = "EmailAddressListView"
        Me.EmailAddressListView.Size = New System.Drawing.Size(174, 259)
        Me.EmailAddressListView.TabIndex = 3
        Me.EmailAddressListView.UseCompatibleStateImageBehavior = false
        Me.EmailAddressListView.View = System.Windows.Forms.View.List
        '
        'ColumnHeaderEmail
        '
        Me.ColumnHeaderEmail.Text = "Email Address"
        Me.ColumnHeaderEmail.Width = 500
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(13, 13)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(173, 20)
        Me.EmailAddressTextBox.TabIndex = 1
        '
        'BulkVerifyButton
        '
        Me.BulkVerifyButton.Location = New System.Drawing.Point(13, 339)
        Me.BulkVerifyButton.Name = "BulkVerifyButton"
        Me.BulkVerifyButton.Size = New System.Drawing.Size(75, 23)
        Me.BulkVerifyButton.TabIndex = 4
        Me.BulkVerifyButton.Text = "&Bulk Verify"
        Me.BulkVerifyButton.UseVisualStyleBackColor = true
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(193, 9)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(75, 23)
        Me.VerifyButton.TabIndex = 2
        Me.VerifyButton.Text = "&Verify"
        Me.VerifyButton.UseVisualStyleBackColor = true
        '
        'BulkVerificationStatusLabel
        '
        Me.BulkVerificationStatusLabel.AutoSize = true
        Me.BulkVerificationStatusLabel.Location = New System.Drawing.Point(94, 344)
        Me.BulkVerificationStatusLabel.Name = "BulkVerificationStatusLabel"
        Me.BulkVerificationStatusLabel.Size = New System.Drawing.Size(150, 13)
        Me.BulkVerificationStatusLabel.TabIndex = 5
        Me.BulkVerificationStatusLabel.Text = "No Bulk Operation In Progress"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 371)
        Me.Controls.Add(Me.BulkVerificationStatusLabel)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.BulkVerifyButton)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(Me.EmailAddressListView)
        Me.Name = "MainForm"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents EmailAddressListView As ListView
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents BulkVerifyButton As Button
    Friend WithEvents VerifyButton As Button
    Friend WithEvents ColumnHeaderEmail As ColumnHeader
    Friend WithEvents BulkVerificationStatusLabel As Label
End Class
