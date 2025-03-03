namespace Source_Engine_x86_Games_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_about = new System.Windows.Forms.Button();
            this.button_hl2mp = new System.Windows.Forms.Button();
            this.button_tf2 = new System.Windows.Forms.Button();
            this.button_css = new System.Windows.Forms.Button();
            this.button_dod = new System.Windows.Forms.Button();
            this.Main_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_about
            // 
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Image = ((System.Drawing.Image)(resources.GetObject("button_about.Image")));
            this.button_about.Location = new System.Drawing.Point(432, 289);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(78, 26);
            this.button_about.TabIndex = 0;
            this.button_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_hl2mp
            // 
            this.button_hl2mp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hl2mp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_hl2mp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hl2mp.Image = ((System.Drawing.Image)(resources.GetObject("button_hl2mp.Image")));
            this.button_hl2mp.Location = new System.Drawing.Point(59, 113);
            this.button_hl2mp.Name = "button_hl2mp";
            this.button_hl2mp.Size = new System.Drawing.Size(93, 93);
            this.button_hl2mp.TabIndex = 1;
            this.button_hl2mp.UseVisualStyleBackColor = true;
            this.button_hl2mp.Click += new System.EventHandler(this.button_hl2mp_Click);
            // 
            // button_tf2
            // 
            this.button_tf2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tf2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_tf2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tf2.Image = ((System.Drawing.Image)(resources.GetObject("button_tf2.Image")));
            this.button_tf2.Location = new System.Drawing.Point(257, 113);
            this.button_tf2.Name = "button_tf2";
            this.button_tf2.Size = new System.Drawing.Size(93, 93);
            this.button_tf2.TabIndex = 2;
            this.button_tf2.UseVisualStyleBackColor = true;
            this.button_tf2.Click += new System.EventHandler(this.button_tf2_Click);
            // 
            // button_css
            // 
            this.button_css.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_css.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_css.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_css.Image = ((System.Drawing.Image)(resources.GetObject("button_css.Image")));
            this.button_css.Location = new System.Drawing.Point(158, 113);
            this.button_css.Name = "button_css";
            this.button_css.Size = new System.Drawing.Size(93, 93);
            this.button_css.TabIndex = 3;
            this.button_css.UseVisualStyleBackColor = true;
            this.button_css.Click += new System.EventHandler(this.button_css_Click);
            // 
            // button_dod
            // 
            this.button_dod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_dod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_dod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dod.Image = ((System.Drawing.Image)(resources.GetObject("button_dod.Image")));
            this.button_dod.Location = new System.Drawing.Point(356, 113);
            this.button_dod.Name = "button_dod";
            this.button_dod.Size = new System.Drawing.Size(93, 93);
            this.button_dod.TabIndex = 4;
            this.button_dod.UseVisualStyleBackColor = true;
            this.button_dod.Click += new System.EventHandler(this.button_dod_Click);
            // 
            // Main_Label
            // 
            this.Main_Label.AutoSize = true;
            this.Main_Label.BackColor = System.Drawing.Color.Transparent;
            this.Main_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Main_Label.Location = new System.Drawing.Point(162, 35);
            this.Main_Label.Name = "Main_Label";
            this.Main_Label.Size = new System.Drawing.Size(205, 30);
            this.Main_Label.TabIndex = 5;
            this.Main_Label.Text = "Source x86 Launcher";
            this.Main_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(511, 318);
            this.Controls.Add(this.Main_Label);
            this.Controls.Add(this.button_dod);
            this.Controls.Add(this.button_css);
            this.Controls.Add(this.button_tf2);
            this.Controls.Add(this.button_hl2mp);
            this.Controls.Add(this.button_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Source x86 Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_hl2mp;
        private System.Windows.Forms.Button button_tf2;
        private System.Windows.Forms.Button button_css;
        private System.Windows.Forms.Button button_dod;
        private System.Windows.Forms.Label Main_Label;
    }
}

