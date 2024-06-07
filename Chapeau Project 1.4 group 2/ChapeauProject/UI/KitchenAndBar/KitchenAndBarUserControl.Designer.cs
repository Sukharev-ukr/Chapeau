﻿namespace UI
{
    partial class KitchenAndBarUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategory = new Label();
            lblTableNumber = new Label();
            lblOrderTime = new Label();
            listViewOrderItems = new ListView();
            columnHeader1 = new ColumnHeader();
            groupBox1 = new GroupBox();
            comboBoxStatus = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(41, 98);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(81, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "category";
            // 
            // lblTableNumber
            // 
            lblTableNumber.AutoSize = true;
            lblTableNumber.Location = new Point(41, 50);
            lblTableNumber.Name = "lblTableNumber";
            lblTableNumber.Size = new Size(67, 25);
            lblTableNumber.TabIndex = 11;
            lblTableNumber.Text = "tablenr";
            // 
            // lblOrderTime
            // 
            lblOrderTime.AutoSize = true;
            lblOrderTime.Location = new Point(252, 19);
            lblOrderTime.Name = "lblOrderTime";
            lblOrderTime.Size = new Size(90, 25);
            lblOrderTime.TabIndex = 12;
            lblOrderTime.Text = "ordertime";
            // 
            // listViewOrderItems
            // 
            listViewOrderItems.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewOrderItems.FullRowSelect = true;
            listViewOrderItems.Location = new Point(41, 133);
            listViewOrderItems.Name = "listViewOrderItems";
            listViewOrderItems.Size = new Size(324, 203);
            listViewOrderItems.TabIndex = 14;
            listViewOrderItems.UseCompatibleStateImageBehavior = false;
            listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 300;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(lblOrderTime);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(23, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 332);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "placed", "BeingPrepared", "ready" });
            comboBoxStatus.Location = new Point(232, 59);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(110, 33);
            comboBoxStatus.TabIndex = 14;
            comboBoxStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // KitchenAndBarUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewOrderItems);
            Controls.Add(lblTableNumber);
            Controls.Add(lblCategory);
            Controls.Add(groupBox1);
            Name = "KitchenAndBarUserControl";
            Size = new Size(392, 390);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCategory;
        private Label lblTableNumber;
        private Label lblOrderTime;
        private ListView listViewOrderItems;
        private GroupBox groupBox1;
        private ComboBox comboBoxStatus;
        private ColumnHeader columnHeader1;
    }
}
