<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(23), CByte(32), CByte(42))
        Button1.Location = New Point(578, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 55)
        Button1.TabIndex = 0
        Button1.Text = ">"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(23), CByte(32), CByte(42))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(52, 82)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(576, 214)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(23), CByte(32), CByte(42))
        Label1.Location = New Point(52, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 38)
        Label1.TabIndex = 2
        Label1.Text = "Muebleria San Rafael"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(668, 322)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label

End Class
