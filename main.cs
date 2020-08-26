using System;

// 1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
//deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
//caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
//será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.

class MainClass {
  public static void Main (string[] args) {

    int cod, quant;
    string produto;
    float val_un, val_tot;

    Console.WriteLine("================================");
    Console.WriteLine("           CARDÁPIO");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Cód -    Descrição    - Valor(UN)");
    Console.WriteLine("100 - Cachorro Quente - R$ 1,70");
    Console.WriteLine("101 - Bauru Simples   - R$ 2,30");
    Console.WriteLine("102 - Bauru com Ovo   - R$ 2,60");
    Console.WriteLine("103 - Hamburguer      - R$ 2,40");
    Console.WriteLine("104 - Cheeseburguer   - R$ 2,50");
    Console.WriteLine("105 - Refrigerante    - R$ 1,00");
    Console.WriteLine("================================");

    Console.WriteLine("Informe o código do produto: ");
    cod = int.Parse (Console.ReadLine());

    Console.WriteLine("Informe a quantidade: ");
    quant = int.Parse (Console.ReadLine());

    if (cod == 100){
      Console.WriteLine("Valor Total: R$ {0}", 1.70*quant);
    }
    else if (cod == 101){
      Console.WriteLine("Valor Total: R$ {0}", 2.30*quant);
    }
    else if (cod == 102){
      Console.WriteLine("Valor Total: R$ {0}", 2.60*quant);
    }
    else if (cod == 103){
      Console.WriteLine("Valor Total: R$ {0}", 2.40*quant);
    }
    else if (cod == 104){
      Console.WriteLine("Valor Total: R$ {0}", 2.50*quant);
    }
    else if (cod == 105){
      Console.WriteLine("Valor Total: R$ {0}", 1.00*quant);
    }
    else{
      Console.WriteLine("Código Inválido. Digite um código válido: ");
    }
  }
}