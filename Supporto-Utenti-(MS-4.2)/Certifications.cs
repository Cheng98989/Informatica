using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supporto_Utenti__MS_4._2_
{
    public class Certifications
    {
        #region Instance CRUD
        private HashSet<string> _certifications = new HashSet<string>() { };
        public HashSet<string> All => _certifications.ToHashSet();
        public bool Add(string c)
        {
            if (string.IsNullOrEmpty(c))
                throw new Exception("Not admited certification");
            return _certifications.Add(_c);
        }
        public bool RemoveCertification(string c)
        {
            return _certifications.Remove(c);
        }
        public void ClearCertification()
        {
            _certifications.Clear();
        }
        #endregion
    }

}
