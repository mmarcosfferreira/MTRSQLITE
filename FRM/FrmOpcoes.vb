Imports System.IO
Imports System.Net

Public Class FRMopcoes
   Private Sub BTend_Click(sender As Object, e As EventArgs) Handles BTend.Click
	 End
   End Sub
   Private Sub BTalterarData_Click(sender As Object, e As EventArgs) Handles BTalterarData.Click

	 Select Case Application.OpenForms.OfType(Of FrmAlterardataehora)().Count
	    Case Is > 0
		  Application.OpenForms.OfType(Of FrmAlterardataehora)().First().Focus()
	    Case Else
		  FrmAlterardataehora.Show()
	 End Select


   End Sub
   Private Sub BTMemorando_Click(sender As Object, e As EventArgs) Handles BTMemorando.Click
	 Select Case Application.OpenForms.OfType(Of FRMmemorando)().Count
	    Case Is > 0
		  Application.OpenForms.OfType(Of FRMmemorando)().First().Focus()
	    Case Else
		  FRMmemorando.Show()
		  FRMControlePesagemManual_.Close()
	 End Select
   End Sub
   Private Sub BTControleInfratores_Click(sender As Object, e As EventArgs) Handles BTControleInfratores.Click
	 Select Case Application.OpenForms.OfType(Of FrmInfratores)().Count
	    Case Is > 0
		  Application.OpenForms.OfType(Of FrmInfratores)().First().Focus()
	    Case Else
		  FrmInfratores.Show()
		  FRMControlePesagemManual_.Close()
	 End Select
   End Sub
   Private Sub BTConfiguraçãoFeam_Click(sender As Object, e As EventArgs) Handles BTConfiguraçãoFeam.Click
	 FRMConfiguracaoFeam.ShowDialog()
	 FRMControlePesagemManual_.Close()
   End Sub

   Private Sub BTcontrolePesagemManual_Click(sender As Object, e As EventArgs) Handles BTcontrolePesagemManual.Click
	 FRMControlePesagemManual_.Visible = True

   End Sub

   Private Sub btsair_Click(sender As Object, e As EventArgs) Handles btsair.Click
	 Close()
   End Sub

   Private Async Sub BtRestore_Click(sender As Object, e As EventArgs) Handles BtRestore.Click
	 Try
	    'request_.AuthenticationLevel = Security.AuthenticationLevel.MutualAuthRequired
	    'request_.Proxy = Nothing
	    ' faz uma requisição web
	    Dim request_ As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://files.000webhost.com/public_html/BDVITAL.db"), System.Net.FtpWebRequest)
	    request_.Credentials = New System.Net.NetworkCredential("marcosferreiramf", "Senha0789")
	    request_.Method = WebRequestMethods.Ftp.DownloadFile
	    request_.KeepAlive = True

	    Dim Response = DirectCast(Await request_.GetResponseAsync, System.Net.FtpWebResponse) ' transforma a var em um objeto de 
	    Dim R = Response.GetResponseStream

	    Using MemoryStream = New MemoryStream()
		  Await R.CopyToAsync(MemoryStream) ''R.CopyTo (MemoryStream)
		  Dim ConteudodoArquivo = MemoryStream.ToArray
		  File.WriteAllBytes(Application.StartupPath & "\BD\BDVITAL.db", ConteudodoArquivo)
	    End Using

	    Dim Mensagem As String = "  Banco de dados carregado do servidor corretamente!! " & Chr(13) & "-------Transferência Concluída com êxito-------" & Chr(13) &
		  "Informações do servidor: " & Response.StatusDescription

	    Dim Titulo As String = Chr(9) & "Transferencia concluída"
	    Dim Texto_associado_ao_Controle As String = Mensagem
	    InputBox_Personalizado("ATENÇÃO!" + vbNewLine + Mensagem, Titulo, Nothing, False, False)
	    Response.Close()
	    Await Task.CompletedTask
	 Catch ex As Exception
	    Finalize()
	 End Try
	 FrmMTR.Show()
   End Sub

   'Private Sub FRMOPCOES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
   '    CHKautosave.Checked = My.Settings.AutoSave
   'End Sub

   'Private Sub CHKautosave_CheckedChanged(sender As Object, e As EventArgs) Handles CHKautosave.CheckedChanged
   '    Select Case CHKautosave.Checked
   '        Case True
   '            My.Settings.AutoSave = True
   '            My.Settings.Save()
   '        Case Else
   '            My.Settings.AutoSave = False
   '            My.Settings.Save()
   '    End Select
   'End Sub
End Class