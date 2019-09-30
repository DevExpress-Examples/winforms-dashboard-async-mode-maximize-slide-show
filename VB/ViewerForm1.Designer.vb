Namespace MaximizeSlideShow
	Partial Public Class ViewerForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.dashboardViewer1)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Controls.Add(Me.simpleButton2)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(974, 473, 650, 400)
			Me.layoutControl1.Root = Me.Root
			Me.layoutControl1.Size = New System.Drawing.Size(798, 568)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
			Me.dashboardViewer1.Appearance.Options.UseBackColor = True
			Me.dashboardViewer1.AsyncMode = True
			Me.dashboardViewer1.DashboardSource = GetType(MaximizeSlideShow.SampleDashboard)
			Me.dashboardViewer1.Location = New System.Drawing.Point(12, 38)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.Size = New System.Drawing.Size(774, 518)
			Me.dashboardViewer1.TabIndex = 5
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 12)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(416, 22)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Start slide show"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnStartClick);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(432, 12)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(354, 22)
			Me.simpleButton2.StyleController = Me.layoutControl1
			Me.simpleButton2.TabIndex = 6
			Me.simpleButton2.Text = "Stop slide show"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton2.Click += new System.EventHandler(this.OnStopClick);
			' 
			' Root
			' 
			Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.Root.GroupBordersVisible = False
			Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem2})
			Me.Root.Name = "Root"
			Me.Root.Size = New System.Drawing.Size(798, 568)
			Me.Root.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.simpleButton1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(420, 26)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.simpleButton2
			Me.layoutControlItem3.Location = New System.Drawing.Point(420, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(358, 26)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.dashboardViewer1
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 26)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1
			Me.layoutControlItem2.Size = New System.Drawing.Size(778, 522)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' ViewerForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(798, 568)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "ViewerForm1"
			Me.Text = "Dashboard Viewer"
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private Root As DevExpress.XtraLayout.LayoutControlGroup
		Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

