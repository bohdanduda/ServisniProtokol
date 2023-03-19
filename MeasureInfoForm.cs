﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    public partial class MeasureInfoForm : Form
    {
        public static MeasureInfoForm instance;
        private int selectedRow;
        private bool editing;
        public MeasureInfoForm()
        {
            

            InitializeComponent();
            instance = this;

            foreach (DataGridViewRow row in HomePageForm.instance.dataGrid.SelectedRows)
            {
                this.selectedRow = row.Index;
            }
        }

        public void LoadData(bool editing)
        {
            this.editing = editing;

            this.txtBox_paramName.Text = HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[0].Value.ToString();
            this.txtBox_measuredUnit.Text = HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[1].Value.ToString();
            this.txtBox_unit.Text = HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[2].Value.ToString();
            if (HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[3].Value.ToString()=="ANO")
            {
                this.chckBox_isValid.CheckState = CheckState.Checked;
            }
            else
            {
                this.chckBox_isValid.CheckState = CheckState.Unchecked;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string isValid;
            if (!this.editing)
            {
                if (this.chckBox_isValid.Checked)
                {
                    isValid = "ANO";
                }
                else
                {
                    isValid = "NE";
                }

                HomePageForm.instance.dataGrid.Rows.Add(this.txtBox_paramName.Text, this.txtBox_measuredUnit.Text, this.txtBox_unit.Text, isValid);
                this.Close();
            }
            else
            {
                if (this.chckBox_isValid.Checked)
                {
                    isValid = "ANO";
                }
                else
                {
                    isValid = "NE";
                }

                HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[0].Value = this.txtBox_paramName.Text;
                HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[1].Value = this.txtBox_measuredUnit.Text;
                HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[2].Value = this.txtBox_unit.Text;
                HomePageForm.instance.dataGrid.Rows[selectedRow].Cells[3].Value = isValid;

                this.Close();
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
