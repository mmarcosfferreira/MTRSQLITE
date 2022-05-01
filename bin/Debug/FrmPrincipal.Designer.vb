<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

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
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation11 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation12 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipPrincipal = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTConfiguracao = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BT1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RadioButon = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.Card1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Card2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Transition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition3 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition4 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuTransition5 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Card1.SuspendLayout()
        Me.Card2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(8, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Licenciado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(8, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Host e Ip"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(8, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Time "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(8, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Build v"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(8, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Os nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition5.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nucleos"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'BTConfiguracao
        '
        Me.BTConfiguracao.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTConfiguracao.BackColor = System.Drawing.Color.Transparent
        Me.BTConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTConfiguracao.BorderRadius = 0
        Me.BTConfiguracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BTConfiguracao.ButtonText = "Controle Mtr"
        Me.BTConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition5.SetDecoration(Me.BTConfiguracao, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.BTConfiguracao, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BTConfiguracao, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.BTConfiguracao, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.BTConfiguracao, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BTConfiguracao, BunifuAnimatorNS.DecorationType.None)
        Me.BTConfiguracao.DisabledColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTConfiguracao.ForeColor = System.Drawing.Color.DimGray
        Me.BTConfiguracao.Iconcolor = System.Drawing.Color.Salmon
        Me.BTConfiguracao.Iconimage = CType(resources.GetObject("BTConfiguracao.Iconimage"), System.Drawing.Image)
        Me.BTConfiguracao.Iconimage_right = Nothing
        Me.BTConfiguracao.Iconimage_right_Selected = Nothing
        Me.BTConfiguracao.Iconimage_Selected = Nothing
        Me.BTConfiguracao.IconMarginLeft = 0
        Me.BTConfiguracao.IconMarginRight = 0
        Me.BTConfiguracao.IconRightVisible = True
        Me.BTConfiguracao.IconRightZoom = 0R
        Me.BTConfiguracao.IconVisible = True
        Me.BTConfiguracao.IconZoom = 90.0R
        Me.BTConfiguracao.IsTab = False
        Me.BTConfiguracao.Location = New System.Drawing.Point(12, 49)
        Me.BTConfiguracao.Margin = New System.Windows.Forms.Padding(2)
        Me.BTConfiguracao.Name = "BTConfiguracao"
        Me.BTConfiguracao.Normalcolor = System.Drawing.Color.Transparent
        Me.BTConfiguracao.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTConfiguracao.OnHoverTextColor = System.Drawing.Color.White
        Me.BTConfiguracao.selected = False
        Me.BTConfiguracao.Size = New System.Drawing.Size(192, 27)
        Me.BTConfiguracao.TabIndex = 6
        Me.BTConfiguracao.Text = "Controle Mtr"
        Me.BTConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTConfiguracao.Textcolor = System.Drawing.Color.Gray
        Me.BTConfiguracao.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTipPrincipal.SetToolTip(Me.BTConfiguracao, "Verifica se na base de dados aquela MTR existe! Se existir então traz o foco na m" &
        "esma para o usuário tomar as devidas providencias! ")
        '
        'BT1
        '
        Me.BT1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BT1.BackColor = System.Drawing.Color.Transparent
        Me.BT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT1.BorderRadius = 0
        Me.BT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BT1.ButtonText = "Ocultar Detalhes "
        Me.BT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition5.SetDecoration(Me.BT1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.BT1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BT1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.BT1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.BT1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BT1, BunifuAnimatorNS.DecorationType.None)
        Me.BT1.DisabledColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BT1.ForeColor = System.Drawing.Color.DimGray
        Me.BT1.Iconcolor = System.Drawing.Color.Salmon
        Me.BT1.Iconimage = CType(resources.GetObject("BT1.Iconimage"), System.Drawing.Image)
        Me.BT1.Iconimage_right = Nothing
        Me.BT1.Iconimage_right_Selected = Nothing
        Me.BT1.Iconimage_Selected = Nothing
        Me.BT1.IconMarginLeft = 0
        Me.BT1.IconMarginRight = 0
        Me.BT1.IconRightVisible = True
        Me.BT1.IconRightZoom = 0R
        Me.BT1.IconVisible = True
        Me.BT1.IconZoom = 90.0R
        Me.BT1.IsTab = False
        Me.BT1.Location = New System.Drawing.Point(12, 13)
        Me.BT1.Margin = New System.Windows.Forms.Padding(2)
        Me.BT1.Name = "BT1"
        Me.BT1.Normalcolor = System.Drawing.Color.Transparent
        Me.BT1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BT1.OnHoverTextColor = System.Drawing.Color.White
        Me.BT1.selected = False
        Me.BT1.Size = New System.Drawing.Size(192, 27)
        Me.BT1.TabIndex = 6
        Me.BT1.Text = "Ocultar Detalhes "
        Me.BT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT1.Textcolor = System.Drawing.Color.Gray
        Me.BT1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTipPrincipal.SetToolTip(Me.BT1, "Informações básica sobre o atual sistema!")
        '
        'RadioButon
        '
        Me.RadioButon.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.RadioButon.BackColor = System.Drawing.Color.Transparent
        Me.RadioButon.BackgroundImage = CType(resources.GetObject("RadioButon.BackgroundImage"), System.Drawing.Image)
        Me.RadioButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButon.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.BunifuTransition5.SetDecoration(Me.RadioButon, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.RadioButon, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.RadioButon, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.RadioButon, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.RadioButon, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.RadioButon, BunifuAnimatorNS.DecorationType.None)
        Me.RadioButon.Location = New System.Drawing.Point(482, 5)
        Me.RadioButon.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButon.Name = "RadioButon"
        Me.RadioButon.OffColor = System.Drawing.Color.Gray
        Me.RadioButon.OnColor = System.Drawing.Color.DarkGreen
        Me.RadioButon.Size = New System.Drawing.Size(43, 25)
        Me.RadioButon.TabIndex = 6
        Me.ToolTipPrincipal.SetToolTip(Me.RadioButon, "Recarrega todos os controles de Tarefa")
        Me.RadioButon.Value = True
        '
        'Card1
        '
        Me.Card1.AutoSize = True
        Me.Card1.BackColor = System.Drawing.Color.Transparent
        Me.Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Card1.BorderRadius = 8
        Me.Card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Card1.BottomSahddow = True
        Me.Card1.color = System.Drawing.Color.Tomato
        Me.Card1.Controls.Add(Me.Label3)
        Me.Card1.Controls.Add(Me.Label5)
        Me.Card1.Controls.Add(Me.Label7)
        Me.Card1.Controls.Add(Me.Label6)
        Me.Card1.Controls.Add(Me.Label1)
        Me.Card1.Controls.Add(Me.Label4)
        Me.Card1.Controls.Add(Me.Label2)
        Me.BunifuTransition5.SetDecoration(Me.Card1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Card1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Card1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Card1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Card1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Card1, BunifuAnimatorNS.DecorationType.None)
        Me.Card1.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Card1.LeftSahddow = False
        Me.Card1.Location = New System.Drawing.Point(4, 26)
        Me.Card1.Margin = New System.Windows.Forms.Padding(2)
        Me.Card1.Name = "Card1"
        Me.Card1.RightSahddow = True
        Me.Card1.ShadowDepth = 20
        Me.Card1.Size = New System.Drawing.Size(342, 194)
        Me.Card1.TabIndex = 4
        '
        'Card2
        '
        Me.Card2.AutoSize = True
        Me.Card2.BackColor = System.Drawing.Color.Transparent
        Me.Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Card2.BorderRadius = 5
        Me.Card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Card2.BottomSahddow = True
        Me.Card2.color = System.Drawing.Color.Tomato
        Me.Card2.Controls.Add(Me.BTConfiguracao)
        Me.Card2.Controls.Add(Me.BT1)
        Me.BunifuTransition5.SetDecoration(Me.Card2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Card2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.Card2, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.Card2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Card2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.Card2, BunifuAnimatorNS.DecorationType.None)
        Me.Card2.LeftSahddow = False
        Me.Card2.Location = New System.Drawing.Point(358, 86)
        Me.Card2.Margin = New System.Windows.Forms.Padding(2)
        Me.Card2.Name = "Card2"
        Me.Card2.RightSahddow = False
        Me.Card2.ShadowDepth = 20
        Me.Card2.Size = New System.Drawing.Size(210, 96)
        Me.Card2.TabIndex = 5
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuTransition5.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition4.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(370, 6)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(99, 18)
        Me.BunifuCustomLabel1.TabIndex = 7
        Me.BunifuCustomLabel1.Text = "&Ativar controles"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Transition
        '
        Me.Transition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.Transition.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 20
        Animation10.Padding = New System.Windows.Forms.Padding(30)
        Animation10.RotateCoeff = 0!
        Animation10.RotateLimit = 0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 0!
        Me.Transition.DefaultAnimation = Animation10
        Me.Transition.Interval = 1
        Me.Transition.MaxAnimationTime = 6000
        Me.Transition.TimeStep = 0.005!
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.BunifuTransition1.Cursor = Nothing
        Animation11.AnimateOnlyDifferences = True
        Animation11.BlindCoeff = CType(resources.GetObject("Animation11.BlindCoeff"), System.Drawing.PointF)
        Animation11.LeafCoeff = 0!
        Animation11.MaxTime = 1.0!
        Animation11.MinTime = 0!
        Animation11.MosaicCoeff = CType(resources.GetObject("Animation11.MosaicCoeff"), System.Drawing.PointF)
        Animation11.MosaicShift = CType(resources.GetObject("Animation11.MosaicShift"), System.Drawing.PointF)
        Animation11.MosaicSize = 1
        Animation11.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation11.RotateCoeff = 0!
        Animation11.RotateLimit = 0!
        Animation11.ScaleCoeff = CType(resources.GetObject("Animation11.ScaleCoeff"), System.Drawing.PointF)
        Animation11.SlideCoeff = CType(resources.GetObject("Animation11.SlideCoeff"), System.Drawing.PointF)
        Animation11.TimeCoeff = 2.0!
        Animation11.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation11
        Me.BunifuTransition1.Interval = 1
        Me.BunifuTransition1.MaxAnimationTime = 6000
        Me.BunifuTransition1.TimeStep = 0.005!
        '
        'BunifuTransition2
        '
        Me.BunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition2.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 0!
        Me.BunifuTransition2.DefaultAnimation = Animation8
        Me.BunifuTransition2.Interval = 2
        Me.BunifuTransition2.MaxAnimationTime = 5000
        Me.BunifuTransition2.TimeStep = 0.009!
        '
        'BunifuTransition3
        '
        Me.BunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.BunifuTransition3.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation9.RotateCoeff = 0!
        Animation9.RotateLimit = 0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0!
        Animation9.TransparencyCoeff = 0!
        Me.BunifuTransition3.DefaultAnimation = Animation9
        Me.BunifuTransition3.Interval = 1
        Me.BunifuTransition3.MaxAnimationTime = 6000
        Me.BunifuTransition3.TimeStep = 0.005!
        '
        'BunifuTransition4
        '
        Me.BunifuTransition4.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.BunifuTransition4.Cursor = Nothing
        Animation12.AnimateOnlyDifferences = True
        Animation12.BlindCoeff = CType(resources.GetObject("Animation12.BlindCoeff"), System.Drawing.PointF)
        Animation12.LeafCoeff = 0!
        Animation12.MaxTime = 1.0!
        Animation12.MinTime = 0!
        Animation12.MosaicCoeff = CType(resources.GetObject("Animation12.MosaicCoeff"), System.Drawing.PointF)
        Animation12.MosaicShift = CType(resources.GetObject("Animation12.MosaicShift"), System.Drawing.PointF)
        Animation12.MosaicSize = 0
        Animation12.Padding = New System.Windows.Forms.Padding(30)
        Animation12.RotateCoeff = 0.5!
        Animation12.RotateLimit = 0.2!
        Animation12.ScaleCoeff = CType(resources.GetObject("Animation12.ScaleCoeff"), System.Drawing.PointF)
        Animation12.SlideCoeff = CType(resources.GetObject("Animation12.SlideCoeff"), System.Drawing.PointF)
        Animation12.TimeCoeff = 0!
        Animation12.TransparencyCoeff = 0!
        Me.BunifuTransition4.DefaultAnimation = Animation12
        Me.BunifuTransition4.Interval = 1
        Me.BunifuTransition4.MaxAnimationTime = 4000
        Me.BunifuTransition4.TimeStep = 0.005!
        '
        'BunifuTransition5
        '
        Me.BunifuTransition5.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.BunifuTransition5.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(30)
        Animation7.RotateCoeff = 0.5!
        Animation7.RotateLimit = 0.2!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.BunifuTransition5.DefaultAnimation = Animation7
        Me.BunifuTransition5.Interval = 1
        Me.BunifuTransition5.MaxAnimationTime = 3900
        Me.BunifuTransition5.TimeStep = 0.005!
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Principal.My.Resources.Resources.fbvasfhjvas
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(577, 243)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.RadioButon)
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card1)
        Me.BunifuTransition4.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition5.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition3.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Transition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vital Engenharia Ambiental - Menu "
        Me.ToolTipPrincipal.SetToolTip(Me, "Menu principal em 2º plano")
        Me.Card1.ResumeLayout(False)
        Me.Card1.PerformLayout()
        Me.Card2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolTipPrincipal As ToolTip
    Friend WithEvents Card1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Card2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BT1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BTConfiguracao As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RadioButon As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Transition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition3 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition4 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition5 As BunifuAnimatorNS.BunifuTransition
    Private WithEvents BunifuTransition2 As BunifuAnimatorNS.BunifuTransition
End Class
