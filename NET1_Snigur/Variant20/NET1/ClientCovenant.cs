namespace NET1_Snigur.Variant20.NET1
{
    class ClientCovenant
    {
        public int ClientId { get; set; }
        public int CovenantId { get; set; }

        public ClientCovenant(int clientId, int covenantId)
        {
            this.ClientId = clientId;
            this.CovenantId = covenantId;
        }
    }
}
