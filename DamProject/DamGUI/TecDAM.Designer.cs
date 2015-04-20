namespace DamProject.DamGUI
{
    partial class TecDAM
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
            this._imgDamPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtWaterFlowSpeed = new System.Windows.Forms.TextBox();
            this._BtnApply = new System.Windows.Forms.Button();
            this._lblHeightReservoir = new System.Windows.Forms.Label();
            this._lblWaterMeter = new System.Windows.Forms.Label();
            this._lblWaterLevel = new System.Windows.Forms.Label();
            this._lblRiverHeight = new System.Windows.Forms.Label();
            this._CmbTurbine = new System.Windows.Forms.ComboBox();
            this._BtnAddTurbine = new System.Windows.Forms.Button();
            this._TurbineProperties = new System.Windows.Forms.Panel();
            this._lblTurbineKiloWatts = new System.Windows.Forms.Label();
            this._lblKilowattsName = new System.Windows.Forms.Label();
            this._chkTurbineEnable = new System.Windows.Forms.CheckBox();
            this._lblTotalTwName = new System.Windows.Forms.Label();
            this._LblDamKiloWatts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._imgDamPicture)).BeginInit();
            this._TurbineProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // _imgDamPicture
            // 
            this._imgDamPicture.BackgroundImage = global::DamProject.DamGUI.Properties.Resources.dam;
            this._imgDamPicture.Location = new System.Drawing.Point(70, 45);
            this._imgDamPicture.Name = "_imgDamPicture";
            this._imgDamPicture.Size = new System.Drawing.Size(621, 240);
            this._imgDamPicture.TabIndex = 0;
            this._imgDamPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Velocidad del caudal de entrada:";
            // 
            // _txtWaterFlowSpeed
            // 
            this._txtWaterFlowSpeed.Location = new System.Drawing.Point(612, 24);
            this._txtWaterFlowSpeed.Name = "_txtWaterFlowSpeed";
            this._txtWaterFlowSpeed.Size = new System.Drawing.Size(67, 20);
            this._txtWaterFlowSpeed.TabIndex = 2;
            // 
            // _BtnApply
            // 
            this._BtnApply.Location = new System.Drawing.Point(697, 24);
            this._BtnApply.Name = "_BtnApply";
            this._BtnApply.Size = new System.Drawing.Size(69, 22);
            this._BtnApply.TabIndex = 3;
            this._BtnApply.Text = "Aplicar";
            this._BtnApply.UseVisualStyleBackColor = true;
            this._BtnApply.Click += new System.EventHandler(this._BtnApply_Click);
            // 
            // _lblHeightReservoir
            // 
            this._lblHeightReservoir.AutoSize = true;
            this._lblHeightReservoir.Location = new System.Drawing.Point(33, 60);
            this._lblHeightReservoir.Name = "_lblHeightReservoir";
            this._lblHeightReservoir.Size = new System.Drawing.Size(47, 13);
            this._lblHeightReservoir.TabIndex = 4;
            this._lblHeightReservoir.Text = "Embalse";
            // 
            // _lblWaterMeter
            // 
            this._lblWaterMeter.AutoSize = true;
            this._lblWaterMeter.Location = new System.Drawing.Point(20, 126);
            this._lblWaterMeter.Name = "_lblWaterMeter";
            this._lblWaterMeter.Size = new System.Drawing.Size(60, 13);
            this._lblWaterMeter.TabIndex = 5;
            this._lblWaterMeter.Text = "altura agua";
            // 
            // _lblWaterLevel
            // 
            this._lblWaterLevel.AutoSize = true;
            this._lblWaterLevel.Location = new System.Drawing.Point(280, 86);
            this._lblWaterLevel.Name = "_lblWaterLevel";
            this._lblWaterLevel.Size = new System.Drawing.Size(113, 13);
            this._lblWaterLevel.TabIndex = 6;
            this._lblWaterLevel.Text = "cantidad de agua cm3";
            // 
            // _lblRiverHeight
            // 
            this._lblRiverHeight.AutoSize = true;
            this._lblRiverHeight.Location = new System.Drawing.Point(652, 150);
            this._lblRiverHeight.Name = "_lblRiverHeight";
            this._lblRiverHeight.Size = new System.Drawing.Size(47, 13);
            this._lblRiverHeight.TabIndex = 7;
            this._lblRiverHeight.Text = "altura rio";
            // 
            // _CmbTurbine
            // 
            this._CmbTurbine.FormattingEnabled = true;
            this._CmbTurbine.Location = new System.Drawing.Point(299, 246);
            this._CmbTurbine.Name = "_CmbTurbine";
            this._CmbTurbine.Size = new System.Drawing.Size(110, 21);
            this._CmbTurbine.TabIndex = 8;
            // 
            // _BtnAddTurbine
            // 
            this._BtnAddTurbine.Location = new System.Drawing.Point(24, 327);
            this._BtnAddTurbine.Name = "_BtnAddTurbine";
            this._BtnAddTurbine.Size = new System.Drawing.Size(109, 28);
            this._BtnAddTurbine.TabIndex = 9;
            this._BtnAddTurbine.Text = "Agregar Turbina";
            this._BtnAddTurbine.UseVisualStyleBackColor = true;
            // 
            // _TurbineProperties
            // 
            this._TurbineProperties.Controls.Add(this._lblTurbineKiloWatts);
            this._TurbineProperties.Controls.Add(this._lblKilowattsName);
            this._TurbineProperties.Controls.Add(this._chkTurbineEnable);
            this._TurbineProperties.Location = new System.Drawing.Point(244, 302);
            this._TurbineProperties.Name = "_TurbineProperties";
            this._TurbineProperties.Size = new System.Drawing.Size(233, 53);
            this._TurbineProperties.TabIndex = 10;
            // 
            // _lblTurbineKiloWatts
            // 
            this._lblTurbineKiloWatts.AutoSize = true;
            this._lblTurbineKiloWatts.Location = new System.Drawing.Point(142, 28);
            this._lblTurbineKiloWatts.Name = "_lblTurbineKiloWatts";
            this._lblTurbineKiloWatts.Size = new System.Drawing.Size(13, 13);
            this._lblTurbineKiloWatts.TabIndex = 2;
            this._lblTurbineKiloWatts.Text = "0";
            // 
            // _lblKilowattsName
            // 
            this._lblKilowattsName.AutoSize = true;
            this._lblKilowattsName.Location = new System.Drawing.Point(10, 26);
            this._lblKilowattsName.Name = "_lblKilowattsName";
            this._lblKilowattsName.Size = new System.Drawing.Size(113, 13);
            this._lblKilowattsName.TabIndex = 1;
            this._lblKilowattsName.Text = "Kilovatios producidos: ";
            // 
            // _chkTurbineEnable
            // 
            this._chkTurbineEnable.AutoSize = true;
            this._chkTurbineEnable.Location = new System.Drawing.Point(7, 3);
            this._chkTurbineEnable.Name = "_chkTurbineEnable";
            this._chkTurbineEnable.Size = new System.Drawing.Size(73, 17);
            this._chkTurbineEnable.TabIndex = 0;
            this._chkTurbineEnable.Text = "Habilitado";
            this._chkTurbineEnable.UseVisualStyleBackColor = true;
            // 
            // _lblTotalTwName
            // 
            this._lblTotalTwName.AutoSize = true;
            this._lblTotalTwName.Location = new System.Drawing.Point(527, 309);
            this._lblTotalTwName.Name = "_lblTotalTwName";
            this._lblTotalTwName.Size = new System.Drawing.Size(213, 13);
            this._lblTotalTwName.TabIndex = 11;
            this._lblTotalTwName.Text = "Total de Kilovatios producidos en la planta: ";
            // 
            // _LblDamKiloWatts
            // 
            this._LblDamKiloWatts.AutoSize = true;
            this._LblDamKiloWatts.Location = new System.Drawing.Point(622, 340);
            this._LblDamKiloWatts.Name = "_LblDamKiloWatts";
            this._LblDamKiloWatts.Size = new System.Drawing.Size(13, 13);
            this._LblDamKiloWatts.TabIndex = 12;
            this._LblDamKiloWatts.Text = "0";
            // 
            // TecDAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(779, 381);
            this.Controls.Add(this._LblDamKiloWatts);
            this.Controls.Add(this._lblTotalTwName);
            this.Controls.Add(this._TurbineProperties);
            this.Controls.Add(this._BtnAddTurbine);
            this.Controls.Add(this._CmbTurbine);
            this.Controls.Add(this._lblRiverHeight);
            this.Controls.Add(this._lblWaterLevel);
            this.Controls.Add(this._lblWaterMeter);
            this.Controls.Add(this._lblHeightReservoir);
            this.Controls.Add(this._BtnApply);
            this.Controls.Add(this._txtWaterFlowSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._imgDamPicture);
            this.Name = "TecDAM";
            this.Text = "TecDAM";
            this.Load += new System.EventHandler(this.TecDAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imgDamPicture)).EndInit();
            this._TurbineProperties.ResumeLayout(false);
            this._TurbineProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgDamPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtWaterFlowSpeed;
        private System.Windows.Forms.Button _BtnApply;
        private System.Windows.Forms.Label _lblHeightReservoir;
        private System.Windows.Forms.Label _lblWaterMeter;
        private System.Windows.Forms.Label _lblWaterLevel;
        private System.Windows.Forms.Label _lblRiverHeight;
        private System.Windows.Forms.ComboBox _CmbTurbine;
        private System.Windows.Forms.Button _BtnAddTurbine;
        private System.Windows.Forms.Panel _TurbineProperties;
        private System.Windows.Forms.CheckBox _chkTurbineEnable;
        private System.Windows.Forms.Label _lblKilowattsName;
        private System.Windows.Forms.Label _lblTurbineKiloWatts;
        private System.Windows.Forms.Label _lblTotalTwName;
        private System.Windows.Forms.Label _LblDamKiloWatts;
    }
}