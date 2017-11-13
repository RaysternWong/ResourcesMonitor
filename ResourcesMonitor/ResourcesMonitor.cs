using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Threading;

namespace ResourcesMonitor
{
    public struct ProccessDetail
    {
        public Process process;
        public float cpuUsage;
        public float ramUsage;
        public float diskWrite;
        public float diskRead;
        public float diskTotal;
    }

    class ResourcesMonitor
    { 
        enum UsageCondition
        {
            Cpu = 0,
            Ram = 1,
            Both = 2,
        }

        public ResourcesMonitor() { }

        public List<ProccessDetail> getProccessesHaveRapidChangeUsage(List<ProccessDetail> listBe4, List<ProccessDetail> listAfter)
        {
            List<ProccessDetail> rapidChangeList = new List<ProccessDetail>();

            foreach (ProccessDetail pdAfter in listAfter)
            {
                List<ProccessDetail> be4Items = listBe4.Where(x => x.process.Id == pdAfter.process.Id).ToList();

                if(be4Items.Count() > 0 )
                    if (checkIsProcessHasRepidChangeUsage(be4Items.First(), pdAfter) == true)
                        rapidChangeList.Add(pdAfter);
            }
            return rapidChangeList;
        }

        private bool checkIsProcessHasRepidChangeUsage(ProccessDetail pdBe4, ProccessDetail pdAfter, UsageCondition uc = UsageCondition.Both)
        {
    

            switch(uc)
            {
                case UsageCondition.Ram: return checkIsRamChange(pdBe4, pdAfter);
                case UsageCondition.Cpu: return checkIsCpuChange(pdBe4, pdAfter);
                case UsageCondition.Both: return checkIsRamChange(pdBe4, pdAfter) & checkIsCpuChange(pdBe4, pdAfter);
                default: return false; ;
            }
        }

        private bool checkIsRamChange(ProccessDetail pdBe4, ProccessDetail pdAfter, int percentChange = 500)
        {
            pdBe4.ramUsage = (pdBe4.ramUsage == 0 ? 1 : pdBe4.ramUsage); //Assign 1 if the original value is 0, for make it compare-able

            if ( pdAfter.ramUsage / pdBe4.ramUsage > (percentChange / 100) )
                return true;
            return false;
        }

        private bool checkIsCpuChange(ProccessDetail pdBe4, ProccessDetail pdAfter, int percentChange = 500)
        {
            pdBe4.cpuUsage = (pdBe4.cpuUsage == 0 ? 1 : pdBe4.cpuUsage); //Assign 1 if the original value is 0, for make it compare-able

            if ( pdAfter.cpuUsage / pdBe4.cpuUsage > (percentChange / 100) )
                return true;
            return false;
        }

        public List<ProccessDetail> getProccessesDetail()
        {
            List<ProccessDetail> pdList = new List<ProccessDetail>();
            PerformanceCounter cpuCounter, ramCounter, readCounter, writeCounter;

            foreach (Process p in Process.GetProcesses())
            {
                cpuCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
                ramCounter = new PerformanceCounter("Process", "Working Set", p.ProcessName);
                ProccessDetail pd = new ProccessDetail();

                try
                {
                    pd.process = p;
                    pd.cpuUsage = cpuCounter.NextValue();
                    pd.ramUsage = ramCounter.NextValue();
                    pdList.Add(pd);
                }
                catch (Exception err)
                {
                    string mss = "Cannot get details for processs of '" + p.ProcessName + "' , error : " + err.Message;
                }
            }
            return pdList;
        }
    }
}
