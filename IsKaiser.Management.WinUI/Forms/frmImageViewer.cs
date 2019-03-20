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
using System.IO;
using System.Diagnostics;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmImageViewer : DevExpress.XtraEditors.XtraForm
    {
        string _filePath;
        public frmImageViewer(string filePath)
        {
            InitializeComponent();
            _filePath = filePath;
        }
        List<string> images;
        int index=0;
        private void FrmImageViewer_Load(object sender, EventArgs e)
        {
            images=Directory.GetFiles(_filePath).ToList();
            picFrame.LoadAsync(images[index]);
            picFrame.Focus();
            TbarImageOperations.AllowSelectedItem = false;
            
        }

        private void TbtnNext_ItemClick(object sender, TileItemEventArgs e)
        {
            NextPicture();
        }

        private void TbtnPrevious_ItemClick(object sender, TileItemEventArgs e)
        {
            PrevPicture();
        }

        private void TbtnShowInFolder_ItemClick(object sender, TileItemEventArgs e)
        {
            Process.Start(_filePath);
        }
        void PrevPicture()
        {
            index = (index == 0) ? images.Count - 1 : index - 1;
            picFrame.LoadAsync(images[index]);
        }
        void NextPicture()
        {
            index = (index >= images.Count - 1) ? 0 : index + 1;
            picFrame.LoadAsync(images[index]);
        }
        private void TbarImageOperations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                PrevPicture();
            if (e.KeyCode == Keys.Right)
                NextPicture();
        }
       
        
    }
}