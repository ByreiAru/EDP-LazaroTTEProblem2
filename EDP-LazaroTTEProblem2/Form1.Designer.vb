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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxGenre = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownDuration = New System.Windows.Forms.NumericUpDown()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelete.Location = New System.Drawing.Point(403, 395)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(399, 37)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete Track"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnUpdate.Location = New System.Drawing.Point(403, 351)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(399, 37)
        Me.btnUpdate.TabIndex = 22
        Me.btnUpdate.Text = "Update Track"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'BtnRead
        '
        Me.BtnRead.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnRead.Location = New System.Drawing.Point(-1, 395)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(397, 37)
        Me.BtnRead.TabIndex = 21
        Me.BtnRead.Text = "Load Track"
        Me.BtnRead.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(109, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(663, 134)
        Me.DataGridView1.TabIndex = 20
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnCreate.Location = New System.Drawing.Point(-3, 351)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(399, 37)
        Me.BtnCreate.TabIndex = 19
        Me.BtnCreate.Text = "Add Track"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Genre:"
        '
        'txtArtist
        '
        Me.txtArtist.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtArtist.Location = New System.Drawing.Point(141, 241)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(631, 20)
        Me.txtArtist.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Artist:"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtTitle.Location = New System.Drawing.Point(141, 215)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(631, 20)
        Me.txtTitle.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Title:"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonConnect.Location = New System.Drawing.Point(-3, 38)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(106, 133)
        Me.ButtonConnect.TabIndex = 12
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Duration:"
        '
        'ComboBoxGenre
        '
        Me.ComboBoxGenre.FormattingEnabled = True
        Me.ComboBoxGenre.Items.AddRange(New Object() {"Pop", "Rock", "Jazz", "Hip-Hop", "Classical"})
        Me.ComboBoxGenre.Location = New System.Drawing.Point(140, 268)
        Me.ComboBoxGenre.Name = "ComboBoxGenre"
        Me.ComboBoxGenre.Size = New System.Drawing.Size(632, 21)
        Me.ComboBoxGenre.TabIndex = 26
        '
        'NumericUpDownDuration
        '
        Me.NumericUpDownDuration.Location = New System.Drawing.Point(140, 296)
        Me.NumericUpDownDuration.Name = "NumericUpDownDuration"
        Me.NumericUpDownDuration.Size = New System.Drawing.Size(632, 20)
        Me.NumericUpDownDuration.TabIndex = 27
        '
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TxtID.Location = New System.Drawing.Point(140, 189)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(631, 20)
        Me.TxtID.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Id:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownDuration)
        Me.Controls.Add(Me.ComboBoxGenre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArtist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxGenre As ComboBox
    Friend WithEvents NumericUpDownDuration As NumericUpDown
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label5 As Label
End Class
