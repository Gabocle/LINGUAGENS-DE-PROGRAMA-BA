using System;

class Program {
  //Designei as varáveis como valores inteiros
  int rolagemD20;
  int rolagemAnterior;
  int rolagemSomada;
  
//Criei um objeto da classe 'número aleatório'
  Random rolagem = new Random();
  
  public static void Main(){
    //Criei o objeto  que vai executar o Programa
    Program programa = new Program();
      
    Console.WriteLine("Bem vindo a BOLA FORA, para ganhar você deve acertar qual número será rolado no nosso D20 do destino. Não se preocupe de errar, você pode tentar de novo, mas terá que adivinhar a SOMA da nova rolagem com a anterior.");
    
    programa.Começar();
  }
  
  public void Começar(){
    //Atribuiu um valor inicial para cara variável
    rolagemD20 = 0;
    rolagemAnterior = 0;
    rolagemSomada = 0; 

    Sorteios();
  }
   
  public void Sorteios(){
//transforma o aletório em int
    int rnd = rolagem.Next(1,21);
//atribuindo o valor aleatório na variável estabelecida na classe
    rolagemD20 = rnd;
      //Ativar para verificar o valor sorteado \/
  //Console.WriteLine("Resultado do dado: " + rolagemD20);
    SomandoRolagens();
  }
  
  public void SomandoRolagens(){
      rolagemSomada = rolagemAnterior + rolagemD20;
     //Ativar para verificar o valor somado \/
    //Console.WriteLine("Resultado somado: " + rolagemSomada);
    InputJogador();
    }

  public void InputJogador(){
    //Solicita o Input do Jogador, transforma esse input de String para int (Lógica de Entrada)
    Console.Write("QUAL O SEU PALPITE? - ");
    string PalpiteSTRJogador = Console.ReadLine();
    int PalpiteJogador = Convert.ToInt32(PalpiteSTRJogador);
    //Faz a comparação entre o input do jogador e o resultado do sorteio (Lógica de Validação)
    if (PalpiteJogador == rolagemSomada){//condição para vitória (lógica de negócio)
      Console.WriteLine("Você é o Mago do Destino?? Uma chance de uma em 20, 5% de acertar e VOCÊ CONSEGUIU!!");
      DesligarJogo();
    } else {//condição para derrota
      if(rolagemSomada >= 100){
        Console.WriteLine("Os dados Explodiram e Você Perdeuuu");
        DesligarJogo();
        return;
      }
      Console.WriteLine("O destino é implacável e você fracassou. Agora tente adivinhar o valor SOMADO de todos os dados...");
      rolagemAnterior = rolagemSomada;
      Console.WriteLine("Rolagem Anterior: " + rolagemAnterior);
      Sorteios();
    }
        
  }
  public void DesligarJogo(){
    Environment.Exit(0);
  }
}