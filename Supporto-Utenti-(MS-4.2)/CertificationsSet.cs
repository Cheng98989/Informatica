using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supporto_Utenti__MS_4._2_
{
    public class CertificationsSet
    {
        private HashSet<string> _set = new HashSet<string>() { };
        public List<string> All => _set.ToList();
        public CertificationsSet(string[] certificazioni)
        {
            foreach(string c in certificazioni)
            {
                this.Add(c);
            }
        }
        public bool Add(string c)
        {
            var _c = c.Trim().ToUpper();
            if (string.IsNullOrEmpty(_c))
                throw new Exception("Not valid certification");
            return _set.Add(_c);
        }
        public bool Remove(string c) => _set.Remove(c);
        public void Clear() => _set.Clear();
        public override string ToString()
        {
            return string.Join(" - ", _set);
        }


    }
}
