using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataApi.Models
{
    public class CommandCenterModel
    {
       


        private String _ProviderName;
        public String ProviderName
        {
            get { return _ProviderName ?? "Default Value"; }
            set { _ProviderName = value; }
        }
        public string Value { get; set; }
        private String _ClientMdvcNumber;
        public String ClientMdvcNumber
        {
            get { return _ClientMdvcNumber ?? "Default _ClientMdvcNumber Value"; }
            set { _ClientMdvcNumber = value; }
        }

        private String _ServiceType;
        public String ServiceType
        {
            get { return _ServiceType ?? "Default Value"; }
            set { _ServiceType = value; }
        }

        private String _MrMDVCNumber;
        public String MrMDVCNumber
        {
            get { return _MrMDVCNumber ?? "Default Value"; }
            set { _MrMDVCNumber = value; }
        }

        private String _DeviceType;
        public String DeviceType
        {
            get { return _DeviceType ?? "Default Value"; }
            set { _DeviceType = value; }
        }

        private String _ClientRate;
        public String ClientRate
        {
            get { return _ClientRate ?? "Default Value"; }
            set { _ClientRate = value; }
        }

        private int _Dials;
        public int Dials
        {
            get { return _Dials; }
            set { _Dials = value; }
        }

        private DateTime _InstallationDateTime;
        public DateTime InstallationDateTime
        {
            get { return _InstallationDateTime; }
            set { InstallationDateTime = value; }
        }

        private String _ProgramId;
        public String ProgramId
        {
            get { return _ProgramId ?? "Default Value"; }
            set { _ProgramId = value; }
        }

        private String _RegisterCode;
        public String RegisterCode
        {
            get { return _RegisterCode ?? "Default Value"; }
            set { _RegisterCode = value; }
        }

        private String _ClientLocationId;
        public String ClientLocationId
        {
            get { return _ClientLocationId ?? "Default Value"; }
            set { _ClientLocationId = value; }
        }

        private String _ClientAccountId;
        public String ClientAccountId
        {
            get { return _ClientAccountId ?? "Default Value"; }
            set { _ClientAccountId = value; }
        }

        private String _ClientCustomerId;
        public String ClientCustomerId
        {
            get { return _ClientCustomerId ?? "Default Value"; }
            set { _ClientCustomerId = value; }
        }
    }
}