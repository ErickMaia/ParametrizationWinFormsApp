using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrizationApp.WinForms.Models
{
    public class Parametrization
    {
        private Parametrization parametrization;

        public Parametrization(string username, string password, string email, string inputPath, string outputPath, int minutesBeforeIntegration)
        {
            Username = username;
            Password = password;
            Email = email;
            InputPath = inputPath;
            OutputPath = outputPath;
            MinutesBeforeIntegration = minutesBeforeIntegration;
        }

        public Parametrization()
        {
            Username = "";
            Password = "";
            Email = "";
            InputPath = "";
            OutputPath = "";
            MinutesBeforeIntegration = 30;
        }

        public Parametrization(Parametrization parametrization)
        {
            this.parametrization = parametrization;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public int MinutesBeforeIntegration { get; set; }

	}
}
