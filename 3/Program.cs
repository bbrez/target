float menorFaturamento(float[] dados)
{
  float menor = dados[0];
  for (int i = 1; i < dados.Length; i++)
  {
    if (dados[i] < menor)
    {
      menor = dados[i];
    }
  }

  return menor;
}

float maiorFaturamento(float[] dados)
{
  float maior = dados[0];
  for (int i = 1; i < dados.Length; i++)
  {
    if (dados[i] > maior)
    {
      maior = dados[i];
    }
  }

  return maior;
}

float mediaFaturamento(float[] dados)
{
  float soma = 0, qtd = 0;
  for (int i = 0; i < dados.Length; i++)
  {
    if (dados[i] != 0)
    {
      soma += dados[i];
      qtd += 1;
    }
  }

  return soma / qtd;
}

int numAcimaMediaFaturamento(float[] dados)
{
  float media = mediaFaturamento(dados);
  int cont = 0;
  for (int i = 0; i < dados.Length; i++)
  {
    if (dados[i] > media)
    {
      cont += 1;
    }
  }

  return cont;
}


float[] faturamento; //Assumir que está preenchido
Console.WriteLine("Menor Faturamento: " + menorFaturamento(faturamento));
Console.WriteLine("Maior Faturamento: " + maiorFaturamento(faturamento));
Console.WriteLine("Num. Dias > Media: " + numAcimaMediaFaturamento(faturamento));