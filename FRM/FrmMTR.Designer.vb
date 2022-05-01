Imports System.ComponentModel
Imports BunifuAnimatorNS
Imports Guna.UI2.WinForms
Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMTR
   Inherits System.Windows.Forms.Form 'MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form



   'Descartar substituições de formulário para limpar a lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	 Try
	    If disposing AndAlso components IsNot Nothing Then
		  components.Dispose()
	    End If
	 Finally
	    MyBase.Dispose(disposing)
	 End Try
   End Sub

   'Exigido pelo Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
   'Pode ser modificado usando o Windows Form Designer.  
   'Não o modifique usando o editor de códigos.

   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
	 Me.components = New System.ComponentModel.Container()
	 Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMTR))
	 Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
	 Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	 Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	 Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	 Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	 Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
	 Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
	 Me.Label1 = New System.Windows.Forms.Label()
	 Me.Label3 = New System.Windows.Forms.Label()
	 Me.StatusStripVolume = New System.Windows.Forms.StatusStrip()
	 Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.ToolStripStatusLabeUsuarioLogado = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.ToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
	 Me.ToolStripStatusLabel_HOJE = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.ToolStripStatusLabel_IPlocal = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.ToolStripStatusLabel_Host = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.BtVolume = New System.Windows.Forms.ToolStripDropDownButton()
	 Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
	 Me.NotifyIcone_MTR = New System.Windows.Forms.NotifyIcon(Me.components)
	 Me.ToolTipMTR = New System.Windows.Forms.ToolTip(Me.components)
	 Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
	 Me.BunifuTransitionOpacity = New BunifuAnimatorNS.BunifuTransition(Me.components)
	 Me.Label2 = New System.Windows.Forms.Label()
	 Me.Label4 = New System.Windows.Forms.Label()
	 Me.DGVdados = New Guna.UI2.WinForms.Guna2DataGridView()
	 Me.Label7 = New System.Windows.Forms.Label()
	 Me.lblComprimentar = New System.Windows.Forms.Label()
	 Me.Pesquisar = New System.Windows.Forms.CheckBox()
	 Me.BTconfig = New System.Windows.Forms.Button()
	 Me.BTsalvarMtr = New System.Windows.Forms.Button()
	 Me.BTcarregarMtr = New System.Windows.Forms.Button()
	 Me.BTadicionarMtr = New System.Windows.Forms.Button()
	 Me.LinkAtualizar = New System.Windows.Forms.LinkLabel()
	 Me.BtContrair = New System.Windows.Forms.Button()
	 Me.Bt_Expandir = New System.Windows.Forms.Button()
	 Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
	 Me.ToolStripStatusLabelLogin = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.DestinadorLocal = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
	 Me.BtnReceberManifestoBunifuFlatButton = New Bunifu.Framework.UI.BunifuFlatButton()
	 Me.txtmanifObservacao = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifTransportadorDataExpedicao = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifTransportadorPlacaVeiculo = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifTransportadorNomeMotorista = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifGeradorCargoResponsavel = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifGeradorNomeResponsavel = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifData = New MetroFramework.Controls.MetroTextBox()
	 Me.txtsituacaoManifestoCodigo = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcnpArmazenador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcnpDestinador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcnpTransportador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcnpGerador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifestoCodigo = New MetroFramework.Controls.MetroTextBox()
	 Me.txtquantidade = New MetroFramework.Controls.MetroTextBox()
	 Me.txtclasseDeRisco = New MetroFramework.Controls.MetroTextBox()
	 Me.txtnumeroONU = New MetroFramework.Controls.MetroTextBox()
	 Me.txttipoDensidadeUnidade = New MetroFramework.Controls.MetroTextBox()
	 Me.txtretornoCodigo = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodUnidadeGerador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodUnidadeTransportador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodUnidadeArmazenador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifDataExpedicao = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifDataRecebimento = New MetroFramework.Controls.MetroTextBox()
	 Me.txtretorno = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoSequencial = New MetroFramework.Controls.MetroTextBox()
	 Me.txtjustificativa = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoInterno = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoClasse = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoTipoEstado = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoUnidade = New MetroFramework.Controls.MetroTextBox()
	 Me.txttipoDensidadeValor = New MetroFramework.Controls.MetroTextBox()
	 Me.txtgrupoEmbalagem = New MetroFramework.Controls.MetroTextBox()
	 Me.txtnomeEmbarque = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifestoItemCodInternoDestinador = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifestoItemCodInterno = New MetroFramework.Controls.MetroTextBox()
	 Me.txtmanifestoItemObservacao = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoTecnologia = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodigoAcondicionamento = New MetroFramework.Controls.MetroTextBox()
	 Me.txtresiduo = New MetroFramework.Controls.MetroTextBox()
	 Me.txtSituacaoMTR = New MetroFramework.Controls.MetroTextBox()
	 Me.txtquantidadeRecebida = New MetroFramework.Controls.MetroTextBox()
	 Me.Label54 = New System.Windows.Forms.Label()
	 Me.Label6 = New System.Windows.Forms.Label()
	 Me.Label5 = New System.Windows.Forms.Label()
	 Me.Label35 = New System.Windows.Forms.Label()
	 Me.Label34 = New System.Windows.Forms.Label()
	 Me.Label33 = New System.Windows.Forms.Label()
	 Me.Label32 = New System.Windows.Forms.Label()
	 Me.Label31 = New System.Windows.Forms.Label()
	 Me.Label30 = New System.Windows.Forms.Label()
	 Me.Label27 = New System.Windows.Forms.Label()
	 Me.Label26 = New System.Windows.Forms.Label()
	 Me.Label25 = New System.Windows.Forms.Label()
	 Me.Label24 = New System.Windows.Forms.Label()
	 Me.Label23 = New System.Windows.Forms.Label()
	 Me.Label22 = New System.Windows.Forms.Label()
	 Me.Label47 = New System.Windows.Forms.Label()
	 Me.Label46 = New System.Windows.Forms.Label()
	 Me.Label21 = New System.Windows.Forms.Label()
	 Me.Label45 = New System.Windows.Forms.Label()
	 Me.Label20 = New System.Windows.Forms.Label()
	 Me.Label44 = New System.Windows.Forms.Label()
	 Me.Label43 = New System.Windows.Forms.Label()
	 Me.Label42 = New System.Windows.Forms.Label()
	 Me.Label19 = New System.Windows.Forms.Label()
	 Me.Label41 = New System.Windows.Forms.Label()
	 Me.Label18 = New System.Windows.Forms.Label()
	 Me.Label17 = New System.Windows.Forms.Label()
	 Me.Label16 = New System.Windows.Forms.Label()
	 Me.Label15 = New System.Windows.Forms.Label()
	 Me.Label14 = New System.Windows.Forms.Label()
	 Me.Label40 = New System.Windows.Forms.Label()
	 Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
	 Me.Label39 = New System.Windows.Forms.Label()
	 Me.Label38 = New System.Windows.Forms.Label()
	 Me.Label37 = New System.Windows.Forms.Label()
	 Me.Label36 = New System.Windows.Forms.Label()
	 Me.Label29 = New System.Windows.Forms.Label()
	 Me.Label13 = New System.Windows.Forms.Label()
	 Me.Label12 = New System.Windows.Forms.Label()
	 Me.Label28 = New System.Windows.Forms.Label()
	 Me.Label11 = New System.Windows.Forms.Label()
	 Me.Label9 = New System.Windows.Forms.Label()
	 Me.Label8 = New System.Windows.Forms.Label()
	 Me.GroupBox1 = New System.Windows.Forms.GroupBox()
	 Me.TreeView1 = New System.Windows.Forms.TreeView()
	 Me.Label53 = New System.Windows.Forms.Label()
	 Me.Label51 = New System.Windows.Forms.Label()
	 Me.Label50 = New System.Windows.Forms.Label()
	 Me.Label49 = New System.Windows.Forms.Label()
	 Me.Label48 = New System.Windows.Forms.Label()
	 Me.Label52 = New System.Windows.Forms.Label()
	 Me.txtUnidadeDescricao = New MetroFramework.Controls.MetroTextBox()
	 Me.txtDescricaoEstadoFisico = New MetroFramework.Controls.MetroTextBox()
	 Me.txtDescriçãoTecnologia = New MetroFramework.Controls.MetroTextBox()
	 Me.txtDescricaoAcondicionamento = New MetroFramework.Controls.MetroTextBox()
	 Me.txtClasseDescrição = New MetroFramework.Controls.MetroTextBox()
	 Me.txtcodUnidadeDestinador = New MetroFramework.Controls.MetroTextBox()
	 Me.GroupBox6 = New System.Windows.Forms.GroupBox()
	 Me.TXTobservacao = New Principal.TextboxMonetário()
	 Me.TXTdataHora = New Principal.TextboxMonetário()
	 Me.TXTmtr = New Principal.TextboxMonetário()
	 Me.TXTCodigo = New Principal.TextboxMonetário()
	 Me.TimerStatusdaRede = New System.Windows.Forms.Timer(Me.components)
	 Me.TimerSalvarNaNuvem = New System.Windows.Forms.Timer(Me.components)
	 Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
	 Me.LoadFormulario = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
	 Me.Efeito = New BunifuAnimatorNS.BunifuTransition(Me.components)
	 Me.StatusStripVolume.SuspendLayout()
	 CType(Me.DGVdados, System.ComponentModel.ISupportInitialize).BeginInit()
	 Me.StatusStrip1.SuspendLayout()
	 Me.BunifuCards1.SuspendLayout()
	 Me.GroupBox1.SuspendLayout()
	 Me.GroupBox6.SuspendLayout()
	 Me.SuspendLayout()
	 '
	 'Label1
	 '
	 resources.ApplyResources(Me.Label1, "Label1")
	 Me.Label1.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
	 Me.Label1.ForeColor = System.Drawing.Color.Gray
	 Me.Label1.Name = "Label1"
	 '
	 'Label3
	 '
	 resources.ApplyResources(Me.Label3, "Label3")
	 Me.Label3.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
	 Me.Label3.ForeColor = System.Drawing.Color.Gray
	 Me.Label3.Name = "Label3"
	 '
	 'StatusStripVolume
	 '
	 Me.StatusStripVolume.AllowMerge = False
	 resources.ApplyResources(Me.StatusStripVolume, "StatusStripVolume")
	 Me.StatusStripVolume.BackColor = System.Drawing.Color.Azure
	 Me.Efeito.SetDecoration(Me.StatusStripVolume, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.StatusStripVolume, BunifuAnimatorNS.DecorationType.Custom)
	 Me.StatusStripVolume.GripMargin = New System.Windows.Forms.Padding(1)
	 Me.StatusStripVolume.ImageScalingSize = New System.Drawing.Size(1, 1)
	 Me.StatusStripVolume.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabeUsuarioLogado, Me.ToolStripSplitButton, Me.ToolStripStatusLabel_HOJE, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel_IPlocal, Me.ToolStripStatusLabel_Host, Me.BtVolume})
	 Me.StatusStripVolume.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
	 Me.StatusStripVolume.Name = "StatusStripVolume"
	 Me.StatusStripVolume.Stretch = False
	 '
	 'ToolStripStatusLabel
	 '
	 resources.ApplyResources(Me.ToolStripStatusLabel, "ToolStripStatusLabel")
	 Me.ToolStripStatusLabel.ForeColor = System.Drawing.Color.Gray
	 Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
	 '
	 'ToolStripStatusLabeUsuarioLogado
	 '
	 Me.ToolStripStatusLabeUsuarioLogado.ForeColor = System.Drawing.Color.Gray
	 Me.ToolStripStatusLabeUsuarioLogado.Name = "ToolStripStatusLabeUsuarioLogado"
	 resources.ApplyResources(Me.ToolStripStatusLabeUsuarioLogado, "ToolStripStatusLabeUsuarioLogado")
	 '
	 'ToolStripSplitButton
	 '
	 Me.ToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	 Me.ToolStripSplitButton.ForeColor = System.Drawing.Color.Gray
	 resources.ApplyResources(Me.ToolStripSplitButton, "ToolStripSplitButton")
	 Me.ToolStripSplitButton.Name = "ToolStripSplitButton"
	 '
	 'ToolStripStatusLabel_HOJE
	 '
	 resources.ApplyResources(Me.ToolStripStatusLabel_HOJE, "ToolStripStatusLabel_HOJE")
	 Me.ToolStripStatusLabel_HOJE.ForeColor = System.Drawing.Color.Gray
	 Me.ToolStripStatusLabel_HOJE.Name = "ToolStripStatusLabel_HOJE"
	 '
	 'ToolStripStatusLabel1
	 '
	 resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
	 Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Gray
	 Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
	 '
	 'ToolStripStatusLabel_IPlocal
	 '
	 resources.ApplyResources(Me.ToolStripStatusLabel_IPlocal, "ToolStripStatusLabel_IPlocal")
	 Me.ToolStripStatusLabel_IPlocal.ForeColor = System.Drawing.Color.Gray
	 Me.ToolStripStatusLabel_IPlocal.Name = "ToolStripStatusLabel_IPlocal"
	 '
	 'ToolStripStatusLabel_Host
	 '
	 Me.ToolStripStatusLabel_Host.ForeColor = System.Drawing.Color.Gray
	 Me.ToolStripStatusLabel_Host.Name = "ToolStripStatusLabel_Host"
	 resources.ApplyResources(Me.ToolStripStatusLabel_Host, "ToolStripStatusLabel_Host")
	 '
	 'BtVolume
	 '
	 resources.ApplyResources(Me.BtVolume, "BtVolume")
	 Me.BtVolume.Name = "BtVolume"
	 '
	 'Timer1
	 '
	 Me.Timer1.Enabled = True
	 Me.Timer1.Interval = 1000
	 '
	 'NotifyIcone_MTR
	 '
	 Me.NotifyIcone_MTR.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
	 resources.ApplyResources(Me.NotifyIcone_MTR, "NotifyIcone_MTR")
	 '
	 'Timer3
	 '
	 Me.Timer3.Enabled = True
	 Me.Timer3.Interval = 1000
	 '
	 'BunifuTransitionOpacity
	 '
	 Me.BunifuTransitionOpacity.AnimationType = BunifuAnimatorNS.AnimationType.Scale
	 Me.BunifuTransitionOpacity.Cursor = Nothing
	 Animation1.AnimateOnlyDifferences = True
	 Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
	 Animation1.LeafCoeff = 0!
	 Animation1.MaxTime = 1.0!
	 Animation1.MinTime = 0!
	 Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
	 Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
	 Animation1.MosaicSize = 0
	 Animation1.Padding = New System.Windows.Forms.Padding(0)
	 Animation1.RotateCoeff = 0!
	 Animation1.RotateLimit = 0!
	 Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
	 Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
	 Animation1.TimeCoeff = 0!
	 Animation1.TransparencyCoeff = 0!
	 Me.BunifuTransitionOpacity.DefaultAnimation = Animation1
	 Me.BunifuTransitionOpacity.Interval = 1
	 Me.BunifuTransitionOpacity.MaxAnimationTime = 4000
	 Me.BunifuTransitionOpacity.TimeStep = 0.01!
	 '
	 'Label2
	 '
	 resources.ApplyResources(Me.Label2, "Label2")
	 Me.Label2.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
	 Me.Label2.ForeColor = System.Drawing.Color.Gray
	 Me.Label2.Name = "Label2"
	 '
	 'Label4
	 '
	 resources.ApplyResources(Me.Label4, "Label4")
	 Me.Label4.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
	 Me.Label4.ForeColor = System.Drawing.Color.Gray
	 Me.Label4.Name = "Label4"
	 '
	 'DGVdados
	 '
	 DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	 DataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush
	 Me.DGVdados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
	 resources.ApplyResources(Me.DGVdados, "DGVdados")
	 Me.DGVdados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
	 Me.DGVdados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
	 Me.DGVdados.BackgroundColor = System.Drawing.Color.White
	 Me.DGVdados.BorderStyle = System.Windows.Forms.BorderStyle.None
	 Me.DGVdados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
	 Me.DGVdados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
	 DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	 DataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew
	 DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
	 DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
	 DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuBar
	 DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText
	 DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
	 Me.DGVdados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
	 Me.Efeito.SetDecoration(Me.DGVdados, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.DGVdados, BunifuAnimatorNS.DecorationType.None)
	 DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	 DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
	 DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
	 DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
	 DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
	 DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
	 DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
	 Me.DGVdados.DefaultCellStyle = DataGridViewCellStyle3
	 Me.DGVdados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
	 Me.DGVdados.EnableHeadersVisualStyles = False
	 Me.DGVdados.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
	 Me.DGVdados.Name = "DGVdados"
	 DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	 DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
	 DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
	 DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
	 DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
	 DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
	 DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
	 Me.DGVdados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
	 Me.DGVdados.RowHeadersVisible = False
	 DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	 DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame
	 Me.DGVdados.RowsDefaultCellStyle = DataGridViewCellStyle5
	 Me.DGVdados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
	 Me.DGVdados.RowTemplate.Height = 32
	 Me.DGVdados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
	 Me.DGVdados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
	 Me.DGVdados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue
	 Me.DGVdados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LavenderBlush
	 Me.DGVdados.ThemeStyle.AlternatingRowsStyle.Font = Nothing
	 Me.DGVdados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
	 Me.DGVdados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
	 Me.DGVdados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
	 Me.DGVdados.ThemeStyle.BackColor = System.Drawing.Color.White
	 Me.DGVdados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
	 Me.DGVdados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Honeydew
	 Me.DGVdados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
	 Me.DGVdados.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
	 Me.DGVdados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray
	 Me.DGVdados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
	 Me.DGVdados.ThemeStyle.HeaderStyle.Height = 35
	 Me.DGVdados.ThemeStyle.ReadOnly = False
	 Me.DGVdados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
	 Me.DGVdados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
	 Me.DGVdados.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
	 Me.DGVdados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray
	 Me.DGVdados.ThemeStyle.RowsStyle.Height = 32
	 Me.DGVdados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
	 Me.DGVdados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray
	 '
	 'Label7
	 '
	 resources.ApplyResources(Me.Label7, "Label7")
	 Me.Label7.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
	 Me.Label7.ForeColor = System.Drawing.Color.Gray
	 Me.Label7.Name = "Label7"
	 '
	 'lblComprimentar
	 '
	 resources.ApplyResources(Me.lblComprimentar, "lblComprimentar")
	 Me.BunifuTransitionOpacity.SetDecoration(Me.lblComprimentar, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.lblComprimentar, BunifuAnimatorNS.DecorationType.None)
	 Me.lblComprimentar.Name = "lblComprimentar"
	 '
	 'Pesquisar
	 '
	 resources.ApplyResources(Me.Pesquisar, "Pesquisar")
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Pesquisar, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Pesquisar, BunifuAnimatorNS.DecorationType.None)
	 Me.Pesquisar.ForeColor = System.Drawing.Color.Gray
	 Me.Pesquisar.Name = "Pesquisar"
	 Me.Pesquisar.UseVisualStyleBackColor = True
	 '
	 'BTconfig
	 '
	 Me.BTconfig.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BTconfig, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.BTconfig, BunifuAnimatorNS.DecorationType.None)
	 Me.BTconfig.FlatAppearance.BorderColor = System.Drawing.Color.White
	 Me.BTconfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
	 resources.ApplyResources(Me.BTconfig, "BTconfig")
	 Me.BTconfig.Image = Global.Principal.My.Resources.Resources.configuration_config_system_1540
	 Me.BTconfig.Name = "BTconfig"
	 Me.BTconfig.UseVisualStyleBackColor = False
	 '
	 'BTsalvarMtr
	 '
	 Me.BTsalvarMtr.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BTsalvarMtr, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.BTsalvarMtr, BunifuAnimatorNS.DecorationType.None)
	 Me.BTsalvarMtr.FlatAppearance.BorderColor = System.Drawing.Color.White
	 Me.BTsalvarMtr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
	 resources.ApplyResources(Me.BTsalvarMtr, "BTsalvarMtr")
	 Me.BTsalvarMtr.ForeColor = System.Drawing.Color.Transparent
	 Me.BTsalvarMtr.Name = "BTsalvarMtr"
	 Me.BTsalvarMtr.UseVisualStyleBackColor = False
	 '
	 'BTcarregarMtr
	 '
	 Me.BTcarregarMtr.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BTcarregarMtr, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.BTcarregarMtr, BunifuAnimatorNS.DecorationType.None)
	 Me.BTcarregarMtr.FlatAppearance.BorderColor = System.Drawing.Color.White
	 Me.BTcarregarMtr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
	 resources.ApplyResources(Me.BTcarregarMtr, "BTcarregarMtr")
	 Me.BTcarregarMtr.ForeColor = System.Drawing.Color.Brown
	 Me.BTcarregarMtr.Name = "BTcarregarMtr"
	 Me.BTcarregarMtr.UseVisualStyleBackColor = False
	 '
	 'BTadicionarMtr
	 '
	 Me.BTadicionarMtr.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BTadicionarMtr, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.BTadicionarMtr, BunifuAnimatorNS.DecorationType.None)
	 Me.BTadicionarMtr.FlatAppearance.BorderColor = System.Drawing.Color.White
	 Me.BTadicionarMtr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
	 resources.ApplyResources(Me.BTadicionarMtr, "BTadicionarMtr")
	 Me.BTadicionarMtr.ForeColor = System.Drawing.Color.Transparent
	 Me.BTadicionarMtr.Name = "BTadicionarMtr"
	 Me.BTadicionarMtr.UseVisualStyleBackColor = False
	 '
	 'LinkAtualizar
	 '
	 resources.ApplyResources(Me.LinkAtualizar, "LinkAtualizar")
	 Me.BunifuTransitionOpacity.SetDecoration(Me.LinkAtualizar, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.LinkAtualizar, BunifuAnimatorNS.DecorationType.None)
	 Me.LinkAtualizar.ForeColor = System.Drawing.Color.Silver
	 Me.LinkAtualizar.LinkColor = System.Drawing.Color.Gray
	 Me.LinkAtualizar.Name = "LinkAtualizar"
	 Me.LinkAtualizar.TabStop = True
	 '
	 'BtContrair
	 '
	 Me.BtContrair.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BtContrair, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.BtContrair, BunifuAnimatorNS.DecorationType.None)
	 resources.ApplyResources(Me.BtContrair, "BtContrair")
	 Me.BtContrair.ForeColor = System.Drawing.Color.WhiteSmoke
	 Me.BtContrair.Name = "BtContrair"
	 Me.BtContrair.UseVisualStyleBackColor = False
	 '
	 'Bt_Expandir
	 '
	 Me.Bt_Expandir.BackColor = System.Drawing.Color.Transparent
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Bt_Expandir, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Bt_Expandir, BunifuAnimatorNS.DecorationType.None)
	 resources.ApplyResources(Me.Bt_Expandir, "Bt_Expandir")
	 Me.Bt_Expandir.ForeColor = System.Drawing.Color.WhiteSmoke
	 Me.Bt_Expandir.Name = "Bt_Expandir"
	 Me.Bt_Expandir.UseVisualStyleBackColor = False
	 '
	 'StatusStrip1
	 '
	 resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
	 Me.StatusStrip1.BackColor = System.Drawing.Color.White
	 Me.Efeito.SetDecoration(Me.StatusStrip1, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.StatusStrip1, BunifuAnimatorNS.DecorationType.None)
	 Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
	 Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
	 Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelLogin, Me.ToolStripStatusLabel3, Me.DestinadorLocal})
	 Me.StatusStrip1.Name = "StatusStrip1"
	 Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
	 '
	 'ToolStripStatusLabelLogin
	 '
	 Me.ToolStripStatusLabelLogin.Name = "ToolStripStatusLabelLogin"
	 resources.ApplyResources(Me.ToolStripStatusLabelLogin, "ToolStripStatusLabelLogin")
	 '
	 'ToolStripStatusLabel3
	 '
	 Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
	 resources.ApplyResources(Me.ToolStripStatusLabel3, "ToolStripStatusLabel3")
	 '
	 'DestinadorLocal
	 '
	 Me.DestinadorLocal.Image = Global.Principal.My.Resources.Resources.bullet_key
	 resources.ApplyResources(Me.DestinadorLocal, "DestinadorLocal")
	 Me.DestinadorLocal.Name = "DestinadorLocal"
	 '
	 'BunifuCards1
	 '
	 resources.ApplyResources(Me.BunifuCards1, "BunifuCards1")
	 Me.BunifuCards1.BackColor = System.Drawing.Color.White
	 Me.BunifuCards1.BorderRadius = 5
	 Me.BunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	 Me.BunifuCards1.BottomSahddow = True
	 Me.BunifuCards1.color = System.Drawing.Color.DodgerBlue
	 Me.BunifuCards1.Controls.Add(Me.BtnReceberManifestoBunifuFlatButton)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifObservacao)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifTransportadorDataExpedicao)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifTransportadorPlacaVeiculo)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifTransportadorNomeMotorista)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifGeradorCargoResponsavel)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifGeradorNomeResponsavel)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifData)
	 Me.BunifuCards1.Controls.Add(Me.txtsituacaoManifestoCodigo)
	 Me.BunifuCards1.Controls.Add(Me.txtcnpArmazenador)
	 Me.BunifuCards1.Controls.Add(Me.txtcnpDestinador)
	 Me.BunifuCards1.Controls.Add(Me.txtcnpTransportador)
	 Me.BunifuCards1.Controls.Add(Me.txtcnpGerador)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifestoCodigo)
	 Me.BunifuCards1.Controls.Add(Me.txtquantidade)
	 Me.BunifuCards1.Controls.Add(Me.txtclasseDeRisco)
	 Me.BunifuCards1.Controls.Add(Me.txtnumeroONU)
	 Me.BunifuCards1.Controls.Add(Me.txttipoDensidadeUnidade)
	 Me.BunifuCards1.Controls.Add(Me.txtretornoCodigo)
	 Me.BunifuCards1.Controls.Add(Me.txtcodUnidadeGerador)
	 Me.BunifuCards1.Controls.Add(Me.txtcodUnidadeTransportador)
	 Me.BunifuCards1.Controls.Add(Me.txtcodUnidadeArmazenador)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifDataExpedicao)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifDataRecebimento)
	 Me.BunifuCards1.Controls.Add(Me.txtretorno)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoSequencial)
	 Me.BunifuCards1.Controls.Add(Me.txtjustificativa)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoInterno)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoClasse)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoTipoEstado)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoUnidade)
	 Me.BunifuCards1.Controls.Add(Me.txttipoDensidadeValor)
	 Me.BunifuCards1.Controls.Add(Me.txtgrupoEmbalagem)
	 Me.BunifuCards1.Controls.Add(Me.txtnomeEmbarque)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifestoItemCodInternoDestinador)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifestoItemCodInterno)
	 Me.BunifuCards1.Controls.Add(Me.txtmanifestoItemObservacao)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoTecnologia)
	 Me.BunifuCards1.Controls.Add(Me.txtcodigoAcondicionamento)
	 Me.BunifuCards1.Controls.Add(Me.txtresiduo)
	 Me.BunifuCards1.Controls.Add(Me.txtSituacaoMTR)
	 Me.BunifuCards1.Controls.Add(Me.txtquantidadeRecebida)
	 Me.BunifuCards1.Controls.Add(Me.Label54)
	 Me.BunifuCards1.Controls.Add(Me.Label6)
	 Me.BunifuCards1.Controls.Add(Me.Label5)
	 Me.BunifuCards1.Controls.Add(Me.Label35)
	 Me.BunifuCards1.Controls.Add(Me.Label34)
	 Me.BunifuCards1.Controls.Add(Me.Label33)
	 Me.BunifuCards1.Controls.Add(Me.Label32)
	 Me.BunifuCards1.Controls.Add(Me.Label31)
	 Me.BunifuCards1.Controls.Add(Me.Label30)
	 Me.BunifuCards1.Controls.Add(Me.Label27)
	 Me.BunifuCards1.Controls.Add(Me.Label26)
	 Me.BunifuCards1.Controls.Add(Me.Label25)
	 Me.BunifuCards1.Controls.Add(Me.Label24)
	 Me.BunifuCards1.Controls.Add(Me.Label23)
	 Me.BunifuCards1.Controls.Add(Me.Label22)
	 Me.BunifuCards1.Controls.Add(Me.Label47)
	 Me.BunifuCards1.Controls.Add(Me.Label46)
	 Me.BunifuCards1.Controls.Add(Me.Label21)
	 Me.BunifuCards1.Controls.Add(Me.Label45)
	 Me.BunifuCards1.Controls.Add(Me.Label20)
	 Me.BunifuCards1.Controls.Add(Me.Label44)
	 Me.BunifuCards1.Controls.Add(Me.Label43)
	 Me.BunifuCards1.Controls.Add(Me.Label42)
	 Me.BunifuCards1.Controls.Add(Me.Label19)
	 Me.BunifuCards1.Controls.Add(Me.Label41)
	 Me.BunifuCards1.Controls.Add(Me.Label18)
	 Me.BunifuCards1.Controls.Add(Me.Label17)
	 Me.BunifuCards1.Controls.Add(Me.Label16)
	 Me.BunifuCards1.Controls.Add(Me.Label15)
	 Me.BunifuCards1.Controls.Add(Me.Label14)
	 Me.BunifuCards1.Controls.Add(Me.Label40)
	 Me.BunifuCards1.Controls.Add(Me.Label39)
	 Me.BunifuCards1.Controls.Add(Me.Label38)
	 Me.BunifuCards1.Controls.Add(Me.Label37)
	 Me.BunifuCards1.Controls.Add(Me.Label36)
	 Me.BunifuCards1.Controls.Add(Me.Label29)
	 Me.BunifuCards1.Controls.Add(Me.Label13)
	 Me.BunifuCards1.Controls.Add(Me.Label12)
	 Me.BunifuCards1.Controls.Add(Me.Label28)
	 Me.BunifuCards1.Controls.Add(Me.Label11)
	 Me.BunifuCards1.Controls.Add(Me.Label9)
	 Me.BunifuCards1.Controls.Add(Me.Label8)
	 Me.BunifuCards1.Controls.Add(Me.GroupBox1)
	 Me.Efeito.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.Custom)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.Custom)
	 Me.BunifuCards1.LeftSahddow = False
	 Me.BunifuCards1.Name = "BunifuCards1"
	 Me.BunifuCards1.RightSahddow = True
	 Me.BunifuCards1.ShadowDepth = 20
	 '
	 'BtnReceberManifestoBunifuFlatButton
	 '
	 Me.BtnReceberManifestoBunifuFlatButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
	 Me.BtnReceberManifestoBunifuFlatButton.BackColor = System.Drawing.Color.Silver
	 resources.ApplyResources(Me.BtnReceberManifestoBunifuFlatButton, "BtnReceberManifestoBunifuFlatButton")
	 Me.BtnReceberManifestoBunifuFlatButton.BorderRadius = 0
	 Me.BtnReceberManifestoBunifuFlatButton.ButtonText = "ReceberManifesto"
	 Me.BtnReceberManifestoBunifuFlatButton.Cursor = System.Windows.Forms.Cursors.Hand
	 Me.BunifuTransitionOpacity.SetDecoration(Me.BtnReceberManifestoBunifuFlatButton, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.BtnReceberManifestoBunifuFlatButton, BunifuAnimatorNS.DecorationType.None)
	 Me.BtnReceberManifestoBunifuFlatButton.DisabledColor = System.Drawing.Color.Gray
	 Me.BtnReceberManifestoBunifuFlatButton.Iconcolor = System.Drawing.Color.Transparent
	 Me.BtnReceberManifestoBunifuFlatButton.Iconimage = Global.Principal.My.Resources.Resources.accept
	 Me.BtnReceberManifestoBunifuFlatButton.Iconimage_right = Nothing
	 Me.BtnReceberManifestoBunifuFlatButton.Iconimage_right_Selected = Nothing
	 Me.BtnReceberManifestoBunifuFlatButton.Iconimage_Selected = Nothing
	 Me.BtnReceberManifestoBunifuFlatButton.IconMarginLeft = 0
	 Me.BtnReceberManifestoBunifuFlatButton.IconMarginRight = 0
	 Me.BtnReceberManifestoBunifuFlatButton.IconRightVisible = True
	 Me.BtnReceberManifestoBunifuFlatButton.IconRightZoom = 0R
	 Me.BtnReceberManifestoBunifuFlatButton.IconVisible = True
	 Me.BtnReceberManifestoBunifuFlatButton.IconZoom = 50.0R
	 Me.BtnReceberManifestoBunifuFlatButton.IsTab = False
	 Me.BtnReceberManifestoBunifuFlatButton.Name = "BtnReceberManifestoBunifuFlatButton"
	 Me.BtnReceberManifestoBunifuFlatButton.Normalcolor = System.Drawing.Color.Silver
	 Me.BtnReceberManifestoBunifuFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
	 Me.BtnReceberManifestoBunifuFlatButton.OnHoverTextColor = System.Drawing.Color.White
	 Me.BtnReceberManifestoBunifuFlatButton.selected = False
	 Me.BtnReceberManifestoBunifuFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
	 Me.BtnReceberManifestoBunifuFlatButton.Textcolor = System.Drawing.Color.White
	 Me.BtnReceberManifestoBunifuFlatButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifObservacao
	 '
	 Me.txtmanifObservacao.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifObservacao.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize"), Boolean)
	 Me.txtmanifObservacao.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifObservacao.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifObservacao.CustomButton.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
	 Me.txtmanifObservacao.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
	 Me.txtmanifObservacao.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode"), System.Windows.Forms.ImeMode)
	 Me.txtmanifObservacao.CustomButton.Location = CType(resources.GetObject("resource.Location"), System.Drawing.Point)
	 Me.txtmanifObservacao.CustomButton.Name = ""
	 Me.txtmanifObservacao.CustomButton.Size = CType(resources.GetObject("resource.Size"), System.Drawing.Size)
	 Me.txtmanifObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifObservacao.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex"), Integer)
	 Me.txtmanifObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifObservacao.CustomButton.UseSelectable = True
	 Me.txtmanifObservacao.CustomButton.Visible = CType(resources.GetObject("resource.Visible"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifObservacao, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifObservacao, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifObservacao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifObservacao.ForeColor = System.Drawing.Color.Blue
	 Me.txtmanifObservacao.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifObservacao, "txtmanifObservacao")
	 Me.txtmanifObservacao.MaxLength = 32767
	 Me.txtmanifObservacao.Name = "txtmanifObservacao"
	 Me.txtmanifObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifObservacao.SelectedText = ""
	 Me.txtmanifObservacao.SelectionLength = 0
	 Me.txtmanifObservacao.SelectionStart = 0
	 Me.txtmanifObservacao.ShortcutsEnabled = True
	 Me.txtmanifObservacao.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifObservacao.UseCustomForeColor = True
	 Me.txtmanifObservacao.UseSelectable = True
	 Me.txtmanifObservacao.UseStyleColors = True
	 Me.txtmanifObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifObservacao.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifTransportadorDataExpedicao
	 '
	 Me.txtmanifTransportadorDataExpedicao.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize1"), Boolean)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle1"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Font = CType(resources.GetObject("resource.Font1"), System.Drawing.Font)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode1"), System.Windows.Forms.ImeMode)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Location = CType(resources.GetObject("resource.Location1"), System.Drawing.Point)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Name = ""
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Size = CType(resources.GetObject("resource.Size1"), System.Drawing.Size)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex1"), Integer)
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.UseSelectable = True
	 Me.txtmanifTransportadorDataExpedicao.CustomButton.Visible = CType(resources.GetObject("resource.Visible1"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifTransportadorDataExpedicao, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifTransportadorDataExpedicao, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifTransportadorDataExpedicao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifTransportadorDataExpedicao.ForeColor = System.Drawing.Color.Green
	 Me.txtmanifTransportadorDataExpedicao.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifTransportadorDataExpedicao, "txtmanifTransportadorDataExpedicao")
	 Me.txtmanifTransportadorDataExpedicao.MaxLength = 32767
	 Me.txtmanifTransportadorDataExpedicao.Name = "txtmanifTransportadorDataExpedicao"
	 Me.txtmanifTransportadorDataExpedicao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifTransportadorDataExpedicao.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifTransportadorDataExpedicao.SelectedText = ""
	 Me.txtmanifTransportadorDataExpedicao.SelectionLength = 0
	 Me.txtmanifTransportadorDataExpedicao.SelectionStart = 0
	 Me.txtmanifTransportadorDataExpedicao.ShortcutsEnabled = True
	 Me.txtmanifTransportadorDataExpedicao.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifTransportadorDataExpedicao.UseSelectable = True
	 Me.txtmanifTransportadorDataExpedicao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifTransportadorDataExpedicao.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifTransportadorPlacaVeiculo
	 '
	 Me.txtmanifTransportadorPlacaVeiculo.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize2"), Boolean)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle2"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Font = CType(resources.GetObject("resource.Font2"), System.Drawing.Font)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode2"), System.Windows.Forms.ImeMode)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Location = CType(resources.GetObject("resource.Location2"), System.Drawing.Point)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Name = ""
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Size = CType(resources.GetObject("resource.Size2"), System.Drawing.Size)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex2"), Integer)
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.UseSelectable = True
	 Me.txtmanifTransportadorPlacaVeiculo.CustomButton.Visible = CType(resources.GetObject("resource.Visible2"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifTransportadorPlacaVeiculo, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifTransportadorPlacaVeiculo, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifTransportadorPlacaVeiculo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifTransportadorPlacaVeiculo.ForeColor = System.Drawing.Color.DarkGray
	 Me.txtmanifTransportadorPlacaVeiculo.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifTransportadorPlacaVeiculo, "txtmanifTransportadorPlacaVeiculo")
	 Me.txtmanifTransportadorPlacaVeiculo.MaxLength = 32767
	 Me.txtmanifTransportadorPlacaVeiculo.Name = "txtmanifTransportadorPlacaVeiculo"
	 Me.txtmanifTransportadorPlacaVeiculo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifTransportadorPlacaVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifTransportadorPlacaVeiculo.SelectedText = ""
	 Me.txtmanifTransportadorPlacaVeiculo.SelectionLength = 0
	 Me.txtmanifTransportadorPlacaVeiculo.SelectionStart = 0
	 Me.txtmanifTransportadorPlacaVeiculo.ShortcutsEnabled = True
	 Me.txtmanifTransportadorPlacaVeiculo.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifTransportadorPlacaVeiculo.UseSelectable = True
	 Me.txtmanifTransportadorPlacaVeiculo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifTransportadorPlacaVeiculo.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifTransportadorNomeMotorista
	 '
	 Me.txtmanifTransportadorNomeMotorista.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize3"), Boolean)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle3"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Font = CType(resources.GetObject("resource.Font3"), System.Drawing.Font)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode3"), System.Windows.Forms.ImeMode)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Location = CType(resources.GetObject("resource.Location3"), System.Drawing.Point)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Name = ""
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Size = CType(resources.GetObject("resource.Size3"), System.Drawing.Size)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex3"), Integer)
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.UseSelectable = True
	 Me.txtmanifTransportadorNomeMotorista.CustomButton.Visible = CType(resources.GetObject("resource.Visible3"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifTransportadorNomeMotorista, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifTransportadorNomeMotorista, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifTransportadorNomeMotorista.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifTransportadorNomeMotorista.ForeColor = System.Drawing.Color.Blue
	 Me.txtmanifTransportadorNomeMotorista.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifTransportadorNomeMotorista, "txtmanifTransportadorNomeMotorista")
	 Me.txtmanifTransportadorNomeMotorista.MaxLength = 32767
	 Me.txtmanifTransportadorNomeMotorista.Name = "txtmanifTransportadorNomeMotorista"
	 Me.txtmanifTransportadorNomeMotorista.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifTransportadorNomeMotorista.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifTransportadorNomeMotorista.SelectedText = ""
	 Me.txtmanifTransportadorNomeMotorista.SelectionLength = 0
	 Me.txtmanifTransportadorNomeMotorista.SelectionStart = 0
	 Me.txtmanifTransportadorNomeMotorista.ShortcutsEnabled = True
	 Me.txtmanifTransportadorNomeMotorista.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifTransportadorNomeMotorista.UseSelectable = True
	 Me.txtmanifTransportadorNomeMotorista.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifTransportadorNomeMotorista.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifGeradorCargoResponsavel
	 '
	 Me.txtmanifGeradorCargoResponsavel.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize4"), Boolean)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle4"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Font = CType(resources.GetObject("resource.Font4"), System.Drawing.Font)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode4"), System.Windows.Forms.ImeMode)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Location = CType(resources.GetObject("resource.Location4"), System.Drawing.Point)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Name = ""
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Size = CType(resources.GetObject("resource.Size4"), System.Drawing.Size)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex4"), Integer)
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.UseSelectable = True
	 Me.txtmanifGeradorCargoResponsavel.CustomButton.Visible = CType(resources.GetObject("resource.Visible4"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifGeradorCargoResponsavel, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifGeradorCargoResponsavel, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifGeradorCargoResponsavel.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifGeradorCargoResponsavel.ForeColor = System.Drawing.Color.Blue
	 Me.txtmanifGeradorCargoResponsavel.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifGeradorCargoResponsavel, "txtmanifGeradorCargoResponsavel")
	 Me.txtmanifGeradorCargoResponsavel.MaxLength = 32767
	 Me.txtmanifGeradorCargoResponsavel.Name = "txtmanifGeradorCargoResponsavel"
	 Me.txtmanifGeradorCargoResponsavel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifGeradorCargoResponsavel.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifGeradorCargoResponsavel.SelectedText = ""
	 Me.txtmanifGeradorCargoResponsavel.SelectionLength = 0
	 Me.txtmanifGeradorCargoResponsavel.SelectionStart = 0
	 Me.txtmanifGeradorCargoResponsavel.ShortcutsEnabled = True
	 Me.txtmanifGeradorCargoResponsavel.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifGeradorCargoResponsavel.UseSelectable = True
	 Me.txtmanifGeradorCargoResponsavel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifGeradorCargoResponsavel.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifGeradorNomeResponsavel
	 '
	 Me.txtmanifGeradorNomeResponsavel.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize5"), Boolean)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle5"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Font = CType(resources.GetObject("resource.Font5"), System.Drawing.Font)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode5"), System.Windows.Forms.ImeMode)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Location = CType(resources.GetObject("resource.Location5"), System.Drawing.Point)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Name = ""
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Size = CType(resources.GetObject("resource.Size5"), System.Drawing.Size)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex5"), Integer)
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.UseSelectable = True
	 Me.txtmanifGeradorNomeResponsavel.CustomButton.Visible = CType(resources.GetObject("resource.Visible5"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifGeradorNomeResponsavel, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifGeradorNomeResponsavel, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifGeradorNomeResponsavel.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifGeradorNomeResponsavel.ForeColor = System.Drawing.Color.Blue
	 Me.txtmanifGeradorNomeResponsavel.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifGeradorNomeResponsavel, "txtmanifGeradorNomeResponsavel")
	 Me.txtmanifGeradorNomeResponsavel.MaxLength = 32767
	 Me.txtmanifGeradorNomeResponsavel.Name = "txtmanifGeradorNomeResponsavel"
	 Me.txtmanifGeradorNomeResponsavel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifGeradorNomeResponsavel.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifGeradorNomeResponsavel.SelectedText = ""
	 Me.txtmanifGeradorNomeResponsavel.SelectionLength = 0
	 Me.txtmanifGeradorNomeResponsavel.SelectionStart = 0
	 Me.txtmanifGeradorNomeResponsavel.ShortcutsEnabled = True
	 Me.txtmanifGeradorNomeResponsavel.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifGeradorNomeResponsavel.UseSelectable = True
	 Me.txtmanifGeradorNomeResponsavel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifGeradorNomeResponsavel.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifData
	 '
	 Me.txtmanifData.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifData.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize6"), Boolean)
	 Me.txtmanifData.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifData.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle6"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifData.CustomButton.Font = CType(resources.GetObject("resource.Font6"), System.Drawing.Font)
	 Me.txtmanifData.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
	 Me.txtmanifData.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode6"), System.Windows.Forms.ImeMode)
	 Me.txtmanifData.CustomButton.Location = CType(resources.GetObject("resource.Location6"), System.Drawing.Point)
	 Me.txtmanifData.CustomButton.Name = ""
	 Me.txtmanifData.CustomButton.Size = CType(resources.GetObject("resource.Size6"), System.Drawing.Size)
	 Me.txtmanifData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifData.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex6"), Integer)
	 Me.txtmanifData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifData.CustomButton.UseSelectable = True
	 Me.txtmanifData.CustomButton.Visible = CType(resources.GetObject("resource.Visible6"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifData, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifData, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifData.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifData.ForeColor = System.Drawing.Color.Green
	 Me.txtmanifData.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifData, "txtmanifData")
	 Me.txtmanifData.MaxLength = 32767
	 Me.txtmanifData.Name = "txtmanifData"
	 Me.txtmanifData.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifData.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifData.SelectedText = ""
	 Me.txtmanifData.SelectionLength = 0
	 Me.txtmanifData.SelectionStart = 0
	 Me.txtmanifData.ShortcutsEnabled = True
	 Me.txtmanifData.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifData.UseCustomBackColor = True
	 Me.txtmanifData.UseCustomForeColor = True
	 Me.txtmanifData.UseSelectable = True
	 Me.txtmanifData.UseStyleColors = True
	 Me.txtmanifData.WaterMarkColor = System.Drawing.Color.Green
	 Me.txtmanifData.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtsituacaoManifestoCodigo
	 '
	 Me.txtsituacaoManifestoCodigo.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtsituacaoManifestoCodigo.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize7"), Boolean)
	 Me.txtsituacaoManifestoCodigo.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtsituacaoManifestoCodigo.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle7"), System.Windows.Forms.FlatStyle)
	 Me.txtsituacaoManifestoCodigo.CustomButton.Font = CType(resources.GetObject("resource.Font7"), System.Drawing.Font)
	 Me.txtsituacaoManifestoCodigo.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
	 Me.txtsituacaoManifestoCodigo.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode7"), System.Windows.Forms.ImeMode)
	 Me.txtsituacaoManifestoCodigo.CustomButton.Location = CType(resources.GetObject("resource.Location7"), System.Drawing.Point)
	 Me.txtsituacaoManifestoCodigo.CustomButton.Name = ""
	 Me.txtsituacaoManifestoCodigo.CustomButton.Size = CType(resources.GetObject("resource.Size7"), System.Drawing.Size)
	 Me.txtsituacaoManifestoCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtsituacaoManifestoCodigo.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex7"), Integer)
	 Me.txtsituacaoManifestoCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtsituacaoManifestoCodigo.CustomButton.UseSelectable = True
	 Me.txtsituacaoManifestoCodigo.CustomButton.Visible = CType(resources.GetObject("resource.Visible7"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtsituacaoManifestoCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtsituacaoManifestoCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.txtsituacaoManifestoCodigo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtsituacaoManifestoCodigo.ForeColor = System.Drawing.Color.Green
	 Me.txtsituacaoManifestoCodigo.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtsituacaoManifestoCodigo, "txtsituacaoManifestoCodigo")
	 Me.txtsituacaoManifestoCodigo.MaxLength = 32767
	 Me.txtsituacaoManifestoCodigo.Name = "txtsituacaoManifestoCodigo"
	 Me.txtsituacaoManifestoCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtsituacaoManifestoCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtsituacaoManifestoCodigo.SelectedText = ""
	 Me.txtsituacaoManifestoCodigo.SelectionLength = 0
	 Me.txtsituacaoManifestoCodigo.SelectionStart = 0
	 Me.txtsituacaoManifestoCodigo.ShortcutsEnabled = True
	 Me.txtsituacaoManifestoCodigo.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtsituacaoManifestoCodigo.UseSelectable = True
	 Me.txtsituacaoManifestoCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtsituacaoManifestoCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcnpArmazenador
	 '
	 Me.txtcnpArmazenador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcnpArmazenador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize8"), Boolean)
	 Me.txtcnpArmazenador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcnpArmazenador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle8"), System.Windows.Forms.FlatStyle)
	 Me.txtcnpArmazenador.CustomButton.Font = CType(resources.GetObject("resource.Font8"), System.Drawing.Font)
	 Me.txtcnpArmazenador.CustomButton.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
	 Me.txtcnpArmazenador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode8"), System.Windows.Forms.ImeMode)
	 Me.txtcnpArmazenador.CustomButton.Location = CType(resources.GetObject("resource.Location8"), System.Drawing.Point)
	 Me.txtcnpArmazenador.CustomButton.Name = ""
	 Me.txtcnpArmazenador.CustomButton.Size = CType(resources.GetObject("resource.Size8"), System.Drawing.Size)
	 Me.txtcnpArmazenador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpArmazenador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex8"), Integer)
	 Me.txtcnpArmazenador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcnpArmazenador.CustomButton.UseSelectable = True
	 Me.txtcnpArmazenador.CustomButton.Visible = CType(resources.GetObject("resource.Visible8"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcnpArmazenador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcnpArmazenador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcnpArmazenador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcnpArmazenador.ForeColor = System.Drawing.Color.Green
	 Me.txtcnpArmazenador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcnpArmazenador, "txtcnpArmazenador")
	 Me.txtcnpArmazenador.MaxLength = 32767
	 Me.txtcnpArmazenador.Name = "txtcnpArmazenador"
	 Me.txtcnpArmazenador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcnpArmazenador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcnpArmazenador.SelectedText = ""
	 Me.txtcnpArmazenador.SelectionLength = 0
	 Me.txtcnpArmazenador.SelectionStart = 0
	 Me.txtcnpArmazenador.ShortcutsEnabled = True
	 Me.txtcnpArmazenador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpArmazenador.UseSelectable = True
	 Me.txtcnpArmazenador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcnpArmazenador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcnpDestinador
	 '
	 Me.txtcnpDestinador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcnpDestinador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize9"), Boolean)
	 Me.txtcnpDestinador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcnpDestinador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle9"), System.Windows.Forms.FlatStyle)
	 Me.txtcnpDestinador.CustomButton.Font = CType(resources.GetObject("resource.Font9"), System.Drawing.Font)
	 Me.txtcnpDestinador.CustomButton.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
	 Me.txtcnpDestinador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode9"), System.Windows.Forms.ImeMode)
	 Me.txtcnpDestinador.CustomButton.Location = CType(resources.GetObject("resource.Location9"), System.Drawing.Point)
	 Me.txtcnpDestinador.CustomButton.Name = ""
	 Me.txtcnpDestinador.CustomButton.Size = CType(resources.GetObject("resource.Size9"), System.Drawing.Size)
	 Me.txtcnpDestinador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpDestinador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex9"), Integer)
	 Me.txtcnpDestinador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcnpDestinador.CustomButton.UseSelectable = True
	 Me.txtcnpDestinador.CustomButton.Visible = CType(resources.GetObject("resource.Visible9"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcnpDestinador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcnpDestinador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcnpDestinador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcnpDestinador.ForeColor = System.Drawing.Color.Green
	 Me.txtcnpDestinador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcnpDestinador, "txtcnpDestinador")
	 Me.txtcnpDestinador.MaxLength = 32767
	 Me.txtcnpDestinador.Name = "txtcnpDestinador"
	 Me.txtcnpDestinador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcnpDestinador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcnpDestinador.SelectedText = ""
	 Me.txtcnpDestinador.SelectionLength = 0
	 Me.txtcnpDestinador.SelectionStart = 0
	 Me.txtcnpDestinador.ShortcutsEnabled = True
	 Me.txtcnpDestinador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpDestinador.UseSelectable = True
	 Me.txtcnpDestinador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcnpDestinador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcnpTransportador
	 '
	 Me.txtcnpTransportador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcnpTransportador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize10"), Boolean)
	 Me.txtcnpTransportador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcnpTransportador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle10"), System.Windows.Forms.FlatStyle)
	 Me.txtcnpTransportador.CustomButton.Font = CType(resources.GetObject("resource.Font10"), System.Drawing.Font)
	 Me.txtcnpTransportador.CustomButton.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
	 Me.txtcnpTransportador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode10"), System.Windows.Forms.ImeMode)
	 Me.txtcnpTransportador.CustomButton.Location = CType(resources.GetObject("resource.Location10"), System.Drawing.Point)
	 Me.txtcnpTransportador.CustomButton.Name = ""
	 Me.txtcnpTransportador.CustomButton.Size = CType(resources.GetObject("resource.Size10"), System.Drawing.Size)
	 Me.txtcnpTransportador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpTransportador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex10"), Integer)
	 Me.txtcnpTransportador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcnpTransportador.CustomButton.UseSelectable = True
	 Me.txtcnpTransportador.CustomButton.Visible = CType(resources.GetObject("resource.Visible10"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcnpTransportador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcnpTransportador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcnpTransportador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcnpTransportador.ForeColor = System.Drawing.Color.Green
	 Me.txtcnpTransportador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcnpTransportador, "txtcnpTransportador")
	 Me.txtcnpTransportador.MaxLength = 32767
	 Me.txtcnpTransportador.Name = "txtcnpTransportador"
	 Me.txtcnpTransportador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcnpTransportador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcnpTransportador.SelectedText = ""
	 Me.txtcnpTransportador.SelectionLength = 0
	 Me.txtcnpTransportador.SelectionStart = 0
	 Me.txtcnpTransportador.ShortcutsEnabled = True
	 Me.txtcnpTransportador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpTransportador.UseSelectable = True
	 Me.txtcnpTransportador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcnpTransportador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcnpGerador
	 '
	 Me.txtcnpGerador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcnpGerador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize11"), Boolean)
	 Me.txtcnpGerador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcnpGerador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle11"), System.Windows.Forms.FlatStyle)
	 Me.txtcnpGerador.CustomButton.Font = CType(resources.GetObject("resource.Font11"), System.Drawing.Font)
	 Me.txtcnpGerador.CustomButton.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
	 Me.txtcnpGerador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode11"), System.Windows.Forms.ImeMode)
	 Me.txtcnpGerador.CustomButton.Location = CType(resources.GetObject("resource.Location11"), System.Drawing.Point)
	 Me.txtcnpGerador.CustomButton.Name = ""
	 Me.txtcnpGerador.CustomButton.Size = CType(resources.GetObject("resource.Size11"), System.Drawing.Size)
	 Me.txtcnpGerador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpGerador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex11"), Integer)
	 Me.txtcnpGerador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcnpGerador.CustomButton.UseSelectable = True
	 Me.txtcnpGerador.CustomButton.Visible = CType(resources.GetObject("resource.Visible11"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcnpGerador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcnpGerador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcnpGerador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcnpGerador.ForeColor = System.Drawing.Color.Green
	 Me.txtcnpGerador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcnpGerador, "txtcnpGerador")
	 Me.txtcnpGerador.MaxLength = 32767
	 Me.txtcnpGerador.Name = "txtcnpGerador"
	 Me.txtcnpGerador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcnpGerador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcnpGerador.SelectedText = ""
	 Me.txtcnpGerador.SelectionLength = 0
	 Me.txtcnpGerador.SelectionStart = 0
	 Me.txtcnpGerador.ShortcutsEnabled = True
	 Me.txtcnpGerador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcnpGerador.UseSelectable = True
	 Me.txtcnpGerador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcnpGerador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifestoCodigo
	 '
	 Me.txtmanifestoCodigo.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifestoCodigo.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize12"), Boolean)
	 Me.txtmanifestoCodigo.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifestoCodigo.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle12"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifestoCodigo.CustomButton.Font = CType(resources.GetObject("resource.Font12"), System.Drawing.Font)
	 Me.txtmanifestoCodigo.CustomButton.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
	 Me.txtmanifestoCodigo.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode12"), System.Windows.Forms.ImeMode)
	 Me.txtmanifestoCodigo.CustomButton.Location = CType(resources.GetObject("resource.Location12"), System.Drawing.Point)
	 Me.txtmanifestoCodigo.CustomButton.Name = ""
	 Me.txtmanifestoCodigo.CustomButton.Size = CType(resources.GetObject("resource.Size12"), System.Drawing.Size)
	 Me.txtmanifestoCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoCodigo.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex12"), Integer)
	 Me.txtmanifestoCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifestoCodigo.CustomButton.UseSelectable = True
	 Me.txtmanifestoCodigo.CustomButton.Visible = CType(resources.GetObject("resource.Visible12"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifestoCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifestoCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifestoCodigo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifestoCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifestoCodigo.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifestoCodigo, "txtmanifestoCodigo")
	 Me.txtmanifestoCodigo.MaxLength = 32767
	 Me.txtmanifestoCodigo.Name = "txtmanifestoCodigo"
	 Me.txtmanifestoCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifestoCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifestoCodigo.SelectedText = ""
	 Me.txtmanifestoCodigo.SelectionLength = 0
	 Me.txtmanifestoCodigo.SelectionStart = 0
	 Me.txtmanifestoCodigo.ShortcutsEnabled = True
	 Me.txtmanifestoCodigo.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoCodigo.UseSelectable = True
	 Me.txtmanifestoCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifestoCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtquantidade
	 '
	 Me.txtquantidade.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtquantidade.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize13"), Boolean)
	 Me.txtquantidade.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtquantidade.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle13"), System.Windows.Forms.FlatStyle)
	 Me.txtquantidade.CustomButton.Font = CType(resources.GetObject("resource.Font13"), System.Drawing.Font)
	 Me.txtquantidade.CustomButton.Image = CType(resources.GetObject("resource.Image13"), System.Drawing.Image)
	 Me.txtquantidade.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode13"), System.Windows.Forms.ImeMode)
	 Me.txtquantidade.CustomButton.Location = CType(resources.GetObject("resource.Location13"), System.Drawing.Point)
	 Me.txtquantidade.CustomButton.Name = ""
	 Me.txtquantidade.CustomButton.Size = CType(resources.GetObject("resource.Size13"), System.Drawing.Size)
	 Me.txtquantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtquantidade.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex13"), Integer)
	 Me.txtquantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtquantidade.CustomButton.UseSelectable = True
	 Me.txtquantidade.CustomButton.Visible = CType(resources.GetObject("resource.Visible13"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtquantidade, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtquantidade, BunifuAnimatorNS.DecorationType.None)
	 Me.txtquantidade.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtquantidade.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txtquantidade.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtquantidade, "txtquantidade")
	 Me.txtquantidade.MaxLength = 32767
	 Me.txtquantidade.Name = "txtquantidade"
	 Me.txtquantidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtquantidade.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtquantidade.SelectedText = ""
	 Me.txtquantidade.SelectionLength = 0
	 Me.txtquantidade.SelectionStart = 0
	 Me.txtquantidade.ShortcutsEnabled = True
	 Me.txtquantidade.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtquantidade.UseSelectable = True
	 Me.txtquantidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtquantidade.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtclasseDeRisco
	 '
	 Me.txtclasseDeRisco.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtclasseDeRisco.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize14"), Boolean)
	 Me.txtclasseDeRisco.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtclasseDeRisco.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle14"), System.Windows.Forms.FlatStyle)
	 Me.txtclasseDeRisco.CustomButton.Font = CType(resources.GetObject("resource.Font14"), System.Drawing.Font)
	 Me.txtclasseDeRisco.CustomButton.Image = CType(resources.GetObject("resource.Image14"), System.Drawing.Image)
	 Me.txtclasseDeRisco.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode14"), System.Windows.Forms.ImeMode)
	 Me.txtclasseDeRisco.CustomButton.Location = CType(resources.GetObject("resource.Location14"), System.Drawing.Point)
	 Me.txtclasseDeRisco.CustomButton.Name = ""
	 Me.txtclasseDeRisco.CustomButton.Size = CType(resources.GetObject("resource.Size14"), System.Drawing.Size)
	 Me.txtclasseDeRisco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtclasseDeRisco.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex14"), Integer)
	 Me.txtclasseDeRisco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtclasseDeRisco.CustomButton.UseSelectable = True
	 Me.txtclasseDeRisco.CustomButton.Visible = CType(resources.GetObject("resource.Visible14"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtclasseDeRisco, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtclasseDeRisco, BunifuAnimatorNS.DecorationType.None)
	 Me.txtclasseDeRisco.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtclasseDeRisco.ForeColor = System.Drawing.Color.DarkGray
	 Me.txtclasseDeRisco.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtclasseDeRisco, "txtclasseDeRisco")
	 Me.txtclasseDeRisco.MaxLength = 32767
	 Me.txtclasseDeRisco.Name = "txtclasseDeRisco"
	 Me.txtclasseDeRisco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtclasseDeRisco.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtclasseDeRisco.SelectedText = ""
	 Me.txtclasseDeRisco.SelectionLength = 0
	 Me.txtclasseDeRisco.SelectionStart = 0
	 Me.txtclasseDeRisco.ShortcutsEnabled = True
	 Me.txtclasseDeRisco.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtclasseDeRisco.UseSelectable = True
	 Me.txtclasseDeRisco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtclasseDeRisco.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtnumeroONU
	 '
	 Me.txtnumeroONU.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtnumeroONU.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize15"), Boolean)
	 Me.txtnumeroONU.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtnumeroONU.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle15"), System.Windows.Forms.FlatStyle)
	 Me.txtnumeroONU.CustomButton.Font = CType(resources.GetObject("resource.Font15"), System.Drawing.Font)
	 Me.txtnumeroONU.CustomButton.Image = CType(resources.GetObject("resource.Image15"), System.Drawing.Image)
	 Me.txtnumeroONU.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode15"), System.Windows.Forms.ImeMode)
	 Me.txtnumeroONU.CustomButton.Location = CType(resources.GetObject("resource.Location15"), System.Drawing.Point)
	 Me.txtnumeroONU.CustomButton.Name = ""
	 Me.txtnumeroONU.CustomButton.Size = CType(resources.GetObject("resource.Size15"), System.Drawing.Size)
	 Me.txtnumeroONU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtnumeroONU.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex15"), Integer)
	 Me.txtnumeroONU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtnumeroONU.CustomButton.UseSelectable = True
	 Me.txtnumeroONU.CustomButton.Visible = CType(resources.GetObject("resource.Visible15"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtnumeroONU, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtnumeroONU, BunifuAnimatorNS.DecorationType.None)
	 Me.txtnumeroONU.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtnumeroONU.ForeColor = System.Drawing.Color.DarkGray
	 Me.txtnumeroONU.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtnumeroONU, "txtnumeroONU")
	 Me.txtnumeroONU.MaxLength = 32767
	 Me.txtnumeroONU.Name = "txtnumeroONU"
	 Me.txtnumeroONU.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtnumeroONU.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtnumeroONU.SelectedText = ""
	 Me.txtnumeroONU.SelectionLength = 0
	 Me.txtnumeroONU.SelectionStart = 0
	 Me.txtnumeroONU.ShortcutsEnabled = True
	 Me.txtnumeroONU.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtnumeroONU.UseSelectable = True
	 Me.txtnumeroONU.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtnumeroONU.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txttipoDensidadeUnidade
	 '
	 Me.txttipoDensidadeUnidade.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txttipoDensidadeUnidade.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize16"), Boolean)
	 Me.txttipoDensidadeUnidade.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txttipoDensidadeUnidade.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle16"), System.Windows.Forms.FlatStyle)
	 Me.txttipoDensidadeUnidade.CustomButton.Font = CType(resources.GetObject("resource.Font16"), System.Drawing.Font)
	 Me.txttipoDensidadeUnidade.CustomButton.Image = CType(resources.GetObject("resource.Image16"), System.Drawing.Image)
	 Me.txttipoDensidadeUnidade.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode16"), System.Windows.Forms.ImeMode)
	 Me.txttipoDensidadeUnidade.CustomButton.Location = CType(resources.GetObject("resource.Location16"), System.Drawing.Point)
	 Me.txttipoDensidadeUnidade.CustomButton.Name = ""
	 Me.txttipoDensidadeUnidade.CustomButton.Size = CType(resources.GetObject("resource.Size16"), System.Drawing.Size)
	 Me.txttipoDensidadeUnidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txttipoDensidadeUnidade.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex16"), Integer)
	 Me.txttipoDensidadeUnidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txttipoDensidadeUnidade.CustomButton.UseSelectable = True
	 Me.txttipoDensidadeUnidade.CustomButton.Visible = CType(resources.GetObject("resource.Visible16"), Boolean)
	 Me.Efeito.SetDecoration(Me.txttipoDensidadeUnidade, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txttipoDensidadeUnidade, BunifuAnimatorNS.DecorationType.None)
	 Me.txttipoDensidadeUnidade.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txttipoDensidadeUnidade.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txttipoDensidadeUnidade.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txttipoDensidadeUnidade, "txttipoDensidadeUnidade")
	 Me.txttipoDensidadeUnidade.MaxLength = 32767
	 Me.txttipoDensidadeUnidade.Name = "txttipoDensidadeUnidade"
	 Me.txttipoDensidadeUnidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txttipoDensidadeUnidade.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txttipoDensidadeUnidade.SelectedText = ""
	 Me.txttipoDensidadeUnidade.SelectionLength = 0
	 Me.txttipoDensidadeUnidade.SelectionStart = 0
	 Me.txttipoDensidadeUnidade.ShortcutsEnabled = True
	 Me.txttipoDensidadeUnidade.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txttipoDensidadeUnidade.UseSelectable = True
	 Me.txttipoDensidadeUnidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txttipoDensidadeUnidade.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtretornoCodigo
	 '
	 Me.txtretornoCodigo.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtretornoCodigo.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize17"), Boolean)
	 Me.txtretornoCodigo.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtretornoCodigo.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle17"), System.Windows.Forms.FlatStyle)
	 Me.txtretornoCodigo.CustomButton.Font = CType(resources.GetObject("resource.Font17"), System.Drawing.Font)
	 Me.txtretornoCodigo.CustomButton.Image = CType(resources.GetObject("resource.Image17"), System.Drawing.Image)
	 Me.txtretornoCodigo.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode17"), System.Windows.Forms.ImeMode)
	 Me.txtretornoCodigo.CustomButton.Location = CType(resources.GetObject("resource.Location17"), System.Drawing.Point)
	 Me.txtretornoCodigo.CustomButton.Name = ""
	 Me.txtretornoCodigo.CustomButton.Size = CType(resources.GetObject("resource.Size17"), System.Drawing.Size)
	 Me.txtretornoCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtretornoCodigo.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex17"), Integer)
	 Me.txtretornoCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtretornoCodigo.CustomButton.UseSelectable = True
	 Me.txtretornoCodigo.CustomButton.Visible = CType(resources.GetObject("resource.Visible17"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtretornoCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtretornoCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.txtretornoCodigo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtretornoCodigo.ForeColor = System.Drawing.Color.Green
	 Me.txtretornoCodigo.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtretornoCodigo, "txtretornoCodigo")
	 Me.txtretornoCodigo.MaxLength = 32767
	 Me.txtretornoCodigo.Name = "txtretornoCodigo"
	 Me.txtretornoCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtretornoCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtretornoCodigo.SelectedText = ""
	 Me.txtretornoCodigo.SelectionLength = 0
	 Me.txtretornoCodigo.SelectionStart = 0
	 Me.txtretornoCodigo.ShortcutsEnabled = True
	 Me.txtretornoCodigo.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtretornoCodigo.UseSelectable = True
	 Me.txtretornoCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtretornoCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodUnidadeGerador
	 '
	 Me.txtcodUnidadeGerador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodUnidadeGerador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize18"), Boolean)
	 Me.txtcodUnidadeGerador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodUnidadeGerador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle18"), System.Windows.Forms.FlatStyle)
	 Me.txtcodUnidadeGerador.CustomButton.Font = CType(resources.GetObject("resource.Font18"), System.Drawing.Font)
	 Me.txtcodUnidadeGerador.CustomButton.Image = CType(resources.GetObject("resource.Image18"), System.Drawing.Image)
	 Me.txtcodUnidadeGerador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode18"), System.Windows.Forms.ImeMode)
	 Me.txtcodUnidadeGerador.CustomButton.Location = CType(resources.GetObject("resource.Location18"), System.Drawing.Point)
	 Me.txtcodUnidadeGerador.CustomButton.Name = ""
	 Me.txtcodUnidadeGerador.CustomButton.Size = CType(resources.GetObject("resource.Size18"), System.Drawing.Size)
	 Me.txtcodUnidadeGerador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeGerador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex18"), Integer)
	 Me.txtcodUnidadeGerador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodUnidadeGerador.CustomButton.UseSelectable = True
	 Me.txtcodUnidadeGerador.CustomButton.Visible = CType(resources.GetObject("resource.Visible18"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodUnidadeGerador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodUnidadeGerador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodUnidadeGerador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodUnidadeGerador.ForeColor = System.Drawing.Color.Green
	 Me.txtcodUnidadeGerador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodUnidadeGerador, "txtcodUnidadeGerador")
	 Me.txtcodUnidadeGerador.MaxLength = 32767
	 Me.txtcodUnidadeGerador.Name = "txtcodUnidadeGerador"
	 Me.txtcodUnidadeGerador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodUnidadeGerador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodUnidadeGerador.SelectedText = ""
	 Me.txtcodUnidadeGerador.SelectionLength = 0
	 Me.txtcodUnidadeGerador.SelectionStart = 0
	 Me.txtcodUnidadeGerador.ShortcutsEnabled = True
	 Me.txtcodUnidadeGerador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeGerador.UseSelectable = True
	 Me.txtcodUnidadeGerador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodUnidadeGerador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodUnidadeTransportador
	 '
	 Me.txtcodUnidadeTransportador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodUnidadeTransportador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize19"), Boolean)
	 Me.txtcodUnidadeTransportador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodUnidadeTransportador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle19"), System.Windows.Forms.FlatStyle)
	 Me.txtcodUnidadeTransportador.CustomButton.Font = CType(resources.GetObject("resource.Font19"), System.Drawing.Font)
	 Me.txtcodUnidadeTransportador.CustomButton.Image = CType(resources.GetObject("resource.Image19"), System.Drawing.Image)
	 Me.txtcodUnidadeTransportador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode19"), System.Windows.Forms.ImeMode)
	 Me.txtcodUnidadeTransportador.CustomButton.Location = CType(resources.GetObject("resource.Location19"), System.Drawing.Point)
	 Me.txtcodUnidadeTransportador.CustomButton.Name = ""
	 Me.txtcodUnidadeTransportador.CustomButton.Size = CType(resources.GetObject("resource.Size19"), System.Drawing.Size)
	 Me.txtcodUnidadeTransportador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeTransportador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex19"), Integer)
	 Me.txtcodUnidadeTransportador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodUnidadeTransportador.CustomButton.UseSelectable = True
	 Me.txtcodUnidadeTransportador.CustomButton.Visible = CType(resources.GetObject("resource.Visible19"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodUnidadeTransportador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodUnidadeTransportador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodUnidadeTransportador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodUnidadeTransportador.ForeColor = System.Drawing.Color.Green
	 Me.txtcodUnidadeTransportador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodUnidadeTransportador, "txtcodUnidadeTransportador")
	 Me.txtcodUnidadeTransportador.MaxLength = 32767
	 Me.txtcodUnidadeTransportador.Name = "txtcodUnidadeTransportador"
	 Me.txtcodUnidadeTransportador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodUnidadeTransportador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodUnidadeTransportador.SelectedText = ""
	 Me.txtcodUnidadeTransportador.SelectionLength = 0
	 Me.txtcodUnidadeTransportador.SelectionStart = 0
	 Me.txtcodUnidadeTransportador.ShortcutsEnabled = True
	 Me.txtcodUnidadeTransportador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeTransportador.UseSelectable = True
	 Me.txtcodUnidadeTransportador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodUnidadeTransportador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodUnidadeArmazenador
	 '
	 Me.txtcodUnidadeArmazenador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodUnidadeArmazenador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize20"), Boolean)
	 Me.txtcodUnidadeArmazenador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodUnidadeArmazenador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle20"), System.Windows.Forms.FlatStyle)
	 Me.txtcodUnidadeArmazenador.CustomButton.Font = CType(resources.GetObject("resource.Font20"), System.Drawing.Font)
	 Me.txtcodUnidadeArmazenador.CustomButton.Image = CType(resources.GetObject("resource.Image20"), System.Drawing.Image)
	 Me.txtcodUnidadeArmazenador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode20"), System.Windows.Forms.ImeMode)
	 Me.txtcodUnidadeArmazenador.CustomButton.Location = CType(resources.GetObject("resource.Location20"), System.Drawing.Point)
	 Me.txtcodUnidadeArmazenador.CustomButton.Name = ""
	 Me.txtcodUnidadeArmazenador.CustomButton.Size = CType(resources.GetObject("resource.Size20"), System.Drawing.Size)
	 Me.txtcodUnidadeArmazenador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeArmazenador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex20"), Integer)
	 Me.txtcodUnidadeArmazenador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodUnidadeArmazenador.CustomButton.UseSelectable = True
	 Me.txtcodUnidadeArmazenador.CustomButton.Visible = CType(resources.GetObject("resource.Visible20"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodUnidadeArmazenador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodUnidadeArmazenador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodUnidadeArmazenador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodUnidadeArmazenador.ForeColor = System.Drawing.Color.Green
	 Me.txtcodUnidadeArmazenador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodUnidadeArmazenador, "txtcodUnidadeArmazenador")
	 Me.txtcodUnidadeArmazenador.MaxLength = 32767
	 Me.txtcodUnidadeArmazenador.Name = "txtcodUnidadeArmazenador"
	 Me.txtcodUnidadeArmazenador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodUnidadeArmazenador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodUnidadeArmazenador.SelectedText = ""
	 Me.txtcodUnidadeArmazenador.SelectionLength = 0
	 Me.txtcodUnidadeArmazenador.SelectionStart = 0
	 Me.txtcodUnidadeArmazenador.ShortcutsEnabled = True
	 Me.txtcodUnidadeArmazenador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeArmazenador.UseSelectable = True
	 Me.txtcodUnidadeArmazenador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodUnidadeArmazenador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifDataExpedicao
	 '
	 Me.txtmanifDataExpedicao.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifDataExpedicao.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize21"), Boolean)
	 Me.txtmanifDataExpedicao.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifDataExpedicao.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle21"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifDataExpedicao.CustomButton.Font = CType(resources.GetObject("resource.Font21"), System.Drawing.Font)
	 Me.txtmanifDataExpedicao.CustomButton.Image = CType(resources.GetObject("resource.Image21"), System.Drawing.Image)
	 Me.txtmanifDataExpedicao.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode21"), System.Windows.Forms.ImeMode)
	 Me.txtmanifDataExpedicao.CustomButton.Location = CType(resources.GetObject("resource.Location21"), System.Drawing.Point)
	 Me.txtmanifDataExpedicao.CustomButton.Name = ""
	 Me.txtmanifDataExpedicao.CustomButton.Size = CType(resources.GetObject("resource.Size21"), System.Drawing.Size)
	 Me.txtmanifDataExpedicao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifDataExpedicao.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex21"), Integer)
	 Me.txtmanifDataExpedicao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifDataExpedicao.CustomButton.UseSelectable = True
	 Me.txtmanifDataExpedicao.CustomButton.Visible = CType(resources.GetObject("resource.Visible21"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifDataExpedicao, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifDataExpedicao, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifDataExpedicao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifDataExpedicao.ForeColor = System.Drawing.Color.DarkGray
	 Me.txtmanifDataExpedicao.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifDataExpedicao, "txtmanifDataExpedicao")
	 Me.txtmanifDataExpedicao.MaxLength = 32767
	 Me.txtmanifDataExpedicao.Name = "txtmanifDataExpedicao"
	 Me.txtmanifDataExpedicao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifDataExpedicao.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifDataExpedicao.SelectedText = ""
	 Me.txtmanifDataExpedicao.SelectionLength = 0
	 Me.txtmanifDataExpedicao.SelectionStart = 0
	 Me.txtmanifDataExpedicao.ShortcutsEnabled = True
	 Me.txtmanifDataExpedicao.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifDataExpedicao.UseSelectable = True
	 Me.txtmanifDataExpedicao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifDataExpedicao.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifDataRecebimento
	 '
	 Me.txtmanifDataRecebimento.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifDataRecebimento.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize22"), Boolean)
	 Me.txtmanifDataRecebimento.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifDataRecebimento.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle22"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifDataRecebimento.CustomButton.Font = CType(resources.GetObject("resource.Font22"), System.Drawing.Font)
	 Me.txtmanifDataRecebimento.CustomButton.Image = CType(resources.GetObject("resource.Image22"), System.Drawing.Image)
	 Me.txtmanifDataRecebimento.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode22"), System.Windows.Forms.ImeMode)
	 Me.txtmanifDataRecebimento.CustomButton.Location = CType(resources.GetObject("resource.Location22"), System.Drawing.Point)
	 Me.txtmanifDataRecebimento.CustomButton.Name = ""
	 Me.txtmanifDataRecebimento.CustomButton.Size = CType(resources.GetObject("resource.Size22"), System.Drawing.Size)
	 Me.txtmanifDataRecebimento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifDataRecebimento.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex22"), Integer)
	 Me.txtmanifDataRecebimento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifDataRecebimento.CustomButton.UseSelectable = True
	 Me.txtmanifDataRecebimento.CustomButton.Visible = CType(resources.GetObject("resource.Visible22"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifDataRecebimento, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifDataRecebimento, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifDataRecebimento.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifDataRecebimento.ForeColor = System.Drawing.Color.Red
	 Me.txtmanifDataRecebimento.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifDataRecebimento, "txtmanifDataRecebimento")
	 Me.txtmanifDataRecebimento.MaxLength = 32767
	 Me.txtmanifDataRecebimento.Name = "txtmanifDataRecebimento"
	 Me.txtmanifDataRecebimento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifDataRecebimento.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifDataRecebimento.SelectedText = ""
	 Me.txtmanifDataRecebimento.SelectionLength = 0
	 Me.txtmanifDataRecebimento.SelectionStart = 0
	 Me.txtmanifDataRecebimento.ShortcutsEnabled = True
	 Me.txtmanifDataRecebimento.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifDataRecebimento.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifDataRecebimento.UseCustomBackColor = True
	 Me.txtmanifDataRecebimento.UseCustomForeColor = True
	 Me.txtmanifDataRecebimento.UseSelectable = True
	 Me.txtmanifDataRecebimento.UseStyleColors = True
	 Me.txtmanifDataRecebimento.WaterMarkColor = System.Drawing.Color.Red
	 Me.txtmanifDataRecebimento.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtretorno
	 '
	 Me.txtretorno.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtretorno.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize23"), Boolean)
	 Me.txtretorno.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtretorno.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle23"), System.Windows.Forms.FlatStyle)
	 Me.txtretorno.CustomButton.Font = CType(resources.GetObject("resource.Font23"), System.Drawing.Font)
	 Me.txtretorno.CustomButton.Image = CType(resources.GetObject("resource.Image23"), System.Drawing.Image)
	 Me.txtretorno.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode23"), System.Windows.Forms.ImeMode)
	 Me.txtretorno.CustomButton.Location = CType(resources.GetObject("resource.Location23"), System.Drawing.Point)
	 Me.txtretorno.CustomButton.Name = ""
	 Me.txtretorno.CustomButton.Size = CType(resources.GetObject("resource.Size23"), System.Drawing.Size)
	 Me.txtretorno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtretorno.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex23"), Integer)
	 Me.txtretorno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtretorno.CustomButton.UseSelectable = True
	 Me.txtretorno.CustomButton.Visible = CType(resources.GetObject("resource.Visible23"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtretorno, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtretorno, BunifuAnimatorNS.DecorationType.None)
	 Me.txtretorno.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtretorno.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txtretorno.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtretorno, "txtretorno")
	 Me.txtretorno.MaxLength = 32767
	 Me.txtretorno.Name = "txtretorno"
	 Me.txtretorno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtretorno.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtretorno.SelectedText = ""
	 Me.txtretorno.SelectionLength = 0
	 Me.txtretorno.SelectionStart = 0
	 Me.txtretorno.ShortcutsEnabled = True
	 Me.txtretorno.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtretorno.UseSelectable = True
	 Me.txtretorno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtretorno.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoSequencial
	 '
	 Me.txtcodigoSequencial.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoSequencial.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize24"), Boolean)
	 Me.txtcodigoSequencial.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoSequencial.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle24"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoSequencial.CustomButton.Font = CType(resources.GetObject("resource.Font24"), System.Drawing.Font)
	 Me.txtcodigoSequencial.CustomButton.Image = CType(resources.GetObject("resource.Image24"), System.Drawing.Image)
	 Me.txtcodigoSequencial.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode24"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoSequencial.CustomButton.Location = CType(resources.GetObject("resource.Location24"), System.Drawing.Point)
	 Me.txtcodigoSequencial.CustomButton.Name = ""
	 Me.txtcodigoSequencial.CustomButton.Size = CType(resources.GetObject("resource.Size24"), System.Drawing.Size)
	 Me.txtcodigoSequencial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoSequencial.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex24"), Integer)
	 Me.txtcodigoSequencial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoSequencial.CustomButton.UseSelectable = True
	 Me.txtcodigoSequencial.CustomButton.Visible = CType(resources.GetObject("resource.Visible24"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoSequencial, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoSequencial, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoSequencial.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoSequencial.ForeColor = System.Drawing.Color.DarkGray
	 Me.txtcodigoSequencial.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoSequencial, "txtcodigoSequencial")
	 Me.txtcodigoSequencial.MaxLength = 32767
	 Me.txtcodigoSequencial.Name = "txtcodigoSequencial"
	 Me.txtcodigoSequencial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoSequencial.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoSequencial.SelectedText = ""
	 Me.txtcodigoSequencial.SelectionLength = 0
	 Me.txtcodigoSequencial.SelectionStart = 0
	 Me.txtcodigoSequencial.ShortcutsEnabled = True
	 Me.txtcodigoSequencial.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoSequencial.UseSelectable = True
	 Me.txtcodigoSequencial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoSequencial.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtjustificativa
	 '
	 Me.txtjustificativa.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtjustificativa.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize25"), Boolean)
	 Me.txtjustificativa.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtjustificativa.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle25"), System.Windows.Forms.FlatStyle)
	 Me.txtjustificativa.CustomButton.Font = CType(resources.GetObject("resource.Font25"), System.Drawing.Font)
	 Me.txtjustificativa.CustomButton.Image = CType(resources.GetObject("resource.Image25"), System.Drawing.Image)
	 Me.txtjustificativa.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode25"), System.Windows.Forms.ImeMode)
	 Me.txtjustificativa.CustomButton.Location = CType(resources.GetObject("resource.Location25"), System.Drawing.Point)
	 Me.txtjustificativa.CustomButton.Name = ""
	 Me.txtjustificativa.CustomButton.Size = CType(resources.GetObject("resource.Size25"), System.Drawing.Size)
	 Me.txtjustificativa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtjustificativa.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex25"), Integer)
	 Me.txtjustificativa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtjustificativa.CustomButton.UseSelectable = True
	 Me.txtjustificativa.CustomButton.Visible = CType(resources.GetObject("resource.Visible25"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtjustificativa, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtjustificativa, BunifuAnimatorNS.DecorationType.None)
	 Me.txtjustificativa.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtjustificativa.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txtjustificativa.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtjustificativa, "txtjustificativa")
	 Me.txtjustificativa.MaxLength = 32767
	 Me.txtjustificativa.Name = "txtjustificativa"
	 Me.txtjustificativa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtjustificativa.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtjustificativa.SelectedText = ""
	 Me.txtjustificativa.SelectionLength = 0
	 Me.txtjustificativa.SelectionStart = 0
	 Me.txtjustificativa.ShortcutsEnabled = True
	 Me.txtjustificativa.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtjustificativa.UseSelectable = True
	 Me.txtjustificativa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtjustificativa.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoInterno
	 '
	 Me.txtcodigoInterno.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoInterno.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize26"), Boolean)
	 Me.txtcodigoInterno.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoInterno.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle26"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoInterno.CustomButton.Font = CType(resources.GetObject("resource.Font26"), System.Drawing.Font)
	 Me.txtcodigoInterno.CustomButton.Image = CType(resources.GetObject("resource.Image26"), System.Drawing.Image)
	 Me.txtcodigoInterno.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode26"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoInterno.CustomButton.Location = CType(resources.GetObject("resource.Location26"), System.Drawing.Point)
	 Me.txtcodigoInterno.CustomButton.Name = ""
	 Me.txtcodigoInterno.CustomButton.Size = CType(resources.GetObject("resource.Size26"), System.Drawing.Size)
	 Me.txtcodigoInterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoInterno.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex26"), Integer)
	 Me.txtcodigoInterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoInterno.CustomButton.UseSelectable = True
	 Me.txtcodigoInterno.CustomButton.Visible = CType(resources.GetObject("resource.Visible26"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoInterno, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoInterno, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoInterno.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoInterno.ForeColor = System.Drawing.Color.DarkGray
	 Me.txtcodigoInterno.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoInterno, "txtcodigoInterno")
	 Me.txtcodigoInterno.MaxLength = 32767
	 Me.txtcodigoInterno.Name = "txtcodigoInterno"
	 Me.txtcodigoInterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoInterno.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoInterno.SelectedText = ""
	 Me.txtcodigoInterno.SelectionLength = 0
	 Me.txtcodigoInterno.SelectionStart = 0
	 Me.txtcodigoInterno.ShortcutsEnabled = True
	 Me.txtcodigoInterno.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoInterno.UseSelectable = True
	 Me.txtcodigoInterno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoInterno.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoClasse
	 '
	 Me.txtcodigoClasse.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoClasse.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize27"), Boolean)
	 Me.txtcodigoClasse.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoClasse.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle27"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoClasse.CustomButton.Font = CType(resources.GetObject("resource.Font27"), System.Drawing.Font)
	 Me.txtcodigoClasse.CustomButton.Image = CType(resources.GetObject("resource.Image27"), System.Drawing.Image)
	 Me.txtcodigoClasse.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode27"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoClasse.CustomButton.Location = CType(resources.GetObject("resource.Location27"), System.Drawing.Point)
	 Me.txtcodigoClasse.CustomButton.Name = ""
	 Me.txtcodigoClasse.CustomButton.Size = CType(resources.GetObject("resource.Size27"), System.Drawing.Size)
	 Me.txtcodigoClasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoClasse.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex27"), Integer)
	 Me.txtcodigoClasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoClasse.CustomButton.UseSelectable = True
	 Me.txtcodigoClasse.CustomButton.Visible = CType(resources.GetObject("resource.Visible27"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoClasse, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoClasse, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoClasse.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoClasse.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txtcodigoClasse.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoClasse, "txtcodigoClasse")
	 Me.txtcodigoClasse.MaxLength = 32767
	 Me.txtcodigoClasse.Name = "txtcodigoClasse"
	 Me.txtcodigoClasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoClasse.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoClasse.SelectedText = ""
	 Me.txtcodigoClasse.SelectionLength = 0
	 Me.txtcodigoClasse.SelectionStart = 0
	 Me.txtcodigoClasse.ShortcutsEnabled = True
	 Me.txtcodigoClasse.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoClasse.UseSelectable = True
	 Me.txtcodigoClasse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoClasse.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoTipoEstado
	 '
	 Me.txtcodigoTipoEstado.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoTipoEstado.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize28"), Boolean)
	 Me.txtcodigoTipoEstado.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoTipoEstado.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle28"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoTipoEstado.CustomButton.Font = CType(resources.GetObject("resource.Font28"), System.Drawing.Font)
	 Me.txtcodigoTipoEstado.CustomButton.Image = CType(resources.GetObject("resource.Image28"), System.Drawing.Image)
	 Me.txtcodigoTipoEstado.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode28"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoTipoEstado.CustomButton.Location = CType(resources.GetObject("resource.Location28"), System.Drawing.Point)
	 Me.txtcodigoTipoEstado.CustomButton.Name = ""
	 Me.txtcodigoTipoEstado.CustomButton.Size = CType(resources.GetObject("resource.Size28"), System.Drawing.Size)
	 Me.txtcodigoTipoEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoTipoEstado.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex28"), Integer)
	 Me.txtcodigoTipoEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoTipoEstado.CustomButton.UseSelectable = True
	 Me.txtcodigoTipoEstado.CustomButton.Visible = CType(resources.GetObject("resource.Visible28"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoTipoEstado, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoTipoEstado, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoTipoEstado.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoTipoEstado.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txtcodigoTipoEstado.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoTipoEstado, "txtcodigoTipoEstado")
	 Me.txtcodigoTipoEstado.MaxLength = 32767
	 Me.txtcodigoTipoEstado.Name = "txtcodigoTipoEstado"
	 Me.txtcodigoTipoEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoTipoEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoTipoEstado.SelectedText = ""
	 Me.txtcodigoTipoEstado.SelectionLength = 0
	 Me.txtcodigoTipoEstado.SelectionStart = 0
	 Me.txtcodigoTipoEstado.ShortcutsEnabled = True
	 Me.txtcodigoTipoEstado.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoTipoEstado.UseSelectable = True
	 Me.txtcodigoTipoEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoTipoEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoUnidade
	 '
	 Me.txtcodigoUnidade.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoUnidade.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize29"), Boolean)
	 Me.txtcodigoUnidade.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoUnidade.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle29"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoUnidade.CustomButton.Font = CType(resources.GetObject("resource.Font29"), System.Drawing.Font)
	 Me.txtcodigoUnidade.CustomButton.Image = CType(resources.GetObject("resource.Image29"), System.Drawing.Image)
	 Me.txtcodigoUnidade.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode29"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoUnidade.CustomButton.Location = CType(resources.GetObject("resource.Location29"), System.Drawing.Point)
	 Me.txtcodigoUnidade.CustomButton.Name = ""
	 Me.txtcodigoUnidade.CustomButton.Size = CType(resources.GetObject("resource.Size29"), System.Drawing.Size)
	 Me.txtcodigoUnidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoUnidade.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex29"), Integer)
	 Me.txtcodigoUnidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoUnidade.CustomButton.UseSelectable = True
	 Me.txtcodigoUnidade.CustomButton.Visible = CType(resources.GetObject("resource.Visible29"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoUnidade, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoUnidade, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoUnidade.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoUnidade.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txtcodigoUnidade.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoUnidade, "txtcodigoUnidade")
	 Me.txtcodigoUnidade.MaxLength = 32767
	 Me.txtcodigoUnidade.Name = "txtcodigoUnidade"
	 Me.txtcodigoUnidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoUnidade.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoUnidade.SelectedText = ""
	 Me.txtcodigoUnidade.SelectionLength = 0
	 Me.txtcodigoUnidade.SelectionStart = 0
	 Me.txtcodigoUnidade.ShortcutsEnabled = True
	 Me.txtcodigoUnidade.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoUnidade.UseSelectable = True
	 Me.txtcodigoUnidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoUnidade.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txttipoDensidadeValor
	 '
	 Me.txttipoDensidadeValor.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txttipoDensidadeValor.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize30"), Boolean)
	 Me.txttipoDensidadeValor.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txttipoDensidadeValor.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle30"), System.Windows.Forms.FlatStyle)
	 Me.txttipoDensidadeValor.CustomButton.Font = CType(resources.GetObject("resource.Font30"), System.Drawing.Font)
	 Me.txttipoDensidadeValor.CustomButton.Image = CType(resources.GetObject("resource.Image30"), System.Drawing.Image)
	 Me.txttipoDensidadeValor.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode30"), System.Windows.Forms.ImeMode)
	 Me.txttipoDensidadeValor.CustomButton.Location = CType(resources.GetObject("resource.Location30"), System.Drawing.Point)
	 Me.txttipoDensidadeValor.CustomButton.Name = ""
	 Me.txttipoDensidadeValor.CustomButton.Size = CType(resources.GetObject("resource.Size30"), System.Drawing.Size)
	 Me.txttipoDensidadeValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txttipoDensidadeValor.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex30"), Integer)
	 Me.txttipoDensidadeValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txttipoDensidadeValor.CustomButton.UseSelectable = True
	 Me.txttipoDensidadeValor.CustomButton.Visible = CType(resources.GetObject("resource.Visible30"), Boolean)
	 Me.Efeito.SetDecoration(Me.txttipoDensidadeValor, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txttipoDensidadeValor, BunifuAnimatorNS.DecorationType.None)
	 Me.txttipoDensidadeValor.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txttipoDensidadeValor.ForeColor = System.Drawing.Color.DarkGreen
	 Me.txttipoDensidadeValor.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txttipoDensidadeValor, "txttipoDensidadeValor")
	 Me.txttipoDensidadeValor.MaxLength = 32767
	 Me.txttipoDensidadeValor.Name = "txttipoDensidadeValor"
	 Me.txttipoDensidadeValor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txttipoDensidadeValor.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txttipoDensidadeValor.SelectedText = ""
	 Me.txttipoDensidadeValor.SelectionLength = 0
	 Me.txttipoDensidadeValor.SelectionStart = 0
	 Me.txttipoDensidadeValor.ShortcutsEnabled = True
	 Me.txttipoDensidadeValor.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txttipoDensidadeValor.UseSelectable = True
	 Me.txttipoDensidadeValor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txttipoDensidadeValor.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtgrupoEmbalagem
	 '
	 Me.txtgrupoEmbalagem.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtgrupoEmbalagem.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize31"), Boolean)
	 Me.txtgrupoEmbalagem.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtgrupoEmbalagem.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle31"), System.Windows.Forms.FlatStyle)
	 Me.txtgrupoEmbalagem.CustomButton.Font = CType(resources.GetObject("resource.Font31"), System.Drawing.Font)
	 Me.txtgrupoEmbalagem.CustomButton.Image = CType(resources.GetObject("resource.Image31"), System.Drawing.Image)
	 Me.txtgrupoEmbalagem.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode31"), System.Windows.Forms.ImeMode)
	 Me.txtgrupoEmbalagem.CustomButton.Location = CType(resources.GetObject("resource.Location31"), System.Drawing.Point)
	 Me.txtgrupoEmbalagem.CustomButton.Name = ""
	 Me.txtgrupoEmbalagem.CustomButton.Size = CType(resources.GetObject("resource.Size31"), System.Drawing.Size)
	 Me.txtgrupoEmbalagem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtgrupoEmbalagem.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex31"), Integer)
	 Me.txtgrupoEmbalagem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtgrupoEmbalagem.CustomButton.UseSelectable = True
	 Me.txtgrupoEmbalagem.CustomButton.Visible = CType(resources.GetObject("resource.Visible31"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtgrupoEmbalagem, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtgrupoEmbalagem, BunifuAnimatorNS.DecorationType.None)
	 Me.txtgrupoEmbalagem.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtgrupoEmbalagem.ForeColor = System.Drawing.Color.Tomato
	 Me.txtgrupoEmbalagem.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtgrupoEmbalagem, "txtgrupoEmbalagem")
	 Me.txtgrupoEmbalagem.MaxLength = 32767
	 Me.txtgrupoEmbalagem.Name = "txtgrupoEmbalagem"
	 Me.txtgrupoEmbalagem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtgrupoEmbalagem.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtgrupoEmbalagem.SelectedText = ""
	 Me.txtgrupoEmbalagem.SelectionLength = 0
	 Me.txtgrupoEmbalagem.SelectionStart = 0
	 Me.txtgrupoEmbalagem.ShortcutsEnabled = True
	 Me.txtgrupoEmbalagem.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtgrupoEmbalagem.UseSelectable = True
	 Me.txtgrupoEmbalagem.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtgrupoEmbalagem.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtnomeEmbarque
	 '
	 Me.txtnomeEmbarque.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtnomeEmbarque.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize32"), Boolean)
	 Me.txtnomeEmbarque.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtnomeEmbarque.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle32"), System.Windows.Forms.FlatStyle)
	 Me.txtnomeEmbarque.CustomButton.Font = CType(resources.GetObject("resource.Font32"), System.Drawing.Font)
	 Me.txtnomeEmbarque.CustomButton.Image = CType(resources.GetObject("resource.Image32"), System.Drawing.Image)
	 Me.txtnomeEmbarque.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode32"), System.Windows.Forms.ImeMode)
	 Me.txtnomeEmbarque.CustomButton.Location = CType(resources.GetObject("resource.Location32"), System.Drawing.Point)
	 Me.txtnomeEmbarque.CustomButton.Name = ""
	 Me.txtnomeEmbarque.CustomButton.Size = CType(resources.GetObject("resource.Size32"), System.Drawing.Size)
	 Me.txtnomeEmbarque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtnomeEmbarque.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex32"), Integer)
	 Me.txtnomeEmbarque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtnomeEmbarque.CustomButton.UseSelectable = True
	 Me.txtnomeEmbarque.CustomButton.Visible = CType(resources.GetObject("resource.Visible32"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtnomeEmbarque, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtnomeEmbarque, BunifuAnimatorNS.DecorationType.None)
	 Me.txtnomeEmbarque.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtnomeEmbarque.ForeColor = System.Drawing.Color.Tomato
	 Me.txtnomeEmbarque.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtnomeEmbarque, "txtnomeEmbarque")
	 Me.txtnomeEmbarque.MaxLength = 32767
	 Me.txtnomeEmbarque.Name = "txtnomeEmbarque"
	 Me.txtnomeEmbarque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtnomeEmbarque.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtnomeEmbarque.SelectedText = ""
	 Me.txtnomeEmbarque.SelectionLength = 0
	 Me.txtnomeEmbarque.SelectionStart = 0
	 Me.txtnomeEmbarque.ShortcutsEnabled = True
	 Me.txtnomeEmbarque.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtnomeEmbarque.UseSelectable = True
	 Me.txtnomeEmbarque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtnomeEmbarque.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifestoItemCodInternoDestinador
	 '
	 Me.txtmanifestoItemCodInternoDestinador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize33"), Boolean)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle33"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Font = CType(resources.GetObject("resource.Font33"), System.Drawing.Font)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Image = CType(resources.GetObject("resource.Image33"), System.Drawing.Image)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode33"), System.Windows.Forms.ImeMode)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Location = CType(resources.GetObject("resource.Location33"), System.Drawing.Point)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Name = ""
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Size = CType(resources.GetObject("resource.Size33"), System.Drawing.Size)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex33"), Integer)
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.UseSelectable = True
	 Me.txtmanifestoItemCodInternoDestinador.CustomButton.Visible = CType(resources.GetObject("resource.Visible33"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifestoItemCodInternoDestinador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifestoItemCodInternoDestinador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifestoItemCodInternoDestinador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifestoItemCodInternoDestinador.ForeColor = System.Drawing.Color.Green
	 Me.txtmanifestoItemCodInternoDestinador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifestoItemCodInternoDestinador, "txtmanifestoItemCodInternoDestinador")
	 Me.txtmanifestoItemCodInternoDestinador.MaxLength = 32767
	 Me.txtmanifestoItemCodInternoDestinador.Name = "txtmanifestoItemCodInternoDestinador"
	 Me.txtmanifestoItemCodInternoDestinador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifestoItemCodInternoDestinador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifestoItemCodInternoDestinador.SelectedText = ""
	 Me.txtmanifestoItemCodInternoDestinador.SelectionLength = 0
	 Me.txtmanifestoItemCodInternoDestinador.SelectionStart = 0
	 Me.txtmanifestoItemCodInternoDestinador.ShortcutsEnabled = True
	 Me.txtmanifestoItemCodInternoDestinador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoItemCodInternoDestinador.UseSelectable = True
	 Me.txtmanifestoItemCodInternoDestinador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifestoItemCodInternoDestinador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifestoItemCodInterno
	 '
	 Me.txtmanifestoItemCodInterno.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifestoItemCodInterno.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize34"), Boolean)
	 Me.txtmanifestoItemCodInterno.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifestoItemCodInterno.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle34"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifestoItemCodInterno.CustomButton.Font = CType(resources.GetObject("resource.Font34"), System.Drawing.Font)
	 Me.txtmanifestoItemCodInterno.CustomButton.Image = CType(resources.GetObject("resource.Image34"), System.Drawing.Image)
	 Me.txtmanifestoItemCodInterno.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode34"), System.Windows.Forms.ImeMode)
	 Me.txtmanifestoItemCodInterno.CustomButton.Location = CType(resources.GetObject("resource.Location34"), System.Drawing.Point)
	 Me.txtmanifestoItemCodInterno.CustomButton.Name = ""
	 Me.txtmanifestoItemCodInterno.CustomButton.Size = CType(resources.GetObject("resource.Size34"), System.Drawing.Size)
	 Me.txtmanifestoItemCodInterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoItemCodInterno.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex34"), Integer)
	 Me.txtmanifestoItemCodInterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifestoItemCodInterno.CustomButton.UseSelectable = True
	 Me.txtmanifestoItemCodInterno.CustomButton.Visible = CType(resources.GetObject("resource.Visible34"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifestoItemCodInterno, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifestoItemCodInterno, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifestoItemCodInterno.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifestoItemCodInterno.ForeColor = System.Drawing.Color.Green
	 Me.txtmanifestoItemCodInterno.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifestoItemCodInterno, "txtmanifestoItemCodInterno")
	 Me.txtmanifestoItemCodInterno.MaxLength = 32767
	 Me.txtmanifestoItemCodInterno.Name = "txtmanifestoItemCodInterno"
	 Me.txtmanifestoItemCodInterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifestoItemCodInterno.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifestoItemCodInterno.SelectedText = ""
	 Me.txtmanifestoItemCodInterno.SelectionLength = 0
	 Me.txtmanifestoItemCodInterno.SelectionStart = 0
	 Me.txtmanifestoItemCodInterno.ShortcutsEnabled = True
	 Me.txtmanifestoItemCodInterno.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoItemCodInterno.UseSelectable = True
	 Me.txtmanifestoItemCodInterno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifestoItemCodInterno.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtmanifestoItemObservacao
	 '
	 Me.txtmanifestoItemObservacao.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtmanifestoItemObservacao.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize35"), Boolean)
	 Me.txtmanifestoItemObservacao.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtmanifestoItemObservacao.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle35"), System.Windows.Forms.FlatStyle)
	 Me.txtmanifestoItemObservacao.CustomButton.Font = CType(resources.GetObject("resource.Font35"), System.Drawing.Font)
	 Me.txtmanifestoItemObservacao.CustomButton.Image = CType(resources.GetObject("resource.Image35"), System.Drawing.Image)
	 Me.txtmanifestoItemObservacao.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode35"), System.Windows.Forms.ImeMode)
	 Me.txtmanifestoItemObservacao.CustomButton.Location = CType(resources.GetObject("resource.Location35"), System.Drawing.Point)
	 Me.txtmanifestoItemObservacao.CustomButton.Name = ""
	 Me.txtmanifestoItemObservacao.CustomButton.Size = CType(resources.GetObject("resource.Size35"), System.Drawing.Size)
	 Me.txtmanifestoItemObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoItemObservacao.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex35"), Integer)
	 Me.txtmanifestoItemObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtmanifestoItemObservacao.CustomButton.UseSelectable = True
	 Me.txtmanifestoItemObservacao.CustomButton.Visible = CType(resources.GetObject("resource.Visible35"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtmanifestoItemObservacao, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtmanifestoItemObservacao, BunifuAnimatorNS.DecorationType.None)
	 Me.txtmanifestoItemObservacao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtmanifestoItemObservacao.ForeColor = System.Drawing.Color.Green
	 Me.txtmanifestoItemObservacao.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtmanifestoItemObservacao, "txtmanifestoItemObservacao")
	 Me.txtmanifestoItemObservacao.MaxLength = 32767
	 Me.txtmanifestoItemObservacao.Name = "txtmanifestoItemObservacao"
	 Me.txtmanifestoItemObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtmanifestoItemObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtmanifestoItemObservacao.SelectedText = ""
	 Me.txtmanifestoItemObservacao.SelectionLength = 0
	 Me.txtmanifestoItemObservacao.SelectionStart = 0
	 Me.txtmanifestoItemObservacao.ShortcutsEnabled = True
	 Me.txtmanifestoItemObservacao.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtmanifestoItemObservacao.UseSelectable = True
	 Me.txtmanifestoItemObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtmanifestoItemObservacao.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoTecnologia
	 '
	 Me.txtcodigoTecnologia.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoTecnologia.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize36"), Boolean)
	 Me.txtcodigoTecnologia.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoTecnologia.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle36"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoTecnologia.CustomButton.Font = CType(resources.GetObject("resource.Font36"), System.Drawing.Font)
	 Me.txtcodigoTecnologia.CustomButton.Image = CType(resources.GetObject("resource.Image36"), System.Drawing.Image)
	 Me.txtcodigoTecnologia.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode36"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoTecnologia.CustomButton.Location = CType(resources.GetObject("resource.Location36"), System.Drawing.Point)
	 Me.txtcodigoTecnologia.CustomButton.Name = ""
	 Me.txtcodigoTecnologia.CustomButton.Size = CType(resources.GetObject("resource.Size36"), System.Drawing.Size)
	 Me.txtcodigoTecnologia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoTecnologia.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex36"), Integer)
	 Me.txtcodigoTecnologia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoTecnologia.CustomButton.UseSelectable = True
	 Me.txtcodigoTecnologia.CustomButton.Visible = CType(resources.GetObject("resource.Visible36"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoTecnologia, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoTecnologia, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoTecnologia.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoTecnologia.ForeColor = System.Drawing.Color.Green
	 Me.txtcodigoTecnologia.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoTecnologia, "txtcodigoTecnologia")
	 Me.txtcodigoTecnologia.MaxLength = 32767
	 Me.txtcodigoTecnologia.Name = "txtcodigoTecnologia"
	 Me.txtcodigoTecnologia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoTecnologia.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoTecnologia.SelectedText = ""
	 Me.txtcodigoTecnologia.SelectionLength = 0
	 Me.txtcodigoTecnologia.SelectionStart = 0
	 Me.txtcodigoTecnologia.ShortcutsEnabled = True
	 Me.txtcodigoTecnologia.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoTecnologia.UseSelectable = True
	 Me.txtcodigoTecnologia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoTecnologia.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodigoAcondicionamento
	 '
	 Me.txtcodigoAcondicionamento.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodigoAcondicionamento.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize37"), Boolean)
	 Me.txtcodigoAcondicionamento.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodigoAcondicionamento.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle37"), System.Windows.Forms.FlatStyle)
	 Me.txtcodigoAcondicionamento.CustomButton.Font = CType(resources.GetObject("resource.Font37"), System.Drawing.Font)
	 Me.txtcodigoAcondicionamento.CustomButton.Image = CType(resources.GetObject("resource.Image37"), System.Drawing.Image)
	 Me.txtcodigoAcondicionamento.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode37"), System.Windows.Forms.ImeMode)
	 Me.txtcodigoAcondicionamento.CustomButton.Location = CType(resources.GetObject("resource.Location37"), System.Drawing.Point)
	 Me.txtcodigoAcondicionamento.CustomButton.Name = ""
	 Me.txtcodigoAcondicionamento.CustomButton.Size = CType(resources.GetObject("resource.Size37"), System.Drawing.Size)
	 Me.txtcodigoAcondicionamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoAcondicionamento.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex37"), Integer)
	 Me.txtcodigoAcondicionamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodigoAcondicionamento.CustomButton.UseSelectable = True
	 Me.txtcodigoAcondicionamento.CustomButton.Visible = CType(resources.GetObject("resource.Visible37"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodigoAcondicionamento, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodigoAcondicionamento, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodigoAcondicionamento.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodigoAcondicionamento.ForeColor = System.Drawing.Color.Green
	 Me.txtcodigoAcondicionamento.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodigoAcondicionamento, "txtcodigoAcondicionamento")
	 Me.txtcodigoAcondicionamento.MaxLength = 32767
	 Me.txtcodigoAcondicionamento.Name = "txtcodigoAcondicionamento"
	 Me.txtcodigoAcondicionamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodigoAcondicionamento.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodigoAcondicionamento.SelectedText = ""
	 Me.txtcodigoAcondicionamento.SelectionLength = 0
	 Me.txtcodigoAcondicionamento.SelectionStart = 0
	 Me.txtcodigoAcondicionamento.ShortcutsEnabled = True
	 Me.txtcodigoAcondicionamento.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodigoAcondicionamento.UseSelectable = True
	 Me.txtcodigoAcondicionamento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodigoAcondicionamento.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtresiduo
	 '
	 Me.txtresiduo.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtresiduo.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize38"), Boolean)
	 Me.txtresiduo.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtresiduo.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle38"), System.Windows.Forms.FlatStyle)
	 Me.txtresiduo.CustomButton.Font = CType(resources.GetObject("resource.Font38"), System.Drawing.Font)
	 Me.txtresiduo.CustomButton.Image = CType(resources.GetObject("resource.Image38"), System.Drawing.Image)
	 Me.txtresiduo.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode38"), System.Windows.Forms.ImeMode)
	 Me.txtresiduo.CustomButton.Location = CType(resources.GetObject("resource.Location38"), System.Drawing.Point)
	 Me.txtresiduo.CustomButton.Name = ""
	 Me.txtresiduo.CustomButton.Size = CType(resources.GetObject("resource.Size38"), System.Drawing.Size)
	 Me.txtresiduo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtresiduo.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex38"), Integer)
	 Me.txtresiduo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtresiduo.CustomButton.UseSelectable = True
	 Me.txtresiduo.CustomButton.Visible = CType(resources.GetObject("resource.Visible38"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtresiduo, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtresiduo, BunifuAnimatorNS.DecorationType.None)
	 Me.txtresiduo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtresiduo.ForeColor = System.Drawing.Color.Green
	 Me.txtresiduo.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtresiduo, "txtresiduo")
	 Me.txtresiduo.MaxLength = 32767
	 Me.txtresiduo.Name = "txtresiduo"
	 Me.txtresiduo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtresiduo.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtresiduo.SelectedText = ""
	 Me.txtresiduo.SelectionLength = 0
	 Me.txtresiduo.SelectionStart = 0
	 Me.txtresiduo.ShortcutsEnabled = True
	 Me.txtresiduo.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtresiduo.UseCustomBackColor = True
	 Me.txtresiduo.UseCustomForeColor = True
	 Me.txtresiduo.UseSelectable = True
	 Me.txtresiduo.UseStyleColors = True
	 Me.txtresiduo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtresiduo.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtSituacaoMTR
	 '
	 Me.txtSituacaoMTR.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtSituacaoMTR.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize39"), Boolean)
	 Me.txtSituacaoMTR.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtSituacaoMTR.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle39"), System.Windows.Forms.FlatStyle)
	 Me.txtSituacaoMTR.CustomButton.Font = CType(resources.GetObject("resource.Font39"), System.Drawing.Font)
	 Me.txtSituacaoMTR.CustomButton.Image = CType(resources.GetObject("resource.Image39"), System.Drawing.Image)
	 Me.txtSituacaoMTR.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode39"), System.Windows.Forms.ImeMode)
	 Me.txtSituacaoMTR.CustomButton.Location = CType(resources.GetObject("resource.Location39"), System.Drawing.Point)
	 Me.txtSituacaoMTR.CustomButton.Name = ""
	 Me.txtSituacaoMTR.CustomButton.Size = CType(resources.GetObject("resource.Size39"), System.Drawing.Size)
	 Me.txtSituacaoMTR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtSituacaoMTR.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex39"), Integer)
	 Me.txtSituacaoMTR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtSituacaoMTR.CustomButton.UseSelectable = True
	 Me.txtSituacaoMTR.CustomButton.Visible = CType(resources.GetObject("resource.Visible39"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtSituacaoMTR, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtSituacaoMTR, BunifuAnimatorNS.DecorationType.None)
	 Me.txtSituacaoMTR.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtSituacaoMTR.ForeColor = System.Drawing.Color.Tomato
	 Me.txtSituacaoMTR.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtSituacaoMTR, "txtSituacaoMTR")
	 Me.txtSituacaoMTR.MaxLength = 32767
	 Me.txtSituacaoMTR.Name = "txtSituacaoMTR"
	 Me.txtSituacaoMTR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtSituacaoMTR.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtSituacaoMTR.SelectedText = ""
	 Me.txtSituacaoMTR.SelectionLength = 0
	 Me.txtSituacaoMTR.SelectionStart = 0
	 Me.txtSituacaoMTR.ShortcutsEnabled = True
	 Me.txtSituacaoMTR.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtSituacaoMTR.UseCustomBackColor = True
	 Me.txtSituacaoMTR.UseCustomForeColor = True
	 Me.txtSituacaoMTR.UseSelectable = True
	 Me.txtSituacaoMTR.UseStyleColors = True
	 Me.txtSituacaoMTR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtSituacaoMTR.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtquantidadeRecebida
	 '
	 '
	 '
	 '
	 Me.txtquantidadeRecebida.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize40"), Boolean)
	 Me.txtquantidadeRecebida.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle40"), System.Windows.Forms.FlatStyle)
	 Me.txtquantidadeRecebida.CustomButton.Image = CType(resources.GetObject("resource.Image40"), System.Drawing.Image)
	 Me.txtquantidadeRecebida.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode40"), System.Windows.Forms.ImeMode)
	 Me.txtquantidadeRecebida.CustomButton.Location = CType(resources.GetObject("resource.Location40"), System.Drawing.Point)
	 Me.txtquantidadeRecebida.CustomButton.Name = ""
	 Me.txtquantidadeRecebida.CustomButton.Size = CType(resources.GetObject("resource.Size40"), System.Drawing.Size)
	 Me.txtquantidadeRecebida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtquantidadeRecebida.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex40"), Integer)
	 Me.txtquantidadeRecebida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtquantidadeRecebida.CustomButton.UseSelectable = True
	 Me.Efeito.SetDecoration(Me.txtquantidadeRecebida, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtquantidadeRecebida, BunifuAnimatorNS.DecorationType.None)
	 Me.txtquantidadeRecebida.ForeColor = System.Drawing.Color.Red
	 Me.txtquantidadeRecebida.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtquantidadeRecebida, "txtquantidadeRecebida")
	 Me.txtquantidadeRecebida.MaxLength = 32767
	 Me.txtquantidadeRecebida.Name = "txtquantidadeRecebida"
	 Me.txtquantidadeRecebida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtquantidadeRecebida.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtquantidadeRecebida.SelectedText = ""
	 Me.txtquantidadeRecebida.SelectionLength = 0
	 Me.txtquantidadeRecebida.SelectionStart = 0
	 Me.txtquantidadeRecebida.ShortcutsEnabled = True
	 Me.txtquantidadeRecebida.ShowButton = True
	 Me.txtquantidadeRecebida.Style = MetroFramework.MetroColorStyle.Green
	 Me.txtquantidadeRecebida.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtquantidadeRecebida.UseCustomForeColor = True
	 Me.txtquantidadeRecebida.UseSelectable = True
	 Me.txtquantidadeRecebida.UseStyleColors = True
	 Me.txtquantidadeRecebida.WaterMarkColor = System.Drawing.Color.Red
	 Me.txtquantidadeRecebida.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
	 '
	 'Label54
	 '
	 resources.ApplyResources(Me.Label54, "Label54")
	 Me.Label54.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label54, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label54, BunifuAnimatorNS.DecorationType.None)
	 Me.Label54.ForeColor = System.Drawing.Color.IndianRed
	 Me.Label54.Name = "Label54"
	 '
	 'Label6
	 '
	 resources.ApplyResources(Me.Label6, "Label6")
	 Me.Label6.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
	 Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label6.Name = "Label6"
	 '
	 'Label5
	 '
	 resources.ApplyResources(Me.Label5, "Label5")
	 Me.Label5.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
	 Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label5.Name = "Label5"
	 '
	 'Label35
	 '
	 resources.ApplyResources(Me.Label35, "Label35")
	 Me.Label35.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
	 Me.Label35.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label35.Name = "Label35"
	 '
	 'Label34
	 '
	 resources.ApplyResources(Me.Label34, "Label34")
	 Me.Label34.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
	 Me.Label34.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label34.Name = "Label34"
	 '
	 'Label33
	 '
	 resources.ApplyResources(Me.Label33, "Label33")
	 Me.Label33.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
	 Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label33.Name = "Label33"
	 '
	 'Label32
	 '
	 resources.ApplyResources(Me.Label32, "Label32")
	 Me.Label32.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
	 Me.Label32.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label32.Name = "Label32"
	 '
	 'Label31
	 '
	 resources.ApplyResources(Me.Label31, "Label31")
	 Me.Label31.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
	 Me.Label31.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label31.Name = "Label31"
	 '
	 'Label30
	 '
	 resources.ApplyResources(Me.Label30, "Label30")
	 Me.Label30.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
	 Me.Label30.ForeColor = System.Drawing.Color.IndianRed
	 Me.Label30.Name = "Label30"
	 '
	 'Label27
	 '
	 resources.ApplyResources(Me.Label27, "Label27")
	 Me.Label27.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
	 Me.Label27.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label27.Name = "Label27"
	 '
	 'Label26
	 '
	 resources.ApplyResources(Me.Label26, "Label26")
	 Me.Label26.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
	 Me.Label26.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label26.Name = "Label26"
	 '
	 'Label25
	 '
	 resources.ApplyResources(Me.Label25, "Label25")
	 Me.Label25.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
	 Me.Label25.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label25.Name = "Label25"
	 '
	 'Label24
	 '
	 resources.ApplyResources(Me.Label24, "Label24")
	 Me.Label24.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
	 Me.Label24.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label24.Name = "Label24"
	 '
	 'Label23
	 '
	 resources.ApplyResources(Me.Label23, "Label23")
	 Me.Label23.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
	 Me.Label23.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label23.Name = "Label23"
	 '
	 'Label22
	 '
	 resources.ApplyResources(Me.Label22, "Label22")
	 Me.Label22.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
	 Me.Label22.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label22.Name = "Label22"
	 '
	 'Label47
	 '
	 resources.ApplyResources(Me.Label47, "Label47")
	 Me.Label47.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label47, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label47, BunifuAnimatorNS.DecorationType.None)
	 Me.Label47.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label47.Name = "Label47"
	 '
	 'Label46
	 '
	 resources.ApplyResources(Me.Label46, "Label46")
	 Me.Label46.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label46, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label46, BunifuAnimatorNS.DecorationType.None)
	 Me.Label46.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label46.Name = "Label46"
	 '
	 'Label21
	 '
	 resources.ApplyResources(Me.Label21, "Label21")
	 Me.Label21.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
	 Me.Label21.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label21.Name = "Label21"
	 '
	 'Label45
	 '
	 resources.ApplyResources(Me.Label45, "Label45")
	 Me.Label45.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label45, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label45, BunifuAnimatorNS.DecorationType.None)
	 Me.Label45.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label45.Name = "Label45"
	 '
	 'Label20
	 '
	 resources.ApplyResources(Me.Label20, "Label20")
	 Me.Label20.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
	 Me.Label20.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label20.Name = "Label20"
	 '
	 'Label44
	 '
	 resources.ApplyResources(Me.Label44, "Label44")
	 Me.Label44.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label44, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label44, BunifuAnimatorNS.DecorationType.None)
	 Me.Label44.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label44.Name = "Label44"
	 '
	 'Label43
	 '
	 resources.ApplyResources(Me.Label43, "Label43")
	 Me.Label43.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label43, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label43, BunifuAnimatorNS.DecorationType.None)
	 Me.Label43.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label43.Name = "Label43"
	 '
	 'Label42
	 '
	 resources.ApplyResources(Me.Label42, "Label42")
	 Me.Label42.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label42, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label42, BunifuAnimatorNS.DecorationType.None)
	 Me.Label42.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label42.Name = "Label42"
	 '
	 'Label19
	 '
	 resources.ApplyResources(Me.Label19, "Label19")
	 Me.Label19.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
	 Me.Label19.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label19.Name = "Label19"
	 '
	 'Label41
	 '
	 resources.ApplyResources(Me.Label41, "Label41")
	 Me.Label41.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label41, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label41, BunifuAnimatorNS.DecorationType.None)
	 Me.Label41.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label41.Name = "Label41"
	 '
	 'Label18
	 '
	 resources.ApplyResources(Me.Label18, "Label18")
	 Me.Label18.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
	 Me.Label18.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label18.Name = "Label18"
	 '
	 'Label17
	 '
	 resources.ApplyResources(Me.Label17, "Label17")
	 Me.Label17.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
	 Me.Label17.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label17.Name = "Label17"
	 '
	 'Label16
	 '
	 resources.ApplyResources(Me.Label16, "Label16")
	 Me.Label16.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
	 Me.Label16.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label16.Name = "Label16"
	 '
	 'Label15
	 '
	 resources.ApplyResources(Me.Label15, "Label15")
	 Me.Label15.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
	 Me.Label15.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label15.Name = "Label15"
	 '
	 'Label14
	 '
	 resources.ApplyResources(Me.Label14, "Label14")
	 Me.Label14.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
	 Me.Label14.ForeColor = System.Drawing.Color.IndianRed
	 Me.Label14.Name = "Label14"
	 '
	 'Label40
	 '
	 resources.ApplyResources(Me.Label40, "Label40")
	 Me.Label40.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label40, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label40, BunifuAnimatorNS.DecorationType.None)
	 Me.Label40.ForeColor = System.Drawing.Color.IndianRed
	 Me.Label40.ImageList = Me.ImageList1
	 Me.Label40.Name = "Label40"
	 '
	 'ImageList1
	 '
	 Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
	 Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
	 Me.ImageList1.Images.SetKeyName(0, "accept.png")
	 Me.ImageList1.Images.SetKeyName(1, "add.png")
	 Me.ImageList1.Images.SetKeyName(2, "pencil.png")
	 Me.ImageList1.Images.SetKeyName(3, "pencil_add.png")
	 '
	 'Label39
	 '
	 resources.ApplyResources(Me.Label39, "Label39")
	 Me.Label39.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label39, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label39, BunifuAnimatorNS.DecorationType.None)
	 Me.Label39.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label39.Name = "Label39"
	 '
	 'Label38
	 '
	 resources.ApplyResources(Me.Label38, "Label38")
	 Me.Label38.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label38, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label38, BunifuAnimatorNS.DecorationType.None)
	 Me.Label38.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label38.Name = "Label38"
	 '
	 'Label37
	 '
	 resources.ApplyResources(Me.Label37, "Label37")
	 Me.Label37.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label37, BunifuAnimatorNS.DecorationType.None)
	 Me.Label37.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label37.Name = "Label37"
	 '
	 'Label36
	 '
	 resources.ApplyResources(Me.Label36, "Label36")
	 Me.Label36.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
	 Me.Label36.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label36.Name = "Label36"
	 '
	 'Label29
	 '
	 resources.ApplyResources(Me.Label29, "Label29")
	 Me.Label29.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
	 Me.Label29.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label29.Name = "Label29"
	 '
	 'Label13
	 '
	 resources.ApplyResources(Me.Label13, "Label13")
	 Me.Label13.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
	 Me.Label13.ForeColor = System.Drawing.Color.IndianRed
	 Me.Label13.Name = "Label13"
	 '
	 'Label12
	 '
	 resources.ApplyResources(Me.Label12, "Label12")
	 Me.Label12.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
	 Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label12.Name = "Label12"
	 '
	 'Label28
	 '
	 resources.ApplyResources(Me.Label28, "Label28")
	 Me.Label28.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
	 Me.Label28.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label28.Name = "Label28"
	 '
	 'Label11
	 '
	 resources.ApplyResources(Me.Label11, "Label11")
	 Me.Label11.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
	 Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label11.Name = "Label11"
	 '
	 'Label9
	 '
	 resources.ApplyResources(Me.Label9, "Label9")
	 Me.Label9.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
	 Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label9.Name = "Label9"
	 '
	 'Label8
	 '
	 resources.ApplyResources(Me.Label8, "Label8")
	 Me.Label8.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
	 Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label8.Name = "Label8"
	 '
	 'GroupBox1
	 '
	 resources.ApplyResources(Me.GroupBox1, "GroupBox1")
	 Me.GroupBox1.Controls.Add(Me.TreeView1)
	 Me.GroupBox1.Controls.Add(Me.Label53)
	 Me.GroupBox1.Controls.Add(Me.Label51)
	 Me.GroupBox1.Controls.Add(Me.Label50)
	 Me.GroupBox1.Controls.Add(Me.Label49)
	 Me.GroupBox1.Controls.Add(Me.Label48)
	 Me.GroupBox1.Controls.Add(Me.Label52)
	 Me.GroupBox1.Controls.Add(Me.txtUnidadeDescricao)
	 Me.GroupBox1.Controls.Add(Me.txtDescricaoEstadoFisico)
	 Me.GroupBox1.Controls.Add(Me.txtDescriçãoTecnologia)
	 Me.GroupBox1.Controls.Add(Me.txtDescricaoAcondicionamento)
	 Me.GroupBox1.Controls.Add(Me.txtClasseDescrição)
	 Me.Efeito.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
	 Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
	 Me.GroupBox1.Name = "GroupBox1"
	 Me.GroupBox1.TabStop = False
	 '
	 'TreeView1
	 '
	 Me.TreeView1.BackColor = System.Drawing.Color.AliceBlue
	 Me.BunifuTransitionOpacity.SetDecoration(Me.TreeView1, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.TreeView1, BunifuAnimatorNS.DecorationType.None)
	 resources.ApplyResources(Me.TreeView1, "TreeView1")
	 Me.TreeView1.ForeColor = System.Drawing.Color.IndianRed
	 Me.TreeView1.Name = "TreeView1"
	 '
	 'Label53
	 '
	 resources.ApplyResources(Me.Label53, "Label53")
	 Me.Label53.BackColor = System.Drawing.Color.AliceBlue
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label53, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label53, BunifuAnimatorNS.DecorationType.None)
	 Me.Label53.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label53.Name = "Label53"
	 '
	 'Label51
	 '
	 resources.ApplyResources(Me.Label51, "Label51")
	 Me.Label51.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label51, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label51, BunifuAnimatorNS.DecorationType.None)
	 Me.Label51.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label51.Name = "Label51"
	 '
	 'Label50
	 '
	 resources.ApplyResources(Me.Label50, "Label50")
	 Me.Label50.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label50, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label50, BunifuAnimatorNS.DecorationType.None)
	 Me.Label50.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label50.Name = "Label50"
	 '
	 'Label49
	 '
	 resources.ApplyResources(Me.Label49, "Label49")
	 Me.Label49.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label49, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label49, BunifuAnimatorNS.DecorationType.None)
	 Me.Label49.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label49.Name = "Label49"
	 '
	 'Label48
	 '
	 resources.ApplyResources(Me.Label48, "Label48")
	 Me.Label48.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label48, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label48, BunifuAnimatorNS.DecorationType.None)
	 Me.Label48.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label48.Name = "Label48"
	 '
	 'Label52
	 '
	 resources.ApplyResources(Me.Label52, "Label52")
	 Me.Label52.BackColor = System.Drawing.Color.White
	 Me.BunifuTransitionOpacity.SetDecoration(Me.Label52, BunifuAnimatorNS.DecorationType.None)
	 Me.Efeito.SetDecoration(Me.Label52, BunifuAnimatorNS.DecorationType.None)
	 Me.Label52.ForeColor = System.Drawing.SystemColors.Highlight
	 Me.Label52.Name = "Label52"
	 '
	 'txtUnidadeDescricao
	 '
	 Me.txtUnidadeDescricao.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtUnidadeDescricao.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize41"), Boolean)
	 Me.txtUnidadeDescricao.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtUnidadeDescricao.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle41"), System.Windows.Forms.FlatStyle)
	 Me.txtUnidadeDescricao.CustomButton.Font = CType(resources.GetObject("resource.Font40"), System.Drawing.Font)
	 Me.txtUnidadeDescricao.CustomButton.Image = CType(resources.GetObject("resource.Image41"), System.Drawing.Image)
	 Me.txtUnidadeDescricao.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode41"), System.Windows.Forms.ImeMode)
	 Me.txtUnidadeDescricao.CustomButton.Location = CType(resources.GetObject("resource.Location41"), System.Drawing.Point)
	 Me.txtUnidadeDescricao.CustomButton.Name = ""
	 Me.txtUnidadeDescricao.CustomButton.Size = CType(resources.GetObject("resource.Size41"), System.Drawing.Size)
	 Me.txtUnidadeDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtUnidadeDescricao.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex41"), Integer)
	 Me.txtUnidadeDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtUnidadeDescricao.CustomButton.UseSelectable = True
	 Me.txtUnidadeDescricao.CustomButton.Visible = CType(resources.GetObject("resource.Visible40"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtUnidadeDescricao, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtUnidadeDescricao, BunifuAnimatorNS.DecorationType.None)
	 Me.txtUnidadeDescricao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtUnidadeDescricao.ForeColor = System.Drawing.Color.Tomato
	 Me.txtUnidadeDescricao.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtUnidadeDescricao, "txtUnidadeDescricao")
	 Me.txtUnidadeDescricao.MaxLength = 32767
	 Me.txtUnidadeDescricao.Name = "txtUnidadeDescricao"
	 Me.txtUnidadeDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtUnidadeDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtUnidadeDescricao.SelectedText = ""
	 Me.txtUnidadeDescricao.SelectionLength = 0
	 Me.txtUnidadeDescricao.SelectionStart = 0
	 Me.txtUnidadeDescricao.ShortcutsEnabled = True
	 Me.txtUnidadeDescricao.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtUnidadeDescricao.UseSelectable = True
	 Me.txtUnidadeDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtUnidadeDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtDescricaoEstadoFisico
	 '
	 Me.txtDescricaoEstadoFisico.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtDescricaoEstadoFisico.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize42"), Boolean)
	 Me.txtDescricaoEstadoFisico.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtDescricaoEstadoFisico.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle42"), System.Windows.Forms.FlatStyle)
	 Me.txtDescricaoEstadoFisico.CustomButton.Font = CType(resources.GetObject("resource.Font41"), System.Drawing.Font)
	 Me.txtDescricaoEstadoFisico.CustomButton.Image = CType(resources.GetObject("resource.Image42"), System.Drawing.Image)
	 Me.txtDescricaoEstadoFisico.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode42"), System.Windows.Forms.ImeMode)
	 Me.txtDescricaoEstadoFisico.CustomButton.Location = CType(resources.GetObject("resource.Location42"), System.Drawing.Point)
	 Me.txtDescricaoEstadoFisico.CustomButton.Name = ""
	 Me.txtDescricaoEstadoFisico.CustomButton.Size = CType(resources.GetObject("resource.Size42"), System.Drawing.Size)
	 Me.txtDescricaoEstadoFisico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtDescricaoEstadoFisico.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex42"), Integer)
	 Me.txtDescricaoEstadoFisico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtDescricaoEstadoFisico.CustomButton.UseSelectable = True
	 Me.txtDescricaoEstadoFisico.CustomButton.Visible = CType(resources.GetObject("resource.Visible41"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtDescricaoEstadoFisico, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtDescricaoEstadoFisico, BunifuAnimatorNS.DecorationType.None)
	 Me.txtDescricaoEstadoFisico.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtDescricaoEstadoFisico.ForeColor = System.Drawing.Color.Tomato
	 Me.txtDescricaoEstadoFisico.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtDescricaoEstadoFisico, "txtDescricaoEstadoFisico")
	 Me.txtDescricaoEstadoFisico.MaxLength = 32767
	 Me.txtDescricaoEstadoFisico.Name = "txtDescricaoEstadoFisico"
	 Me.txtDescricaoEstadoFisico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtDescricaoEstadoFisico.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtDescricaoEstadoFisico.SelectedText = ""
	 Me.txtDescricaoEstadoFisico.SelectionLength = 0
	 Me.txtDescricaoEstadoFisico.SelectionStart = 0
	 Me.txtDescricaoEstadoFisico.ShortcutsEnabled = True
	 Me.txtDescricaoEstadoFisico.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtDescricaoEstadoFisico.UseSelectable = True
	 Me.txtDescricaoEstadoFisico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtDescricaoEstadoFisico.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtDescriçãoTecnologia
	 '
	 Me.txtDescriçãoTecnologia.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtDescriçãoTecnologia.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize43"), Boolean)
	 Me.txtDescriçãoTecnologia.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtDescriçãoTecnologia.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle43"), System.Windows.Forms.FlatStyle)
	 Me.txtDescriçãoTecnologia.CustomButton.Font = CType(resources.GetObject("resource.Font42"), System.Drawing.Font)
	 Me.txtDescriçãoTecnologia.CustomButton.Image = CType(resources.GetObject("resource.Image43"), System.Drawing.Image)
	 Me.txtDescriçãoTecnologia.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode43"), System.Windows.Forms.ImeMode)
	 Me.txtDescriçãoTecnologia.CustomButton.Location = CType(resources.GetObject("resource.Location43"), System.Drawing.Point)
	 Me.txtDescriçãoTecnologia.CustomButton.Name = ""
	 Me.txtDescriçãoTecnologia.CustomButton.Size = CType(resources.GetObject("resource.Size43"), System.Drawing.Size)
	 Me.txtDescriçãoTecnologia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtDescriçãoTecnologia.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex43"), Integer)
	 Me.txtDescriçãoTecnologia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtDescriçãoTecnologia.CustomButton.UseSelectable = True
	 Me.txtDescriçãoTecnologia.CustomButton.Visible = CType(resources.GetObject("resource.Visible42"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtDescriçãoTecnologia, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtDescriçãoTecnologia, BunifuAnimatorNS.DecorationType.None)
	 Me.txtDescriçãoTecnologia.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtDescriçãoTecnologia.ForeColor = System.Drawing.Color.Tomato
	 Me.txtDescriçãoTecnologia.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtDescriçãoTecnologia, "txtDescriçãoTecnologia")
	 Me.txtDescriçãoTecnologia.MaxLength = 32767
	 Me.txtDescriçãoTecnologia.Name = "txtDescriçãoTecnologia"
	 Me.txtDescriçãoTecnologia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtDescriçãoTecnologia.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtDescriçãoTecnologia.SelectedText = ""
	 Me.txtDescriçãoTecnologia.SelectionLength = 0
	 Me.txtDescriçãoTecnologia.SelectionStart = 0
	 Me.txtDescriçãoTecnologia.ShortcutsEnabled = True
	 Me.txtDescriçãoTecnologia.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtDescriçãoTecnologia.UseSelectable = True
	 Me.txtDescriçãoTecnologia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtDescriçãoTecnologia.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtDescricaoAcondicionamento
	 '
	 Me.txtDescricaoAcondicionamento.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtDescricaoAcondicionamento.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize44"), Boolean)
	 Me.txtDescricaoAcondicionamento.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtDescricaoAcondicionamento.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle44"), System.Windows.Forms.FlatStyle)
	 Me.txtDescricaoAcondicionamento.CustomButton.Font = CType(resources.GetObject("resource.Font43"), System.Drawing.Font)
	 Me.txtDescricaoAcondicionamento.CustomButton.Image = CType(resources.GetObject("resource.Image44"), System.Drawing.Image)
	 Me.txtDescricaoAcondicionamento.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode44"), System.Windows.Forms.ImeMode)
	 Me.txtDescricaoAcondicionamento.CustomButton.Location = CType(resources.GetObject("resource.Location44"), System.Drawing.Point)
	 Me.txtDescricaoAcondicionamento.CustomButton.Name = ""
	 Me.txtDescricaoAcondicionamento.CustomButton.Size = CType(resources.GetObject("resource.Size44"), System.Drawing.Size)
	 Me.txtDescricaoAcondicionamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtDescricaoAcondicionamento.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex44"), Integer)
	 Me.txtDescricaoAcondicionamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtDescricaoAcondicionamento.CustomButton.UseSelectable = True
	 Me.txtDescricaoAcondicionamento.CustomButton.Visible = CType(resources.GetObject("resource.Visible43"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtDescricaoAcondicionamento, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtDescricaoAcondicionamento, BunifuAnimatorNS.DecorationType.None)
	 Me.txtDescricaoAcondicionamento.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtDescricaoAcondicionamento.ForeColor = System.Drawing.Color.Tomato
	 Me.txtDescricaoAcondicionamento.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtDescricaoAcondicionamento, "txtDescricaoAcondicionamento")
	 Me.txtDescricaoAcondicionamento.MaxLength = 32767
	 Me.txtDescricaoAcondicionamento.Name = "txtDescricaoAcondicionamento"
	 Me.txtDescricaoAcondicionamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtDescricaoAcondicionamento.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtDescricaoAcondicionamento.SelectedText = ""
	 Me.txtDescricaoAcondicionamento.SelectionLength = 0
	 Me.txtDescricaoAcondicionamento.SelectionStart = 0
	 Me.txtDescricaoAcondicionamento.ShortcutsEnabled = True
	 Me.txtDescricaoAcondicionamento.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtDescricaoAcondicionamento.UseSelectable = True
	 Me.txtDescricaoAcondicionamento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtDescricaoAcondicionamento.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtClasseDescrição
	 '
	 Me.txtClasseDescrição.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtClasseDescrição.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize45"), Boolean)
	 Me.txtClasseDescrição.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtClasseDescrição.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle45"), System.Windows.Forms.FlatStyle)
	 Me.txtClasseDescrição.CustomButton.Font = CType(resources.GetObject("resource.Font44"), System.Drawing.Font)
	 Me.txtClasseDescrição.CustomButton.Image = CType(resources.GetObject("resource.Image45"), System.Drawing.Image)
	 Me.txtClasseDescrição.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode45"), System.Windows.Forms.ImeMode)
	 Me.txtClasseDescrição.CustomButton.Location = CType(resources.GetObject("resource.Location45"), System.Drawing.Point)
	 Me.txtClasseDescrição.CustomButton.Name = ""
	 Me.txtClasseDescrição.CustomButton.Size = CType(resources.GetObject("resource.Size45"), System.Drawing.Size)
	 Me.txtClasseDescrição.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtClasseDescrição.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex45"), Integer)
	 Me.txtClasseDescrição.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtClasseDescrição.CustomButton.UseSelectable = True
	 Me.txtClasseDescrição.CustomButton.Visible = CType(resources.GetObject("resource.Visible44"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtClasseDescrição, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtClasseDescrição, BunifuAnimatorNS.DecorationType.None)
	 Me.txtClasseDescrição.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtClasseDescrição.ForeColor = System.Drawing.Color.Tomato
	 Me.txtClasseDescrição.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtClasseDescrição, "txtClasseDescrição")
	 Me.txtClasseDescrição.MaxLength = 32767
	 Me.txtClasseDescrição.Name = "txtClasseDescrição"
	 Me.txtClasseDescrição.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtClasseDescrição.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtClasseDescrição.SelectedText = ""
	 Me.txtClasseDescrição.SelectionLength = 0
	 Me.txtClasseDescrição.SelectionStart = 0
	 Me.txtClasseDescrição.ShortcutsEnabled = True
	 Me.txtClasseDescrição.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtClasseDescrição.UseSelectable = True
	 Me.txtClasseDescrição.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtClasseDescrição.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'txtcodUnidadeDestinador
	 '
	 Me.txtcodUnidadeDestinador.BackColor = System.Drawing.Color.WhiteSmoke
	 '
	 '
	 '
	 Me.txtcodUnidadeDestinador.CustomButton.AutoSize = CType(resources.GetObject("resource.AutoSize46"), Boolean)
	 Me.txtcodUnidadeDestinador.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
	 Me.txtcodUnidadeDestinador.CustomButton.FlatStyle = CType(resources.GetObject("resource.FlatStyle46"), System.Windows.Forms.FlatStyle)
	 Me.txtcodUnidadeDestinador.CustomButton.Font = CType(resources.GetObject("resource.Font45"), System.Drawing.Font)
	 Me.txtcodUnidadeDestinador.CustomButton.Image = CType(resources.GetObject("resource.Image46"), System.Drawing.Image)
	 Me.txtcodUnidadeDestinador.CustomButton.ImeMode = CType(resources.GetObject("resource.ImeMode46"), System.Windows.Forms.ImeMode)
	 Me.txtcodUnidadeDestinador.CustomButton.Location = CType(resources.GetObject("resource.Location46"), System.Drawing.Point)
	 Me.txtcodUnidadeDestinador.CustomButton.Name = ""
	 Me.txtcodUnidadeDestinador.CustomButton.Size = CType(resources.GetObject("resource.Size46"), System.Drawing.Size)
	 Me.txtcodUnidadeDestinador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeDestinador.CustomButton.TabIndex = CType(resources.GetObject("resource.TabIndex46"), Integer)
	 Me.txtcodUnidadeDestinador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
	 Me.txtcodUnidadeDestinador.CustomButton.UseSelectable = True
	 Me.txtcodUnidadeDestinador.CustomButton.Visible = CType(resources.GetObject("resource.Visible45"), Boolean)
	 Me.Efeito.SetDecoration(Me.txtcodUnidadeDestinador, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.txtcodUnidadeDestinador, BunifuAnimatorNS.DecorationType.None)
	 Me.txtcodUnidadeDestinador.FontWeight = MetroFramework.MetroTextBoxWeight.Light
	 Me.txtcodUnidadeDestinador.ForeColor = System.Drawing.Color.Green
	 Me.txtcodUnidadeDestinador.Lines = New String(-1) {}
	 resources.ApplyResources(Me.txtcodUnidadeDestinador, "txtcodUnidadeDestinador")
	 Me.txtcodUnidadeDestinador.MaxLength = 32767
	 Me.txtcodUnidadeDestinador.Name = "txtcodUnidadeDestinador"
	 Me.txtcodUnidadeDestinador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.txtcodUnidadeDestinador.ScrollBars = System.Windows.Forms.ScrollBars.None
	 Me.txtcodUnidadeDestinador.SelectedText = ""
	 Me.txtcodUnidadeDestinador.SelectionLength = 0
	 Me.txtcodUnidadeDestinador.SelectionStart = 0
	 Me.txtcodUnidadeDestinador.ShortcutsEnabled = True
	 Me.txtcodUnidadeDestinador.Style = MetroFramework.MetroColorStyle.Blue
	 Me.txtcodUnidadeDestinador.UseSelectable = True
	 Me.txtcodUnidadeDestinador.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
	 Me.txtcodUnidadeDestinador.WaterMarkFont = New System.Drawing.Font("Segoe UI Emoji", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
	 '
	 'GroupBox6
	 '
	 Me.GroupBox6.Controls.Add(Me.BtContrair)
	 Me.GroupBox6.Controls.Add(Me.lblComprimentar)
	 Me.GroupBox6.Controls.Add(Me.Bt_Expandir)
	 Me.GroupBox6.Controls.Add(Me.BTconfig)
	 Me.GroupBox6.Controls.Add(Me.BTadicionarMtr)
	 Me.GroupBox6.Controls.Add(Me.BTcarregarMtr)
	 Me.GroupBox6.Controls.Add(Me.BTsalvarMtr)
	 Me.Efeito.SetDecoration(Me.GroupBox6, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.GroupBox6, BunifuAnimatorNS.DecorationType.None)
	 resources.ApplyResources(Me.GroupBox6, "GroupBox6")
	 Me.GroupBox6.Name = "GroupBox6"
	 Me.GroupBox6.TabStop = False
	 '
	 'TXTobservacao
	 '
	 Me.TXTobservacao.Ativar_CasasDecimais = False
	 Me.TXTobservacao.Ativar_so_Letras = False
	 Me.TXTobservacao.Ativar_so_Numeros = False
	 Me.TXTobservacao.AtivarSoNumeroSemFormatacao_ = False
	 Me.TXTobservacao.BorderColor = System.Drawing.Color.Silver
	 Me.TXTobservacao.Cursor = System.Windows.Forms.Cursors.IBeam
	 Me.Efeito.SetDecoration(Me.TXTobservacao, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.TXTobservacao, BunifuAnimatorNS.DecorationType.None)
	 Me.TXTobservacao.DefaultText = ""
	 Me.TXTobservacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
	 Me.TXTobservacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
	 Me.TXTobservacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTobservacao.DisabledState.Parent = Me.TXTobservacao
	 Me.TXTobservacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTobservacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTobservacao.FocusedState.Parent = Me.TXTobservacao
	 Me.TXTobservacao.ForeColor = System.Drawing.Color.Gray
	 Me.TXTobservacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTobservacao.HoverState.Parent = Me.TXTobservacao
	 resources.ApplyResources(Me.TXTobservacao, "TXTobservacao")
	 Me.TXTobservacao.Name = "TXTobservacao"
	 Me.TXTobservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.TXTobservacao.PlaceholderText = ""
	 Me.TXTobservacao.SelectedText = ""
	 Me.TXTobservacao.ShadowDecoration.Parent = Me.TXTobservacao
	 '
	 'TXTdataHora
	 '
	 Me.TXTdataHora.Ativar_CasasDecimais = False
	 Me.TXTdataHora.Ativar_so_Letras = False
	 Me.TXTdataHora.Ativar_so_Numeros = False
	 Me.TXTdataHora.AtivarSoNumeroSemFormatacao_ = False
	 Me.TXTdataHora.BorderColor = System.Drawing.Color.Silver
	 Me.TXTdataHora.Cursor = System.Windows.Forms.Cursors.IBeam
	 Me.Efeito.SetDecoration(Me.TXTdataHora, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.TXTdataHora, BunifuAnimatorNS.DecorationType.None)
	 Me.TXTdataHora.DefaultText = ""
	 Me.TXTdataHora.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
	 Me.TXTdataHora.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
	 Me.TXTdataHora.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTdataHora.DisabledState.Parent = Me.TXTdataHora
	 Me.TXTdataHora.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTdataHora.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTdataHora.FocusedState.Parent = Me.TXTdataHora
	 Me.TXTdataHora.ForeColor = System.Drawing.Color.Gray
	 Me.TXTdataHora.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTdataHora.HoverState.Parent = Me.TXTdataHora
	 resources.ApplyResources(Me.TXTdataHora, "TXTdataHora")
	 Me.TXTdataHora.Name = "TXTdataHora"
	 Me.TXTdataHora.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.TXTdataHora.PlaceholderText = ""
	 Me.TXTdataHora.SelectedText = ""
	 Me.TXTdataHora.ShadowDecoration.Parent = Me.TXTdataHora
	 '
	 'TXTmtr
	 '
	 Me.TXTmtr.Ativar_CasasDecimais = False
	 Me.TXTmtr.Ativar_so_Letras = False
	 Me.TXTmtr.Ativar_so_Numeros = False
	 Me.TXTmtr.AtivarSoNumeroSemFormatacao_ = False
	 Me.TXTmtr.BorderColor = System.Drawing.Color.Silver
	 Me.TXTmtr.Cursor = System.Windows.Forms.Cursors.IBeam
	 Me.Efeito.SetDecoration(Me.TXTmtr, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.TXTmtr, BunifuAnimatorNS.DecorationType.None)
	 Me.TXTmtr.DefaultText = ""
	 Me.TXTmtr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
	 Me.TXTmtr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
	 Me.TXTmtr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTmtr.DisabledState.Parent = Me.TXTmtr
	 Me.TXTmtr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTmtr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTmtr.FocusedState.Parent = Me.TXTmtr
	 Me.TXTmtr.ForeColor = System.Drawing.Color.Gray
	 Me.TXTmtr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTmtr.HoverState.Parent = Me.TXTmtr
	 resources.ApplyResources(Me.TXTmtr, "TXTmtr")
	 Me.TXTmtr.Name = "TXTmtr"
	 Me.TXTmtr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.TXTmtr.PlaceholderText = ""
	 Me.TXTmtr.SelectedText = ""
	 Me.TXTmtr.ShadowDecoration.Parent = Me.TXTmtr
	 '
	 'TXTCodigo
	 '
	 Me.TXTCodigo.Ativar_CasasDecimais = False
	 Me.TXTCodigo.Ativar_so_Letras = False
	 Me.TXTCodigo.Ativar_so_Numeros = True
	 Me.TXTCodigo.AtivarSoNumeroSemFormatacao_ = False
	 Me.TXTCodigo.BorderColor = System.Drawing.Color.Silver
	 Me.TXTCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
	 Me.Efeito.SetDecoration(Me.TXTCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me.TXTCodigo, BunifuAnimatorNS.DecorationType.None)
	 Me.TXTCodigo.DefaultText = ""
	 Me.TXTCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
	 Me.TXTCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
	 Me.TXTCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTCodigo.DisabledState.Parent = Me.TXTCodigo
	 Me.TXTCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
	 Me.TXTCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTCodigo.FocusedState.Parent = Me.TXTCodigo
	 Me.TXTCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
	 Me.TXTCodigo.HoverState.Parent = Me.TXTCodigo
	 resources.ApplyResources(Me.TXTCodigo, "TXTCodigo")
	 Me.TXTCodigo.Name = "TXTCodigo"
	 Me.TXTCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
	 Me.TXTCodigo.PlaceholderText = ""
	 Me.TXTCodigo.SelectedText = ""
	 Me.TXTCodigo.ShadowDecoration.Parent = Me.TXTCodigo
	 '
	 'TimerStatusdaRede
	 '
	 Me.TimerStatusdaRede.Interval = 5000
	 '
	 'TimerSalvarNaNuvem
	 '
	 Me.TimerSalvarNaNuvem.Interval = 1000
	 '
	 'ToolStripStatusLabel2
	 '
	 Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
	 resources.ApplyResources(Me.ToolStripStatusLabel2, "ToolStripStatusLabel2")
	 '
	 'LoadFormulario
	 '
	 Me.LoadFormulario.Delay = 1
	 '
	 'Efeito
	 '
	 Me.Efeito.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
	 Me.Efeito.Cursor = Nothing
	 Animation2.AnimateOnlyDifferences = True
	 Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
	 Animation2.LeafCoeff = 0!
	 Animation2.MaxTime = 1.0!
	 Animation2.MinTime = 0!
	 Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
	 Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
	 Animation2.MosaicSize = 0
	 Animation2.Padding = New System.Windows.Forms.Padding(0)
	 Animation2.RotateCoeff = 0!
	 Animation2.RotateLimit = 0!
	 Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
	 Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
	 Animation2.TimeCoeff = 0!
	 Animation2.TransparencyCoeff = 0!
	 Me.Efeito.DefaultAnimation = Animation2
	 '
	 'FrmMTR
	 '
	 resources.ApplyResources(Me, "$this")
	 Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	 Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
	 Me.BackColor = System.Drawing.Color.SkyBlue
	 Me.Controls.Add(Me.BunifuCards1)
	 Me.Controls.Add(Me.StatusStripVolume)
	 Me.Controls.Add(Me.GroupBox6)
	 Me.Controls.Add(Me.LinkAtualizar)
	 Me.Controls.Add(Me.Pesquisar)
	 Me.Controls.Add(Me.TXTobservacao)
	 Me.Controls.Add(Me.TXTdataHora)
	 Me.Controls.Add(Me.TXTmtr)
	 Me.Controls.Add(Me.Label7)
	 Me.Controls.Add(Me.TXTCodigo)
	 Me.Controls.Add(Me.Label4)
	 Me.Controls.Add(Me.Label3)
	 Me.Controls.Add(Me.Label2)
	 Me.Controls.Add(Me.Label1)
	 Me.Controls.Add(Me.DGVdados)
	 Me.Controls.Add(Me.StatusStrip1)
	 Me.Efeito.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
	 Me.BunifuTransitionOpacity.SetDecoration(Me, BunifuAnimatorNS.DecorationType.Custom)
	 Me.ForeColor = System.Drawing.Color.DimGray
	 Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
	 Me.KeyPreview = True
	 Me.MaximizeBox = False
	 Me.Name = "FrmMTR"
	 Me.Opacity = 0.95R
	 Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
	 Me.StatusStripVolume.ResumeLayout(False)
	 Me.StatusStripVolume.PerformLayout()
	 CType(Me.DGVdados, System.ComponentModel.ISupportInitialize).EndInit()
	 Me.StatusStrip1.ResumeLayout(False)
	 Me.StatusStrip1.PerformLayout()
	 Me.BunifuCards1.ResumeLayout(False)
	 Me.BunifuCards1.PerformLayout()
	 Me.GroupBox1.ResumeLayout(False)
	 Me.GroupBox1.PerformLayout()
	 Me.GroupBox6.ResumeLayout(False)
	 Me.GroupBox6.PerformLayout()
	 Me.ResumeLayout(False)
	 Me.PerformLayout()

   End Sub


   Friend WithEvents txtcodUnidadeDestinador As MetroTextBox
   Friend WithEvents Label1 As Label
   Public WithEvents BTadicionarMtr As Button
	Public WithEvents BTsalvarMtr As Button
	Friend WithEvents Label3 As Label
   Friend WithEvents StatusStripVolume As StatusStrip
   Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabeUsuarioLogado As ToolStripStatusLabel
   Friend WithEvents ToolStripSplitButton As ToolStripSplitButton
   Friend WithEvents Timer1 As Timer
   Friend WithEvents ToolStripStatusLabel_HOJE As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel_IPlocal As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel_Host As ToolStripStatusLabel
   Friend WithEvents NotifyIcone_MTR As NotifyIcon
   Public WithEvents BTeditarMTR As Button
   Friend WithEvents ToolTipMTR As ToolTip
   Public WithEvents Timer3 As Timer
   Public WithEvents BTcarregarMtr As Button
   Friend WithEvents BunifuTransitionOpacity As BunifuAnimatorNS.BunifuTransition
   Friend WithEvents TimerStatusdaRede As Timer
   Friend WithEvents BtVolume As ToolStripDropDownButton
   Friend WithEvents TimerSalvarNaNuvem As Timer
   Friend WithEvents ImageList1 As ImageList
   Friend WithEvents Label2 As Label
   Public WithEvents BTconfig As Button
   Friend WithEvents Label4 As Label
   Friend WithEvents TXTCodigo As TextboxMonetário
   Friend WithEvents TXTmtr As TextboxMonetário
   Friend WithEvents DGVdados As Guna.UI2.WinForms.Guna2DataGridView
   Friend WithEvents TXTdataHora As TextboxMonetário
   Friend WithEvents TXTobservacao As TextboxMonetário
   Friend WithEvents Label7 As Label
   Friend WithEvents lblComprimentar As Label
   Friend WithEvents Pesquisar As CheckBox
   Friend WithEvents LinkAtualizar As LinkLabel
   Friend WithEvents Bt_Expandir As Button

   Public Sub New(components As IContainer, label1 As Label, bTadicionarMtr As Button, bTdeletar As Button, bTsalvarMtr As Button, label3 As Label, statusStripVolume As StatusStrip, toolStripStatusLabel As ToolStripStatusLabel, toolStripStatusLabeUsuarioLogado As ToolStripStatusLabel, toolStripSplitButton As ToolStripSplitButton, timer1 As Timer, toolStripStatusLabel_HOJE As ToolStripStatusLabel, toolStripStatusLabel1 As ToolStripStatusLabel, toolStripStatusLabel_IPlocal As ToolStripStatusLabel, toolStripStatusLabel_Host As ToolStripStatusLabel, notifyIcone_MTR As NotifyIcon, bTeditarMTR As Button, toolTipMTR As ToolTip, timer3 As Timer, bTcarregarMtr As Button, bunifuTransitionOpacity As BunifuTransition, timerStatusdaRede As Timer, btVolume As ToolStripDropDownButton, timerSalvarNaNuvem As Timer, imageList1 As ImageList, label2 As Label, bTconfig As Button, label4 As Label, tXTCodigo As TextboxMonetário, tXTmtr As TextboxMonetário, dGVdados As Guna2DataGridView, tXTdataHora As TextboxMonetário, tXTobservacao As TextboxMonetário, tXTgerador As TextboxMonetário, label6 As Label, tXTtransportador As TextboxMonetário, label7 As Label, tXTdestinador As TextboxMonetário, lblComprimentar As Label, pesquisar As CheckBox, linkAtualizar As LinkLabel, groupBox1 As GroupBox, groupBox2 As GroupBox, label8 As Label, label5 As Label, bt_Direita As Button, bt_Esquerda As Button, jjj As FRMConfigurar_banco_de_Dados, info5 As Notifyicone_PopupNotifier, lvi_Observação As AutoCompleteStringCollection, caminho As String, dialogResult As DialogResult, cont As Integer, carragarThreed As Threading.Thread, carragarThreed2 As Threading.Thread, msg As String, radiobuttonserver As FRMConfigurar_banco_de_Dados, radiobuttonLocalHost As FRMConfigurar_banco_de_Dados, lL As Integer, completar As AutoCompleteStringCollection, tempo As TimeSpan)
	 Me.components = components
	 Me.Label1 = label1
	 Me.BTadicionarMtr = bTadicionarMtr
	 'Me.BTdeletar = bTdeletar
	 Me.BTsalvarMtr = bTsalvarMtr
	 Me.Label3 = label3
	 Me.StatusStripVolume = statusStripVolume
	 Me.ToolStripStatusLabel = toolStripStatusLabel
	 Me.ToolStripStatusLabeUsuarioLogado = toolStripStatusLabeUsuarioLogado
	 Me.ToolStripSplitButton = toolStripSplitButton
	 Me.Timer1 = timer1
	 Me.ToolStripStatusLabel_HOJE = toolStripStatusLabel_HOJE
	 Me.ToolStripStatusLabel1 = toolStripStatusLabel1
	 Me.ToolStripStatusLabel_IPlocal = toolStripStatusLabel_IPlocal
	 Me.ToolStripStatusLabel_Host = toolStripStatusLabel_Host
	 Me.NotifyIcone_MTR = notifyIcone_MTR
	 Me.BTeditarMTR = bTeditarMTR
	 Me.ToolTipMTR = toolTipMTR
	 Me.Timer3 = timer3
	 Me.BTcarregarMtr = bTcarregarMtr
	 Me.BunifuTransitionOpacity = bunifuTransitionOpacity
	 Me.TimerStatusdaRede = timerStatusdaRede
	 Me.BtVolume = btVolume
	 Me.TimerSalvarNaNuvem = timerSalvarNaNuvem
	 Me.ImageList1 = imageList1
	 Me.Label2 = label2
	 Me.BTconfig = bTconfig
	 Me.Label4 = label4
	 Me.TXTCodigo = tXTCodigo
	 Me.TXTmtr = tXTmtr
	 Me.DGVdados = dGVdados
	 Me.TXTdataHora = tXTdataHora
	 Me.TXTobservacao = tXTobservacao
	 Me.Label7 = label7

	 Me.lblComprimentar = lblComprimentar
	 Me.Pesquisar = pesquisar
	 Me.LinkAtualizar = linkAtualizar

	 Me.Bt_Expandir = bt_Direita

	 Me._jjj = jjj
	 Me._info5 = info5
	 Me._Lvi_Observação = lvi_Observação

	 Me._Cont = cont

	 Me.radiobuttonserver = radiobuttonserver
	 Me.radiobuttonLocalHost = radiobuttonLocalHost
	 Me.LL = lL
	 Me.Completar = completar
	 Me.Tempo = tempo



   End Sub

   Friend WithEvents BtContrair As Button
   Friend WithEvents ToolStripStatusLabelLogin As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
   Friend WithEvents GroupBox6 As GroupBox
   Private WithEvents StatusStrip1 As StatusStrip
   Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
   Friend WithEvents LoadFormulario As Bunifu.Framework.UI.BunifuFormFadeTransition
   Friend WithEvents Efeito As BunifuTransition
   Friend WithEvents Label10 As Label
   Friend WithEvents lblmanifTransportadorDataExpedicao As Label
   Friend WithEvents lblmanifTransportadorPlacaVeiculo As Label
   Friend WithEvents GroupBox1 As GroupBox
   Friend WithEvents BtnReceberManifestoBunifuFlatButton As Bunifu.Framework.UI.BunifuFlatButton
   Friend WithEvents Label6 As Label
   Friend WithEvents Label5 As Label
   Friend WithEvents Label8 As Label
   Friend WithEvents Label9 As Label
   Friend WithEvents Label11 As Label
   Friend WithEvents Label12 As Label
   Friend WithEvents Label27 As Label
   Friend WithEvents Label26 As Label
   Friend WithEvents Label25 As Label
   Friend WithEvents Label24 As Label
   Friend WithEvents Label23 As Label
   Friend WithEvents Label22 As Label
   Friend WithEvents Label21 As Label
   Friend WithEvents Label20 As Label
   Friend WithEvents Label19 As Label
   Friend WithEvents Label18 As Label
   Friend WithEvents Label17 As Label
   Friend WithEvents Label16 As Label
   Friend WithEvents Label15 As Label
   Friend WithEvents Label14 As Label
   Friend WithEvents Label13 As Label
   Friend WithEvents Label35 As Label
   Friend WithEvents Label34 As Label
   Friend WithEvents Label33 As Label
   Friend WithEvents Label32 As Label
   Friend WithEvents Label31 As Label
   Friend WithEvents Label30 As Label
   Friend WithEvents Label29 As Label
   Friend WithEvents Label28 As Label
   Friend WithEvents Label47 As Label
   Friend WithEvents Label46 As Label
   Friend WithEvents Label45 As Label
   Friend WithEvents Label44 As Label
   Friend WithEvents Label43 As Label
   Friend WithEvents Label42 As Label
   Friend WithEvents Label41 As Label
   Friend WithEvents Label40 As Label
   Friend WithEvents Label39 As Label
   Friend WithEvents Label38 As Label
   Friend WithEvents Label37 As Label
   Friend WithEvents Label36 As Label
   Friend WithEvents Label51 As Label
   Friend WithEvents Label50 As Label
   Friend WithEvents Label49 As Label
   Friend WithEvents Label48 As Label
   Friend WithEvents Label52 As Label
   Friend WithEvents Label53 As Label
   Friend WithEvents TreeView1 As TreeView
   Friend WithEvents Label54 As Label
   Friend WithEvents txtquantidadeRecebida As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtSituacaoMTR As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtresiduo As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txttipoDensidadeValor As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txttipoDensidadeUnidade As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcnpGerador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifestoCodigo As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcnpTransportador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcnpDestinador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcnpArmazenador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtsituacaoManifestoCodigo As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifData As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifObservacao As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifGeradorNomeResponsavel As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifGeradorCargoResponsavel As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifTransportadorNomeMotorista As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifTransportadorDataExpedicao As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifTransportadorPlacaVeiculo As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoAcondicionamento As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoTecnologia As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifestoItemObservacao As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifestoItemCodInterno As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifestoItemCodInternoDestinador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtnomeEmbarque As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtgrupoEmbalagem As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoUnidade As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoTipoEstado As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtnumeroONU As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtclasseDeRisco As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtquantidade As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoClasse As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoInterno As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtjustificativa As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodigoSequencial As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtretorno As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifDataRecebimento As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtmanifDataExpedicao As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodUnidadeArmazenador As MetroFramework.Controls.MetroTextBox

   ' Friend WithEvents txtcodUnidadeDestinador As MetroFramework.Controls.MetroTextBox

   Friend WithEvents txtcodUnidadeTransportador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtcodUnidadeGerador As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtretornoCodigo As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtUnidadeDescricao As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtDescricaoEstadoFisico As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtDescriçãoTecnologia As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtDescricaoAcondicionamento As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtClasseDescrição As MetroFramework.Controls.MetroTextBox
   Friend WithEvents DestinadorCodUnidadeToolStripStatusLabel As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
   Friend WithEvents DestinadorLocal As ToolStripStatusLabel


End Class
