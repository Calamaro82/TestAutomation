﻿namespace WestpacTestAutomation.Libraries
{
    class WestpacLibraries
    {
        public static void VerifySettingExist(string settingValue, string settingName)
        {
            if (settingValue == null)
            {
                throw new System.InvalidOperationException($"{settingName} doesn't exists in the App.config file");
            }
        }
    }
}