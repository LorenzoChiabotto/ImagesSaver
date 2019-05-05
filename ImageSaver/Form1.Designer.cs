namespace ImageSaver
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImages = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbPNG = new System.Windows.Forms.RadioButton();
            this.rbJPG = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pbSaved = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(465, 49);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(560, 22);
            this.txtUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(465, 107);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(488, 22);
            this.txtDestino.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL Images";
            // 
            // txtImages
            // 
            this.txtImages.Location = new System.Drawing.Point(15, 29);
            this.txtImages.MaxLength = 70000;
            this.txtImages.Multiline = true;
            this.txtImages.Name = "txtImages";
            this.txtImages.Size = new System.Drawing.Size(441, 524);
            this.txtImages.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(465, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(561, 55);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(473, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "1- URL, general link to the images.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "How to use";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(473, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(574, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "2- URL Images - List of images, separated with \"enter\" that one by one complete t" +
    "he URL";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(467, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "3- Folder, the folder where the images are going to be saved";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(518, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Example: \"https://chart.googleapis.com/chart?chs=500x500&cht=qr&chl=\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(517, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 68);
            this.label9.TabIndex = 12;
            this.label9.Text = "Example:\r\nXXXXXX\r\nCCCCCC\r\nDDDDDD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(517, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Example: \"C:\\Users\\user\\Images\\Saved\\\"";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(465, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(467, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(563, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "4- Name, the name which the image will be saved. (Result: name1, name2..nameN)";
            // 
            // rbPNG
            // 
            this.rbPNG.AutoSize = true;
            this.rbPNG.Checked = true;
            this.rbPNG.Location = new System.Drawing.Point(13, 21);
            this.rbPNG.Name = "rbPNG";
            this.rbPNG.Size = new System.Drawing.Size(59, 21);
            this.rbPNG.TabIndex = 17;
            this.rbPNG.TabStop = true;
            this.rbPNG.Text = "PNG";
            this.rbPNG.UseVisualStyleBackColor = true;
            // 
            // rbJPG
            // 
            this.rbJPG.AutoSize = true;
            this.rbJPG.Location = new System.Drawing.Point(78, 21);
            this.rbJPG.Name = "rbJPG";
            this.rbJPG.Size = new System.Drawing.Size(56, 21);
            this.rbJPG.TabIndex = 18;
            this.rbJPG.Text = "JPG";
            this.rbJPG.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJPG);
            this.groupBox1.Controls.Add(this.rbPNG);
            this.groupBox1.Location = new System.Drawing.Point(634, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 51);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(960, 107);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = "Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // pbSaved
            // 
            this.pbSaved.Location = new System.Drawing.Point(462, 248);
            this.pbSaved.Name = "pbSaved";
            this.pbSaved.Size = new System.Drawing.Size(563, 23);
            this.pbSaved.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1038, 561);
            this.Controls.Add(this.pbSaved);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "ImageSaver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbPNG;
        private System.Windows.Forms.RadioButton rbJPG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ProgressBar pbSaved;
    }
}

