using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using DataApi.Models;

namespace DataApi
{
    public static class FileStreamers
    {
        public static string GetDatFileData(CommandCenterModel cmdCenterModel)
        {
            return cmdCenterModel.ProviderName.ToString()+"|"
                + cmdCenterModel.ClientAccountId.ToString() + "|"
                + cmdCenterModel.ClientCustomerId.ToString() + "|"
                + cmdCenterModel.ClientLocationId.ToString() + "|"
                + cmdCenterModel.ClientMdvcNumber.ToString() + "|"
                + cmdCenterModel.ClientRate.ToString() + "|"
                + cmdCenterModel.DeviceType.ToString() + "|"
                + cmdCenterModel.Dials.ToString() + "|"
                + cmdCenterModel.InstallationDateTime.ToString() + "|"
                + cmdCenterModel.MrMDVCNumber.ToString() + "|"
                + cmdCenterModel.ProgramId.ToString();
        }

        public static void CreateDatFile(string data)
        {
            string path = @ConfigurationManager.AppSettings["PathForDatFile"];

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(data);
            }
        }
    }
}