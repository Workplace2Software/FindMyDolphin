<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BlinkText = New System.Windows.Forms.Label()
        Me.BlinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DolphinImage = New System.Windows.Forms.Panel()
        Me.coolBrowser = New System.Windows.Forms.WebBrowser()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlinkText
        '
        Me.BlinkText.Dock = System.Windows.Forms.DockStyle.Top
        Me.BlinkText.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlinkText.ForeColor = System.Drawing.Color.Black
        Me.BlinkText.Location = New System.Drawing.Point(0, 0)
        Me.BlinkText.Name = "BlinkText"
        Me.BlinkText.Size = New System.Drawing.Size(551, 65)
        Me.BlinkText.TabIndex = 0
        Me.BlinkText.Text = "Loading..."
        Me.BlinkText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BlinkTimer
        '
        Me.BlinkTimer.Interval = 500
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 65)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DolphinImage)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.coolBrowser)
        Me.SplitContainer1.Size = New System.Drawing.Size(551, 330)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 1
        '
        'DolphinImage
        '
        Me.DolphinImage.BackgroundImage = Global.PetRussianDolphinLocator.My.Resources.Resources.dolphin_in_water
        Me.DolphinImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DolphinImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DolphinImage.Location = New System.Drawing.Point(0, 0)
        Me.DolphinImage.Name = "DolphinImage"
        Me.DolphinImage.Size = New System.Drawing.Size(129, 330)
        Me.DolphinImage.TabIndex = 6
        Me.DolphinImage.Visible = False
        '
        'coolBrowser
        '
        Me.coolBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.coolBrowser.Location = New System.Drawing.Point(0, 0)
        Me.coolBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.coolBrowser.Name = "coolBrowser"
        Me.coolBrowser.ScriptErrorsSuppressed = True
        Me.coolBrowser.ScrollBarsEnabled = False
        Me.coolBrowser.Size = New System.Drawing.Size(418, 330)
        Me.coolBrowser.TabIndex = 6
        Me.coolBrowser.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 395)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.BlinkText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlinkText As System.Windows.Forms.Label
    Friend WithEvents BlinkTimer As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DolphinImage As System.Windows.Forms.Panel
    Friend WithEvents coolBrowser As System.Windows.Forms.WebBrowser
End Class
