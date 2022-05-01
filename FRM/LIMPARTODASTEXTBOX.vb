Module LIMPAR_CONTROLES
   Public Sub LIMPAR_CONTROLES(ControlP As Control)

	 Dim CT As Control
	 Application.DoEvents()

	 For Each CT In ControlP.Controls


	    If TypeOf CT Is TextBox Then  'se o tipo da variavel for compativel com a sua classe ou estrutura

		  DirectCast(CT, TextBox).Text = String.Empty

	    ElseIf TypeOf CT Is ComboBox Then

		  DirectCast(CT, ComboBox).SelectedIndex = -1

	    ElseIf TypeOf CT Is TextboxMonetário Then

		  DirectCast(CT, TextboxMonetário).Text = String.Empty

	    ElseIf TypeOf CT Is Guna.UI2.WinForms.Guna2ComboBox Then

		  DirectCast(CT, Guna.UI2.WinForms.Guna2ComboBox).SelectedIndex = -1

	    ElseIf CT.Controls.Count > 0 Then

		  LIMPAR_CONTROLES(CT)

	    End If

	 Next

   End Sub
End Module
