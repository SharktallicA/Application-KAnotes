<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.barMenu = New System.Windows.Forms.MenuStrip()
        Me.itmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.itmView = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.editor = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.barStatus = New System.Windows.Forms.StatusStrip()
        Me.lblCharacters = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCharacterCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblWords = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblWordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.barTool = New System.Windows.Forms.ToolStrip()
        Me.itmNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.itmFindReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.barMenu.SuspendLayout()
        Me.barStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'barMenu
        '
        Me.barMenu.BackColor = System.Drawing.Color.Transparent
        Me.barMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmFile, Me.itmEdit, Me.itmView, Me.itmHelp})
        Me.barMenu.Location = New System.Drawing.Point(0, 0)
        Me.barMenu.Name = "barMenu"
        Me.barMenu.Size = New System.Drawing.Size(784, 24)
        Me.barMenu.TabIndex = 0
        Me.barMenu.Text = "MenuStrip1"
        '
        'itmFile
        '
        Me.itmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmNew, Me.itmSeparator1, Me.itmOpen, Me.itmSeparator2, Me.itmSave, Me.itmSaveAs, Me.itmSeparator3, Me.itmPageSetup, Me.itmPrint, Me.itmSeparator4, Me.itmExit})
        Me.itmFile.Name = "itmFile"
        Me.itmFile.Size = New System.Drawing.Size(37, 20)
        Me.itmFile.Text = "File"
        '
        'itmSeparator1
        '
        Me.itmSeparator1.Name = "itmSeparator1"
        Me.itmSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'itmSeparator2
        '
        Me.itmSeparator2.Name = "itmSeparator2"
        Me.itmSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        'itmSaveAs
        '
        Me.itmSaveAs.Name = "itmSaveAs"
        Me.itmSaveAs.Size = New System.Drawing.Size(142, 22)
        Me.itmSaveAs.Text = "Save As..."
        '
        'itmSeparator3
        '
        Me.itmSeparator3.Name = "itmSeparator3"
        Me.itmSeparator3.Size = New System.Drawing.Size(139, 6)
        '
        'itmSeparator4
        '
        Me.itmSeparator4.Name = "itmSeparator4"
        Me.itmSeparator4.Size = New System.Drawing.Size(139, 6)
        '
        'itmEdit
        '
        Me.itmEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmUndo, Me.itmRedo, Me.itmSeparator5, Me.itmCut, Me.itmCopy, Me.itmPaste, Me.itmDelete, Me.itmSeparator6, Me.itmSelectAll, Me.itmSeparator7, Me.itmFindReplace})
        Me.itmEdit.Name = "itmEdit"
        Me.itmEdit.Size = New System.Drawing.Size(39, 20)
        Me.itmEdit.Text = "Edit"
        '
        'itmSeparator5
        '
        Me.itmSeparator5.Name = "itmSeparator5"
        Me.itmSeparator5.Size = New System.Drawing.Size(160, 6)
        '
        'itmSeparator6
        '
        Me.itmSeparator6.Name = "itmSeparator6"
        Me.itmSeparator6.Size = New System.Drawing.Size(160, 6)
        '
        'itmSelectAll
        '
        Me.itmSelectAll.Name = "itmSelectAll"
        Me.itmSelectAll.Size = New System.Drawing.Size(163, 22)
        Me.itmSelectAll.Text = "Select All"
        '
        'itmSeparator7
        '
        Me.itmSeparator7.Name = "itmSeparator7"
        Me.itmSeparator7.Size = New System.Drawing.Size(160, 6)
        '
        'itmView
        '
        Me.itmView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmOptions})
        Me.itmView.Name = "itmView"
        Me.itmView.Size = New System.Drawing.Size(44, 20)
        Me.itmView.Text = "View"
        '
        'itmOptions
        '
        Me.itmOptions.Name = "itmOptions"
        Me.itmOptions.Size = New System.Drawing.Size(125, 22)
        Me.itmOptions.Text = "Options..."
        '
        'itmHelp
        '
        Me.itmHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmAbout})
        Me.itmHelp.Name = "itmHelp"
        Me.itmHelp.Size = New System.Drawing.Size(44, 20)
        Me.itmHelp.Text = "Help"
        '
        'itmAbout
        '
        Me.itmAbout.Name = "itmAbout"
        Me.itmAbout.Size = New System.Drawing.Size(163, 22)
        Me.itmAbout.Text = "About KAnotes..."
        '
        'editor
        '
        Me.editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editor.Location = New System.Drawing.Point(0, 49)
        Me.editor.Name = "editor"
        Me.editor.Size = New System.Drawing.Size(784, 491)
        Me.editor.TabIndex = 1
        Me.editor.Text = ""
        '
        'barStatus
        '
        Me.barStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCharacters, Me.lblCharacterCount, Me.lblWords, Me.lblWordCount})
        Me.barStatus.Location = New System.Drawing.Point(0, 540)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(784, 22)
        Me.barStatus.TabIndex = 3
        Me.barStatus.Text = "StatusStrip1"
        '
        'lblCharacters
        '
        Me.lblCharacters.Name = "lblCharacters"
        Me.lblCharacters.Size = New System.Drawing.Size(66, 17)
        Me.lblCharacters.Text = "Characters:"
        '
        'lblCharacterCount
        '
        Me.lblCharacterCount.Name = "lblCharacterCount"
        Me.lblCharacterCount.Size = New System.Drawing.Size(36, 17)
        Me.lblCharacterCount.Text = "NULL"
        '
        'lblWords
        '
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(44, 17)
        Me.lblWords.Text = "Words:"
        '
        'lblWordCount
        '
        Me.lblWordCount.Name = "lblWordCount"
        Me.lblWordCount.Size = New System.Drawing.Size(36, 17)
        Me.lblWordCount.Text = "NULL"
        '
        'barTool
        '
        Me.barTool.BackColor = System.Drawing.Color.Transparent
        Me.barTool.BackgroundImage = Global.KAnotes.My.Resources.Resources.imgControlBackgroud
        Me.barTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.barTool.Location = New System.Drawing.Point(0, 24)
        Me.barTool.Name = "barTool"
        Me.barTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.barTool.Size = New System.Drawing.Size(784, 25)
        Me.barTool.TabIndex = 2
        Me.barTool.Text = "ToolStrip1"
        '
        'itmNew
        '
        Me.itmNew.Image = Global.KAnotes.My.Resources.Resources.imgNew
        Me.itmNew.Name = "itmNew"
        Me.itmNew.Size = New System.Drawing.Size(142, 22)
        Me.itmNew.Text = "New"
        '
        'itmOpen
        '
        Me.itmOpen.Image = Global.KAnotes.My.Resources.Resources.imgOpen
        Me.itmOpen.Name = "itmOpen"
        Me.itmOpen.Size = New System.Drawing.Size(142, 22)
        Me.itmOpen.Text = "Open..."
        '
        'itmSave
        '
        Me.itmSave.Image = Global.KAnotes.My.Resources.Resources.imgSave
        Me.itmSave.Name = "itmSave"
        Me.itmSave.Size = New System.Drawing.Size(142, 22)
        Me.itmSave.Text = "Save"
        '
        'itmPageSetup
        '
        Me.itmPageSetup.Image = Global.KAnotes.My.Resources.Resources.imgPageSetup
        Me.itmPageSetup.Name = "itmPageSetup"
        Me.itmPageSetup.Size = New System.Drawing.Size(142, 22)
        Me.itmPageSetup.Text = "Page Setup..."
        '
        'itmPrint
        '
        Me.itmPrint.Image = Global.KAnotes.My.Resources.Resources.imgPrinter
        Me.itmPrint.Name = "itmPrint"
        Me.itmPrint.Size = New System.Drawing.Size(142, 22)
        Me.itmPrint.Text = "Print..."
        '
        'itmExit
        '
        Me.itmExit.Image = Global.KAnotes.My.Resources.Resources.imgExit
        Me.itmExit.Name = "itmExit"
        Me.itmExit.Size = New System.Drawing.Size(142, 22)
        Me.itmExit.Text = "Exit"
        '
        'itmUndo
        '
        Me.itmUndo.Image = Global.KAnotes.My.Resources.Resources.imgUndo
        Me.itmUndo.Name = "itmUndo"
        Me.itmUndo.Size = New System.Drawing.Size(163, 22)
        Me.itmUndo.Text = "Undo"
        '
        'itmRedo
        '
        Me.itmRedo.Image = Global.KAnotes.My.Resources.Resources.imgRedo
        Me.itmRedo.Name = "itmRedo"
        Me.itmRedo.Size = New System.Drawing.Size(163, 22)
        Me.itmRedo.Text = "Redo"
        '
        'itmCut
        '
        Me.itmCut.Image = Global.KAnotes.My.Resources.Resources.imgCut
        Me.itmCut.Name = "itmCut"
        Me.itmCut.Size = New System.Drawing.Size(163, 22)
        Me.itmCut.Text = "Cut"
        '
        'itmCopy
        '
        Me.itmCopy.Image = Global.KAnotes.My.Resources.Resources.imgCopy
        Me.itmCopy.Name = "itmCopy"
        Me.itmCopy.Size = New System.Drawing.Size(163, 22)
        Me.itmCopy.Text = "Copy"
        '
        'itmPaste
        '
        Me.itmPaste.Image = Global.KAnotes.My.Resources.Resources.imgPaste
        Me.itmPaste.Name = "itmPaste"
        Me.itmPaste.Size = New System.Drawing.Size(163, 22)
        Me.itmPaste.Text = "Paste"
        '
        'itmDelete
        '
        Me.itmDelete.Image = Global.KAnotes.My.Resources.Resources.imgDelete
        Me.itmDelete.Name = "itmDelete"
        Me.itmDelete.Size = New System.Drawing.Size(163, 22)
        Me.itmDelete.Text = "Delete"
        '
        'itmFindReplace
        '
        Me.itmFindReplace.Image = Global.KAnotes.My.Resources.Resources.imgFind
        Me.itmFindReplace.Name = "itmFindReplace"
        Me.itmFindReplace.Size = New System.Drawing.Size(163, 22)
        Me.itmFindReplace.Text = "Find && Replace..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.editor)
        Me.Controls.Add(Me.barStatus)
        Me.Controls.Add(Me.barTool)
        Me.Controls.Add(Me.barMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.barMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KAnotes"
        Me.barMenu.ResumeLayout(False)
        Me.barMenu.PerformLayout()
        Me.barStatus.ResumeLayout(False)
        Me.barStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barMenu As MenuStrip
    Friend WithEvents itmHelp As ToolStripMenuItem
    Friend WithEvents itmAbout As ToolStripMenuItem
    Friend WithEvents itmFile As ToolStripMenuItem
    Friend WithEvents itmNew As ToolStripMenuItem
    Friend WithEvents itmSeparator1 As ToolStripSeparator
    Friend WithEvents itmOpen As ToolStripMenuItem
    Friend WithEvents itmSeparator2 As ToolStripSeparator
    Friend WithEvents itmSave As ToolStripMenuItem
    Friend WithEvents itmSaveAs As ToolStripMenuItem
    Friend WithEvents itmSeparator3 As ToolStripSeparator
    Friend WithEvents itmPrint As ToolStripMenuItem
    Friend WithEvents itmPageSetup As ToolStripMenuItem
    Friend WithEvents itmSeparator4 As ToolStripSeparator
    Friend WithEvents itmExit As ToolStripMenuItem
    Friend WithEvents itmEdit As ToolStripMenuItem
    Friend WithEvents itmUndo As ToolStripMenuItem
    Friend WithEvents itmRedo As ToolStripMenuItem
    Friend WithEvents itmSeparator5 As ToolStripSeparator
    Friend WithEvents itmCut As ToolStripMenuItem
    Friend WithEvents itmCopy As ToolStripMenuItem
    Friend WithEvents itmPaste As ToolStripMenuItem
    Friend WithEvents itmDelete As ToolStripMenuItem
    Friend WithEvents itmSeparator6 As ToolStripSeparator
    Friend WithEvents itmSelectAll As ToolStripMenuItem
    Friend WithEvents itmSeparator7 As ToolStripSeparator
    Friend WithEvents itmFindReplace As ToolStripMenuItem
    Friend WithEvents itmView As ToolStripMenuItem
    Friend WithEvents itmOptions As ToolStripMenuItem
    Friend WithEvents editor As RichTextBox
    Friend WithEvents barTool As ToolStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents barStatus As StatusStrip
    Friend WithEvents lblCharacters As ToolStripStatusLabel
    Friend WithEvents lblWords As ToolStripStatusLabel
    Friend WithEvents lblCharacterCount As ToolStripStatusLabel
    Friend WithEvents lblWordCount As ToolStripStatusLabel
End Class
