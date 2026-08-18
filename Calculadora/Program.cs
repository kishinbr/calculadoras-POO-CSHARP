CalculadoraCientifica Base =  new CalculadoraCientifica("Calculadora", "Científica");

Console.WriteLine(Base.FalarNome());
Console.WriteLine(Base.FalarDescricao());

Console.WriteLine("Digite o primeiro número: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine("Escolha a operação: 1 - Somar, 2 - Subtrair, 3 - Multiplicar, 4 - Dividir, 5 - Potência, 6 - Raiz Quadrada, 7 - Logaritmo, 8 - Seno, 9 - Cosseno, 10 - Tangente");
int operacao = int.Parse(Console.ReadLine());
float resultado = 0f;

switch(operacao){
    case 1:
        resultado = Base.Somar(n1,n2);
        break;
    case 2:
        resultado = Base.Subtrair(n1,n2);
        break;
    case 3:
        resultado = Base.Multiplicar(n1,n2);
        break;
    case 4:
        if(n2 == 0){
            Console.WriteLine("Não é possível dividir por zero.");
        } else {
            resultado = Base.Dividir(n1,n2);
        }
        break;
    case 5:
        resultado = Base.Potencia(n1,n2);
        break;
    case 6:
        resultado = Base.Raiz(n1);
        break;
    case 7:
        resultado = Base.Logaritmo(n1);
        break;
    case 8:
        resultado = Base.Seno(n1);
        break;
    case 9:
        resultado = Base.Cosseno(n1);
        break;
    case 10:
        resultado = Base.Tangente(n1);
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}
Console.WriteLine("Resultado: " + resultado);
    

