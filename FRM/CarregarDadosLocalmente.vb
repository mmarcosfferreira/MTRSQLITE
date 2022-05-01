

Module CarregarDadosLocalmenteListview
   Public info5 As Notifyicone_PopupNotifier
   Public Sub CarregarDadosLocalmenteListview(ByVal DiretoriodoArquivo As String, LV As ListView)
	 Dim SR As IO.StreamReader
	 LV.Items.Clear()

	 Try
	    If My.Computer.FileSystem.FileExists(DiretoriodoArquivo) Then

		  SR = My.Computer.FileSystem.OpenTextFileReader(DiretoriodoArquivo)
		  Dim Array() As String

		  Do While Not SR.EndOfStream
			Dim lvi As New ListViewItem
			Array = SR.ReadLine.Split(Chr(9))
			lvi.Text = Array(0).ToString

			lvi.SubItems.Add(Array(1).ToString)
			lvi.SubItems.Add(Array(2).ToString)
			lvi.SubItems.Add(Array(3).ToString)
			lvi.SubItems.Add(Array(4).ToString)
			lvi.SubItems.Add(Array(5).ToString)
			lvi.SubItems.Add(Array(6).ToString)
			lvi.SubItems.Add(Array(7).ToString)
			lvi.SubItems.Add(Array(8).ToString)
			lvi.SubItems.Add(Array(9).ToString)
			lvi.SubItems.Add(Array(10).ToString)
			LV.Items.Add(lvi)

		  Loop
		  ' TextBoxMTRobservação.AutoCompleteCustomSource.Add(lvi.SubItems(3).Text)
		  SR.Close()


	    End If

	 Catch ex As Exception
	    MsgBox(ex.Message.ToString())
	    '  Exit Sub
	 End Try
   End Sub

End Module
