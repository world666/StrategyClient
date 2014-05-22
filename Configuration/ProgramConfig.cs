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

        public VersionSection VersionSection { get; set; }

        public GeneralSection GeneralSection { get; set; }

        protected override void SetObject(ProgramConfig obj)
        {
            this.UserSection = obj.UserSection;
            this.VersionSection = obj.VersionSection;
            this.GeneralSection = obj.GeneralSection;
        }

        protected override ProgramConfig GetObject()
        {
            return this;
        }

        protected override ProgramConfig GetDefault()
        {
            var programConfig =  new ProgramConfig
                {
                    VersionSection = new VersionSection()
                        {
                            CurrentVersion = "BusinessStartegy v1.0"
                        },
                    GeneralSection = new GeneralSection()
                        {
                            LanguageId = 0
                        }
                };
            return programConfig;
        }
        private static ProgramConfig _selRefference;
    }
}