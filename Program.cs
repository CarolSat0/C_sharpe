int qntdNotas;
double notas = 0, media;

Console.WriteLine("*-----------------------------------------------------------------*");
Console.WriteLine("                         SISTEMA DE NOTAS");
Console.WriteLine("Digite a quantidade de notas deste trimeste:");
qntdNotas = int.Parse(Console.ReadLine());
Console.WriteLine("                    ***** INSERINDO NOTAS *****");
for(int x = 0; x<qntdNotas; x++){
    Console.WriteLine("Digite a " + (x+1) + "ª nota do aluno:");
    double notaInserida = int.Parse(Console.ReadLine());
    
    notas = notas + notaInserida;
}

media = notas/qntdNotas;

Console.WriteLine("                    ***** MÉDIA DO ALUNO *****");
Console.WriteLine("Média do alino: " + media);



Console.WriteLine("*-----------------------------------------------------------------*");