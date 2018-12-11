using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient; 
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArenaGameTool
{
    public partial class frmMain : Form
    {
        private SqlConnection m_dbConn = null;
        private int m_changeCol = -1;
        private int m_changeRow = -1;
        public frmMain()
        {
            InitializeComponent();
            
        } 
        private string getUtf8NickNameFromNickName(string strBase64)
        { 
            var bytes = Convert.FromBase64String(strBase64);
            return System.Text.Encoding.Unicode.GetString(bytes);
        }

        private string getNickNameBase64(string nickName)
        { 
            var bytes = System.Text.Encoding.Unicode.GetBytes(nickName);
            return Convert.ToBase64String(bytes);
        }

        private string m_configPath = ".\\configDB.json";
        void loadConfig()
        {
            try
            {
                if(!File.Exists(m_configPath))
                {
                    File.WriteAllText(m_configPath, "{}");  //\"ip\":,\"user\":,\"passwd\":
                    return;
                }
                StreamReader file = File.OpenText(m_configPath);
                JsonTextReader reader = new JsonTextReader(file); 
                JObject jsonObject = (JObject)JToken.ReadFrom(reader); 
                ip.Text = (string)jsonObject["ip"];
                user.Text = (string)jsonObject["user"];
                passwd.Text = (string)jsonObject["passwd"];
                file.Close();

            }
            catch(Exception e)
            { 
                MessageBox.Show(e.ToString());
            }
        }
        void unLoadConfig()
        {
            try
            {
                string json = File.ReadAllText(m_configPath);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj["ip"] = ip.Text;
                jsonObj["user"] = user.Text;
                jsonObj["passwd"] = passwd.Text;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(m_configPath, output);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadConfig();
        }

        private void cboEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
         //  initDBConn();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_dbConn != null)
            {
                m_dbConn.Close();
            }
        }
         

        private void link_Click(object sender, EventArgs e)
        {
            if(ip.Text.Length < 0 || user.Text.Length < 1 || passwd.Text.Length < 1)
            {
                MessageBox.Show(string.Format("请输入信息！"));
                return;
            } 
            string connectionString = @"Data Source=" + ip.Text +"; Initial Catalog=master;User ID=" + user.Text + ";Password=" + passwd.Text + ";";
            try
            {
                m_dbConn = new SqlConnection(connectionString);
                m_dbConn.Open();
                ShowDB();
                unLoadConfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("连接数据库失败:{0}", ex.ToString()));
                Application.Exit();
                m_dbConn = null; 
            }
        }

        private void outClose_Click(object sender, EventArgs e)
        {
            string[] sqlCmd = { "sp_configure 'xp_cmdshell',0", "reconfigure",
                "exec sp_configure 'Ad Hoc Distributed Queries',0", "reconfigure",
                "sp_configure 'show advanced options',0", "reconfigure", };
            var cmd = new SqlCommand(sqlCmd[0], m_dbConn);
            try
            {
                for (int i = 0; i < sqlCmd.Length; i++)
                {
                    cmd.CommandText = sqlCmd[i];
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("命令完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.ToString());
            }

        }

        private void outOpen_Click(object sender, EventArgs e)
        {

            string[] sqlCmd = { "sp_configure 'show advanced options',1", "reconfigure",
                "exec sp_configure 'Ad Hoc Distributed Queries',1", "reconfigure",
                "sp_configure 'xp_cmdshell',1", "reconfigure", };
            var cmd = new SqlCommand(sqlCmd[0], m_dbConn);
            try
            {
                for (int i = 0; i < sqlCmd.Length; i++)
                {
                    cmd.CommandText = sqlCmd[i];
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("命令完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.ToString());
            }

        }
        private void ShowDB()
        { 
            var cmd = new SqlCommand("SELECT Name FROM Master..SysDatabases ORDER BY Name", m_dbConn); 
            try
            {
                var reader = cmd.ExecuteReader();
                List<string> result = new List<string>();
                 
                while (reader.Read())
                {
                    result.Add(reader.GetString(0)); 
                }
                reader.Close();
                DBlist.Items.Clear();
                DBlist.Items.AddRange(result.ToArray());
                DBlist.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowDB失败:" + ex.ToString());
                return;
            }
        }
        private void ShowTable()
        { 
            var cmd = new SqlCommand("select name from sysobjects where xtype='u'", m_dbConn);
            try
            {
                var reader = cmd.ExecuteReader();
                List<string> result = new List<string>();

                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
                reader.Close(); 
                tableList.Items.Clear();
                tableList.Items.AddRange(result.ToArray());
                tableList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowTable失败:" + ex.ToString());
                return;
            }
        }
        private void ShowProc()
        {
            var cmd = new SqlCommand("select name from sysobjects where xtype='p'", m_dbConn);
            try
            {
                var reader = cmd.ExecuteReader();
                List<string> result = new List<string>();
                 
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
                reader.Close();
                proBox.Items.Clear();
                if (result.Count() > 0)
                {
                    proBox.Items.AddRange(result.ToArray());
                    proBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowTable失败:" + ex.ToString());
                return;
            }
        }
        private void ShowCol(string tableName)
        {
            var cmd = new SqlCommand("Select Name FROM SysColumns Where id = Object_Id('" + tableName + "')", m_dbConn);
            try
            {
                var reader = cmd.ExecuteReader();
                List<string> result = new List<string>();
                selectInfo.Text = "";
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                    if (selectInfo.Text == "")
                    {
                        selectInfo.Text = "top 10 ";
                        selectInfo.Text += reader.GetString(0);
                    }else
                    {
                        selectInfo.Text += "," + reader.GetString(0);
                    }
                }
                selectTable.Text = tableName;                 
                inOutCol.Text = selectInfo.Text;
                reader.Close();
                col.Items.Clear();
                col.Items.AddRange(result.ToArray());
                col.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowCol失败:" + ex.ToString());
                return;
            }
        }
        //数据库
        private void DBlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBlist.Text == "")
                return; 
            var cmd = new SqlCommand("use " + DBlist.Text, m_dbConn);
            try
            {
                cmd.ExecuteNonQuery();
                ShowTable();
                ShowProc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.ToString());
                return;
            }
        } 
        //表
        private void tableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableList.Text == "")
                return;  
            ShowCol(tableList.Text);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if(selectTable.Text.Length < 1 || selectInfo.Text.Length < 1)
            {
                return;
            }
            string sqlCmd = "select " + selectInfo.Text + " from " + selectTable.Text;
            if(whereInfo.Text.Length > 1)
            {
                sqlCmd += " where " + whereInfo.Text;
            }
            var cmd = new SqlCommand(sqlCmd, m_dbConn);
            try
            {
                var reader = cmd.ExecuteReader();
                bool isSet = false;
                dataShow.Columns.Clear();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    for (int i = 0; !isSet && i < reader.FieldCount; i++)
                    {
                        if (i == 0)
                        {
                            item.Text = reader.GetName(i).Trim();
                        }else
                        {
                            item.SubItems.Add(reader.GetName(i).Trim());
                        }
                        dataShow.Columns.Add(reader.GetName(i).Trim(), reader.GetName(i).Trim());
                    }
                    isSet = true;
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataShow.Rows.Add(row);
                    for (int i = 0; i < reader.FieldCount; i++)
                    { 
                        dataShow.Rows[index].Cells[i].Value = reader[reader.GetName(i).Trim()].ToString(); 
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.ToString());
                return;
            } 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tableList.Text.Length < 1 || outPath.Text.Length < 1)
                return;
            if (MessageBox.Show("请确保服务器上的目录存在，再执行！", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            var dataBase = DBlist.Text;
            var tableName = tableList.Text;
            string sqlCmd = "EXEC master..xp_cmdshell 'bcp \"select " + inOutCol.Text + " from " + dataBase + ".dbo." + tableName + "\" queryout \"" + outPath.Text + "\\" + tableName + ".xls\" -c -q -U\"" + user.Text + "\" -P\"" + passwd.Text + "\"'";

            var cmd = new SqlCommand(sqlCmd, m_dbConn);
            try
            {
                btnOutXls.Enabled = false;
                cmd.ExecuteNonQuery();
                MessageBox.Show("命令完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.ToString());
            }
            btnOutXls.Enabled = true;
        }

        private void btnInXls_Click(object sender, EventArgs e)
        {
            if (tableList.Text.Length < 1 || outPath.Text.Length < 1)
                return;
            if (MessageBox.Show("请确保服务器上的目录存在，再执行！", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            var tableName = tableList.Text;
            string sqlCmd = "insert into ";
            if (outTB.Text.Length > 1)
            {
                tableName = outTB.Text;
                sqlCmd = "select " + inOutCol.Text + "into " + tableName + " from" +
              " OPENROWSET('MICROSOFT.JET.OLEDB.4.0', 'Excel 5.0;HDR=YES;DATABASE=\"" + outPath.Text + "\\" + tableName + ".xls ', sheet1$)";
            }
            else
            {
                sqlCmd = "insert into " + tableName + " select " + inOutCol.Text + " from" +
              " OPENROWSET('MICROSOFT.JET.OLEDB.4.0', 'Excel 5.0;HDR=YES;DATABASE=\"" + outPath.Text + "\\" + tableName + ".xls ', sheet1$)";
            }


            var cmd = new SqlCommand(sqlCmd, m_dbConn);
            try
            {
                btnInXls.Enabled = false;
                cmd.ExecuteNonQuery();
                MessageBox.Show("命令完成！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("失败:" + ex.ToString());
            }
            btnInXls.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(whereInfo.Text == "")
            {
                MessageBox.Show("请输入条件！");
                return; 
            }

            if ( m_changeCol < 0 ||  m_changeRow  < 0)
            {
                MessageBox.Show("请先编辑内容！");
                return;
            }
            string sqlUp = "update " + selectTable.Text + " set ";

            bool isSet = false;
            string[] strCol = new string[dataShow.ColumnCount];
            for (int col = 0; col < dataShow.ColumnCount; col++)
            {
                if (m_changeCol != col)
                    continue;
                strCol[col] = '@' + dataShow.Columns[col].HeaderText.ToString();
                if (isSet)
                {
                    sqlUp += " and ";
                }
                isSet = true;
                sqlUp += dataShow.Columns[col].HeaderText.ToString() + "=" + strCol[col];
                break;
            }
            sqlUp += " where ";
            sqlUp += whereInfo.Text;
            SqlCommand cmd = new SqlCommand(sqlUp, m_dbConn); 

            int count = 0;
            string[] str = new string[dataShow.Rows.Count];
            for (int i = 0; i < dataShow.Rows.Count; i++)
            {
                if (i == m_changeRow)
                {
                    for (int j = 0; j < dataShow.ColumnCount; j++)
                    {
                        if (m_changeCol != j)
                            continue;
                        cmd.Parameters.AddWithValue(strCol[j], dataShow.Rows[i].Cells[j].Value.ToString());
                        break;
                    }

                    try
                    {
                        count += cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("失败:" + ex.ToString());
                    }
                    break;
                }
            }
            m_changeCol = m_changeRow = -1;
            MessageBox.Show(string.Format("影响条数={0}", count));
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (whereInfo.Text == "")
            {
                MessageBox.Show("请输入条件！");
                return;
            } 

            string sqlDel = "delete from " + selectTable.Text + " where " + whereInfo.Text; 
            SqlCommand cmd = new SqlCommand(sqlDel, m_dbConn);
            int count = cmd.ExecuteNonQuery(); 
            MessageBox.Show(string.Format("影响条数={0}", count));
        }

        private void button1_Click_1old(object sender, EventArgs e)
        {

            string sqlDel = "delete from " + selectTable.Text + " where ";
            string[] strCol = new string[dataShow.ColumnCount];
            for (int col = 0; col < dataShow.ColumnCount; col++)
            {
                strCol[col] = '@' +  dataShow.Columns[col].HeaderText.ToString();
                if(col != 0)
                {
                    sqlDel += " and ";
                }
                sqlDel += dataShow.Columns[col].HeaderText.ToString() + "=" + strCol[col]; 
            }


            SqlCommand cmd = new SqlCommand(sqlDel, m_dbConn);
            string[] str = new string[dataShow.Rows.Count];
            int count = 0;
            for (int i = 0; i < dataShow.Rows.Count; i++)
            {
                if (dataShow.Rows[i].Selected == true)
                {
                    for(int j = 0; j < dataShow.ColumnCount; j ++)
                    { 
                        cmd.Parameters.AddWithValue(strCol[j], dataShow.Rows[i].Cells[j].Value.ToString());
                    }

                    try
                    {
                         count += cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("失败:" + ex.ToString());
                        break;
                    }
                }
            }
            MessageBox.Show(string.Format("影响条数={0}", count));
        }

        private void dataShow_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataShow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            m_changeCol = e.ColumnIndex;
            m_changeRow = e.RowIndex;
        }   

        private void DBlist_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;
            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }
    }
}
