Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=musicstudio_db;"
        Try
            conn.Open()
            MessageBox.Show("Connected")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub


    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim query As String = "INSERT  INTo tracks_tbl (title, artist, genre, duration) VALUES (@title, @artist, @genre, @duration)"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=musicstudio_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@artist", txtArtist.Text)
                    cmd.Parameters.AddWithValue("@genre", ComboBoxGenre.SelectedItem)
                    cmd.Parameters.AddWithValue("@duration", NumericUpDownDuration.Value)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert succesfully!")



                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE tracks_tbl SET title = @newTitle, artist = @artist, genre = @genre WHERE title = @titleToFind"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=musicstudio_db;")
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)

                    If txtTitle.Text = String.Empty Or txtArtist.Text = String.Empty Then
                        MessageBox.Show("Please enter Fill the Artist and Title.", "Input Error")
                        Return
                    End If

                    If NumericUpDownDuration.Value < 1 Then
                        MessageBox.Show("Please enter a valid duration.", "Input Error")
                        Return
                    End If

                    cmd.Parameters.AddWithValue("@titleToFind", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@newTitle", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@artist", txtArtist)
                    cmd.Parameters.AddWithValue("@genre", ComboBoxGenre.SelectedItem)
                    cmd.Parameters.AddWithValue("@duration", NumericUpDownDuration.Value)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show(rowsAffected & " record(s) updated successfully!")

                        txtTitle.Clear()
                        txtTitle.Clear()
                        txtArtist.Clear()

                        Call BtnRead_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Update failed: No record found with that title.", "Update Status")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        Dim query As String = "SELECT title, artist, genre, duration FROM musicstudio_db.tracks_tbl;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=musicstudio_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Please enter the title of the record to delete.", "Selection Required")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete the record(s) for " & txtTitle.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim query As String = "DELETE FROM tracks_tbl WHERE name = @titleToDelete"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=musicstudio_db;")
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@titleToDelete", txtTitle.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show(rowsAffected & " record(s) deleted successfully!")

                        txtTitle.Clear()
                        txtTitle.Clear()
                        txtArtist.Clear()

                        Call BtnRead_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Delete failed: No record found with that title.", "Delete Status")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
        End Try
    End Sub
End Class
