namespace Homework_8
{
    partial class SubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.funcGroupBox = new System.Windows.Forms.GroupBox();
            this.funcFlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buyersComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.funcFlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.modifyComboBox = new System.Windows.Forms.ComboBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.addItemComboBox = new System.Windows.Forms.ComboBox();
            this.addItemTextBox = new System.Windows.Forms.TextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.OrderSplitContainer = new System.Windows.Forms.SplitContainer();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderBuyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.thisItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warningLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel.SuspendLayout();
            this.funcGroupBox.SuspendLayout();
            this.funcFlowLayoutPanel3.SuspendLayout();
            this.funcFlowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSplitContainer)).BeginInit();
            this.OrderSplitContainer.Panel1.SuspendLayout();
            this.OrderSplitContainer.Panel2.SuspendLayout();
            this.OrderSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Controls.Add(this.funcGroupBox);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(774, 160);
            this.flowLayoutPanel.TabIndex = 5;
            // 
            // funcGroupBox
            // 
            this.funcGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.funcGroupBox.Controls.Add(this.funcFlowLayoutPanel3);
            this.funcGroupBox.Controls.Add(this.funcFlowLayoutPanel2);
            this.funcGroupBox.Location = new System.Drawing.Point(3, 3);
            this.funcGroupBox.Name = "funcGroupBox";
            this.funcGroupBox.Size = new System.Drawing.Size(767, 148);
            this.funcGroupBox.TabIndex = 2;
            this.funcGroupBox.TabStop = false;
            this.funcGroupBox.Text = "Function";
            // 
            // funcFlowLayoutPanel3
            // 
            this.funcFlowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcFlowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcFlowLayoutPanel3.Controls.Add(this.label1);
            this.funcFlowLayoutPanel3.Controls.Add(this.buyersComboBox);
            this.funcFlowLayoutPanel3.Controls.Add(this.addButton);
            this.funcFlowLayoutPanel3.Controls.Add(this.saveButton);
            this.funcFlowLayoutPanel3.Location = new System.Drawing.Point(13, 83);
            this.funcFlowLayoutPanel3.Name = "funcFlowLayoutPanel3";
            this.funcFlowLayoutPanel3.Size = new System.Drawing.Size(748, 53);
            this.funcFlowLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择购买者";
            // 
            // buyersComboBox
            // 
            this.buyersComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buyersComboBox.FormattingEnabled = true;
            this.buyersComboBox.Location = new System.Drawing.Point(91, 11);
            this.buyersComboBox.Name = "buyersComboBox";
            this.buyersComboBox.Size = new System.Drawing.Size(100, 23);
            this.buyersComboBox.TabIndex = 5;
            this.buyersComboBox.Text = "选择购买者";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(197, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "添加订单";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveButton.Location = new System.Drawing.Point(303, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "保存订单";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // funcFlowLayoutPanel2
            // 
            this.funcFlowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcFlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcFlowLayoutPanel2.Controls.Add(this.modifyComboBox);
            this.funcFlowLayoutPanel2.Controls.Add(this.itemLabel);
            this.funcFlowLayoutPanel2.Controls.Add(this.addItemComboBox);
            this.funcFlowLayoutPanel2.Controls.Add(this.addItemTextBox);
            this.funcFlowLayoutPanel2.Controls.Add(this.modifyButton);
            this.funcFlowLayoutPanel2.Location = new System.Drawing.Point(13, 24);
            this.funcFlowLayoutPanel2.Name = "funcFlowLayoutPanel2";
            this.funcFlowLayoutPanel2.Size = new System.Drawing.Size(754, 53);
            this.funcFlowLayoutPanel2.TabIndex = 1;
            // 
            // modifyComboBox
            // 
            this.modifyComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modifyComboBox.FormattingEnabled = true;
            this.modifyComboBox.Items.AddRange(new object[] {
            "删除当前订单项",
            "增加订单项"});
            this.modifyComboBox.Location = new System.Drawing.Point(3, 11);
            this.modifyComboBox.Name = "modifyComboBox";
            this.modifyComboBox.Size = new System.Drawing.Size(159, 23);
            this.modifyComboBox.TabIndex = 0;
            this.modifyComboBox.Text = "选择修改方式";
            this.modifyComboBox.SelectedIndexChanged += new System.EventHandler(this.modifyComboBox_SelectedIndexChanged);
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(168, 15);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(97, 15);
            this.itemLabel.TabIndex = 8;
            this.itemLabel.Text = "选择添加物品";
            // 
            // addItemComboBox
            // 
            this.addItemComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addItemComboBox.FormattingEnabled = true;
            this.addItemComboBox.Location = new System.Drawing.Point(271, 11);
            this.addItemComboBox.Name = "addItemComboBox";
            this.addItemComboBox.Size = new System.Drawing.Size(162, 23);
            this.addItemComboBox.TabIndex = 6;
            this.addItemComboBox.Text = "选择物品";
            // 
            // addItemTextBox
            // 
            this.addItemTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addItemTextBox.Location = new System.Drawing.Point(439, 10);
            this.addItemTextBox.Name = "addItemTextBox";
            this.addItemTextBox.Size = new System.Drawing.Size(100, 25);
            this.addItemTextBox.TabIndex = 7;
            this.addItemTextBox.Text = "输入添加数";
            // 
            // modifyButton
            // 
            this.modifyButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modifyButton.Location = new System.Drawing.Point(545, 3);
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
            this.OrderSplitContainer.Location = new System.Drawing.Point(12, 178);
            this.OrderSplitContainer.Name = "OrderSplitContainer";
            // 
            // OrderSplitContainer.Panel1
            // 
            this.OrderSplitContainer.Panel1.Controls.Add(this.orderDataGridView);
            // 
            // OrderSplitContainer.Panel2
            // 
            this.OrderSplitContainer.Panel2.Controls.Add(this.itemDataGridView);
            this.OrderSplitContainer.Size = new System.Drawing.Size(774, 180);
            this.OrderSplitContainer.SplitterDistance = 385;
            this.OrderSplitContainer.TabIndex = 4;
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
            this.orderBuyerDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.sumOfCostDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(4, -1);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(376, 180);
            this.orderDataGridView.TabIndex = 0;
            // 
            // orderBuyerDataGridViewTextBoxColumn
            // 
            this.orderBuyerDataGridViewTextBoxColumn.DataPropertyName = "OrderBuyer";
            this.orderBuyerDataGridViewTextBoxColumn.HeaderText = "OrderBuyer";
            this.orderBuyerDataGridViewTextBoxColumn.Name = "orderBuyerDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // sumOfCostDataGridViewTextBoxColumn
            // 
            this.sumOfCostDataGridViewTextBoxColumn.DataPropertyName = "SumOfCost";
            this.sumOfCostDataGridViewTextBoxColumn.HeaderText = "SumOfCost";
            this.sumOfCostDataGridViewTextBoxColumn.Name = "sumOfCostDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "OrderList";
            this.orderBindingSource.DataSource = typeof(Homework_5.OrderService);
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
            this.itemDataGridView.Location = new System.Drawing.Point(3, -1);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(377, 180);
            this.itemDataGridView.TabIndex = 0;
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
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(12, 365);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(52, 15);
            this.warningLabel.TabIndex = 6;
            this.warningLabel.Text = "提示：";
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 420);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.OrderSplitContainer);
            this.Name = "SubForm";
            this.Text = "SubForm";
            this.flowLayoutPanel.ResumeLayout(false);
            this.funcGroupBox.ResumeLayout(false);
            this.funcFlowLayoutPanel3.ResumeLayout(false);
            this.funcFlowLayoutPanel3.PerformLayout();
            this.funcFlowLayoutPanel2.ResumeLayout(false);
            this.funcFlowLayoutPanel2.PerformLayout();
            this.OrderSplitContainer.Panel1.ResumeLayout(false);
            this.OrderSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderSplitContainer)).EndInit();
            this.OrderSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.GroupBox funcGroupBox;
        private System.Windows.Forms.FlowLayoutPanel funcFlowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel funcFlowLayoutPanel2;
        private System.Windows.Forms.ComboBox modifyComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.SplitContainer OrderSplitContainer;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.ComboBox buyersComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderBuyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thisItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox addItemComboBox;
        private System.Windows.Forms.TextBox addItemTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warningLabel;
    }
}