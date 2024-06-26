﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasteredCarConfigurator
{
    public partial class ConfiguratorForm : Form
    {
        private const int originalCarPrice = 27245;
        private const int metallicPriceIncrease = 595;
        private const int sportIncrease = 1040;
        private const int mSportIncrease = 2840;
        int totalPrice;
        readonly double sportConsumption = 0.9;
        readonly double originalConsumption = 49.6;
        readonly double mSportConsumption = 1.7;
        double totalConsumption;
        private const int originalCO2 = 130;
        private const int sportCO2Increase = 1;
        private const int mSportCO2Increase = 4;
        int totalCO2;

        
        public ConfiguratorForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            lblBMWModelBlurb.Text = "The SE model marks the entry point to the range, offering a high level of standard equipment and trademark BMW driving dynamics.";
            txtEnginePerformance.Text = "100KW";
            txtAcceleration.Text = "8.9 s";
            txtConsumption.Text = "49.6 mpg";
            txtCO2.Text = "130 g/km";
            colourComboBox.Items.Add(new CarColour() { Colour = "White", Image = "WhiteCar.png" }); //Added white colour with white sports SE car image
            colourComboBox.Items.Add(new CarColour() { Colour = "Black", Image = "BlackCar.png" }); //Added black colour with black sports SE car image
            colourComboBox.Items.Add(new CarColour() { Colour = "Metallic Red", Image = "RedCar.png" }); //Added metallic red colour with red SE car image
            colourComboBox.Items.Add(new CarColour() { Colour = "Metallic Blue", Image = "BlueCar.png" }); //Added metallic blue colour with blue SE car image
            modelComboBox.Items.Add(new CarModel() { Model = "Sport", Image = "BlackSportsCar.png" }); //Licence plate ending with 5046
            modelComboBox.Items.Add(new CarModel() { Model = "SE", Image = "BlackCar.png" }); //Licence plate ending with 8158
            modelComboBox.Items.Add(new CarModel() { Model = "M Sport", Image = "WhiteMSportsCar.png" }); //Licence plate ending with 1887
        }

        private void UpdatePriceandImage()
        {
            if (modelComboBox.SelectedItem == null)
            {
                // handle the error
                return;
            }

            switch (colourComboBox.SelectedIndex)
            {

                case -1:
                    var imageName = ((CarColour)colourComboBox.SelectedItem).Image;
                    var file = System.IO.Path.Combine(Application.StartupPath, "Images", imageName);
                    carPhotoBox.Image = Image.FromFile(file);
                    break;
            }
            //Differentiating between metallic (blue, red) and non-metallic colours (white, black)
            switch (colourComboBox.SelectedIndex)
            {
                case 0:
                case 1 when modelComboBox.SelectedIndex < -1:
                    lblCarPrice.Text = "27245";
                    break;
            }
            switch (colourComboBox.SelectedIndex)
            {
                case 2:
                case 3 when modelComboBox.SelectedIndex < -1:
                    totalPrice = originalCarPrice + metallicPriceIncrease;
                    lblCarPrice.Text = totalPrice.ToString();
                    break;
            }
            //Multiple if statements with AND operator for two combobox conditions e.g. if colour is white and model is Sport or if colour is white and model is SE
            if (colourComboBox.SelectedIndex == 0 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\WhiteSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 0 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\WhiteCar.png");
                lblCarPrice.Text = "27245";

            }
            if (colourComboBox.SelectedIndex == 0 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\WhiteMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease;
                lblCarPrice.Text = totalPrice.ToString();

            }
            if (colourComboBox.SelectedIndex == 1 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlackSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease;
                lblCarPrice.Text = totalPrice.ToString();

            }
            if (colourComboBox.SelectedIndex == 1 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlackCar.png");
                lblCarPrice.Text = "27245";
            }
            if (colourComboBox.SelectedIndex == 1 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlackMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 2 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\RedSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 2 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\RedCar.png");
                totalPrice = originalCarPrice + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 2 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\RedMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 3 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlueSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 3 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlueCar.png");
                totalPrice = originalCarPrice + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 3 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlueMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }

            switch (modelComboBox.SelectedIndex)
            {
                case -1:
                        var spimageName = ((CarModel)modelComboBox.SelectedItem).Image;
                        var spfile = System.IO.Path.Combine(Application.StartupPath, "Images", spimageName);
                        carPhotoBox.Image = Image.FromFile(spfile);
                        break;

                case 0:
                    totalPrice = originalCarPrice + sportIncrease;
                    lblCarPrice.Text = totalPrice.ToString();
                    lblCarModel.Text = "BMW 118i Sport";
                    lblBMWModelBlurb.Text = "The Sport model offers a more athletic look with High-gloss Shadowline exterior design elements as well as upgraded light alloy wheels.";
                    totalConsumption = originalConsumption - sportConsumption;
                    txtConsumption.Text = totalConsumption.ToString() + " mpg";
                    totalCO2 = originalCO2 + sportCO2Increase;
                    txtCO2.Text = totalCO2.ToString() + " g/km";
                    break;

                case 1:
                    lblCarModel.Text = "BMW 118i SE";
                    lblCarPrice.Text = "27245";
                    txtEnginePerformance.Text = "100KW";
                    txtConsumption.Text = "49.6 mpg";
                    lblBMWModelBlurb.Text = "The SE model marks the entry point to the range, offering a high level of standard equipment and trademark BMW driving dynamics.";
                    txtCO2.Text = "130 g/km";
                    break;

                case 2:
                    totalPrice = originalCarPrice + mSportIncrease;
                    lblCarPrice.Text = totalPrice.ToString();
                    lblCarModel.Text = "BMW 118i M Sport";
                    lblBMWModelBlurb.Text = "The M Sport model offers a sharpened appearance with M Sport aerodynamic bodystyling, High-gloss Shadowline exterior trim and 19\" M alloy wheels.";
                    totalConsumption = originalConsumption - mSportConsumption;
                    txtConsumption.Text = totalConsumption.ToString() + " mpg";
                    totalCO2 = originalCO2 + mSportCO2Increase;
                    txtCO2.Text = totalCO2.ToString() + " g/km";
                    break;
            }
            //Multiple if statements with AND operator for two combobox conditions e.g. if colour is white and model is Sport or if colour is white and model is SE
            if (colourComboBox.SelectedIndex == 0 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\WhiteSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 0 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\WhiteCar.png");
                lblCarPrice.Text = "27245";
            }
            if (colourComboBox.SelectedIndex == 0 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\WhiteMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 1 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlackSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 1 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlackCar.png");
                lblCarPrice.Text = "27245";

            }
            if (colourComboBox.SelectedIndex == 1 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlackMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 2 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\RedSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 2 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\RedCar.png");
                totalPrice = originalCarPrice + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 2 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\RedMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 3 && modelComboBox.SelectedIndex == 0)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlueSportsCar.png");
                totalPrice = originalCarPrice + sportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 3 && modelComboBox.SelectedIndex == 1)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlueCar.png");
                totalPrice = originalCarPrice + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
            if (colourComboBox.SelectedIndex == 3 && modelComboBox.SelectedIndex == 2)
            {
                carPhotoBox.Image = Image.FromFile("Images\\BlueMSportsCar.png");
                totalPrice = originalCarPrice + mSportIncrease + metallicPriceIncrease;
                lblCarPrice.Text = totalPrice.ToString();
            }
        }

        private void colourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceandImage();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceandImage();
        }

        private void btnPrintCarModels_Click(object sender, EventArgs e)
        {
            PrintCarModels();
        }

        private void PrintCarModels()
        {
            carModelList.Items.Add(modelComboBox.Items[0]);
            carModelList.Items.Add("Consumption - 48.7 mpg");
            carModelList.Items.Add("CO2 - 131 g/km");
            carModelList.Items.Add(modelComboBox.Items[1]);
            carModelList.Items.Add("Consumption - 49.6 mpg");
            carModelList.Items.Add("CO2 - 130 g/km");
            carModelList.Items.Add(modelComboBox.Items[2]);
            carModelList.Items.Add("Consumption - 47.9 mpg");
            carModelList.Items.Add("CO2 - 134 g/km");
        }
    }
}
