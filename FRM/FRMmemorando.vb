Imports System.IO
Imports System.Security.Principal

Public Class FRMmemorando



   Private Sub FRMmemorando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 Cabecario_Memorando() 'do listview
#Disable Warning
	 ColocarFormularionoTopo.ColocaFormularionoCentro(sender)
#Enable Warning
	 'Me.Size = Screen.PrimaryScreen.WorkingArea.Size



   End Sub



   Public Userrrr As WindowsIdentity
   Private Sub Receptor(Combo_Objeto As ComboBox)
	 Combo_Objeto.Items.Clear()
	 'For Each carpeta In My.Computer.FileSystem.GetDirectories("C:\Documents and Settings", FileIO.SearchOption.SearchAllSubDirectories)
	 '    ListBox1.Items.Add(carpeta)
	 'Next

	 Combo_Objeto.Items.Add("Balança")
	 Dim unused = My.Computer.FileSystem.GetDirectories("C:\Users", FileIO.SearchOption.SearchTopLevelOnly) 'As WindowsIdentity = WindowsIdentity.GetCurrent()
	 For Each g In unused
	    '  Combo_Objeto.Items.Add(g.Value)
	    'Combo_Objeto.Items.Add(g.Translate(GetType(NTAccount)).ToString)
	    Combo_Objeto.Items.Add(Replace(g, "C:\Users\", "", 1).ToString)
	 Next

   End Sub



   Private Contador = 0
   Private Sub Btadd_Memorando(ByVal CT As Control)



	 If String.IsNullOrEmpty(TxtDescricao.Text) Then
	    TxtDescricao.Focus()
	    Return

	 ElseIf String.IsNullOrEmpty(DateTimePickerDATA.Value.ToString) Then
	    DateTimePickerDATA.Focus()
	    Return

	 ElseIf String.IsNullOrEmpty(DateTimePickerHORA.Value.ToString) Then
	    DateTimePickerHORA.Focus()
	    Return

	 ElseIf String.IsNullOrEmpty(ComboBoxDE.SelectedItem) Then
	    ComboBoxDE.Focus()
	    Return

	 ElseIf String.IsNullOrEmpty(ComboBoxPARA.SelectedItem) Then
	    ComboBoxPARA.Focus()
	    Return

	 ElseIf String.IsNullOrEmpty(ComboBoxSITUACAO.SelectedItem) Then
	    ComboBoxSITUACAO.Focus()
	    Return
	 Else


	    ListView1.SmallImageList = ImageList1
	    Contador = ListView1.Items.Count + 1
	    Dim Lvi As New ListViewItem(CStr(Contador)) 'ok


	    Lvi.SubItems.Add(TxtDescricao.Text)  'ok

	    Lvi.SubItems.Add(UsuarioLogado.UsuarioLogado) 'ok

	    Lvi.SubItems.Add(DateTimePickerHORA.Value.ToShortTimeString)

	    Lvi.SubItems.Add(DateTimePickerDATA.Value.ToShortDateString)

	    Lvi.SubItems.Add(ComboBoxDE.SelectedItem.ToString)

	    Lvi.SubItems.Add(ComboBoxPARA.SelectedItem.ToString)

	    Lvi.SubItems.Add(ComboBoxSITUACAO.SelectedItem.ToString)

	    ListView1.Items.Add(Lvi)

	    ListView1.EnsureVisible(ListView1.Items.Count - 1) 'curso no final

	    ' Dim Img As ImageList = New ImageList
	    'Img.ImageSize = New Size(25, 25)

	    'saida da imagem
	    'Dim files As String()
	    ''files = Directory.GetFiles("C:\MTR\Principal\Resources\pencil_go.png")

	    ''usa um loop p adicioana
	    'Try
	    '    For Each i In files
	    '        Img.Images.Add(Bitmap.FromFile(i))
	    '    Next
	    'Catch ex As Exception

	    'End Try


	 End If






   End Sub

   Private Sub BTADD_Click(sender As Object, e As EventArgs) Handles BTADD.Click
	 Btadd_Memorando(ListView1)
   End Sub


#Region "Salvar com settings"

   Private Sub SALVARCETTINGS()

	 'If My.Settings.Lembrete Is Nothing Then
	 '    My.Settings.Lembrete = New Specialized.StringCollection
	 'End If

	 'My.Settings.Lembrete.Clear()

	 'For Each item As ListViewItem In ListView1.Items
	 '    My.Settings.Lembrete.Add(item.Text)
	 'Next

	 'My.Settings.Save()
	 'My.Settings.Reload()
	 '   MsgBox("Salvo")
   End Sub



   Public CaminhoMemorando As String = Application.StartupPath & "\BD\Memorando.txt"
   ''' <summary>
   ''' Primeiro salvar as alterações no local e depois sobe p a nuvem
   ''' </summary>
   ''' <param name="sender">Objeto usado para Salvar: Neste caso o botão</param>
   ''' <param name="e">e seria o evento usando:Neste caso o evento Click</param>
   Private Async Sub BTSALVA_Click(sender As Object, e As EventArgs) Handles BTSALVA.Click
	 Try

	    If My.Computer.FileSystem.FileExists(CaminhoMemorando) Then
		  My.Computer.FileSystem.DeleteFile(CaminhoMemorando)
		  Dim FS As New FileStream(CaminhoMemorando, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
		  Dim SW As New StreamWriter(FS)

		  For i As Integer = 0 To ListView1.Items.Count - 1
			For i2 As Integer = 0 To ListView1.Items(i).SubItems.Count - 1
			   SW.Write(ListView1.Items(i).SubItems(i2).Text & Chr(9))
			Next
			SW.Write(Environment.NewLine) 'cria nova linha
		  Next

		  SW.Close()
		  FS.Close()

		  Await Internet.FTP_Upload(CaminhoMemorando,
							"ftp://files.000webhost.com/public_html/Memorando.txt",
							"marcosferreiramf",
							"Senha0789")

		  ' FrmMTR.Notifyicone("Memorando SALVO com sucesso!", "Leitura de dados!", 2, BTSALVA)

	    End If
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	 Finally
	 End Try
   End Sub
#End Region

#Region "Deletar items selecionados com loop for each"
   Private Sub BTDELETE_Click(sender As Object, e As EventArgs) Handles BTDELETE.Click


	 Contador = ListView1.Items.Count + 1


	 For Each H As ListViewItem In ListView1.SelectedItems

	    ListView1.Items.Remove(H)
	    'My.Settings.Lembrete.Remove(H.Selected)

	 Next
   End Sub
#End Region

   Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

	 Size = New Size(70, 60)

   End Sub


   Private Sub BTALTERA_Click(sender As Object, e As EventArgs) Handles BTALTERA.Click
	 Try
	    ListView1.SelectedItems(0).SubItems(1).Text = TxtDescricao.Text
	    ListView1.SelectedItems(0).SubItems(3).Text = DateTimePickerHORA.Value.ToString("HH:MM")
	    ListView1.SelectedItems(0).SubItems(4).Text = DateTimePickerDATA.Value.ToString("dd:MM:yyyy")
	    ListView1.SelectedItems(0).SubItems(5).Text = ComboBoxDE.Text
	    ListView1.SelectedItems(0).SubItems(6).Text = ComboBoxPARA.Text
	    ListView1.SelectedItems(0).SubItems(7).Text = ComboBoxSITUACAO.Text
	 Catch ex As Exception

	 End Try
   End Sub


   'If My.Settings.Lembrete IsNot Nothing Then
   '    My.Settings.Reload()
   '    'Apaga items do listview
   '    Dim items As ListView.ListViewItemCollection = ListView1.Items
   '    items.Clear()

   '    For Each A As String In My.Settings.Lembrete
   '        ListView1.Items.Add(A)
   '    Next

   'End If



   Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
	 '0=id

	 Try
	    TxtDescricao.Text = ListView1.SelectedItems(0).SubItems(1).Text
	    DateTimePickerHORA.Value = Convert.ToDateTime(ListView1.SelectedItems(0).SubItems(3).Text)
	    DateTimePickerDATA.Value = ListView1.SelectedItems(0).SubItems(4).Text
	    ComboBoxDE.Text = ListView1.SelectedItems(0).SubItems(5).Text
	    ComboBoxPARA.Text = ListView1.SelectedItems(0).SubItems(6).Text
	    ComboBoxSITUACAO.Text = ListView1.SelectedItems(0).SubItems(7).Text
	 Catch ex As Exception

	 End Try

   End Sub


#Region "Cabelario do memorando"
   Private Sub Cabecario_Memorando()
	 ListView1.Columns.Add("ID", 60, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("Descrição", 340, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("Usuario", 100, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("Hora", 100, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("Data", 100, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("De:", 100, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("Para:", 100, textAlign:=HorizontalAlignment.Left)
	 ListView1.Columns.Add("Situação: ", 130, textAlign:=HorizontalAlignment.Left)

   End Sub
#End Region

   Private Async Sub BTCARREGA_Click(sender As Object, e As EventArgs) Handles BTCARREGA.Click
	 ListView1.Items.Clear()
	 Dim SR As StreamReader


	 Await Internet.FTP_Dowload(CaminhoMemorando,
							 "ftp://files.000webhost.com/public_html/Memorando.txt",
							 "marcosferreiramf",
							 "Senha0789")
	 Try
	    If My.Computer.FileSystem.FileExists(CaminhoMemorando) Then

		  SR = My.Computer.FileSystem.OpenTextFileReader(CaminhoMemorando)
		  Dim Array() As String

		  Do While Not SR.EndOfStream
			Dim lvi As New ListViewItem
			Array = SR.ReadLine.Split(Chr(9))
			lvi.Text = Array(0).ToString  'principal

			lvi.SubItems.Add(Array(1).ToString)
			lvi.SubItems.Add(Array(2).ToString)
			lvi.SubItems.Add(Array(3).ToString)
			lvi.SubItems.Add(Array(4).ToString)
			lvi.SubItems.Add(Array(5).ToString)
			lvi.SubItems.Add(Array(6).ToString)
			lvi.SubItems.Add(Array(7).ToString)
			ListView1.Items.Add(lvi)
		  Loop
		  ' TextBoxMTRobservação.AutoCompleteCustomSource.Add(lvi.SubItems(3).Text)
		  SR.Close()
	    Else
	    End If
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString())
	    '  Exit Sub
	 End Try
   End Sub

#Region "Adicionar o usuario no objeto combobox"
   Private Sub ComboBoxDE_DropDown(sender As Object, e As EventArgs) Handles ComboBoxDE.DropDown
	 If ComboBoxDE.Items.Count = 1 Then
	 Else
	    Receptor(sender)
	 End If


   End Sub

#End Region

   Private Sub ComboBoxPARA_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPARA.DropDown

	 Receptor(sender)

   End Sub

   Private Sub ComboBoxPARA_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxPARA.GotFocus
	 ComboBoxPARA.DroppedDown = True
   End Sub

   Private Sub ComboBoxPARA_Leave(sender As Object, e As EventArgs) Handles ComboBoxPARA.Leave
	 ComboBoxPARA.DroppedDown = False
   End Sub


   Private Sub ComboBoxSITUACAO_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxSITUACAO.GotFocus
	 ComboBoxSITUACAO.DroppedDown = True
   End Sub

   Private Sub ComboBoxSITUACAO_Leave(sender As Object, e As EventArgs) Handles ComboBoxSITUACAO.Leave
	 ComboBoxSITUACAO.DroppedDown = False
   End Sub

   Private Sub ComboBoxDE_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxDE.GotFocus
	 ComboBoxDE.DroppedDown = True
   End Sub


   Private Sub ComboBoxDE_Leave(sender As Object, e As EventArgs) Handles ComboBoxDE.Leave
	 ComboBoxDE.DroppedDown = False
   End Sub


   Private Sub FRMmemorando_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

	 If MsgBox("Deseja minimizar o formulário? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção") = DialogResult.Yes Then

	    Visible = False
	 Else
	    e.Cancel = True
	 End If

   End Sub




#Region "Salvar em settings"

   'Private Sub BTSALVA_Click(sender As Object, e As EventArgs) Handles BTSALVA.Click
   '    Try
   '        If My.Settings.Lembrete Is Nothing Then
   '            My.Settings.Lembrete = New Specialized.StringCollection
   '        End If

   '        My.Settings.Lembrete.Clear()

   '        For Each item In ListBox1.Items
   '            My.Settings.Lembrete.Add(item)
   '        Next

   '        My.Settings.Save()

   '        MsgBox("Salvo")


   '    Catch ex As Exception
   '        MessageBox.Show("Detalhes: " & ex.Message.ToString)
   '    End Try

   'End Sub

#End Region


   'Private Sub BTADD_Click(sender As Object, e As EventArgs) Handles BTADD.Click

   '    If Not String.IsNullOrEmpty(TxtCaixadeTexto.Text) Then
   '        ListBox1.Items.Add(TxtCaixadeTexto.Text & " - " & Now.ToShortDateString & "-" & Now.ToShortTimeString)
   '    Else
   '        MsgBox("Campos estão vazios!")
   '        Return
   '    End If

   'End Sub


#Region "Carregar no settings"
   '  Private Sub BTCARREGA_Click(sender As Object, e As EventArgs) Handles BTCARREGA.Click
   'CARREGAR OQ FOI GRAVADO

   'If My.Settings.Lembrete IsNot Nothing Then

   '    ListBox1.Items.Clear()
   '    For Each A As String In My.Settings.Lembrete
   '        ListBox1.Items.Add(A)
   '    Next
   '    MsgBox("Dados Carregados!")
   'End If
   '   End Sub
#End Region

#Region "deletar usando loop for each"

   ' Private Sub BTDELETE_Click(sender As Object, e As EventArgs) Handles BTDELETE.Click
   '    Try
   '        If ListBox1.SelectedItems.Count = 0 Then
   '            MsgBox("Favor selecionar uma linha para exclusão!", MsgBoxStyle.Information, "Memorando")
   '        Else

   '            For Each D As String In My.Settings.Lembrete
   '                ListBox1.Items.Remove(D)
   '                My.Settings.Lembrete.Remove(D)
   '            Next

   '            My.Settings.Save()


   '        End If

   '    Catch ex As Exception

   '    End Try
   '  End Sub

#End Region


End Class