//using Microsoft.Reporting.WebForms;
//using Microsoft.Reporting.WebForms;

namespace GroupBProject.Business
{
    public class ReportType
    {
        #region Properties

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #endregion Properties

        #region Constructors

        public ReportType()
        {
        }

        #endregion Constructors

        #region Methods

        public override string ToString()
        {
            return this.Name;
        }

        #endregion Methods
    }
}