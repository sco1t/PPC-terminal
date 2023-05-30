Public Class Form2

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If Not Form1.SerialPort1.IsOpen And Not ComboBox2.Text = "" And Not ComboBox1.Text = "" Then


            With Form1.SerialPort1
                .BaudRate = ComboBox2.Text
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With

            If ComboBox1.Text = "Auto" Then
                For Each sp As String In ComboBox1.Items
                    Form1.SerialPort1.PortName = sp
                    On Error GoTo skip
                    Form1.SerialPort1.Open()

                    Exit For
skip:
                Next

            Else
                On Error GoTo skip2
                Form1.SerialPort1.PortName = ComboBox1.Text
                Form1.SerialPort1.Open()
skip2:
            End If


            If Form1.SerialPort1.IsOpen Then
                Form1.TextBox1.Text = " Connected to ." & Form1.SerialPort1.PortName & vbCrLf
            Else
                Form1.TextBox1.Text = " Connection failed :( Maybe the port's in use." & vbCrLf
            End If
        Else
            Form1.TextBox1.Text = "Port already open"
        End If
        Hide()
        Form1.Focus()
        Form1.Show()
    End Sub



    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Process.Start("\Windows\ctlpnl.exe", "cplmain.cpl, 23, 0")
    End Sub
End Class