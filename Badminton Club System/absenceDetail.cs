using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Badminton_Club_System
{
    
    public partial class absenceDetail : Form
    {
        bool selectBtnCheck = false;
        String today;
        int col = 0;
        public absenceDetail(String today)
        {
            InitializeComponent();
            this.today = today;
            updateData();
            monthTbox.Text = today;
        }

        private void absenceDetailListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                absenceDetailCMS.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void updateData()
        {
            table.Clear();
            absenceDetailCB.Items.Clear();
            try
            {
                db.sql = $"select max(meeting_count) from meeting where `month` = '{today}'";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    col = r.GetInt16(0);
                }
                createCol();
                r.Dispose();
                db.disposeCmd();
                db.sql = "select a.member_id , mem.`name` , m.meeting_count,a.`status` from `absence` a " +
                            "inner join `meeting` m on a.meeting_id = m.id " +
                            "inner join `member` mem on a.member_id = mem.nim " +
                           $"where m.`month` = '{today}' " +
                            "order by m.meeting_count";
                db.addCMD();
                r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    if (r.GetString(0) == "001")
                        continue;
                    ListViewItem item = new ListViewItem(r.GetString(0));
                    item.SubItems.Add(r.GetString(1));
                    if (r.GetInt16(2) == 1)
                        item.SubItems.Add(r.GetString(3));
                    else
                    {
                        int i = 0;
                        foreach (ListViewItem el in table.Items)
                        {
                            if (el.SubItems[0].Text == r.GetString(0))
                                table.Items[i].SubItems.Add(r.GetString(3));
                            i++;
                        }
                        continue;
                    }
                    table.Items.Add(item);
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createCol()
        {
            table.Columns.Add("NIM",145);
            table.Columns.Add("Name", 145);
            for (int i = 0; i < col; i++)
            {
                table.Columns.Add("Meeting " + (i + 1).ToString(), 100);
                absenceDetailCB.Items.Add("Meeting " + (i + 1).ToString());
            }
            absenceDetailCB.SelectedIndex = 0;
        }

        private void newMeetinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(today);
                String[] date = today.Split();
                Console.WriteLine(date[0]);
                Console.WriteLine(date[1]);
                String count = (col + 1).ToString();
                db.sql = $"insert into `meeting` values('{date[0] + date[1] + count}','{today}',{col + 1})";
                db.addCMD();
                db.cmd.ExecuteNonQuery();
                db.disposeCmd();
                db.sql = $"insert into `absence`(`id`,`member_id`,`meeting_id`) select concat('{date[0] + date[1] + count}',m.nim) , m.nim , '{date[0] + date[1] + count}' from `member` m";
                db.addCMD();
                Console.WriteLine(db.sql);
                db.cmd.ExecuteNonQuery();
                updateData();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeStatus(String status)
        {
            try
            {
                String currentMeeting = (absenceDetailCB.SelectedIndex + 1).ToString();
                String[] date = today.Split();
                foreach (ListViewItem item in table.SelectedItems)
                {
                    db.sql = $"update `absence` set `status` = '{status}' where `id`='{date[0] + date[1] + currentMeeting + item.SubItems[0].Text}'";
                    Console.WriteLine(db.sql);
                    db.addCMD();
                    db.cmd.ExecuteNonQuery();
                    db.disposeCmd();
                }
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void absenceDetailAbsenceBtn_Click(object sender, EventArgs e)
        {
            if (table.SelectedItems.Count > 0)
            {
                changeStatus("Approved");
                updateData();
            } else
            {
                MessageBox.Show("No item selected","ERROR");
            }
        }

        private void permissionBtn_Click(object sender, EventArgs e)
        {
            if (table.SelectedItems.Count > 0)
            {
                changeStatus("Permission");
                updateData();
            }
            else
            {
                MessageBox.Show("No item selected", "ERROR");
            }
        }

        private void absenceDetailxAbsenceBtn_Click(object sender, EventArgs e)
        {
            if (table.SelectedItems.Count > 0)
            {
                changeStatus("None");
                updateData();
            }
            else
            {
                MessageBox.Show("No item selected", "ERROR");
            }
        }


        private void table_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
            if (e.Item.Checked)
            {
                e.Item.Selected = true;
            } else
            {
                e.Item.Selected = false;
            }

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(ListViewItem item in table.Items)
            {
                if (!selectBtnCheck)
                {
                    item.Checked = true;
                    item.Selected = true;
                    flag = true;
                }
                else
                {
                    item.Checked = false;
                    item.Selected = false;
                }
            }
            if (flag)
            {
                selectBtnCheck = true;
                selectBtn.Text = "Unselect all";
            }
            else
            {
                selectBtnCheck = false;
                selectBtn.Text = "Select all";
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            table.Clear();
            absenceDetailCB.Items.Clear();
            try
            {
                db.sql = $"select max(meeting_count) from meeting where `month` = '{today}'";
                db.addCMD();
                MySqlDataReader r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    col = r.GetInt16(0);
                }
                createCol();
                r.Dispose();
                db.disposeCmd();
                db.sql = "select a.member_id , mem.`name` , m.meeting_count,a.`status` from `absence` a " +
                            "inner join `meeting` m on a.meeting_id = m.id " +
                            "inner join `member` mem on a.member_id = mem.nim " +
                           $"where m.`month` = '{today}' and mem.`nim`='{filterTbox.Text}'" +
                            "order by m.meeting_count";
                db.addCMD();
                r = db.cmd.ExecuteReader();
                while (r.Read())
                {
                    if (r.GetString(0) == "001")
                        continue;
                    ListViewItem item = new ListViewItem(r.GetString(0));
                    item.SubItems.Add(r.GetString(1));
                    if (r.GetInt16(2) == 1)
                        item.SubItems.Add(r.GetString(3));
                    else
                    {
                        int i = 0;
                        foreach (ListViewItem el in table.Items)
                        {
                            if (el.SubItems[0].Text == r.GetString(0))
                                table.Items[i].SubItems.Add(r.GetString(3));
                            i++;
                        }
                        continue;
                    }
                    table.Items.Add(item);
                }
                r.Dispose();
                db.disposeCmd();
            }
            catch (MySqlException err)
            {
                MessageBox.Show(err.Message, err.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
