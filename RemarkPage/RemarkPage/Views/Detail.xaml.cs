using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RemarkPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentView
    {
        public Detail()
        {
            InitializeComponent();
            Txt.Text = "JKJFDJF jkjfgkjkf jkmmvnckj flşldşf şf  şfjkjfflş"
                        + "JKJFDJF jkjfgkjkf jkmmvnckj flşldşf şf  şfjkjfflş"
                        + "JKJFDJF jkjfgkjkf jkmmvnckj flşldşf şf  şfjkjfflş"
                        + "JKJFDJF jkjfgkjkf jkmmvnckj flşldşf şf  şfjkjfflş";
        }
    }
}