<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMmemorando
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmemorando))
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BTALTERA = New System.Windows.Forms.Button()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.BTDELETE = New System.Windows.Forms.Button()
        Me.BTSALVA = New System.Windows.Forms.Button()
        Me.BTADD = New System.Windows.Forms.Button()
        Me.BTCARREGA = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSITUACAO = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPARA = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerDATA = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerHORA = New System.Windows.Forms.DateTimePicker()
        Me.BunifuTransitionMemorando = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.SkyBlue
        Me.BunifuCards1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.BTALTERA)
        Me.BunifuCards1.Controls.Add(Me.TxtDescricao)
        Me.BunifuCards1.Controls.Add(Me.BTDELETE)
        Me.BunifuCards1.Controls.Add(Me.BTSALVA)
        Me.BunifuCards1.Controls.Add(Me.BTADD)
        Me.BunifuCards1.Controls.Add(Me.BTCARREGA)
        Me.BunifuCards1.Controls.Add(Me.ListView1)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.Label4)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.ComboBoxSITUACAO)
        Me.BunifuCards1.Controls.Add(Me.ComboBoxPARA)
        Me.BunifuCards1.Controls.Add(Me.ComboBoxDE)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.DateTimePickerDATA)
        Me.BunifuCards1.Controls.Add(Me.DateTimePickerHORA)
        Me.BunifuTransitionMemorando.SetDecoration(Me.BunifuCards1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1239, 518)
        Me.BunifuCards1.TabIndex = 0
        '
        'BTALTERA
        '
        Me.BTALTERA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransitionMemorando.SetDecoration(Me.BTALTERA, BunifuAnimatorNS.DecorationType.None)
        Me.BTALTERA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTALTERA.ForeColor = System.Drawing.Color.Gray
        Me.BTALTERA.Location = New System.Drawing.Point(320, 483)
        Me.BTALTERA.Name = "BTALTERA"
        Me.BTALTERA.Size = New System.Drawing.Size(73, 27)
        Me.BTALTERA.TabIndex = 4
        Me.BTALTERA.Text = "AL&TERA"
        Me.BTALTERA.UseVisualStyleBackColor = True
        '
        'TxtDescricao
        '
        Me.BunifuTransitionMemorando.SetDecoration(Me.TxtDescricao, BunifuAnimatorNS.DecorationType.None)
        Me.TxtDescricao.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescricao.Location = New System.Drawing.Point(13, 29)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(275, 27)
        Me.TxtDescricao.TabIndex = 1
        '
        'BTDELETE
        '
        Me.BTDELETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransitionMemorando.SetDecoration(Me.BTDELETE, BunifuAnimatorNS.DecorationType.None)
        Me.BTDELETE.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTDELETE.ForeColor = System.Drawing.Color.Gray
        Me.BTDELETE.Location = New System.Drawing.Point(244, 483)
        Me.BTDELETE.Name = "BTDELETE"
        Me.BTDELETE.Size = New System.Drawing.Size(73, 27)
        Me.BTDELETE.TabIndex = 3
        Me.BTDELETE.Text = "&DELETA"
        Me.BTDELETE.UseVisualStyleBackColor = True
        '
        'BTSALVA
        '
        Me.BTSALVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransitionMemorando.SetDecoration(Me.BTSALVA, BunifuAnimatorNS.DecorationType.None)
        Me.BTSALVA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSALVA.ForeColor = System.Drawing.Color.Gray
        Me.BTSALVA.Location = New System.Drawing.Point(168, 483)
        Me.BTSALVA.Name = "BTSALVA"
        Me.BTSALVA.Size = New System.Drawing.Size(73, 27)
        Me.BTSALVA.TabIndex = 2
        Me.BTSALVA.Text = "&SALVA"
        Me.BTSALVA.UseVisualStyleBackColor = True
        '
        'BTADD
        '
        Me.BTADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransitionMemorando.SetDecoration(Me.BTADD, BunifuAnimatorNS.DecorationType.None)
        Me.BTADD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTADD.ForeColor = System.Drawing.Color.Gray
        Me.BTADD.Location = New System.Drawing.Point(92, 483)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(73, 27)
        Me.BTADD.TabIndex = 1
        Me.BTADD.Text = "&ADICIONA"
        Me.BTADD.UseVisualStyleBackColor = True
        '
        'BTCARREGA
        '
        Me.BTCARREGA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransitionMemorando.SetDecoration(Me.BTCARREGA, BunifuAnimatorNS.DecorationType.None)
        Me.BTCARREGA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCARREGA.ForeColor = System.Drawing.Color.Gray
        Me.BTCARREGA.Location = New System.Drawing.Point(16, 483)
        Me.BTCARREGA.Name = "BTCARREGA"
        Me.BTCARREGA.Size = New System.Drawing.Size(73, 27)
        Me.BTCARREGA.TabIndex = 0
        Me.BTCARREGA.Text = "&CARREGA"
        Me.BTCARREGA.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuTransitionMemorando.SetDecoration(Me.ListView1, BunifuAnimatorNS.DecorationType.None)
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.DarkGray
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelEdit = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(13, 62)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(1214, 415)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.StateImageList = Me.ImageList1
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "paste_plain.png")
        Me.ImageList1.Images.SetKeyName(1, "pencil.png")
        Me.ImageList1.Images.SetKeyName(2, "pencil_delete.png")
        Me.ImageList1.Images.SetKeyName(3, "pencil_go.png")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionMemorando.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Location = New System.Drawing.Point(857, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Situação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionMemorando.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Location = New System.Drawing.Point(646, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Para:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionMemorando.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Location = New System.Drawing.Point(522, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "De:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionMemorando.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Location = New System.Drawing.Point(395, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionMemorando.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(296, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Hora"
        '
        'ComboBoxSITUACAO
        '
        Me.BunifuTransitionMemorando.SetDecoration(Me.ComboBoxSITUACAO, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBoxSITUACAO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSITUACAO.FormattingEnabled = True
        Me.ComboBoxSITUACAO.Items.AddRange(New Object() {"Em Andamento", "Concluído", "Indeterminado"})
        Me.ComboBoxSITUACAO.Location = New System.Drawing.Point(857, 28)
        Me.ComboBoxSITUACAO.Name = "ComboBoxSITUACAO"
        Me.ComboBoxSITUACAO.Size = New System.Drawing.Size(167, 29)
        Me.ComboBoxSITUACAO.TabIndex = 6
        '
        'ComboBoxPARA
        '
        Me.BunifuTransitionMemorando.SetDecoration(Me.ComboBoxPARA, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBoxPARA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPARA.FormattingEnabled = True
        Me.ComboBoxPARA.Location = New System.Drawing.Point(649, 28)
        Me.ComboBoxPARA.Name = "ComboBoxPARA"
        Me.ComboBoxPARA.Size = New System.Drawing.Size(200, 29)
        Me.ComboBoxPARA.TabIndex = 5
        '
        'ComboBoxDE
        '
        Me.BunifuTransitionMemorando.SetDecoration(Me.ComboBoxDE, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBoxDE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDE.FormattingEnabled = True
        Me.ComboBoxDE.Location = New System.Drawing.Point(522, 28)
        Me.ComboBoxDE.Name = "ComboBoxDE"
        Me.ComboBoxDE.Size = New System.Drawing.Size(121, 29)
        Me.ComboBoxDE.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransitionMemorando.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Descrição"
        '
        'DateTimePickerDATA
        '
        Me.DateTimePickerDATA.CalendarFont = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTransitionMemorando.SetDecoration(Me.DateTimePickerDATA, BunifuAnimatorNS.DecorationType.None)
        Me.DateTimePickerDATA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDATA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDATA.Location = New System.Drawing.Point(398, 29)
        Me.DateTimePickerDATA.Name = "DateTimePickerDATA"
        Me.DateTimePickerDATA.Size = New System.Drawing.Size(118, 27)
        Me.DateTimePickerDATA.TabIndex = 3
        '
        'DateTimePickerHORA
        '
        Me.DateTimePickerHORA.CalendarFont = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTransitionMemorando.SetDecoration(Me.DateTimePickerHORA, BunifuAnimatorNS.DecorationType.None)
        Me.DateTimePickerHORA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHORA.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerHORA.Location = New System.Drawing.Point(296, 29)
        Me.DateTimePickerHORA.Name = "DateTimePickerHORA"
        Me.DateTimePickerHORA.ShowUpDown = True
        Me.DateTimePickerHORA.Size = New System.Drawing.Size(96, 27)
        Me.DateTimePickerHORA.TabIndex = 2
        '
        'BunifuTransitionMemorando
        '
        Me.BunifuTransitionMemorando.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransitionMemorando.Cursor = Nothing
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
        Me.BunifuTransitionMemorando.DefaultAnimation = Animation1
        Me.BunifuTransitionMemorando.Interval = 1
        Me.BunifuTransitionMemorando.MaxAnimationTime = 4000
        Me.BunifuTransitionMemorando.TimeStep = 0.01!
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FRMmemorando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 518)
        Me.Controls.Add(Me.BunifuCards1)
        Me.BunifuTransitionMemorando.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FRMmemorando"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memorando"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuTransitionMemorando As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BTDELETE As Button
    Friend WithEvents BTSALVA As Button
    Friend WithEvents BTCARREGA As Button
    Friend WithEvents BTADD As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BTALTERA As Button
    Friend WithEvents DateTimePickerHORA As DateTimePicker
    Friend WithEvents DateTimePickerDATA As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxDE As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxSITUACAO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxPARA As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents ImageList1 As ImageList
End Class
