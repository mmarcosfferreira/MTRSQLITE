Imports System.IO
Public Class FrmEstimativaManual
   Private Sub FrmEstimativaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 Activate()
	 KeyPreview = True
	 RichTextBoxSaida.ReadOnly = True
	 ColocarFormularionoTopo.Topo(sender)
   End Sub



   Public Shared Sub Sair(Esc As Form)
	 Esc.Close()
   End Sub



   Public Sub Limpar(ByVal Objeto As Control)

	 pb = 0
	 pt = 0
	 pl = 0

	 Try
	    Dim ctl As Control
	    For Each ctl In Objeto.Controls
		  If TypeOf ctl Is TextBox Then
			DirectCast(ctl, TextBox).Text = String.Empty

		  ElseIf TypeOf ctl Is ComboBox Then
			DirectCast(ctl, ComboBox).Text = String.Empty

		  ElseIf TypeOf ctl Is MaskedTextBox Then
			DirectCast(ctl, MaskedTextBox).Text = String.Empty

		  ElseIf TypeOf ctl Is RichTextBox Then
			DirectCast(ctl, RichTextBox).Text = String.Empty

		  ElseIf ctl.Controls.Count > 0 Then
			Limpar(ctl)
		  End If
	    Next

	 Catch ex As Exception
	    MessageBox.Show("Detalhes do erro: " & ex.Message.ToString())
	 End Try

	 LblBruto.Text = ""
	 LblTara.Text = ""
	 Lblliquido.Text = ""

   End Sub


   Private pb As Double = 0
   Private pt As Double = 0
   Private pl As Double = 0
   Private rs As Double = 0
   Dim FrequenciaLbl As Int32 = 0
   Private Media As Double = 0


   Private Sub Btestimativa_Click(sender As Object, e As EventArgs) Handles Btestimativa.Click

	 Try
	    If String.IsNullOrEmpty(TxtBruto.Text) Then
		  Focuss(TxtBruto)
		  Return
	    ElseIf String.IsNullOrEmpty(TxtBruto.Text) AndAlso String.IsNullOrEmpty(TxtTara.Text) Then
		  MsgBox("Antes de calcular, insira valores na caixa de entrada")
		  Focuss(TxtBruto)
		  Return
	    ElseIf String.IsNullOrEmpty(TxtTara.Text) Then
		  MsgBox("Antes de calcular, insira valores na caixa de entrada")
		  Focuss(TxtTara)
		  Return
	    ElseIf String.IsNullOrEmpty(Txtpreco.Text) Then
		  MsgBox("Insira o preço da tonelada!", MsgBoxStyle.Information, "Estimativa")
		  Txtpreco.Focus()
		  Return
	    Else

		  pb += Val(TxtBruto.Text)
		  pt += Val(TxtTara.Text)
		  pl = Val(pb) - Val(pt)
		  FrequenciaLbl += 1
		  Media = ((pl * Txtpreco.Text) / 1000) / FrequenciaLbl
		  TxtLiquido.Text = TxtBruto.Text - TxtTara.Text

		  LblContagem.Text = FrequenciaLbl

		  LblBruto.Text = "P.Bruto: " & pb / FrequenciaLbl
		  LblTara.Text = "P.Tara: " & pt / FrequenciaLbl
		  Lblliquido.Text = "P.Liquido: " & pl / FrequenciaLbl
		  FormatNumber(Media, 2)
		  Lblestimativa.Text = "Média a pagar: " & Convert.ToDecimal(Media) / 10

		  rs = (Val(TxtLiquido.Text * Val(Txtpreco.Text) / 1000))
		  LblValor.Text = "valor R$ " & rs

		  RichTextBoxSaida.Text += "Bruto: " & TxtBruto.Text & ", tara: " & TxtTara.Text & ", liquido: " & TxtLiquido.Text & " Preço: " & LblValor.Text & vbLf
	    End If
	 Catch ex As Exception
	    ex.Message.ToString()
	 End Try
   End Sub

   Public Shared Sub Focuss(ByVal Controle As Control)
	 If Controle.CanFocus Then ' se o controle tem o foco entao
	    Controle.Focus()
	 End If
   End Sub

   Private Sub FrmEstimativaManual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

	 If e.KeyChar = ChrW(27) AndAlso MsgBox("Sair da aplicação? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
	    Call Sair(Me)
	 End If
   End Sub

   Private Sub LimparDados(e As KeyEventArgs)

	 Try
	    If e.KeyValue = Keys.Delete Then
		  Call Limpar(TxtBruto)
		  Call Limpar(TxtTara)
		  Call Limpar(TxtLiquido)
		  Call Limpar(RichTextBoxSaida)
		  Limpar(Me)
		  '===============================
		  FrequenciaLbl = 0
		  LblContagem.Text = 0
		  Lblestimativa.Text = 0
		  LblValor.Text = 0
		  '==============================
	    End If
	 Catch ex As Exception
	    ex.Message.ToString()
	 End Try

   End Sub


   Private Sub TxtBruto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBruto.KeyDown, Txtpreco.KeyDown
	 LimparDados(e)
   End Sub

   Private Sub TxtTara_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTara.KeyDown
	 LimparDados(e)
   End Sub

   Private Sub Btestimativa_KeyDown(sender As Object, e As KeyEventArgs) Handles Btestimativa.KeyDown
	 LimparDados(e)
   End Sub


   Friend WithEvents I As TextBox
   Friend WithEvents B As String = "C:\Users\marcosferreira\OneDrive - Queiroz Galvão S.A\Projetos\MTR\BD\BancoPreco.txt"

   Sub Salvarpreco()

	 If My.Computer.FileSystem.FileExists(B) Then
	    My.Computer.FileSystem.DeleteFile(B)

	    Dim filestream As New FileStream(B, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
	    Dim streamwriter As New StreamWriter(filestream) ' o fluxo da gravação será o arquivo lido pelo filestream

	    ' streamwriter.Write() ' escreve o item 
	    streamwriter.Write(Environment.NewLine)
	    MsgBox("Gravado com sucesso")
	    streamwriter.Close()
	    ' filestream.Close()

	 ElseIf Not My.Computer.FileSystem.FileExists(B) Then

	    My.Computer.FileSystem.DirectoryExists(B)

	    Dim file_stream As New FileStream(B, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
	    Dim stream_writer As New StreamWriter(file_stream)
	    '  stream_writer.Write()
	    MsgBox("Item salvo")
	    stream_writer.Close()
	    '            file_stream.Close()
	 Else
	    If Not B.Contains(".txt") Then
		  Return
	    End If
	 End If

   End Sub

   Private Sub I_LostFocus(sender As Object, e As EventArgs) Handles I.LostFocus

	 I.Text = FormatNumber(I, 2)

   End Sub

   Private Sub FrmEstimativaManual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
	 Principal.FrmMTR.Activate()
	 'Dim I As New Principal.FrmPrincipal
	 'I.Show()


   End Sub





   Private Sub Txtpreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpreco.KeyPress
	 If e.KeyChar = Chr(44) Then
	    e.KeyChar = Chr(46)
	 End If
   End Sub
End Class
'Dim I As New TextBox With {
'    .Text = "",
'     .BackColor = Color.White,
'     .BorderStyle = BorderStyle.Fixed3D,
'     .CharacterCasing = CharacterCasing.Upper,
'     .ForeColor = Color.Black,
'     .Font = New System.Drawing.Font("Segoe UI", 8.25!),
'     .Name = "TxtConfigPreço",
'     .Location = New System.Drawing.Point(200, 205),
'     .TabIndex = 5,
'     .AllowDrop = True,
'     .TextAlign = HorizontalAlignment.Center}

'Me.Controls.Add(I)

'Dim l As New Label With {.BackColor = Color.White,
'     .BorderStyle = BorderStyle.Fixed3D,
'     .ForeColor = Color.Black,
'     .Font = New System.Drawing.Font("Segoe UI", 8.25!),
'     .Name = "Lblnomecx",
'     .Text = "Preço",
'     .Location = New System.Drawing.Point(230, 192),
'     .TabIndex = 5,
'     .AllowDrop = True,
'     .TextAlign = HorizontalAlignment.Center}
'Me.Controls.Add(l)

