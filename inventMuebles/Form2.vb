Imports System.Data.SqlClient

Public Class Form2
    Dim connectionString As String = "Data Source=DESKTOP-3SLI41N;Initial Catalog=USPG;Persist Security Info=True;User ID=sa;Password=1234"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim sql As String = "INSERT INTO inventmuebles (nombreMueble, tipoMueble, materialMueble, colorMueble, alturaMueble, anchoMueble, profundidadMueble, pesoMueble, FechaCompraMueble, precioMueble, ubicacionMueble, notasMueble) VALUES (@nombreMueble, @tipoMueble, @materialMueble, @colorMueble, @alturaMueble, @anchoMueble, @profundidadMueble, @pesoMueble, @FechaCompraMueble, @precioMueble, @ubicacionMueble, @notasMueble )"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@nombreMueble", TextBox1.Text)
                    command.Parameters.AddWithValue("@tipoMueble", TextBox2.Text)
                    command.Parameters.AddWithValue("@materialMueble", TextBox3.Text)
                    command.Parameters.AddWithValue("@colorMueble", TextBox4.Text)
                    command.Parameters.AddWithValue("@alturaMueble", TextBox5.Text)
                    command.Parameters.AddWithValue("@anchoMueble", TextBox6.Text)
                    command.Parameters.AddWithValue("@profundidadMueble", TextBox7.Text)
                    command.Parameters.AddWithValue("@pesoMueble", TextBox8.Text)
                    command.Parameters.AddWithValue("@FechaCompraMueble", TextBox9.Text)
                    command.Parameters.AddWithValue("precioMueble", TextBox10.Text)
                    command.Parameters.AddWithValue("@ubicacionMueble", TextBox11.Text)
                    command.Parameters.AddWithValue("@notasMueble", TextBox12.Text)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Producto registrado correctamente en la base de datos.")

                    Dim form1 As Form1 = CType(Application.OpenForms("Form1"), Form1)
                    If form1 IsNot Nothing Then
                        form1.ActualizarDataGridView()
                    End If

                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox7.Text = ""
                    TextBox8.Text = ""
                    TextBox9.Text = ""
                    TextBox10.Text = ""
                    TextBox11.Text = ""
                    TextBox12.Text = ""

                End Using

                Form1.Show()
                Me.Hide()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar registrar el producto :" & ex.Message)
        End Try
    End Sub
End Class
