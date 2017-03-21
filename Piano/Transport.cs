using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
namespace Piano
{
    class Transport
    {
        private long received_count = 0;//接收计数
        private long send_count = 0;//发送计数
        SerialPort comm;
        StringBuilder builder;
        private List<byte> buffer = new List<byte>(4096);

        public Transport()
        {
            comm = new SerialPort();
            builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。
            string[] ports = SerialPort.GetPortNames();//获取当前计算机的串行端口名称数组

            //初始化SerialPort对象
            comm.PortName = "COM3";
            comm.NewLine = "\r\n";
            //comm.RtsEnable = true;//根据实际情况吧
            comm.BaudRate = 9600;
            comm.Open();
        }
        public int[] CommDataReceived()
        {
            int number = 0;
            int[] data = new int[4];

            int n = this.comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count += n;//增加接收计数
            comm.Read(buf, 0, n);//读取缓冲数据
            builder.Length = 0; ;//清除字符串构造器的内容
            if (n != 0)
            {
                data[0] = buf[0];
                data[1] = buf[1];
                data[2] = buf[2];

            }//CommDataSend(0);


            return data;

        }//收数据
        public void CommDataSend(int[] sendData)
        {
            //定义一个变量，记录发送了几个字节
            int i=0;
           //while (i<10000)
           //{
                int n = 0;
                //16进制发送
                //转换列表为数组后发送
                Byte[] data = new Byte[2];
                //string moren = "COM";
                data[0] = Convert.ToByte(sendData[0]); ;
                //data[1] = Convert.ToByte(sendData[1]);
                //data[2] = Convert.ToByte(sendData[2]); ;
                comm.Write(data, 0, 1);
            //    i++;
          // }

        }//发送数据

        public void CommDataSend1()
        {
            Byte[] data = new Byte[4];
            data[0] = 0x02;
            //data[1] = 0x10;
            comm.Write(data, 0, 1);
        }
        public void ClosePort()
        {
            comm.Close();
        }
    }
}
