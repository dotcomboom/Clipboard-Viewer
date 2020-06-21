Public Class Main

    Private _Image As TabPage
    Private _RichText As TabPage
    Private _PlainText As TabPage

    Private ListboxShown As New System.Windows.Forms.ToolStripMenuItem
    Private ClearClipboard_ As New System.Windows.Forms.ToolStripMenuItem
    Private About As New System.Windows.Forms.ToolStripMenuItem

    Const errFormat As String = "Something went wrong when loading this data as plain text.{0}It is likely binary or empty.{0}{0}More info:{0}  {1}"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Image = Tabs.TabPages.Item(0)
        _RichText = Tabs.TabPages.Item(1)
        _PlainText = Tabs.TabPages.Item(2)

        ListboxShown.Text = "Show Formats panel"
        ListboxShown.Image = MenuImages.Images.Item("ShowFormatsPanel")
        ListboxShown.CheckOnClick = True
        ListboxShown.Checked = Formats.Visible
        AddHandler ListboxShown.Click, AddressOf HandlePanel

        ClearClipboard_.Text = "Clear Clipboard"
        ClearClipboard_.Image = MenuImages.Images.Item("ClearClipboard")
        AddHandler ClearClipboard_.Click, AddressOf doClearClipboard

        About.Text = "About"
        About.Image = MenuImages.Images.Item("Information")
        AddHandler About.Click, AddressOf doAbout

        ClearTabs()
        LoadClipboard()
    End Sub

    Private Sub RemoveTab(ByVal tab As TabPage)
        If Tabs.TabPages.Contains(tab) Then
            Tabs.TabPages.Remove(tab)
        End If
    End Sub
    Private Sub AddTab(ByVal tab As TabPage)
        If Not Tabs.TabPages.Contains(tab) Then
            Tabs.TabPages.Add(tab)
        End If
    End Sub
    Private Sub ClearTabs()
        Tabs.TabPages.Clear()
    End Sub

    Private Sub LoadClipboard() Handles RefreshClip.Click, EmptyMsg.Click
        FormatsMnu.DropDownItems.Clear()
        Formats.Items.Clear()
        _Image.Text = "Image"
        _RichText.Text = "RTF"
        _PlainText.Text = "Text"

        ClearTabs()

        If Not ImageView.Image Is Nothing Then
            ImageView.Image.Dispose()
        End If
        For Each f As String In My.Computer.Clipboard.GetDataObject.GetFormats()
            Formats.Items.Add(f)
            Dim fs = FormatsMnu.DropDownItems.Add(f)
            fs.Image = MenuImages.Images.Item("FormatDocument")
            AddHandler fs.Click, AddressOf HandleLoadType
        Next
        If FormatsMnu.DropDownItems.Count > 0 Then
            FormatsMnu.DropDownItems.Add(New System.Windows.Forms.ToolStripSeparator)
        End If
        FormatsMnu.DropDownItems.Add(ListboxShown)
        FormatsMnu.DropDownItems.Add(ClearClipboard_)
        FormatsMnu.DropDownItems.Add(New System.Windows.Forms.ToolStripSeparator)
        FormatsMnu.DropDownItems.Add(About)
        If My.Computer.Clipboard.ContainsImage() Then
            ImageView.Image = My.Computer.Clipboard.GetImage
            _Image.Text = String.Format("Image: {0} x {1}", ImageView.Image.Width, ImageView.Image.Height)
            AddTab(_Image)
        End If
        If Array.IndexOf(My.Computer.Clipboard.GetDataObject.GetFormats, ("Rich Text Format")) > -1 Then
            RichTxt.Rtf = My.Computer.Clipboard.GetData("Rich Text Format")
            AddTab(_RichText)
        End If
        If My.Computer.Clipboard.ContainsText() Then
            Txt.Text = My.Computer.Clipboard.GetText()
            _PlainText.Text = "Text"
            AddTab(_PlainText)
        End If

        Tabs.Visible = Not (Tabs.TabCount = 0)
    End Sub

    Private Function HandleLoadType(ByVal sender, ByVal e)
        Txt.Show()
        AddTab(_PlainText)
        _PlainText.Text = sender.Text
        Tabs.SelectTab(_PlainText)
        Try
            Txt.ForeColor = Color.Black
            Txt.Text = My.Computer.Clipboard.GetData(sender.Text)
        Catch ex As Exception
            Txt.ForeColor = Color.OrangeRed
            Txt.Text = String.Format(errFormat, vbNewLine, ex.ToString)
        End Try
        Return True
    End Function

    Private Sub HandlePanel(ByVal sender, ByVal e)
        Formats.Visible = ListboxShown.Checked
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Formats.SelectedIndexChanged
        Txt.Show()
        AddTab(_PlainText)
        _PlainText.Text = Formats.SelectedItem
        Tabs.SelectTab(_PlainText)
        Try
            Txt.ForeColor = Color.Black
            Txt.Text = My.Computer.Clipboard.GetData(Formats.SelectedItem)
        Catch ex As Exception
            Txt.ForeColor = Color.OrangeRed
            Txt.Text = String.Format(errFormat, vbNewLine, ex.ToString)
        End Try
    End Sub

    Private Sub doClearClipboard()
        My.Computer.Clipboard.Clear()
        LoadClipboard()
    End Sub

    Private Sub doAbout()
        MsgBox(String.Format("Clipboard Viewer 1.0{0}by dotcomboom{0}{0}Made on the fine thirteenth day of the sixth month of two-thousand and twenty{0}{0}Visit on the web at dotcomboom.somnolescent.net", vbNewLine), MsgBoxStyle.Information, "About this program")
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        If Context.SourceControl.GetType().ToString = "FastColoredTextBoxNS.FastColoredTextBox" Then
            Dim ns As FastColoredTextBoxNS.FastColoredTextBox = Context.SourceControl
            ns.Copy()
        ElseIf Context.SourceControl.GetType().ToString = "System.Windows.Forms.RichTextBox" Then
            Dim ns As RichTextBox = Context.SourceControl
            ns.Copy()
        ElseIf Context.SourceControl.GetType().ToString = "System.Windows.Forms.PictureBox" Then
            Dim ns As PictureBox = Context.SourceControl
            My.Computer.Clipboard.SetImage(ns.Image)
        End If
    End Sub
    Private Function GuessImageFormat(Filename As String)
        If Filename.EndsWith(".jpg") Then
            Return System.Drawing.Imaging.ImageFormat.Jpeg
        ElseIf Filename.EndsWith(".png") Then
            Return System.Drawing.Imaging.ImageFormat.Png
        ElseIf Filename.EndsWith(".gif") Then
            Return System.Drawing.Imaging.ImageFormat.Gif
        ElseIf Filename.EndsWith(".tiff") Then
            Return System.Drawing.Imaging.ImageFormat.Tiff
        ElseIf Filename.EndsWith(".wmf") Then
            Return System.Drawing.Imaging.ImageFormat.Wmf
        End If
        Return System.Drawing.Imaging.ImageFormat.Bmp
    End Function

    Private Sub SaveAs_Click(sender As System.Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click
        If Context.SourceControl.GetType().ToString = "FastColoredTextBoxNS.FastColoredTextBox" Then
            SaveAs.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*"
        ElseIf Context.SourceControl.GetType().ToString = "System.Windows.Forms.RichTextBox" Then
            SaveAs.Filter = "Rich Text Format (RTF) (*.rtf)|*.rtf|Text Document (*.txt)|*.txt|All files (*.*)|*.*"
        ElseIf Context.SourceControl.GetType().ToString = "System.Windows.Forms.PictureBox" Then
            SaveAs.Filter = "Portable Network Graphics (*.png)|*.png|JPEG (*.jpg)|*.jpg|CompuServe GIF (*.gif)|*.gif|TIFF (*.tiff)|*.tiff|WMF (*.wmf)|*.wmf|BMP (*.bmp)|*.bmp|All files (*.*)|*.*"
        End If
        If SaveAs.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Context.SourceControl.GetType().ToString = "FastColoredTextBoxNS.FastColoredTextBox" Then
                Dim ns As FastColoredTextBoxNS.FastColoredTextBox = Context.SourceControl
                ns.SaveToFile(SaveAs.FileName, System.Text.Encoding.UTF8)
            ElseIf Context.SourceControl.GetType().ToString = "System.Windows.Forms.RichTextBox" Then
                Dim ns As RichTextBox = Context.SourceControl
                ns.SaveFile(SaveAs.FileName)
            ElseIf Context.SourceControl.GetType().ToString = "System.Windows.Forms.PictureBox" Then
                Dim ns As PictureBox = Context.SourceControl
                My.Computer.Clipboard.SetImage(ns.Image)
                ns.Image.Save(SaveAs.FileName, GuessImageFormat(SaveAs.FileName))
            End If
        End If
    End Sub
End Class
