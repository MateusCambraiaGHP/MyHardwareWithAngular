namespace MyHardware.ViewModel

{
    public class EmailViewModel
    {
        public string To { get; set; }
        public string Subject { get; set; } = "Token de acesso para o registro";
        public string Token { get; set; }
        public string NameClient { get; set; }
        public string Body { get { return GetBody(); } }

        #region -----------Private Methods-------------
        private string GetBody() {
            var bodyEmail = $"{NameClient}, o seu token de acesso é {Token}, acesse o site https://localhost:44384 e ao se registar, informe o Token.";
            return bodyEmail;
        }
        #endregion
    }
}