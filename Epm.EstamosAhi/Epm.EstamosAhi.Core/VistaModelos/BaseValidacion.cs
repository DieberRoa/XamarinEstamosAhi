using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Core.VistaModelos
{
    public abstract class BaseValidacion : ViewModelBase
    {
        protected BaseValidacion()
        {
            ValidationErrors = new ErroresValidacion();
        }

        private ErroresValidacion validationErrors;

        public ErroresValidacion ValidationErrors
        {
            get
            {
                return validationErrors;
            }
            set
            {
                Set<ErroresValidacion>(ref validationErrors, value);
            }
        }

        public bool IsValid { get; private set; }

        public void Validate()
        {
            ValidationErrors.Clear();
            Autovalidarse();
            IsValid = ValidationErrors.IsValid;
            RaisePropertyChanged("IsValid");
            RaisePropertyChanged("ValidationErrors");
        }

        protected abstract void Autovalidarse();

    }
}
