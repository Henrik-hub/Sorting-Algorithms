using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;

// This App measures the time for executing different sorting algorithms.
// Merge Sort, Bubble Sort, Insertion Sort, Lambda sort, Selection Sort, Quick Sort
// The input window takes a number corresponding to the size of a randomly created array
// By clicking the button for each sorting algorithm the calculation gets executed and returns the elapsed time for the choosen algorithm
// time gets displayed at the bottom 

namespace DesktopApp1
{
    public partial class Form1 : Form
    {  
        Algorithm Prepare = new Algorithm();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //Using button Selection Sort 
          
            //use delegate type declared in Algorithm and create pointer to Selection sort in Algorithm
            Algorithm.point pointa = new Algorithm.point(Prepare.Selection_sort);

            //store the result time from Running method in erg1. running method takes the provided input array length and the previously created delegate pointer as input args
            double erg1 = Prepare.Running(Prepare.Randomize(Convert.ToInt32(this.textBox1.Text)),pointa);

            //  elapsed time to seconds and miliseconds and mikroseconds 
            label3.Text = Convert.ToString(erg1);
            label5.Text = Convert.ToString(erg1/1000);
            label7.Text = Convert.ToString(erg1 / 1000000);
        }

        private void button2_Click(object sender, EventArgs e)
        { // bubble sort

            Algorithm.point pointa2 = new Algorithm.point(Prepare.Bubble_sort);
            double erg2 = Prepare.Running(Prepare.Randomize(Convert.ToInt32(this.textBox1.Text)), pointa2);

            label3.Text = Convert.ToString(erg2);
            label5.Text = Convert.ToString(erg2 / 1000);
            label7.Text = Convert.ToString(erg2 / 1000000);
        }

        private void button3_Click(object sender, EventArgs e)
        {// merge sort

            Algorithm.point_multi pointa3 = new Algorithm.point_multi(Prepare.MergeSort);
            double erg3 = Prepare.Runnings(Prepare.Randomize(Convert.ToInt32(this.textBox1.Text)), pointa3);


            label3.Text = Convert.ToString(erg3);
            label5.Text = Convert.ToString(erg3 / 1000);
            label7.Text = Convert.ToString(erg3 / 1000000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // quick sort

            Algorithm.point_multi pointa4 = new Algorithm.point_multi(Prepare.QuickSort);
            double ergebnis = Prepare.Runnings(Prepare.Randomize(Convert.ToInt32(this.textBox1.Text)), pointa4);


            label3.Text = Convert.ToString(ergebnis);
            label5.Text = Convert.ToString(ergebnis / 1000);
            label7.Text = Convert.ToString(ergebnis / 1000000);
        }

        private void button5_Click(object sender, EventArgs e)
        {   //Insertion sort

            Algorithm.point pointa5 = new Algorithm.point(Prepare.Insertion_sort);
            double erg5 = Prepare.Running(Prepare.Randomize(Convert.ToInt32(this.textBox1.Text)), pointa5);


            label3.Text = Convert.ToString(erg5);
            label5.Text = Convert.ToString(erg5 / 1000);
            label7.Text = Convert.ToString(erg5 / 1000000); 
        }

        private void button6_Click(object sender, EventArgs e)
        {   //Lambda 
           
            Algorithm.point pointa6 = new Algorithm.point(Prepare.Lambda);
            double erg6 = Prepare.Running(Prepare.Randomize(Convert.ToInt32(this.textBox1.Text)), pointa6);

            label3.Text = Convert.ToString(erg6);
            label5.Text = Convert.ToString(erg6 / 1000);
            label7.Text = Convert.ToString(erg6 / 1000000);
        }
    }
}
