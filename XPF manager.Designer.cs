/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 8/5/2017
 * Time: 3:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TSA_XPF_mgmt
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbmode = new System.Windows.Forms.ComboBox();
			this.rbmode1 = new System.Windows.Forms.RadioButton();
			this.rbmode2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbcuss = new System.Windows.Forms.RadioButton();
			this.rbcute = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.cbstandard = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvresult = new System.Windows.Forms.DataGridView();
			this.dgvpkgname = new System.Windows.Forms.DataGridView();
			this.btlist = new System.Windows.Forms.Button();
			this.btcompare = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btdelete = new System.Windows.Forms.Button();
			this.btcleanup = new System.Windows.Forms.Button();
			this.btdeactivate = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvpkgname)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 539);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1234, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 52);
			this.label1.TabIndex = 14;
			this.label1.Text = "Site Domain:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbmode
			// 
			this.cbmode.Enabled = false;
			this.cbmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbmode.FormattingEnabled = true;
			this.cbmode.Location = new System.Drawing.Point(124, 18);
			this.cbmode.Name = "cbmode";
			this.cbmode.Size = new System.Drawing.Size(135, 28);
			this.cbmode.TabIndex = 15;
			// 
			// rbmode1
			// 
			this.rbmode1.Checked = true;
			this.rbmode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbmode1.Location = new System.Drawing.Point(10, 19);
			this.rbmode1.Name = "rbmode1";
			this.rbmode1.Size = new System.Drawing.Size(47, 24);
			this.rbmode1.TabIndex = 17;
			this.rbmode1.TabStop = true;
			this.rbmode1.Text = "All";
			this.rbmode1.UseVisualStyleBackColor = true;
			// 
			// rbmode2
			// 
			this.rbmode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbmode2.Location = new System.Drawing.Point(59, 19);
			this.rbmode2.Name = "rbmode2";
			this.rbmode2.Size = new System.Drawing.Size(59, 24);
			this.rbmode2.TabIndex = 18;
			this.rbmode2.Text = "One";
			this.rbmode2.UseVisualStyleBackColor = true;
			this.rbmode2.CheckedChanged += new System.EventHandler(this.Rbmode2CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbmode1);
			this.groupBox1.Controls.Add(this.cbmode);
			this.groupBox1.Controls.Add(this.rbmode2);
			this.groupBox1.Location = new System.Drawing.Point(187, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(266, 52);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Compare Mode";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbcuss);
			this.panel1.Controls.Add(this.rbcute);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(459, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(194, 36);
			this.panel1.TabIndex = 20;
			// 
			// rbcuss
			// 
			this.rbcuss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbcuss.Location = new System.Drawing.Point(117, 5);
			this.rbcuss.Name = "rbcuss";
			this.rbcuss.Size = new System.Drawing.Size(72, 26);
			this.rbcuss.TabIndex = 8;
			this.rbcuss.TabStop = true;
			this.rbcuss.Text = "CUSS";
			this.rbcuss.UseVisualStyleBackColor = true;
			this.rbcuss.CheckedChanged += new System.EventHandler(this.RbcussCheckedChanged);
			// 
			// rbcute
			// 
			this.rbcute.Checked = true;
			this.rbcute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbcute.Location = new System.Drawing.Point(45, 5);
			this.rbcute.Name = "rbcute";
			this.rbcute.Size = new System.Drawing.Size(70, 26);
			this.rbcute.TabIndex = 7;
			this.rbcute.TabStop = true;
			this.rbcute.Text = "CUTE";
			this.rbcute.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "OU:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbstandard
			// 
			this.cbstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbstandard.FormattingEnabled = true;
			this.cbstandard.Location = new System.Drawing.Point(746, 13);
			this.cbstandard.Name = "cbstandard";
			this.cbstandard.Size = new System.Drawing.Size(140, 28);
			this.cbstandard.Sorted = true;
			this.cbstandard.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(659, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 36);
			this.label3.TabIndex = 21;
			this.label3.Text = "Standard:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvresult
			// 
			this.dgvresult.AllowUserToAddRows = false;
			this.dgvresult.AllowUserToDeleteRows = false;
			this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvresult.Location = new System.Drawing.Point(12, 94);
			this.dgvresult.Name = "dgvresult";
			this.dgvresult.RowHeadersVisible = false;
			this.dgvresult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvresult.Size = new System.Drawing.Size(636, 442);
			this.dgvresult.TabIndex = 24;
			// 
			// dgvpkgname
			// 
			this.dgvpkgname.AllowUserToAddRows = false;
			this.dgvpkgname.AllowUserToDeleteRows = false;
			this.dgvpkgname.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvpkgname.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvpkgname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvpkgname.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvpkgname.Location = new System.Drawing.Point(661, 48);
			this.dgvpkgname.Name = "dgvpkgname";
			this.dgvpkgname.RowHeadersVisible = false;
			this.dgvpkgname.Size = new System.Drawing.Size(561, 488);
			this.dgvpkgname.TabIndex = 23;
			// 
			// btlist
			// 
			this.btlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btlist.Location = new System.Drawing.Point(892, 12);
			this.btlist.Name = "btlist";
			this.btlist.Size = new System.Drawing.Size(120, 28);
			this.btlist.TabIndex = 25;
			this.btlist.Text = "List Standard";
			this.btlist.UseVisualStyleBackColor = true;
			this.btlist.Click += new System.EventHandler(this.BtlistClick);
			// 
			// btcompare
			// 
			this.btcompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btcompare.Location = new System.Drawing.Point(3, 3);
			this.btcompare.Name = "btcompare";
			this.btcompare.Size = new System.Drawing.Size(85, 28);
			this.btcompare.TabIndex = 26;
			this.btcompare.Text = "Compare";
			this.btcompare.UseVisualStyleBackColor = true;
			this.btcompare.Click += new System.EventHandler(this.BtcompareClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btdelete);
			this.panel2.Controls.Add(this.btcleanup);
			this.panel2.Controls.Add(this.btdeactivate);
			this.panel2.Controls.Add(this.btcompare);
			this.panel2.Location = new System.Drawing.Point(13, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(635, 34);
			this.panel2.TabIndex = 27;
			// 
			// btdelete
			// 
			this.btdelete.Enabled = false;
			this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btdelete.Location = new System.Drawing.Point(393, 3);
			this.btdelete.Name = "btdelete";
			this.btdelete.Size = new System.Drawing.Size(98, 28);
			this.btdelete.TabIndex = 29;
			this.btdelete.Text = "Delete";
			this.btdelete.UseVisualStyleBackColor = true;
			// 
			// btcleanup
			// 
			this.btcleanup.Enabled = false;
			this.btcleanup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btcleanup.Location = new System.Drawing.Point(94, 3);
			this.btcleanup.Name = "btcleanup";
			this.btcleanup.Size = new System.Drawing.Size(98, 28);
			this.btcleanup.TabIndex = 28;
			this.btcleanup.Text = "Cleanup";
			this.btcleanup.UseVisualStyleBackColor = true;
			// 
			// btdeactivate
			// 
			this.btdeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btdeactivate.Location = new System.Drawing.Point(284, 3);
			this.btdeactivate.Name = "btdeactivate";
			this.btdeactivate.Size = new System.Drawing.Size(98, 28);
			this.btdeactivate.TabIndex = 27;
			this.btdeactivate.Text = "Deactivate";
			this.btdeactivate.UseVisualStyleBackColor = true;
			this.btdeactivate.Click += new System.EventHandler(this.BtdeactivateClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 561);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btlist);
			this.Controls.Add(this.dgvresult);
			this.Controls.Add(this.dgvpkgname);
			this.Controls.Add(this.cbstandard);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "XPF manager";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvpkgname)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btcleanup;
		private System.Windows.Forms.Button btdelete;
		private System.Windows.Forms.Button btdeactivate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btcompare;
		private System.Windows.Forms.Button btlist;
		private System.Windows.Forms.DataGridView dgvpkgname;
		private System.Windows.Forms.DataGridView dgvresult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbstandard;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbcute;
		private System.Windows.Forms.RadioButton rbcuss;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbmode2;
		private System.Windows.Forms.RadioButton rbmode1;
		private System.Windows.Forms.ComboBox cbmode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}
