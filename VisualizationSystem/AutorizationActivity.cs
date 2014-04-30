using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Configuration;
using Configuration.Sections;
using VisualizationSystem.WebReference;

namespace VisualizationSystem
{
    [Activity(Label = "Авторизация")]
    public class AutorizationActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Autorization);

            var regButton = FindViewById<Button>(Resource.Id.autorize_button);
            var login = FindViewById<EditText>(Resource.Id.login);
            var password = FindViewById<EditText>(Resource.Id.password);

            regButton.Click += delegate
                {
                    var programConfig = ProgramConfig.CreateInstance();
                    var userService = new UserService();
                    AuthorizationState retState;
                    bool rez;
                    string sessionCode;
                    userService.Authorization(login.Text, password.Text, out retState, out rez, out sessionCode);
                    if (retState == AuthorizationState.Success)
                    {
                        programConfig.UserSection = new UserSection()
                            {
                                Login = login.Text,
                                Password = password.Text,
                                SessionCode = sessionCode
                            };
                        programConfig.Save();
                        StartActivity(typeof (AutorizedActivity));
                    }
                    else
                    {
                        new AlertDialog.Builder(this).SetMessage("Неверный логин или пароль").Show();
                    }
                };
        }
    }
}