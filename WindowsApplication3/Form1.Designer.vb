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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.CourseID = New System.Windows.Forms.TextBox()
        Me.sendRequestButton = New System.Windows.Forms.Button()
        Me.Rank1Mii = New System.Windows.Forms.PictureBox()
        Me.Rank2Mii = New System.Windows.Forms.PictureBox()
        Me.Rank3Mii = New System.Windows.Forms.PictureBox()
        Me.Rank4Mii = New System.Windows.Forms.PictureBox()
        Me.Rank5Mii = New System.Windows.Forms.PictureBox()
        Me.Rank6Mii = New System.Windows.Forms.PictureBox()
        Me.Rank1Name = New System.Windows.Forms.Label()
        Me.Rank1Time = New System.Windows.Forms.Label()
        Me.Rank2Time = New System.Windows.Forms.Label()
        Me.Rank2Name = New System.Windows.Forms.Label()
        Me.Rank3Time = New System.Windows.Forms.Label()
        Me.Rank3Name = New System.Windows.Forms.Label()
        Me.Rank4Time = New System.Windows.Forms.Label()
        Me.Rank4Name = New System.Windows.Forms.Label()
        Me.Rank5Time = New System.Windows.Forms.Label()
        Me.Rank5Name = New System.Windows.Forms.Label()
        Me.Rank6Time = New System.Windows.Forms.Label()
        Me.Rank6Name = New System.Windows.Forms.Label()
        Me.ScoreChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Track = New System.Windows.Forms.Label()
        CType(Me.Rank1Mii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank2Mii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank3Mii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank4Mii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank5Mii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank6Mii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoreChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourseID
        '
        Me.CourseID.Location = New System.Drawing.Point(296, 14)
        Me.CourseID.Name = "CourseID"
        Me.CourseID.Size = New System.Drawing.Size(100, 20)
        Me.CourseID.TabIndex = 0
        '
        'sendRequestButton
        '
        Me.sendRequestButton.Location = New System.Drawing.Point(402, 12)
        Me.sendRequestButton.Name = "sendRequestButton"
        Me.sendRequestButton.Size = New System.Drawing.Size(99, 23)
        Me.sendRequestButton.TabIndex = 1
        Me.sendRequestButton.Text = "Send Request"
        Me.sendRequestButton.UseVisualStyleBackColor = True
        '
        'Rank1Mii
        '
        Me.Rank1Mii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rank1Mii.Location = New System.Drawing.Point(402, 164)
        Me.Rank1Mii.Name = "Rank1Mii"
        Me.Rank1Mii.Size = New System.Drawing.Size(55, 50)
        Me.Rank1Mii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rank1Mii.TabIndex = 2
        Me.Rank1Mii.TabStop = False
        '
        'Rank2Mii
        '
        Me.Rank2Mii.Location = New System.Drawing.Point(402, 220)
        Me.Rank2Mii.Name = "Rank2Mii"
        Me.Rank2Mii.Size = New System.Drawing.Size(55, 50)
        Me.Rank2Mii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rank2Mii.TabIndex = 3
        Me.Rank2Mii.TabStop = False
        '
        'Rank3Mii
        '
        Me.Rank3Mii.Location = New System.Drawing.Point(402, 276)
        Me.Rank3Mii.Name = "Rank3Mii"
        Me.Rank3Mii.Size = New System.Drawing.Size(55, 50)
        Me.Rank3Mii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rank3Mii.TabIndex = 4
        Me.Rank3Mii.TabStop = False
        '
        'Rank4Mii
        '
        Me.Rank4Mii.Location = New System.Drawing.Point(402, 332)
        Me.Rank4Mii.Name = "Rank4Mii"
        Me.Rank4Mii.Size = New System.Drawing.Size(55, 50)
        Me.Rank4Mii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rank4Mii.TabIndex = 5
        Me.Rank4Mii.TabStop = False
        '
        'Rank5Mii
        '
        Me.Rank5Mii.Location = New System.Drawing.Point(402, 388)
        Me.Rank5Mii.Name = "Rank5Mii"
        Me.Rank5Mii.Size = New System.Drawing.Size(55, 50)
        Me.Rank5Mii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rank5Mii.TabIndex = 6
        Me.Rank5Mii.TabStop = False
        '
        'Rank6Mii
        '
        Me.Rank6Mii.Location = New System.Drawing.Point(402, 444)
        Me.Rank6Mii.Name = "Rank6Mii"
        Me.Rank6Mii.Size = New System.Drawing.Size(55, 50)
        Me.Rank6Mii.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rank6Mii.TabIndex = 7
        Me.Rank6Mii.TabStop = False
        '
        'Rank1Name
        '
        Me.Rank1Name.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank1Name.Location = New System.Drawing.Point(463, 164)
        Me.Rank1Name.Name = "Rank1Name"
        Me.Rank1Name.Size = New System.Drawing.Size(200, 50)
        Me.Rank1Name.TabIndex = 8
        Me.Rank1Name.Text = "TopRankName"
        Me.Rank1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank1Time
        '
        Me.Rank1Time.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank1Time.Location = New System.Drawing.Point(669, 164)
        Me.Rank1Time.Name = "Rank1Time"
        Me.Rank1Time.Size = New System.Drawing.Size(153, 50)
        Me.Rank1Time.TabIndex = 9
        Me.Rank1Time.Text = "TopRankTime"
        Me.Rank1Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank2Time
        '
        Me.Rank2Time.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank2Time.Location = New System.Drawing.Point(669, 220)
        Me.Rank2Time.Name = "Rank2Time"
        Me.Rank2Time.Size = New System.Drawing.Size(153, 50)
        Me.Rank2Time.TabIndex = 11
        Me.Rank2Time.Text = "TopRankTime"
        Me.Rank2Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank2Name
        '
        Me.Rank2Name.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank2Name.Location = New System.Drawing.Point(463, 220)
        Me.Rank2Name.Name = "Rank2Name"
        Me.Rank2Name.Size = New System.Drawing.Size(200, 50)
        Me.Rank2Name.TabIndex = 10
        Me.Rank2Name.Text = "TopRankName"
        Me.Rank2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank3Time
        '
        Me.Rank3Time.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank3Time.Location = New System.Drawing.Point(669, 276)
        Me.Rank3Time.Name = "Rank3Time"
        Me.Rank3Time.Size = New System.Drawing.Size(153, 50)
        Me.Rank3Time.TabIndex = 13
        Me.Rank3Time.Text = "TopRankTime"
        Me.Rank3Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank3Name
        '
        Me.Rank3Name.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank3Name.Location = New System.Drawing.Point(463, 276)
        Me.Rank3Name.Name = "Rank3Name"
        Me.Rank3Name.Size = New System.Drawing.Size(200, 50)
        Me.Rank3Name.TabIndex = 12
        Me.Rank3Name.Text = "TopRankName"
        Me.Rank3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank4Time
        '
        Me.Rank4Time.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank4Time.Location = New System.Drawing.Point(669, 332)
        Me.Rank4Time.Name = "Rank4Time"
        Me.Rank4Time.Size = New System.Drawing.Size(153, 50)
        Me.Rank4Time.TabIndex = 15
        Me.Rank4Time.Text = "TopRankTime"
        Me.Rank4Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank4Name
        '
        Me.Rank4Name.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank4Name.Location = New System.Drawing.Point(463, 332)
        Me.Rank4Name.Name = "Rank4Name"
        Me.Rank4Name.Size = New System.Drawing.Size(200, 50)
        Me.Rank4Name.TabIndex = 14
        Me.Rank4Name.Text = "TopRankName"
        Me.Rank4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank5Time
        '
        Me.Rank5Time.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank5Time.Location = New System.Drawing.Point(669, 388)
        Me.Rank5Time.Name = "Rank5Time"
        Me.Rank5Time.Size = New System.Drawing.Size(153, 50)
        Me.Rank5Time.TabIndex = 17
        Me.Rank5Time.Text = "TopRankTime"
        Me.Rank5Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank5Name
        '
        Me.Rank5Name.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank5Name.Location = New System.Drawing.Point(463, 388)
        Me.Rank5Name.Name = "Rank5Name"
        Me.Rank5Name.Size = New System.Drawing.Size(200, 50)
        Me.Rank5Name.TabIndex = 16
        Me.Rank5Name.Text = "TopRankName"
        Me.Rank5Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank6Time
        '
        Me.Rank6Time.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank6Time.Location = New System.Drawing.Point(669, 444)
        Me.Rank6Time.Name = "Rank6Time"
        Me.Rank6Time.Size = New System.Drawing.Size(153, 50)
        Me.Rank6Time.TabIndex = 19
        Me.Rank6Time.Text = "TopRankTime"
        Me.Rank6Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Rank6Name
        '
        Me.Rank6Name.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rank6Name.Location = New System.Drawing.Point(463, 444)
        Me.Rank6Name.Name = "Rank6Name"
        Me.Rank6Name.Size = New System.Drawing.Size(200, 50)
        Me.Rank6Name.TabIndex = 18
        Me.Rank6Name.Text = "TopRankName"
        Me.Rank6Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoreChart
        '
        Me.ScoreChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.IsClustered = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.Rotation = 25
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisY.LabelStyle.Enabled = False
        ChartArea1.Name = "ChartArea1"
        Me.ScoreChart.ChartAreas.Add(ChartArea1)
        Me.ScoreChart.Location = New System.Drawing.Point(12, 164)
        Me.ScoreChart.Name = "ScoreChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series1.Name = "Series1"
        Me.ScoreChart.Series.Add(Series1)
        Me.ScoreChart.Size = New System.Drawing.Size(384, 330)
        Me.ScoreChart.TabIndex = 20
        Me.ScoreChart.Text = "Chart1"
        '
        'Track
        '
        Me.Track.Font = New System.Drawing.Font("Segoe Print", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Track.Location = New System.Drawing.Point(12, 38)
        Me.Track.Name = "Track"
        Me.Track.Size = New System.Drawing.Size(810, 123)
        Me.Track.TabIndex = 22
        Me.Track.Text = "Track"
        Me.Track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 522)
        Me.Controls.Add(Me.Track)
        Me.Controls.Add(Me.ScoreChart)
        Me.Controls.Add(Me.Rank6Time)
        Me.Controls.Add(Me.Rank6Name)
        Me.Controls.Add(Me.Rank5Time)
        Me.Controls.Add(Me.Rank5Name)
        Me.Controls.Add(Me.Rank4Time)
        Me.Controls.Add(Me.Rank4Name)
        Me.Controls.Add(Me.Rank3Time)
        Me.Controls.Add(Me.Rank3Name)
        Me.Controls.Add(Me.Rank2Time)
        Me.Controls.Add(Me.Rank2Name)
        Me.Controls.Add(Me.Rank1Time)
        Me.Controls.Add(Me.Rank1Name)
        Me.Controls.Add(Me.Rank6Mii)
        Me.Controls.Add(Me.Rank5Mii)
        Me.Controls.Add(Me.Rank4Mii)
        Me.Controls.Add(Me.Rank3Mii)
        Me.Controls.Add(Me.Rank2Mii)
        Me.Controls.Add(Me.Rank1Mii)
        Me.Controls.Add(Me.sendRequestButton)
        Me.Controls.Add(Me.CourseID)
        Me.Name = "Form1"
        Me.Text = "Time Trial Viewer"
        CType(Me.Rank1Mii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank2Mii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank3Mii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank4Mii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank5Mii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank6Mii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoreChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CourseID As System.Windows.Forms.TextBox
    Friend WithEvents sendRequestButton As System.Windows.Forms.Button
    Friend WithEvents Rank1Mii As System.Windows.Forms.PictureBox
    Friend WithEvents Rank2Mii As System.Windows.Forms.PictureBox
    Friend WithEvents Rank3Mii As System.Windows.Forms.PictureBox
    Friend WithEvents Rank4Mii As System.Windows.Forms.PictureBox
    Friend WithEvents Rank5Mii As System.Windows.Forms.PictureBox
    Friend WithEvents Rank6Mii As System.Windows.Forms.PictureBox
    Friend WithEvents Rank1Name As System.Windows.Forms.Label
    Friend WithEvents Rank1Time As System.Windows.Forms.Label
    Friend WithEvents Rank2Time As System.Windows.Forms.Label
    Friend WithEvents Rank2Name As System.Windows.Forms.Label
    Friend WithEvents Rank3Time As System.Windows.Forms.Label
    Friend WithEvents Rank3Name As System.Windows.Forms.Label
    Friend WithEvents Rank4Time As System.Windows.Forms.Label
    Friend WithEvents Rank4Name As System.Windows.Forms.Label
    Friend WithEvents Rank5Time As System.Windows.Forms.Label
    Friend WithEvents Rank5Name As System.Windows.Forms.Label
    Friend WithEvents Rank6Time As System.Windows.Forms.Label
    Friend WithEvents Rank6Name As System.Windows.Forms.Label
    Friend WithEvents ScoreChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Track As System.Windows.Forms.Label

End Class
