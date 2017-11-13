using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_getProcessRapidChange_Click(object sender, EventArgs e)
        {
            getProcessesRapidChangeOfUsageInEach500ms();
        }

        private async void getProcessesRapidChangeOfUsageInEach500ms()
        {
            ResourcesMonitor resourcesMonitor = new ResourcesMonitor();

            while (true)
            {
                List<ProccessDetail> pdArrBefore = resourcesMonitor.getProccessesDetail();
                await Task.Delay(500);
                List<ProccessDetail> pdArrAfter = resourcesMonitor.getProccessesDetail();

                List<ProccessDetail> result = resourcesMonitor.getProccessesHaveRapidChangeUsage(pdArrBefore, pdArrAfter);

                if (result.Count() > 0)
                {
                    lbl_state.Text = " Found";
                    lbl_state.ForeColor = Color.DarkRed;

                    int[] pidArr = result.Select(i => i.process.Id).ToArray();

                    lb_processRapidChange.DataSource = pidArr;
                }
                else
                {
                    lbl_state.ForeColor = Color.DarkBlue;
                    lbl_state.Text = "No Found";
                }

                lbl_state.BackColor = lbl_state.BackColor == Color.LightGreen ? Color.LightBlue : Color.LightGreen;
            }
        }
    }
}
