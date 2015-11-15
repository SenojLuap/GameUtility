namespace TileSheetEditor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tileSheetFile = new System.Windows.Forms.TextBox();
            this.openTileSheetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.frameHeightBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.frameWidthBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.defaultOffsetY = new System.Windows.Forms.NumericUpDown();
            this.defaultOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.offsetListBox = new System.Windows.Forms.ListBox();
            this.defaultChkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rmvAnimationBtn = new System.Windows.Forms.Button();
            this.addAnimationBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openTileSheetDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.frameHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWidthBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TileSheet:";
            // 
            // tileSheetFile
            // 
            this.tileSheetFile.Location = new System.Drawing.Point(96, 6);
            this.tileSheetFile.Name = "tileSheetFile";
            this.tileSheetFile.ReadOnly = true;
            this.tileSheetFile.Size = new System.Drawing.Size(166, 20);
            this.tileSheetFile.TabIndex = 1;
            // 
            // openTileSheetBtn
            // 
            this.openTileSheetBtn.Location = new System.Drawing.Point(268, 4);
            this.openTileSheetBtn.Name = "openTileSheetBtn";
            this.openTileSheetBtn.Size = new System.Drawing.Size(127, 23);
            this.openTileSheetBtn.TabIndex = 2;
            this.openTileSheetBtn.Text = "Open TileSheet";
            this.openTileSheetBtn.UseVisualStyleBackColor = true;
            this.openTileSheetBtn.Click += new System.EventHandler(this.openTileSheetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame Width";
            // 
            // frameHeightBox
            // 
            this.frameHeightBox.Location = new System.Drawing.Point(319, 36);
            this.frameHeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frameHeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameHeightBox.Name = "frameHeightBox";
            this.frameHeightBox.Size = new System.Drawing.Size(76, 20);
            this.frameHeightBox.TabIndex = 5;
            this.frameHeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameHeightBox.ValueChanged += new System.EventHandler(this.frameHeightBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frame Height";
            // 
            // frameWidthBox
            // 
            this.frameWidthBox.Location = new System.Drawing.Point(96, 36);
            this.frameWidthBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frameWidthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameWidthBox.Name = "frameWidthBox";
            this.frameWidthBox.Size = new System.Drawing.Size(76, 20);
            this.frameWidthBox.TabIndex = 7;
            this.frameWidthBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameWidthBox.ValueChanged += new System.EventHandler(this.frameWidthBox_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.defaultOffsetY);
            this.groupBox1.Controls.Add(this.defaultOffsetX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Frame Offset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // defaultOffsetY
            // 
            this.defaultOffsetY.Location = new System.Drawing.Point(303, 18);
            this.defaultOffsetY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.defaultOffsetY.Name = "defaultOffsetY";
            this.defaultOffsetY.Size = new System.Drawing.Size(76, 20);
            this.defaultOffsetY.TabIndex = 10;
            // 
            // defaultOffsetX
            // 
            this.defaultOffsetX.Location = new System.Drawing.Point(80, 18);
            this.defaultOffsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.defaultOffsetX.Name = "defaultOffsetX";
            this.defaultOffsetX.Size = new System.Drawing.Size(76, 20);
            this.defaultOffsetX.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // offsetListBox
            // 
            this.offsetListBox.FormattingEnabled = true;
            this.offsetListBox.Location = new System.Drawing.Point(10, 19);
            this.offsetListBox.Name = "offsetListBox";
            this.offsetListBox.Size = new System.Drawing.Size(369, 108);
            this.offsetListBox.TabIndex = 9;
            this.offsetListBox.SelectedIndexChanged += new System.EventHandler(this.offsetListBox_SelectedIndexChanged);
            // 
            // defaultChkBox
            // 
            this.defaultChkBox.AutoSize = true;
            this.defaultChkBox.Enabled = false;
            this.defaultChkBox.Location = new System.Drawing.Point(20, 133);
            this.defaultChkBox.Name = "defaultChkBox";
            this.defaultChkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.defaultChkBox.Size = new System.Drawing.Size(60, 17);
            this.defaultChkBox.TabIndex = 11;
            this.defaultChkBox.Text = "Default";
            this.defaultChkBox.UseVisualStyleBackColor = true;
            this.defaultChkBox.CheckedChanged += new System.EventHandler(this.defaultChkBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // offsetY
            // 
            this.offsetY.Enabled = false;
            this.offsetY.Location = new System.Drawing.Point(313, 133);
            this.offsetY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(57, 20);
            this.offsetY.TabIndex = 14;
            // 
            // offsetX
            // 
            this.offsetX.Enabled = false;
            this.offsetX.Location = new System.Drawing.Point(175, 132);
            this.offsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(57, 20);
            this.offsetX.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.offsetListBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.defaultChkBox);
            this.groupBox2.Controls.Add(this.offsetX);
            this.groupBox2.Controls.Add(this.offsetY);
            this.groupBox2.Location = new System.Drawing.Point(16, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 165);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame Offsets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rmvAnimationBtn);
            this.groupBox3.Controls.Add(this.addAnimationBtn);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(16, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 194);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animations";
            // 
            // rmvAnimationBtn
            // 
            this.rmvAnimationBtn.Enabled = false;
            this.rmvAnimationBtn.Location = new System.Drawing.Point(241, 161);
            this.rmvAnimationBtn.Name = "rmvAnimationBtn";
            this.rmvAnimationBtn.Size = new System.Drawing.Size(137, 23);
            this.rmvAnimationBtn.TabIndex = 2;
            this.rmvAnimationBtn.Text = "Remove";
            this.rmvAnimationBtn.UseVisualStyleBackColor = true;
            // 
            // addAnimationBtn
            // 
            this.addAnimationBtn.Location = new System.Drawing.Point(10, 161);
            this.addAnimationBtn.Name = "addAnimationBtn";
            this.addAnimationBtn.Size = new System.Drawing.Size(144, 23);
            this.addAnimationBtn.TabIndex = 1;
            this.addAnimationBtn.Text = "Add";
            this.addAnimationBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(369, 121);
            this.listBox1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(136, 503);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(166, 23);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openTileSheetDialog
            // 
            this.openTileSheetDialog.DefaultExt = "xnb";
            this.openTileSheetDialog.FileName = "openFileDialog1";
            this.openTileSheetDialog.Filter = "Image File|*.png";
            this.openTileSheetDialog.Title = "Open TileSheet";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 535);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frameWidthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frameHeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openTileSheetBtn);
            this.Controls.Add(this.tileSheetFile);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "TileSheet Editor";
            ((System.ComponentModel.ISupportInitialize)(this.frameHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWidthBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tileSheetFile;
        private System.Windows.Forms.Button openTileSheetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown frameHeightBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown frameWidthBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown defaultOffsetY;
        private System.Windows.Forms.NumericUpDown defaultOffsetX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox offsetListBox;
        private System.Windows.Forms.CheckBox defaultChkBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rmvAnimationBtn;
        private System.Windows.Forms.Button addAnimationBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.OpenFileDialog openTileSheetDialog;
    }
}

