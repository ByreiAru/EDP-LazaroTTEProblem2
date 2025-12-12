Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Load data into DataGridView when form loads
        LoadData()
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection("server=localhost;userid=root;password=root;database=musicstudio_db;")
        Try
            conn.Open()
            MessageBox.Show("Connected successfully!")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
    End Sub

    ' CREATE
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim query As String = "INSERT INTO tracks_tbl (title, artist, genre, duration) VALUES (@title, @artist, @genre, @duration)"
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=musicstudio_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    If txtArtist.Text = String.Empty Or txtTitle.Text = String.Empty Then
                        MessageBox.Show("Please fill in the field.", "Input Required")
                        Return
                    End If

                    If NumericUpDownDuration.Value < 1 Then
                        MessageBox.Show("Duration Value should be valid positive integer.", "Input Required")
                        Return
                    End If

                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@artist", txtArtist.Text)
                    cmd.Parameters.AddWithValue("@genre", ComboBoxGenre.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@duration", NumericUpDownDuration.Value)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record inserted successfully!")
                    ClearFields()
                    LoadData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Insert failed: " & ex.Message)
        End Try
    End Sub

    ' READ
    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT id, title, artist, genre, duration FROM tracks_tbl"
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=musicstudio_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Read failed: " & ex.Message)
        End Try
    End Sub

    ' UPDATE by ID
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Please enter the ID of the record to update.", "Input Required")
            Return
        End If

        Dim query As String = "UPDATE tracks_tbl SET title=@title, artist=@artist, genre=@genre, duration=@duration WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=musicstudio_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    If txtArtist.Text = String.Empty Or txtTitle.Text = String.Empty Then
                        MessageBox.Show("Please fill in the field.", "Input Required")
                        Return
                    End If

                    If NumericUpDownDuration.Value < 1 Then
                        MessageBox.Show("Duration Value should be valid positive integer.", "Input Required")
                        Return
                    End If

                    cmd.Parameters.AddWithValue("@id", TxtID.Text)
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text)
                    cmd.Parameters.AddWithValue("@artist", txtArtist.Text)
                    cmd.Parameters.AddWithValue("@genre", ComboBoxGenre.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@duration", NumericUpDownDuration.Value)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show(rowsAffected & " record(s) updated successfully!")
                        ClearFields()
                        LoadData()
                    Else
                        MessageBox.Show("Update failed: No record found with that ID.", "Update Status")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
        End Try
    End Sub

    ' DELETE by ID
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Please enter the ID of the record to delete.", "Input Required")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete the record with ID " & txtID.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim query As String = "DELETE FROM tracks_tbl WHERE id=@id"

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=musicstudio_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show(rowsAffected & " record(s) deleted successfully!")
                        ClearFields()
                        LoadData()
                    Else
                        MessageBox.Show("Delete failed: No record found with that ID.", "Delete Status")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

    ' Helper to clear fields
    Private Sub ClearFields()
        txtID.Clear()
        txtTitle.Clear()
        txtArtist.Clear()
        ComboBoxGenre.SelectedIndex = -1
        NumericUpDownDuration.Value = 1
    End Sub
End Class
