using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrizationApp.Core.Models
{
    public class Parametrization
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public int MinutesBeforeIntegration { get; set; }

	}
}
