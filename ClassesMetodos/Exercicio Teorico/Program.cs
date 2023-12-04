//using System.Runtime.Intrinsics.X86;

//Exercícios
//1- O que é uma classe e qual a sua composição ?
/* Uma classe em c# e um modelo que permite a criacao de um objeto
    que carrega com si atributos e metodos derivados dessa clase*/

//2- O que é um objeto e como pode ser criado ?
/* Um objeto e uma instancia de uma classe que possibilita acessar seus metodos
   Em c#, uma classe pode ser criada usando a palavra new* 
  */

//3- Qual a diferença entre classe e objeto ?
/* Classe é o molde para a criação de um objeto e o objeto
 é a materializaçao da classe */

//4- O que é um método e como pode ser criado e chamado ?
/* Metodo e um bloco de codigo que contem instruções para ser inciadas.
 para a criacao de um metodo necessitamos de criar uma instacia de uma classe*/

//5- O que é um parâmetro de método ?
/* Parametro sao os argumentos que um metodo necessita para ser chamado e executado
 */

//6- O que é um argumento ?
/* argumentos sao os valores que o metodo ira receber para a sua inicializacao*/

//7- O que é um construtor e qual o seu objetivo ?
/* Um construtor e utilizado para definir parametros necessarios para a incialização de
 uma classe e, permite que no momento que a classe for incializada, seja atribuido valores
 dos menmbros de dados*/

//8- Quais os usos da palavra chave this ?
/* A palavra this faz referencia a instacia atual propria classe, sendo utilizada para 
 referenciar os atributos da classe*/

//9- O que é um método com retorno ?
/* Um retorno de um metodo e utilizado para definir qual o valor esperado que um metodo deve retornar
 seja ele um int, float, etc..*/

//10- O que é sobrecarga de método ?
/* A sobrecarga de metodos permite que seja criado um metodo com mesmo nome mas, com comportamentos diferentes
 e, para isso, necessita que as assinaturas dos metodos sejam distintas */


//11- Como é feita a passagem de parâmetros por valor ?
/* O metodo que tem um tipo de parametro por valor, ao ser executado, recebe uma copia do argumento. O valor
 original da variavel e alterado*/

//12- Como é feita a passagem de parâmetros por referência ?
/* O metodo que de define o parametro por referencia, ao ser executado, recebe o endereco de memoria
 da variavel, e o valor original da variavel nao e aletrado*/
//Exercícios

//13- Qual a diferença entre os parâmetros out e o parâmetro ref ?
/* Quando um argumento é passado como ref, ele deve ser inicializado antes de poder ser passado para o método. Um
parâmetro out, por outro lado, não precisa ser inicializado antes de passar para um método.*/

//14- O que são argumentos nomeados ?
/* argumentos nomeados sao utilizados para que voce nao precise "passar" o argumento na ordem definida na lista de
 parametros*/

//15- O que são parâmetros opcionais ?
/*Sao parametros que podem ser obtidos na chamada de um metodo, eles sao definidos sempre ao final de uma lista de
 parametros de um metodo */

//16- Qual o efeito da palavra-chave static ?
/* A palavra-chave static significa relativo ao próprio tipo, em vez de uma instância do tipo. Ao usar static podemos acessar
um membro estático usando o nome do tipo em vez de uma referência ou um valor. */

//17 - O que é método estático e qual o seu comportamento ?
/*Um metodo estatico e relativo ao tipo que foi definida e, nao precisa de que seja instaciando um objeto derivado do tipo
 para ser utilizado pois, pode ser chamado pelo proprio tipo*/

//18- O que é um campo estático e qual o seu comportamento ?
/* Assim como o metodo estatico, o campo estatico tambem faz referencia ao tipo e que sera mantido em todas as instancia do tipo
 e sera acesado pelo proprio tipo se possivel*/

//Exercícios
//19- O que são propriedades ?
/* As propriedades se comportam como campos quando são acessadas. No entanto, elas são implementadas com
acessadores(get e set) que definem as instruções executadas quando uma propriedade é acessada ou atribuída. As
propriedades permitem encapsular os atributos da classe */

//20- Qual a diferença entre campos e propriedades ?
/* As propriedades expõem os campos. Os campos devem (quase sempre) ser mantidos privados para uma classe e acessados 
por meio das propriedades get e set. As propriedades fornecem um nível de abstração que permite alterar os campos sem 
afetar a maneira externa como eles são acessados por quem for utilizar a classe. */

//21- O que é uma struct ?
/*Um tipo struct é um tipo de valor que pode encapsular dados e funcionalidades relacionadas possuindo praticamente o 
mesmo comportamento de uma classe*/

//22- Qual a diferença entre uma struct e uma classe ?
/*Uma struct é um tipo de valor e uma classe é um tipo de referência. Assim os objetos criados a partir de uma struct são 
alocados na Stack e os objetos da classe são alocados na Heap.*/

//23- O que é uma Enum ?
/* Um tipo de enumeração (ou tipo enum) é um tipo de valor definido por um conjunto de constantes nomeadas do tipo 
numérico integral subjacente */

//24- Quais são e qual o escopo dos modificadores de acesso ?
/* private - o nivel mais baixo de um escopo de acesso, permitindo apenas que a classe
acesse a varivael*/

/* public - escopo mais alto de acesso, pode ser acesso em qualquer local do codigo*/

/* internal - Quando uma propriedade ou método é definido como interno, ele só pode ser acessado a partir do 
assembly atual dessa classe.*/

/*Protected - Quando um usuário declara um método ou atributo como protegido, ele só pode ser acessado por 
membros dessa classe e por aqueles que a herdam.*/


////25- Qual a regra geral para usar os modificadores de acesso ?
/* Limitar a visibilidade de seus tipos e/ou membros restringindo-os a apenas a quem precisa realmente acessar o tipo 
ou membro. Quanto menos visibilidade houver, menor será a probabilidade de ocorrer uma alteração indesejada ou 
seja, menor será a chance de outras partes do sistema mudar quando você fizer uma atualização.*/