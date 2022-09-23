<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LocateButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.MuteButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LaterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.WebpageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LocateButton
        '
        Me.LocateButton.Location = New System.Drawing.Point(441, 206)
        Me.LocateButton.Name = "LocateButton"
        Me.LocateButton.Size = New System.Drawing.Size(203, 35)
        Me.LocateButton.TabIndex = 0
        Me.LocateButton.Text = "Locate Dolphin"
        Me.LocateButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(12, 207)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(93, 13)
        Me.StatusLabel.TabIndex = 1
        Me.StatusLabel.Text = "Waiting for input..."
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(13, 224)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 17)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 2
        Me.ProgressBar.Visible = False
        '
        'MuteButton
        '
        Me.MuteButton.BackgroundImage = Global.PetRussianDolphinLocator.My.Resources.Resources.mutebutton
        Me.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MuteButton.Location = New System.Drawing.Point(650, 206)
        Me.MuteButton.Name = "MuteButton"
        Me.MuteButton.Size = New System.Drawing.Size(75, 35)
        Me.MuteButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.MuteButton, "Mute The Audo")
        Me.MuteButton.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Crazy Help"
        '
        'LaterTimer
        '
        Me.LaterTimer.Interval = 30000
        '
        'AboutButton
        '
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.AboutButton.Location = New System.Drawing.Point(578, 247)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(147, 22)
        Me.AboutButton.TabIndex = 4
        Me.AboutButton.Text = "About This Softwares"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'WebpageButton
        '
        Me.WebpageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.WebpageButton.Location = New System.Drawing.Point(288, 247)
        Me.WebpageButton.Name = "WebpageButton"
        Me.WebpageButton.Size = New System.Drawing.Size(284, 22)
        Me.WebpageButton.TabIndex = 5
        Me.WebpageButton.Text = "Get More Products from Workplace2Software"
        Me.WebpageButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PetRussianDolphinLocator.My.Resources.Resources.dolphin_isolated_white_additional_png_attached_transparent_layer_your_convenience_60909202
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(731, 271)
        Me.Controls.Add(Me.WebpageButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.MuteButton)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.LocateButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FindMyDolphin 6 Deluxe Server Edition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LocateButton As System.Windows.Forms.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents MuteButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LaterTimer As System.Windows.Forms.Timer
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents WebpageButton As System.Windows.Forms.Button

End Class
