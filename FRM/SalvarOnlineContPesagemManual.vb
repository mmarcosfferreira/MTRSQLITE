Imports System.IO

Module SalvarOnlineContPesagemManual
   Public info6 As Notifyicone_PopupNotifier
   Public Async Sub SalvarOnlineContPesagemManual(ByVal Caminho As String, lV As ListView, bt As Button)
	 Try
	    If My.Computer.FileSystem.FileExists(Caminho) Then
		  My.Computer.FileSystem.DeleteFile(Caminho)


		  Dim FS As New FileStream(Caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
		  Dim SW As New StreamWriter(FS)


		  For i As Integer = 0 To lV.Items.Count - 1
			For i2 As Integer = 0 To lV.Items(i).SubItems.Count - 1
			   SW.Write(lV.Items(i).SubItems(i2).Text & Chr(9))
			Next
			SW.Write(Environment.NewLine) 'cria nova linha
		  Next

		  Await Task.Delay(300)

		  SW.Close()
		  'SW.Flush()

		  Await Task.Delay(4000)
		  Await Internet.FTP_Upload(Application.StartupPath & "\BD\Controle_de_Pesagem_Manual.txt",
								"ftp://files.000webhost.com/public_html/Controle_de_Pesagem_Manual.txt",
								"marcosferreiramf",
								"Senha0789")
		  Await Task.Delay(3000)

	    End If
	    '==============================

	 Catch ex As Exception
	    MsgBox("Detalhe: " + ex.TargetSite.ToString())

	 Finally

	 End Try

   End Sub

   Public Async Sub SalvarContPesagemManual(ByVal Caminho As String, lV As ListView, bt As Button)
	 Try
	    If My.Computer.FileSystem.FileExists(Caminho) Then
		  My.Computer.FileSystem.DeleteFile(Caminho)


		  Dim FS As New FileStream(Caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
		  Dim SW As New StreamWriter(FS)


		  For i As Integer = 0 To lV.Items.Count - 1
			For i2 As Integer = 0 To lV.Items(i).SubItems.Count - 1
			   SW.Write(lV.Items(i).SubItems(i2).Text & Chr(9))
			Next
			SW.Write(Environment.NewLine) 'cria nova linha
		  Next

		  Await Task.Delay(300)

		  SW.Close()
		  'SW.Flush()


	    End If
	    '==============================

	 Catch ex As Exception
	    MsgBox("Detalhe: " + ex.TargetSite.ToString())

	 Finally

	 End Try

   End Sub


End Module
