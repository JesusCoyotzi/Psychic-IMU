using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IMUMonitor
{
    public partial class Monitor : Form
    {
        private List<double[]> dataStruct;
        SerialPort Port;
        public delegate void data1(string data);
        public delegate void data2(double a, double b, double c);
        public delegate void data3(string data, double[] s);
        public delegate void data4(double a, double b, double c, double e, double f, double g);
        public data3 myDel;
        private double Acx, Acy, Acz, Gx, Gy, Gz;
        volatile bool keyBrake;
        public Monitor()
        {
            InitializeComponent();

        }

        private void listPorts()
        {
            ReceiverBox.Text = "";
            ReceiverBox.Text = "Puertos COM disponibles" + Environment.NewLine;
            string[] puertos = SerialPort.GetPortNames();
            if (puertos.Length > 0)
            {
                comPorts.Items.Clear();
                foreach (string s in SerialPort.GetPortNames())
                {
                    ReceiverBox.Text += s + Environment.NewLine;
                    comPorts.Items.Add(s);
                }
            }
            else
            {
                ReceiverBox.Text += "Sin puertos disponibles";
            }


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void readSerial(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            try
            {
                string data = sp.ReadLine();

                //System.Diagnostics.Debug.WriteLine(data);
                setValues(data);
                
                    string[] sep = { "," };
                    string[] result = data.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    Acx = Convert.ToDouble(result[0]);
                    Acy = Convert.ToDouble(result[1]);
                    Acz = Convert.ToDouble(result[2]);
                    Gx = Convert.ToDouble(result[3]);
                    Gy = Convert.ToDouble(result[4]);
                    Gz = Convert.ToDouble(result[5]);
                    double brake;
                    if (brk.Checked || keyBrake)
                    {
                        brake = 1;
                    }
                    else
                    {
                        brake = 0;

                    }
                    //double[] gArr = { Acx, Acy, Acz, Gx, Gy, Gz };
                    double[] arr = { Acx, Acy, Acz, Gx, Gy, Gz, brake };
                    // ReceiverBox.BeginInvoke(myDel, new object[] { data, gArr });
                    dataStruct.Add(arr);

                    if (graph.Checked)
                    {
                    setGraph1(Acx, Acy, Acz);
                    setGraph2(Acx,Acy,Acz,Gx, Gy, Gz);
                    
                    
                  
                    }
            }
            catch (Exception ex)
            {
                ReceiverBox.Text = ex.Message;
            }


        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string portName;
            try
            {
                if (comPorts.SelectedIndex != 0)
                {
                    portName = comPorts.SelectedText;
                }
                else
                {
                    portName = SerialPort.GetPortNames()[0];
                }

                SenderBox.Text = portName;
                Port.BaudRate = int.Parse(baudRates.Text);
                Port.PortName = portName;
                Port.Parity = Parity.None;
                Port.StopBits = StopBits.One;
                Port.Handshake = Handshake.None;
                Port.RtsEnable = true; //Important to be enabled
                Port.DtrEnable = true; //Else event won't trigger
                Port.DataReceived += new SerialDataReceivedEventHandler(readSerial);
                Port.Open();
                Port.Write("S");
                //   SenderBox.Text = "Connected";
            }
            catch (Exception ex)
            {
                ReceiverBox.Text = ex.Message;
            }
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            listPorts();

            if (SerialPort.GetPortNames().Length > 0) //This bit is only to set default displays
            {
                baudRates.SelectedIndex = 10;
                comPorts.SelectedIndex = 0;
            }


            dataStruct = new List<double[]>();
            Port = new SerialPort();
            myDel = new data3(setAll);
        }

        private void setValues(string s)
        {
            if (ReceiverBox.InvokeRequired)
            {
                data1 del = new data1(setValues);
                ReceiverBox.BeginInvoke(del, new object[] { s });
            }
            else
            {
                ReceiverBox.Text = s;
            }
        }

        private void setAll(string data, double[] s)
        {
            ReceiverBox.Text = data;

            GyroGraph.Series[0].Points.AddY(s[3]);
            GyroGraph.Series[1].Points.AddY(s[4]);
            GyroGraph.Series[2].Points.AddY(s[5]);

            AcelGraph.Series[0].Points.AddY(s[0]);
            AcelGraph.Series[1].Points.AddY(s[1]);
            AcelGraph.Series[2].Points.AddY(s[2]);


        }
        private void setGraph1(double a, double b, double c) //Set Accelerometer
        {
            if (AcelGraph.InvokeRequired)
            {
                data2 del = new data2(setGraph1);
                AcelGraph.BeginInvoke(del, new object[] { a, b, c });
            }
            else
            {
                AcelGraph.Series[0].Points.AddY(a);
                AcelGraph.Series[1].Points.AddY(b);
                AcelGraph.Series[2].Points.AddY(c);
            }
        }

        private void setGraph2(double a, double b, double c) //Set Gyro
        {
            if (GyroGraph.InvokeRequired)
            {
                data2 del = new data2(setGraph2);
                GyroGraph.BeginInvoke(del, new object[] { a, b, c });
            }
            else
            {
                GyroGraph.Series[0].Points.AddY(a);
                GyroGraph.Series[1].Points.AddY(b);
                GyroGraph.Series[2].Points.AddY(c);
            }
        }

        private void setGraph2(double a, double b, double c, double d, double e, double f) //Set Gyro
        {
            if (GyroGraph.InvokeRequired)
            {
                data4 del = new data4(setGraph2);
                GyroGraph.BeginInvoke(del, new object[] { a, b, c, d, e, f, });
            }
            else
            {
                GyroGraph.Series[0].Points.AddY(a);
                GyroGraph.Series[1].Points.AddY(b);
                GyroGraph.Series[2].Points.AddY(c);
                GyroGraph.Series[3].Points.AddY(d);
                GyroGraph.Series[4].Points.AddY(e);
                GyroGraph.Series[5].Points.AddY(f);
            }
        }


        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Port.IsOpen)
            {
                Port.Write("C");
                Port.RtsEnable = false;
                Port.DtrEnable = false;

                Port.Close();
                ReceiverBox.Text = "Connection Closed";
            }


        }

        private void sender_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.WriteLine(SenderBox.Text);
            }
            SenderBox.Text = baudRates.SelectedIndex.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name;
            if (SenderBox.Text == "")
            {
                name = "Datos";
            }

            if (dataStruct.Count > 0) //Is is not empty?
            {
                name = SenderBox.Text + ".txt";

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(name))
                {
                    sw.WriteLine("#Measuremente data, separator is tabulator");
                    sw.WriteLine("#AcX,Acy,Acz,Gx,Gy,Gz,Brake");
                    sw.WriteLine();

                    foreach (double[] d in dataStruct)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            sw.Write(d[i]);
                            sw.Write("\t");
                        }
                        sw.WriteLine();
                    }
                }
            }
        }

        private void Monitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (Port.IsOpen)
                {
                    Port.Write("C");
                    Port.RtsEnable = false;
                    Port.DtrEnable = false;

                    Port.Close();

                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine(e.KeyCode);
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D5)
            {
                brk.Checked = true;
                keyBrake = true;
            }
            else if (e.KeyCode >= Keys.D6 && e.KeyCode <= Keys.D9)
            {
                brk.Checked = false;
                keyBrake = false;
            }
        }

        private void baudRates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listarPuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPorts();
        }
    }
}
