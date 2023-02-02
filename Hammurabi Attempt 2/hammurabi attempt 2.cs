using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;


namespace Hammurabi_Attempt_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            //Rules
            //  *Population Rules*
            //• Enter a number into the feeding text box to feed your citizens.
            //• Citizens require 20 bushels per turn to survive.
            //• If 40% or more of your citizens starve, then the game will end.
            //• A random ammount of new citizens between 0 to 10 will enter your kingdom on each turn.
            //• There is a 20% chance of 10% of your population dying from the plague.
            //• There is a 10% chance of 20% of your population dying from the plague.
            //       
            //  *Bushel Rules*
            //• You cant plant more acres of bushels than you own.
            //• If you run out bushels your population will starve and the game will end.
            //• The bushel harvest rate will fluctuate from 0 to 5 so plant carefully.
            //• The planted area multiplied by the harvest rate will give you the total harvest.
            //• There is a percentage chance of rats destryoing your bushels.
            //• There is a 30% chance of rats destroying 10% of your bushels.
            //• There is a 20% chance of rats destroying 20% of your bushels.
            //• There is a 10% chance of rats destroying 30% of your bushels.
            //
            //  *Land Rules*
            //• Land value fluctuates beetween 17-25 bushels per acre.
            //• To Buy Land, simply type the number of acres you would like to purchase.
            //• To sell land please type a minus (-) symbol before the acerage.
            //• The planted area multiplied by the harvest rate will give you the total harvest.
            //• If you run out of bushels but stll have land, some land will be sold to settle your debt and feed your people.
            //
            //• You will go bankrupt if you run out of bushels and land.


            //GUI References
            // Wheat ico - http://clipart-library.com/clipart/563882.htm
            // Mesopotamia Background - https://www.tes.com/lessons/p0Td_C7rk3MOrA/tes-lesson-mesopotamia-city-states
            // Scroll - http://clipart-library.com/clip-art/scroll-clipart-transparent-background-14.htm
            // Hammurabi title Banner - https://stock.adobe.com/uk/search/images?k=parchment%20banner
            // Animated Birds - https://ya-webdesign.com/image/bird-gif-png/432917.html
            // Animated Palm Trees - https://www.google.com/search?rlz=1C1CHBF_en-GBGB773GB773&biw=1707&bih=784&tbm=isch&sxsrf=ACYBGNQA75Fv59U2yhG5QZQzEJ4RDRWlGg%3A1580251336983&sa=1&ei=yLgwXtzYO5K7gweF6aPoCw&q=moving+palm+trees+gif&oq=palm+moving+gif&gs_l=img.3.0.0i8i30.35253.36923..38845...0.0..0.60.291.5......0....1..gws-wiz-img.......35i39j0i7i30j0i8i7i30.4qqcPnRhL1o#imgrc=HnOe50Y_lRxStM:
            // Animated Palm Tree Swaying - https://giphy.com/stickers/BayLedges-bay-ledges-iremember-bayledges-fGOAbNrp0WtctLULQV
            // Animated Boat - https://webstockreview.net/explore/boat-clipart-animation/


            InitializeComponent();
            {
                string delimiter = ","; //to seperate the data
                string tablename = "Highscores"; //sets table title
                string filepathname = ConfigurationManager.AppSettings["fileLoc"];
                //string filename = (@"n:\scores.txt"); //file name to write to

                DataSet dataset = new DataSet();
                StreamReader sr = new StreamReader(filepathname); //reads the name and score data from the csv file

                dataset.Tables.Add(tablename);
                dataset.Tables[tablename].Columns.Add("Name"); //adds the name column to the table
                dataset.Tables[tablename].Columns.Add("Scores"); //adds the score column to the table
                string allData = sr.ReadToEnd();
                string[] rows = allData.Split("\r".ToCharArray()); //writes the data to an array
                foreach (string r in rows)
                {
                    string[] items = r.Split(delimiter.ToCharArray());  //splits the comma seperated data into rows
                    dataset.Tables[tablename].Rows.Add(items);
                }
                this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
                dataGridView1.BackgroundColor = Color.Wheat; //changes the colour of the background of the table
            }
            // Add Series data to chart
            peopleSeries = ChartScore.Series.Add("People");
            bushelSeries = ChartScore.Series.Add("Bushels");
            landSeries = ChartScore.Series.Add("Land");

            //Statements to show yearly stats
            LblYearStats.Text = "Year " + YearNo + " Stats";  // shows the year number
            LblTitlePopulation.Text = "Population: " + TotalPopulation; // shows the total population
            LblTitleBushels.Text = "Bushels: " + TotalBushels; // shows the total bushels
            LblTitleLand.Text = "Land (Acres): " + TotalLand; // shows the total land
            LblHowManyStarved.Text = "How many people starved: " + Starved; // shows the total starved

            //Start Pop up

            MessageBox.Show(String.Join(Environment.NewLine, //shows a popup before the form loads with some basic information on
                            "Congratulations! you are the newest ruler of ancient Sumaria, elected for a ten year term of office. Your duties are to:",
                            "- Dispense food ",
                            "- Direct farming",
                            "- Buy and sell land as needed to support your people.",
                            "",
                            "Watch out for rat infestations and the plague!",
                            "Grain is the general currency, measured in bushels.",
                            "Have Fun & Good Luck!",
                            "",
                            "Click OK to begin your rule!"));
        }

        //Variables
        int YearNo = 0;
        int TotalPopulation = 100;
        int TotalBushels = 2800;
        int TotalLand = 1000;
        int LandValue;
        int HarvestRate;
        int NewPopulation;
        int RatRate;
        int Plague;
        int Starved;
        
        //graph series
        Series peopleSeries;
        Series bushelSeries;
        Series landSeries;

        //randoms
        Random random = new Random();



    //High Scores
    public static void addrecord(string Name, string Score,string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(Name + "," + Score); //writes the names and scores to a csv file seperated by a comma
                }
            }
            catch (Exception ex) //Prevents a crash if the names and scores fail to write to file
            {

                throw new ApplicationException("Did not save!",ex); //Warns the user that names and scores failed to write to file
            }
        }

        private void BtnNextYear_Click(object sender, EventArgs e)
        {

            //file writing

            



            //Progress bar
            YearlyProgressBar.Increment(+1);
            
            //Validation
            //land buy text box
            if (string.IsNullOrEmpty(TxtLandBuy.Text)) //Prevents an error with an empty text box
            {
                TxtLandBuy.Text = "0"; //replaces the empty field with a 0
            }
            if (int.TryParse(TxtLandBuy.Text, out int num2) == false) //prevents any characters other than numbers being entered
            {
                MessageBox.Show("You can only enter numbers into the land box!"); //shows a message to only enter numbers
                return;
            }

            //land plant text box
            if (string.IsNullOrEmpty(TxtLandPlant.Text)) //Prevents an error with an empty text box
            {
                TxtLandPlant.Text = "0"; //replaces the empty field with a 0
            }
            if (int.TryParse(TxtLandPlant.Text, out int num3) == false) //prevents any characters other than numbers being entered
            {
                MessageBox.Show("You can only enter numbers into the plant box!"); //shows a message to only enter numbers
                return;
            }
            if (int.Parse(TxtLandPlant.Text) <0 )
            {
                MessageBox.Show("You can't plant a negative ammount of bushels!"); //shows a message to only enter numbers
                return;
            }
            if (int.Parse(TxtLandPlant.Text) > TotalBushels) //sells land to pay for planting
            {
                int totland;
                totland = int.Parse(TxtLandPlant.Text) / LandValue;
                TotalLand = TotalLand - totland;
                int Harvest;
                Harvest = HarvestRate * int.Parse(TxtLandPlant.Text);
            }

            //feed text box
            if (string.IsNullOrEmpty(TxtFeed.Text))
            {
                TxtFeed.Text = "0"; //replaces the empty field with a 0
            }
            if (int.TryParse(TxtFeed.Text, out int num4) == false) //prevents any characters other than numbers being entered
            {
                MessageBox.Show("You can only enter numbers into the feed box!");
                return;
            }
            if (int.Parse(TxtFeed.Text) / 20 > TotalPopulation) //prevents the populaion being over fed
            {
                MessageBox.Show("Dont Over Feed The Population"); //shows a message to stop the user over feeding
                return;
            }




            //bankrupcy event

            if (TotalBushels <= 0) // sells land to make up enough bushels to settle the debt (bring bushels back to 0) and to feed the population
            {
                int difference;
                difference = 0 - TotalBushels;
                int sum;
                sum = difference / LandValue;
                TotalBushels = 0;
                TotalLand = TotalLand + sum;


                int totallandxvalue;
                totallandxvalue = TotalLand * LandValue;
                int bankrupcyfood;
                bankrupcyfood = TotalPopulation * 20;
                int totbankbushels;
                totbankbushels = totallandxvalue - bankrupcyfood;
                int canbuy;
                canbuy = totbankbushels / LandValue;
                TotalBushels = TotalBushels + bankrupcyfood;
                int add;
                add = TotalLand - canbuy;
                TotalLand = TotalLand - add;

                MessageBox.Show(String.Join(Environment.NewLine, //warns the user that they are getting close to bankrupcy
                "Some land has been sold to settle your debt and to feed your people!",
                    "Be careful bankrupcy looms!"));

            }

            //Land Value
            LandValue = random.Next(17, 25); //sets a random land value between 17 and 25
            LblLandValue.Text = "Land value per acre: " + LandValue; //show the land value

            //TotalLand
            if (int.Parse(TxtLandBuy.Text) < 0)    //if a minus number

            {

                if (Math.Abs(int.Parse(TxtLandBuy.Text)) > TotalLand)
                {
                    MessageBox.Show("You can't sell more land than you own!"); //stops the user from selling more land than they have to sell
                    return;
                }
            }
            else
            { }


            TotalLand = TotalLand + int.Parse(TxtLandBuy.Text);  //adds land to total

 
            //if (int.Parse(TxtLandBuy.Text) <0)
            //{
            //    TotalBushels = Math.Abs((int.Parse(TxtLandBuy.Text))* LandValue) + TotalBushels; //
            //}



            LblTitleLand.Text = "Land (Acres): " + TotalLand; //displays total land
            
            //Feed
            TotalBushels = TotalBushels - int.Parse(TxtFeed.Text);

            //Year Number
            YearNo = YearNo + 1;
            LblYearStats.Text = "Year " + YearNo + " Stats";

            //Starved
            int PeopleFed;
            PeopleFed = int.Parse(TxtFeed.Text) / 20;
            Starved = TotalPopulation - PeopleFed;
            double percentage = TotalPopulation / 100f; //works out how many people starved and takes from total

            percentage = percentage * 40;
            if (Starved >= percentage)
            {
                MessageBox.Show("Game Over! 40% or more of your population Starved."); //if more than 40% starve = game over
                High_Score_Pop_Up popup = new High_Score_Pop_Up(); //shows the score enter popup and forces the user to start again
                DialogResult dialogresult = popup.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    Console.WriteLine("OK");

                    addrecord(GlobalVariables.name.ToString(), GlobalVariables.score.ToString(), "Scores.txt");
                }
                else if (dialogresult == DialogResult.Cancel)
                {
                    Application.Restart();
                    Console.WriteLine(".");
                }
                popup.Dispose();
            }
            TotalPopulation = TotalPopulation - Starved; //takes starved peopole away from total


            //New People
            NewPopulation = random.Next(0, 11); //randomly between 0,11 adds new people to the kingdom
            TotalPopulation = TotalPopulation + NewPopulation;
            LblHowManyEnteredTheKingdom.Text = "How many people entered the kingdom: " + NewPopulation;


            //Plague Deaths
            Plague = random.Next(1, 11); //random chance of plague happening between 1,11
            int PlagueKilled;
            if (Plague >= 8)
            {
                PlagueKilled = (TotalPopulation / 100) * 10;
                TotalPopulation = TotalPopulation - PlagueKilled; //30% chance of 10% of people dying in plague
            }
            if (Plague == 7)
            {
                PlagueKilled = (TotalPopulation / 100) * 20;
                TotalPopulation = TotalPopulation - PlagueKilled; //10% chance of 20% of people dying in plague
            }
            else
            {
                PlagueKilled = 0;
                TotalPopulation = TotalPopulation - PlagueKilled;
            }
            //30% chance of 10% of people dying in plague
            LblPlagueDeaths.Text = "Plague deaths: " + PlagueKilled;


            //Total Population
            LblTitlePopulation.Text = "Population: " + TotalPopulation;

            //Total Bushels
            LblTitleBushels.Text = "Bushels: " + TotalBushels;

            //Bushel Harvest Rate
            HarvestRate = (random.Next(0, 5));
            LblHarvestRate.Text = "Bushel harvest rate: " + HarvestRate;

            //Bushel Harvested
            int Harvested;
            Harvested = HarvestRate * int.Parse(TxtLandPlant.Text);
            LblBushelsHarvested.Text = "Bushels harvested: " + Harvested;
            TotalBushels = Harvested + TotalBushels;

            //Rat Destruction
            RatRate = (random.Next(0, 11));
            int RatTotalDestruction;
            if (RatRate == 5 || RatRate == 6 || RatRate == 7) //30% chance of rats destroying 10%
            {
                RatTotalDestruction = (TotalBushels / 100) * 10;
                TotalBushels = TotalBushels - RatTotalDestruction;
            }
            if (RatRate == 8 || RatRate == 9) //20% chance of rats destroying 20%
            {
                RatTotalDestruction = (TotalBushels / 100) * 20;
                TotalBushels = TotalBushels - RatTotalDestruction;
            }
            if (RatRate == 10) //10% chance of rats destroying 30%
            {
                RatTotalDestruction = (TotalBushels / 100) * 30;
                TotalBushels = TotalBushels - RatTotalDestruction;
            }
            else
            {
                RatTotalDestruction = 0;
            }

            LblRatsDestroyed.Text = "Ammount of bushels destroyed by rats: " + RatTotalDestruction; // shows how many were destroyed




            //Scores
            GlobalVariables.score = (TotalLand + TotalBushels) / TotalPopulation; //score calculation

            if (YearNo ==10) //if year 10 is reached show end game add name and score popup
            {
                //
                High_Score_Pop_Up popup = new High_Score_Pop_Up();
                DialogResult dialogresult = popup.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                        Console.WriteLine("You clicked OK");

                        addrecord(GlobalVariables.name.ToString(), GlobalVariables.score.ToString(), "Scores.txt");
                }
                else if (dialogresult == DialogResult.Cancel)
                {
                        Application.Restart();
                        Console.WriteLine("You clicked either Cancel or X button in the top right corner");
                }
                popup.Dispose();

            }

            if (TotalLand <= 0) //if you run out of land you are declared bankrupt
            {
                MessageBox.Show(String.Join(Environment.NewLine,
                            "*BANKRUPT!*",
                            "",
                            "You have failed in your quest to lead your people!",
                            "",
                            "Your people have starved and the once great empire has fallen!",
                            "",
                            "You should hang your head in shame!"));
            }


            // Add series data to graph
            peopleSeries.Points.Add(TotalPopulation);
            bushelSeries.Points.Add(TotalBushels);
            landSeries.Points.Add(TotalLand);

        }



        private void BtnAutoFeed_Click(object sender, EventArgs e)
        {
            TxtFeed.Text = (20 * TotalPopulation).ToString(); //auto feed button works out how much to feed all and feeds them
        }

        private void BtnRules_Click(object sender, EventArgs e) //rules button clicked shows rules in popup
        {
            MessageBox.Show(String.Join(Environment.NewLine,
                            "*Population Rules*",
                            "• Enter a number into the feeding text box to feed your citizens.",
                            "• Citizens require 20 bushels per turn to survive.",
                            "• If 40% or more of your citizens starve, then the game will end.",
                            "• A random ammount of new citizens between 0 to 10 will enter your kingdom on each turn.",
                            "• There is a 20% chance of 10% of your population dying from the plague.",
                            "• There is a 10% chance of 20% of your population dying from the plague.",
                            "",
                            "*Bushel Rules*",
                            "• You cant plant more acres of bushels than you own.",
                            "• If you run out bushels your population will starve and the game will end.",
                            "• The bushel harvest rate will fluctuate from 0 to 5 so plant carefully.",
                            "• The planted area multiplied by the harvest rate will give you the total harvest.",
                            "• There is a percentage chance of rats destryoing your bushels.",
                            "• There is a 30% chance of rats destroying 10% of your bushels.",
                            "• There is a 20% chance of rats destroying 20% of your bushels.",
                            "• There is a 10% chance of rats destroying 30% of your bushels.",
                            "",
                            "*Land Rules*",
                            "• Land value fluctuates beetween 17-25 bushels per acre.",
                            "• To Buy Land, simply type the number of acres you would like to purchase",
                            "• To sell land please type a minus (-) symbol before the acerage.",
                            "• The planted area multiplied by the harvest rate will give you the total harvest.",
                            "• If you run out of bushels but stll have land, some land will be sold to settle your debt and feed your people",
                            "",
                            "You will go bankrupt if you run out of bushels and land.",
                            "",
                            "Click OK to continue your rule!"));



            
        }
    }
}
