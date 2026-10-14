using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoyoverse
{
    public class Worker
    {
        private string _id;
        public string Id => this._id;

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 200)
                    throw new Exception("Name can't be null or empty or longer than 200 characters");
                _name = value.ToLower();
            }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 200)
                    throw new Exception("Surname can't be null or empty or longer than 200 characters");
                _surname = value.ToLower();
            }
        }

        public enum Departents
        {
            GameDevelopment,
            GraphicsDesign,
            Marketing,
            Administration,
            TechnicalAssistance,
            Research,
        }

        public Departents Department;



        private DateTime _hireDate;

        public DateTime HireDate
        {
            get { return _hireDate; }
            set
            {
                var v = value.Date;
                if (v > DateTime.Now || v < new DateTime(2012, 1, 1))
                    throw new Exception("Hire date must be between 2012/01/01 and the current date");
                _hireDate = v;
            }
        }

        private decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    throw new Exception("Salary must be [0;∞)");
                _salary = value;
            }
        }
        #region Roles
        public enum Roles
        {
            // Development
            SeniorDeveloper,
            LeadDeveloper,
            GameplayProgrammer,
            QAEngineer,

            // Art & Design
            GameDesigner,
            LeadArtist,
            ConceptArtist,
            Animator,

            // Narrative & Audio
            GameWriter,
            SoundDesigner,

            // Marketing & Community
            MarketingSpecialist,
            MarketingManager,
            CommunityManager,

            // Management
            GameProducer,
            ProjectManager,
            ProductManager,

            // Business & Support
            LocalizationSpecialist,
            CustomerSupportSpecialist,
            HumanResourcesManager
        }
        #endregion
        private Dictionary<string, List<Roles>> _projects;
        public Dictionary<string, List<Roles>> GetProjects()
        {
            return _projects.ToDictionary(p => p.Key, p => p.Value);
        }
        public bool AddProject(string p_name, List<Roles> r)
        {
            if (_projects.ContainsKey(p_name))
                return false;
            _projects.Add(p_name, r);
            return true;
        }

        public bool RemoveProject(string p_name)
        {
            return _projects.Remove(p_name);
        }

        

    }
}
