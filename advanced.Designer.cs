namespace Unity_GUID_Remapper_hxrmn
{
    partial class advanced
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbox_fixScenes = new System.Windows.Forms.CheckBox();
            this.checkbox_fixPrefabs = new System.Windows.Forms.CheckBox();
            this.checkbox_DeleteMetaFiles = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkbox_FixScriptableObjects = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(11, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Select Bad Class File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bad GUID To Be Replaced:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Good GUID To Use Instead";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(11, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select Good Class File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox_fixScenes
            // 
            this.checkbox_fixScenes.AutoSize = true;
            this.checkbox_fixScenes.Checked = true;
            this.checkbox_fixScenes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_fixScenes.Location = new System.Drawing.Point(135, 203);
            this.checkbox_fixScenes.Name = "checkbox_fixScenes";
            this.checkbox_fixScenes.Size = new System.Drawing.Size(78, 17);
            this.checkbox_fixScenes.TabIndex = 16;
            this.checkbox_fixScenes.Text = "Fix Scenes";
            this.checkbox_fixScenes.UseVisualStyleBackColor = true;
            // 
            // checkbox_fixPrefabs
            // 
            this.checkbox_fixPrefabs.AutoSize = true;
            this.checkbox_fixPrefabs.Checked = true;
            this.checkbox_fixPrefabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_fixPrefabs.Location = new System.Drawing.Point(135, 180);
            this.checkbox_fixPrefabs.Name = "checkbox_fixPrefabs";
            this.checkbox_fixPrefabs.Size = new System.Drawing.Size(78, 17);
            this.checkbox_fixPrefabs.TabIndex = 15;
            this.checkbox_fixPrefabs.Text = "Fix Prefabs";
            this.checkbox_fixPrefabs.UseVisualStyleBackColor = true;
            // 
            // checkbox_DeleteMetaFiles
            // 
            this.checkbox_DeleteMetaFiles.AutoSize = true;
            this.checkbox_DeleteMetaFiles.Checked = true;
            this.checkbox_DeleteMetaFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_DeleteMetaFiles.Location = new System.Drawing.Point(418, 203);
            this.checkbox_DeleteMetaFiles.Name = "checkbox_DeleteMetaFiles";
            this.checkbox_DeleteMetaFiles.Size = new System.Drawing.Size(175, 17);
            this.checkbox_DeleteMetaFiles.TabIndex = 14;
            this.checkbox_DeleteMetaFiles.Text = "Delete Meta Files for fixed items";
            this.checkbox_DeleteMetaFiles.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(418, 180);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(241, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Remove ALL Unity Package Manager Scripts";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(213, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 46);
            this.button3.TabIndex = 17;
            this.button3.Text = "Replace GUID\'s";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 323);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(776, 93);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Log:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(11, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(317, 46);
            this.button4.TabIndex = 20;
            this.button4.Text = "Select Root Game Directory";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Game Directory:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(354, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkbox_FixScriptableObjects
            // 
            this.checkbox_FixScriptableObjects.AutoSize = true;
            this.checkbox_FixScriptableObjects.Checked = true;
            this.checkbox_FixScriptableObjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_FixScriptableObjects.Location = new System.Drawing.Point(135, 226);
            this.checkbox_FixScriptableObjects.Name = "checkbox_FixScriptableObjects";
            this.checkbox_FixScriptableObjects.Size = new System.Drawing.Size(200, 17);
            this.checkbox_FixScriptableObjects.TabIndex = 23;
            this.checkbox_FixScriptableObjects.Text = "Fix Scriptable Objects (may not work)";
            this.checkbox_FixScriptableObjects.UseVisualStyleBackColor = true;
            // 
            // advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkbox_FixScriptableObjects);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkbox_fixScenes);
            this.Controls.Add(this.checkbox_fixPrefabs);
            this.Controls.Add(this.checkbox_DeleteMetaFiles);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Name = "advanced";
            this.Text = "advanced";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbox_fixScenes;
        private System.Windows.Forms.CheckBox checkbox_fixPrefabs;
        private System.Windows.Forms.CheckBox checkbox_DeleteMetaFiles;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkbox_FixScriptableObjects;
    }
}