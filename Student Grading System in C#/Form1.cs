using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univesity_Grade_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_attendance.Text=="" || tb_Final.Text == "" || tb_Mid.Text=="" ||tb_quiz1.Text=="" ||tb_quiz2.Text=="" || tb_quiz3.Text=="" || tb_quiz4.Text=="")
            {
                MessageBox.Show("Marking fields should not be left empty.");
            }
            else { 
            int inatt, finalatt, mid, final, total, percentage, quizsum = 0;
            inatt = int.Parse(tb_attendance.Text);
            finalatt = (inatt * 30) / 28;
            lb_attendance.Text = finalatt.ToString() + "/30";
            lb_attendance.Visible = true;
            mid = int.Parse(tb_Mid.Text);
            lb_mid.Text = mid.ToString() + "/75";
            lb_mid.Visible = true;
            final = int.Parse(tb_Final.Text);
            lb_Final.Text = final.ToString() + "/150";
            lb_Final.Visible = true;

            int quiz1, quiz2, quiz3, quiz4;
            quiz1 = int.Parse(tb_quiz1.Text);
            quiz2 = int.Parse(tb_quiz2.Text);
            quiz3 = int.Parse(tb_quiz3.Text);
            quiz4 = int.Parse(tb_quiz4.Text);
            int[] array = { quiz1, quiz2, quiz3, quiz4 };

            for (int i = 0; i <= 2; i++)
            {
                Array.Sort(array);
                Array.Reverse(array);
                quizsum += array[i];
            }
            lb_quiz.Text = quizsum.ToString()+"/45";
            lb_quiz.Visible = true;

            total = finalatt + mid + quizsum + final;
            lb_total.Text = total.ToString() + "/300";
            lb_total.Visible = true;
            percentage = (total * 100) / 300;

            if (percentage >= 80)
                lb_Grade.Text = "A+";
            else if (percentage >= 75 && percentage <= 79)
                lb_Grade.Text = "A";
            else if (percentage >= 70 && percentage <= 74)
                lb_Grade.Text = "A-";
            else if (percentage >= 65 && percentage <= 69)
                lb_Grade.Text = "B+";
            else if (percentage >= 64 && percentage <= 60)
                lb_Grade.Text = "B";
            else if (percentage >= 55 && percentage <= 59)
                lb_Grade.Text = "B-";
            else if (percentage >= 50 && percentage <= 54)
                lb_Grade.Text = "C+";
            else if (percentage >= 45 && percentage <= 49)
                lb_Grade.Text = "C";
            else if (percentage >= 40 && percentage <= 44)
                lb_Grade.Text = "D";
            else
                lb_Grade.Text = "F";

            lb_Grade.Visible = true;


            lb_displayresult.Text = tb_Name.Text +" with student id "+ tb_studentID.Text + " obtained " + percentage.ToString() + "% marks in " +tb_semester.Text+" Semester.";
            lb_displayresult.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_attendance.Text = "";
            tb_Final.Text = "";
            tb_Mid.Text = "";
            tb_Name.Text = "";
            tb_quiz1.Text = "";
            tb_quiz2.Text = "";
            tb_quiz3.Text = "";
            tb_quiz4.Text = "";
            tb_semester.Text = "";
            tb_studentID.Text = "";
            lb_attendance.Text = "";
            lb_displayresult.Text = "";
            lb_Final.Text = "";
            lb_Grade.Text = "";
            lb_mid.Text = "";
            lb_quiz.Text = "";
            lb_total.Text = "";
           
        }
    }
}
