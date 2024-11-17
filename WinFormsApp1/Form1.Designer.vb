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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.RoyalBlue
        TextBox1.Location = New Point(156, 148)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 55)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.RoyalBlue
        TextBox2.Location = New Point(156, 230)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 55)
        TextBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.RoyalBlue
        Button1.Location = New Point(544, 161)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 100)
        Button1.TabIndex = 2
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.RoyalBlue
        Button2.Location = New Point(665, 161)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 100)
        Button2.TabIndex = 3
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.RoyalBlue
        Button3.Location = New Point(544, 276)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 100)
        Button3.TabIndex = 4
        Button3.Text = "x"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.RoyalBlue
        Button4.Location = New Point(665, 276)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 100)
        Button4.TabIndex = 5
        Button4.Text = ":"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.RoyalBlue
        Button5.Location = New Point(422, 161)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 100)
        Button5.TabIndex = 6
        Button5.Text = "C"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(27, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 56)
        Label1.TabIndex = 7
        Label1.Text = "Nilai A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(29, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 56)
        Label2.TabIndex = 8
        Label2.Text = "Nilai B"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(156, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(540, 70)
        Label3.TabIndex = 9
        Label3.Text = "KALKULATOR SEDERHANA"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(98, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(305, 56)
        Label4.TabIndex = 10
        Label4.Text = "Hasil Perhitungan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(205, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(413, 50)
        Label5.TabIndex = 11
        Label5.Text = "Diaz Adriansyah 1 AEC - 4 A"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(205, 120)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 70)
        Label6.TabIndex = 12
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Kalkulator Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
