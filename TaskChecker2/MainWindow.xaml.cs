using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskChecker
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PrefomanceCounter();
        }

        public  class Process {
            public string title { get; set; }
            public string usage { get; set; }
            public SolidColorBrush Color { get; set; }
            
        }

        public void PrefomanceCounter()
        {
            System.Diagnostics.Process[] myProcs = System.Diagnostics.Process.GetProcesses();
            var sorted = myProcs.OrderBy(p => p.UserProcessorTime);
            StringBuilder sb = new StringBuilder();
            List <Process> list = new List<Process>();

            int i = 0;

            foreach (var proc in myProcs)
            {
                if (i < 5)
                {
                    var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

                    cpuCounter.NextValue().ToString();
                    System.Threading.Thread.Sleep(1000);

                    list.Add(new Process
                    {
                        title = proc.ProcessName,

                        usage = cpuCounter.NextValue().ToString() + "%",

                    });
                 
                    foreach (var count in list)
                    {
                        if (double.TryParse(count.usage, out double usages)){
                            if (usages > 15)
                            {
                                color = Brushes.Red;
                                
                            }
                        }
                        
                    }
                    
                    i++;
                   
                }
                else
                {
                    break;
                }
               
            }
            list.OrderBy(x=>x.usage);
            dg.ItemsSource = list;

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            PrefomanceCounter();
        }
    }
}
