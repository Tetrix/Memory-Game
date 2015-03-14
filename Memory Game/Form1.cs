using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Memory_Game
{
     
    public partial class Form1 : Form
    {
        
        Button b1=null, b2=null,b3=null;
         int counter = 0;
         int counter1 = 0;
         int j =0 ;

        public Form1()
        {
            InitializeComponent();

            foreach (Control cnt in panel1.Controls)
            {
                cnt.Enabled = false;
            }

            button37.ForeColor = Color.Green;

        }
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            timer1.Start();
            j = 150;
            b1 = null; b2 = null; b3 = null;
           
            Random random = new Random();

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 18; i++)
            {
                numbers.Add(i);
                numbers.Add(i);
            }


            foreach (Control control in panel1.Controls)
            {

                int randomBroj = random.Next(numbers.Count);
                control.Text = numbers[randomBroj].ToString();
                control.BackColor = Color.FromArgb(232, 232, 232);
                control.ForeColor = Color.FromArgb(232, 232, 232);
                control.Enabled = true;
                label1.Text = "";
                label5.Text = "";
                counter = 0;
                counter1 = 0;
                numbers.RemoveAt(randomBroj);
            }

           
            
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button31_Click_1(object sender, EventArgs e)
        {

        }

         private void function(object sender, EventArgs e)
        {
          
            Button check = sender as Button;
            if (check.ForeColor == Color.Black) { return; }
            if (b1 == null)
            {
                b1=check;
                b1.ForeColor = Color.Black;
                return;
            } 
               
           else if (b1!=null && b2==null)
            {      
                b2 = check;
                b2.ForeColor = Color.Black;
            }
            else if (b1 != null && b2 != null && b3 == null)
            {
                b3 = check;
                b3.ForeColor = Color.Black;

             
            }

           

            
            if (b1.Text == b2.Text)
            {
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b1.Enabled = false;
                b2.Enabled = false;
                
                b1 = null;
                b2 = null;
                counter1++;
                label1.Text = counter1.ToString();
            }
            else 
            {
                while (counter <= 0)
                {
                    b1.BackColor = Color.Red;
                    b2.BackColor = Color.Red;
                  
                    counter++;
                    counter1++;
                    label1.Text = counter1.ToString();
                }

                if (counter > 0 && b3 != null)
                {
                    foreach (Control cnt in panel1.Controls)
                    {
                        if (cnt.BackColor == Color.Red)
                        {
                            cnt.BackColor = Color.FromArgb(232, 232, 232);
                        }
                    }
                    b1.ForeColor = Color.FromArgb(232, 232, 232);
                    b2.ForeColor = Color.FromArgb(232, 232, 232);
                    b3.ForeColor = Color.Black;
                    counter = 0;
                    b1 = null; b2 = null;
                    b1 = b3;
                    b3 = null;
                }

                


            }

           
            
       }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j > 0)
            {
                j--;
                label3.Text = j.ToString();
            }
            else {
                timer1.Stop();
                foreach (Control cnt in panel1.Controls)
                {

                    cnt.Enabled = false;
                   
                }
            }

            int counter2 = 0;
            foreach (Control control in panel1.Controls)
            {
                if (control.BackColor == Color.Green) { counter2++; }
            }
            if (counter2 == 36) { label5.Text = "Ustesno zavrsena igra";
            timer1.Stop();
            }
            else if (j == 0) { label5.Text = "Poveke sreka naredniot pat"; }


        }

        private void button38_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

    }
            

}
