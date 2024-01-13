
namespace Bank_Management_System
{
    partial class allEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allEmployeeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHireEmployee = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.btnAllEmployees = new System.Windows.Forms.Button();
            this.btnBlockCustomer = new System.Windows.Forms.Button();
            this.btnFlow = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.2695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.7305F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1233, 705);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1227, 150);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.1304F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.8696F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1227, 543);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Honeydew;
            this.flowLayoutPanel2.Controls.Add(this.btnHireEmployee);
            this.flowLayoutPanel2.Controls.Add(this.btnFireEmployee);
            this.flowLayoutPanel2.Controls.Add(this.btnAllEmployees);
            this.flowLayoutPanel2.Controls.Add(this.btnBlockCustomer);
            this.flowLayoutPanel2.Controls.Add(this.btnFlow);
            this.flowLayoutPanel2.Controls.Add(this.btnInterest);
            this.flowLayoutPanel2.Controls.Add(this.btnBonus);
            this.flowLayoutPanel2.Controls.Add(this.btnBack);
            this.flowLayoutPanel2.Controls.Add(this.dropDown);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(241, 537);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnHireEmployee
            // 
            this.btnHireEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHireEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHireEmployee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHireEmployee.Location = new System.Drawing.Point(3, 3);
            this.btnHireEmployee.Name = "btnHireEmployee";
            this.btnHireEmployee.Size = new System.Drawing.Size(236, 50);
            this.btnHireEmployee.TabIndex = 1;
            this.btnHireEmployee.Text = "Hire new Employee";
            this.btnHireEmployee.UseVisualStyleBackColor = false;
            this.btnHireEmployee.Click += new System.EventHandler(this.btnHireEmployee_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFireEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireEmployee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFireEmployee.Location = new System.Drawing.Point(3, 59);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(236, 50);
            this.btnFireEmployee.TabIndex = 2;
            this.btnFireEmployee.Text = "Fire an Employee";
            this.btnFireEmployee.UseVisualStyleBackColor = false;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // btnAllEmployees
            // 
            this.btnAllEmployees.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllEmployees.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEmployees.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAllEmployees.Location = new System.Drawing.Point(3, 115);
            this.btnAllEmployees.Name = "btnAllEmployees";
            this.btnAllEmployees.Size = new System.Drawing.Size(236, 50);
            this.btnAllEmployees.TabIndex = 4;
            this.btnAllEmployees.Text = "All Employees";
            this.btnAllEmployees.UseVisualStyleBackColor = false;
            // 
            // btnBlockCustomer
            // 
            this.btnBlockCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlockCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockCustomer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBlockCustomer.Location = new System.Drawing.Point(3, 171);
            this.btnBlockCustomer.Name = "btnBlockCustomer";
            this.btnBlockCustomer.Size = new System.Drawing.Size(236, 50);
            this.btnBlockCustomer.TabIndex = 5;
            this.btnBlockCustomer.Text = "Block Customer Account";
            this.btnBlockCustomer.UseVisualStyleBackColor = false;
            this.btnBlockCustomer.Click += new System.EventHandler(this.btnBlockCustomer_Click);
            // 
            // btnFlow
            // 
            this.btnFlow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFlow.Location = new System.Drawing.Point(3, 227);
            this.btnFlow.Name = "btnFlow";
            this.btnFlow.Size = new System.Drawing.Size(236, 50);
            this.btnFlow.TabIndex = 6;
            this.btnFlow.Text = "Check Cash flow";
            this.btnFlow.UseVisualStyleBackColor = false;
            this.btnFlow.Click += new System.EventHandler(this.btnFlow_Click);
            // 
            // btnInterest
            // 
            this.btnInterest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInterest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInterest.Location = new System.Drawing.Point(3, 283);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(236, 50);
            this.btnInterest.TabIndex = 10;
            this.btnInterest.Text = "Give Interest";
            this.btnInterest.UseVisualStyleBackColor = false;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // btnBonus
            // 
            this.btnBonus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBonus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBonus.Location = new System.Drawing.Point(3, 339);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(236, 50);
            this.btnBonus.TabIndex = 11;
            this.btnBonus.Text = "Give Bonus";
            this.btnBonus.UseVisualStyleBackColor = false;
            this.btnBonus.Click += new System.EventHandler(this.btnBonus_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(3, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(236, 50);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(250, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2216F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.7784F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(974, 537);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(968, 64);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(898, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 33);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 35);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Welcome ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // dropDown
            // 
            this.dropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection Sort",
            "Insertion Sort",
            "Merge Sort",
            "Quick Sort",
            "Heap Sort",
            "Counting Sort",
            "Radix Sort",
            "Bucket Sort"});
            this.dropDown.Location = new System.Drawing.Point(3, 451);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(236, 24);
            this.dropDown.TabIndex = 13;
            this.dropDown.SelectedIndexChanged += new System.EventHandler(this.dropDown_SelectedIndexChanged);
            // 
            // allEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1233, 705);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "allEmployeeForm";
            this.Text = "allEmployeeForm";
            this.Load += new System.EventHandler(this.allEmployeeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnHireEmployee;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.Button btnAllEmployees;
        private System.Windows.Forms.Button btnBlockCustomer;
        private System.Windows.Forms.Button btnFlow;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox dropDown;
    }
}