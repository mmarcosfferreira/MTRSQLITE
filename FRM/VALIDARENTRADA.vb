
Module VALIDARENTRADA
   Public Function VALIDARENTRADA(ByVal CT As Object) As Boolean

	 Dim info7 As New Notifyicone_PopupNotifier
	 If String.IsNullOrEmpty(CT.Text) Then
	    info7.Notifyicone_PopupNotifier(vbNewLine & Chr(9) & "Preencha o campo " & CT.Name & Chr(9) & Chr(9) & Chr(9) & Chr(9) & "    corretamente!", Chr(9) & "   Validação de entrada de dados!", 1100, CT)
	    CT.Focus()
	    Return True
	 End If
	 Return VALIDARENTRADA
   End Function


End Module
