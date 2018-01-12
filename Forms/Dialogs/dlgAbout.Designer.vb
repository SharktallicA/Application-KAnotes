<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAbout))
        Me.imgPlaceholder = New System.Windows.Forms.PictureBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.pnlAboutItems = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.txtCopyright = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        CType(Me.imgPlaceholder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAboutItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgPlaceholder
        '
        Me.imgPlaceholder.BackgroundImage = Global.KAnotes.My.Resources.Resources.imgPlaceholder
        Me.imgPlaceholder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPlaceholder.ErrorImage = Nothing
        Me.imgPlaceholder.Location = New System.Drawing.Point(12, 12)
        Me.imgPlaceholder.Name = "imgPlaceholder"
        Me.imgPlaceholder.Size = New System.Drawing.Size(64, 64)
        Me.imgPlaceholder.TabIndex = 1
        Me.imgPlaceholder.TabStop = False
        '
        'btnOkay
        '
        Me.btnOkay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOkay.BackColor = System.Drawing.Color.Transparent
        Me.btnOkay.FlatAppearance.BorderSize = 0
        Me.btnOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOkay.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnOkay.Location = New System.Drawing.Point(190, 133)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(64, 32)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "OK"
        Me.btnOkay.UseVisualStyleBackColor = False
        '
        'pnlAboutItems
        '
        Me.pnlAboutItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAboutItems.Controls.Add(Me.lblCopyright)
        Me.pnlAboutItems.Controls.Add(Me.txtCopyright)
        Me.pnlAboutItems.Controls.Add(Me.lblVersion)
        Me.pnlAboutItems.Controls.Add(Me.txtVersion)
        Me.pnlAboutItems.Controls.Add(Me.lblName)
        Me.pnlAboutItems.Controls.Add(Me.txtName)
        Me.pnlAboutItems.Location = New System.Drawing.Point(82, 12)
        Me.pnlAboutItems.Name = "pnlAboutItems"
        Me.pnlAboutItems.Size = New System.Drawing.Size(172, 114)
        Me.pnlAboutItems.TabIndex = 5
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(3, 98)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(33, 13)
        Me.lblCopyright.TabIndex = 13
        Me.lblCopyright.Text = "NULL"
        '
        'txtCopyright
        '
        Me.txtCopyright.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCopyright.BackColor = System.Drawing.Color.LightGray
        Me.txtCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCopyright.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCopyright.Location = New System.Drawing.Point(3, 77)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.ReadOnly = True
        Me.txtCopyright.Size = New System.Drawing.Size(166, 18)
        Me.txtCopyright.TabIndex = 12
        Me.txtCopyright.Text = "Copyright"
        Me.txtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(3, 61)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(33, 13)
        Me.lblVersion.TabIndex = 11
        Me.lblVersion.Text = "NULL"
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.BackColor = System.Drawing.Color.LightGray
        Me.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVersion.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtVersion.Location = New System.Drawing.Point(3, 40)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(166, 18)
        Me.txtVersion.TabIndex = 10
        Me.txtVersion.Text = "Program Version"
        Me.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(3, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(33, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "NULL"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(3, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(166, 18)
        Me.txtName.TabIndex = 8
        Me.txtName.Text = "Program Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dlgAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(266, 177)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.pnlAboutItems)
        Me.Controls.Add(Me.imgPlaceholder)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About KAnotes"
        CType(Me.imgPlaceholder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAboutItems.ResumeLayout(False)
        Me.pnlAboutItems.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents imgPlaceholder As PictureBox
    Private WithEvents btnOkay As Button
    Private WithEvents pnlAboutItems As Panel
    Private WithEvents lblCopyright As Label
    Private WithEvents txtCopyright As TextBox
    Private WithEvents lblVersion As Label
    Private WithEvents txtVersion As TextBox
    Private WithEvents lblName As Label
    Private WithEvents txtName As TextBox
End Class
