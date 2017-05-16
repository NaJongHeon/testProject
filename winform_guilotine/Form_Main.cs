using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        delegate void SettextCallback(string text);

        bool bIsConnFront = false;
        bool bIsConnBack = false;
        #region 서보관련변수
        byte m_nPortNo;
        bool m_bConnected;
        int m_mouseDown = 0;  //0 : None 1: jog- 2: jog+
        int m_PosAct = 0;
        int m_PosCom = 0;
        #endregion

        public Form_Main()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //Class 할당
            backlight = new ClassSerialPort();
            frontlight = new ClassSerialPort();

            

            #region Light 관련
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
            #endregion
            //서보 초기화
            m_nPortNo = 0;
            m_bConnected = false;
            Thread getPos = new Thread(new ThreadStart(run2));
            getPos.Start();
            txt_Position.Text = "0";
            txt_Speed.Text = "50000";
            txt_RepeatDelay.Text = "100";

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
                        res = true;
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

        #region ServoEvent
        public void run()
        {
            byte iSlaveNo;
            int nRtn;
            int lPosition;
            uint lVelocity;

            if (m_bConnected == false)
                return;

            if (txt_Slave.Text.Length <= 0)
            {
                txt_Slave.Focus();
                return;
            }

            iSlaveNo = byte.Parse(txt_Slave.Text);

            lPosition = int.Parse(txt_Position.Text);
            lVelocity = uint.Parse(txt_Speed.Text);



            if (m_mouseDown == 1)
            {
                nRtn = FAS_EziMOTIONPlusR.FAS_MoveVelocity(m_nPortNo, iSlaveNo, lVelocity, 0);
                if (nRtn != FAS_EziMOTIONPlusR.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisIncPos() \nReturned: " + nRtn.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            if (m_mouseDown == 2)
            {
                nRtn = FAS_EziMOTIONPlusR.FAS_MoveVelocity(m_nPortNo, iSlaveNo, lVelocity, 1);
                if (nRtn != FAS_EziMOTIONPlusR.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisIncPos() \nReturned: " + nRtn.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }
            if (m_mouseDown == 0)
            {
                nRtn = FAS_EziMOTIONPlusR.FAS_MoveStop(m_nPortNo, iSlaveNo);
                if (nRtn != FAS_EziMOTIONPlusR.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisIncPos() \nReturned: " + nRtn.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
            }


        }

        public void run2()  //POS Data 가져오기
        {
            try
            {
                m_stop = false;
                while (!m_stop)
                {
                    if (m_bConnected)
                    {
                        FAS_EziMOTIONPlusR.FAS_GetActualPos(m_nPortNo, byte.Parse(txt_Slave.Text), ref m_PosAct);
                        SettextAct(m_PosAct.ToString());
                        FAS_EziMOTIONPlusR.FAS_GetCommandPos(m_nPortNo, byte.Parse(txt_Slave.Text), ref m_PosCom);
                        SettextCom(m_PosCom.ToString());
                        SettextErr((m_PosAct - m_PosCom).ToString());
                        Thread.Sleep(1);
                    }

                }
            }
            catch (Exception e)
            {

            }
        }

        private void SettextAct(string text)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    SettextCallback d = new SettextCallback(SettextAct);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.txt_POSActual.Text = text;
                }
            }
            catch (Exception e)
            {

            }

        }
        private void SettextCom(string text)
        {
            if (this.InvokeRequired)
            {
                SettextCallback e = new SettextCallback(SettextCom);
                this.Invoke(e, new object[] { text });
            }
            else
            {
                this.txt_POSCommand.Text = text;
            }
        }
        private void SettextErr(string text)
        {
            if (this.InvokeRequired)
            {
                SettextCallback f = new SettextCallback(SettextErr);
                this.Invoke(f, new object[] { text });
            }
            else
            {
                this.txt_POSError.Text = text;
            }
        }
        private void SettextRepeat(string text)
        {
            if (this.InvokeRequired)
            {
                SettextCallback g = new SettextCallback(SettextRepeat);
                this.Invoke(g, new object[] { text });
            }
            else
            {
                this.txt_RepeatCount.Text = text;
            }
        }
        public void thr_repeat()
        {
            bool m_done = false;
            int dirCount = 0;   //0 : Find Start 1: Find End
            if (m_bConnected)
            {
                while (txt_RepeatCount.Text != "0")
                {
                    for (int iLoof = int.Parse(txt_RepeatCount.Text); iLoof >= 1; iLoof--)
                    {
                        if (int.Parse(txt_RepeatCount.Text) >= 1)
                        {
                            if (m_done == true && dirCount == 2)
                            {
                                SettextRepeat((int.Parse(txt_RepeatCount.Text) - 1).ToString());
                                m_done = false;
                                dirCount = 0;
                            }
                            if (dirCount == 0)
                            {
                                FAS_EziMOTIONPlusR.FAS_MoveSingleAxisAbsPos(m_nPortNo, byte.Parse(txt_Slave.Text), int.Parse(txt_RepeatStart.Text), uint.Parse(txt_Speed.Text));
                                if (int.Parse(txt_POSCommand.Text) / 10 == int.Parse(txt_RepeatStart.Text) / 10)
                                {
                                    dirCount = 1;
                                }
                            }
                            if (dirCount == 1)
                            {
                                FAS_EziMOTIONPlusR.FAS_MoveSingleAxisAbsPos(m_nPortNo, byte.Parse(txt_Slave.Text), int.Parse(txt_RepeatEnd.Text), uint.Parse(txt_Speed.Text));
                                if (int.Parse(txt_POSCommand.Text) / 10 == int.Parse(txt_RepeatEnd.Text) / 10)
                                {
                                    dirCount = 2;
                                    m_done = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
        private void btn_ServoConn_Click(object sender, EventArgs e)
        {
            if (txt_servoPort.Text == null)
            {
                txt_servoPort.Focus();
                return;
            }

            if (m_bConnected == false)
            {
                uint dwBaud;

                m_nPortNo = byte.Parse(txt_servoPort.Text);
                dwBaud = 115200;

                if (FAS_EziMOTIONPlusR.FAS_Connect(m_nPortNo, dwBaud) == 0)
                {
                    // Failed to connect
                    MessageBox.Show("연결 실패!!!");
                    //for (int iLoof = 0; iLoof < btnGroup_Servoset.Length; iLoof++)
                    //{
                    //    if (btnGroup_Servoset[iLoof] != null)
                    //        btnGroup_Servoset[iLoof].Enabled = false;
                    //}
                    btn_ServoConn.Enabled = true;
                }
                else
                {
                    //m_bConnected = true;
                    btn_ServoConn.Text = "Disconnect";
                    //cmb_servoPort.Enabled = false;
                    //btn_ServoOn.Enabled = true;

                    for (byte i = 0; i < FAS_EziMOTIONPlusR.MAX_SLAVE_NUMS; i++)
                    {
                        if (FAS_EziMOTIONPlusR.FAS_IsSlaveExist(m_nPortNo, i) != 0)
                        {
                            txt_Slave.Text = i.ToString();
                            break;
                        }
                    }
                }
            }
            else
            {
                FAS_EziMOTIONPlusR.FAS_Close(m_nPortNo);
                m_bConnected = false;

                btn_ServoConn.Text = "Connect";
                //cmb_servoPort.Enabled = true;
            }
        }

        private void btn_ServoOn_Click(object sender, EventArgs e)
        {
            byte iSlaveNo;
            int nRtn;

            if (m_bConnected == false)
                return;

            if (txt_Slave.Text.Length <= 0)
            {
                txt_Slave.Focus();
                return;
            }

            iSlaveNo = byte.Parse(txt_Slave.Text);

            nRtn = FAS_EziMOTIONPlusR.FAS_ServoEnable(m_nPortNo, iSlaveNo, 1);
            if (nRtn != FAS_EziMOTIONPlusR.FMM_OK)
            {
                string strMsg;
                strMsg = "FAS_ServoEnable() \nReturned: " + nRtn.ToString();
                MessageBox.Show(strMsg, "Function Failed");
            }
            //for (int iLoof = 0; iLoof < btnGroup_Servoset.Length; iLoof++)
            //{
            //    if (btnGroup_Servoset[iLoof] != null)
            //        btnGroup_Servoset[iLoof].Enabled = true;
            //}
        }

        private void btn_nJog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_mouseDown = 1;
                Thread jogDown = new Thread(new ThreadStart(run));
                jogDown.Start();
            }
        }

        private void btn_nJog_MouseUp(object sender, MouseEventArgs e)
        {
            Thread jogDown = new Thread(new ThreadStart(run));
            jogDown.Start();
            m_mouseDown = 0;
        }

        private void btn_pJog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_mouseDown = 2;
                Thread jogDown = new Thread(new ThreadStart(run));
                jogDown.Start();
            }
        }

        private void btn_pJog_MouseUp(object sender, MouseEventArgs e)
        {
            Thread jogDown = new Thread(new ThreadStart(run));
            jogDown.Start();
            m_mouseDown = 0;
        }

        private void btn_MoveABS_Click(object sender, EventArgs e)
        {
            byte iSlaveNo;
            int nRtn;
            int lPosition;
            uint lVelocity;

            if (m_bConnected == false)
                return;

            if (txt_Slave.Text.Length <= 0)
            {
                txt_Slave.Focus();
                return;
            }

            iSlaveNo = byte.Parse(txt_Slave.Text);

            lPosition = int.Parse(txt_Position.Text);
            lVelocity = uint.Parse(txt_Speed.Text);

            nRtn = FAS_EziMOTIONPlusR.FAS_MoveSingleAxisAbsPos(m_nPortNo, iSlaveNo, lPosition, lVelocity);
            if (nRtn != FAS_EziMOTIONPlusR.FMM_OK)
            {
                string strMsg;
                strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn.ToString();
                MessageBox.Show(strMsg, "Function Failed");
            }
        }

        private void btn_Origin_Click(object sender, EventArgs e)
        {
            if (m_bConnected)
            {
                FAS_EziMOTIONPlusR.FAS_MoveOriginSingleAxis(m_nPortNo, byte.Parse(txt_Slave.Text));
            }
        }

        private void btn_StartRepeat_Click(object sender, EventArgs e)
        {
            Thread gorepeat = new Thread(new ThreadStart(thr_repeat));
            gorepeat.Start();
        }
<<<<<<< master
=======
        #endregion


        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_bConnected)
            {
                int nRtn;
                nRtn = FAS_EziMOTIONPlusR.FAS_ServoEnable(m_nPortNo, byte.Parse(txt_Slave.Text), 0);
                if (nRtn != FAS_EziMOTIONPlusR.FMM_OK)
                {
                    string strMsg;
                    strMsg = "FAS_MoveSingleAxisAbsPos() \nReturned: " + nRtn.ToString();
                    MessageBox.Show(strMsg, "Function Failed");
                }
                m_bConnected = false;
            }

            m_stop = true;
        }


>>>>>>> local
    }
}
