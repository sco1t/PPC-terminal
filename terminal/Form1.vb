Imports System
Imports System.IO.Ports
Imports System.Threading
Imports System.Threading.Thread


Public Class Form1


    Dim RXbyte As String

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If SerialPort1.IsOpen Then

            SerialPort1.DiscardInBuffer()



            SerialPort1.Close()
        End If

        Form2.Show()
        Form2.ComboBox1.Items.Clear()

        For Each sp As String In IO.Ports.SerialPort.GetPortNames
            Form2.ComboBox1.Items.Add(sp)
        Next
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine(TextBox1.Text)
            TextBox2.Text = String.Empty
        Else
            TextBox1.Text = TextBox1.Text & "Port not open :(" & vbCrLf
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim Incoming As String
        Incoming = ""
        Do
            Try
                ' Do Until SerialPort1.BytesToRead = 0
                'Incoming += SerialPort1.ReadExisting

                'Loop


                If SerialPort1.IsOpen Then Incoming = SerialPort1.ReadLine()
            Catch ex As TimeoutException
                Incoming = "Error: Serial Port read timed out."
                Exit Do
            Catch ex As Exception
                Exit Do
                MsgBox(ex.ToString)
            End Try

            If Incoming Is Nothing Then
                Exit Do
            Else

                If TextBox1.InvokeRequired Then

                    RXbyte = Incoming
                    Me.Invoke(New Action(AddressOf Display))

                Else
                    If TextBox1.TextLength > 1000 Then TextBox1.Text = ""
                    TextBox1.SelectionStart = 0 'TextBox1.TextLength
                    TextBox1.SelectedText = Incoming & vbCrLf

                End If

            End If
        Loop


    End Sub

    Private Sub Display()
        If TextBox1.TextLength > 1000 Then TextBox1.Text = ""

        TextBox1.SelectionStart = 0 'TextBox1.TextLength
        TextBox1.SelectedText = RXbyte & vbCrLf
        'TextBox1.ScrollToCaret()



    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub



    Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Label1.Text = SerialPort1.PortName & " " & SerialPort1.BaudRate
        TextBox2.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If SerialPort1.IsOpen Then
            'SerialPort1.DiscardInBuffer()
            'SerialPort1.DiscardOutBuffer()
            SerialPort1.Close()
        End If

        Label1.Text = SerialPort1.PortName & " " & SerialPort1.BaudRate
        TextBox2.Focus()
    End Sub

   
End Class
