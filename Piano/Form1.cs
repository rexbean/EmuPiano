using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x01;
            i = 1;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x02;
            i = 2;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x03;
            i = 3;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x04;
            i = 4;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x05;
            i = 5;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x06;
            i = 6;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x07;
            i = 7;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Transport transportTemperature = new Transport();
            int[] cT2Int = new int[1];
            int[] a = new int[3];
            cT2Int[0] = 0x08;
            i = 8;
            transportTemperature.CommDataSend(cT2Int);
            transportTemperature.ClosePort();
            textBox1.Text = i.ToString();
        }
    }
}
