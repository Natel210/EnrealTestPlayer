using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UE4_TestPlay
{
    public partial class MainForm : Form
    {
        //유저 데이터 하나 생성합니다.
        private string CreateUserData(string _name)
        {
            UserData NewUserData = new UserData();
            NewUserData.DataName = _name;

            NewUserData.ClientInfo.Dir = Path.GetDirectoryName(ClientDirectory_Box.Text);
            NewUserData.ClientInfo.Name = Path.GetFileName(ClientDirectory_Box.Text);

            NewUserData.ServerInfo.Dir = Path.GetDirectoryName(ServerDirectory_Box.Text);
            NewUserData.ServerInfo.Name = Path.GetFileName(ServerDirectory_Box.Text);

            NewUserData.MapInfo = MapDirectory_Box.Text;


            NewUserData.Option.IP = IP_TextBox.Text;
            NewUserData.Option.Port = Convert.ToInt32(Port_TextBox.Text);
            NewUserData.Option.ServerCount = Convert.ToInt32(SeverCount_TextBox.Text);
            NewUserData.Option.ClientCount = Convert.ToInt32(ClientCount_TextBox.Text);
            NewUserData.Option.WindowSizeX = Convert.ToInt32(WinSizeX_TextBox.Text);
            NewUserData.Option.WindowSizeY = Convert.ToInt32(WinSizeY_TextBox.Text);
            NewUserData.Option.Log = Log_CheckBox.Checked;
            NewUserData.Option.Cooked = Cooked_CheckBox.Checked;

            try
            {
                //이름 체크후에 정해주기.
                if (UserDataDic.ContainsKey(NewUserData.DataName))
                {
                    int Count = 2;
                    while (UserDataDic.ContainsKey(String.Format("{0}_{1}", NewUserData.DataName, Count)))
                    {
                        ++Count;
                    }
                    NewUserData.DataName = String.Format("{0}_{1}", NewUserData.DataName, Count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return String.Empty;
            }
            UserDataDic.Add(NewUserData.DataName, NewUserData);
            CurrentUserData = NewUserData.DataName;
            return NewUserData.DataName;
        }

        //유저 데이터를 수정합니다.
        private string MotifyUserData(string _name)
        {
            //0개인 경우
            if (0 == SelectSetting_ComboBox.Items.Count)
            {
                if (MessageBox.Show("You Want New Create Data?", "Not Exist Data", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    return CreateUserData(_name);
                }
                return String.Empty;
            }

            //이름을 바꾼경우입니다.
            if (SelectSetting_ComboBox.SelectedItem.ToString() != _name)
            {
                RemoveUserData(SelectSetting_ComboBox.SelectedItem.ToString());
                return CreateUserData(_name);
            }

            //그것이 아닌경우에는 딕에서 찾아봅니다.
            if (!UserDataDic.ContainsKey(_name))
            {
                //만약 존제하지 않는다면 새롭게 다시 만들어줍니다.
                if (MessageBox.Show("You Want New Create Data?", "Not Exist Data", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    return CreateUserData(_name);
                }
                return String.Empty;
            }

            UserData FindData = UserDataDic[_name];
            FindData.ClientInfo.Dir = Path.GetDirectoryName(ClientDirectory_Box.Text);
            FindData.ClientInfo.Name = Path.GetFileName(ClientDirectory_Box.Text);

            FindData.ServerInfo.Dir = Path.GetDirectoryName(ServerDirectory_Box.Text);
            FindData.ServerInfo.Name = Path.GetFileName(ServerDirectory_Box.Text);

            FindData.MapInfo = MapDirectory_Box.Text;


            FindData.Option.IP = IP_TextBox.Text;
            FindData.Option.Port = Convert.ToInt32(Port_TextBox.Text);
            FindData.Option.ServerCount = Convert.ToInt32(SeverCount_TextBox.Text);
            FindData.Option.ClientCount = Convert.ToInt32(ClientCount_TextBox.Text);
            FindData.Option.WindowSizeX = Convert.ToInt32(WinSizeX_TextBox.Text);
            FindData.Option.WindowSizeY = Convert.ToInt32(WinSizeY_TextBox.Text);
            FindData.Option.Log = Log_CheckBox.Checked;
            FindData.Option.Cooked = Cooked_CheckBox.Checked;
            return _name;
        }

        //유저 데이터를 지웁니다.
        private bool RemoveUserData(string _name)
        {
            if (!UserDataDic.ContainsKey(_name))
            {
                MessageBox.Show("Not Find UserData\nCheck to Name");
                return false;
            }

            //이름을 바꾼경우입니다.
            if (SelectSetting_ComboBox.SelectedItem.ToString() != _name)
            {
                RemoveUserData(SelectSetting_ComboBox.SelectedItem.ToString());
                return true;
            }

            UserDataDic.Remove(_name);
            return true;
        }

        //유저 데이터를 완전 초기값으로 바꿉니다.
        private void InitializeUserData()
        {
            ClientDirectory_Box.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ServerDirectory_Box.Text = "C:\\Program Files\\Epic Games\\UE_4.23\\Engine\\Binaries\\Win64";
            MapDirectory_Box.Text = "";
            IP_TextBox.Text = "127.0.0.1";
            Port_TextBox.Text = "7777";
            SeverCount_TextBox.Text = "1";
            ClientCount_TextBox.Text = "2";
            WinSizeX_TextBox.Text = "800";
            WinSizeY_TextBox.Text = "600";
            Log_CheckBox.Checked = false;
            Cooked_CheckBox.Checked = false;
        }

        //콤보 박스를 초기화 합니다.
        private void Refresh_ComboBox()
        {
            SelectSetting_ComboBox.Items.Clear();
            foreach (var item in UserDataDic)
            {
                SelectSetting_ComboBox.Items.Add(item.Key);
            }
            SelectSetting_ComboBox.Refresh();

            if (0 < SelectSetting_ComboBox.Items.Count && CurrentUserData != String.Empty)
            {
                foreach (var item in SelectSetting_ComboBox.Items)
                {
                    if (item.ToString() == CurrentUserData)
                    {
                        SelectSetting_ComboBox.SelectedItem = item;
                    }
                }
                if (null == SelectSetting_ComboBox.SelectedItem)
                {
                    SelectSetting_ComboBox.Select(SelectSetting_ComboBox.SelectedIndex,1);
                }
            }
            else if (0 >= SelectSetting_ComboBox.Items.Count)
            {
                SelectSetting_ComboBox.SelectedIndex = -1;
            }
            else
            {
                --SelectSetting_ComboBox.SelectedIndex;
                Refresh_ComboBox();
            }
        }
    }
}
