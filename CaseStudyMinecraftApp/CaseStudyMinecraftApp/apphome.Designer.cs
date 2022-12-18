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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apphome));
            this.titeltekstlabel = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.uitlegtekstlabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.textlabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.categorienaamlabel = new System.Windows.Forms.Label();
            this.categorienaamtextBox = new System.Windows.Forms.TextBox();
            this.naamlabel = new System.Windows.Forms.Label();
            this.naamtextBox = new System.Windows.Forms.TextBox();
            this.typelabel = new System.Windows.Forms.Label();
            this.typetextBox = new System.Windows.Forms.TextBox();
            this.biotooplabel = new System.Windows.Forms.Label();
            this.biotooptextBox = new System.Windows.Forms.TextBox();
            this.omschrijvinglabel = new System.Windows.Forms.Label();
            this.omschrijvingtextBox = new System.Windows.Forms.TextBox();
            this.voegtoebutton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(449, 82);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(397, 16);
            this.textlabel.TabIndex = 4;
            this.textlabel.Text = "Waarden toevoegen? Dat kan! Vul hieronder nieuwe gegevens in:";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(516, 104);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(23, 16);
            this.idlabel.TabIndex = 5;
            this.idlabel.Text = "ID:";
            this.idlabel.Click += new System.EventHandler(this.idlabel_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(546, 101);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 6;
            this.idtextBox.TextChanged += new System.EventHandler(this.idtextBox_TextChanged);
            // 
            // categorienaamlabel
            // 
            this.categorienaamlabel.AutoSize = true;
            this.categorienaamlabel.Location = new System.Drawing.Point(435, 126);
            this.categorienaamlabel.Name = "categorienaamlabel";
            this.categorienaamlabel.Size = new System.Drawing.Size(104, 16);
            this.categorienaamlabel.TabIndex = 7;
            this.categorienaamlabel.Text = "categorieNaam:";
            // 
            // categorienaamtextBox
            // 
            this.categorienaamtextBox.Location = new System.Drawing.Point(546, 126);
            this.categorienaamtextBox.Name = "categorienaamtextBox";
            this.categorienaamtextBox.Size = new System.Drawing.Size(100, 22);
            this.categorienaamtextBox.TabIndex = 8;
            // 
            // naamlabel
            // 
            this.naamlabel.AutoSize = true;
            this.naamlabel.Location = new System.Drawing.Point(495, 158);
            this.naamlabel.Name = "naamlabel";
            this.naamlabel.Size = new System.Drawing.Size(44, 16);
            this.naamlabel.TabIndex = 9;
            this.naamlabel.Text = "naam:";
            // 
            // naamtextBox
            // 
            this.naamtextBox.Location = new System.Drawing.Point(546, 158);
            this.naamtextBox.Name = "naamtextBox";
            this.naamtextBox.Size = new System.Drawing.Size(100, 22);
            this.naamtextBox.TabIndex = 10;
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Location = new System.Drawing.Point(503, 188);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(36, 16);
            this.typelabel.TabIndex = 11;
            this.typelabel.Text = "type:";
            // 
            // typetextBox
            // 
            this.typetextBox.Location = new System.Drawing.Point(546, 187);
            this.typetextBox.Name = "typetextBox";
            this.typetextBox.Size = new System.Drawing.Size(100, 22);
            this.typetextBox.TabIndex = 12;
            // 
            // biotooplabel
            // 
            this.biotooplabel.AutoSize = true;
            this.biotooplabel.Location = new System.Drawing.Point(484, 216);
            this.biotooplabel.Name = "biotooplabel";
            this.biotooplabel.Size = new System.Drawing.Size(56, 16);
            this.biotooplabel.TabIndex = 13;
            this.biotooplabel.Text = "biotoop:";
            // 
            // biotooptextBox
            // 
            this.biotooptextBox.Location = new System.Drawing.Point(546, 216);
            this.biotooptextBox.Name = "biotooptextBox";
            this.biotooptextBox.Size = new System.Drawing.Size(100, 22);
            this.biotooptextBox.TabIndex = 14;
            // 
            // omschrijvinglabel
            // 
            this.omschrijvinglabel.AutoSize = true;
            this.omschrijvinglabel.Location = new System.Drawing.Point(454, 244);
            this.omschrijvinglabel.Name = "omschrijvinglabel";
            this.omschrijvinglabel.Size = new System.Drawing.Size(85, 16);
            this.omschrijvinglabel.TabIndex = 15;
            this.omschrijvinglabel.Text = "omschrijving:";
            // 
            // omschrijvingtextBox
            // 
            this.omschrijvingtextBox.Location = new System.Drawing.Point(546, 245);
            this.omschrijvingtextBox.Name = "omschrijvingtextBox";
            this.omschrijvingtextBox.Size = new System.Drawing.Size(100, 22);
            this.omschrijvingtextBox.TabIndex = 16;
            // 
            // voegtoebutton
            // 
            this.voegtoebutton.Location = new System.Drawing.Point(519, 307);
            this.voegtoebutton.Name = "voegtoebutton";
            this.voegtoebutton.Size = new System.Drawing.Size(151, 47);
            this.voegtoebutton.TabIndex = 17;
            this.voegtoebutton.Text = "gegevens toevoegen";
            this.voegtoebutton.UseVisualStyleBackColor = true;
            this.voegtoebutton.Click += new System.EventHandler(this.voegtoebutton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(745, 137);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(258, 257);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // apphome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 516);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.voegtoebutton);
            this.Controls.Add(this.omschrijvingtextBox);
            this.Controls.Add(this.omschrijvinglabel);
            this.Controls.Add(this.biotooptextBox);
            this.Controls.Add(this.biotooplabel);
            this.Controls.Add(this.typetextBox);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.naamtextBox);
            this.Controls.Add(this.naamlabel);
            this.Controls.Add(this.categorienaamtextBox);
            this.Controls.Add(this.categorienaamlabel);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.uitlegtekstlabel);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.titeltekstlabel);
            this.Name = "apphome";
            this.Text = "apphome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titeltekstlabel;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Label uitlegtekstlabel;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label categorienaamlabel;
        private System.Windows.Forms.TextBox categorienaamtextBox;
        private System.Windows.Forms.Label naamlabel;
        private System.Windows.Forms.TextBox naamtextBox;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.TextBox typetextBox;
        private System.Windows.Forms.Label biotooplabel;
        private System.Windows.Forms.TextBox biotooptextBox;
        private System.Windows.Forms.Label omschrijvinglabel;
        private System.Windows.Forms.TextBox omschrijvingtextBox;
        private System.Windows.Forms.Button voegtoebutton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

