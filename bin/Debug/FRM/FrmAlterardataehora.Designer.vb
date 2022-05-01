<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlterardataehora
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlterardataehora))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblhoracorrendo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerHora = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.BtatualizarcomNet = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1000
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 350
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'NumericUpDown1
        '
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Green
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, resources.GetString("NumericUpDown1.ToolTip"))
        '
        'lblhoracorrendo
        '
        resources.ApplyResources(Me.lblhoracorrendo, "lblhoracorrendo")
        Me.lblhoracorrendo.BackColor = System.Drawing.Color.Transparent
        Me.lblhoracorrendo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblhoracorrendo.ForeColor = System.Drawing.Color.Green
        Me.lblhoracorrendo.Name = "lblhoracorrendo"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Name = "Label2"
        '
        'DateTimePickerData
        '
        Me.DateTimePickerData.CalendarForeColor = System.Drawing.Color.Transparent
        Me.DateTimePickerData.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DateTimePickerData.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerData.CalendarTitleForeColor = System.Drawing.Color.Transparent
        Me.DateTimePickerData.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.DateTimePickerData, "DateTimePickerData")
        Me.DateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.ShowUpDown = True
        '
        'DateTimePickerHora
        '
        resources.ApplyResources(Me.DateTimePickerHora, "DateTimePickerHora")
        Me.DateTimePickerHora.CalendarForeColor = System.Drawing.Color.Transparent
        Me.DateTimePickerHora.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DateTimePickerHora.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.DateTimePickerHora.CalendarTitleForeColor = System.Drawing.Color.Transparent
        Me.DateTimePickerHora.CalendarTrailingForeColor = System.Drawing.Color.Transparent
        Me.DateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerHora.Name = "DateTimePickerHora"
        Me.DateTimePickerHora.ShowUpDown = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Name = "Label4"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'CheckBox2
        '
        resources.ApplyResources(Me.CheckBox2, "CheckBox2")
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'BtatualizarcomNet
        '
        Me.BtatualizarcomNet.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtatualizarcomNet, "BtatualizarcomNet")
        Me.BtatualizarcomNet.Name = "BtatualizarcomNet"
        Me.BtatualizarcomNet.UseVisualStyleBackColor = False
        '
        'FrmAlterardataehora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblhoracorrendo)
        Me.Controls.Add(Me.BtatualizarcomNet)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerData)
        Me.Controls.Add(Me.DateTimePickerHora)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAlterardataehora"
        Me.Opacity = 0.95R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.TransparencyKey = System.Drawing.Color.Blue
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents lblhoracorrendo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerData As DateTimePicker
    Friend WithEvents DateTimePickerHora As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BtatualizarcomNet As Button
End Class
