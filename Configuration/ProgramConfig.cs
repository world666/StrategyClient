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
using Configuration.Sections;

namespace Configuration
{
    public class ProgramConfig : AbstractConfig<ProgramConfig>, IConfig
    {
        public static ProgramConfig CreateInstance()
        {
            return _selRefference ?? (_selRefference = new ProgramConfig());
        }

        public UserSection UserSection { get; set; }

        protected override void SetObject(ProgramConfig obj)
        {
            this.UserSection = obj.UserSection;
        }

        protected override ProgramConfig GetObject()
        {
            /*this.UserSection = new UserSection()
                {
                    Login = "and",
                    Password = "and"
                };*/
            return this;
        }

        protected override ProgramConfig GetDefault()
        {
            return new ProgramConfig();
        }
        private static ProgramConfig _selRefference;
    }
}