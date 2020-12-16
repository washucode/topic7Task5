using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructurestask5
{
    class Book
    {
        private String title;
        private String author;
        int year;
        Boolean checkedout;
        private string p1;
        private string p2;
        private int p3;
        private bool p4;

        public Book(String t, String a, int y,bool x){
            title = t;
            author = a;
            year = y;
            checkedout = x;
        }

       
        public string Title
        {
            get {
                return title;

            }
            set {

                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;

            }
            set
            {

                author = value;
            }
        }

        public int   Year
        {
            get
            {
                return year;

            }
            set
            {

                year=value;
            }
        }

        public bool CheckedOut {
            get {
                return checkedout;
            }
            set {
                checkedout = value;
            }
        }
    }
}
