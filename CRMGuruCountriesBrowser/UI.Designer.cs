
namespace CountryBrowser
{
    partial class UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CountryNameText = new System.Windows.Forms.TextBox();
            this.EnterCountryLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ShowDataBaseButton = new System.Windows.Forms.Button();
            this.ApiConnectLabel = new System.Windows.Forms.Label();
            this.DataBaseConnectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryNameText
            // 
            this.CountryNameText.Location = new System.Drawing.Point(522, 155);
            this.CountryNameText.Name = "CountryNameText";
            this.CountryNameText.Size = new System.Drawing.Size(136, 20);
            this.CountryNameText.TabIndex = 1;
            // 
            // EnterCountryLabel
            // 
            this.EnterCountryLabel.AutoSize = true;
            this.EnterCountryLabel.Location = new System.Drawing.Point(420, 158);
            this.EnterCountryLabel.Name = "EnterCountryLabel";
            this.EnterCountryLabel.Size = new System.Drawing.Size(96, 13);
            this.EnterCountryLabel.TabIndex = 2;
            this.EnterCountryLabel.Text = "Country Full Name:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(574, 181);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(664, 149);
            this.DataGrid.TabIndex = 4;
            // 
            // ShowDataBaseButton
            // 
            this.ShowDataBaseButton.Location = new System.Drawing.Point(12, 155);
            this.ShowDataBaseButton.Name = "ShowDataBaseButton";
            this.ShowDataBaseButton.Size = new System.Drawing.Size(104, 20);
            this.ShowDataBaseButton.TabIndex = 5;
            this.ShowDataBaseButton.Text = "Show Data Base";
            this.ShowDataBaseButton.UseVisualStyleBackColor = true;
            this.ShowDataBaseButton.Click += new System.EventHandler(this.ShowDataBaseButton_Click);
            // 
            // ApiConnectLabel
            // 
            this.ApiConnectLabel.Location = new System.Drawing.Point(238, 67);
            this.ApiConnectLabel.Name = "ApiConnectLabel";
            this.ApiConnectLabel.Size = new System.Drawing.Size(188, 42);
            this.ApiConnectLabel.TabIndex = 6;
            this.ApiConnectLabel.Text = "Connecting to restcountries.eu...";
            this.ApiConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApiConnectLabel.Visible = false;
            // 
            // DataBaseConnectLabel
            // 
            this.DataBaseConnectLabel.Location = new System.Drawing.Point(9, 182);
            this.DataBaseConnectLabel.Name = "DataBaseConnectLabel";
            this.DataBaseConnectLabel.Size = new System.Drawing.Size(140, 22);
            this.DataBaseConnectLabel.TabIndex = 7;
            this.DataBaseConnectLabel.Text = "Connecting to Data Base...";
            this.DataBaseConnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataBaseConnectLabel.Visible = false;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 209);
            this.Controls.Add(this.DataBaseConnectLabel);
            this.Controls.Add(this.ApiConnectLabel);
            this.Controls.Add(this.ShowDataBaseButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EnterCountryLabel);
            this.Controls.Add(this.CountryNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Browser";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CountryNameText;
        private System.Windows.Forms.Label EnterCountryLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button ShowDataBaseButton;
        private System.Windows.Forms.Label ApiConnectLabel;
        private System.Windows.Forms.Label DataBaseConnectLabel;
    }
}

