<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.RefreshClip = New System.Windows.Forms.ToolStripButton()
        Me.FormatsMnu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Formats = New System.Windows.Forms.ListBox()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ImagePanel = New System.Windows.Forms.Panel()
        Me.ImageView = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTxt = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Txt = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.EmptyMsg = New System.Windows.Forms.Label()
        Me.MenuImages = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.Context.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ImagePanel.SuspendLayout()
        CType(Me.ImageView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Context
        '
        Me.Context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem1, Me.SaveAsToolStripMenuItem1})
        Me.Context.Name = "ContextMenuStrip1"
        Me.Context.Size = New System.Drawing.Size(124, 48)
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Image = CType(resources.GetObject("CopyToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        Me.CopyToolStripMenuItem1.ToolTipText = "Note: This will not be reflected in the program until you refresh."
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.Image = CType(resources.GetObject("SaveAsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save As..."
        '
        'Tools
        '
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshClip, Me.FormatsMnu})
        Me.Tools.Location = New System.Drawing.Point(0, 0)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(683, 25)
        Me.Tools.TabIndex = 11
        Me.Tools.Text = "ToolStrip1"
        '
        'RefreshClip
        '
        Me.RefreshClip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshClip.Image = CType(resources.GetObject("RefreshClip.Image"), System.Drawing.Image)
        Me.RefreshClip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshClip.Name = "RefreshClip"
        Me.RefreshClip.Size = New System.Drawing.Size(23, 22)
        Me.RefreshClip.Text = "Refresh Clipboard"
        '
        'FormatsMnu
        '
        Me.FormatsMnu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.FormatsMnu.BackColor = System.Drawing.SystemColors.Control
        Me.FormatsMnu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FormatsMnu.Image = CType(resources.GetObject("FormatsMnu.Image"), System.Drawing.Image)
        Me.FormatsMnu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FormatsMnu.Name = "FormatsMnu"
        Me.FormatsMnu.Size = New System.Drawing.Size(29, 22)
        Me.FormatsMnu.Text = "Formats in Clipboard"
        '
        'Formats
        '
        Me.Formats.Dock = System.Windows.Forms.DockStyle.Right
        Me.Formats.FormattingEnabled = True
        Me.Formats.HorizontalScrollbar = True
        Me.Formats.Location = New System.Drawing.Point(563, 25)
        Me.Formats.Name = "Formats"
        Me.Formats.Size = New System.Drawing.Size(120, 477)
        Me.Formats.TabIndex = 4
        Me.Formats.Visible = False
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPage1)
        Me.Tabs.Controls.Add(Me.TabPage2)
        Me.Tabs.Controls.Add(Me.TabPage3)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 25)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(563, 477)
        Me.Tabs.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ImagePanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(555, 451)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Image"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ImagePanel
        '
        Me.ImagePanel.AutoScroll = True
        Me.ImagePanel.BackgroundImage = CType(resources.GetObject("ImagePanel.BackgroundImage"), System.Drawing.Image)
        Me.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagePanel.Controls.Add(Me.ImageView)
        Me.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagePanel.Location = New System.Drawing.Point(3, 3)
        Me.ImagePanel.Name = "ImagePanel"
        Me.ImagePanel.Size = New System.Drawing.Size(549, 445)
        Me.ImagePanel.TabIndex = 7
        '
        'ImageView
        '
        Me.ImageView.BackColor = System.Drawing.Color.Transparent
        Me.ImageView.ContextMenuStrip = Me.Context
        Me.ImageView.Location = New System.Drawing.Point(-1, 0)
        Me.ImageView.Name = "ImageView"
        Me.ImageView.Size = New System.Drawing.Size(100, 50)
        Me.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImageView.TabIndex = 3
        Me.ImageView.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTxt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(555, 451)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rich Text"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTxt
        '
        Me.RichTxt.BackColor = System.Drawing.Color.White
        Me.RichTxt.ContextMenuStrip = Me.Context
        Me.RichTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTxt.Location = New System.Drawing.Point(3, 3)
        Me.RichTxt.Name = "RichTxt"
        Me.RichTxt.ReadOnly = True
        Me.RichTxt.Size = New System.Drawing.Size(549, 445)
        Me.RichTxt.TabIndex = 10
        Me.RichTxt.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Txt)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(555, 451)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Text"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Txt
        '
        Me.Txt.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Txt.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]*" & _
            "(?<range>:)\s*(?<range>[^;]+);"
        Me.Txt.AutoScrollMinSize = New System.Drawing.Size(0, 14)
        Me.Txt.BackBrush = Nothing
        Me.Txt.CharHeight = 14
        Me.Txt.CharWidth = 8
        Me.Txt.ContextMenuStrip = Me.Context
        Me.Txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt.IsReplaceMode = False
        Me.Txt.Location = New System.Drawing.Point(3, 3)
        Me.Txt.Name = "Txt"
        Me.Txt.Paddings = New System.Windows.Forms.Padding(0)
        Me.Txt.ReadOnly = True
        Me.Txt.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt.ServiceColors = Nothing
        Me.Txt.Size = New System.Drawing.Size(549, 445)
        Me.Txt.TabIndex = 11
        Me.Txt.WordWrap = True
        Me.Txt.Zoom = 100
        '
        'EmptyMsg
        '
        Me.EmptyMsg.BackColor = System.Drawing.Color.White
        Me.EmptyMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmptyMsg.Location = New System.Drawing.Point(0, 0)
        Me.EmptyMsg.Name = "EmptyMsg"
        Me.EmptyMsg.Size = New System.Drawing.Size(683, 502)
        Me.EmptyMsg.TabIndex = 15
        Me.EmptyMsg.Text = "The clipboard is currently empty. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to refresh."
        Me.EmptyMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuImages
        '
        Me.MenuImages.ImageStream = CType(resources.GetObject("MenuImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MenuImages.TransparentColor = System.Drawing.Color.Transparent
        Me.MenuImages.Images.SetKeyName(0, "ClearClipboard")
        Me.MenuImages.Images.SetKeyName(1, "ShowFormatsPanel")
        Me.MenuImages.Images.SetKeyName(2, "FormatDocument")
        Me.MenuImages.Images.SetKeyName(3, "Information")
        '
        'SaveAs
        '
        Me.SaveAs.Title = "Save As"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 502)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.Formats)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.EmptyMsg)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Clipboard Viewer"
        Me.Context.ResumeLayout(False)
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.Tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ImagePanel.ResumeLayout(False)
        Me.ImagePanel.PerformLayout()
        CType(Me.ImageView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Txt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tools As System.Windows.Forms.ToolStrip
    Friend WithEvents RefreshClip As System.Windows.Forms.ToolStripButton
    Friend WithEvents FormatsMnu As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Formats As System.Windows.Forms.ListBox
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ImagePanel As System.Windows.Forms.Panel
    Friend WithEvents ImageView As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RichTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Txt As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents EmptyMsg As System.Windows.Forms.Label
    Friend WithEvents MenuImages As System.Windows.Forms.ImageList
    Friend WithEvents SaveAs As System.Windows.Forms.SaveFileDialog

End Class
