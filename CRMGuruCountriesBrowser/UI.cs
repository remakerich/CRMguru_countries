using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryBrowser
{
    public partial class UI : Form
    {
        public static HttpClient Client { get; set; }

        public UI()
        {
            InitializeComponent();            
            Client = new HttpClient();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(CountryNameText.Text)) 
            {
                Popups.EmptyTextFieldError();               
                return;
            }

            ApiConnectLabel.Visible = true;
            CountryModel country = new CountryModel();
            try
            {
                country = await ApiCall.LoadCountry(CountryNameText.Text);
            }
            catch (Exception ex)
            {
                Popups.ErrorMessage(ex.Message);
                country.Name = "error";
            }
            ApiConnectLabel.Visible = false;

            if (country.Name == null)
            {                
                Popups.CountryNotFound();
            }
            else if (country.Name != "error")
            {                
                DataGrid.DataSource = new List<CountryModel> { country };
                if (Popups.UpdateRequest() == DialogResult.Yes)
                {
                    DataBaseConnectLabel.Visible = true;
                    await Task.Run(() =>
                    {
                        try
                        {
                            DataAccess.UpdateCountry(country);
                        }
                        catch (Exception ex)
                        {
                            Popups.ErrorMessage(ex.Message);
                        }
                    });
                    DataBaseConnectLabel.Visible = false;
                }
            }            
        }

        private async void ShowDataBaseButton_Click(object sender, EventArgs e)
        {
            DataBaseConnectLabel.Visible = true;
            List<CountryModel> data = new List<CountryModel>();
            await Task.Run(() => 
            {                
                try
                {                    
                    data = DataAccess.ShowAllCountries();
                }
                catch (Exception ex)
                {
                    Popups.ErrorMessage(ex.Message);
                }
            });
            DataBaseConnectLabel.Visible = false;
            if (data.Count != 0)
                DataGrid.DataSource = data;
        }
    }
}
