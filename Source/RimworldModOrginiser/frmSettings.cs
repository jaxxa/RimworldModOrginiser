﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RimworldModOrginiser
{
    public partial class frmSettings : Form
    {
        private RimworldModOrginiser.ProgramSettings.SettingsManager m_SettingManager;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

            this.m_SettingManager = new ProgramSettings.SettingsManager();

            this.m_SettingManager.Load();

            this.bsrcSettings.DataSource = this.m_SettingManager.Profiles;
        }

        private void bttnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgrvSettings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public static ProgramSettings.SettingsManager GetSettings()
        {
            var _frmSettings = new frmSettings();

            DialogResult _Result = _frmSettings.ShowDialog();

            if (_Result != DialogResult.OK)
            {
                return null;
            }

            return _frmSettings.m_SettingManager;
        }
    }
}