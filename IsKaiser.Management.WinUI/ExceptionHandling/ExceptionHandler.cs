using DevExpress.XtraEditors;
using FluentValidation;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.WinUI.ExceptionHandling
{
    public static class ExceptionHandler
    {
        public static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(ValidationException exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
            catch(Exception exception)
            {
                XtraMessageBox.Show("Bir Hata Oluştu");
            }
        }
    }
}
