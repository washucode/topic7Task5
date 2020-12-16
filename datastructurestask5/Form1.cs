using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datastructurestask5
{
    public partial class frmLibrary : Form
    {

        Book[] library;
        public frmLibrary()
        {
            InitializeComponent();
        }

        private void frmLibrary_Load(object sender, EventArgs e)
        {
            library = new Book[10];

            library[0] = new Book("Book1", "Author1", 2000, false);
            library[1] = new Book("Book2", "Author2", 2010);

            library[2] = new Book("Book3", "hor", 2002);
            library[3]=new Book("Book1", "Author1", 2000);
            library[4]=new Book("Book1", "Author1", 2000);
            library[5]=new Book("Book1", "Author1", 2000);
            library[6]=new Book("Book1", "Author1", 2001);
            library[7]= new Book("Book1", "Author1", 2008);
            library[8]= new Book("Book1", "Author1", 2010);
            library[9]= new Book("Book1", "Author1", 2000);












        }

        private void btnFind_Click(object sender, EventArgs e)
        {
             int findbbyyear;
             findbbyyear = Int32.Parse(txtYear.Text);
             lblOutput.Text = "";

             for (int counter = 0; counter < library.Length; counter++) {

                 if (library[counter].Year == findbbyyear)
                 {
                     lblOutput.Text = lblOutput.Text + library[counter].Title + " - Author: " + library[counter].Author + "\n";

                 }
                 
             }
        }
    }
}
