namespace StockSystem.Views.UserDefinition
{
    class ValidationResult
    {
        public bool FocusPassword { get; internal set; }
        public string WarningMessage { get; set; }
        public bool FocusUserName { get; set; }
        public bool IsValidationSuccess { get; set; }
    }

    class Controller
    {
        public Model Model { get; set; }

        public ValidationResult Result { get; } = new ValidationResult();

        public void Validate()
        {
            if (Model.CompanyId == null)
            {
                Result.WarningMessage = "Şirket bilgisi seçilmelidir.";
                return;
            }

            if (string.IsNullOrWhiteSpace(Model.Password))
            {
                Result.WarningMessage = "Şifre bilgisi girilmelidir.";
                Result.FocusPassword = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(Model.UserName))
            {
                Result.WarningMessage = "Kullanıcı Adı bilgisi girilmelidir.";
                Result.FocusUserName = true;
                return;
            }

            Result.IsValidationSuccess = true;
        }
    }
}