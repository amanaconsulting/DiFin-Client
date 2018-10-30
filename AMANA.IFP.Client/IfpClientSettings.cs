﻿// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using AMANA.IFP.Common.Helpers;

namespace AMANA.IFP.Client
{
    [Serializable]
    public class IfpClientSettings : INotifyPropertyChanged
    {
        private bool _isAutoDownloadRoutingTableFileDisabled;
        private string _sftpSchufaFilesUserName;
        private string _sftpSchufaFilesPassword;
        private bool _validateIfpData;
        private bool _validateGcdData;
        private string _routingTableFilePath;
        private readonly string _settingsFilePath;

        public bool ValidateIfpData
        {
            get { return _validateIfpData; }
            set
            {
                if (value == _validateIfpData) return;
                _validateIfpData = value;
                OnPropertyChanged();
            }
        }

        public bool ValidateGcdData
        {
            get { return _validateGcdData; }
            set
            {
                if (value == _validateGcdData) return;
                _validateGcdData = value;
                OnPropertyChanged();
            }
        }

        public string RoutingTableFilePath
        {
            get { return _routingTableFilePath; }
            set
            {
                if (value == _routingTableFilePath) return;
                _routingTableFilePath = value;
                OnPropertyChanged();
            }
        }


        public bool IsAutoDownloadRoutingTableFileDisabled
        {
            get { return _isAutoDownloadRoutingTableFileDisabled; }
            set
            {
                if (value == _isAutoDownloadRoutingTableFileDisabled) return;
                    _isAutoDownloadRoutingTableFileDisabled = value;
                OnPropertyChanged();
            }
        }

        public CertificateSettings CertificateSettings { get; set; }

        public string SftpSchufaFilesUserName
        {
            get { return _sftpSchufaFilesUserName; }
            set
            {
                if (value == _sftpSchufaFilesUserName) return;
                    _sftpSchufaFilesUserName = value;
                OnPropertyChanged();
            }
        }

        public string SftpSchufaFilesPassword
        {
            get { return _sftpSchufaFilesPassword; }
            set
            {
                if (value == _sftpSchufaFilesPassword) return;
                    _sftpSchufaFilesPassword = value;
                OnPropertyChanged();
            }
        }

        public DateTime? RemoteDownloadInstituteMappingProdFileLastWriteDate { get; set; }
        public DateTime? RemoteDownloadInstituteMappingTestFileLastWriteDate { get; set; }


        private IfpClientSettings Load()
        {
            var settings = GenericXmlSerializerHelper.DeserializeFromFile<IfpClientSettings>(_settingsFilePath);
            settings?.CopyTo(this);

            return settings;
        }

        private IfpClientSettings()
        {
            CertificateSettings = new CertificateSettings();
            ValidateIfpData = true;
            CertificateSettings.SetDefaultValues();
        }

        public IfpClientSettings(string settingsFilepath) : this()
        {
            _settingsFilePath = settingsFilepath;
            IsAutoDownloadRoutingTableFileDisabled = true;

            if (Load() == null)
                Save(); //ensure existence of settings file with default values
        }

        public void Save()
        {
           GenericXmlSerializerHelper.SerializeToFile(_settingsFilePath, this);
        }

        public IfpClientSettings Copy()
        {
            return CopyTo(new IfpClientSettings());
        }

        public IfpClientSettings CopyTo(IfpClientSettings settings)
        {
            settings.ValidateIfpData = ValidateIfpData;
            settings.ValidateGcdData = ValidateGcdData;
            settings.RoutingTableFilePath = RoutingTableFilePath;
            settings.CertificateSettings = CertificateSettings.Copy();
            settings.IsAutoDownloadRoutingTableFileDisabled = IsAutoDownloadRoutingTableFileDisabled;
            settings.SftpSchufaFilesUserName = SftpSchufaFilesUserName;
            settings.SftpSchufaFilesPassword = SftpSchufaFilesPassword;

            return settings;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}