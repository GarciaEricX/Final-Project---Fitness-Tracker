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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstHR = New System.Windows.Forms.ListBox()
        Me.Grp = New System.Windows.Forms.GroupBox()
        Me.radRun = New System.Windows.Forms.RadioButton()
        Me.radJog = New System.Windows.Forms.RadioButton()
        Me.radWalk = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtHR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHR = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Grp.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnCalc.Enabled = False
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalc.Location = New System.Drawing.Point(537, 438)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(115, 55)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Location = New System.Drawing.Point(28, 439)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 55)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.Location = New System.Drawing.Point(340, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lstHR)
        Me.Panel1.Controls.Add(Me.Grp)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtHR)
        Me.Panel1.Location = New System.Drawing.Point(28, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 313)
        Me.Panel1.TabIndex = 3
        '
        'lstHR
        '
        Me.lstHR.BackColor = System.Drawing.Color.DimGray
        Me.lstHR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstHR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHR.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lstHR.FormattingEnabled = True
        Me.lstHR.ItemHeight = 27
        Me.lstHR.Location = New System.Drawing.Point(222, 172)
        Me.lstHR.Name = "lstHR"
        Me.lstHR.Size = New System.Drawing.Size(120, 108)
        Me.lstHR.TabIndex = 0
        '
        'Grp
        '
        Me.Grp.Controls.Add(Me.radRun)
        Me.Grp.Controls.Add(Me.radJog)
        Me.Grp.Controls.Add(Me.radWalk)
        Me.Grp.Location = New System.Drawing.Point(81, 67)
        Me.Grp.Name = "Grp"
        Me.Grp.Size = New System.Drawing.Size(200, 100)
        Me.Grp.TabIndex = 11
        Me.Grp.TabStop = False
        '
        'radRun
        '
        Me.radRun.AutoSize = True
        Me.radRun.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRun.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.radRun.Location = New System.Drawing.Point(10, 65)
        Me.radRun.Name = "radRun"
        Me.radRun.Size = New System.Drawing.Size(103, 28)
        Me.radRun.TabIndex = 2
        Me.radRun.TabStop = True
        Me.radRun.Text = "Running"
        Me.radRun.UseVisualStyleBackColor = True
        '
        'radJog
        '
        Me.radJog.AutoSize = True
        Me.radJog.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJog.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.radJog.Location = New System.Drawing.Point(10, 41)
        Me.radJog.Name = "radJog"
        Me.radJog.Size = New System.Drawing.Size(99, 28)
        Me.radJog.TabIndex = 1
        Me.radJog.TabStop = True
        Me.radJog.Text = "Jogging"
        Me.radJog.UseVisualStyleBackColor = True
        '
        'radWalk
        '
        Me.radWalk.AutoSize = True
        Me.radWalk.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWalk.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.radWalk.Location = New System.Drawing.Point(10, 16)
        Me.radWalk.Name = "radWalk"
        Me.radWalk.Size = New System.Drawing.Size(101, 28)
        Me.radWalk.TabIndex = 0
        Me.radWalk.TabStop = True
        Me.radWalk.Text = "Walking"
        Me.radWalk.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Location = New System.Drawing.Point(3, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(203, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Press 'Add' to append the value"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(3, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Enter recorded heart rate values"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(21, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(302, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Please select a workout intensity"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnAdd.Location = New System.Drawing.Point(282, 280)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 32)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtHR
        '
        Me.txtHR.Location = New System.Drawing.Point(223, 281)
        Me.txtHR.Multiline = True
        Me.txtHR.Name = "txtHR"
        Me.txtHR.Size = New System.Drawing.Size(54, 31)
        Me.txtHR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(168, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Input"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblCalories)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblHR)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(420, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 313)
        Me.Panel2.TabIndex = 4
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalories.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCalories.Location = New System.Drawing.Point(137, 226)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(88, 44)
        Me.lblCalories.TabIndex = 4
        Me.lblCalories.Text = "XXX"
        Me.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCalories.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(39, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 27)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Estimated Calories Burned:"
        '
        'lblHR
        '
        Me.lblHR.AutoSize = True
        Me.lblHR.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHR.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblHR.Location = New System.Drawing.Point(103, 81)
        Me.lblHR.Name = "lblHR"
        Me.lblHR.Size = New System.Drawing.Size(88, 44)
        Me.lblHR.TabIndex = 2
        Me.lblHR.Text = "XXX"
        Me.lblHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHR.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(72, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Average Heart Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(560, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Output"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(253, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fitness Tracker App"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(382, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ">"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.btnPrint.Location = New System.Drawing.Point(658, 438)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 55)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 507)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Fitness Tracker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Grp.ResumeLayout(False)
        Me.Grp.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lstHR As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHR As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtHR As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Grp As GroupBox
    Friend WithEvents radRun As RadioButton
    Friend WithEvents radJog As RadioButton
    Friend WithEvents radWalk As RadioButton
    Friend WithEvents btnPrint As Button
End Class
