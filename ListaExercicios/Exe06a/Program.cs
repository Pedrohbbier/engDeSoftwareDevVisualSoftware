int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = random.Next(1000);

    for (int e = 0; e < vetor.Length; e++)
    { //evitar numeros iguais
        if (vetor[i] == vetor[e] && i != e)
        {
            vetor[i] = random.Next(1000);
            e = 0;
        }
    }

}

bool troca = false;

do{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
            if (vetor[i] > vetor[i + 1])
            {
                troca = true;
                int aux = vetor[i];
                vetor[i] = vetor[i + 1];
                vetor[i + 1] = aux;
            }
    }

} while (troca);


Console.WriteLine(string.Join(", ", vetor));