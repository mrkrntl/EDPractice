Imports MySql.Data.MySqlClient

Public Class Form1

    Public DBConnection As New MySqlConnection

    Public Sub DBConnect()
        Dim DBConnectionString As String = "server=localhost;user id=root;password=Rantael041801;database=edpractice"

        With DBConnection
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionString
                .Open()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Error")
                Call DBDisconnect()
            End Try
        End With
    End Sub

    Public Sub DBDisconnect()
        With DBConnection
            .Close()
            .Dispose()
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsersButton_Click(sender, e)
    End Sub

    Private Sub LoadUsersButton_Click(sender As Object, e As EventArgs) Handles LoadUsersButton.Click
        Me.UsersDataGridView.Rows.Clear()
        Dim strsql As String
        Dim sqlcmd As New MySqlCommand
        strsql = "SELECT * FROM users"
        DBConnect()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With

        Dim myreader As MySqlDataReader
        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.UsersDataGridView.Rows.Add(New Object() {myreader.Item("user_id"), myreader.Item("username")})
        End While
        DBDisconnect()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        For Each tb As TextBox In Panel1.Controls.OfType(Of TextBox)()
            tb.Text = ""
        Next

        'If String.IsNullOrEmpty(TxtBoxUserID.Text) Then
        '    TxtBoxUserID.BackColor = Color.Red
        '    MsgBox("Inputs are empty", MsgBoxStyle.Information, "Information")
        '    TxtBoxUserID.Focus()
        'End If

        'Dim strsql As String = "INSERT INTO users VALUES('" & Me.TxtBoxUserID.Text & "','" & Me.TxtBoxUsername.Text & "')"

        'DBConnect()
        'Dim sqlcmd As New MySqlCommand
        'With sqlcmd
        '    Try
        '        .Connection = DBConnection
        '        .CommandText = strsql
        '        .ExecuteNonQuery()
        '        MsgBox("Data Succesfully Added", MsgBoxStyle.Information, "Information")
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '    End Try
        '    DBDisconnect()
        'End With
        'LoadUsersButton_Click(sender, e)

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click



        Dim strsql As String = "UPDATE users SET username='" & TxtBoxUsername.Text & "' WHERE user_id='" & TxtBoxUserID.Text & "'"

        DBConnect()
        Dim sqlcmd As New MySqlCommand
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandText = strsql
                .ExecuteNonQuery()
                MsgBox("Data Succesfully Updated", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            DBDisconnect()
        End With
        LoadUsersButton_Click(sender, e)

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim strsql As String = "DELETE FROM users WHERE user_id='" & TxtBoxUserID.Text & "'"

        DBConnect()
        Dim sqlcmd As New MySqlCommand
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandText = strsql
                .ExecuteNonQuery()
                MsgBox("Data Succesfully Deleted", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            DBDisconnect()
        End With
        LoadUsersButton_Click(sender, e)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim i As Integer
        i = UsersDataGridView.CurrentRow.Index
        TxtBoxUserID.Text = UsersDataGridView.Item(0, i).Value
        TxtBoxUsername.Text = UsersDataGridView.Item(1, i).Value
    End Sub
End Class
