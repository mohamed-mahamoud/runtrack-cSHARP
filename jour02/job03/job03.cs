class MerchantCart
{
    private int gold;
    public int Gold { get; private set; }

    public void AddGold(int montant)
    {
        Gold += montant;
    }

    public bool Payfee(int montant)
    {
        if (Gold >= montant)
        {
            Gold -= montant;
            return true;
        }
        else
        {
            Console.WriteLine("Vous n'avez pas assez d'or pour payer.");
            return false;
        }
    }
}
