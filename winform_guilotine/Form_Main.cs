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

        public Form_Main()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            backlight = new ClassSerialPort();
            frontlight = new ClassSerialPort();
        }
        #region FrontLight Event
        private void btn_FrontConn_Click(object sender, EventArgs e)
        {
            frontlight.initialize("COM5", 9600, this);
            frontlight.portOpen();
            if(frontlight.objSerialPort.IsOpen)
            {
                txt_FrontLog.Text = "Front 조명 연결 성공\r\n" + txt_FrontLog.Text;
            }
            else
            {
                txt_FrontLog.Text = "Front 조명 연결 실패\r\n" + txt_FrontLog.Text;
            }
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

            if(frontlight.objSerialPort.IsOpen)
            {
                if(e.Type == ScrollEventType.EndScroll)
                {
                    frontlight.sendData(txt_FrontValue.Text);
                    txt_FrontLog.Text = "Front 조명값 : " + txt_FrontValue.Text + "\r\n" + txt_FrontLog.Text;
                }
            }
        }

        private void btn_FrontSet_Click(object sender, EventArgs e)
        {
            if (frontlight.objSerialPort.IsOpen)
            {
                frontlight.sendData(txt_FrontValue.Text);
            }
            txt_FrontLog.Text = "Front 조명값 : " + txt_FrontValue.Text + "\r\n" + txt_FrontLog.Text;
        }
        #endregion

        #region BackLight Event
        private void btn_BackConn_Click(object sender, EventArgs e)
        {
            backlight.initialize("COM6", 9600, this);
            backlight.portOpen();
            if (backlight.objSerialPort.IsOpen)
            {
                txt_BackLog.Text = "Front 조명 연결 성공\r\n" + txt_BackLog.Text;
            }
            else
            {
                txt_BackLog.Text = "Front 조명 연결 실패\r\n" + txt_BackLog.Text;
            }
        }

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
                    txt_BackLog.Text = "Back 조명값 : " + txt_BackValue.Text + "\r\n" + txt_BackLog.Text;
                }
            }
        }
        private void btn_BackSet_Click(object sender, EventArgs e)
        {
            if (backlight.objSerialPort.IsOpen)
            {
                backlight.sendData(txt_BackValue.Text);
            }
            txt_BackLog.Text = "Back 조명값 : " + txt_BackValue.Text + "\r\n" + txt_BackLog.Text;
        }

        #endregion

        
    }
}
