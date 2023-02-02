namespace Hammurabi_Attempt_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblLandToBuy = new System.Windows.Forms.Label();
            this.LblHowMuchFood = new System.Windows.Forms.Label();
            this.LblHowMuchToFeed = new System.Windows.Forms.Label();
            this.LblHowManyStarved = new System.Windows.Forms.Label();
            this.LblHowManyEnteredTheKingdom = new System.Windows.Forms.Label();
            this.TxtLandBuy = new System.Windows.Forms.TextBox();
            this.TxtFeed = new System.Windows.Forms.TextBox();
            this.TxtLandPlant = new System.Windows.Forms.TextBox();
            this.LblBushelsHarvested = new System.Windows.Forms.Label();
            this.LblHarvestRate = new System.Windows.Forms.Label();
            this.LblRatsDestroyed = new System.Windows.Forms.Label();
            this.LblLandValue = new System.Windows.Forms.Label();
            this.LblYearStats = new System.Windows.Forms.Label();
            this.LblPlagueDeaths = new System.Windows.Forms.Label();
            this.BtnAutoFeed = new System.Windows.Forms.Button();
            this.LblTitlePopulation = new System.Windows.Forms.Label();
            this.LblTitleBushels = new System.Windows.Forms.Label();
            this.LblTitleLand = new System.Windows.Forms.Label();
            this.BtnNextYear = new System.Windows.Forms.Button();
            this.LblTitleProgress = new System.Windows.Forms.Label();
            this.ChartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.YearlyProgressBar = new System.Windows.Forms.ProgressBar();
            this.LblTitleHighScores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblGraphTitleBushels = new System.Windows.Forms.Label();
            this.LblGraphTitlePeople = new System.Windows.Forms.Label();
            this.BtnRules = new System.Windows.Forms.Button();
            this.LblChartLand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLandToBuy
            // 
            this.LblLandToBuy.AutoSize = true;
            this.LblLandToBuy.BackColor = System.Drawing.Color.Transparent;
            this.LblLandToBuy.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLandToBuy.Location = new System.Drawing.Point(979, 566);
            this.LblLandToBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLandToBuy.Name = "LblLandToBuy";
            this.LblLandToBuy.Size = new System.Drawing.Size(156, 20);
            this.LblLandToBuy.TabIndex = 2;
            this.LblLandToBuy.Text = "Acres of land to buy:";
            // 
            // LblHowMuchFood
            // 
            this.LblHowMuchFood.AutoSize = true;
            this.LblHowMuchFood.BackColor = System.Drawing.Color.Transparent;
            this.LblHowMuchFood.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHowMuchFood.Location = new System.Drawing.Point(59, 566);
            this.LblHowMuchFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHowMuchFood.Name = "LblHowMuchFood";
            this.LblHowMuchFood.Size = new System.Drawing.Size(275, 20);
            this.LblHowMuchFood.TabIndex = 2;
            this.LblHowMuchFood.Text = "How many bushels to feed the people:";
            // 
            // LblHowMuchToFeed
            // 
            this.LblHowMuchToFeed.AutoSize = true;
            this.LblHowMuchToFeed.BackColor = System.Drawing.Color.Transparent;
            this.LblHowMuchToFeed.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHowMuchToFeed.Location = new System.Drawing.Point(528, 566);
            this.LblHowMuchToFeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHowMuchToFeed.Name = "LblHowMuchToFeed";
            this.LblHowMuchToFeed.Size = new System.Drawing.Size(263, 20);
            this.LblHowMuchToFeed.TabIndex = 2;
            this.LblHowMuchToFeed.Text = "How many acres to plant with food:";
            // 
            // LblHowManyStarved
            // 
            this.LblHowManyStarved.AutoSize = true;
            this.LblHowManyStarved.BackColor = System.Drawing.Color.Transparent;
            this.LblHowManyStarved.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHowManyStarved.ForeColor = System.Drawing.Color.Black;
            this.LblHowManyStarved.Location = new System.Drawing.Point(59, 618);
            this.LblHowManyStarved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHowManyStarved.Name = "LblHowManyStarved";
            this.LblHowManyStarved.Size = new System.Drawing.Size(190, 22);
            this.LblHowManyStarved.TabIndex = 2;
            this.LblHowManyStarved.Text = "How many people starved:";
            // 
            // LblHowManyEnteredTheKingdom
            // 
            this.LblHowManyEnteredTheKingdom.AutoSize = true;
            this.LblHowManyEnteredTheKingdom.BackColor = System.Drawing.Color.Transparent;
            this.LblHowManyEnteredTheKingdom.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHowManyEnteredTheKingdom.ForeColor = System.Drawing.Color.Black;
            this.LblHowManyEnteredTheKingdom.Location = new System.Drawing.Point(59, 590);
            this.LblHowManyEnteredTheKingdom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHowManyEnteredTheKingdom.Name = "LblHowManyEnteredTheKingdom";
            this.LblHowManyEnteredTheKingdom.Size = new System.Drawing.Size(278, 22);
            this.LblHowManyEnteredTheKingdom.TabIndex = 2;
            this.LblHowManyEnteredTheKingdom.Text = "How many people entered the kingdom:";
            // 
            // TxtLandBuy
            // 
            this.TxtLandBuy.BackColor = System.Drawing.Color.Wheat;
            this.TxtLandBuy.Location = new System.Drawing.Point(1161, 564);
            this.TxtLandBuy.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLandBuy.Name = "TxtLandBuy";
            this.TxtLandBuy.Size = new System.Drawing.Size(132, 22);
            this.TxtLandBuy.TabIndex = 3;
            // 
            // TxtFeed
            // 
            this.TxtFeed.BackColor = System.Drawing.Color.Wheat;
            this.TxtFeed.Location = new System.Drawing.Point(372, 564);
            this.TxtFeed.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFeed.Name = "TxtFeed";
            this.TxtFeed.Size = new System.Drawing.Size(132, 22);
            this.TxtFeed.TabIndex = 3;
            // 
            // TxtLandPlant
            // 
            this.TxtLandPlant.BackColor = System.Drawing.Color.Wheat;
            this.TxtLandPlant.Location = new System.Drawing.Point(831, 564);
            this.TxtLandPlant.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLandPlant.Name = "TxtLandPlant";
            this.TxtLandPlant.Size = new System.Drawing.Size(132, 22);
            this.TxtLandPlant.TabIndex = 3;
            // 
            // LblBushelsHarvested
            // 
            this.LblBushelsHarvested.AutoSize = true;
            this.LblBushelsHarvested.BackColor = System.Drawing.Color.Transparent;
            this.LblBushelsHarvested.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBushelsHarvested.ForeColor = System.Drawing.Color.Black;
            this.LblBushelsHarvested.Location = new System.Drawing.Point(525, 618);
            this.LblBushelsHarvested.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBushelsHarvested.Name = "LblBushelsHarvested";
            this.LblBushelsHarvested.Size = new System.Drawing.Size(135, 22);
            this.LblBushelsHarvested.TabIndex = 2;
            this.LblBushelsHarvested.Text = "Bushels harvested:";
            // 
            // LblHarvestRate
            // 
            this.LblHarvestRate.AutoSize = true;
            this.LblHarvestRate.BackColor = System.Drawing.Color.Transparent;
            this.LblHarvestRate.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHarvestRate.ForeColor = System.Drawing.Color.Black;
            this.LblHarvestRate.Location = new System.Drawing.Point(525, 590);
            this.LblHarvestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHarvestRate.Name = "LblHarvestRate";
            this.LblHarvestRate.Size = new System.Drawing.Size(145, 22);
            this.LblHarvestRate.TabIndex = 2;
            this.LblHarvestRate.Text = "Bushel harvest rate:";
            // 
            // LblRatsDestroyed
            // 
            this.LblRatsDestroyed.AutoSize = true;
            this.LblRatsDestroyed.BackColor = System.Drawing.Color.Transparent;
            this.LblRatsDestroyed.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRatsDestroyed.ForeColor = System.Drawing.Color.Black;
            this.LblRatsDestroyed.Location = new System.Drawing.Point(524, 642);
            this.LblRatsDestroyed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRatsDestroyed.Name = "LblRatsDestroyed";
            this.LblRatsDestroyed.Size = new System.Drawing.Size(271, 22);
            this.LblRatsDestroyed.TabIndex = 2;
            this.LblRatsDestroyed.Text = "Ammount of bushels destroyed by rats:";
            // 
            // LblLandValue
            // 
            this.LblLandValue.AutoSize = true;
            this.LblLandValue.BackColor = System.Drawing.Color.Transparent;
            this.LblLandValue.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLandValue.ForeColor = System.Drawing.Color.Black;
            this.LblLandValue.Location = new System.Drawing.Point(979, 592);
            this.LblLandValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLandValue.Name = "LblLandValue";
            this.LblLandValue.Size = new System.Drawing.Size(149, 22);
            this.LblLandValue.TabIndex = 2;
            this.LblLandValue.Text = "Land value per acre:";
            // 
            // LblYearStats
            // 
            this.LblYearStats.AutoSize = true;
            this.LblYearStats.BackColor = System.Drawing.Color.Transparent;
            this.LblYearStats.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYearStats.ForeColor = System.Drawing.Color.Black;
            this.LblYearStats.Location = new System.Drawing.Point(53, 474);
            this.LblYearStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblYearStats.Name = "LblYearStats";
            this.LblYearStats.Size = new System.Drawing.Size(180, 49);
            this.LblYearStats.TabIndex = 5;
            this.LblYearStats.Text = "Year Stats";
            // 
            // LblPlagueDeaths
            // 
            this.LblPlagueDeaths.AutoSize = true;
            this.LblPlagueDeaths.BackColor = System.Drawing.Color.Transparent;
            this.LblPlagueDeaths.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlagueDeaths.ForeColor = System.Drawing.Color.Black;
            this.LblPlagueDeaths.Location = new System.Drawing.Point(59, 646);
            this.LblPlagueDeaths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPlagueDeaths.Name = "LblPlagueDeaths";
            this.LblPlagueDeaths.Size = new System.Drawing.Size(109, 22);
            this.LblPlagueDeaths.TabIndex = 2;
            this.LblPlagueDeaths.Text = "Plague deaths:";
            // 
            // BtnAutoFeed
            // 
            this.BtnAutoFeed.BackColor = System.Drawing.Color.Transparent;
            this.BtnAutoFeed.FlatAppearance.BorderSize = 0;
            this.BtnAutoFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutoFeed.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAutoFeed.Location = new System.Drawing.Point(592, 415);
            this.BtnAutoFeed.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAutoFeed.Name = "BtnAutoFeed";
            this.BtnAutoFeed.Size = new System.Drawing.Size(83, 59);
            this.BtnAutoFeed.TabIndex = 6;
            this.BtnAutoFeed.Text = "Auto Feed";
            this.BtnAutoFeed.UseVisualStyleBackColor = false;
            this.BtnAutoFeed.Click += new System.EventHandler(this.BtnAutoFeed_Click);
            // 
            // LblTitlePopulation
            // 
            this.LblTitlePopulation.AutoSize = true;
            this.LblTitlePopulation.BackColor = System.Drawing.Color.Transparent;
            this.LblTitlePopulation.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlePopulation.ForeColor = System.Drawing.Color.Black;
            this.LblTitlePopulation.Location = new System.Drawing.Point(55, 523);
            this.LblTitlePopulation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitlePopulation.Name = "LblTitlePopulation";
            this.LblTitlePopulation.Size = new System.Drawing.Size(145, 37);
            this.LblTitlePopulation.TabIndex = 7;
            this.LblTitlePopulation.Text = "Population";
            // 
            // LblTitleBushels
            // 
            this.LblTitleBushels.AutoSize = true;
            this.LblTitleBushels.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleBushels.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleBushels.ForeColor = System.Drawing.Color.Black;
            this.LblTitleBushels.Location = new System.Drawing.Point(525, 523);
            this.LblTitleBushels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleBushels.Name = "LblTitleBushels";
            this.LblTitleBushels.Size = new System.Drawing.Size(106, 37);
            this.LblTitleBushels.TabIndex = 7;
            this.LblTitleBushels.Text = "Bushels";
            // 
            // LblTitleLand
            // 
            this.LblTitleLand.AutoSize = true;
            this.LblTitleLand.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleLand.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleLand.ForeColor = System.Drawing.Color.Black;
            this.LblTitleLand.Location = new System.Drawing.Point(976, 523);
            this.LblTitleLand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleLand.Name = "LblTitleLand";
            this.LblTitleLand.Size = new System.Drawing.Size(78, 37);
            this.LblTitleLand.TabIndex = 7;
            this.LblTitleLand.Text = "Land";
            // 
            // BtnNextYear
            // 
            this.BtnNextYear.BackColor = System.Drawing.Color.Transparent;
            this.BtnNextYear.FlatAppearance.BorderSize = 0;
            this.BtnNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextYear.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextYear.Location = new System.Drawing.Point(707, 415);
            this.BtnNextYear.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNextYear.Name = "BtnNextYear";
            this.BtnNextYear.Size = new System.Drawing.Size(83, 59);
            this.BtnNextYear.TabIndex = 8;
            this.BtnNextYear.Text = "Next year";
            this.BtnNextYear.UseVisualStyleBackColor = false;
            this.BtnNextYear.Click += new System.EventHandler(this.BtnNextYear_Click);
            // 
            // LblTitleProgress
            // 
            this.LblTitleProgress.AutoSize = true;
            this.LblTitleProgress.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleProgress.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleProgress.Location = new System.Drawing.Point(89, 86);
            this.LblTitleProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleProgress.Name = "LblTitleProgress";
            this.LblTitleProgress.Size = new System.Drawing.Size(122, 40);
            this.LblTitleProgress.TabIndex = 5;
            this.LblTitleProgress.Text = "Progress";
            this.LblTitleProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChartScore
            // 
            this.ChartScore.BackColor = System.Drawing.Color.Transparent;
            this.ChartScore.BorderlineColor = System.Drawing.Color.Wheat;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Firebrick;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.MediumBlue;
            chartArea2.BackColor = System.Drawing.Color.Wheat;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 94F;
            chartArea2.Position.Width = 94F;
            this.ChartScore.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.ChartScore.Legends.Add(legend2);
            this.ChartScore.Location = new System.Drawing.Point(23, 119);
            this.ChartScore.Margin = new System.Windows.Forms.Padding(4);
            this.ChartScore.Name = "ChartScore";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.CornflowerBlue;
            series4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsVisibleInLegend = false;
            series4.LabelForeColor = System.Drawing.Color.RoyalBlue;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Red;
            series5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsVisibleInLegend = false;
            series5.LabelForeColor = System.Drawing.Color.Firebrick;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Green;
            series6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.LabelForeColor = System.Drawing.Color.Green;
            series6.Legend = "Legend1";
            series6.Name = "Series3";
            this.ChartScore.Series.Add(series4);
            this.ChartScore.Series.Add(series5);
            this.ChartScore.Series.Add(series6);
            this.ChartScore.Size = new System.Drawing.Size(243, 227);
            this.ChartScore.TabIndex = 15;
            // 
            // YearlyProgressBar
            // 
            this.YearlyProgressBar.BackColor = System.Drawing.Color.Wheat;
            this.YearlyProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.YearlyProgressBar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.YearlyProgressBar.Location = new System.Drawing.Point(300, 487);
            this.YearlyProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearlyProgressBar.Maximum = 10;
            this.YearlyProgressBar.Name = "YearlyProgressBar";
            this.YearlyProgressBar.Size = new System.Drawing.Size(977, 23);
            this.YearlyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.YearlyProgressBar.TabIndex = 9;
            // 
            // LblTitleHighScores
            // 
            this.LblTitleHighScores.AutoSize = true;
            this.LblTitleHighScores.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleHighScores.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleHighScores.Location = new System.Drawing.Point(1154, 86);
            this.LblTitleHighScores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleHighScores.Name = "LblTitleHighScores";
            this.LblTitleHighScores.Size = new System.Drawing.Size(164, 40);
            this.LblTitleHighScores.TabIndex = 5;
            this.LblTitleHighScores.Text = "High Scores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(851, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(339, 373);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(668, 254);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(473, 358);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(821, 350);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(109, 108);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1120, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(231, 231);
            this.dataGridView1.TabIndex = 16;
            // 
            // LblGraphTitleBushels
            // 
            this.LblGraphTitleBushels.AutoSize = true;
            this.LblGraphTitleBushels.BackColor = System.Drawing.Color.Transparent;
            this.LblGraphTitleBushels.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGraphTitleBushels.ForeColor = System.Drawing.Color.Yellow;
            this.LblGraphTitleBushels.Location = new System.Drawing.Point(131, 350);
            this.LblGraphTitleBushels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGraphTitleBushels.Name = "LblGraphTitleBushels";
            this.LblGraphTitleBushels.Size = new System.Drawing.Size(69, 22);
            this.LblGraphTitleBushels.TabIndex = 5;
            this.LblGraphTitleBushels.Text = "Bushels";
            // 
            // LblGraphTitlePeople
            // 
            this.LblGraphTitlePeople.AutoSize = true;
            this.LblGraphTitlePeople.BackColor = System.Drawing.Color.Transparent;
            this.LblGraphTitlePeople.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGraphTitlePeople.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblGraphTitlePeople.Location = new System.Drawing.Point(35, 350);
            this.LblGraphTitlePeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGraphTitlePeople.Name = "LblGraphTitlePeople";
            this.LblGraphTitlePeople.Size = new System.Drawing.Size(96, 22);
            this.LblGraphTitlePeople.TabIndex = 5;
            this.LblGraphTitlePeople.Text = "Population";
            // 
            // BtnRules
            // 
            this.BtnRules.BackColor = System.Drawing.Color.Wheat;
            this.BtnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRules.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRules.Location = new System.Drawing.Point(1283, 487);
            this.BtnRules.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRules.Name = "BtnRules";
            this.BtnRules.Size = new System.Drawing.Size(72, 23);
            this.BtnRules.TabIndex = 17;
            this.BtnRules.Text = "Rules";
            this.BtnRules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRules.UseVisualStyleBackColor = false;
            this.BtnRules.Click += new System.EventHandler(this.BtnRules_Click);
            // 
            // LblChartLand
            // 
            this.LblChartLand.AutoSize = true;
            this.LblChartLand.BackColor = System.Drawing.Color.Transparent;
            this.LblChartLand.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChartLand.ForeColor = System.Drawing.Color.Firebrick;
            this.LblChartLand.Location = new System.Drawing.Point(199, 350);
            this.LblChartLand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblChartLand.Name = "LblChartLand";
            this.LblChartLand.Size = new System.Drawing.Size(50, 22);
            this.LblChartLand.TabIndex = 5;
            this.LblChartLand.Text = "Land";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 703);
            this.Controls.Add(this.BtnRules);
            this.Controls.Add(this.LblTitleProgress);
            this.Controls.Add(this.LblGraphTitlePeople);
            this.Controls.Add(this.LblChartLand);
            this.Controls.Add(this.LblGraphTitleBushels);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChartScore);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTitleHighScores);
            this.Controls.Add(this.YearlyProgressBar);
            this.Controls.Add(this.LblYearStats);
            this.Controls.Add(this.LblTitlePopulation);
            this.Controls.Add(this.BtnNextYear);
            this.Controls.Add(this.LblHowManyEnteredTheKingdom);
            this.Controls.Add(this.LblTitleLand);
            this.Controls.Add(this.LblHowManyStarved);
            this.Controls.Add(this.LblTitleBushels);
            this.Controls.Add(this.LblPlagueDeaths);
            this.Controls.Add(this.BtnAutoFeed);
            this.Controls.Add(this.TxtLandPlant);
            this.Controls.Add(this.TxtFeed);
            this.Controls.Add(this.TxtLandBuy);
            this.Controls.Add(this.LblLandValue);
            this.Controls.Add(this.LblHarvestRate);
            this.Controls.Add(this.LblRatsDestroyed);
            this.Controls.Add(this.LblBushelsHarvested);
            this.Controls.Add(this.LblHowMuchToFeed);
            this.Controls.Add(this.LblHowMuchFood);
            this.Controls.Add(this.LblLandToBuy);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblLandToBuy;
        private System.Windows.Forms.Label LblHowMuchFood;
        private System.Windows.Forms.Label LblHowMuchToFeed;
        private System.Windows.Forms.Label LblHowManyStarved;
        private System.Windows.Forms.Label LblHowManyEnteredTheKingdom;
        private System.Windows.Forms.TextBox TxtLandBuy;
        private System.Windows.Forms.TextBox TxtFeed;
        private System.Windows.Forms.TextBox TxtLandPlant;
        private System.Windows.Forms.Label LblBushelsHarvested;
        private System.Windows.Forms.Label LblHarvestRate;
        private System.Windows.Forms.Label LblRatsDestroyed;
        private System.Windows.Forms.Label LblLandValue;
        private System.Windows.Forms.Label LblYearStats;
        private System.Windows.Forms.Label LblPlagueDeaths;
        private System.Windows.Forms.Button BtnAutoFeed;
        private System.Windows.Forms.Label LblTitlePopulation;
        private System.Windows.Forms.Label LblTitleBushels;
        private System.Windows.Forms.Label LblTitleLand;
        private System.Windows.Forms.Button BtnNextYear;
        private System.Windows.Forms.Label LblTitleProgress;
        private System.Windows.Forms.ProgressBar YearlyProgressBar;
        private System.Windows.Forms.Label LblTitleHighScores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblGraphTitleBushels;
        private System.Windows.Forms.Label LblGraphTitlePeople;
        private System.Windows.Forms.Button BtnRules;
        private System.Windows.Forms.Label LblChartLand;
    }
}

