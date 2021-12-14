using ParametrizationApp.WinForms.Models;
using ParametrizationApp.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParametrizationWinFormsApp
{
    public partial class MainForm : Form
    {
        public ParametrizationService parametrizationService { get; set; } = new ParametrizationService();
        public Parametrization parametrization { get; set; } = new Parametrization();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            parametrization = parametrizationService.ReadParametrization();
            LoadParametrizationInFormFields(); 
        }

        private void LoadParametrizationInFormFields()
        {
            txtBoxUserName.Text = parametrization.Username; 
        }
    }
}
