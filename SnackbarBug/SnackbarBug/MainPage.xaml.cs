using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;

namespace SnackbarBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var options = new SnackBarOptions
            {
                MessageOptions = new MessageOptions
                {
                    Foreground = Color.DodgerBlue,
                    Padding = new Thickness(10, 20, 30, 40),
                    Message = "Pour supprimer un élément de votre liste hors connexion, faites glisser l'élément vers la droite"
                },
                BackgroundColor = Color.Aquamarine,
                Duration = TimeSpan.FromSeconds(5),
                CornerRadius = new Thickness(10, 20, 30, 40),
                Actions = new[]
                {
                    new SnackBarActionOptions
                    {
                        Text = "I've completed this",
                        BackgroundColor = (Color.Aqua),
                        ForegroundColor = Color.Brown,
                        Padding = new Thickness(40, 30, 20, 10),
                        Action = () => Task.FromResult(true)
                    },
					// new SnackBarActionOptions
					// {
					// 	Text = "I've completed this",
					// 	BackgroundColor = (Color.Aqua),
					// 	ForegroundColor = Color.Brown,
					// 	Padding = new Thickness(40, 30, 20, 10),
					// 	Action = () => Task.FromResult(true)
					// }
				}
            };
            var result = await this.DisplaySnackBarAsync(options);
        }
    }
}

