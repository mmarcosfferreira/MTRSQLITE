
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Security.Principal

'<Assembly: NeutralResourcesLanguage("pt-BR")>
Public Class FrmAlterardataehora
   Public Sub New()
	 ' Esta chamada é requerida pelo designer.
	 InitializeComponent()
	 ' Adicione qualquer inicialização após a chamada InitializeComponent().
   End Sub
   Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
	 With lblhoracorrendo
	    lblhoracorrendo.ForeColor = Color.Green
	    lblhoracorrendo.BackColor = Color.WhiteSmoke
	 End With
	 lblhoracorrendo.Text = TimeString
   End Sub
   Public Shared Function GetNetworkTime() As Date
	 'Servidor nacional para melhor latência
	 Const ntpServer As String = "a.ntp.br"
	 ' Tamanho da mensagem NTP - 16 bytes (RFC 2030)
	 Dim ntpData = New Byte(47) {}
	 'Indicador de Leap (ver RFC), Versão e Modo
	 ntpData(0) = &H1B
	 'LI = 0 (sem warnings), VN = 3 (IPv4 apenas), Mode = 3 (modo cliente)
	 Dim addresses = Dns.GetHostEntry(ntpServer).AddressList
	 '123 é a porta padrão do NTP
	 Dim ipEndPoint = New IPEndPoint(addresses(0), 123)
	 'NTP usa UDP
	 Dim socket = New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
	 socket.Connect(ipEndPoint)
	 'Caso NTP esteja bloqueado, ao menos nao trava o app
	 socket.ReceiveTimeout = 3000
	 socket.Send(ntpData)
	 socket.Receive(ntpData)
	 socket.Close()

	 'Offset para chegar no campo "Transmit Timestamp" (que é
	 'o do momento da saída do servidor, em formato 64-bit timestamp
	 Const serverReplyTime As Byte = 40

	 'Pegando os segundos
	 Dim intPart As ULong = BitConverter.ToUInt32(ntpData, serverReplyTime)

	 'e a fração de segundos
	 Dim fractPart As ULong = BitConverter.ToUInt32(ntpData, serverReplyTime + 4)

	 'Passando de big-endian pra little-endian
	 intPart = SwapEndianness(intPart)
	 fractPart = SwapEndianness(fractPart)
	 Dim milliseconds = (intPart * 1000) + ((fractPart * 1000) / &H100000000L)
	 'Tempo em **UTC**
	 Dim networkDateTime = (New DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(CLng(milliseconds))
	 Return networkDateTime.ToLocalTime()
   End Function
   Private Shared Function SwapEndianness(x As ULong) As UInteger
	 Return ((x And &HFF) << 24) + ((x And &HFF00) << 8) + ((x And &HFF0000) >> 8) + ((x And &HFF000000UI) >> 24)
   End Function
   Private Sub Notifications(ByVal Control As NotifyIcon, ByVal ControlVisible As Boolean)
	 TopMost = True
	 Control.ShowBalloonTip(200)
	 Control.Visible = ControlVisible
	 Control.ShowBalloonTip(500, "SIB", "By Marcos Ferreira", ToolTipIcon.Info)
   End Sub
   Private Sub NumericUpDown1_MouseHover(sender As Object, e As EventArgs)
	 Dim I As ToolTip = ToolTip1
	 Dim g As String = "Alterar a Opacidade do formulário!"
	 I.ToolTipTitle = "Informativo"
	 I.SetToolTip(NumericUpDown1, g)
   End Sub
   Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
	 Try
	    If Me.Visible = True Then
		  Me.WindowState = FormWindowState.Normal
		  NotifyIcon1.Visible = False
	    End If
	 Catch ex As Exception
	    Notifications(NotifyIcon1, False)
	 End Try

   End Sub

   Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
	 Visible = True
	 Me.TopMost = True
   End Sub

   Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
	 'Try
	 '    If Me.WindowState = FormWindowState.Minimized Then
	 '        Me.Visible = False
	 '        Notifications(NotifyIcon1, True)

	 '    End If
	 'Catch ex As Exception
	 '    Notifications(NotifyIcon1, True)
	 'End Try

   End Sub

   Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs)
	 Opacity = Val(NumericUpDown1.Value / 100)
   End Sub


   Private Sub Timer3_Tick(sender As Object, Text As EventArgs) Handles Timer3.Tick

	 Dim J As Date = Today.Date

	 Label3.Text = J

	 If Label2.Text = "Data do PC Local" Then
	    Label2.Text = "Data do PC Local."

	 Else
	    If Label2.Text = "Data do PC Local." Then
		  Label2.Text = "Data do PC Local.."

	    Else
		  If Label2.Text = "Data do PC Local.." Then
			Label2.Text = "Data do PC Local..."
		  Else
			If Label2.Text = "Data do PC Local..." Then
			   Label2.Text = "Data do PC Local...."
			Else
			   Label2.Text = "Data do PC Local"
			End If
		  End If

	    End If


	 End If

	 'dando um delay (restardando 1 segundo)
	 'Thread.Sleep(1000)
	 'Application.DoEvents()




   End Sub


   Private Sub Lblhoracorrendo_MouseHover(sender As Object, e As EventArgs)
	 Dim I As ToolTip = ToolTip1
	 Dim g As String = "Horário atual do Computador!"
	 I.ToolTipTitle = "Informativo"
	 I.SetToolTip(lblhoracorrendo, g)
   End Sub

   Private Sub FrmAlterardataehora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 CheckBox2.CheckState = CheckState.Indeterminate
	 Dim mPrincipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent)
	 If mPrincipal.IsInRole(WindowsBuiltInRole.Administrator) = False Then
	    MessageBox.Show("Você precisa executar a aplicação usando a opção 'run as administrator'", "É preciso ser uma administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
	 Else
	    MessageBox.Show("Você pode executar a aplicação com direitos de administrador em modo elevado", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information)
	 End If



	 Try
	    ' Label2.Text = "Data do PC Local"
	    KeyPreview = True
	    NumericUpDown1.Value = 100
	    ' CheckBox1.Checked = True
	    Notifications(NotifyIcon1, True)
	    Dim now1 As Date = Date.Now
	    lblhoracorrendo.Text = Date.Now.ToLongDateString & "   " & now1.ToShortDateString & ""
	    lblhoracorrendo.Text = TimeString
	    'WindowState = FormWindowState.Minimized 'inicia minimizado'

	    'Cria registro para iniciar com o windows'
	    Dim FileName As String
	    Dim FilePath As Object
	    Dim RegistryKey As Object
	    FileName = "Alter Data e Hora.exe"
	    FilePath = Path.GetFullPath(FileName)
	    RegistryKey = CreateObject("WScript.Shell")

	    RegistryKey.RegWrite("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\AutoDataHora", FilePath)
	 Catch ex As Exception

	 End Try


	 '   Call Topo(Me)



   End Sub


   Private Sub FrmAlterardataehora_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

	 If e.KeyValue = Keys.F3 AndAlso NumericUpDown1.Value <> 0 Then

	    NumericUpDown1.Value = 0 'Se presionar F3 eo valor do meu objt for diferente de 0 então fique invisivel 
	    e.Handled = True


	 ElseIf e.KeyValue = Keys.F3 AndAlso NumericUpDown1.Value = 0 Then 'Se presionar F3 eo valor do meu objt for = a 0 então fique visivel

	    NumericUpDown1.Value = 100
	    e.Handled = True


	 ElseIf e.KeyValue = Keys.Escape AndAlso MessageBox.Show("Deseja SAIR da aplicação?", "Atenção", MessageBoxButtons.YesNo) = DialogResult.Yes Then
	    Close()

	    e.Handled = True


	 ElseIf Visible = False AndAlso e.KeyValue = Keys.F3 Then
	    Visible = True
	    e.Handled = True


	 ElseIf Visible = True AndAlso e.KeyValue = Keys.F3 Then
	    Visible = False
	 Else
	    Show()
	    e.Handled = False 'Para não bloquear os controles

	 End If

   End Sub



   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
	 'Frmpesoliquido.StartPosition = FormStartPosition.CenterScreen

	 Dim o = Frmpesoliquido

	 If o IsNot Nothing Then 'SE NÃO É VAZIO EU CHAMO
	    o.Show()
	 Else
	    Visible = True 'SE É VAZIO 
	 End If



   End Sub

   Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerData.ValueChanged
	 Today = Date.Parse(DateTimePickerData.Value)
   End Sub

   Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerHora.ValueChanged
	 On Error Resume Next
	 TimeOfDay = DateTimePickerHora.Value
   End Sub

   Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
	 Opacity = Val(NumericUpDown1.Value / 100)

   End Sub

   Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
	 If e.KeyValue = Keys.F3 AndAlso NumericUpDown1.Value <> 0 Then

	    NumericUpDown1.Value = 0 'Se presionar F3 eo valor do meu objt for diferente de 0 então fique invisivel 
	    e.Handled = True

	 ElseIf e.KeyValue = Keys.F3 AndAlso NumericUpDown1.Value = 0 Then 'Se presionar F3 eo valor do meu objt for = a 0 então fique visivel


	    NumericUpDown1.Value = 100
	    e.Handled = True

	 End If
   End Sub

   Private Sub FrmAlterardataehora_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	 If MessageBox.Show("Deseja sair da aplicação?", "...Atenção... ", MessageBoxButtons.YesNo) = DialogResult.No Then

	    e.Cancel = True
	    Exit Sub
	 Else

	    MessageBox.Show(e.CloseReason.ToString)
	    Select Case e.CloseReason
		  Case CloseReason.ApplicationExitCall
		  Case CloseReason.FormOwnerClosing
		  Case CloseReason.MdiFormClosing
		  Case CloseReason.None
		  Case CloseReason.TaskManagerClosing
		  Case CloseReason.UserClosing
		  Case CloseReason.WindowsShutDown
			Close()
	    End Select
	    '   FrmPrincipal.Show()
	 End If

   End Sub





   Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
	 TopMost_.TopMost_(CheckBox2, Me)
   End Sub

   Private Sub BtatualizarcomNet_Click(sender As Object, e As EventArgs) Handles BtatualizarcomNet.Click
	 TimeOfDay = GetNetworkTime()
	 Today = GetNetworkTime()
   End Sub

   Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

   End Sub
End Class
