Public Class Form2

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If Not Form1.SerialPort1.IsOpen And Not ComboBox2.Text = "" And Not ComboBox1.Text = "" Then
            'Form1.SerialPort1.BaudRate = ComboBox2.Text
            'Form1.SerialPort1.PortName = ComboBox1.Text


            Try
                With Form1.SerialPort1
                    .PortName = ComboBox1.Text
                    .BaudRate = ComboBox2.Text
                    .Parity = IO.Ports.Parity.None
                    .DataBits = 8
                    .StopBits = IO.Ports.StopBits.One
                End With
                Form1.SerialPort1.Open()

               

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            If Form1.SerialPort1.IsOpen Then
                Form1.TextBox1.Text = " Connected." & vbCrLf
            Else
                Form1.TextBox1.Text = " Connection failed :( Maybe the port's in use." & vbCrLf
            End If
            'Form1.SerialPort1.Open()
            'Form1.TextBox1.Text = Form1.TextBox1.Text & "Port settings updated" & vbCrLf
        Else
            Form1.TextBox1.Text = "Port already open"
        End If
        Hide()
        Form1.Focus()
        Form1.Show()
    End Sub

    Private Sub Form2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        ComboBox1.Items.Clear()
        ComboBox2.Text = Form1.SerialPort1.BaudRate
        ComboBox1.Text = Form1.SerialPort1.PortName
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Process.Start("\Windows\ctlpnl.exe", "cplmain.cpl, 23, 0")
    End Sub
End Class