using DevExpress.XtraEditors;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }
        IUserService _userService;
        public static byte UserType;
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
        void DoLogin()
        {
            var userType = _userService.CheckUser(txtUserName.Text.ToLower(), txtPassword.Text.ToLower());
            if (userType != null)
            {
                
                frmMenu frMenu = new frmMenu();
                frMenu.Show();
                UserType = userType.UserType;
                Hide();

            }
            else
            {
                XtraMessageBox.Show("Kullanıcı veya Şifre Hatalı");
            }
        }
        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode==System.Windows.Forms.Keys.Enter)
            {
                DoLogin();
            }
        }
    }
}