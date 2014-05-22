using Android.App;
using Android.OS;
using Android.Widget;
using Configuration;
using Configuration.Sections;
using VisualizationSystem.WebReference1;

namespace VisualizationSystem.Activities
{
    [Activity(Label = "Регистрация")]
    public class RegistrationActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.Registration);

            var regButton = FindViewById<Button>(Resource.Id.reg_button);
            var login = FindViewById<EditText>(Resource.Id.login);
            var password = FindViewById<EditText>(Resource.Id.password);
            var repPassword = FindViewById<EditText>(Resource.Id.rep_password);

            regButton.Click += delegate
                {
                    if (password.Text == "" || login.Text == "")
                    {
                        new AlertDialog.Builder(this).SetMessage("Все поля должны быть заполнены").Show();
                        return;
                    }
                    if (repPassword.Text != password.Text)
                    {
                        new AlertDialog.Builder(this).SetMessage("Пароль и подтверждение пароля не совпадают").Show();
                        return;
                    }
                    UserService userService = new UserService();
                    RegistrationState regState;
                    bool rez;
                    string sessionCode;
                    userService.Registration(login.Text, password.Text,out regState, out rez,out sessionCode);
                    if (regState != RegistrationState.Success)
                    {
                        new AlertDialog.Builder(this).SetMessage("Пользователь с таким логином уже существует").Show();
                        return;
                    }
                    ProgramConfig programConfig = ProgramConfig.CreateInstance();
                    programConfig.UserSection = new UserSection() {Login = login.Text, Password = password.Text, SessionCode = sessionCode};
                    programConfig.Save();
                    StartActivity(typeof(AutorizedActivity));
                };
        }
    }
}