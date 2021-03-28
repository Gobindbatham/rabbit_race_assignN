using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rabbit_race_assign
{
    public partial class Form1 : Form
    {
        
        //create the array object of the class
        Player1[] player = new Player1[3];
        
        int indx = 0;

        int Manna = 100,Harry=100,Sonu=100;
        
        int winer = 0;
        
        public Form1()
        {
            InitializeComponent();
            player[0] = new Player1("", 0, 0, 0);
            player[1] = new Player1("", 0, 0, 0);
            player[2] = new Player1("", 0, 0, 0);
        }

        private void manna_has_Click(object sender, EventArgs e)
        {

        }

        private void race_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Greyhound greyhound = new Greyhound();
            if (pbRabit1.Left < greyhound.setLimit())
            {
                pbRabit1.Left += greyhound.genNo();
            
            }
            else {
                timer1.Stop();
                MessageBox.Show("first one won the race ");
                winer = 1;
                lastAnnouncement();
            }

            if (pbRabit2.Left< greyhound.setLimit()) {
                pbRabit2.Left += greyhound.genNo();
            }
            else {
                timer1.Stop();
                MessageBox.Show("Second one won the race ");
                winer = 2;
                lastAnnouncement();
            }
            if (pbRabit3.Left < greyhound.setLimit())
            {
                pbRabit3.Left += greyhound.genNo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("third one won the race ");
                winer = 3;
                lastAnnouncement();

            }
            if (pbRabit4.Left < greyhound.setLimit())
            {
                pbRabit4.Left += greyhound.genNo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("forth one won the race ");
                winer = 4;
                lastAnnouncement();
            }
       }

        public void lastAnnouncement() {

//            MessageBox.Show(player[0].Name);
            
            if (!player[0].Name.Equals("")) {
                if (player[0].Name.Equals("Harry"))
                {

                    Harry = player[0].resetBudget(winer);
                }
                if (player[0].Name.Equals("Manna"))
                {

                    Manna = player[0].resetBudget(winer);
                }
                if (player[0].Name.Equals("Sonu"))
                {

                    Sonu = player[0].resetBudget(winer);
                }

            }

            if (!player[1].Name.Equals(""))
            {
                if (player[1].Name.Equals("Harry"))
                {

                    Harry = player[1].resetBudget(winer);
                }
                if (player[1].Name.Equals("Manna"))
                {

                    Manna = player[1].resetBudget(winer);
                }
                if (player[1].Name.Equals("Sonu"))
                {

                    Sonu = player[1].resetBudget(winer);
                }
            }


            if (!player[2].Name.Equals(""))
            {
                if (player[2].Name.Equals("Harry"))
                {

                    Harry = player[2].resetBudget(winer);
                }
                if (player[2].Name.Equals("Manna"))
                {

                    Manna = player[2].resetBudget(winer);
                }
                if (player[2].Name.Equals("Sonu"))
                {

                    Sonu = player[2].resetBudget(winer);
                }

            }




            harry_has.Text = "Harry Has " + Harry;
            manna_has.Text = "Manna Has " + Manna;
            sonu_has.Text = "Sonu Has " + Sonu;

            pbRabit1.Left = 10;
            pbRabit2.Left = 10;
            pbRabit3.Left = 10;
            pbRabit4.Left = 10;

            race_btn.Enabled = false;

            select_amount.Text = "";
            select_player.Text = "";
            select_rabbit.Text = "";

            player[0] = new Player1("", 0, 0, 0);
            player[1] = new Player1("", 0, 0, 0);
            player[2] = new Player1("", 0, 0, 0);

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //add the name of the player 
            select_player.Items.Add("Manna");
            select_player.Items.Add("Harry");
            select_player.Items.Add("Sonu");

            //add the position of the rabit 
            select_rabbit.Items.Add("1");
            select_rabbit.Items.Add("2");
            select_rabbit.Items.Add("3");
            select_rabbit.Items.Add("4");

            //add the amount for the bet 
            int y = 1;
            do
            {
                select_amount.Items.Add("" + y);
                y++;
            } while (y <= 50);

        }

        private void bet_btn_Click(object sender, EventArgs e)
        {
            //when the player fullfill all condition then need to set the details 
            if (!select_player.Text.Equals("") && !select_rabbit.Text.Equals("") && !select_amount.Text.Equals(""))
            {
                
                
                if (select_player.Text.ToString().Equals("Manna") && Manna>0 && Manna>=Convert.ToInt32(select_amount.Text))
                {
                //    MessageBox.Show(select_player.Text.ToString());
                    player[indx] = new Player1("Manna", Convert.ToInt32(select_rabbit.Text.ToString()), Convert.ToInt32(select_amount.Text.ToString()), Manna);
                    manna_has.Text = "Manna select " + select_rabbit.Text.ToString() + " with the amount " + select_amount.Text.ToString();
                    race_btn.Enabled = true;
                }
                
              else  if (select_player.Text.ToString().Equals("Harry") && Harry > 0 && Harry >= Convert.ToInt32(select_amount.Text)) {
                    player[indx] = new Player1("Harry",Convert.ToInt32(select_rabbit.Text.ToString()), Convert.ToInt32(select_amount.Text.ToString()),Harry);
                    harry_has.Text = "Harry select " + select_rabbit.Text.ToString() + " with the amount " + select_amount.Text.ToString();
                    race_btn.Enabled = true;
                }

               else if (select_player.Text.ToString().Equals("Sonu") && Sonu > 0 && Sonu >= Convert.ToInt32(select_amount.Text))
                {
                    player[indx] = new Player1("Sonu", Convert.ToInt32(select_rabbit.Text.ToString()), Convert.ToInt32(select_amount.Text.ToString()), Sonu);
                    sonu_has.Text = "Sonu select " + select_rabbit.Text.ToString() + " with the amount " + select_amount.Text.ToString();
                    race_btn.Enabled = true;
                }

                if (indx<2) {
                    indx++;
                }

                //MessageBox.Show(player[indx--].Name);
            }
            else {
                MessageBox.Show("must need to select the all details ");
            }

        }
    }
}
