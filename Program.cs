int qntdNotas, qntdAluno = 1;
double notas = 0, media, notaInserida;
bool retorno = false, retornoResp = true, RespForma = true, formaInserida = true;
string resposta, formaNota;

Console.WriteLine("*-----------------------------------------------------------------*");
Console.WriteLine("                         SISTEMA DE NOTAS");

do{

    Console.WriteLine("As notas vão ser de qual forma?");
    Console.WriteLine("1 - 1 a 10");
    Console.WriteLine("2 - 10 a 100");
    Console.WriteLine("Responda 1 ou 2:");
    formaNota = Console.ReadLine();

    if(formaNota != "1" && formaNota != "2"){
        Console.WriteLine("");
        Console.WriteLine("**RESPOSTA INVALIDA! Digite outra vez**");
        Console.WriteLine("");
        RespForma = false;
    }else{
        RespForma = true;
    }

}while(RespForma != true);

do{

    Console.WriteLine("*-----------------------------------------------------------------*");

    Console.WriteLine("                       ***** ALUNO " + qntdAluno + " *****");
    Console.WriteLine("Digite a quantidade de notas deste trimeste:");
    qntdNotas = Convert.ToInt32(Console.ReadLine());

    if(qntdNotas == 1){
        Console.WriteLine("Não a média de uma única nota!");
    }else{
        Console.WriteLine("                    ***** INSERINDO NOTAS *****");
        for(int x = 0; x<qntdNotas; x++){
            if(formaNota == "1"){
                do{
                    Console.WriteLine("Digite a " + (x+1) + "ª nota do aluno:");
                    notaInserida = Convert.ToInt32(Console.ReadLine());

                    if(notaInserida > 10 && notaInserida != 0){
                        Console.WriteLine("");
                        Console.WriteLine("Forma de inserção errada! Digite a nota outra vez [1 a 10]");
                        Console.WriteLine("");
                        formaInserida = false;
                    }else{
                        formaInserida = true;
                    }
                }while(formaInserida != true);
            }else{
                do{
                    Console.WriteLine("Digite a " + (x+1) + "ª nota do aluno:");
                    notaInserida = Convert.ToInt32(Console.ReadLine());

                    if(notaInserida < 10 && notaInserida != 0){
                        Console.WriteLine("");
                        Console.WriteLine("Forma de inserção errada! Digite a nota outra vez [10 a 100]");
                        Console.WriteLine("");
                        formaInserida = false;
                    }else{
                        formaInserida = true;
                    }
                }while(formaInserida != true);
            }


            notas = notas + notaInserida;
        }

        media = notas/qntdNotas;

        Console.WriteLine("                    ***** MÉDIA DO ALUNO *****");
        Console.WriteLine("Média do alino: " + media);
        Console.WriteLine("");

        Console.WriteLine("                    ***** STATUS DO ALUNO *****");
        switch(formaNota){
            case "1":
                if (media >= 6){
                    Console.WriteLine("Aluno APROVADO!");
                }else{
                    Console.WriteLine("Aluno está de RECUPERAÇÃO");
                }
            break;
            case "2":
                if(media >= 60){
                    Console.WriteLine("Aluno APROVADO!");
                }else{
                    Console.WriteLine("Aluno está de RECUPERAÇÃO");
                }
            break;
        }
    }
    Console.WriteLine("                    ***** --------------- *****");
    do{
        Console.WriteLine("Deseja continuar inserindo as notas dos alunos? [S/N]");
        resposta = Console.ReadLine();

        if(resposta != "S" && resposta != "s" && resposta != "N" && resposta != "n"){
            Console.WriteLine("");
            Console.WriteLine("**RESPOSTA INVALIDA! Digite outra vez [S/N]**");
            Console.WriteLine("");
            retornoResp = false;
        }else{
            retornoResp = true;
        }
        }while(retornoResp != true);

        if(resposta == "S" || resposta == "s"){
            retorno = true;
        }else{
            retorno = false;
        }

        qntdAluno = (qntdAluno+1);
        notas = 0;

}while(retorno != false);

Console.WriteLine("                    ***** --------------- *****");
Console.WriteLine("O sistema irá fechar!");
Console.WriteLine("Até mais!!");

Console.WriteLine("*-----------------------------------------------------------------*");