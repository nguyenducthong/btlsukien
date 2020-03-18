using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetWinForm.Utils;

namespace TimeSheetWinForm
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }
        #region
        private static bool _exiting;
        static TimeSheetModel TimeSheetModel = new TimeSheetModel();
        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = $"Xin chào {Session.Name}";
            usersToolStripMenuItem.Enabled = true;
            manageProjectToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.Enabled = false;
            manageTaskToolStripMenuItem.Enabled = false;
            timesheetToolStripMenuItem.Enabled = false;
            myTimeSheetToolStripMenuItem.Enabled = false;
            configToolStripMenuItem.Enabled = true;
            timesheetStaticToolStripMenuItem.Enabled = false;
            foreach(var a in Session.RoleNameOfUser)
            {
                switch (a)
                {
                    case "Admin":
                        usersToolStripMenuItem.Enabled = manageProjectToolStripMenuItem.Enabled = clientToolStripMenuItem.Enabled = manageTaskToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = myTimeSheetToolStripMenuItem.Enabled = configToolStripMenuItem.Enabled = timesheetStaticToolStripMenuItem.Enabled = true;
                        break;
                    case "ProjectAdmin":
                         manageProjectToolStripMenuItem.Enabled = clientToolStripMenuItem.Enabled = manageTaskToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = myTimeSheetToolStripMenuItem.Enabled = configToolStripMenuItem.Enabled = timesheetStaticToolStripMenuItem.Enabled = true;
                        break;
                    case "SuperVisor":
                        manageProjectToolStripMenuItem.Enabled = clientToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = timesheetStaticToolStripMenuItem.Enabled = true;
                        break;
                    case "BasicUser":
                        myTimeSheetToolStripMenuItem.Enabled = true;
                        break;
                        

                }

            }
            //Neu Basicuser nhung duoc lam PM cua du an thi se bat duoc cac nut manage project,managetask, timesheet nhung chi duoc phep xem du an no lam quan ly
            //(xu ly viec hien ra o  cac code cua doan sau nhe, o day chi xu ly viec bat nut)
            if (TimeSheetModel.ProjectUsers.Any(s => s.UserId == Session.UserSessionId && s.Type == Entites.ProjectUserType.PM))
            {
                manageProjectToolStripMenuItem.Enabled = manageTaskToolStripMenuItem.Enabled = timesheetToolStripMenuItem.Enabled = true;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (!_exiting && MessageBox.Show("Bạn có chắc chắn muốn thoát?","Messenger",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                Session.UserSessionId = 0;
                Session.Name = "";
                Session.RoleNameOfUser = null;
                Environment.Exit(1);
            }
           
            
            
        }

    
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerUser managerUser = new ManagerUser();
            managerUser.MdiParent = this;
            managerUser.Show();
            //panel1.Controls.Clear();
            //panel1.Controls.Add(new ManageUser1());
        }

        private void manageProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerProject managerProject = new ManagerProject();
            managerProject.MdiParent = this;
            managerProject.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClient manageClient = new ManageClient();
            manageClient.MdiParent = this;
            manageClient.Show();
        }

        private void manageTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTask manageTask = new ManageTask();
            manageTask.MdiParent = this;
            manageTask.Show();
        }

        private void timesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerTimesheet managerTimesheet = new ManagerTimesheet();
            managerTimesheet.MdiParent = this;
            managerTimesheet.Show();
        }

        private void myTimeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMyTimesheet manageMyTimesheet = new ManageMyTimesheet();
            manageMyTimesheet.MdiParent = this;
            manageMyTimesheet.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.MdiParent = this;
            config.Show();
        }

        private void timesheetStaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTimesheetStatic manageTimesheetStatic = new ManageTimesheetStatic();
            manageTimesheetStatic.MdiParent = this;
            manageTimesheetStatic.Show();
        }
    }
}
