﻿namespace FirstPlugin
{
    partial class BinaryTextureImporterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryTextureImporterList));
            this.button2 = new Switch_Toolbox.Library.Forms.STButton();
            this.button1 = new Switch_Toolbox.Library.Forms.STButton();
            this.listViewCustom1 = new Switch_Toolbox.Library.Forms.ListViewCustom();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Format = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SwizzleNum = new Switch_Toolbox.Library.Forms.STNumbericUpDown();
            this.label5 = new Switch_Toolbox.Library.Forms.STLabel();
            this.tileModeCB = new Switch_Toolbox.Library.Forms.STComboBox();
            this.label4 = new Switch_Toolbox.Library.Forms.STLabel();
            this.ImgDimComb = new Switch_Toolbox.Library.Forms.STComboBox();
            this.label3 = new Switch_Toolbox.Library.Forms.STLabel();
            this.label2 = new Switch_Toolbox.Library.Forms.STLabel();
            this.label1 = new Switch_Toolbox.Library.Forms.STLabel();
            this.MipmapNum = new Switch_Toolbox.Library.Forms.STNumbericUpDown();
            this.WidthLabel = new Switch_Toolbox.Library.Forms.STLabel();
            this.HeightLabel = new Switch_Toolbox.Library.Forms.STLabel();
            this.pictureBox1 = new Switch_Toolbox.Library.Forms.PictureBoxCustom();
            this.formatComboBox = new Switch_Toolbox.Library.Forms.STComboBox();
            this.contentContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwizzleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipmapNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentContainer
            // 
            this.contentContainer.Controls.Add(this.SwizzleNum);
            this.contentContainer.Controls.Add(this.label5);
            this.contentContainer.Controls.Add(this.tileModeCB);
            this.contentContainer.Controls.Add(this.label4);
            this.contentContainer.Controls.Add(this.ImgDimComb);
            this.contentContainer.Controls.Add(this.label3);
            this.contentContainer.Controls.Add(this.label2);
            this.contentContainer.Controls.Add(this.label1);
            this.contentContainer.Controls.Add(this.MipmapNum);
            this.contentContainer.Controls.Add(this.WidthLabel);
            this.contentContainer.Controls.Add(this.HeightLabel);
            this.contentContainer.Controls.Add(this.pictureBox1);
            this.contentContainer.Controls.Add(this.formatComboBox);
            this.contentContainer.Controls.Add(this.listViewCustom1);
            this.contentContainer.Controls.Add(this.button2);
            this.contentContainer.Controls.Add(this.button1);
            this.contentContainer.Size = new System.Drawing.Size(1092, 557);
            this.contentContainer.Controls.SetChildIndex(this.button1, 0);
            this.contentContainer.Controls.SetChildIndex(this.button2, 0);
            this.contentContainer.Controls.SetChildIndex(this.listViewCustom1, 0);
            this.contentContainer.Controls.SetChildIndex(this.formatComboBox, 0);
            this.contentContainer.Controls.SetChildIndex(this.pictureBox1, 0);
            this.contentContainer.Controls.SetChildIndex(this.HeightLabel, 0);
            this.contentContainer.Controls.SetChildIndex(this.WidthLabel, 0);
            this.contentContainer.Controls.SetChildIndex(this.MipmapNum, 0);
            this.contentContainer.Controls.SetChildIndex(this.label1, 0);
            this.contentContainer.Controls.SetChildIndex(this.label2, 0);
            this.contentContainer.Controls.SetChildIndex(this.label3, 0);
            this.contentContainer.Controls.SetChildIndex(this.ImgDimComb, 0);
            this.contentContainer.Controls.SetChildIndex(this.label4, 0);
            this.contentContainer.Controls.SetChildIndex(this.tileModeCB, 0);
            this.contentContainer.Controls.SetChildIndex(this.label5, 0);
            this.contentContainer.Controls.SetChildIndex(this.SwizzleNum, 0);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1009, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(911, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewCustom1
            // 
            this.listViewCustom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewCustom1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Format});
            this.listViewCustom1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewCustom1.Location = new System.Drawing.Point(0, 25);
            this.listViewCustom1.Name = "listViewCustom1";
            this.listViewCustom1.OwnerDraw = true;
            this.listViewCustom1.Size = new System.Drawing.Size(237, 532);
            this.listViewCustom1.TabIndex = 6;
            this.listViewCustom1.UseCompatibleStateImageBehavior = false;
            this.listViewCustom1.View = System.Windows.Forms.View.Details;
            this.listViewCustom1.SelectedIndexChanged += new System.EventHandler(this.listViewCustom1_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 104;
            // 
            // Format
            // 
            this.Format.Text = "Format";
            this.Format.Width = 133;
            // 
            // SwizzleNum
            // 
            this.SwizzleNum.Location = new System.Drawing.Point(855, 175);
            this.SwizzleNum.Name = "SwizzleNum";
            this.SwizzleNum.Size = new System.Drawing.Size(130, 20);
            this.SwizzleNum.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Swizzle";
            // 
            // tileModeCB
            // 
            this.tileModeCB.BorderColor = System.Drawing.Color.Empty;
            this.tileModeCB.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.tileModeCB.ButtonColor = System.Drawing.Color.Empty;
            this.tileModeCB.FormattingEnabled = true;
            this.tileModeCB.Location = new System.Drawing.Point(855, 102);
            this.tileModeCB.Name = "tileModeCB";
            this.tileModeCB.ReadOnly = true;
            this.tileModeCB.Size = new System.Drawing.Size(233, 21);
            this.tileModeCB.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tile Mode";
            // 
            // ImgDimComb
            // 
            this.ImgDimComb.BorderColor = System.Drawing.Color.Empty;
            this.ImgDimComb.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ImgDimComb.ButtonColor = System.Drawing.Color.Empty;
            this.ImgDimComb.FormattingEnabled = true;
            this.ImgDimComb.Location = new System.Drawing.Point(853, 69);
            this.ImgDimComb.Name = "ImgDimComb";
            this.ImgDimComb.ReadOnly = true;
            this.ImgDimComb.Size = new System.Drawing.Size(233, 21);
            this.ImgDimComb.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Image Dimension";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Number MipMaps";
            // 
            // MipmapNum
            // 
            this.MipmapNum.Location = new System.Drawing.Point(855, 138);
            this.MipmapNum.Name = "MipmapNum";
            this.MipmapNum.Size = new System.Drawing.Size(130, 20);
            this.MipmapNum.TabIndex = 20;
            this.MipmapNum.ValueChanged += new System.EventHandler(this.MipmapNum_ValueChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(759, 243);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 19;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(759, 208);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 18;
            this.HeightLabel.Text = "Height";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(237, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // formatComboBox
            // 
            this.formatComboBox.BorderColor = System.Drawing.Color.Empty;
            this.formatComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.formatComboBox.ButtonColor = System.Drawing.Color.Empty;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(853, 39);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.ReadOnly = true;
            this.formatComboBox.Size = new System.Drawing.Size(233, 21);
            this.formatComboBox.TabIndex = 16;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // BinaryTextureImporterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 560);
            this.Text = "Texture Importer";
            this.Load += new System.EventHandler(this.BinaryTextureImporterList_Load);
            this.contentContainer.ResumeLayout(false);
            this.contentContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwizzleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipmapNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Switch_Toolbox.Library.Forms.STButton button2;
        private Switch_Toolbox.Library.Forms.STButton button1;
        private Switch_Toolbox.Library.Forms.ListViewCustom listViewCustom1;
        private Switch_Toolbox.Library.Forms.STNumbericUpDown SwizzleNum;
        private Switch_Toolbox.Library.Forms.STLabel label5;
        private Switch_Toolbox.Library.Forms.STComboBox tileModeCB;
        private Switch_Toolbox.Library.Forms.STLabel label4;
        private Switch_Toolbox.Library.Forms.STComboBox ImgDimComb;
        private Switch_Toolbox.Library.Forms.STLabel label3;
        private Switch_Toolbox.Library.Forms.STLabel label2;
        private Switch_Toolbox.Library.Forms.STLabel label1;
        private Switch_Toolbox.Library.Forms.STNumbericUpDown MipmapNum;
        private Switch_Toolbox.Library.Forms.STLabel WidthLabel;
        private Switch_Toolbox.Library.Forms.STLabel HeightLabel;
        private Switch_Toolbox.Library.Forms.PictureBoxCustom pictureBox1;
        private Switch_Toolbox.Library.Forms.STComboBox formatComboBox;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Format;
    }
}