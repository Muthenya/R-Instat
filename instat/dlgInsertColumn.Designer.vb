﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInsertColumn
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
        Me.lblStartPos = New System.Windows.Forms.Label()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.grpInsert = New System.Windows.Forms.GroupBox()
        Me.rdoBeforeAfter = New System.Windows.Forms.RadioButton()
        Me.ucrInputBeforeAfter = New instat.ucrInputComboBox()
        Me.ucrReceiverColumnsToInsert = New instat.ucrReceiverSingle()
        Me.rdoAtEnd = New System.Windows.Forms.RadioButton()
        Me.rdoAtStart = New System.Windows.Forms.RadioButton()
        Me.ucrPnlStartEnd = New instat.UcrPanel()
        Me.lblNumberOfColumnsToInsert = New System.Windows.Forms.Label()
        Me.lblDefaultValue = New System.Windows.Forms.Label()
        Me.grpOPtions = New System.Windows.Forms.GroupBox()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.ucrPnlBeforeAfter = New instat.UcrPanel()
        Me.rdoInsertColumns = New System.Windows.Forms.RadioButton()
        Me.rdoInsertRows = New System.Windows.Forms.RadioButton()
        Me.ucrSaveInsertColumn = New instat.ucrSave()
        Me.ucrNudNumberOfColumns = New instat.ucrNud()
        Me.ucrPnlColumnsOrRows = New instat.UcrPanel()
        Me.ucrInputDefaultValue = New instat.ucrInputTextBox()
        Me.ucrSelectorInsertColumns = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.ucrNudNumberOfRows = New instat.ucrNud()
        Me.ucrNudStartRow = New instat.ucrNud()
        Me.grpInsert.SuspendLayout()
        Me.grpOPtions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(12, 129)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(88, 13)
        Me.lblStartPos.TabIndex = 7
        Me.lblStartPos.Text = "Insert at Position:"
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(12, 103)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(130, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 5
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert:"
        '
        'grpInsert
        '
        Me.grpInsert.Controls.Add(Me.rdoBeforeAfter)
        Me.grpInsert.Controls.Add(Me.ucrInputBeforeAfter)
        Me.grpInsert.Controls.Add(Me.ucrReceiverColumnsToInsert)
        Me.grpInsert.Controls.Add(Me.rdoAtEnd)
        Me.grpInsert.Controls.Add(Me.rdoAtStart)
        Me.grpInsert.Controls.Add(Me.ucrPnlStartEnd)
        Me.grpInsert.Location = New System.Drawing.Point(228, 73)
        Me.grpInsert.Name = "grpInsert"
        Me.grpInsert.Size = New System.Drawing.Size(298, 101)
        Me.grpInsert.TabIndex = 10
        Me.grpInsert.TabStop = False
        Me.grpInsert.Text = "Insert"
        '
        'rdoBeforeAfter
        '
        Me.rdoBeforeAfter.AutoSize = True
        Me.rdoBeforeAfter.Location = New System.Drawing.Point(20, 71)
        Me.rdoBeforeAfter.Name = "rdoBeforeAfter"
        Me.rdoBeforeAfter.Size = New System.Drawing.Size(96, 17)
        Me.rdoBeforeAfter.TabIndex = 23
        Me.rdoBeforeAfter.TabStop = True
        Me.rdoBeforeAfter.Text = "Before or After:"
        Me.rdoBeforeAfter.UseVisualStyleBackColor = True
        '
        'ucrInputBeforeAfter
        '
        Me.ucrInputBeforeAfter.AddQuotesIfUnrecognised = True
        Me.ucrInputBeforeAfter.IsReadOnly = False
        Me.ucrInputBeforeAfter.Location = New System.Drawing.Point(121, 70)
        Me.ucrInputBeforeAfter.Name = "ucrInputBeforeAfter"
        Me.ucrInputBeforeAfter.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputBeforeAfter.TabIndex = 3
        '
        'ucrReceiverColumnsToInsert
        '
        Me.ucrReceiverColumnsToInsert.frmParent = Me
        Me.ucrReceiverColumnsToInsert.Location = New System.Drawing.Point(218, 69)
        Me.ucrReceiverColumnsToInsert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToInsert.Name = "ucrReceiverColumnsToInsert"
        Me.ucrReceiverColumnsToInsert.Selector = Nothing
        Me.ucrReceiverColumnsToInsert.Size = New System.Drawing.Size(75, 20)
        Me.ucrReceiverColumnsToInsert.strNcFilePath = ""
        Me.ucrReceiverColumnsToInsert.TabIndex = 4
        Me.ucrReceiverColumnsToInsert.ucrSelector = Nothing
        '
        'rdoAtEnd
        '
        Me.rdoAtEnd.AutoSize = True
        Me.rdoAtEnd.Location = New System.Drawing.Point(21, 18)
        Me.rdoAtEnd.Name = "rdoAtEnd"
        Me.rdoAtEnd.Size = New System.Drawing.Size(57, 17)
        Me.rdoAtEnd.TabIndex = 0
        Me.rdoAtEnd.TabStop = True
        Me.rdoAtEnd.Text = "At End"
        Me.rdoAtEnd.UseVisualStyleBackColor = True
        '
        'rdoAtStart
        '
        Me.rdoAtStart.AutoSize = True
        Me.rdoAtStart.Location = New System.Drawing.Point(21, 43)
        Me.rdoAtStart.Name = "rdoAtStart"
        Me.rdoAtStart.Size = New System.Drawing.Size(60, 17)
        Me.rdoAtStart.TabIndex = 1
        Me.rdoAtStart.TabStop = True
        Me.rdoAtStart.Text = "At Start"
        Me.rdoAtStart.UseVisualStyleBackColor = True
        '
        'ucrPnlStartEnd
        '
        Me.ucrPnlStartEnd.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlStartEnd.Name = "ucrPnlStartEnd"
        Me.ucrPnlStartEnd.Size = New System.Drawing.Size(78, 81)
        Me.ucrPnlStartEnd.TabIndex = 22
        '
        'lblNumberOfColumnsToInsert
        '
        Me.lblNumberOfColumnsToInsert.AutoSize = True
        Me.lblNumberOfColumnsToInsert.Location = New System.Drawing.Point(232, 184)
        Me.lblNumberOfColumnsToInsert.Name = "lblNumberOfColumnsToInsert"
        Me.lblNumberOfColumnsToInsert.Size = New System.Drawing.Size(143, 13)
        Me.lblNumberOfColumnsToInsert.TabIndex = 11
        Me.lblNumberOfColumnsToInsert.Text = "Number of Columns to Insert:"
        '
        'lblDefaultValue
        '
        Me.lblDefaultValue.AutoSize = True
        Me.lblDefaultValue.Location = New System.Drawing.Point(233, 208)
        Me.lblDefaultValue.Name = "lblDefaultValue"
        Me.lblDefaultValue.Size = New System.Drawing.Size(74, 13)
        Me.lblDefaultValue.TabIndex = 13
        Me.lblDefaultValue.Text = "Default Value:"
        '
        'grpOPtions
        '
        Me.grpOPtions.Controls.Add(Me.rdoAfter)
        Me.grpOPtions.Controls.Add(Me.rdoBefore)
        Me.grpOPtions.Controls.Add(Me.ucrPnlBeforeAfter)
        Me.grpOPtions.Location = New System.Drawing.Point(349, 57)
        Me.grpOPtions.Name = "grpOPtions"
        Me.grpOPtions.Size = New System.Drawing.Size(124, 82)
        Me.grpOPtions.TabIndex = 9
        Me.grpOPtions.TabStop = False
        Me.grpOPtions.Text = "Options"
        '
        'rdoAfter
        '
        Me.rdoAfter.AutoSize = True
        Me.rdoAfter.Location = New System.Drawing.Point(5, 53)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter.TabIndex = 1
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.Text = "After"
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.Location = New System.Drawing.Point(6, 26)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore.TabIndex = 0
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.Text = "Before"
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'ucrPnlBeforeAfter
        '
        Me.ucrPnlBeforeAfter.Location = New System.Drawing.Point(4, 18)
        Me.ucrPnlBeforeAfter.Name = "ucrPnlBeforeAfter"
        Me.ucrPnlBeforeAfter.Size = New System.Drawing.Size(98, 57)
        Me.ucrPnlBeforeAfter.TabIndex = 21
        '
        'rdoInsertColumns
        '
        Me.rdoInsertColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInsertColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatAppearance.BorderSize = 2
        Me.rdoInsertColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInsertColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertColumns.Location = New System.Drawing.Point(140, 12)
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.Size = New System.Drawing.Size(100, 28)
        Me.rdoInsertColumns.TabIndex = 1
        Me.rdoInsertColumns.Text = "Insert Columns"
        Me.rdoInsertColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'rdoInsertRows
        '
        Me.rdoInsertRows.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoInsertRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatAppearance.BorderSize = 2
        Me.rdoInsertRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInsertRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoInsertRows.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoInsertRows.Location = New System.Drawing.Point(238, 12)
        Me.rdoInsertRows.Name = "rdoInsertRows"
        Me.rdoInsertRows.Size = New System.Drawing.Size(100, 28)
        Me.rdoInsertRows.TabIndex = 2
        Me.rdoInsertRows.Text = "Insert Rows"
        Me.rdoInsertRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoInsertRows.UseVisualStyleBackColor = True
        '
        'ucrSaveInsertColumn
        '
        Me.ucrSaveInsertColumn.Location = New System.Drawing.Point(10, 235)
        Me.ucrSaveInsertColumn.Name = "ucrSaveInsertColumn"
        Me.ucrSaveInsertColumn.Size = New System.Drawing.Size(343, 24)
        Me.ucrSaveInsertColumn.TabIndex = 21
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Location = New System.Drawing.Point(373, 180)
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfColumns.TabIndex = 20
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlColumnsOrRows
        '
        Me.ucrPnlColumnsOrRows.Location = New System.Drawing.Point(132, 11)
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        Me.ucrPnlColumnsOrRows.Size = New System.Drawing.Size(214, 29)
        Me.ucrPnlColumnsOrRows.TabIndex = 0
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.AddQuotesIfUnrecognised = True
        Me.ucrInputDefaultValue.IsMultiline = False
        Me.ucrInputDefaultValue.IsReadOnly = False
        Me.ucrInputDefaultValue.Location = New System.Drawing.Point(374, 204)
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ucrInputDefaultValue.Size = New System.Drawing.Size(45, 21)
        Me.ucrInputDefaultValue.TabIndex = 14
        '
        'ucrSelectorInsertColumns
        '
        Me.ucrSelectorInsertColumns.bShowHiddenColumns = False
        Me.ucrSelectorInsertColumns.Location = New System.Drawing.Point(9, 93)
        Me.ucrSelectorInsertColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorInsertColumns.Name = "ucrSelectorInsertColumns"
        Me.ucrSelectorInsertColumns.Size = New System.Drawing.Size(202, 148)
        Me.ucrSelectorInsertColumns.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 260)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 17
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.bUseCurrentFilter = True
        Me.ucrDataFramesList.Location = New System.Drawing.Point(10, 52)
        Me.ucrDataFramesList.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 3
        '
        'ucrNudNumberOfRows
        '
        Me.ucrNudNumberOfRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfRows.Location = New System.Drawing.Point(148, 101)
        Me.ucrNudNumberOfRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfRows.Name = "ucrNudNumberOfRows"
        Me.ucrNudNumberOfRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfRows.TabIndex = 18
        Me.ucrNudNumberOfRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudStartRow
        '
        Me.ucrNudStartRow.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartRow.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudStartRow.Location = New System.Drawing.Point(148, 129)
        Me.ucrNudStartRow.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudStartRow.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudStartRow.Name = "ucrNudStartRow"
        Me.ucrNudStartRow.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudStartRow.TabIndex = 19
        Me.ucrNudStartRow.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 325)
        Me.Controls.Add(Me.grpOPtions)
        Me.Controls.Add(Me.grpInsert)
        Me.Controls.Add(Me.ucrSaveInsertColumn)
        Me.Controls.Add(Me.ucrNudNumberOfColumns)
        Me.Controls.Add(Me.rdoInsertRows)
        Me.Controls.Add(Me.rdoInsertColumns)
        Me.Controls.Add(Me.ucrPnlColumnsOrRows)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblDefaultValue)
        Me.Controls.Add(Me.lblNumberOfColumnsToInsert)
        Me.Controls.Add(Me.ucrSelectorInsertColumns)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.Controls.Add(Me.ucrNudNumberOfRows)
        Me.Controls.Add(Me.ucrNudStartRow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        Me.grpInsert.ResumeLayout(False)
        Me.grpInsert.PerformLayout()
        Me.grpOPtions.ResumeLayout(False)
        Me.grpOPtions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberOfRowsToInsert As Label
    Friend WithEvents ucrSelectorInsertColumns As ucrSelectorAddRemove
    Friend WithEvents grpInsert As GroupBox
    Friend WithEvents ucrInputBeforeAfter As ucrInputComboBox
    Friend WithEvents rdoAtStart As RadioButton
    Friend WithEvents rdoAtEnd As RadioButton
    Friend WithEvents ucrReceiverColumnsToInsert As ucrReceiverSingle
    Friend WithEvents lblNumberOfColumnsToInsert As Label
    Friend WithEvents lblDefaultValue As Label
    Friend WithEvents ucrInputDefaultValue As ucrInputTextBox
    Friend WithEvents grpOPtions As GroupBox
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoInsertColumns As RadioButton
    Friend WithEvents ucrPnlColumnsOrRows As UcrPanel
    Friend WithEvents rdoInsertRows As RadioButton
    Friend WithEvents ucrNudNumberOfColumns As ucrNud
    Friend WithEvents ucrNudStartRow As ucrNud
    Friend WithEvents ucrNudNumberOfRows As ucrNud
    Friend WithEvents ucrPnlBeforeAfter As UcrPanel
    Friend WithEvents ucrPnlStartEnd As UcrPanel
    Friend WithEvents ucrSaveInsertColumn As ucrSave
    Friend WithEvents rdoBeforeAfter As RadioButton
End Class
