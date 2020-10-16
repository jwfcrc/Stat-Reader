using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Statistics_Reader
{
    public partial class Form1 : Form
    {
        //Variables
        int InfoCount = 0;
        int DirectCount = 0;
        int TechCount = 0;
        int TeleCount = 0;
        int EContCount = 0;
        int TotalCount = 0;
        int DoorCount = 0;
        int numberOfInfoFiles = 0;

        string[] files;
        string defaultPath = Library_Statistics_Reader.Properties.Settings.Default.FileLocation;

        bool isFromDateChosen = false;
        bool isToDateChosen = false;
        bool isFolderChosen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void LocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //format for date pickers
        public void SetMyCustomFormat()
        {
            FromDatePicker.Format = DateTimePickerFormat.Custom;
            FromDatePicker.CustomFormat = " ";
            ToDatePicker.Format = DateTimePickerFormat.Custom;
            ToDatePicker.CustomFormat = " ";
        }

        //initialise form
        private void Form1_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();

            //check if default filepath exists
            if (Directory.Exists(defaultPath))
            {
                files = Directory.GetFiles(defaultPath);
                isFolderChosen = true;
                FileLocationLabel.Text = defaultPath;
            }
        }

        private void FromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format type and the CustomFormat string.
            FromDatePicker.Format = DateTimePickerFormat.Custom;
            FromDatePicker.CustomFormat = "dd-MM-yyyy";

            //set to date minimum to chosen from date
            ToDatePicker.MinDate = FromDatePicker.Value;

            //set boolean
            isFromDateChosen = true;
        }

        private void ToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format type and the CustomFormat string.
            ToDatePicker.Format = DateTimePickerFormat.Custom;
            ToDatePicker.CustomFormat = "dd-MM-yyyy";

            //set from date maximum to chosen to date
            FromDatePicker.MaxDate = ToDatePicker.Value;

            //set boolean
            isToDateChosen = true;
        }

        private void ToDatePicker_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TechEnqLabel_Click(object sender, EventArgs e)
        {

        }

        private void InfoEnqTotLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {

            //Check Location is entered
            if (LocationComboBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please select a location");
            }
            //Check that dates are chosen
            else if (!isFromDateChosen || !isToDateChosen)
            {
                System.Windows.Forms.MessageBox.Show("Please select a To and From Date");
            }
            else if (!isFolderChosen)
            {
                System.Windows.Forms.MessageBox.Show("Please select a file location");
            }

            else
            {
                //variables to store file information in
                int GetInfoCount = 0;
                int GetDirectCount = 0;
                int GetTechCount = 0;
                int GetTeleCount = 0;
                int GetEContCount = 0;
                int GetTotalCount = 0;
                int GetDoorCount = 0;
                int FileCount = 0;

                //initialise data list
                List<int> dataList = new List<int>();

                //reset counters
                InfoCount = 0;
                DirectCount = 0;
                TechCount = 0;
                TeleCount = 0;
                EContCount = 0;
                TotalCount = 0;
                DoorCount = 0;
                numberOfInfoFiles = 0;

                //reset avg labels
                InfoAvg.Text = "0";
                DirAvg.Text = "0";
                TechAvg.Text = "0";
                TeleAvg.Text = "0";
                EContAvg.Text = "0";
                TotAvg.Text = "0";


                //date range
                DateTime fromDate = FromDatePicker.Value;
                DateTime toDate = ToDatePicker.Value;




                if (isFolderChosen)
                {


                    //check each file in search directory
                    foreach (string fileStr in files)
                    {

                        //check if file has the correct location code
                        if (fileStr.Contains(LocationComboBox.Text)|| LocationComboBox.Text == "All")
                        {
                            if (LocationComboBox.Text == "MB" && fileStr.Contains("Toy"))
                            {
                                // Do nothing
                            }
                            else
                            {
                                //set start variable for date loop
                                DateTime calcDate = fromDate;


                                //check if file is in correct date range
                                while (toDate >= calcDate)
                                {

                                    if (fileStr.Contains(calcDate.ToString("dd-MM-yyyy")))
                                    {
                                        //read file
                                        FileCount++;

                                        string fileContentsStr = File.ReadAllText(fileStr);
                                        //Debug.Print(fileContentsStr);



                                        string[] digits = Regex.Split(fileContentsStr, @"\D+");
                                        foreach (string value in digits)
                                        {
                                            int number;
                                            if (int.TryParse(value, out number))
                                            {
                                                //Debug.Print(value);
                                                dataList.Add(number);
                                            }


                                        }

                                        //store each count from the file in variables and add to existing counter variables from the form
                                        GetInfoCount = dataList[3];
                                        InfoCount += GetInfoCount;

                                        GetDirectCount = dataList[4];
                                        DirectCount += GetDirectCount;

                                        GetTechCount = dataList[5];
                                        TechCount += GetTechCount;

                                        GetTeleCount = dataList[6];
                                        TeleCount += GetTeleCount;

                                        GetEContCount = dataList[7];
                                        EContCount += GetEContCount;

                                        GetTotalCount = dataList[8];
                                        TotalCount += GetTotalCount;

                                        GetDoorCount = dataList[9];
                                        DoorCount += GetDoorCount;

                                        //check if file was info via doorcount
                                        if (GetDoorCount == 0)
                                        {
                                            numberOfInfoFiles++;
                                        }

                                        //clear datalist for new data
                                        dataList.Clear();

                                    }
                                    //increment day
                                    calcDate = calcDate.AddDays(1);

                                }
                            }
                        }
                        //Tot
                        InfoEnqTotLabel.Text = InfoCount.ToString();
                        DirectEnqTotLabel.Text = DirectCount.ToString();
                        TechEnqTotLabel.Text = TechCount.ToString();
                        TeleEnqTotLabel.Text = TeleCount.ToString();
                        EContEnqTotLabel.Text = EContCount.ToString();
                        TotCountLabel.Text = TotalCount.ToString();
                        DoorTotLabel.Text = DoorCount.ToString();

                        // Avg
                        if (FileCount > 0)
                        {
                            if (numberOfInfoFiles == FileCount)
                            {
                                numberOfInfoFiles = 0;
                            }
                            InfoAvg.Text = ((Double)InfoCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                            DirAvg.Text = ((Double)DirectCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                            TechAvg.Text = ((Double)TechCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                            TeleAvg.Text = ((Double)TeleCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                            EContAvg.Text = ((Double)EContCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                            TotAvg.Text = ((Double)TotalCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                            DoorAvg.Text = ((Double)DoorCount / ((Double)FileCount - (Double)numberOfInfoFiles)).ToString("f2");
                        }



                        FileCountDisplay.Text = FileCount.ToString();
                        //System.Windows.Forms.MessageBox.Show("Files found: " + FileCount.ToString(), "Results");
                    }

                }


            }


        }

        private void FileLocationButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (FileLocationLabel.Text.Length > 1)
                {
                    fbd.SelectedPath = FileLocationLabel.Text;
                }
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);
                    isFolderChosen = true;
                    FileLocationLabel.Text = fbd.SelectedPath.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FileCountDisplay_Click(object sender, EventArgs e)
        {

        }

        private void FileLocationButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(FileLocationButton, "Click to select stat file location");
        }

        private void LocationComboBox_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(LocationComboBox, "Click to select physical location for stat collection");
        }

        private void ResultsButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(ResultsButton, "Click to collect and calculate results");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(label1, "The number of files found in the search (one file per day per location).");
        }

        private void FromDatePicker_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(FromDatePicker, "Click to select the beginning of the date range you would like to search");
        }

        private void ToDatePicker_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(ToDatePicker, "Click to select the end of the date range you would like to search");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://intracfrasercoast.qld.gov.au/drf/?3512115");
        }

        private void DocsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://intrac.frasercoast.qld.gov.au/drf/?3512115");
        }
    }
}
