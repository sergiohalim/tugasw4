using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SergioHalimAssignmentWeek4
{
    public partial class Main : Form
    {
        List<Team> teams = new List<Team>();
        public Main()
        {
            InitializeComponent();

            /*Goalkeeper
            Centre Back
            Left Back
            Right Back
            Defensive Midfield
            Central Midfield
            Left Midfield
            Right Midfield
            Attacking Midfield
            Left Winger
            Right Winger
            Centre Forward
            Striker*/
            //Initiate First Data
            initiateData();
        }

        public void initiateData()
        {
            teams.Add(new Team("Negeri Sembilan", "Malaysia", "Seremban"));
            teams.Add(new Team("Arema", "Indonesia", "Malang"));
            teams.Add(new Team("Persib", "Indonesia", "Bandung"));

            List<Player> players = new List<Player>();
            List<Player> players2 = new List<Player>();
            List<Player> players3 = new List<Player>();
            players.Add(new Player("Shahrul Iman Ahmad Shukri", "1", "Goalkeeper"));
            players.Add(new Player("Mohd Nazirul Mohd Sham", "4", "Defender"));
            players.Add(new Player("Mohd Hazrulniezam Hashim", "5", "Defender"));
            players.Add(new Player("Vethyatharan al Tamial Selwam", "6", "Defender"));
            players.Add(new Player("Azli Azrul Ahmad Kameel", "17", "Defender"));
            players.Add(new Player("Javabilaarivin al Nyanasegar", "8", "Midfielder"));
            players.Add(new Player("Selvan al Anbualagan", "10", "Midfielder"));
            players.Add(new Player("Wan Ikram Amir Wan Mohd Zamri", "14", "Midfielder"));
            players.Add(new Player("Nur Arif Asyraf Haidir", "20", "Midfielder"));
            players.Add(new Player("Muhammad Ramadan Roseli", "9", "Forward"));
            players.Add(new Player("Mohd Haziq Fikri Haszaime", "11", "Forward"));
            teams[0].playerList = players;

            players2.Add(new Player("Teguh Amiruddin", "23", "Goalkeeper"));
            players2.Add(new Player("Sergio Silva", "4", "Defender"));
            players2.Add(new Player("Bagas Adi Nugroho", "5", "Defender"));
            players2.Add(new Player("Rizky Dwi Febrianto", "12", "Defender"));
            players2.Add(new Player("Hasyim Kipuw", "15", "Defender"));
            players2.Add(new Player("Evan Dimas", "6", "Midfielder"));
            players2.Add(new Player("Renshi Yamaguchi", "8", "Midfielder"));
            players2.Add(new Player("Gian Zola", "11", "Midfielder"));
            players2.Add(new Player("Hamzah Titofani", "13", "Midfielder"));
            players2.Add(new Player("Muhammad Rafli", "10", "Forward"));
            players2.Add(new Player("Hanis Sagara", "22", "Forward"));
            teams[1].playerList = players2;

            players3.Add(new Player("Fitrul Dwi Rustapa", "1", "Goalkeeper"));
            players3.Add(new Player("Nick Kuipers", "2", "Defender"));
            players3.Add(new Player("Victor Igbonefo", "32", "Defender"));
            players3.Add(new Player("Zalnando", "27", "Defender"));
            players3.Add(new Player("Henhen Herdiana", "12", "Defender"));
            players3.Add(new Player("Marc Klok", "10", "Midfielder"));
            players3.Add(new Player("Rachmat Irianto", "53", "Midfielder"));
            players3.Add(new Player("Dedi Kusnandar", "11", "Midfielder"));
            players3.Add(new Player("Abdul Aziz", "8", "Midfielder"));
            players3.Add(new Player("Frets Butuan", "21", "Forward"));
            players3.Add(new Player("David da Silva", "19", "Forward"));
            teams[2].playerList = players3;

            for (int i = 0; i < teams.Count; i++)
            {
                comboBoxTeamName.Items.Add(teams[i].teamName);
                comboBoxTeamNamePlayer.Items.Add(teams[i].teamName);
            }
        }

        private void comboBoxTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxListOfPlayers.Items.Clear();
            for(int i = 0; i < teams.Count; i++) {
                if (teams[i].teamName.Equals(comboBoxTeamName.SelectedItem.ToString()))
                {
                    MessageBox.Show("You choose team " + comboBoxTeamName.SelectedItem.ToString() + " from " + teams[i].teamCity + ", " + teams[i].teamCountry);
                    if(teams[i].playerList != null)
                    {
                        for (int j = 0; j < teams[i].playerList.Count; j++)
                        {
                            listBoxListOfPlayers.Items.Add(teams[i].playerList[j].playerName + " - " + teams[i].playerList[j].playerPos + " (" + teams[i].playerList[j].playerNum + ")");
                        }
                    }
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int trap = 0;
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].teamName == textBoxTeamName.Text)
                {
                    trap = 1;
                }
            }
            if (trap == 1)
            {
                MessageBox.Show("Team name is already exist.");
            }
            else
            {
                if (textBoxTeamName.Text.Equals("") || textBoxTeamCountry.Text.Equals("") || textBoxTeamCity.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill Team Name, Team Country and Team City first before add.");
                }
                else
                {
                    teams.Add(new Team(textBoxTeamName.Text, textBoxTeamCountry.Text, textBoxTeamCity.Text));
                    MessageBox.Show("Successfull add Team " + textBoxTeamName.Text);
                    clear();
                    load();
                }
            }
        }

        public void load()
        {
            comboBoxTeamName.Items.Clear();
            comboBoxTeamNamePlayer.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                comboBoxTeamName.Items.Add(teams[i].teamName);
                comboBoxTeamNamePlayer.Items.Add(teams[i].teamName);
            }
        }

        public void clear()
        {
            textBoxTeamName.Text = "";
            textBoxTeamCountry.Text = "";
            textBoxTeamCity.Text = "";
        }

        public void clearPlayer()
        {
            comboBoxTeamNamePlayer.Text = "";
            textBoxPlayerName.Text = "";
            textBoxPlayerNum.Text = "";
            comboBoxPlayerPos.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int trap = 0;
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].teamName == comboBoxTeamNamePlayer.Text)
                {
                    if (teams[i].playerList != null)
                    {
                        for (int j = 0; j < teams[i].playerList.Count; j++)
                        {
                            if (teams[i].playerList[j].playerName.Equals(textBoxPlayerName.Text))
                            {
                                trap = 1;
                                break;
                            }
                        }
                    }
                }
            }
            if (trap == 1)
            {
                MessageBox.Show("Player name in team " + comboBoxTeamNamePlayer.Text + " is already exist.");
            }
            else
            {
                if (textBoxPlayerName.Text.Equals("") || textBoxPlayerNum.Text.Equals("") || comboBoxPlayerPos.Text.Equals("") || comboBoxTeamNamePlayer.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill Player Name, Player Num, Choose Team Name and Player pos first before add.");
                }
                else
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].teamName == comboBoxTeamNamePlayer.Text)
                        {
                            if(teams[i].playerList == null)
                            {
                                teams[i].playerList = new List<Player>();
                            }
                            teams[i].playerList.Add(new Player(textBoxPlayerName.Text, textBoxPlayerNum.Text, comboBoxPlayerPos.Text));
                            break;
                        }
                    }

                    if (comboBoxTeamNamePlayer.Text.Equals(comboBoxTeamName.Text))
                    {
                        listBoxListOfPlayers.Items.Clear();
                        for (int i = 0; i < teams.Count; i++)
                        {
                            if (teams[i].teamName.Equals(comboBoxTeamName.SelectedItem.ToString()))
                            {
                                MessageBox.Show("List of Players refreshed.");
                                if (teams[i].playerList != null)
                                {
                                    for (int j = 0; j < teams[i].playerList.Count; j++)
                                    {
                                        listBoxListOfPlayers.Items.Add(teams[i].playerList[j].playerName + " - " + teams[i].playerList[j].playerPos + " (" + teams[i].playerList[j].playerNum + ")");
                                    }
                                }
                                break;
                            }
                        }
                    }

                    clearPlayer();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!listBoxListOfPlayers.Text.Equals(""))
            {
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].teamName.Equals(comboBoxTeamName.SelectedItem.ToString()))
                    {
                        
                        if (teams[i].playerList != null)
                        {
                            if (teams[i].playerList.Count - 1 < 11)
                            {
                                MessageBox.Show("Can't remove player. Minimum 11 player in team.");
                            }
                            else
                            {
                                for (int j = 0; j < teams[i].playerList.Count; j++)
                                {
                                    string[] split = listBoxListOfPlayers.Text.ToString().Split('-');
                                    if (teams[i].playerList[j].playerName.Equals(split[0].Trim()))
                                    {
                                        teams[i].playerList.RemoveAt(j);
                                        MessageBox.Show("Remove player success.");
                                    }
                                }

                                listBoxListOfPlayers.Items.Clear();
                                for (int j = 0; j < teams[i].playerList.Count; j++)
                                {
                                    listBoxListOfPlayers.Items.Add(teams[i].playerList[j].playerName + " - " + teams[i].playerList[j].playerPos + " (" + teams[i].playerList[j].playerNum + ")");
                                }
                                MessageBox.Show("List of Players refreshed.");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose player first before remove.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxListOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
