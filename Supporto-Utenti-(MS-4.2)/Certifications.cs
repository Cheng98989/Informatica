using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._2_
{
    //public enum Certifications
    //{
    //    ISO22000,
    //    BRC,
    //    IFS,
    //    BIO
    //}
    public class Certificates
    {
        private HashSet<string> _certificates = new HashSet<string>() { };
        public List<string> GetCertificates() => _certificates.ToList();
        public bool AddCertificate(string c) => _certificates.Add(c);
        public bool RemoveCertificate(string c) => _certificates.Remove(c);
        public void ClearCerticate(string c) => _certificates.Clear();
        public int Count() => _certificates.Count();
    }
}
