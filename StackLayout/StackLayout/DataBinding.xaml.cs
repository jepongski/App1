using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBinding : ContentPage
	{
	   public string Quotes { get; set; }

		public DataBinding ()
		{
		    Quotes = "I am so clever that sometimes I don\'t understand a single word of what I am saying.";
            InitializeComponent();

		    Quote.Text = Quotes;

		}

	}
}