



public class Veiculo
{
    private int _id_identificacao;
    private string _niv;
    public string _placa;
    public string _n_motor;
    public string _renavam;
    public string _ano_modelo;
    public string _situacao;
    public string _cor;

    public Modelo _modelo;
    public Cidade _cidade;

    public void SetNiv(string niv)
      {
        if (niv.Length == 17) _niv = niv;
        else throw new Exception("NIV inválido");
    }

    public string GetNiv() {
        return _niv;
    }
}

