using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UE4_TestPlay
{
    public partial class MainForm : Form
    {
        static private string CurrentUserData = String.Empty;
        static private Dictionary<string, UserData> UserDataDic = new Dictionary<string, UserData>();

        public MainForm()
        {
            InitializeComponent();

            //파일 로드




            //디랙토리 설정
            InitializeUserData();
            




            //정보 로딩

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //최소화 일 경우에만
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowIcon = false;//작업 표시줄 제거
                MainNotifyIcon.Visible = true; //트레이 아이콘 활성화
            }
        }

        private void MainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowIcon = true;
            MainNotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ClientDirectory_Button_Click(object sender, EventArgs e)
        {
            //파일 오픈 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Client Directory Find";
            //ofd.FileName = "Open";
            ofd.Filter = "Unreal Project (*.uproject) | *.uproject; |Application (*.exe) | *.exe;|All files (*.*) | *.*;";
            ofd.InitialDirectory = ClientDirectory_Box.Text;

            //다이얼로그 쇼
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 을 클릭해서 다이얼 로그 종료시에
            if (dr == DialogResult.OK)
            {
                ////File명과 확장자를 가지고 온다.
                //string fileName = ofd.SafeFileName;

                //File경로와 File명을 모두가지고온다.
                //string fileFullName = ofd.FileName;

                ////File의 경로만 가지고 온다.
                //string filePath = fileFullName.Replace(fileName, "");

                ClientDirectory_Box.Text = ofd.FileName;
            }

        }

        private void ServerDirectory_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Server Directory Find";
            ofd.Filter = "Unreal Editor (UE4Editor.exe) | UE4Editor.exe; |Application (*.exe) | *.exe; |All files (*.*) | *.*;";
            ofd.InitialDirectory = ServerDirectory_Box.Text;

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                ServerDirectory_Box.Text = ofd.FileName;
            }
        }

        private void MapDirectory_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Map Directory Find";
            ofd.Filter = "Unreal Map (*.umap) | *.umap; |All files (*.*) | *.*;";
            if (String.Empty == MapDirectory_Box.Text)
            {
                ofd.InitialDirectory = Path.GetDirectoryName(ClientDirectory_Box.Text) + "\\Content";
            }
            else
            {
                ofd.InitialDirectory = MapDirectory_Box.Text;
            }

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                int StartNum =ofd.FileName.IndexOf("\\Content\\") + 9;
                int EndNum = ofd.FileName.Length - StartNum - 5;
                string TempStiring = ofd.FileName.Substring(StartNum, EndNum);
                MapDirectory_Box.Text = String.Format("\\Game\\" + TempStiring).Replace("\\","/");

            }
        }

        private void TestExport_Click(object sender, EventArgs e)
        {

        }

        //크리에이트 부분입니다.
        private void CurrentSettingCreate_Click(object sender, EventArgs e)
        {
            CurrentUserData = CreateUserData(DefuaultSettingBox.Text);
            Refresh_ComboBox();
        }

        private void CurrentSettingSave_Click(object sender, EventArgs e)
        {
            CurrentUserData = MotifyUserData(DefuaultSettingBox.Text);
            Refresh_ComboBox();
        }

        private void CurrentSettingRemove_Click(object sender, EventArgs e)
        {
            if (RemoveUserData(DefuaultSettingBox.Text))
            {
                Refresh_ComboBox();
            }
        }

        private void CurrentSettingInit_Click(object sender, EventArgs e)
        {
            InitializeUserData();
        }

        private void SelectSetting_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!UserDataDic.ContainsKey(SelectSetting_ComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Is not valid Selected \nRetry Select");
                return;
            }

            UserData userData = UserDataDic[SelectSetting_ComboBox.SelectedItem.ToString()];
            DefuaultSettingBox.Text = userData.DataName;
            ClientDirectory_Box.Text = userData.ClientInfo.Dir + "\\" + userData.ClientInfo.Name;
            ServerDirectory_Box.Text = userData.ServerInfo.Dir + "\\" + userData.ServerInfo.Name;
            MapDirectory_Box.Text = userData.MapInfo;
            IP_TextBox.Text = userData.Option.IP.ToString();
            Port_TextBox.Text = userData.Option.Port.ToString();
            SeverCount_TextBox.Text = userData.Option.ServerCount.ToString();
            ClientCount_TextBox.Text = userData.Option.ClientCount.ToString();
            WinSizeX_TextBox.Text = userData.Option.WindowSizeX.ToString();
            WinSizeY_TextBox.Text = userData.Option.WindowSizeY.ToString();
            Log_CheckBox.Checked = userData.Option.Log;
            Cooked_CheckBox.Checked = userData.Option.Cooked;
        }

        private void TestStart_Button_Click(object sender, EventArgs e)
        {
            //서버 부터 실행

            if (0 != Convert.ToInt32(SeverCount_TextBox.Text))
            {
                System.Diagnostics.ProcessStartInfo proInfo = new System.Diagnostics.ProcessStartInfo();
                System.Diagnostics.Process pro = new System.Diagnostics.Process();
                proInfo.FileName = ServerDirectory_Box.Text;
                proInfo.Arguments = String.Format("\"{0}\" {1} -server -port={2} -log",
                    ClientDirectory_Box.Text, MapDirectory_Box.Text, Convert.ToInt32(Port_TextBox.Text));
                pro.StartInfo = proInfo;
                if (pro.Start())
                {
                    //바로 실행되면 문제가 발생할수 있음.
                    //성공한다면 약간의 텀을 주자.
                    Thread.Sleep(10000);
                }
            }
            

            for (int i = 0; i < Convert.ToInt32(ClientCount_TextBox.Text); ++i)
            {
                System.Diagnostics.ProcessStartInfo proInfo = new System.Diagnostics.ProcessStartInfo();
                System.Diagnostics.Process pro = new System.Diagnostics.Process();
                proInfo.UseShellExecute = false;
                proInfo.CreateNoWindow = true;
                proInfo.FileName = ServerDirectory_Box.Text;
                proInfo.Arguments = String.Format("\"{0}\" {1} -game -port={2} -windowed resx={3} resy={4}",
                    ClientDirectory_Box.Text, IP_TextBox.Text, Convert.ToInt32(Port_TextBox.Text),
                    WinSizeX_TextBox.Text, WinSizeY_TextBox.Text);
                if (Log_CheckBox.Checked)
                {
                    proInfo.Arguments += " -log";
                }
                pro.StartInfo = proInfo;
                if (pro.Start())
                {
                    //바로 실행되면 문제가 발생할수 있음.
                    //성공한다면 약간의 텀을 주자.
                    Thread.Sleep(5000);
                }
                else
                {
                    --i;//실패 했음으로 --;
                }
            }

        }

        private void IP_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Port_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void SeverCount_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void ClientCount_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void WinSizeX_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void WinSizeY_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
