namespace Unity_GUID_Remapper_hxrmn
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkbox_DeleteMetaFiles = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkbox_fixPrefabs = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_fixScenes = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Project Directory";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "current project path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "none";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(57, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Fix TextMeshPro UGUI objects";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(57, 130);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(241, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Remove ALL Unity Package Manager Scripts";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkbox_DeleteMetaFiles
            // 
            this.checkbox_DeleteMetaFiles.AutoSize = true;
            this.checkbox_DeleteMetaFiles.Checked = true;
            this.checkbox_DeleteMetaFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_DeleteMetaFiles.Location = new System.Drawing.Point(57, 153);
            this.checkbox_DeleteMetaFiles.Name = "checkbox_DeleteMetaFiles";
            this.checkbox_DeleteMetaFiles.Size = new System.Drawing.Size(175, 17);
            this.checkbox_DeleteMetaFiles.TabIndex = 5;
            this.checkbox_DeleteMetaFiles.Text = "Delete Meta Files for fixed items";
            this.checkbox_DeleteMetaFiles.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(12, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remap TMPro UGUI\'s";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkbox_fixPrefabs
            // 
            this.checkbox_fixPrefabs.AutoSize = true;
            this.checkbox_fixPrefabs.Checked = true;
            this.checkbox_fixPrefabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_fixPrefabs.Location = new System.Drawing.Point(57, 176);
            this.checkbox_fixPrefabs.Name = "checkbox_fixPrefabs";
            this.checkbox_fixPrefabs.Size = new System.Drawing.Size(78, 17);
            this.checkbox_fixPrefabs.TabIndex = 7;
            this.checkbox_fixPrefabs.Text = "Fix Prefabs";
            this.checkbox_fixPrefabs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "shitty guid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "none";
            // 
            // checkbox_fixScenes
            // 
            this.checkbox_fixScenes.AutoSize = true;
            this.checkbox_fixScenes.Checked = true;
            this.checkbox_fixScenes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_fixScenes.Location = new System.Drawing.Point(57, 199);
            this.checkbox_fixScenes.Name = "checkbox_fixScenes";
            this.checkbox_fixScenes.Size = new System.Drawing.Size(78, 17);
            this.checkbox_fixScenes.TabIndex = 10;
            this.checkbox_fixScenes.Text = "Fix Scenes";
            this.checkbox_fixScenes.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(47, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Advanced";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(341, 328);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkbox_fixScenes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkbox_fixPrefabs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkbox_DeleteMetaFiles);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Unity GUID Remapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkbox_DeleteMetaFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkbox_fixPrefabs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbox_fixScenes;
        private System.Windows.Forms.Button button3;
    }
}

