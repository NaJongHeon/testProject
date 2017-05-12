using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_guilotine
{
    public partial class Form_Main : Form
    {
        ClassSerialPort backlight;
        ClassSerialPort frontlight;

        List<Control> listFront;
        List<Control> listBack;

        bool bIsConnFront = false;
        bool bIsConnBack = false;

        public Form_Main()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            backlight = new ClassSerialPort();
            frontlight = new ClassSerialPort();

            //front control list
            listFront = new List<Control>();
            foreach (Control x in groupBox1.Controls)
            {
                listFront.Add(x);
            }
            setEnableList(0, false);

            bIsConnFront = conntry(0);
            if (bIsConnFront)
            {
                btn_FrontRetry.Visible = false;
                setEnableList(0, true);
            }
            else
            {
                btn_FrontRetry.Visible = true;
                setEnableList(0, false);
            }


            //back control list
            listBack = new List<Control>();
            foreach (Control x in groupBox2.Controls)
            {
                listBack.Add(x);
            }
            setEnableList(1, false);

            bIsConnBack = conntry(1);
            if (bIsConnBack)
            {
                btn_BackRetry.Visible = false;
                setEnableList(1, true);
            }
            else
            {
                btn_BackRetry.Visible = true;
                setEnableList(1, false);
            }
        }
        /// <summary>
        /// 포트 연결을 시도합니다
        /// </summary>
        /// <param name="setConn"></param>
        /// <returns></returns>
        private bool conntry(int setConn)
        {
            bool res = false;
            switch (setConn)
            {
                case 0:
                    frontlight.initialize("COM5", 9600, this);

                    try
                    {
                        frontlight.portOpen();
                    }
                    catch
                    {

                    }

                    if (frontlight.objSerialPort.IsOpen)
                    {
                        txt_LightLog.Text = "Front 조명 연결 성공\r\n" + txt_LightLog.Text;
                        res = true;
                    }
                    else
                    {
                        txt_LightLog.Text = "Front 조명 연결 실패\r\n" + txt_LightLog.Text;
                    }
                    break;
                case 1:
                    backlight.initialize("COM6", 9600, this);
                    try
                    {
                        backlight.portOpen();
                    }
                    catch
                    {

                    }
                    if (backlight.objSerialPort.IsOpen)
                    {
                        txt_LightLog.Text = "Back 조명 연결 성공\r\n" + txt_LightLog.Text;
                    }
                    else
                    {
                        txt_LightLog.Text = "Back 조명 연결 실패\r\n" + txt_LightLog.Text;
                    }
                    break;
            }
            return res;
        }
        /// <summary>
        /// 그룹박스 내의 컨트롤 전체의 Enable을 셋팅합니다
        /// </summary>
        /// <param name="listnum">0:Front GroupBox, 1:BackGroupBox</param>
        /// <param name="setEnable">true:Enable, false:Disable</param>
        private void setEnableList(int listnum, bool setEnable)
        {
            switch (listnum)
            {
                case 0:
                    for (int LoofCount = 0; LoofCount < listFront.Count; LoofCount++)
                    {
                        listFront[LoofCount].Enabled = setEnable;
                    }
                    break;
                case 1:
                    for (int LoofCount = 0; LoofCount < listFront.Count; LoofCount++)
                    {
                        listBack[LoofCount].Enabled = setEnable;
                    }
                    break;
            }
        }

        #region FrontLight Event
        private void btn_FrontConn_Click(object sender, EventArgs e)
        {

        }

        private void scr_FrontValue_Scroll(object sender, ScrollEventArgs e)
        {
            if (scr_FrontValue.Value > 255)
            {
                txt_FrontValue.Text = "255";
            }
            else if (scr_FrontValue.Value < 0)
            {
                txt_FrontValue.Text = "0";
            }
            else
            {
                txt_FrontValue.Text = scr_FrontValue.Value.ToString();
            }

            if (frontlight.objSerialPort.IsOpen)
            {
                if (e.Type == ScrollEventType.EndScroll)
                {
                    frontlight.sendData(txt_FrontValue.Text);
                    txt_LightLog.Text = "Front 조명값 : " + txt_FrontValue.Text + "\r\n" + txt_LightLog.Text;
                }
            }
        }

        private void btn_FrontSet_Click(object sender, EventArgs e)
        {
            if (frontlight.objSerialPort.IsOpen)
            {
                frontlight.sendData(txt_FrontValue.Text);
            }
            txt_LightLog.Text = "Front 조명값 : " + txt_FrontValue.Text + "\r\n" + txt_LightLog.Text;
        }
        private void btn_FrontRetry_Click(object sender, EventArgs e)
        {
            if (conntry(0))
            {
                setEnableList(0, true);
                btn_FrontRetry.Visible = false;
            }
            else
            {
                setEnableList(0, false);
                btn_FrontRetry.Visible = true;
            }
        }

        private void btn_FrontOn_Click(object sender, EventArgs e)
        {
            frontlight.sendData("a1");
        }

        private void btn_FrontOff_Click(object sender, EventArgs e)
        {
            frontlight.sendData("a0");
        }

        #endregion

        #region BackLight Event


        private void scr_BackValue_Scroll(object sender, ScrollEventArgs e)
        {
            if (scr_BackValue.Value > 255)
            {
                txt_BackValue.Text = "255";
            }
            else if (scr_BackValue.Value < 0)
            {
                txt_BackValue.Text = "0";
            }
            else
            {
                txt_BackValue.Text = scr_BackValue.Value.ToString();
            }

            if (backlight.objSerialPort.IsOpen)
            {
                if (e.Type == ScrollEventType.EndScroll)
                {
                    backlight.sendData(txt_BackValue.Text);
                    txt_LightLog.Text = "Back 조명값 : " + txt_BackValue.Text + "\r\n" + txt_LightLog.Text;
                }
            }
        }
        private void btn_BackSet_Click(object sender, EventArgs e)
        {
            if (backlight.objSerialPort.IsOpen)
            {
                backlight.sendData(txt_BackValue.Text);
            }
            txt_LightLog.Text = "Back 조명값 : " + txt_BackValue.Text + "\r\n" + txt_LightLog.Text;
        }

        private void btn_BackRetry_Click(object sender, EventArgs e)
        {
            if (conntry(1))
            {
                setEnableList(1, true);
                btn_BackRetry.Visible = false;
            }
            else
            {
                setEnableList(1, false);
                btn_BackRetry.Visible = true;
            }
        }

        private void btn_BackOn_Click(object sender, EventArgs e)
        {
            frontlight.sendData("b1");
        }

        private void btn_BackOff_Click(object sender, EventArgs e)
        {
            frontlight.sendData("b0");
        }


        #endregion


    }
}
