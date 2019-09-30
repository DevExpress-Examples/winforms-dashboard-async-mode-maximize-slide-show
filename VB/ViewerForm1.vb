Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace MaximizeSlideShow
	Partial Public Class ViewerForm1
		Inherits XtraForm

		Private isSlideShown As Boolean = False
		Private index As Integer = 0
		Private slideShowTimer As New Timer() With {.Interval = 5000}

		Public Sub New()
			InitializeComponent()
			AddHandler slideShowTimer.Tick, AddressOf OnSlideShowTimerTick
		End Sub

		Private Async Sub OnSlideShowTimerTick(ByVal sender As Object, ByVal e As EventArgs)
			Dim items = dashboardViewer1.Dashboard.Items
			Dim maxIndex As Integer = items.Count - 1

			If Not isSlideShown Then
				slideShowTimer.Stop()
				Return
			End If
			Await dashboardViewer1.MaximizeDashboardItemAsync(items(index).ComponentName)
			If index = maxIndex Then
				index = 0
			Else
				index += 1
			End If
		End Sub

		Private Sub OnStartClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles simpleButton1.MouseClick
			If Not isSlideShown Then
				isSlideShown = True
				slideShowTimer.Start()
			End If
		End Sub
		Private Async Sub OnStopClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			isSlideShown = False
			Await dashboardViewer1.RestoreDashboardItemAsync()
		End Sub
	End Class
End Namespace