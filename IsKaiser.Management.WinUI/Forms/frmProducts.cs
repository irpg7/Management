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
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.Entities.Concrete;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmProducts : DevExpress.XtraEditors.XtraForm
    {
        IProductTypeService _productTypeService;
        IProductService _productService;

        public frmProducts()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _productTypeService = InstanceFactory.GetInstance<IProductTypeService>();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void tbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {
            var searchForValue = _productTypeService.GetByName(cmbProductType.Text);
            if (searchForValue==null)
            {
                _productTypeService.Add(new ProductType { Type = cmbProductType.Text });
                PopulateComboBox();
            }
            var product = new Product
            {
                ProductName = txtProductName.Text,
                ProductDescription = txtDescription.Text,
                ProductType=Convert.ToInt16(cmbProductType.GetColumnValue("TypeId"))
            };
            _productService.Add(product);
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu frMenu = new frmMenu();
            frMenu.Show();
        }
        void PopulateComboBox()
        {
            cmbProductType.Properties.DataSource = _productTypeService.GetList();
            cmbProductType.Properties.ValueMember = "Type";
            cmbProductType.Properties.DisplayMember = "Type";
        }
    }
}