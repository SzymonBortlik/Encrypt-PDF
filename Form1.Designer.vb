<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LabEnterP = New System.Windows.Forms.Label()
        Me.SavePdf = New System.Windows.Forms.Button()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.OpenPdf = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ForgetMP = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabEnterP
        '
        Me.LabEnterP.BackColor = System.Drawing.Color.Transparent
        Me.LabEnterP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEnterP.ForeColor = System.Drawing.SystemColors.Control
        Me.LabEnterP.Location = New System.Drawing.Point(23, 130)
        Me.LabEnterP.Name = "LabEnterP"
        Me.LabEnterP.Size = New System.Drawing.Size(113, 18)
        Me.LabEnterP.TabIndex = 16
        Me.LabEnterP.Text = "Enter password"
        '
        'SavePdf
        '
        Me.SavePdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavePdf.Location = New System.Drawing.Point(22, 231)
        Me.SavePdf.Name = "SavePdf"
        Me.SavePdf.Size = New System.Drawing.Size(241, 40)
        Me.SavePdf.TabIndex = 15
        Me.SavePdf.Text = "Encrypt PDF file"
        Me.SavePdf.UseVisualStyleBackColor = True
        '
        'TextBoxPass
        '
        Me.TextBoxPass.CausesValidation = False
        Me.TextBoxPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPass.ForeColor = System.Drawing.Color.Red
        Me.TextBoxPass.Location = New System.Drawing.Point(22, 156)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.TextBoxPass.Size = New System.Drawing.Size(241, 29)
        Me.TextBoxPass.TabIndex = 14
        Me.TextBoxPass.WordWrap = False
        '
        'OpenPdf
        '
        Me.OpenPdf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OpenPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenPdf.Location = New System.Drawing.Point(22, 49)
        Me.OpenPdf.Name = "OpenPdf"
        Me.OpenPdf.Size = New System.Drawing.Size(241, 40)
        Me.OpenPdf.TabIndex = 13
        Me.OpenPdf.Text = "Open PDF File"
        Me.OpenPdf.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ForgetMP
        '
        Me.ForgetMP.AutoSize = True
        Me.ForgetMP.BackColor = System.Drawing.Color.Transparent
        Me.ForgetMP.FlatAppearance.BorderSize = 0
        Me.ForgetMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ForgetMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForgetMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgetMP.Location = New System.Drawing.Point(0, 502)
        Me.ForgetMP.Name = "ForgetMP"
        Me.ForgetMP.Size = New System.Drawing.Size(70, 25)
        Me.ForgetMP.TabIndex = 18
        Me.ForgetMP.Text = "♥FMP♥"
        Me.ForgetMP.UseVisualStyleBackColor = False
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.AllowDrop = True
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(625, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(364, 527)
        Me.AxAcroPDF1.TabIndex = 17
        Me.AxAcroPDF1.Visible = False
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.Encrypt_PDF.My.Resources.Resources.iStock_612828352
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(989, 527)
        Me.Controls.Add(Me.ForgetMP)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.LabEnterP)
        Me.Controls.Add(Me.SavePdf)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.OpenPdf)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Encrypt-PDF"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabEnterP As Label
    Friend WithEvents SavePdf As Button
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents OpenPdf As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDF
    Friend WithEvents ForgetMP As Button
End Class
