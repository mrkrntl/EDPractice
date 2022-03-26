<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.TxtBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxUserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.userid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadUsersButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Aquamarine
        Me.Panel1.Controls.Add(Me.ShowButton)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Controls.Add(Me.TxtBoxUsername)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtBoxUserID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 391)
        Me.Panel1.TabIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowButton.Location = New System.Drawing.Point(12, 287)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(105, 23)
        Me.ShowButton.TabIndex = 5
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(12, 250)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(105, 31)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(11, 212)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(106, 31)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'TxtBoxUsername
        '
        Me.TxtBoxUsername.Location = New System.Drawing.Point(11, 130)
        Me.TxtBoxUsername.Name = "TxtBoxUsername"
        Me.TxtBoxUsername.Size = New System.Drawing.Size(157, 23)
        Me.TxtBoxUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'TxtBoxUserID
        '
        Me.TxtBoxUserID.Location = New System.Drawing.Point(11, 78)
        Me.TxtBoxUserID.Name = "TxtBoxUserID"
        Me.TxtBoxUserID.Size = New System.Drawing.Size(157, 23)
        Me.TxtBoxUserID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(11, 173)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(106, 33)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add to Database"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'UsersDataGridView
        '
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userid, Me.username})
        Me.UsersDataGridView.Location = New System.Drawing.Point(223, 60)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.RowTemplate.Height = 25
        Me.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersDataGridView.Size = New System.Drawing.Size(265, 283)
        Me.UsersDataGridView.TabIndex = 1
        '
        'userid
        '
        Me.userid.HeaderText = "User_ID"
        Me.userid.Name = "userid"
        '
        'username
        '
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        '
        'LoadUsersButton
        '
        Me.LoadUsersButton.Location = New System.Drawing.Point(223, 12)
        Me.LoadUsersButton.Name = "LoadUsersButton"
        Me.LoadUsersButton.Size = New System.Drawing.Size(106, 33)
        Me.LoadUsersButton.TabIndex = 0
        Me.LoadUsersButton.Text = "Load Users"
        Me.LoadUsersButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 391)
        Me.Controls.Add(Me.UsersDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoadUsersButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtBoxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxUserID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents LoadUsersButton As Button
    Friend WithEvents userid As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ShowButton As Button
End Class
