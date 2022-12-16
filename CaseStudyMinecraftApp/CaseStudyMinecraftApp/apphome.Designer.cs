namespace CaseStudyMinecraftApp
{
    partial class apphome
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
            this.titeltekstlabel = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.uitlegtekstlabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titeltekstlabel
            // 
            this.titeltekstlabel.AutoSize = true;
            this.titeltekstlabel.Location = new System.Drawing.Point(223, 9);
            this.titeltekstlabel.Name = "titeltekstlabel";
            this.titeltekstlabel.Size = new System.Drawing.Size(570, 16);
            this.titeltekstlabel.TabIndex = 0;
            this.titeltekstlabel.Text = "Welkom in de kleine Minecraft-gids app! Deze app bevat alle informatie over het s" +
    "pel Minecraft!";
            this.titeltekstlabel.Click += new System.EventHandler(this.titletextlable_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Items.AddRange(new object[] {
            "Blokken",
            "Biotopen",
            "Speciale Blokken",
            "Gereedschappen",
            "Mobs"});
            this.listbox.Location = new System.Drawing.Point(24, 104);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(394, 356);
            this.listbox.TabIndex = 1;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // uitlegtekstlabel
            // 
            this.uitlegtekstlabel.AutoSize = true;
            this.uitlegtekstlabel.Location = new System.Drawing.Point(55, 82);
            this.uitlegtekstlabel.Name = "uitlegtekstlabel";
            this.uitlegtekstlabel.Size = new System.Drawing.Size(306, 16);
            this.uitlegtekstlabel.TabIndex = 2;
            this.uitlegtekstlabel.Text = "Selecteer de categorie waarover u meer wil weten:";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(464, 474);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // apphome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 516);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.uitlegtekstlabel);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.titeltekstlabel);
            this.Name = "apphome";
            this.Text = "apphome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titeltekstlabel;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label uitlegtekstlabel;
        private System.Windows.Forms.Button exitbutton;
    }
}

