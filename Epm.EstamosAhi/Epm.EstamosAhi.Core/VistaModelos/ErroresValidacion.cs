using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epm.EstamosAhi.Core.VistaModelos
{
    public class ErroresValidacion : ViewModelBase
    {
        private readonly Dictionary<string, string> validationErrors = new Dictionary<string, string>();

        public bool IsValid
        {
            get
            {
                return validationErrors.Count < 1;
            }
        }

        public string this[string fieldName]
        {
            get
            {
                return validationErrors.ContainsKey(fieldName) ?
                    validationErrors[fieldName] : string.Empty;
            }

            set
            {
                if (validationErrors.ContainsKey(fieldName))
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        validationErrors.Remove(fieldName);
                    }
                    else
                    {
                        validationErrors[fieldName] = value;
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        validationErrors.Add(fieldName, value);
                    }
                }

                RaisePropertyChanged();
                RaisePropertyChanged("IsValid");
            }
        }

        public void Clear()
        {
            var keyList = new string[validationErrors.Count];
            validationErrors.Keys.CopyTo(keyList, 0);

            foreach (var key in keyList)
            {
                this[key] = string.Empty;
            }
        }
    }
}
