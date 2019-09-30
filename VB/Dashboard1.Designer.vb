Namespace MaximizeSlideShow
	Partial Public Class SampleDashboard
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

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim valueMap1 As New DevExpress.DashboardCommon.ValueMap()
			Dim uniformScale1 As New DevExpress.DashboardCommon.UniformScale()
			Dim deltaMap1 As New DevExpress.DashboardCommon.DeltaMap()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SampleDashboard))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure4 As New DevExpress.DashboardCommon.Measure()
			Dim measure5 As New DevExpress.DashboardCommon.Measure()
			Dim gridDeltaColumn1 As New DevExpress.DashboardCommon.GridDeltaColumn()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure6 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim measure7 As New DevExpress.DashboardCommon.Measure()
			Dim measure8 As New DevExpress.DashboardCommon.Measure()
			Dim card1 As New DevExpress.DashboardCommon.Card()
			Dim cardStretchedLayoutTemplate1 As New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
			Dim measure9 As New DevExpress.DashboardCommon.Measure()
			Dim measure10 As New DevExpress.DashboardCommon.Measure()
			Dim card2 As New DevExpress.DashboardCommon.Card()
			Dim cardStretchedLayoutTemplate2 As New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
			Dim measure11 As New DevExpress.DashboardCommon.Measure()
			Dim measure12 As New DevExpress.DashboardCommon.Measure()
			Dim card3 As New DevExpress.DashboardCommon.Card()
			Dim cardStretchedLayoutTemplate3 As New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutGroup3 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem4 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.choroplethMapDashboardItem1 = New DevExpress.DashboardCommon.ChoroplethMapDashboardItem()
			Me.dashboardExcelDataSource1 = New DevExpress.DashboardCommon.DashboardExcelDataSource()
			Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
			DirectCast(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure5, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure6, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure7, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure8, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure9, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure10, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure11, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure12, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' choroplethMapDashboardItem1
			' 
			Me.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA
			dimension1.DataMember = "State"
			Me.choroplethMapDashboardItem1.AttributeDimension = dimension1
			Me.choroplethMapDashboardItem1.AttributeName = "NAME"
			Me.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1"
			measure1.DataMember = "RevenueYTD (Sum)"
			measure2.DataMember = "RevenueYTD (Sum)"
			measure3.DataMember = "RevenueYTDTarget (Sum)"
			Me.choroplethMapDashboardItem1.DataItemRepository.Clear()
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
			Me.choroplethMapDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			valueMap1.Name = "Revenue YTD"
			valueMap1.Scale = uniformScale1
			valueMap1.ValueName = "Revenue"
			valueMap1.AddDataItem("Value", measure1)
			deltaMap1.ActualValueName = "Revenue"
			deltaMap1.DeltaName = "vs Target"
			deltaMap1.Name = "Revenue YTD vs Target"
			deltaMap1.AddDataItem("ActualValue", measure2)
			deltaMap1.AddDataItem("TargetValue", measure3)
			Me.choroplethMapDashboardItem1.Maps.AddRange(New DevExpress.DashboardCommon.ChoroplethMap() { valueMap1, deltaMap1})
			Me.choroplethMapDashboardItem1.Name = "Sales by State"
			Me.choroplethMapDashboardItem1.ShapeTitleAttributeName = "ABBREV"
			Me.choroplethMapDashboardItem1.ShowCaption = True
			Me.choroplethMapDashboardItem1.Viewport.BottomLatitude = 22.722765208057595R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 37.208247632673633R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -95.848499902568008R
			Me.choroplethMapDashboardItem1.Viewport.LeftLongitude = -124.70997774915153R
			Me.choroplethMapDashboardItem1.Viewport.RightLongitude = -66.987022055984482R
			Me.choroplethMapDashboardItem1.Viewport.TopLatitude = 49.369672064487254R
			' 
			' dashboardExcelDataSource1
			' 
			Me.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1"
			Me.dashboardExcelDataSource1.FileName = "|DataDirectory|\Data\Sales.xlsx"
			Me.dashboardExcelDataSource1.Name = "Excel Data Source 1"
			Me.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "Category"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Product"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "State"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "UnitsSoldYTD (Sum)"
			fieldInfo4.Type = GetType(Double)
			fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)"
			fieldInfo5.Type = GetType(Double)
			fieldInfo6.Name = "RevenueQTD (Sum)"
			fieldInfo6.Type = GetType(Double)
			fieldInfo7.Name = "RevenueQTDTarget (Sum)"
			fieldInfo7.Type = GetType(Double)
			fieldInfo8.Name = "RevenueYTD (Sum)"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "RevenueYTDTarget (Sum)"
			fieldInfo9.Type = GetType(Double)
			Me.dashboardExcelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Sheet1"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' gridDashboardItem1
			' 
			dimension2.DataMember = "Product"
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension2)
			measure4.DataMember = "UnitsSoldYTD (Sum)"
			measure5.DataMember = "UnitsSoldYTDTarget (Sum)"
			gridDeltaColumn1.Name = "UnitsSold YTD vs Target"
			gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDeltaColumn1.AddDataItem("ActualValue", measure4)
			gridDeltaColumn1.AddDataItem("TargetValue", measure5)
			Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridDeltaColumn1})
			Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
			Me.gridDashboardItem1.DataItemRepository.Clear()
			Me.gridDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.gridDashboardItem1.DataItemRepository.Add(measure4, "DataItem1")
			Me.gridDashboardItem1.DataItemRepository.Add(measure5, "DataItem2")
			Me.gridDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridDashboardItem1.Name = "Product Units Sold"
			Me.gridDashboardItem1.ShowCaption = True
			' 
			' chartDashboardItem1
			' 
			dimension3.DataMember = "Category"
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure6.DataMember = "UnitsSoldYTD (Sum)"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(measure6, "DataItem1")
			Me.chartDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = "Chart 1"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.AddDataItem("Value", measure6)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.Rotated = True
			Me.chartDashboardItem1.ShowCaption = True
			' 
			' cardDashboardItem1
			' 
			measure7.DataMember = "RevenueQTD (Sum)"
			measure8.DataMember = "RevenueQTDTarget (Sum)"
			cardStretchedLayoutTemplate1.BottomValue1.DimensionIndex = 0
			cardStretchedLayoutTemplate1.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
			cardStretchedLayoutTemplate1.BottomValue1.Visible = True
			cardStretchedLayoutTemplate1.BottomValue2.DimensionIndex = 0
			cardStretchedLayoutTemplate1.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
			cardStretchedLayoutTemplate1.BottomValue2.Visible = True
			cardStretchedLayoutTemplate1.DeltaIndicator.Visible = True
			cardStretchedLayoutTemplate1.MainValue.DimensionIndex = 0
			cardStretchedLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
			cardStretchedLayoutTemplate1.MainValue.Visible = True
			cardStretchedLayoutTemplate1.Sparkline.Visible = True
			cardStretchedLayoutTemplate1.SubValue.DimensionIndex = 0
			cardStretchedLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
			cardStretchedLayoutTemplate1.SubValue.Visible = True
			cardStretchedLayoutTemplate1.TopValue.DimensionIndex = 0
			cardStretchedLayoutTemplate1.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
			cardStretchedLayoutTemplate1.TopValue.Visible = True
			card1.LayoutTemplate = cardStretchedLayoutTemplate1
			card1.AddDataItem("ActualValue", measure7)
			card1.AddDataItem("TargetValue", measure8)
			measure9.DataMember = "RevenueYTD (Sum)"
			measure10.DataMember = "RevenueYTDTarget (Sum)"
			cardStretchedLayoutTemplate2.BottomValue1.DimensionIndex = 0
			cardStretchedLayoutTemplate2.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
			cardStretchedLayoutTemplate2.BottomValue1.Visible = True
			cardStretchedLayoutTemplate2.BottomValue2.DimensionIndex = 0
			cardStretchedLayoutTemplate2.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
			cardStretchedLayoutTemplate2.BottomValue2.Visible = True
			cardStretchedLayoutTemplate2.DeltaIndicator.Visible = True
			cardStretchedLayoutTemplate2.MainValue.DimensionIndex = 0
			cardStretchedLayoutTemplate2.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
			cardStretchedLayoutTemplate2.MainValue.Visible = True
			cardStretchedLayoutTemplate2.Sparkline.Visible = True
			cardStretchedLayoutTemplate2.SubValue.DimensionIndex = 0
			cardStretchedLayoutTemplate2.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
			cardStretchedLayoutTemplate2.SubValue.Visible = True
			cardStretchedLayoutTemplate2.TopValue.DimensionIndex = 0
			cardStretchedLayoutTemplate2.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
			cardStretchedLayoutTemplate2.TopValue.Visible = True
			card2.LayoutTemplate = cardStretchedLayoutTemplate2
			card2.AddDataItem("ActualValue", measure9)
			card2.AddDataItem("TargetValue", measure10)
			measure11.DataMember = "UnitsSoldYTD (Sum)"
			measure12.DataMember = "UnitsSoldYTDTarget (Sum)"
			cardStretchedLayoutTemplate3.BottomValue1.DimensionIndex = 0
			cardStretchedLayoutTemplate3.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
			cardStretchedLayoutTemplate3.BottomValue1.Visible = True
			cardStretchedLayoutTemplate3.BottomValue2.DimensionIndex = 0
			cardStretchedLayoutTemplate3.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
			cardStretchedLayoutTemplate3.BottomValue2.Visible = True
			cardStretchedLayoutTemplate3.DeltaIndicator.Visible = True
			cardStretchedLayoutTemplate3.MainValue.DimensionIndex = 0
			cardStretchedLayoutTemplate3.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
			cardStretchedLayoutTemplate3.MainValue.Visible = True
			cardStretchedLayoutTemplate3.Sparkline.Visible = True
			cardStretchedLayoutTemplate3.SubValue.DimensionIndex = 0
			cardStretchedLayoutTemplate3.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
			cardStretchedLayoutTemplate3.SubValue.Visible = True
			cardStretchedLayoutTemplate3.TopValue.DimensionIndex = 0
			cardStretchedLayoutTemplate3.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
			cardStretchedLayoutTemplate3.TopValue.Visible = True
			card3.LayoutTemplate = cardStretchedLayoutTemplate3
			card3.AddDataItem("ActualValue", measure11)
			card3.AddDataItem("TargetValue", measure12)
			Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1, card2, card3})
			Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
			Me.cardDashboardItem1.DataItemRepository.Clear()
			Me.cardDashboardItem1.DataItemRepository.Add(measure7, "DataItem0")
			Me.cardDashboardItem1.DataItemRepository.Add(measure8, "DataItem1")
			Me.cardDashboardItem1.DataItemRepository.Add(measure9, "DataItem2")
			Me.cardDashboardItem1.DataItemRepository.Add(measure10, "DataItem3")
			Me.cardDashboardItem1.DataItemRepository.Add(measure11, "DataItem4")
			Me.cardDashboardItem1.DataItemRepository.Add(measure12, "DataItem5")
			Me.cardDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.cardDashboardItem1.Name = "Cards 1"
			Me.cardDashboardItem1.ShowCaption = False
			' 
			' SampleDashboard
			' 
			Me.CurrencyCultureName = Nothing
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExcelDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.choroplethMapDashboardItem1, Me.gridDashboardItem1, Me.chartDashboardItem1, Me.cardDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.choroplethMapDashboardItem1
			dashboardLayoutItem1.Weight = 73.395721925133685R
			dashboardLayoutItem2.DashboardItem = Me.cardDashboardItem1
			dashboardLayoutItem2.Weight = 26.604278074866311R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 62.684365781710916R
			dashboardLayoutItem3.DashboardItem = Me.gridDashboardItem1
			dashboardLayoutItem3.Weight = 48.1283422459893R
			dashboardLayoutItem4.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem4.Weight = 51.8716577540107R
			dashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem3, dashboardLayoutItem4})
			dashboardLayoutGroup3.DashboardItem = Nothing
			dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup3.Weight = 37.315634218289084R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutGroup3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sample Dashboard"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure5, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure6, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure7, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure8, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure9, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure10, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure11, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure12, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private choroplethMapDashboardItem1 As DevExpress.DashboardCommon.ChoroplethMapDashboardItem
		Private dashboardExcelDataSource1 As DevExpress.DashboardCommon.DashboardExcelDataSource
		Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
	End Class
End Namespace
