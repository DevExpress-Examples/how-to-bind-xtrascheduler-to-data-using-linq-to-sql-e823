'TODO: INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System.Data.Linq
	Imports System.Data.Linq.Mapping
	Imports System.Data
	Imports System.Collections.Generic
	Imports System.Reflection
	Imports System.Linq
	Imports System.Linq.Expressions
	Imports System.ComponentModel
	Imports System
Namespace XtraScheduler_linq


	<System.Data.Linq.Mapping.DatabaseAttribute(Name:="XtraCars")> _
	Partial Public Class LINQDataContext
		Inherits System.Data.Linq.DataContext

		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub InsertDBAppointment(ByVal instance As DBAppointment)
	End Sub
	Partial Private Sub UpdateDBAppointment(ByVal instance As DBAppointment)
	End Sub
	Partial Private Sub DeleteDBAppointment(ByVal instance As DBAppointment)
	End Sub
	#End Region

		Public Sub New()
			MyBase.New(My.Settings.Default.XtraCarsConnectionString, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public ReadOnly Property DBResources() As System.Data.Linq.Table(Of DBResource)
			Get
				Return Me.GetTable(Of DBResource)()
			End Get
		End Property

		Public ReadOnly Property DBAppointments() As System.Data.Linq.Table(Of DBAppointment)
			Get
				Return Me.GetTable(Of DBAppointment)()
			End Get
		End Property
	End Class

	<Table(Name:="dbo.Cars")> _
	Partial Public Class DBResource

		Private _ID As Integer

		Private _Trademark As String

		Private _Model As String

		Private _HP As System.Nullable(Of Short)

		Private _Liter As System.Nullable(Of Double)

		Private _Cyl As System.Nullable(Of Byte)

		Private _TransmissSpeedCount As System.Nullable(Of Byte)

		Private _TransmissAutomatic As String

		Private _MPG_City As System.Nullable(Of Byte)

		Private _MPG_Highway As System.Nullable(Of Byte)

		Private _Category As String

		Private _Description As String

		Private _Hyperlink As String

		Private _Picture() As Byte

		Private _Price As System.Nullable(Of Decimal)

		Private _RtfContent As String

		Public Sub New()
		End Sub

		<Column(Storage:="_ID", DbType:="Int NOT NULL")> _
		Public Property ID() As Integer
			Get
				Return Me._ID
			End Get
			Set(ByVal value As Integer)
				If (Me._ID <> value) Then
					Me._ID = value
				End If
			End Set
		End Property

		<Column(Storage:="_Trademark", DbType:="NVarChar(50)")> _
		Public Property Trademark() As String
			Get
				Return Me._Trademark
			End Get
			Set(ByVal value As String)
				If (Me._Trademark <> value) Then
					Me._Trademark = value
				End If
			End Set
		End Property

		<Column(Storage:="_Model", DbType:="NVarChar(50)")> _
		Public Property Model() As String
			Get
				Return Me._Model
			End Get
			Set(ByVal value As String)
				If (Me._Model <> value) Then
					Me._Model = value
				End If
			End Set
		End Property

		<Column(Storage:="_HP", DbType:="SmallInt")> _
		Public Property HP() As System.Nullable(Of Short)
			Get
				Return Me._HP
			End Get
			Set(ByVal value As System.Nullable(Of Short))
				If (Not Me._HP.Equals(value)) Then
					Me._HP = value
				End If
			End Set
		End Property

		<Column(Storage:="_Liter", DbType:="Float")> _
		Public Property Liter() As System.Nullable(Of Double)
			Get
				Return Me._Liter
			End Get
			Set(ByVal value As System.Nullable(Of Double))
				If (Not Me._Liter.Equals(value)) Then
					Me._Liter = value
				End If
			End Set
		End Property

		<Column(Storage:="_Cyl", DbType:="TinyInt")> _
		Public Property Cyl() As System.Nullable(Of Byte)
			Get
				Return Me._Cyl
			End Get
			Set(ByVal value As System.Nullable(Of Byte))
				If (Not Me._Cyl.Equals(value)) Then
					Me._Cyl = value
				End If
			End Set
		End Property

		<Column(Storage:="_TransmissSpeedCount", DbType:="TinyInt")> _
		Public Property TransmissSpeedCount() As System.Nullable(Of Byte)
			Get
				Return Me._TransmissSpeedCount
			End Get
			Set(ByVal value As System.Nullable(Of Byte))
				If (Not Me._TransmissSpeedCount.Equals(value)) Then
					Me._TransmissSpeedCount = value
				End If
			End Set
		End Property

		<Column(Storage:="_TransmissAutomatic", DbType:="NVarChar(3)")> _
		Public Property TransmissAutomatic() As String
			Get
				Return Me._TransmissAutomatic
			End Get
			Set(ByVal value As String)
				If (Me._TransmissAutomatic <> value) Then
					Me._TransmissAutomatic = value
				End If
			End Set
		End Property

		<Column(Storage:="_MPG_City", DbType:="TinyInt")> _
		Public Property MPG_City() As System.Nullable(Of Byte)
			Get
				Return Me._MPG_City
			End Get
			Set(ByVal value As System.Nullable(Of Byte))
				If (Not Me._MPG_City.Equals(value)) Then
					Me._MPG_City = value
				End If
			End Set
		End Property

		<Column(Storage:="_MPG_Highway", DbType:="TinyInt")> _
		Public Property MPG_Highway() As System.Nullable(Of Byte)
			Get
				Return Me._MPG_Highway
			End Get
			Set(ByVal value As System.Nullable(Of Byte))
				If (Not Me._MPG_Highway.Equals(value)) Then
					Me._MPG_Highway = value
				End If
			End Set
		End Property

		<Column(Storage:="_Category", DbType:="NVarChar(7)")> _
		Public Property Category() As String
			Get
				Return Me._Category
			End Get
			Set(ByVal value As String)
				If (Me._Category <> value) Then
					Me._Category = value
				End If
			End Set
		End Property

		<Column(Storage:="_Description", DbType:="NVarChar(MAX)")> _
		Public Property Description() As String
			Get
				Return Me._Description
			End Get
			Set(ByVal value As String)
				If (Me._Description <> value) Then
					Me._Description = value
				End If
			End Set
		End Property

		<Column(Storage:="_Hyperlink", DbType:="NVarChar(50)")> _
		Public Property Hyperlink() As String
			Get
				Return Me._Hyperlink
			End Get
			Set(ByVal value As String)
				If (Me._Hyperlink <> value) Then
					Me._Hyperlink = value
				End If
			End Set
		End Property

		<Column(Storage:="_Picture", DbType:="Image", UpdateCheck:=UpdateCheck.Never)> _
		Public Property Picture() As Byte()
			Get
				Return Me._Picture
			End Get
			Set(ByVal value As Byte())
				If (Not Me._Picture.Equals(value)) Then
					Me._Picture = value
				End If
			End Set
		End Property

		<Column(Storage:="_Price", DbType:="Money")> _
		Public Property Price() As System.Nullable(Of Decimal)
			Get
				Return Me._Price
			End Get
			Set(ByVal value As System.Nullable(Of Decimal))
				If (Not Me._Price.Equals(value)) Then
					Me._Price = value
				End If
			End Set
		End Property

		<Column(Storage:="_RtfContent", DbType:="NVarChar(MAX)")> _
		Public Property RtfContent() As String
			Get
				Return Me._RtfContent
			End Get
			Set(ByVal value As String)
				If (Me._RtfContent <> value) Then
					Me._RtfContent = value
				End If
			End Set
		End Property
	End Class

	<Table(Name:="dbo.CarScheduling")> _
	Partial Public Class DBAppointment
		Implements INotifyPropertyChanging, INotifyPropertyChanged

		Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

		Private _ID As Integer

		Private _UserId As System.Nullable(Of Integer)

		Private _Status As System.Nullable(Of Integer)

		Private _Subject As String

		Private _Description As String

		Private _Label As System.Nullable(Of Integer)

		Private _StartTime As System.Nullable(Of System.DateTime)

		Private _EndTime As System.Nullable(Of System.DateTime)

		Private _Location As String

		Private _AllDay As Boolean

		Private _EventType As System.Nullable(Of Integer)

		Private _RecurrenceInfo As String

		Private _ReminderInfo As String

		Private _CarIdShared As String

		Private _Price As System.Nullable(Of Double)

		Private _CarId As System.Nullable(Of Integer)

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnLoaded()
	End Sub
	Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
	End Sub
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub OnIDChanging(ByVal value As Integer)
	End Sub
	Partial Private Sub OnIDChanged()
	End Sub
	Partial Private Sub OnUserIdChanging(ByVal value As System.Nullable(Of Integer))
	End Sub
	Partial Private Sub OnUserIdChanged()
	End Sub
	Partial Private Sub OnStatusChanging(ByVal value As System.Nullable(Of Integer))
	End Sub
	Partial Private Sub OnStatusChanged()
	End Sub
	Partial Private Sub OnSubjectChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnSubjectChanged()
	End Sub
	Partial Private Sub OnDescriptionChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnDescriptionChanged()
	End Sub
	Partial Private Sub OnLabelChanging(ByVal value As System.Nullable(Of Integer))
	End Sub
	Partial Private Sub OnLabelChanged()
	End Sub
	Partial Private Sub OnStartTimeChanging(ByVal value As System.Nullable(Of System.DateTime))
	End Sub
	Partial Private Sub OnStartTimeChanged()
	End Sub
	Partial Private Sub OnEndTimeChanging(ByVal value As System.Nullable(Of System.DateTime))
	End Sub
	Partial Private Sub OnEndTimeChanged()
	End Sub
	Partial Private Sub OnLocationChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnLocationChanged()
	End Sub
	Partial Private Sub OnAllDayChanging(ByVal value As Boolean)
	End Sub
	Partial Private Sub OnAllDayChanged()
	End Sub
	Partial Private Sub OnEventTypeChanging(ByVal value As System.Nullable(Of Integer))
	End Sub
	Partial Private Sub OnEventTypeChanged()
	End Sub
	Partial Private Sub OnRecurrenceInfoChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnRecurrenceInfoChanged()
	End Sub
	Partial Private Sub OnReminderInfoChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnReminderInfoChanged()
	End Sub
	Partial Private Sub OnCarIdSharedChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnCarIdSharedChanged()
	End Sub
	Partial Private Sub OnPriceChanging(ByVal value As System.Nullable(Of Double))
	End Sub
	Partial Private Sub OnPriceChanged()
	End Sub
	Partial Private Sub OnCarIdChanging(ByVal value As System.Nullable(Of Integer))
	End Sub
	Partial Private Sub OnCarIdChanged()
	End Sub
	#End Region

		Public Sub New()
			OnCreated()
		End Sub

		<Column(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)> _
		Public Property ID() As Integer
			Get
				Return Me._ID
			End Get
			Set(ByVal value As Integer)
				If (Me._ID <> value) Then
					Me.OnIDChanging(value)
					Me.SendPropertyChanging()
					Me._ID = value
					Me.SendPropertyChanged("ID")
					Me.OnIDChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_UserId", DbType:="Int")> _
		Public Property UserId() As System.Nullable(Of Integer)
			Get
				Return Me._UserId
			End Get
			Set(ByVal value As System.Nullable(Of Integer))
				If (Not Me._UserId.Equals(value)) Then
					Me.OnUserIdChanging(value)
					Me.SendPropertyChanging()
					Me._UserId = value
					Me.SendPropertyChanged("UserId")
					Me.OnUserIdChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Status", DbType:="Int")> _
		Public Property Status() As System.Nullable(Of Integer)
			Get
				Return Me._Status
			End Get
			Set(ByVal value As System.Nullable(Of Integer))
				If (Not Me._Status.Equals(value)) Then
					Me.OnStatusChanging(value)
					Me.SendPropertyChanging()
					Me._Status = value
					Me.SendPropertyChanged("Status")
					Me.OnStatusChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Subject", DbType:="NVarChar(50)")> _
		Public Property Subject() As String
			Get
				Return Me._Subject
			End Get
			Set(ByVal value As String)
				If (Me._Subject <> value) Then
					Me.OnSubjectChanging(value)
					Me.SendPropertyChanging()
					Me._Subject = value
					Me.SendPropertyChanged("Subject")
					Me.OnSubjectChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Description", DbType:="NVarChar(MAX)")> _
		Public Property Description() As String
			Get
				Return Me._Description
			End Get
			Set(ByVal value As String)
				If (Me._Description <> value) Then
					Me.OnDescriptionChanging(value)
					Me.SendPropertyChanging()
					Me._Description = value
					Me.SendPropertyChanged("Description")
					Me.OnDescriptionChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Label", DbType:="Int")> _
		Public Property Label() As System.Nullable(Of Integer)
			Get
				Return Me._Label
			End Get
			Set(ByVal value As System.Nullable(Of Integer))
				If (Not Me._Label.Equals(value)) Then
					Me.OnLabelChanging(value)
					Me.SendPropertyChanging()
					Me._Label = value
					Me.SendPropertyChanged("Label")
					Me.OnLabelChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_StartTime", DbType:="DateTime")> _
		Public Property StartTime() As System.Nullable(Of System.DateTime)
			Get
				Return Me._StartTime
			End Get
			Set(ByVal value As System.Nullable(Of System.DateTime))
				If (Not Me._StartTime.Equals(value)) Then
					Me.OnStartTimeChanging(value)
					Me.SendPropertyChanging()
					Me._StartTime = value
					Me.SendPropertyChanged("StartTime")
					Me.OnStartTimeChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_EndTime", DbType:="DateTime")> _
		Public Property EndTime() As System.Nullable(Of System.DateTime)
			Get
				Return Me._EndTime
			End Get
			Set(ByVal value As System.Nullable(Of System.DateTime))
				If (Not Me._EndTime.Equals(value)) Then
					Me.OnEndTimeChanging(value)
					Me.SendPropertyChanging()
					Me._EndTime = value
					Me.SendPropertyChanged("EndTime")
					Me.OnEndTimeChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Location", DbType:="NVarChar(50)")> _
		Public Property Location() As String
			Get
				Return Me._Location
			End Get
			Set(ByVal value As String)
				If (Me._Location <> value) Then
					Me.OnLocationChanging(value)
					Me.SendPropertyChanging()
					Me._Location = value
					Me.SendPropertyChanged("Location")
					Me.OnLocationChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_AllDay", DbType:="Bit NOT NULL")> _
		Public Property AllDay() As Boolean
			Get
				Return Me._AllDay
			End Get
			Set(ByVal value As Boolean)
				If (Me._AllDay <> value) Then
					Me.OnAllDayChanging(value)
					Me.SendPropertyChanging()
					Me._AllDay = value
					Me.SendPropertyChanged("AllDay")
					Me.OnAllDayChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_EventType", DbType:="Int")> _
		Public Property EventType() As System.Nullable(Of Integer)
			Get
				Return Me._EventType
			End Get
			Set(ByVal value As System.Nullable(Of Integer))
				If (Not Me._EventType.Equals(value)) Then
					Me.OnEventTypeChanging(value)
					Me.SendPropertyChanging()
					Me._EventType = value
					Me.SendPropertyChanged("EventType")
					Me.OnEventTypeChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_RecurrenceInfo", DbType:="NVarChar(MAX)")> _
		Public Property RecurrenceInfo() As String
			Get
				Return Me._RecurrenceInfo
			End Get
			Set(ByVal value As String)
				If (Me._RecurrenceInfo <> value) Then
					Me.OnRecurrenceInfoChanging(value)
					Me.SendPropertyChanging()
					Me._RecurrenceInfo = value
					Me.SendPropertyChanged("RecurrenceInfo")
					Me.OnRecurrenceInfoChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ReminderInfo", DbType:="NVarChar(MAX)")> _
		Public Property ReminderInfo() As String
			Get
				Return Me._ReminderInfo
			End Get
			Set(ByVal value As String)
				If (Me._ReminderInfo <> value) Then
					Me.OnReminderInfoChanging(value)
					Me.SendPropertyChanging()
					Me._ReminderInfo = value
					Me.SendPropertyChanged("ReminderInfo")
					Me.OnReminderInfoChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_CarIdShared", DbType:="NVarChar(MAX)")> _
		Public Property CarIdShared() As String
			Get
				Return Me._CarIdShared
			End Get
			Set(ByVal value As String)
				If (Me._CarIdShared <> value) Then
					Me.OnCarIdSharedChanging(value)
					Me.SendPropertyChanging()
					Me._CarIdShared = value
					Me.SendPropertyChanged("CarIdShared")
					Me.OnCarIdSharedChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Price", DbType:="Float")> _
		Public Property Price() As System.Nullable(Of Double)
			Get
				Return Me._Price
			End Get
			Set(ByVal value As System.Nullable(Of Double))
				If (Not Me._Price.Equals(value)) Then
					Me.OnPriceChanging(value)
					Me.SendPropertyChanging()
					Me._Price = value
					Me.SendPropertyChanged("Price")
					Me.OnPriceChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_CarId", DbType:="Int")> _
		Public Property CarId() As System.Nullable(Of Integer)
			Get
				Return Me._CarId
			End Get
			Set(ByVal value As System.Nullable(Of Integer))
				If (Not Me._CarId.Equals(value)) Then
					Me.OnCarIdChanging(value)
					Me.SendPropertyChanging()
					Me._CarId = value
					Me.SendPropertyChanged("CarId")
					Me.OnCarIdChanged()
				End If
			End Set
		End Property

		Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub SendPropertyChanging()
			If (Me.PropertyChangingEvent IsNot Nothing) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub

		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
End Namespace
'TODO: INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591