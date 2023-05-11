<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Connect"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(20, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 22)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.Add("300")
        Me.ComboBox2.Items.Add("600")
        Me.ComboBox2.Items.Add("900")
        Me.ComboBox2.Items.Add("1200")
        Me.ComboBox2.Items.Add("2400")
        Me.ComboBox2.Items.Add("4800")
        Me.ComboBox2.Items.Add("9600")
        Me.ComboBox2.Items.Add("19200")
        Me.ComboBox2.Items.Add("38400")
        Me.ComboBox2.Items.Add("57600")
        Me.ComboBox2.Items.Add("115200")
        Me.ComboBox2.Items.Add("230400")
        Me.ComboBox2.Location = New System.Drawing.Point(20, 98)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(197, 22)
        Me.ComboBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.Text = "Available ports"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.Text = "Baud rate"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "BT Manger"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form2"
        Me.Text = "Settings"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
End Class
