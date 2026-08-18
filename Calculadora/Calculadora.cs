class Calculadora{
        private string _nome { get; set; }

        public Calculadora(string nome)
        {
            _nome = nome;
        }
        public string FalarNome(){
            return _nome;
        }
        
        public float Somar(float n1, float n2){
            return n1+n2;
        }
        public float Subtrair(float n1, float n2){
            return n1-n2;
        }
        public float Multiplicar(float n1, float n2){
            return n1*n2;
        }
        public float Dividir(float n1, float n2){
            return n1/n2;
        }
}

class CalculadoraCientifica:Calculadora{
    private string _descricao { get; set; }

    public CalculadoraCientifica(string nome,string descricao):base(nome)
    {
        _descricao = descricao;
    }
    public string FalarDescricao(){
        return _descricao;
    }

    public float Potencia(float n1, float n2){
        return (float)Math.Pow(n1,n2);
    }
    public float Raiz(float n1){
        return (float)Math.Sqrt(n1);
    }
    public float Logaritmo(float n1){
        return (float)Math.Log10(n1);
    }
    public float Seno(float n1){
        return (float)Math.Sin(n1);
    }
    public float Cosseno(float n1){
        return (float)Math.Cos(n1);
    }
    public float Tangente(float n1){
        return (float)Math.Tan(n1);
    }

}