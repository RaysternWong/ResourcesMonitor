using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResourcesMonitor;

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

            int period = Convert.ToInt32(tb_period.Text);

            while (true)
            {
                List<ProccessDetail> pdArrBefore = resourcesMonitor.getProccessesDetail();
                await Task.Delay(period);
                List<ProccessDetail> pdArrAfter = resourcesMonitor.getProccessesDetail();

                List<ProccessDetail> bothUsage = resourcesMonitor.getProccessesHaveRapidChangeUsage(pdArrBefore, pdArrAfter);
                List<ProccessDetail> ramUsage = resourcesMonitor.getProccessesHaveRapidChangeUsage(pdArrBefore, pdArrAfter, ResourcesMonitor.UsageCondition.Ram);
                List<ProccessDetail> cpuUsage = resourcesMonitor.getProccessesHaveRapidChangeUsage(pdArrBefore, pdArrAfter, ResourcesMonitor.UsageCondition.Cpu);

                lb_processRapidChange.DataSource = bothUsage.Select(i => i.process.Id).ToArray();
                lb_cpuSurge.DataSource = cpuUsage.Select(i => i.process.Id).ToArray();
                lb_ramSurge.DataSource = ramUsage.Select(i => i.process.Id).ToArray();

                if (bothUsage.Count() == 0 && ramUsage.Count() == 0 && cpuUsage.Count() == 0  )
                {
                    lbl_state.ForeColor = Color.DarkBlue;
                    lbl_state.Text = "No Found";
                }
                else
                {
                    lbl_state.ForeColor = Color.DarkRed;
                    lbl_state.Text = "Found";
                }

                lbl_state.BackColor = lbl_state.BackColor == Color.LightGreen ? Color.LightBlue : Color.LightGreen;
            }
        }
    }
}
