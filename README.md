# Jogo da Forca
![](https://i.imgur.com/kyySj8G.gif)

## Projeto
Um jogo da forca sobre frutas.

## Como Jogar
- Será escolhido aleatoriamente uma palavra entre várias.
- Você deverá chutar uma letra por vez.
- Continue até acertar a palavra sorteada, ou acabar suas tentativas.

## Funcionalidades
- **Desenho da Forca:** Contém um desenho de uma forca, onde será acrescentado partes de um personagem em Stick em cada vez que o jogador errar a letra.
- **Palavra secreta aleatória:** Todo inicio de partida, o jogo irá escolher uma palavra aleatória.
- **Visualização da palavra:** A palavra sorteada é escrita e deixada a mostra na tela conforme o jogador acerta as letras.
- **Contagem de erros:** É mostrado ao jogador quantas vezes ele errou até o momento.

## Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como utilizar
1. **Clone o Repositório**
```
git clone https://github.com/gsvsantos/JogoDaForca.git
```
2. Abra o terminal ou promp de comando e navegue até a pasta raiz do Jogo.
3. Utilize o comando abaixo para restaurar as depencências do projeto.
```
dotnet restore
```
4. Compile e execute o arquivo *.exe* do jogo.
```
dotnet build --configuration Release
```
```
JogoDaForca.ConsoleApp.exe
```
### Opcional
- Executar o projeto compilando em tempo real
```
dotnet run --project JogoDaForca.ConsoleApp
```

# Sobre o Projeto
Este projeto foi desenvolvido como parte de uma atividade da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).
