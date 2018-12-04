namespace SwissTransportUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_start = new System.Windows.Forms.ComboBox();
            this.box_dest = new System.Windows.Forms.ComboBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.btn_search_connentions = new System.Windows.Forms.Button();
            this.lst_list = new System.Windows.Forms.ListBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.txt_dest = new System.Windows.Forms.TextBox();
            this.btn_search_departures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_start
            // 
            this.box_start.FormattingEnabled = true;
            this.box_start.Location = new System.Drawing.Point(52, 64);
            this.box_start.Name = "box_start";
            this.box_start.Size = new System.Drawing.Size(530, 21);
            this.box_start.TabIndex = 1;
            // 
            // box_dest
            // 
            this.box_dest.FormattingEnabled = true;
            this.box_dest.Location = new System.Drawing.Point(52, 110);
            this.box_dest.Name = "box_dest";
            this.box_dest.Size = new System.Drawing.Size(530, 21);
            this.box_dest.TabIndex = 3;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(9, 48);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(26, 13);
            this.lbl_from.TabIndex = 2;
            this.lbl_from.Text = "Von";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(9, 94);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(33, 13);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "Nach";
            // 
            // btn_search_connentions
            // 
            this.btn_search_connentions.Location = new System.Drawing.Point(120, 150);
            this.btn_search_connentions.Name = "btn_search_connentions";
            this.btn_search_connentions.Size = new System.Drawing.Size(124, 23);
            this.btn_search_connentions.TabIndex = 4;
            this.btn_search_connentions.Text = "Verbindungen suchen";
            this.btn_search_connentions.UseVisualStyleBackColor = true;
            this.btn_search_connentions.Click += new System.EventHandler(this.btn_search_connections_Click);
            // 
            // lst_list
            // 
            this.lst_list.FormattingEnabled = true;
            this.lst_list.Location = new System.Drawing.Point(12, 197);
            this.lst_list.Name = "lst_list";
            this.lst_list.Size = new System.Drawing.Size(570, 199);
            this.lst_list.TabIndex = 5;
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(52, 45);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(530, 20);
            this.txt_start.TabIndex = 0;
            this.txt_start.TextChanged += new System.EventHandler(this.txt_start_TextChanged);
            // 
            // txt_dest
            // 
            this.txt_dest.Location = new System.Drawing.Point(52, 91);
            this.txt_dest.Name = "txt_dest";
            this.txt_dest.Size = new System.Drawing.Size(530, 20);
            this.txt_dest.TabIndex = 2;
            this.txt_dest.TextChanged += new System.EventHandler(this.txt_dest_TextChanged);
            // 
            // btn_search_departures
            // 
            this.btn_search_departures.Location = new System.Drawing.Point(377, 150);
            this.btn_search_departures.Name = "btn_search_departures";
            this.btn_search_departures.Size = new System.Drawing.Size(75, 23);
            this.btn_search_departures.TabIndex = 6;
            this.btn_search_departures.Text = "Abfahrtsliste";
            this.btn_search_departures.UseVisualStyleBackColor = true;
            this.btn_search_departures.Click += new System.EventHandler(this.btn_search_departures_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btn_search_departures);
            this.Controls.Add(this.txt_dest);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.lst_list);
            this.Controls.Add(this.btn_search_connentions);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.box_dest);
            this.Controls.Add(this.box_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox box_start;
        private System.Windows.Forms.ComboBox box_dest;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Button btn_search_connentions;
        private System.Windows.Forms.ListBox lst_list;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.TextBox txt_dest;
        private System.Windows.Forms.Button btn_search_departures;
    }
}

