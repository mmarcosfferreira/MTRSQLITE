Public Module ImputBoxPersonalizado
   Sub New()
	 InitializeComponent()
	 'With BunifuCustomTextbox1
	 '	If .UseSystemPasswordChar = True Then
	 '		.PasswordChar = "*"
	 '	End If
	 'End With

   End Sub

   Public WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
   Public WithEvents BtnOK As New Button
   Friend WithEvents BtnCancelar As New Button
   Friend WithEvents Frm As New Form
   Friend WithEvents LblDescricao As New Label

   Public Property Titulo_ As String
   Public Property Descricao_Form_ As String
   Public Property ValorPadrao_ As String = Nothing
   Public Property Descricao As String
   Public Property PasswordChar_ As Boolean


   Public Sub InitializeComponent()
	 Frm.SuspendLayout()

	 'LblDescricao
	 With LblDescricao
	    .BackColor = Color.GhostWhite 'Color.FromArgb(180, 182, 50)
	    .ForeColor = Color.Gray
	    .Name = "LblDescricao"
	    .BorderStyle = BorderStyle.None
	    .TextAlign = ContentAlignment.MiddleCenter
	    .Text = Descricao_Form_
	    .Size = New System.Drawing.Size(390, 100)
	    .Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	    .Location = New System.Drawing.Point(10, 20)
	    .FlatStyle = FlatStyle.Flat
	 End With


	 BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
	 BunifuCustomTextbox1.UseSystemPasswordChar = PasswordChar_
	 BtnOK = New System.Windows.Forms.Button()
	 BtnCancelar = New System.Windows.Forms.Button()

	 'BunifuCustomTextbox1	 '
	 BunifuCustomTextbox1.BackColor = System.Drawing.Color.White
	 BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
	 BunifuCustomTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 BunifuCustomTextbox1.ForeColor = System.Drawing.Color.DimGray

	 'BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
	 'BunifuCustomTextbox1.Location = New System.Drawing.Point(10, 130)
	 'BunifuCustomTextbox1.Size = New System.Drawing.Size(390, 120) '380
	 'BunifuCustomTextbox1.TextAlign = HorizontalAlignment.Center
	 'BunifuCustomTextbox1.WordWrap = True
	 'BunifuCustomTextbox1.Modified = True

	 'BunifuCustomTextbox1.UseSystemPasswordChar = PasswordChar_
	 'BunifuCustomTextbox1.PasswordChar = "#"
	 'BunifuCustomTextbox1.TabIndex = 0
	 'BunifuCustomTextbox1.Multiline = False
	 '
	 'BtnOK
	 '
	 BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
	 BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 BtnOK.ForeColor = System.Drawing.Color.DimGray

	 BtnOK.BackColor = Color.WhiteSmoke
	 BtnOK.Location = New System.Drawing.Point(120, 263) '(287, 24)
	 BtnOK.Name = "BtnOK"
	 BtnOK.Size = New System.Drawing.Size(65, 30)
	 BtnOK.TabIndex = 1
	 BtnOK.Text = "OK"

	 'BtnCancelar
	 BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
	 BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 BtnCancelar.ForeColor = System.Drawing.Color.DimGray
	 BtnCancelar.BackColor = Color.WhiteSmoke
	 BtnCancelar.Location = New System.Drawing.Point(210, 263)
	 BtnCancelar.Name = "BtnCancelar"
	 BtnCancelar.Size = New System.Drawing.Size(100, 30)  '(88, 30)
	 BtnCancelar.TabIndex = 2
	 BtnCancelar.Text = "CANCELAR"

	 'InputBox_Personalizado
	 Frm.BackColor = System.Drawing.Color.SkyBlue
	 Frm.ClientSize = New System.Drawing.Size(410, 300) '(410, 210)
	 Frm.ForeColor = System.Drawing.Color.DimGray
	 Frm.StartPosition = FormStartPosition.CenterScreen
	 Frm.StartPosition = FormStartPosition.CenterScreen
	 Frm.FormBorderStyle = FormBorderStyle.FixedSingle
	 'Image.FromFile(Application.StartupPath & "/CQG.Ico")

	 Frm.MaximizeBox = False
	 Frm.MinimizeBox = True
	 Frm.Name = "InputBox_Personalizado"
	 Frm.TabIndex = 3

	 Frm.Controls.Add(BtnOK)
	 Frm.Controls.Add(BtnCancelar)
	 Frm.Controls.Add(BunifuCustomTextbox1)
	 Frm.Controls.Add(LblDescricao)

	 Frm.ResumeLayout(False)
	 Frm.PerformLayout()

   End Sub

   ''' <summary>
   ''' </summary>
   ''' <param name="descricao">A descrição do objetivo da imputbox, esta mesma é feita em um label no centro do formulário</param>
   ''' <param name="title">O título ou cabeçario da inputboxPersonalizada</param>
   ''' <param name="valorPadrao">O valor que a inputboxPersonaliza vai receber ou capturar ao ser acionada</param>
   ''' <param name="PasswordChar_">Opcional se a caixa de texto vai ter a caixa de texto no formato de senha ou não</param>
   ''' <returns>A função deve retornar o valor qualquer do tipo string que não seja nulo</returns>
   Public Function InputBox_Personalizado(descricao As String, title As String, valorPadrao As String, Optional PasswordChar_ As Boolean = False, Optional SemTextbox As Boolean = False) As String

	 BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
	 BunifuCustomTextbox1.Location = New System.Drawing.Point(10, 130)
	 BunifuCustomTextbox1.Size = New System.Drawing.Size(390, 120) '380
	 BunifuCustomTextbox1.TextAlign = HorizontalAlignment.Center
	 BunifuCustomTextbox1.WordWrap = True
	 BunifuCustomTextbox1.Modified = True

	 BunifuCustomTextbox1.UseSystemPasswordChar = PasswordChar_
	 BunifuCustomTextbox1.TabIndex = 0
	 BunifuCustomTextbox1.Multiline = False

	 Select Case PasswordChar_
	    Case True
		  BunifuCustomTextbox1.PasswordChar = "#"
		  BunifuCustomTextbox1.Multiline = False
		  BunifuCustomTextbox1.UseSystemPasswordChar = PasswordChar_

	    Case False
		  BunifuCustomTextbox1.PasswordChar = Nothing
		  BunifuCustomTextbox1.Multiline = True
	 End Select


	 'atribuindo as propriedades valores da function
	 Titulo_ = UCase(title)
	 Descricao_Form_ = descricao
	 ValorPadrao_ = valorPadrao
	 '-------------------------------
	 'atribuindo alguns valores do encapsulamento as propriedades do objeto label e texto do frm
	 Frm.Text = title
	 LblDescricao.Text = descricao
	 BunifuCustomTextbox1.Focus()
	 Frm.ShowDialog() 'Caixa de diálogo modal p recebimento de dados

	 Dim s As String = ValorPadrao_
	 If s = String.Empty Then
	    Return ""
	 Else
	    Return s
	 End If


   End Function

   Private Sub BtnOK_click(sender As Object, e As EventArgs) Handles BtnOK.Click
	 Application.DoEvents()
	 If BtnOK.Text = "OK" AndAlso BunifuCustomTextbox1.Text <> "" Then
	    ValorPadrao_ = BunifuCustomTextbox1.Text
	 End If
	 Frm.Close()
   End Sub
   Private Sub BtnCancelar_click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
	 Frm.Close()
   End Sub

   Private Sub InputBox_Personalizado_Load(sender As Object, e As EventArgs) Handles Frm.Load
	 Titulo_ = Titulo_
	 Descricao_Form_ = Descricao
	 ValorPadrao_ = ValorPadrao_

   End Sub

   'antes de se fechar a inputbox personalizada, limpo a textbox 
   Private Sub Frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Frm.FormClosing
	 If e.CloseReason = CloseReason.UserClosing Then
	    BunifuCustomTextbox1.Clear()
	 End If
   End Sub
End Module
