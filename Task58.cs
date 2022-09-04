// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество строк первой матрицы:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбов превой матрицы:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбов второй матрицы:");
int n2 = Convert.ToInt32(Console.ReadLine());
int [,] GetMatrix(int M, int N) {
    int [,] matrix = new int [M, N];
    for (int i = 0; i < M; i++) {
        for (int j = 0; j < N; j++) {
           matrix[i, j] = new Random().Next(1, 10);
           Console.Write($"{matrix[i, j]} ");
     }
     Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
int[,] Matrix1 = GetMatrix(m1,n1);
int[,] Matrix2 = GetMatrix(m2,n2);
int[,] MatrixResult = new int [m1,n2];
if (n1 == m2){
    for (int i = 0; i < m1; i++){
        for (int j = 0; j < n2; j++) {
            int mult = 0;
            for (int z = 0; z < m2; z++){
                mult = mult + Matrix1[i,z] * Matrix2[z,j];
            }
            MatrixResult[i,j] = mult;
            Console.Write($"{MatrixResult[i,j]} ");
        }
        Console.WriteLine();
    }
}
else {
    Console.WriteLine("Перемножить матрицы невозможно! Количество столбов первой матрицы должно быть равно количеству строк второй матрицы!!!");
}