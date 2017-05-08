using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace winform_guilotine
{
    public class ClassSerialPort
    {
        Form_Main objform;
        public SerialPort objSerialPort = new SerialPort();
        private string _PortName;
        private int _BaudRate;
        private int _DataBit;
        private Parity _Parity;
        private StopBits _StopBits;

        public void initialize(string PortName, int BaudRate, Form_Main objformMain)
        {
            objform = objformMain;
            _PortName = PortName;
            _BaudRate = BaudRate;

            objSerialPort.PortName = _PortName;
            objSerialPort.BaudRate = _BaudRate;


            objSerialPort.DataReceived += new SerialDataReceivedEventHandler(objSerialPort_DataReceived);
        }

        public void portOpen()
        {
            objSerialPort.Open();
        }

        public bool sendData(string cmd)
        {
            bool res = false;
            if (objSerialPort.IsOpen)
            {
                string temp = "";
                temp = cmd + "\n";
                objSerialPort.Write(temp.ToCharArray(), 0, temp.ToCharArray().Length);
                return res = true;
            }
            else
            {

            }
            return res;
        }

        private void objSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBytes = objSerialPort.BytesToRead;
            byte[] bytes = new byte[intBytes];
            objSerialPort.Read(bytes, 0, intBytes);
            string str = "";
            string resStr = "";
            str += Encoding.Default.GetString(bytes);

            string[] Ssep = new string[1] { ("\n\r") };
            string[] strData = str.Split(Ssep, StringSplitOptions.RemoveEmptyEntries);


            string[] stringData = new string[strData.Length];


            for (int i = 0; i < strData.Length; i++)
            {
                stringData[i] = strData[i];

            }
            for (int iLoopCount = 0; iLoopCount < stringData.Length; iLoopCount++)
            {
                resStr = stringData[iLoopCount];
                //리시브 받은 데이터 전달 구현
                //objMainform.SettextPuttyLog(stringData[iLoopCount]);
            }



        }
    }
}
