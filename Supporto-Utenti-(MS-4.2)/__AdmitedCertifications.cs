using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supporto_Utenti__MS_4._2_
{
    public class AdmitedCertification
    {
        #region Static CRUD
        private static HashSet<string> _admitedCertifications = new HashSet<string>()
        {
            "ISO22000",
            "BRC",
            "IFS",
            "BIO",
        };
        public static HashSet<string> All => _admitedCertifications.ToHashSet();
        public static bool Add(string c)
        {
            if (string.IsNullOrEmpty(c))
                throw new Exception("Certification can't be null or empty");
            return _admitedCertifications.Add(c.Trim().ToUpper());
        }
        public static bool Remove(string c)
        {
            return _admitedCertifications.Remove(c.Trim().ToUpper());
        }
        public static void Clear()
        {
            _admitedCertifications.Clear();
        }
        #endregion

        private 
    }

}
