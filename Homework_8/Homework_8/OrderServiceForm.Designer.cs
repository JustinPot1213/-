namespace Homework_8
{
    partial class OrderServiceForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.funcFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.OrderSplitContainer = new System.Windows.Forms.SplitContainer();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.funcGroupBox = new System.Windows.Forms.GroupBox();
            this.funcFlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.funcFlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.orderBuyerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfCostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thisItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSplitContainer)).BeginInit();
            this.OrderSplitContainer.Panel1.SuspendLayout();
            this.OrderSplitContainer.Panel2.SuspendLayout();
            this.OrderSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.funcGroupBox.SuspendLayout();
            this.funcFlowLayoutPanel3.SuspendLayout();
            this.funcFlowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // funcFlowLayoutPanel1
            // 
            this.funcFlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcFlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcFlowLayoutPanel1.Controls.Add(this.addButton);
            this.funcFlowLayoutPanel1.Controls.Add(this.deleteButton);
            this.funcFlowLayoutPanel1.Controls.Add(this.modifyButton);
            this.funcFlowLayoutPanel1.Location = new System.Drawing.Point(12, 33);
            this.funcFlowLayoutPanel1.Name = "funcFlowLayoutPanel1";
            this.funcFlowLayoutPanel1.Size = new System.Drawing.Size(547, 53);
            this.funcFlowLayoutPanel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "添加订单";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteButton.Location = new System.Drawing.Point(109, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "删除订单";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modifyButton.Location = new System.Drawing.Point(215, 3);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 40);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "修改订单";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // OrderSplitContainer
            // 
            this.OrderSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderSplitContainer.Location = new System.Drawing.Point(12, 222);
            this.OrderSplitContainer.Name = "OrderSplitContainer";
            // 
            // OrderSplitContainer.Panel1
            // 
            this.OrderSplitContainer.Panel1.Controls.Add(this.orderDataGridView);
            // 
            // OrderSplitContainer.Panel2
            // 
            this.OrderSplitContainer.Panel2.Controls.Add(this.itemDataGridView);
            this.OrderSplitContainer.Size = new System.Drawing.Size(772, 216);
            this.OrderSplitContainer.SplitterDistance = 385;
            this.OrderSplitContainer.TabIndex = 1;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderBuyerDataGridViewTextBoxColumn1,
            this.orderIDDataGridViewTextBoxColumn2,
            this.sumOfCostDataGridViewTextBoxColumn1});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(4, 3);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(376, 208);
            this.orderDataGridView.TabIndex = 0;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thisItemDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.sumOfPriceDataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.orderItemsBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(3, 3);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(375, 208);
            this.itemDataGridView.TabIndex = 0;
            // 
            // funcGroupBox
            // 
            this.funcGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.funcGroupBox.Controls.Add(this.funcFlowLayoutPanel3);
            this.funcGroupBox.Controls.Add(this.funcFlowLayoutPanel2);
            this.funcGroupBox.Controls.Add(this.funcFlowLayoutPanel1);
            this.funcGroupBox.Location = new System.Drawing.Point(203, 3);
            this.funcGroupBox.Name = "funcGroupBox";
            this.funcGroupBox.Size = new System.Drawing.Size(562, 201);
            this.funcGroupBox.TabIndex = 2;
            this.funcGroupBox.TabStop = false;
            this.funcGroupBox.Text = "Function";
            // 
            // funcFlowLayoutPanel3
            // 
            this.funcFlowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcFlowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcFlowLayoutPanel3.Controls.Add(this.fileTextBox);
            this.funcFlowLayoutPanel3.Controls.Add(this.exportButton);
            this.funcFlowLayoutPanel3.Controls.Add(this.importButton);
            this.funcFlowLayoutPanel3.Location = new System.Drawing.Point(12, 147);
            this.funcFlowLayoutPanel3.Name = "funcFlowLayoutPanel3";
            this.funcFlowLayoutPanel3.Size = new System.Drawing.Size(543, 53);
            this.funcFlowLayoutPanel3.TabIndex = 2;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileTextBox.Location = new System.Drawing.Point(3, 10);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(312, 25);
            this.fileTextBox.TabIndex = 6;
            this.fileTextBox.Text = "XmlOrderList.xml";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Location = new System.Drawing.Point(321, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 40);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "导出订单";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.Location = new System.Drawing.Point(427, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(100, 40);
            this.importButton.TabIndex = 8;
            this.importButton.Text = "导入订单";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // funcFlowLayoutPanel2
            // 
            this.funcFlowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcFlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcFlowLayoutPanel2.Controls.Add(this.searchComboBox);
            this.funcFlowLayoutPanel2.Controls.Add(this.searchTextBox);
            this.funcFlowLayoutPanel2.Controls.Add(this.searchButton);
            this.funcFlowLayoutPanel2.Location = new System.Drawing.Point(12, 88);
            this.funcFlowLayoutPanel2.Name = "funcFlowLayoutPanel2";
            this.funcFlowLayoutPanel2.Size = new System.Drawing.Size(549, 53);
            this.funcFlowLayoutPanel2.TabIndex = 1;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "按ID查询",
            "按物品查询",
            "按购买者查询",
            "显示全部"});
            this.searchComboBox.Location = new System.Drawing.Point(3, 11);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(120, 23);
            this.searchComboBox.TabIndex = 0;
            this.searchComboBox.Text = "选择查询方式";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTextBox.Location = new System.Drawing.Point(129, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(186, 25);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchButton.Location = new System.Drawing.Point(321, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 40);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "查询订单";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Controls.Add(this.warningLabel);
            this.flowLayoutPanel.Controls.Add(this.funcGroupBox);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(772, 204);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(3, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(194, 207);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "警告信息：              ";
            // 
            // orderBuyerDataGridViewTextBoxColumn1
            // 
            this.orderBuyerDataGridViewTextBoxColumn1.DataPropertyName = "OrderBuyer";
            this.orderBuyerDataGridViewTextBoxColumn1.HeaderText = "OrderBuyer";
            this.orderBuyerDataGridViewTextBoxColumn1.Name = "orderBuyerDataGridViewTextBoxColumn1";
            // 
            // orderIDDataGridViewTextBoxColumn2
            // 
            this.orderIDDataGridViewTextBoxColumn2.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn2.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn2.Name = "orderIDDataGridViewTextBoxColumn2";
            // 
            // sumOfCostDataGridViewTextBoxColumn1
            // 
            this.sumOfCostDataGridViewTextBoxColumn1.DataPropertyName = "SumOfCost";
            this.sumOfCostDataGridViewTextBoxColumn1.HeaderText = "SumOfCost";
            this.sumOfCostDataGridViewTextBoxColumn1.Name = "sumOfCostDataGridViewTextBoxColumn1";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "OrderList";
            this.orderBindingSource.DataSource = typeof(Homework_5.OrderService);
            // 
            // thisItemDataGridViewTextBoxColumn
            // 
            this.thisItemDataGridViewTextBoxColumn.DataPropertyName = "ThisItem";
            this.thisItemDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.thisItemDataGridViewTextBoxColumn.Name = "thisItemDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // sumOfPriceDataGridViewTextBoxColumn
            // 
            this.sumOfPriceDataGridViewTextBoxColumn.DataPropertyName = "SumOfPrice";
            this.sumOfPriceDataGridViewTextBoxColumn.HeaderText = "SumOfPrice";
            this.sumOfPriceDataGridViewTextBoxColumn.Name = "sumOfPriceDataGridViewTextBoxColumn";
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.orderBindingSource;
            // 
            // OrderServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.OrderSplitContainer);
            this.Name = "OrderServiceForm";
            this.Text = "OrderService";
            this.funcFlowLayoutPanel1.ResumeLayout(false);
            this.OrderSplitContainer.Panel1.ResumeLayout(false);
            this.OrderSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderSplitContainer)).EndInit();
            this.OrderSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.funcGroupBox.ResumeLayout(false);
            this.funcFlowLayoutPanel3.ResumeLayout(false);
            this.funcFlowLayoutPanel3.PerformLayout();
            this.funcFlowLayoutPanel2.ResumeLayout(false);
            this.funcFlowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel funcFlowLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.SplitContainer OrderSplitContainer;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private System.Windows.Forms.GroupBox funcGroupBox;
        private System.Windows.Forms.FlowLayoutPanel funcFlowLayoutPanel3;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.FlowLayoutPanel funcFlowLayoutPanel2;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderBuyerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfCostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thisItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfPriceDataGridViewTextBoxColumn;
    }
}

