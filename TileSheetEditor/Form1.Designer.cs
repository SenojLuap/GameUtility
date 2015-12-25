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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rmvAnimationBtn = new System.Windows.Forms.Button();
            this.addAnimationBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openTileSheetDialog = new System.Windows.Forms.OpenFileDialog();
            this.newTileSheetBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.imageFile = new System.Windows.Forms.TextBox();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.defaultChkBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.offsetListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.createTileSheetBtn = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.frameHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWidthBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TileSheet:";
            // 
            // tileSheetFile
            // 
            this.tileSheetFile.Location = new System.Drawing.Point(256, 14);
            this.tileSheetFile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tileSheetFile.Name = "tileSheetFile";
            this.tileSheetFile.ReadOnly = true;
            this.tileSheetFile.Size = new System.Drawing.Size(436, 38);
            this.tileSheetFile.TabIndex = 1;
            // 
            // openTileSheetBtn
            // 
            this.openTileSheetBtn.Location = new System.Drawing.Point(715, 10);
            this.openTileSheetBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.openTileSheetBtn.Name = "openTileSheetBtn";
            this.openTileSheetBtn.Size = new System.Drawing.Size(119, 55);
            this.openTileSheetBtn.TabIndex = 2;
            this.openTileSheetBtn.Text = "Open";
            this.openTileSheetBtn.UseVisualStyleBackColor = true;
            this.openTileSheetBtn.Click += new System.EventHandler(this.openTileSheetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frame Width";
            // 
            // frameHeightBox
            // 
            this.frameHeightBox.Location = new System.Drawing.Point(851, 156);
            this.frameHeightBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            this.frameHeightBox.Size = new System.Drawing.Size(203, 38);
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
            this.label3.Location = new System.Drawing.Point(648, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frame Height";
            // 
            // frameWidthBox
            // 
            this.frameWidthBox.Location = new System.Drawing.Point(256, 156);
            this.frameWidthBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
            this.frameWidthBox.Size = new System.Drawing.Size(203, 38);
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
            this.groupBox1.Location = new System.Drawing.Point(43, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1035, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Frame Offset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // defaultOffsetY
            // 
            this.defaultOffsetY.Location = new System.Drawing.Point(808, 43);
            this.defaultOffsetY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.defaultOffsetY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.defaultOffsetY.Name = "defaultOffsetY";
            this.defaultOffsetY.Size = new System.Drawing.Size(203, 38);
            this.defaultOffsetY.TabIndex = 10;
            this.defaultOffsetY.ValueChanged += new System.EventHandler(this.defaultOffset_ValueChanged);
            // 
            // defaultOffsetX
            // 
            this.defaultOffsetX.Location = new System.Drawing.Point(213, 43);
            this.defaultOffsetX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.defaultOffsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.defaultOffsetX.Name = "defaultOffsetX";
            this.defaultOffsetX.Size = new System.Drawing.Size(203, 38);
            this.defaultOffsetX.TabIndex = 9;
            this.defaultOffsetX.ValueChanged += new System.EventHandler(this.defaultOffset_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rmvAnimationBtn);
            this.groupBox3.Controls.Add(this.addAnimationBtn);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(43, 793);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(1035, 463);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Animations";
            // 
            // rmvAnimationBtn
            // 
            this.rmvAnimationBtn.Enabled = false;
            this.rmvAnimationBtn.Location = new System.Drawing.Point(643, 384);
            this.rmvAnimationBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rmvAnimationBtn.Name = "rmvAnimationBtn";
            this.rmvAnimationBtn.Size = new System.Drawing.Size(365, 55);
            this.rmvAnimationBtn.TabIndex = 2;
            this.rmvAnimationBtn.Text = "Remove";
            this.rmvAnimationBtn.UseVisualStyleBackColor = true;
            // 
            // addAnimationBtn
            // 
            this.addAnimationBtn.Location = new System.Drawing.Point(27, 384);
            this.addAnimationBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addAnimationBtn.Name = "addAnimationBtn";
            this.addAnimationBtn.Size = new System.Drawing.Size(384, 55);
            this.addAnimationBtn.TabIndex = 1;
            this.addAnimationBtn.Text = "Add";
            this.addAnimationBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(27, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(977, 283);
            this.listBox1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(363, 1269);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(443, 55);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openTileSheetDialog
            // 
            this.openTileSheetDialog.DefaultExt = "xnb";
            this.openTileSheetDialog.FileName = "openFileDialog1";
            this.openTileSheetDialog.Filter = "GU Tilesheet|*.jts";
            this.openTileSheetDialog.Title = "Open TileSheet";
            // 
            // newTileSheetBtn
            // 
            this.newTileSheetBtn.Location = new System.Drawing.Point(851, 10);
            this.newTileSheetBtn.Name = "newTileSheetBtn";
            this.newTileSheetBtn.Size = new System.Drawing.Size(227, 55);
            this.newTileSheetBtn.TabIndex = 19;
            this.newTileSheetBtn.Text = "New";
            this.newTileSheetBtn.UseVisualStyleBackColor = true;
            this.newTileSheetBtn.Click += new System.EventHandler(this.newTileSheetBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Image";
            // 
            // imageFile
            // 
            this.imageFile.Location = new System.Drawing.Point(256, 85);
            this.imageFile.Name = "imageFile";
            this.imageFile.ReadOnly = true;
            this.imageFile.Size = new System.Drawing.Size(436, 38);
            this.imageFile.TabIndex = 21;
            // 
            // offsetY
            // 
            this.offsetY.Enabled = false;
            this.offsetY.Location = new System.Drawing.Point(835, 317);
            this.offsetY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.offsetY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(152, 38);
            this.offsetY.TabIndex = 14;
            // 
            // offsetX
            // 
            this.offsetX.Enabled = false;
            this.offsetX.Location = new System.Drawing.Point(467, 315);
            this.offsetX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.offsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(152, 38);
            this.offsetX.TabIndex = 13;
            // 
            // defaultChkBox
            // 
            this.defaultChkBox.AutoSize = true;
            this.defaultChkBox.Enabled = false;
            this.defaultChkBox.Location = new System.Drawing.Point(53, 317);
            this.defaultChkBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.defaultChkBox.Name = "defaultChkBox";
            this.defaultChkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.defaultChkBox.Size = new System.Drawing.Size(144, 36);
            this.defaultChkBox.TabIndex = 11;
            this.defaultChkBox.Text = "Default";
            this.defaultChkBox.UseVisualStyleBackColor = true;
            this.defaultChkBox.CheckedChanged += new System.EventHandler(this.defaultChkBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // offsetListBox
            // 
            this.offsetListBox.FormattingEnabled = true;
            this.offsetListBox.ItemHeight = 31;
            this.offsetListBox.Location = new System.Drawing.Point(27, 45);
            this.offsetListBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.offsetListBox.Name = "offsetListBox";
            this.offsetListBox.Size = new System.Drawing.Size(977, 252);
            this.offsetListBox.TabIndex = 9;
            this.offsetListBox.SelectedIndexChanged += new System.EventHandler(this.offsetListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.offsetListBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.defaultChkBox);
            this.groupBox2.Controls.Add(this.offsetX);
            this.groupBox2.Controls.Add(this.offsetY);
            this.groupBox2.Location = new System.Drawing.Point(43, 382);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1035, 393);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame Offsets";
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            this.openImageDialog.Filter = "PNG Image|*.png";
            this.openImageDialog.Title = "Open TileSheet Image";
            // 
            // createTileSheetBtn
            // 
            this.createTileSheetBtn.Filter = "GU TileSheet|*.jts";
            this.createTileSheetBtn.Title = "Create TileSheet";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 1476);
            this.Controls.Add(this.imageFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newTileSheetBtn);
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
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "TileSheet Editor";
            ((System.ComponentModel.ISupportInitialize)(this.frameHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameWidthBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOffsetX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rmvAnimationBtn;
        private System.Windows.Forms.Button addAnimationBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.OpenFileDialog openTileSheetDialog;
        private System.Windows.Forms.Button newTileSheetBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox imageFile;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.CheckBox defaultChkBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox offsetListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog createTileSheetBtn;
    }
}

