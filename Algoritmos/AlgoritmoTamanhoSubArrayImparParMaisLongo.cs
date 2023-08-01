namespace EncontrarTamanhoSubArrayImparParMaisLongo.App.Algoritmos
{
    public static class AlgoritmoTamanhoSubArrayImparParMaisLongo
    {
        public static int EncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeQuadraticaDeTempo(int[] a, int n)
        {
            int tamanho = 1;
            for (int i = 0; i < n; i++) 
            {
                int contador = 1;
                for (int j = i + 1; j < n; j++) 
                {
                    if ((a[j-1] % 2 == 0 && a[j] % 2 != 0) || (a[j-1] % 2 != 0 && a[j] % 2 == 0))
                    {
                        contador++;
                    }
                    else
                    {
                        break;
                    }
                }
                tamanho = contador > tamanho ? contador : tamanho;
            }
            if (tamanho == 1)
            {
                return 0;
            }
            return tamanho;
        }

        public static int EncontrarTamanhoSubArrayImparParMaisLongoEmComplexidadeLinearDeTempo(int[] a, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            int maiorTamanho = 0;
            int tamanhoAtual = 1;
            for (int i = 1; i < n; i++)
            {
                if (a[i] % 2 != a[i-1] % 2)
                {
                    tamanhoAtual++;
                }
                else
                {
                    maiorTamanho = tamanhoAtual > maiorTamanho ? tamanhoAtual : maiorTamanho;
                    tamanhoAtual = 1;
                }
            }
            return maiorTamanho == 1 ? 0 : maiorTamanho;
        }
    }
}