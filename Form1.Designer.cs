
namespace MIDCOM_Tax
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.taxEntryGrid = new System.Windows.Forms.DataGridView();
            this.taxCodeGrid = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadBtn = new System.Windows.Forms.Button();
            this.expDatBtn = new System.Windows.Forms.Button();
            this.expStrBtn = new System.Windows.Forms.Button();
            this.TableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxEntryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxCodeGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            this.TableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayout.AutoSize = true;
            this.TableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayout.ColumnCount = 1;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableLayout.Controls.Add(this.taxEntryGrid, 0, 0);
            this.TableLayout.Controls.Add(this.taxCodeGrid, 0, 1);
            this.TableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableLayout.Location = new System.Drawing.Point(12, 94);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 2;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayout.Size = new System.Drawing.Size(1084, 690);
            this.TableLayout.TabIndex = 0;
            // 
            // taxEntryGrid
            // 
            this.taxEntryGrid.AllowUserToAddRows = false;
            this.taxEntryGrid.AllowUserToDeleteRows = false;
            this.taxEntryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxEntryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxEntryGrid.Location = new System.Drawing.Point(3, 4);
            this.taxEntryGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taxEntryGrid.MultiSelect = false;
            this.taxEntryGrid.Name = "taxEntryGrid";
            this.taxEntryGrid.RowTemplate.Height = 25;
            this.taxEntryGrid.Size = new System.Drawing.Size(1078, 337);
            this.taxEntryGrid.TabIndex = 0;
            // 
            // taxCodeGrid
            // 
            this.taxCodeGrid.AllowUserToAddRows = false;
            this.taxCodeGrid.AllowUserToDeleteRows = false;
            this.taxCodeGrid.AllowUserToResizeColumns = false;
            this.taxCodeGrid.AllowUserToResizeRows = false;
            this.taxCodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxCodeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxCodeGrid.Location = new System.Drawing.Point(3, 349);
            this.taxCodeGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taxCodeGrid.Name = "taxCodeGrid";
            this.taxCodeGrid.RowTemplate.Height = 25;
            this.taxCodeGrid.Size = new System.Drawing.Size(1078, 337);
            this.taxCodeGrid.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.loadBtn);
            this.flowLayoutPanel1.Controls.Add(this.expDatBtn);
            this.flowLayoutPanel1.Controls.Add(this.expStrBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1078, 52);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // loadBtn
            // 
            this.loadBtn.AutoSize = true;
            this.loadBtn.Location = new System.Drawing.Point(3, 3);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(71, 30);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // expDatBtn
            // 
            this.expDatBtn.AutoSize = true;
            this.expDatBtn.Location = new System.Drawing.Point(80, 3);
            this.expDatBtn.Name = "expDatBtn";
            this.expDatBtn.Size = new System.Drawing.Size(97, 30);
            this.expDatBtn.TabIndex = 1;
            this.expDatBtn.Text = "Export .DAT";
            this.expDatBtn.UseVisualStyleBackColor = true;
            // 
            // expStrBtn
            // 
            this.expStrBtn.AutoSize = true;
            this.expStrBtn.Location = new System.Drawing.Point(183, 3);
            this.expStrBtn.Name = "expStrBtn";
            this.expStrBtn.Size = new System.Drawing.Size(94, 30);
            this.expStrBtn.TabIndex = 2;
            this.expStrBtn.Text = "Export .STR";
            this.expStrBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1118, 797);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TableLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "MIDCOM Tax File Editor - SD & Cybercard - Standard (20,20,100) Format";
            this.TableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxEntryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxCodeGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.DataGridView taxEntryGrid;
        private System.Windows.Forms.DataGridView taxCodeGrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button expDatBtn;
        private System.Windows.Forms.Button expStrBtn;
    }
}

