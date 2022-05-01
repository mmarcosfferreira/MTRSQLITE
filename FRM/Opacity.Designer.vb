<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOpacity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpacity))
        Me.BunifuCardsOpacity = New Bunifu.Framework.UI.BunifuCards()
        Me.SuspendLayout()
        '
        'BunifuCardsOpacity
        '
        Me.BunifuCardsOpacity.BackColor = System.Drawing.Color.White
        Me.BunifuCardsOpacity.BorderRadius = 5
        Me.BunifuCardsOpacity.BottomSahddow = True
        Me.BunifuCardsOpacity.color = System.Drawing.Color.Tomato
        Me.BunifuCardsOpacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCardsOpacity.LeftSahddow = False
        Me.BunifuCardsOpacity.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCardsOpacity.Name = "BunifuCardsOpacity"
        Me.BunifuCardsOpacity.RightSahddow = True
        Me.BunifuCardsOpacity.ShadowDepth = 20
        Me.BunifuCardsOpacity.Size = New System.Drawing.Size(424, 67)
        Me.BunifuCardsOpacity.TabIndex = 0
        '
        'FrmOpacity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 67)
        Me.Controls.Add(Me.BunifuCardsOpacity)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmOpacity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opacity"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCardsOpacity As Bunifu.Framework.UI.BunifuCards
End Class
