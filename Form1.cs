using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halmazok
{
    public partial class Form1 : Form
    {
        List<int> A_halmaz = new List<int>();
        List<int> B_halmaz = new List<int>();
        public Form1()
        {
            InitializeComponent();
            A_lista_list.Items.Clear();
            B_lista_list.Items.Clear();
        }

        private void Feltotes_btn_Click(object sender, EventArgs e)
        {
            Random vel = new Random();
            

            for (int i = 0; i < numericUpDownA.Value; i++)
            {

                int db = vel.Next(0, 20);

                if (!A_halmaz.Contains(db))
                {
                    A_halmaz.Add(db);
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < numericUpDownB.Value; i++)
            {
                int db = vel.Next(0, 20);
                
                if (!B_halmaz.Contains(db))
                {
                   B_halmaz.Add(db);
                }
                else
                {
                    i--;
                }
            }

            A_halmaz.Sort();
            B_halmaz.Sort();

            foreach (var item in A_halmaz)
            {
                A_lista_list.Items.Add(item);
            }
            foreach (var item in B_halmaz)
            {
                B_lista_list.Items.Add(item);
            }

            Unio();
            AmetszetB();
            AminusB();
            BminusA();
        }

        private void Unio() 
        {
            A_unio_B_list.Items.Clear();
            List<int> unio = new List<int>(A_halmaz);
            unio.AddRange(B_halmaz);

            unio = unio.Distinct().ToList();
            unio.Sort();

            foreach (var item in unio)
            {
               A_unio_B_list.Items.Add(item);
            }
           

        }

        private void AmetszetB()
        {
            A_metszet_B_listbox.Items.Clear();

            List<int> metszet = new List<int>(A_halmaz);
            metszet.AddRange(B_halmaz);

            metszet.Distinct().ToList();
            metszet.Sort();

            foreach (var item in A_halmaz)
            {
                if (B_halmaz.Contains(item))
                {
                    A_metszet_B_listbox.Items.Add(item);
                }

            }

        }
        private void AminusB()
        {
            A_minus_B_listbox.Items.Clear();
            List<int> a_minus_b = new List<int>(B_halmaz);
            foreach (var b_item in B_halmaz)
            {
                a_minus_b.Add(b_item);
            }
            foreach (var a_item in A_halmaz)
            {
                if (!a_minus_b.Contains(a_item))
                {
                    A_minus_B_listbox.Items.Add(a_item);
                }
            }
        }
        private void BminusA()
        {
            B_minus_A_listbox.Items.Clear();
            List<int> b_minus_a = new List<int>(A_halmaz);
            foreach (var a_item in A_halmaz)
            {
                b_minus_a.Add(a_item);
            }
            foreach (var b_item in B_halmaz)
            {
                if (!b_minus_a.Contains(b_item))
                {
                    B_minus_A_listbox.Items.Add(b_item);
                }
            }
        }
    }
}
