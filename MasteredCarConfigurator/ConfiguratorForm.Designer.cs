namespace MasteredCarConfigurator
{
    partial class ConfiguratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguratorForm));
            this.carPhotoBox = new System.Windows.Forms.PictureBox();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.lblSelectColour = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblPound = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.lblSelectModel = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.lblBMWCarConfigurator = new System.Windows.Forms.Label();
            this.lblBMWModelBlurb = new System.Windows.Forms.Label();
            this.lblEnginePeformance = new System.Windows.Forms.Label();
            this.txtEnginePerformance = new System.Windows.Forms.Label();
            this.txtAcceleration = new System.Windows.Forms.Label();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.txtConsumption = new System.Windows.Forms.Label();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.txtCO2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carModelList = new System.Windows.Forms.ListBox();
            this.btnPrintCarModels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // carPhotoBox
            // 
            this.carPhotoBox.Image = ((System.Drawing.Image)(resources.GetObject("carPhotoBox.Image")));
            this.carPhotoBox.Location = new System.Drawing.Point(127, 82);
            this.carPhotoBox.Name = "carPhotoBox";
            this.carPhotoBox.Size = new System.Drawing.Size(872, 326);
            this.carPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPhotoBox.TabIndex = 0;
            this.carPhotoBox.TabStop = false;
            // 
            // colourComboBox
            // 
            this.colourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Location = new System.Drawing.Point(1046, 132);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(121, 24);
            this.colourComboBox.TabIndex = 1;
            this.colourComboBox.SelectedIndexChanged += new System.EventHandler(this.colourComboBox_SelectedIndexChanged);
            // 
            // lblSelectColour
            // 
            this.lblSelectColour.AutoSize = true;
            this.lblSelectColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectColour.Location = new System.Drawing.Point(1046, 82);
            this.lblSelectColour.Name = "lblSelectColour";
            this.lblSelectColour.Size = new System.Drawing.Size(107, 20);
            this.lblSelectColour.TabIndex = 2;
            this.lblSelectColour.Text = "Select colour";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(395, 424);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(114, 20);
            this.lblCarModel.TabIndex = 3;
            this.lblCarModel.Text = "BMW 118i SE";
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPound.Location = new System.Drawing.Point(630, 424);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(18, 20);
            this.lblPound.TabIndex = 4;
            this.lblPound.Text = "£";
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.AutoSize = true;
            this.lblCarPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPrice.Location = new System.Drawing.Point(644, 424);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(54, 20);
            this.lblCarPrice.TabIndex = 5;
            this.lblCarPrice.Text = "27245";
            // 
            // lblSelectModel
            // 
            this.lblSelectModel.AutoSize = true;
            this.lblSelectModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectModel.Location = new System.Drawing.Point(1050, 215);
            this.lblSelectModel.Name = "lblSelectModel";
            this.lblSelectModel.Size = new System.Drawing.Size(106, 20);
            this.lblSelectModel.TabIndex = 6;
            this.lblSelectModel.Text = "Select model";
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(1050, 262);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 24);
            this.modelComboBox.TabIndex = 7;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // lblBMWCarConfigurator
            // 
            this.lblBMWCarConfigurator.AutoSize = true;
            this.lblBMWCarConfigurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMWCarConfigurator.Location = new System.Drawing.Point(421, 35);
            this.lblBMWCarConfigurator.Name = "lblBMWCarConfigurator";
            this.lblBMWCarConfigurator.Size = new System.Drawing.Size(317, 25);
            this.lblBMWCarConfigurator.TabIndex = 8;
            this.lblBMWCarConfigurator.Text = "BMW Series 1 Car Configurator";
            // 
            // lblBMWModelBlurb
            // 
            this.lblBMWModelBlurb.AutoSize = true;
            this.lblBMWModelBlurb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMWModelBlurb.Location = new System.Drawing.Point(12, 456);
            this.lblBMWModelBlurb.Name = "lblBMWModelBlurb";
            this.lblBMWModelBlurb.Size = new System.Drawing.Size(53, 20);
            this.lblBMWModelBlurb.TabIndex = 9;
            this.lblBMWModelBlurb.Text = "label1";
            // 
            // lblEnginePeformance
            // 
            this.lblEnginePeformance.AutoSize = true;
            this.lblEnginePeformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnginePeformance.Location = new System.Drawing.Point(124, 524);
            this.lblEnginePeformance.Name = "lblEnginePeformance";
            this.lblEnginePeformance.Size = new System.Drawing.Size(159, 20);
            this.lblEnginePeformance.TabIndex = 10;
            this.lblEnginePeformance.Text = "Engine performance";
            // 
            // txtEnginePerformance
            // 
            this.txtEnginePerformance.AutoSize = true;
            this.txtEnginePerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnginePerformance.Location = new System.Drawing.Point(125, 498);
            this.txtEnginePerformance.Name = "txtEnginePerformance";
            this.txtEnginePerformance.Size = new System.Drawing.Size(59, 20);
            this.txtEnginePerformance.TabIndex = 11;
            this.txtEnginePerformance.Text = "label1";
            // 
            // txtAcceleration
            // 
            this.txtAcceleration.AutoSize = true;
            this.txtAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcceleration.Location = new System.Drawing.Point(375, 498);
            this.txtAcceleration.Name = "txtAcceleration";
            this.txtAcceleration.Size = new System.Drawing.Size(59, 20);
            this.txtAcceleration.TabIndex = 12;
            this.txtAcceleration.Text = "label2";
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceleration.Location = new System.Drawing.Point(376, 528);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(102, 20);
            this.lblAcceleration.TabIndex = 13;
            this.lblAcceleration.Text = "Acceleration";
            // 
            // txtConsumption
            // 
            this.txtConsumption.AutoSize = true;
            this.txtConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumption.Location = new System.Drawing.Point(557, 498);
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.Size = new System.Drawing.Size(59, 20);
            this.txtConsumption.TabIndex = 14;
            this.txtConsumption.Text = "label3";
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumption.Location = new System.Drawing.Point(558, 528);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(107, 20);
            this.lblConsumption.TabIndex = 15;
            this.lblConsumption.Text = "Consumption";
            // 
            // txtCO2
            // 
            this.txtCO2.AutoSize = true;
            this.txtCO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCO2.Location = new System.Drawing.Point(737, 501);
            this.txtCO2.Name = "txtCO2";
            this.txtCO2.Size = new System.Drawing.Size(59, 20);
            this.txtCO2.TabIndex = 16;
            this.txtCO2.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(737, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "CO2 Emissions";
            // 
            // carModelList
            // 
            this.carModelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carModelList.FormattingEnabled = true;
            this.carModelList.ItemHeight = 20;
            this.carModelList.Location = new System.Drawing.Point(1021, 511);
            this.carModelList.Name = "carModelList";
            this.carModelList.Size = new System.Drawing.Size(229, 224);
            this.carModelList.TabIndex = 18;
            // 
            // btnPrintCarModels
            // 
            this.btnPrintCarModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCarModels.Location = new System.Drawing.Point(1046, 339);
            this.btnPrintCarModels.Name = "btnPrintCarModels";
            this.btnPrintCarModels.Size = new System.Drawing.Size(175, 38);
            this.btnPrintCarModels.TabIndex = 19;
            this.btnPrintCarModels.Text = "Print car models";
            this.btnPrintCarModels.UseVisualStyleBackColor = true;
            this.btnPrintCarModels.Click += new System.EventHandler(this.btnPrintCarModels_Click);
            // 
            // ConfiguratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 783);
            this.Controls.Add(this.btnPrintCarModels);
            this.Controls.Add(this.carModelList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCO2);
            this.Controls.Add(this.lblConsumption);
            this.Controls.Add(this.txtConsumption);
            this.Controls.Add(this.lblAcceleration);
            this.Controls.Add(this.txtAcceleration);
            this.Controls.Add(this.txtEnginePerformance);
            this.Controls.Add(this.lblEnginePeformance);
            this.Controls.Add(this.lblBMWModelBlurb);
            this.Controls.Add(this.lblBMWCarConfigurator);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.lblSelectModel);
            this.Controls.Add(this.lblCarPrice);
            this.Controls.Add(this.lblPound);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblSelectColour);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.carPhotoBox);
            this.Name = "ConfiguratorForm";
            this.Text = "Configurator Form";
            this.Load += new System.EventHandler(this.ConfiguratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carPhotoBox;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Label lblSelectColour;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.Label lblSelectModel;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label lblBMWCarConfigurator;
        private System.Windows.Forms.Label lblBMWModelBlurb;
        private System.Windows.Forms.Label lblEnginePeformance;
        private System.Windows.Forms.Label txtEnginePerformance;
        private System.Windows.Forms.Label txtAcceleration;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.Label txtConsumption;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.Label txtCO2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox carModelList;
        private System.Windows.Forms.Button btnPrintCarModels;
    }
}

