Module Excluir_item_selecionado_com_delete
   Public Sub Excluir_item_selecionado_com_delete(ByVal lV As ListView, e As KeyEventArgs)
	 If e.KeyCode = Keys.Delete Then

	    If lV.SelectedItems.Count > 0 Then





		  Dim cont As Integer = 0
		  If MsgBox("Deletar seleção de item's'?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Cuidado") = DialogResult.Yes Then 'MsgBoxResult.Yes Then

			For Each IT As ListViewItem In lV.SelectedItems

			   IT.Remove()
			   cont += 1
			Next
			MsgBox("Você excluiu " & cont & " registros da lista!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informação")




		  Else

			Exit Sub

		  End If



	    End If


	 End If





   End Sub


End Module
