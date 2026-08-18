Calculadora Base =  new Calculadora();

Console.WriteLine("Digite o primeiro número: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine("Escolha a operação: 1 - Somar, 2 - Subtrair, 3 - Multiplicar, 4 - Dividir");
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
    default:
        Console.WriteLine("Operação inválida");
        break;
}
Console.WriteLine("Resultado: " + resultado);
    

