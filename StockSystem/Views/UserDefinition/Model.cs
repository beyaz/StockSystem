using WhiteStone.Common;

namespace StockSystem.Views.UserDefinition
{
    public class Model : ContractBase
    {
        #region string Name
        string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        #endregion

        #region int CompanyId
        int? _companyId;

        public int? CompanyId
        {
            get { return _companyId; }
            set
            {
                if (_companyId != value)
                {
                    _companyId = value;
                    OnPropertyChanged("CompanyId");
                }
            }
        }
        #endregion

        #region string UserName
        string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        #endregion

        #region string Password
        string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        #endregion
    }
}