namespace WachtrijApp
{
    partial class FormWachtrij
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWachtrij));
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelWachttijd = new System.Windows.Forms.Label();
            this.labelWachttijdMelding = new System.Windows.Forms.Label();
            this.AttractieLogo = new System.Windows.Forms.PictureBox();
            this.labelKar2 = new System.Windows.Forms.Label();
            this.labelKar1 = new System.Windows.Forms.Label();
            this.labelKar3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.BackColor = System.Drawing.Color.Transparent;
            this.labelTitel.Font = new System.Drawing.Font("Orbitron", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(14, 28);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(196, 29);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "DEBUG HERO";
            this.labelTitel.Click += new System.EventHandler(this.labelTitel_Click);
            // 
            // labelWachttijd
            // 
            this.labelWachttijd.AutoSize = true;
            this.labelWachttijd.BackColor = System.Drawing.Color.Transparent;
            this.labelWachttijd.Font = new System.Drawing.Font("Orbitron", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachttijd.Location = new System.Drawing.Point(14, 189);
            this.labelWachttijd.Name = "labelWachttijd";
            this.labelWachttijd.Size = new System.Drawing.Size(120, 25);
            this.labelWachttijd.TabIndex = 4;
            this.labelWachttijd.Text = "Wachttijd";
            this.labelWachttijd.Click += new System.EventHandler(this.labelWachttijd_Click);
            // 
            // labelWachttijdMelding
            // 
            this.labelWachttijdMelding.AutoSize = true;
            this.labelWachttijdMelding.BackColor = System.Drawing.Color.Transparent;
            this.labelWachttijdMelding.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelWachttijdMelding.Location = new System.Drawing.Point(32, 237);
            this.labelWachttijdMelding.Name = "labelWachttijdMelding";
            this.labelWachttijdMelding.Size = new System.Drawing.Size(102, 27);
            this.labelWachttijdMelding.TabIndex = 5;
            this.labelWachttijdMelding.Text = "0 minuten";
            this.labelWachttijdMelding.Click += new System.EventHandler(this.labelWachttijdMelding_Click);
            // 
            // AttractieLogo
            // 
            this.AttractieLogo.BackColor = System.Drawing.Color.Transparent;
            this.AttractieLogo.ErrorImage = null;
            this.AttractieLogo.Image = ((System.Drawing.Image)(resources.GetObject("AttractieLogo.Image")));
            this.AttractieLogo.Location = new System.Drawing.Point(312, 174);
            this.AttractieLogo.Name = "AttractieLogo";
            this.AttractieLogo.Size = new System.Drawing.Size(211, 212);
            this.AttractieLogo.TabIndex = 6;
            this.AttractieLogo.TabStop = false;
            this.AttractieLogo.Click += new System.EventHandler(this.AttractieLogo_Click);
            // 
            // labelKar2
            // 
            this.labelKar2.AutoSize = true;
            this.labelKar2.BackColor = System.Drawing.Color.Transparent;
            this.labelKar2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelKar2.Location = new System.Drawing.Point(29, 87);
            this.labelKar2.Name = "labelKar2";
            this.labelKar2.Size = new System.Drawing.Size(104, 27);
            this.labelKar2.TabIndex = 8;
            this.labelKar2.Text = "Kar 2: ...";
            this.labelKar2.Click += new System.EventHandler(this.labelKar2_Click);
            // 
            // labelKar1
            // 
            this.labelKar1.AutoSize = true;
            this.labelKar1.BackColor = System.Drawing.Color.Transparent;
            this.labelKar1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKar1.Location = new System.Drawing.Point(30, 60);
            this.labelKar1.Name = "labelKar1";
            this.labelKar1.Size = new System.Drawing.Size(104, 27);
            this.labelKar1.TabIndex = 9;
            this.labelKar1.Text = "Kar 1: ...";
            this.labelKar1.Click += new System.EventHandler(this.labelKar1_Click);
            // 
            // labelKar3
            // 
            this.labelKar3.AutoSize = true;
            this.labelKar3.BackColor = System.Drawing.Color.Transparent;
            this.labelKar3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelKar3.Location = new System.Drawing.Point(30, 114);
            this.labelKar3.Name = "labelKar3";
            this.labelKar3.Size = new System.Drawing.Size(104, 27);
            this.labelKar3.TabIndex = 10;
            this.labelKar3.Text = "Kar 3: ...";
            this.labelKar3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Orbitron", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(312, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Orbitron", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(312, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.AttractieLogo_Click);
            // 
            // FormWachtrij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelKar3);
            this.Controls.Add(this.labelKar1);
            this.Controls.Add(this.labelKar2);
            this.Controls.Add(this.AttractieLogo);
            this.Controls.Add(this.labelWachttijdMelding);
            this.Controls.Add(this.labelWachttijd);
            this.Controls.Add(this.labelTitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWachtrij";
            this.Text = "Debug Hero";
            this.Load += new System.EventHandler(this.FormWachtrij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttractieLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelWachttijd;
        private System.Windows.Forms.Label labelWachttijdMelding;
        private System.Windows.Forms.PictureBox AttractieLogo;
        private System.Windows.Forms.Label labelKar2;
        private System.Windows.Forms.Label labelKar1;
        private System.Windows.Forms.Label labelKar3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

