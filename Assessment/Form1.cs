using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PingSweep;
using PortScan;

namespace Assessment
{




    public partial class Assessment : Form
    {
        //IDictionary<string, Computers> comp = new Dictionary<string, Computers>();


        //public List<string,List<int>> Computers = new List<string,List<int>>();




        //public Computer(string name,string OpenPort,string Service);
        //Computer computer1 = new Computer("IP", "open port", "service/process;





        /*
                private void PortScanner(string currAddr)
                {
                    // Store the values of port numbers.
                    int beginPort;
                    int endPort;
                    int cmbPortStart = 20;
                    int cmbPortEnd = 2222;



                    //If theres an ipaddress continue else do nothing.

                    //If theres a port number continue else do nothing.
                    //Converts the port number from a string to an int.
                    beginPort = Convert.ToInt32(cmbPortStart);
                    endPort = Convert.ToInt32(cmbPortEnd);

                    //If the first port is smaller than the second port continue.
                    if (beginPort < endPort)
                    {

                        //Set the minimum value of the progress bar.
                        progBar.Minimum = beginPort;
                        // Set the max value of the progress bar.
                        progBar.Maximum = endPort;
                        // Resets the progress bar to smallest port number.
                        progBar.Value = beginPort;
                        //Increases the progress bar by one.
                        progBar.Step = 1;

                        // Let the user know the application is in prgress.
                        Cursor.Current = Cursors.WaitCursor;

                        // Loop through the ports between start port and end port.
                        for (int CurrPort = beginPort; CurrPort <= endPort; CurrPort++)
                        {
                            System.Net.Sockets.TcpClient TcpScanPort = new System.Net.Sockets.TcpClient();
                            try
                            {
                                // Try to connect
                                TcpScanPort.Connect(currAddr, CurrPort);
                                // If there's no exception, we can say the port is open
                                txtConsole.AppendText(currAddr + "'s Port " + CurrPort + " is open" + Environment.NewLine);
                                //Closes the port.
                                TcpScanPort.Close();
                            }
                            catch
                            {
                                // An exception occured, thus the port is probably closed.
                                //txtConsole.AppendText(currAddr + "'s Port " + CurrPort + " is closed" + Environment.NewLine);
                            }
                            // Increase the progress on the progress bar
                            progBar.PerformStep();
                        }
                        // Set the cursor back to normal
                        Cursor.Current = Cursors.Arrow;
                    }
                    else
                    {
                        //Error has accoured, do nothing.
                    }
                }
                */



        
        public Assessment()
        {
            InitializeComponent();
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            checkedListBox1.Items.Clear();
            SelectAll.Checked = false;
            SelectNone.Checked = false;

            //txtConsole.AppendText("HelloWorld" + System.Environment.NewLine);
            /*
            
            
            PingSweep.PingSweep.PingSweeper();

            foreach (var x in comp.Values)
            {
                txtConsole.AppendText(x.IP);
            }
            */
            



            
            //txtConsole.AppendText(Dns.GetHostByName(hostName).AddressList[0].ToString() + System.Environment.NewLine);


            


        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.Checked == true)
            {
                SelectNone.Checked = false;
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void SelectNone_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectNone.Checked == true)
            {
                SelectAll.Checked = false;
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtConsole.Clear();
            SelectAll.Checked = false;
            SelectNone.Checked = false;
            checkedListBox1.Items.Clear();
        }
        

        public void PortScan_Click(object sender, EventArgs e)
        {
            /*
            //Scan(string[] args "192.168.1.5","1","9999");
            //txtConsole.Text = String.Join(Environment.NewLine, Computers);
            //Console.WriteLine(String.Join(Environment.NewLine, Computers));
            
            foreach (string ip in checkedListBox1.CheckedItems)
            {
                string currAddr = ip.ToString();

                var args = new string[] { currAddr, "1", "100" };

                //PortScan.PortScan.Scan(args);


                //comp[currAddr] = new Computer { IP = currAddr, OpenPort = null };
                
                

                //Computers.Add()
                //Computers.Add(currAddr, Scan(args));
                //PortScanner(currAddr);
            }
            foreach (var x in comp.Values)
            {
                txtConsole.AppendText(x.IP + Environment.NewLine);
            }


            foreach (KeyValuePair<string, Computer> kvp in comp)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                txtConsole.Text += string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value + Environment.NewLine);
            }

            */
            
        }



        private void btnObjects_Click(object sender, EventArgs e)
        {
            //txtConsole.Text = String.Join(Environment.NewLine, Computers);
        }
        
    }
}