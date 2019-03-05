using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.WinUI.ExceptionHandling;
using System.IO;
using System.Diagnostics;

namespace IsKaiser.Management.WinUI.Forms
{

    public partial class frmNewCustomer : XtraForm
    {
        #region Declarations
        public frmNewCustomer()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();

            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        ICustomerService _customerService;
        IEmployeeService _employeeService;

        Customer customerInfo;
        CustomerAccountant customerAccountant;
        CustomerPurchasingStaff customerPurchStaff;
        CustomerDirector customerDirector;
        #endregion
        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            LoadEnvoys();
            if (frmMain.customerIdx != 0)
            {
                FillCustomerInfo();
                tbarDetails.Visible = true;
            }
            else
            {
                tbarDetails.Visible = false;
            }
        }

        void FillCustomerInfo()
        {
            try
            {
                customerInfo = _customerService.Get(frmMain.customerIdx);
                customerAccountant = _customerService.GetAccountant(frmMain.customerIdx);
                customerPurchStaff = _customerService.GetPurchasingStaff(frmMain.customerIdx);
                customerDirector = _customerService.GetDirector(frmMain.customerIdx);

                txtCode.Text = customerInfo.CustomerCode;
                txtName.Text = customerInfo.CustomerName;
                txtTaxNo.Text = customerInfo.CustomerTaxNo;
                txtTaxDepart.Text = customerInfo.CustomerTaxDepartment;
                cmbEnvoy.EditValue = customerInfo.CustomerEnvoyId;
                txtAddress.Text = customerInfo.CustomerAddress;
                chbActive.Checked = customerInfo.CustomerActive;
                chbAppointment.Checked = customerInfo.CustomerGotAppointment;
                chbDebate.Checked = customerInfo.CustomerDebated;

                txtAccountantName.Text = customerAccountant.AccountantName;
                txtAccountantGsm.Text = customerAccountant.AccountantGsm;
                txtAccountantMail.Text = customerAccountant.AccountantMail;
                txtAccountantPhone.Text = customerAccountant.AccountantPhone;
                dtpAccountantExpiry.EditValue = customerAccountant.AccountantExpiry;

                txtPurchasingDirector.Text = customerPurchStaff.PurchaseStaffName;
                txtPurchasingGsm.Text = customerPurchStaff.PurchaseStaffGsm;
                txtPurchasingMail.Text = customerPurchStaff.PurchaseStaffMail;
                txtPurchasingPhone.Text = customerPurchStaff.PurchaseStaffPhone;

                txtDirectorName.Text = customerDirector.DirectorName;
                txtDirectorTitle.Text = customerDirector.DirectorTitle;
                txtDirectorGsm.Text = customerDirector.DirectorGsm;
                txtDirectorMail.Text = customerDirector.DirectorMail;
                txtDirectorPhone.Text = customerDirector.DirectorPhone;
            }
            catch { }
        }
        private void tbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                if (frmMain.customerIdx != 0)
                {
                    #region Update
                    var updateCustomer = new Customer
                    {
                        CustomerId = customerInfo.CustomerId,
                        CustomerCode = txtCode.Text,
                        CustomerName = txtName.Text,
                        CustomerTaxNo = txtTaxNo.Text,
                        CustomerTaxDepartment = txtTaxDepart.Text,
                        CustomerAddress = txtAddress.Text,
                        CustomerActive = chbActive.Checked,
                        CustomerDebated = chbDebate.Checked,
                        CustomerGotAppointment = chbAppointment.Checked,
                        CustomerEnvoyId = Convert.ToInt32(cmbEnvoy.EditValue)
                    };
                    
                    var updateDirector = new CustomerDirector
                    {
                        DirectorId = customerDirector.DirectorId,
                        DirectorName = txtDirectorName.Text,
                        DirectorTitle = txtDirectorTitle.Text,
                        DirectorGsm = txtDirectorGsm.Text,
                        DirectorMail = txtDirectorMail.Text,
                        DirectorPhone = txtDirectorPhone.Text,
                        CustomerId = updateCustomer.CustomerId
                    };
                    var updatePurchasingStaff = new CustomerPurchasingStaff
                    {
                        PurchaseStaffId = customerPurchStaff.PurchaseStaffId,
                        PurchaseStaffName = txtPurchasingDirector.Text,
                        PurchaseStaffGsm = txtPurchasingGsm.Text,
                        PurchaseStaffMail = txtPurchasingMail.Text,
                        PurchaseStaffPhone = txtPurchasingPhone.Text,
                        CustomerId = updateCustomer.CustomerId
                    };
                    var updateAccountant = new CustomerAccountant
                    {
                        AccountantId = customerAccountant.AccountantId,
                        CustomerId = updateCustomer.CustomerId,
                        AccountantName = txtAccountantName.Text,
                        AccountantGsm = txtAccountantGsm.Text,
                        AccountantMail = txtAccountantMail.Text,
                        AccountantPhone = txtAccountantPhone.Text,
                        AccountantExpiry = dtpAccountantExpiry.DateTime
                    };
                    _customerService.Update(updateCustomer,updateAccountant,updateDirector,updatePurchasingStaff);
                    FillCustomerInfo();
                    XtraMessageBox.Show("Güncellendi.");
                    
                    #endregion
                }
                else
                {
                    #region NewRecord
                    var newCustomerRec = new Customer
                    {
                        CustomerCode = txtCode.Text,
                        CustomerName = txtName.Text,
                        CustomerTaxNo = txtTaxNo.Text,
                        CustomerTaxDepartment = txtTaxDepart.Text,
                        CustomerAddress = txtAddress.Text,
                        CustomerActive = chbActive.Checked,
                        CustomerDebated = chbDebate.Checked,
                        CustomerGotAppointment = chbAppointment.Checked,
                        CustomerEnvoyId = Convert.ToInt32(cmbEnvoy.EditValue)
                    };
                    
                    var newDirectorRec = new CustomerDirector
                    {
                        DirectorName = txtDirectorName.Text,
                        DirectorTitle = txtDirectorTitle.Text,
                        DirectorGsm = txtDirectorGsm.Text,
                        DirectorMail = txtDirectorMail.Text,
                        DirectorPhone = txtDirectorPhone.Text,
                     
                    };
                   
                    var newPurchasingStaffRec = new CustomerPurchasingStaff
                    {
                        PurchaseStaffName = txtPurchasingDirector.Text,
                        PurchaseStaffGsm = txtPurchasingGsm.Text,
                        PurchaseStaffMail = txtPurchasingMail.Text,
                        PurchaseStaffPhone = txtPurchasingPhone.Text,
                     
                    };
                  
                    var newAccountantRec = new CustomerAccountant
                    {
                       
                        AccountantName = txtAccountantName.Text,
                        AccountantGsm = txtAccountantGsm.Text,
                        AccountantMail = txtAccountantMail.Text,
                        AccountantPhone = txtAccountantPhone.Text,
                        AccountantExpiry = dtpAccountantExpiry.DateTime
                    };
                    _customerService.Add(newCustomerRec,newAccountantRec,newDirectorRec,newPurchasingStaffRec);
                    frmMain.customerIdx = newCustomerRec.CustomerId;
                    FillCustomerInfo();
                    tbarDetails.Visible = true;
                    XtraMessageBox.Show("Başarıyla Oluşturuldu.");
                    #endregion
                }
            });

        }
        void LoadEnvoys()
        {
            cmbEnvoy.Properties.DataSource = _employeeService.GetAll();
            cmbEnvoy.Properties.DisplayMember = "EmployeeName";
            cmbEnvoy.Properties.ValueMember = "EmployeeId";
        }

        private void tbtnAddDebate_ItemClick(object sender, TileItemEventArgs e)
        {
            if (chbDebate.Checked && customerInfo.CustomerDebated)
            {
                frmDebateList.debateIdx = 0;
                frmNewDebate frNewDebate = new frmNewDebate();
                frNewDebate.Text = "Görüşme - " + customerInfo.CustomerName;
                frNewDebate.Show();
            }
            else
            {
                XtraMessageBox.Show("Görüşüldü bilgisini işaretleyip kaydediniz.");
            }


        }

        private void tbtnDebates_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDebateList frDebateList = new frmDebateList();
            frDebateList.Text = "Görüşmeler - " + customerInfo.CustomerName;
            frDebateList.Show();
        }

        private void tbtnAppointment_ItemClick(object sender, TileItemEventArgs e)
        {
            if (chbAppointment.Checked && customerInfo.CustomerGotAppointment)
            {
                frmAppointmentList.appointmentIdx = 0;
                frmNewAppointment frNewAppointment = new frmNewAppointment();
                frNewAppointment.Text = "Randevu - " + customerInfo.CustomerName;
                frNewAppointment.Show();
            }
            else
            {
                XtraMessageBox.Show("Randevu bilgisini işaretleyip kaydediniz.");
            }

        }

        private void tbtnAppointments_ItemClick(object sender, TileItemEventArgs e)
        {
            frmAppointmentList frAppointmentList = new frmAppointmentList();
            frAppointmentList.Text = "Randevular - " + customerInfo.CustomerName;
            frAppointmentList.Show();
        }

        private void tbtnAttachments_ItemClick(object sender, TileItemEventArgs e)
        {
            OpenFile();
        }
        string path;
        private void tbtnAddAttachment_ItemClick(object sender, TileItemEventArgs e)
        {
            OpenFileDialog attachmentsDialog = new OpenFileDialog();
            attachmentsDialog.Multiselect = true;
            path = Application.StartupPath + "\\Documents\\" + customerInfo.CustomerName.Replace('/', '-');
            if (attachmentsDialog.ShowDialog() == DialogResult.OK)
            {
            transfer:
                if (Directory.Exists(path))
                {
                    foreach (var file in attachmentsDialog.FileNames)
                    {
                        File.Copy(file, path + "\\" + Path.GetFileName(file), true);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    goto transfer;
                }
            }
        }

        private void tbtnOpenAttachments_ItemClick(object sender, TileItemEventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            path = Application.StartupPath + "\\Documents\\" + customerInfo.CustomerName.Replace('/', '-');
            if (Directory.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                XtraMessageBox.Show("Dizin bulunamadı.");
            }
        }
    }
}