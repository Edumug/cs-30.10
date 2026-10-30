// Console.Write("Digite um valor em reais: ");
// int valor = int.Parse(Console.ReadLine());

// if (valor < 0)
// {
//     Console.WriteLine("Valor inválido.");
// }
// else
// {
//     int[] cedulas = { 100, 50, 20, 10, 5, 2 };
//     int[] quantidade = new int[cedulas.Length];

//     for (int i = 0; i < cedulas.Length; i++)
//     {
//         quantidade[i] = valor / cedulas[i];
//         valor %= cedulas[i];
//     }

//     if (valor == 0)
//     {
//         Console.WriteLine("Cédulas necessárias:");
//         for (int i = 0; i < cedulas.Length; i++)
//         {
//             if (quantidade[i] > 0)
//             {
//                 Console.WriteLine($"R$ {cedulas[i]}: {quantidade[i]}");
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("Não foi possível formar o valor exato.");
//     }
// }
