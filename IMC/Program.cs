    double peso, altura, imc;
    string sexo;

    Console.Write("Digite o peso (em kg): ");
    peso = double.Parse(Console.ReadLine());

    Console.Write("Digite a altura (em metros): ");
    altura = double.Parse(Console.ReadLine());

    Console.Write("Digite o sexo (M/F): ");
    sexo = Console.ReadLine().ToUpper();

    // calculando o IMC
    imc = peso / (altura * altura);

    // calculando o imc da pessoa
    string situacao;
if (sexo == "M")
{
    if (imc < 20.0)
    {
        situacao = "Abaixo do peso";
    }
    else if (imc < 25.0)
    {
        situacao = "Peso normal";
    }
    else if (imc < 30.0)
    {
        situacao = "Sobrepeso";
    }
    else
    {
        situacao = "Obesidade";
    }
}
else if (sexo == "F")
{
    if (imc < 18.5)
    {
        situacao = "Abaixo do peso";
    }
    else if (imc < 24.0)
    {
        situacao = "Peso normal";
    }
    else if (imc < 29.0)
    {
        situacao = "Sobrepeso";
    }
    else
    {
        situacao = "Obesidade";
    }
}
else
{
    situacao = "Sexo inválido";
}
    Console.WriteLine("O IMC é: {0}", imc);
    Console.WriteLine("Situação: {0}", situacao);