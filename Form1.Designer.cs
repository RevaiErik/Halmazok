
namespace Halmazok
{
    partial class Form1
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
            this.A_lista_list = new System.Windows.Forms.ListBox();
            this.B_lista_list = new System.Windows.Forms.ListBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.A_halmaz_lbl = new System.Windows.Forms.Label();
            this.B_halmaz_lbl = new System.Windows.Forms.Label();
            this.A_unio_B_list = new System.Windows.Forms.ListBox();
            this.A_minus_B_listbox = new System.Windows.Forms.ListBox();
            this.A_metszet_B_listbox = new System.Windows.Forms.ListBox();
            this.B_minus_A_listbox = new System.Windows.Forms.ListBox();
            this.Feltotes_btn = new System.Windows.Forms.Button();
            this.darab_lbl_2 = new System.Windows.Forms.Label();
            this.darab_lb_1 = new System.Windows.Forms.Label();
            this.A_U_B_lbl = new System.Windows.Forms.Label();
            this.A_m_b = new System.Windows.Forms.Label();
            this.A_minus_B_lbl = new System.Windows.Forms.Label();
            this.B_minus_A_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            this.SuspendLayout();
            // 
            // A_lista_list
            // 
            this.A_lista_list.FormattingEnabled = true;
            this.A_lista_list.Location = new System.Drawing.Point(29, 75);
            this.A_lista_list.Name = "A_lista_list";
            this.A_lista_list.Size = new System.Drawing.Size(60, 251);
            this.A_lista_list.TabIndex = 0;
            // 
            // B_lista_list
            // 
            this.B_lista_list.FormattingEnabled = true;
            this.B_lista_list.Location = new System.Drawing.Point(117, 75);
            this.B_lista_list.Name = "B_lista_list";
            this.B_lista_list.Size = new System.Drawing.Size(60, 251);
            this.B_lista_list.TabIndex = 1;
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(29, 355);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownA.TabIndex = 2;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(117, 355);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownB.TabIndex = 3;
            // 
            // A_halmaz_lbl
            // 
            this.A_halmaz_lbl.AutoSize = true;
            this.A_halmaz_lbl.Location = new System.Drawing.Point(39, 59);
            this.A_halmaz_lbl.Name = "A_halmaz_lbl";
            this.A_halmaz_lbl.Size = new System.Drawing.Size(50, 13);
            this.A_halmaz_lbl.TabIndex = 4;
            this.A_halmaz_lbl.Text = "A halmaz";
            // 
            // B_halmaz_lbl
            // 
            this.B_halmaz_lbl.AutoSize = true;
            this.B_halmaz_lbl.Location = new System.Drawing.Point(127, 59);
            this.B_halmaz_lbl.Name = "B_halmaz_lbl";
            this.B_halmaz_lbl.Size = new System.Drawing.Size(50, 13);
            this.B_halmaz_lbl.TabIndex = 5;
            this.B_halmaz_lbl.Text = "B halmaz";
            // 
            // A_unio_B_list
            // 
            this.A_unio_B_list.FormattingEnabled = true;
            this.A_unio_B_list.Location = new System.Drawing.Point(341, 75);
            this.A_unio_B_list.Name = "A_unio_B_list";
            this.A_unio_B_list.Size = new System.Drawing.Size(60, 251);
            this.A_unio_B_list.TabIndex = 6;
            // 
            // A_minus_B_listbox
            // 
            this.A_minus_B_listbox.FormattingEnabled = true;
            this.A_minus_B_listbox.Location = new System.Drawing.Point(560, 75);
            this.A_minus_B_listbox.Name = "A_minus_B_listbox";
            this.A_minus_B_listbox.Size = new System.Drawing.Size(60, 251);
            this.A_minus_B_listbox.TabIndex = 7;
            // 
            // A_metszet_B_listbox
            // 
            this.A_metszet_B_listbox.FormattingEnabled = true;
            this.A_metszet_B_listbox.Location = new System.Drawing.Point(448, 75);
            this.A_metszet_B_listbox.Name = "A_metszet_B_listbox";
            this.A_metszet_B_listbox.Size = new System.Drawing.Size(60, 251);
            this.A_metszet_B_listbox.TabIndex = 8;
            // 
            // B_minus_A_listbox
            // 
            this.B_minus_A_listbox.FormattingEnabled = true;
            this.B_minus_A_listbox.Location = new System.Drawing.Point(683, 75);
            this.B_minus_A_listbox.Name = "B_minus_A_listbox";
            this.B_minus_A_listbox.Size = new System.Drawing.Size(60, 251);
            this.B_minus_A_listbox.TabIndex = 9;
            // 
            // Feltotes_btn
            // 
            this.Feltotes_btn.Location = new System.Drawing.Point(202, 355);
            this.Feltotes_btn.Name = "Feltotes_btn";
            this.Feltotes_btn.Size = new System.Drawing.Size(75, 23);
            this.Feltotes_btn.TabIndex = 12;
            this.Feltotes_btn.Text = "Feltoltes";
            this.Feltotes_btn.UseVisualStyleBackColor = true;
            this.Feltotes_btn.Click += new System.EventHandler(this.Feltotes_btn_Click);
            // 
            // darab_lbl_2
            // 
            this.darab_lbl_2.AutoSize = true;
            this.darab_lbl_2.Location = new System.Drawing.Point(127, 339);
            this.darab_lbl_2.Name = "darab_lbl_2";
            this.darab_lbl_2.Size = new System.Drawing.Size(34, 13);
            this.darab_lbl_2.TabIndex = 13;
            this.darab_lbl_2.Text = "darab";
            // 
            // darab_lb_1
            // 
            this.darab_lb_1.AutoSize = true;
            this.darab_lb_1.Location = new System.Drawing.Point(39, 339);
            this.darab_lb_1.Name = "darab_lb_1";
            this.darab_lb_1.Size = new System.Drawing.Size(34, 13);
            this.darab_lb_1.TabIndex = 14;
            this.darab_lb_1.Text = "darab";
            // 
            // A_U_B_lbl
            // 
            this.A_U_B_lbl.AutoSize = true;
            this.A_U_B_lbl.Location = new System.Drawing.Point(352, 59);
            this.A_U_B_lbl.Name = "A_U_B_lbl";
            this.A_U_B_lbl.Size = new System.Drawing.Size(49, 13);
            this.A_U_B_lbl.TabIndex = 15;
            this.A_U_B_lbl.Text = "A Unió B";
            // 
            // A_m_b
            // 
            this.A_m_b.AutoSize = true;
            this.A_m_b.Location = new System.Drawing.Point(445, 59);
            this.A_m_b.Name = "A_m_b";
            this.A_m_b.Size = new System.Drawing.Size(63, 13);
            this.A_m_b.TabIndex = 16;
            this.A_m_b.Text = "A metszet B";
            // 
            // A_minus_B_lbl
            // 
            this.A_minus_B_lbl.AutoSize = true;
            this.A_minus_B_lbl.Location = new System.Drawing.Point(574, 59);
            this.A_minus_B_lbl.Name = "A_minus_B_lbl";
            this.A_minus_B_lbl.Size = new System.Drawing.Size(30, 13);
            this.A_minus_B_lbl.TabIndex = 17;
            this.A_minus_B_lbl.Text = "A - B";
            // 
            // B_minus_A_lbl
            // 
            this.B_minus_A_lbl.AutoSize = true;
            this.B_minus_A_lbl.Location = new System.Drawing.Point(698, 59);
            this.B_minus_A_lbl.Name = "B_minus_A_lbl";
            this.B_minus_A_lbl.Size = new System.Drawing.Size(30, 13);
            this.B_minus_A_lbl.TabIndex = 18;
            this.B_minus_A_lbl.Text = "B - A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_minus_A_lbl);
            this.Controls.Add(this.A_minus_B_lbl);
            this.Controls.Add(this.A_m_b);
            this.Controls.Add(this.A_U_B_lbl);
            this.Controls.Add(this.darab_lb_1);
            this.Controls.Add(this.darab_lbl_2);
            this.Controls.Add(this.Feltotes_btn);
            this.Controls.Add(this.B_minus_A_listbox);
            this.Controls.Add(this.A_metszet_B_listbox);
            this.Controls.Add(this.A_minus_B_listbox);
            this.Controls.Add(this.A_unio_B_list);
            this.Controls.Add(this.B_halmaz_lbl);
            this.Controls.Add(this.A_halmaz_lbl);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.B_lista_list);
            this.Controls.Add(this.A_lista_list);
            this.Name = "Form1";
            this.Text = "Halmazok";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox A_lista_list;
        private System.Windows.Forms.ListBox B_lista_list;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label A_halmaz_lbl;
        private System.Windows.Forms.Label B_halmaz_lbl;
        private System.Windows.Forms.ListBox A_unio_B_list;
        private System.Windows.Forms.ListBox A_minus_B_listbox;
        private System.Windows.Forms.ListBox A_metszet_B_listbox;
        private System.Windows.Forms.ListBox B_minus_A_listbox;
        private System.Windows.Forms.Button Feltotes_btn;
        private System.Windows.Forms.Label darab_lbl_2;
        private System.Windows.Forms.Label darab_lb_1;
        private System.Windows.Forms.Label A_U_B_lbl;
        private System.Windows.Forms.Label A_m_b;
        private System.Windows.Forms.Label A_minus_B_lbl;
        private System.Windows.Forms.Label B_minus_A_lbl;
    }
}

