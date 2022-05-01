Public Class TextboxMonetário
   Inherits Guna.UI2.WinForms.Guna2TextBox

   Private SoNumeros As Boolean = True
   Private Soletras As Boolean = False
   Private CasaDecimalAtivada As Boolean = False
   Private SoNumeroSemFormatacao As Boolean = False

   Public Property AtivarSoNumeroSemFormatacao_() As Boolean
	 Get
	    If SoNumeroSemFormatacao = True Then
		  Soletras = False
		  CasaDecimalAtivada = False
	    End If
	    Return SoNumeroSemFormatacao
	 End Get
	 Set(value As Boolean)
	    SoNumeroSemFormatacao = value
	 End Set
   End Property
   Public Property Ativar_so_Numeros() As Boolean

	 Get

	    If Soletras = True And SoNumeros = True Then
		  Return SoNumeros = True And Soletras = False
	    End If

	    Return SoNumeros

	 End Get

	 Set(value As Boolean)
	    SoNumeros = value
	 End Set

   End Property

   Public Property Ativar_so_Letras() As Boolean

	 Get
	    Return Soletras = True
	 End Get

	 Set(value As Boolean)
	    Soletras = value
	 End Set

   End Property

   Public Property Ativar_CasasDecimais() As Boolean
	 Get
	    If Ativar_CasasDecimais = True Then
		  AtivarSoNumeroSemFormatacao_ = False
		  Ativar_so_Letras = False
	    End If

	    Return CasaDecimalAtivada
	 End Get

	 Set(value As Boolean)
	    CasaDecimalAtivada = value
	 End Set

   End Property


   Private Sub TextboxMonetário_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
	 If Ativar_so_Numeros = True Then
	    Ativar_so_Letras = False

	    Select Case e.KeyChar
		  Case Chr(44) ',    asc(",")

			'------------Tratamento para várias vírgulas-------------------------
			If CType(sender, TextboxMonetário).Text = "" And e.KeyChar = Chr(44) Then
			   e.Handled = True
			   Exit Select 'exit select faz com que pule a linha para o fim da instrução
			End If

			'se a textbox já possui um virgula
			If CType(sender, TextboxMonetário).Text.Contains(Chr(44)) And e.KeyChar = Chr(44) Then
			   e.Handled = True
			   Exit Select 'exit select faz com que pule a linha para o fim da instrução
			End If

			e.Handled = False
			 '-------------------------------------------------------------------------------------


			 '----------------Tratamento para não repetir barios Pontos------------
		  Case Chr(46) '  asc(".")

			'Se na textbox estiver vazio e o usuário pressionar a tecla correspondente do ponto, bloqueie então
			If CType(sender, TextboxMonetário).Text = "" And e.KeyChar = Chr(46) Then
			   e.Handled = True
			   Exit Select
			End If


			' se játem um ponto ele bloqueia para nãoter dois pontos
			If CType(sender, TextboxMonetário).Text.Contains(Chr(46)) And e.KeyChar = Chr(46) Then
			   e.Handled = True
			   Exit Select
			End If

			e.Handled = False
		  Case Chr(32) 'space
			e.Handled = False
		  Case Chr(8) 'vbback
			e.Handled = False
		  Case Chr(48), Chr(49), Chr(50), Chr(51), Chr(52), Chr(53), Chr(54), Chr(55), Chr(56), Chr(57) 'numeros de 0 a 9
			e.Handled = False
		  Case Else
			e.Handled = True
	    End Select

	 ElseIf Ativar_so_Letras = False And Ativar_so_Numeros = False Then
	    'FAÇA NADA

	 ElseIf Ativar_so_Letras = True Then
	    Ativar_so_Numeros = False
	    If Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(32) Or e.KeyChar = Chr(8) Then
		  e.Handled = False
	    Else
		  e.Handled = True
	    End If
	 End If
   End Sub
   Private Sub TextboxMonetário_Enter(sender As Object, e As EventArgs) Handles Me.Enter
	 FillColor = Drawing.Color.WhiteSmoke
	 ForeColor = Drawing.Color.Gray
   End Sub

   Private Sub TextboxMonetário_Leave(sender As Object, e As EventArgs) Handles Me.Leave
	 If SoNumeros = True Then
	    If Text.Length > 0 Then
		  If IsNumeric(Me.Text) = False Then 'se n for numrico
			MsgBox("Formato incorreto de número", MsgBoxStyle.Information, "Atenção " & UsuarioLogado.UsuarioLogado)
			Me.Focus()
		  Else 'se for um numero formate ele como um decimal + 2 casas decimais
			If Ativar_CasasDecimais = True Then
			   If SoNumeros = True Then
				 If SoNumeroSemFormatacao = False Then
				    Me.Text = FormatNumber(Convert.ToDouble(Text), 2)
				 Else
				    SoNumeroSemFormatacao = True
				    Text = CInt(Text.Replace(".", "").Replace(",", ""))
				 End If
			   End If
			Else
			   If Ativar_CasasDecimais = False Then
				 If SoNumeros = True Then
				    SoNumeroSemFormatacao = True
				    Text = Text.Replace(".", "").Replace(",", "")
				 Else
				    SoNumeroSemFormatacao = False
				    Text = FormatNumber(Convert.ToDouble(Text), 0)
				 End If
			   End If
			End If
		  End If
	    End If
	 End If
	 FillColor = Drawing.Color.White
	 ForeColor = Drawing.Color.Gray
   End Sub

   Private Sub InitializeComponent()
		Me.SuspendLayout()
		'
		'TextboxMonetário
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.DisabledState.FillColor = System.Drawing.Color.White
		Me.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.DisabledState.Parent = Me
		Me.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.FocusedState.Parent = Me
		Me.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.HoverState.Parent = Me
		Me.Name = "TextboxMonetário"
		Me.ShadowDecoration.Parent = Me
		Me.Size = New System.Drawing.Size(200, 30)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Public Shared Narrowing Operator CType(v As TextboxMonetário) As TextBox
		Throw New NotImplementedException()
	End Operator

	Private Sub TextboxMonetário_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged

	End Sub
End Class
