// Aqui estou usando Concatenação e somando Strings e Variaveis

string hello = "Ola";
string nome = "Vinicius";
int idade = 30;

Console.WriteLine( "\n" + hello + " , " + nome + "!" +"  Voce tem atualmente: \n " + "\n" + idade + "Anos... \n" );  

// No Exemplo abaixo eu uso Interpolação de Strings, onde eu uso o $ e coloco as variaveis dentro de chaves {} para mostrar o resultado

Console.WriteLine( $"\n {hello} , {nome}! Voce tem atualmente: \n {idade} Anos... \n" );  