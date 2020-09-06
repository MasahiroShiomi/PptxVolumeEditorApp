namespace PptxVolumeEditorApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonModify = new System.Windows.Forms.Button();
            this.checkBoxVolume = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOrgFileName = new System.Windows.Forms.Label();
            this.labelModifiedFileName = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonUnmuteAll = new System.Windows.Forms.RadioButton();
            this.radioButtonMuteAll = new System.Windows.Forms.RadioButton();
            this.radioButtonNoChangeMute = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(80, 207);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // checkBoxVolume
            // 
            this.checkBoxVolume.AutoSize = true;
            this.checkBoxVolume.Location = new System.Drawing.Point(6, 19);
            this.checkBoxVolume.Name = "checkBoxVolume";
            this.checkBoxVolume.Size = new System.Drawing.Size(154, 16);
            this.checkBoxVolume.TabIndex = 2;
            this.checkBoxVolume.Text = "Override volume (0~100%)";
            this.checkBoxVolume.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "FileName: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "FileName (modified): ";
            // 
            // labelOrgFileName
            // 
            this.labelOrgFileName.AutoSize = true;
            this.labelOrgFileName.Location = new System.Drawing.Point(14, 26);
            this.labelOrgFileName.Name = "labelOrgFileName";
            this.labelOrgFileName.Size = new System.Drawing.Size(0, 12);
            this.labelOrgFileName.TabIndex = 5;
            // 
            // labelModifiedFileName
            // 
            this.labelModifiedFileName.AutoSize = true;
            this.labelModifiedFileName.Location = new System.Drawing.Point(14, 66);
            this.labelModifiedFileName.Name = "labelModifiedFileName";
            this.labelModifiedFileName.Size = new System.Drawing.Size(0, 12);
            this.labelModifiedFileName.TabIndex = 6;
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Location = new System.Drawing.Point(166, 18);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(42, 19);
            this.numericUpDownVolume.TabIndex = 7;
            this.numericUpDownVolume.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxVolume);
            this.groupBox1.Controls.Add(this.numericUpDownVolume);
            this.groupBox1.Location = new System.Drawing.Point(14, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonUnmuteAll);
            this.groupBox2.Controls.Add(this.radioButtonMuteAll);
            this.groupBox2.Controls.Add(this.radioButtonNoChangeMute);
            this.groupBox2.Location = new System.Drawing.Point(14, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 46);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mute";
            // 
            // radioButtonUnmuteAll
            // 
            this.radioButtonUnmuteAll.AutoSize = true;
            this.radioButtonUnmuteAll.Location = new System.Drawing.Point(162, 18);
            this.radioButtonUnmuteAll.Name = "radioButtonUnmuteAll";
            this.radioButtonUnmuteAll.Size = new System.Drawing.Size(62, 16);
            this.radioButtonUnmuteAll.TabIndex = 12;
            this.radioButtonUnmuteAll.Text = "Unmute";
            this.radioButtonUnmuteAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonMuteAll
            // 
            this.radioButtonMuteAll.AutoSize = true;
            this.radioButtonMuteAll.Location = new System.Drawing.Point(93, 18);
            this.radioButtonMuteAll.Name = "radioButtonMuteAll";
            this.radioButtonMuteAll.Size = new System.Drawing.Size(48, 16);
            this.radioButtonMuteAll.TabIndex = 11;
            this.radioButtonMuteAll.Text = "Mute";
            this.radioButtonMuteAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoChangeMute
            // 
            this.radioButtonNoChangeMute.AutoSize = true;
            this.radioButtonNoChangeMute.Checked = true;
            this.radioButtonNoChangeMute.Location = new System.Drawing.Point(6, 18);
            this.radioButtonNoChangeMute.Name = "radioButtonNoChangeMute";
            this.radioButtonNoChangeMute.Size = new System.Drawing.Size(77, 16);
            this.radioButtonNoChangeMute.TabIndex = 10;
            this.radioButtonNoChangeMute.TabStop = true;
            this.radioButtonNoChangeMute.Text = "No change";
            this.radioButtonNoChangeMute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelModifiedFileName);
            this.Controls.Add(this.labelOrgFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModify);
            this.Name = "Form1";
            this.Text = "PptxVolumeEditor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.CheckBox checkBoxVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOrgFileName;
        private System.Windows.Forms.Label labelModifiedFileName;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonUnmuteAll;
        private System.Windows.Forms.RadioButton radioButtonMuteAll;
        private System.Windows.Forms.RadioButton radioButtonNoChangeMute;
    }
}

