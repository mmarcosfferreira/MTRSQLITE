'Imports Media_Manual
'Imports System.Management
'Imports System.Management.Instrumentation

Public Class FrmPrincipal


   'Dim FrmMTR_ As FrmMTR = Nothing
   'Dim FrmEstimative_ As FrmEstimativaManual = Nothing
   'Dim Frmalterardata_ As FrmAlterardataehora = Nothing
   'Dim Frmprincipall_ As FrmPrincipal = Nothing
   'Dim Frmpesoliquido_ As Frmpesoliquido = Nothing
   'Dim Frmsomarhoras_ As FrmSomarHoras = Nothing


   <CodeAnalysis.SuppressMessage("Qualidade do Código", "IDE0067:Descartar objetos antes de perder o escopo", Justification:="<Pendente>")>
   Private Sub ControleDeMTRToolStripMenuItem_Click(sender As Object, e As EventArgs)


	 'If FrmMTR_ Is Nothing Then
	 '    Dim I As New FrmMTR
	 '    Hide()
	 '    I.Show()
	 'Else
	 '    Dim I As New FrmMTR
	 '    Hide()
	 '    I.Focus()
	 'End If


	 Hide()
	 FrmMTR.Show()

   End Sub

   Private Sub SomarHorasToolStripMenuItem_Click(sender As Object, e As EventArgs)
	 Hide()
	 FrmSomarHoras.Show()
   End Sub




   <CodeAnalysis.SuppressMessage("Qualidade do Código", "IDE0067:Descartar objetos antes de perder o escopo", Justification:="<Pendente>")>
   Private Sub AlterarADataDoComputadorToolStripMenuItem_Click(sender As Object, e As EventArgs)


	 Try

	    Hide()
	    FrmAlterardataehora.Show()

	 Catch ex As Exception
	    ex.Message.ToString()
	    Exit Sub
	 End Try
   End Sub

   Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	 Dim J As New FrmMTR

	 Card1.Visible = False
	 Card2.Visible = False
	 RadioButon.Value = False


	 Timer1.Start()

	 Label5.Text = "Versão da Build do Windows: " & Environment.Version.Build
	 Label6.Text = "Quantidade de Nucleos: " & Environment.ProcessorCount
	 Label1.Text = "Usuario: " + UsuarioLogado3()
	 Dim y As New Internet
	 Label3.Text = "Local Host: " & y.Endereço_de_Host & "  Ip Local: " & y.Endereço_de_Ip_local
	 Label4.Text = Today & " " & TimeString
	 Label7.Text = My.Computer.Info.OSFullName & " " & My.Computer.Info.OSPlatform

	 ' Call Shell("C:\Windows\System32\msinfo32.exe", vbNormalFocus)
	 Label2.Text = "Licenciado para: Vital Engenharia Ambiental"
	 Activate()


   End Sub

   Public Shared Function UsuarioLogado3()
	 Dim i As Object = CreateObject("Wscript.network")
	 Dim j As Object = i.username()
	 UsuarioLogado3 = j
	 Return UsuarioLogado3
   End Function

   Private Sub MediaDePesagemManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
	 Hide()
	 FrmEstimativaManual.Show()
   End Sub

   Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
	 Label4.Text = Today & " " & TimeString
   End Sub

   Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	 'If MessageBox.Show("Deseja sair da aplicação?", "...Atenção... ", MessageBoxButtons.YesNo) = DialogResult.Yes Then

	 '    Internet.FTP_Upload("C:\MTR\Principal\BD\BancoMTR.txt",
	 '                        "ftp://ftpupload.net/htdocs/BancoMTR.txt",
	 '                        "epiz_25111379",
	 '                        "FERREIRAMARCOS")

	 '    If FrmMTR.jjj.RadioButtonServer.Checked = True Then

	 '        Internet.FTP_Upload(Application.StartupPath & "\BancoMTR.txt",
	 '                                             "ftp://files.000webhost.com/public_html/BancoMTR.txt",
	 '                                            "marcosferreiraa",
	 '                                              "Senha0789")
	 '        Await Task.Delay(5000)
	 '    Else
	 '        FrmMTR.SalvarDadosLocalmente()
	 '    End If

	 '    Close()
	 '    Dispose()
	 'Else
	 '    e.Cancel = True
	 'End If


   End Sub

   Private Sub RadioButon_OnValueChange(sender As Object, e As EventArgs) Handles RadioButon.OnValueChange
	 If RadioButon.Value = True Then

	    'Card1.Visible = True
	    'Card2.Visible = True

	    With Transition
		  .ShowSync(Card1)

	    End With
	    BunifuTransition1.ShowSync(Card2)
	 Else
	    Transition.HideSync(Card1)
	    Transition.HideSync(Card2)
	 End If
   End Sub

   Friend Sub Anim_hide(ByVal Tipo_anim As BunifuAnimatorNS.AnimationType)
	 With Transition
	    Transition.HideSync(Me)
	    .Interval = 1
	    .MaxAnimationTime = 3500
	    .TimeStep = 0.01
	    .AnimationType = Tipo_anim

	 End With
   End Sub

   Private Async Sub BT1_Click(sender As Object, e As EventArgs) Handles BT1.Click

	 Try
	    If Card1.Visible = True Then
		  Await Task.Delay(100)
		  BunifuTransition1.HideSync(Card1)
	    Else
		  Await Task.Delay(100)
		  BunifuTransition1.ShowSync(Card1)
	    End If
	 Catch ex As Exception
	    ex.Message.ToString()
	 End Try

   End Sub

   Private Sub BT2_Click(sender As Object, e As EventArgs) Handles BTConfiguracao.Click
	 Hide()
	 FrmMTR.Show()
	 'Await Task.Delay(100)
	 'BunifuTransition4.HideSync(Me)
	 'Await Task.Delay(100)
	 'BunifuTransition5.ShowSync(FrmMTR)
	 ' AppActivate("FrmMTR")
	 'Await Task.Delay(100)
	 FrmMTR.Activate()
   End Sub

   Private Sub BT3_Click(sender As Object, e As EventArgs)
	 BunifuTransition2.HideSync(Me)
	 FrmAlterardataehora.Show()
   End Sub

   Private Sub BT4_Click(sender As Object, e As EventArgs)
	 BunifuTransition3.HideSync(Me)
	 FrmSomarHoras.ShowDialog()
   End Sub

   Private Sub BT6_Click(sender As Object, e As EventArgs)
	 MsgBox("Recurso bloqueado pelo administrador do sistema", MsgBoxStyle.Exclamation, "Info!!! ")
   End Sub

   Private Async Sub FrmPrincipal_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp




	 If e.KeyValue = Keys.F3 Then
	    Opacity = 0
	 ElseIf e.KeyValue = Keys.F4 Then
	    Opacity = 100 / 100

	 ElseIf e.KeyValue = Keys.Escape Then
	    Close()
	 ElseIf e.KeyValue = Keys.Right Then

	    RadioButon.Value = True

	 ElseIf e.KeyValue = Keys.Left Then
	    RadioButon.Value = False



	 ElseIf e.KeyValue = Keys.Down Then

	    Hide()
	    Await Task.Delay(100)
	    FrmMTR.Show()
	    ' BunifuTransition2.ShowSync(FrmMTR)

	    '  MsgBox("Saindo da aplicação!", MsgBoxStyle.Information, "Confirmando fechamento!")

	    'If MessageBox.Show("Deseja sair da aplicação?", "...Atenção... ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
	    '    Application.Exit()
	    'End If

	    'Internet.FTP_Upload("C:\MTR\Principal\BD\BancoMTR.txt",
	    '                    "ftp://ftpupload.net/htdocs/BancoMTR.txt",
	    '                    "epiz_25111379",
	    '                    "FERREIRAMARCOS")

	    'Application.ExitThread()

	 End If




	 'Await Task.Delay(1000)
	 FrmMTR.Activate()


   End Sub


End Class

