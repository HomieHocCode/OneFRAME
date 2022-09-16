namespace OneFRAME.Tools
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDestCode = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cmdGen = new System.Windows.Forms.Button();
            this.txtFieldTypes = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxDestCode);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(625, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code Process";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxDestCode
            // 
            this.textBoxDestCode.Location = new System.Drawing.Point(4, 197);
            this.textBoxDestCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDestCode.Multiline = true;
            this.textBoxDestCode.Name = "textBoxDestCode";
            this.textBoxDestCode.ReadOnly = true;
            this.textBoxDestCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDestCode.Size = new System.Drawing.Size(621, 211);
            this.textBoxDestCode.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(4, 4);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(621, 181);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtClass);
            this.tabPage2.Controls.Add(this.cmdGen);
            this.tabPage2.Controls.Add(this.txtFieldTypes);
            this.tabPage2.Controls.Add(this.txtKey);
            this.tabPage2.Controls.Add(this.txtTableName);
            this.tabPage2.Controls.Add(this.txtFields);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(625, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gen class";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Field Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Class:";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(151, 10);
            this.txtClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClass.Multiline = true;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(465, 23);
            this.txtClass.TabIndex = 5;
            this.txtClass.Text = "Currency";
            // 
            // cmdGen
            // 
            this.cmdGen.Location = new System.Drawing.Point(151, 226);
            this.cmdGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdGen.Name = "cmdGen";
            this.cmdGen.Size = new System.Drawing.Size(115, 32);
            this.cmdGen.TabIndex = 4;
            this.cmdGen.Text = "Generate code";
            this.cmdGen.UseVisualStyleBackColor = true;
            this.cmdGen.Click += new System.EventHandler(this.cmdGen_Click);
            // 
            // txtFieldTypes
            // 
            this.txtFieldTypes.Location = new System.Drawing.Point(151, 159);
            this.txtFieldTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFieldTypes.Multiline = true;
            this.txtFieldTypes.Name = "txtFieldTypes";
            this.txtFieldTypes.Size = new System.Drawing.Size(465, 55);
            this.txtFieldTypes.TabIndex = 3;
            this.txtFieldTypes.Text = "string;string;int";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(151, 61);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(465, 24);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = "CurrencyId";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(151, 36);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(465, 23);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.Text = "TableCurrency";
            // 
            // txtFields
            // 
            this.txtFields.Location = new System.Drawing.Point(151, 96);
            this.txtFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.Size = new System.Drawing.Size(465, 55);
            this.txtFields.TabIndex = 0;
            this.txtFields.Text = "CurrencyCode;CurrencyName;SortIndex";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 448);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Tools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxDestCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.Button cmdGen;
        private System.Windows.Forms.TextBox txtFieldTypes;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
    }
}

