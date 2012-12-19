using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ServiceResult();
        }

        private async void ServiceResult()
        {
            HelloServiceProxy.HelloServiceContractClient proxy = new HelloServiceProxy.HelloServiceContractClient();
            string result = await proxy.MyHelloMessageAsync("Pravinkumar R. D.");
            lblServiceResult.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstLoop.ForeColor = Color.Red;
            for (int i = 0; i < 10; i++)
            {
                lstLoop.Items.Add("For Loop No - " + i.ToString());
                System.Threading.Thread.Sleep(500);
            }
        }


        
    }
}
