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
        private readonly HashSet<string> _certifications = new HashSet<string>();
        public HashSet<string> All => _certifications.ToHashSet();
        public List<string> GetCertificates() => _certifications.ToList();
        public bool Add(string c)
        {
            if (string.IsNullOrEmpty(c))
                throw new Exception("Not admited certification");
            return _certifications.Add(c);
        }
        public bool AddCertificate(string c) => Add(c);
        public bool RemoveCertification(string c) => _certifications.Remove(c);
        public bool RemoveCertificate(string c) => RemoveCertification(c);
        public void ClearCertification() => _certifications.Clear();
        public void ClearCerticate(string c) => ClearCertification();
        public int Count() => _certifications.Count;
    }

    public class Certificates : Certifications
    {
    }
    }
}
