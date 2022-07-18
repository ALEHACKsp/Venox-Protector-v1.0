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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnbrowse = New System.Windows.Forms.PictureBox()
        Me.btnprotect = New System.Windows.Forms.PictureBox()
        Me.btnsettings = New System.Windows.Forms.PictureBox()
        Me.btncredits = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SettingsPage = New System.Windows.Forms.TabPage()
        Me.actall = New VENOX.InxCheckBox()
        Me.Hidenamespaces = New VENOX.InxCheckBox()
        Me.strencryption = New VENOX.InxCheckBox()
        Me.fixresources = New VENOX.InxCheckBox()
        Me.junk = New VENOX.InxCheckBox()
        Me.renamer = New VENOX.InxCheckBox()
        Me.antiildasm = New VENOX.InxCheckBox()
        Me.CreditsPage = New System.Windows.Forms.TabPage()
        Me.Discord = New System.Windows.Forms.PictureBox()
        Me.InxLabel3 = New VENOX.InxLabel()
        Me.InxLabel2 = New VENOX.InxLabel()
        Me.InxLabel1 = New VENOX.InxLabel()
        Me.logpage = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MovePanel1 = New VENOX.MovePanel()
        Me.btnclose = New System.Windows.Forms.Panel()
        Me.btnmin = New System.Windows.Forms.Panel()
        Me.AssemblyPath = New VENOX.DarkUITextBox()
        CType(Me.btnbrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnprotect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncredits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SettingsPage.SuspendLayout()
        Me.CreditsPage.SuspendLayout()
        CType(Me.Discord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.logpage.SuspendLayout()
        Me.MovePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbrowse
        '
        Me.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbrowse.Image = CType(resources.GetObject("btnbrowse.Image"), System.Drawing.Image)
        Me.btnbrowse.Location = New System.Drawing.Point(52, 102)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(48, 48)
        Me.btnbrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnbrowse.TabIndex = 0
        Me.btnbrowse.TabStop = False
        '
        'btnprotect
        '
        Me.btnprotect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprotect.Image = CType(resources.GetObject("btnprotect.Image"), System.Drawing.Image)
        Me.btnprotect.Location = New System.Drawing.Point(108, 102)
        Me.btnprotect.Name = "btnprotect"
        Me.btnprotect.Size = New System.Drawing.Size(48, 48)
        Me.btnprotect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnprotect.TabIndex = 1
        Me.btnprotect.TabStop = False
        '
        'btnsettings
        '
        Me.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsettings.Image = CType(resources.GetObject("btnsettings.Image"), System.Drawing.Image)
        Me.btnsettings.Location = New System.Drawing.Point(164, 102)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(48, 48)
        Me.btnsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnsettings.TabIndex = 2
        Me.btnsettings.TabStop = False
        '
        'btncredits
        '
        Me.btncredits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncredits.Image = CType(resources.GetObject("btncredits.Image"), System.Drawing.Image)
        Me.btncredits.Location = New System.Drawing.Point(220, 102)
        Me.btncredits.Name = "btncredits"
        Me.btncredits.Size = New System.Drawing.Size(48, 48)
        Me.btncredits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btncredits.TabIndex = 3
        Me.btncredits.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 140)
        Me.Panel1.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CreditsPage)
        Me.TabControl1.Controls.Add(Me.SettingsPage)
        Me.TabControl1.Controls.Add(Me.logpage)
        Me.TabControl1.Location = New System.Drawing.Point(-4, -22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(328, 166)
        Me.TabControl1.TabIndex = 0
        '
        'SettingsPage
        '
        Me.SettingsPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SettingsPage.Controls.Add(Me.actall)
        Me.SettingsPage.Controls.Add(Me.Hidenamespaces)
        Me.SettingsPage.Controls.Add(Me.strencryption)
        Me.SettingsPage.Controls.Add(Me.fixresources)
        Me.SettingsPage.Controls.Add(Me.junk)
        Me.SettingsPage.Controls.Add(Me.renamer)
        Me.SettingsPage.Controls.Add(Me.antiildasm)
        Me.SettingsPage.Location = New System.Drawing.Point(4, 22)
        Me.SettingsPage.Name = "SettingsPage"
        Me.SettingsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingsPage.Size = New System.Drawing.Size(320, 140)
        Me.SettingsPage.TabIndex = 0
        '
        'actall
        '
        Me.actall.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.actall.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.actall.Checked = False
        Me.actall.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.actall.Cursor = System.Windows.Forms.Cursors.Default
        Me.actall.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.actall.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.actall.Location = New System.Drawing.Point(13, 104)
        Me.actall.Name = "actall"
        Me.actall.Size = New System.Drawing.Size(295, 22)
        Me.actall.TabIndex = 6
        Me.actall.Text = "Best settings ( Active all recommended )"
        '
        'Hidenamespaces
        '
        Me.Hidenamespaces.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Hidenamespaces.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Hidenamespaces.Checked = False
        Me.Hidenamespaces.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Hidenamespaces.Cursor = System.Windows.Forms.Cursors.Default
        Me.Hidenamespaces.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Hidenamespaces.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Hidenamespaces.Location = New System.Drawing.Point(164, 15)
        Me.Hidenamespaces.Name = "Hidenamespaces"
        Me.Hidenamespaces.Size = New System.Drawing.Size(145, 22)
        Me.Hidenamespaces.TabIndex = 5
        Me.Hidenamespaces.Text = "Hide Namespaces"
        '
        'strencryption
        '
        Me.strencryption.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.strencryption.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.strencryption.Checked = False
        Me.strencryption.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.strencryption.Cursor = System.Windows.Forms.Cursors.Default
        Me.strencryption.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.strencryption.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.strencryption.Location = New System.Drawing.Point(13, 71)
        Me.strencryption.Name = "strencryption"
        Me.strencryption.Size = New System.Drawing.Size(145, 22)
        Me.strencryption.TabIndex = 4
        Me.strencryption.Text = "Strings Encryption"
        '
        'fixresources
        '
        Me.fixresources.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.fixresources.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.fixresources.Checked = False
        Me.fixresources.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.fixresources.Cursor = System.Windows.Forms.Cursors.Default
        Me.fixresources.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.fixresources.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.fixresources.Location = New System.Drawing.Point(164, 71)
        Me.fixresources.Name = "fixresources"
        Me.fixresources.Size = New System.Drawing.Size(145, 22)
        Me.fixresources.TabIndex = 3
        Me.fixresources.Text = "Fix Res"
        '
        'junk
        '
        Me.junk.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.junk.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.junk.Checked = False
        Me.junk.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.junk.Cursor = System.Windows.Forms.Cursors.Default
        Me.junk.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.junk.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.junk.Location = New System.Drawing.Point(13, 43)
        Me.junk.Name = "junk"
        Me.junk.Size = New System.Drawing.Size(145, 22)
        Me.junk.TabIndex = 2
        Me.junk.Text = "Junk"
        '
        'renamer
        '
        Me.renamer.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.renamer.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.renamer.Checked = False
        Me.renamer.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.renamer.Cursor = System.Windows.Forms.Cursors.Default
        Me.renamer.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.renamer.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.renamer.Location = New System.Drawing.Point(164, 43)
        Me.renamer.Name = "renamer"
        Me.renamer.Size = New System.Drawing.Size(92, 22)
        Me.renamer.TabIndex = 1
        Me.renamer.Text = "Renamer"
        '
        'antiildasm
        '
        Me.antiildasm.BaseColour = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.antiildasm.BorderColour = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.antiildasm.Checked = False
        Me.antiildasm.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.antiildasm.Cursor = System.Windows.Forms.Cursors.Default
        Me.antiildasm.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.antiildasm.FontColour = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.antiildasm.Location = New System.Drawing.Point(13, 15)
        Me.antiildasm.Name = "antiildasm"
        Me.antiildasm.Size = New System.Drawing.Size(145, 22)
        Me.antiildasm.TabIndex = 0
        Me.antiildasm.Text = "Anti ILDasm"
        '
        'CreditsPage
        '
        Me.CreditsPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CreditsPage.Controls.Add(Me.Discord)
        Me.CreditsPage.Controls.Add(Me.InxLabel3)
        Me.CreditsPage.Controls.Add(Me.InxLabel2)
        Me.CreditsPage.Controls.Add(Me.InxLabel1)
        Me.CreditsPage.Location = New System.Drawing.Point(4, 22)
        Me.CreditsPage.Name = "CreditsPage"
        Me.CreditsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CreditsPage.Size = New System.Drawing.Size(320, 140)
        Me.CreditsPage.TabIndex = 1
        '
        'Discord
        '
        Me.Discord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Discord.Image = CType(resources.GetObject("Discord.Image"), System.Drawing.Image)
        Me.Discord.Location = New System.Drawing.Point(136, 82)
        Me.Discord.Name = "Discord"
        Me.Discord.Size = New System.Drawing.Size(48, 48)
        Me.Discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Discord.TabIndex = 9
        Me.Discord.TabStop = False
        '
        'InxLabel3
        '
        Me.InxLabel3.AutoSize = True
        Me.InxLabel3.BackColor = System.Drawing.Color.Transparent
        Me.InxLabel3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.InxLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.InxLabel3.Location = New System.Drawing.Point(116, 39)
        Me.InxLabel3.Name = "InxLabel3"
        Me.InxLabel3.Size = New System.Drawing.Size(89, 19)
        Me.InxLabel3.TabIndex = 2
        Me.InxLabel3.Text = "Version : 1.0"
        Me.InxLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'InxLabel2
        '
        Me.InxLabel2.AutoSize = True
        Me.InxLabel2.BackColor = System.Drawing.Color.Transparent
        Me.InxLabel2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.InxLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.InxLabel2.Location = New System.Drawing.Point(50, 58)
        Me.InxLabel2.Name = "InxLabel2"
        Me.InxLabel2.Size = New System.Drawing.Size(220, 19)
        Me.InxLabel2.TabIndex = 1
        Me.InxLabel2.Text = "Made By : Omar Ramadan ( Inx )"
        Me.InxLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'InxLabel1
        '
        Me.InxLabel1.AutoSize = True
        Me.InxLabel1.BackColor = System.Drawing.Color.Transparent
        Me.InxLabel1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InxLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.InxLabel1.Location = New System.Drawing.Point(55, 11)
        Me.InxLabel1.Name = "InxLabel1"
        Me.InxLabel1.Size = New System.Drawing.Size(210, 19)
        Me.InxLabel1.TabIndex = 0
        Me.InxLabel1.Text = "Venox Protector / Obfuscator"
        Me.InxLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'logpage
        '
        Me.logpage.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.logpage.Controls.Add(Me.RichTextBox1)
        Me.logpage.Location = New System.Drawing.Point(4, 22)
        Me.logpage.Name = "logpage"
        Me.logpage.Padding = New System.Windows.Forms.Padding(3)
        Me.logpage.Size = New System.Drawing.Size(320, 140)
        Me.logpage.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ShortcutsEnabled = False
        Me.RichTextBox1.Size = New System.Drawing.Size(300, 120)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Log"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(0, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 1)
        Me.Panel2.TabIndex = 7
        '
        'MovePanel1
        '
        Me.MovePanel1.BackColor = System.Drawing.Color.Transparent
        Me.MovePanel1.Controls.Add(Me.btnclose)
        Me.MovePanel1.Controls.Add(Me.btnmin)
        Me.MovePanel1.Location = New System.Drawing.Point(0, 0)
        Me.MovePanel1.Name = "MovePanel1"
        Me.MovePanel1.Size = New System.Drawing.Size(320, 34)
        Me.MovePanel1.TabIndex = 7
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Location = New System.Drawing.Point(299, 11)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(12, 12)
        Me.btnclose.TabIndex = 5
        '
        'btnmin
        '
        Me.btnmin.BackColor = System.Drawing.Color.Transparent
        Me.btnmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmin.Location = New System.Drawing.Point(282, 11)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(12, 12)
        Me.btnmin.TabIndex = 6
        '
        'AssemblyPath
        '
        Me.AssemblyPath.AutoCompleteCustomSource = Nothing
        Me.AssemblyPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.AssemblyPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.AssemblyPath.BackColor = System.Drawing.Color.Transparent
        Me.AssemblyPath.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AssemblyPath.ForeColor = System.Drawing.Color.LightGray
        Me.AssemblyPath.Image = Nothing
        Me.AssemblyPath.Lines = Nothing
        Me.AssemblyPath.Location = New System.Drawing.Point(30, 67)
        Me.AssemblyPath.MaxLength = 32767
        Me.AssemblyPath.Multiline = False
        Me.AssemblyPath.Name = "AssemblyPath"
        Me.AssemblyPath.ReadOnly = True
        Me.AssemblyPath.Size = New System.Drawing.Size(260, 28)
        Me.AssemblyPath.TabIndex = 1
        Me.AssemblyPath.Text = "Drag & Drop Supported"
        Me.AssemblyPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AssemblyPath.UseSystemPasswordChar = False
        Me.AssemblyPath.WatermarkText = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(320, 160)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MovePanel1)
        Me.Controls.Add(Me.AssemblyPath)
        Me.Controls.Add(Me.btncredits)
        Me.Controls.Add(Me.btnsettings)
        Me.Controls.Add(Me.btnprotect)
        Me.Controls.Add(Me.btnbrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(320, 300)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venox Protector"
        CType(Me.btnbrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnprotect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncredits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.SettingsPage.ResumeLayout(False)
        Me.CreditsPage.ResumeLayout(False)
        Me.CreditsPage.PerformLayout()
        CType(Me.Discord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.logpage.ResumeLayout(False)
        Me.MovePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbrowse As System.Windows.Forms.PictureBox
    Friend WithEvents btnprotect As System.Windows.Forms.PictureBox
    Friend WithEvents btnsettings As System.Windows.Forms.PictureBox
    Friend WithEvents btncredits As System.Windows.Forms.PictureBox
    Friend WithEvents btnclose As System.Windows.Forms.Panel
    Friend WithEvents btnmin As System.Windows.Forms.Panel
    Friend WithEvents AssemblyPath As VENOX.DarkUITextBox
    Friend WithEvents MovePanel1 As VENOX.MovePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SettingsPage As System.Windows.Forms.TabPage
    Friend WithEvents CreditsPage As System.Windows.Forms.TabPage
    Friend WithEvents fixresources As VENOX.InxCheckBox
    Friend WithEvents junk As VENOX.InxCheckBox
    Friend WithEvents renamer As VENOX.InxCheckBox
    Friend WithEvents antiildasm As VENOX.InxCheckBox
    Friend WithEvents Discord As System.Windows.Forms.PictureBox
    Friend WithEvents InxLabel3 As VENOX.InxLabel
    Friend WithEvents InxLabel2 As VENOX.InxLabel
    Friend WithEvents InxLabel1 As VENOX.InxLabel
    Friend WithEvents strencryption As VENOX.InxCheckBox
    Friend WithEvents logpage As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Hidenamespaces As VENOX.InxCheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents actall As VENOX.InxCheckBox

End Class
