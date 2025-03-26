# Jogo da Forca
![](https://i.imgur.com/ClOi9lt.gif)

## Projeto
Um simples jogo da forca.

## Como Jogar
- Navegue pelos menus Inicial e Principal.
- Inicie uma partida ou antes selecione um tema nas Configurações.
- Será escolhido aleatoriamente uma palavra entre várias.
- Você deverá chutar uma letra por vez.
- Continue até acertar a palavra sorteada, ou esgotarem suas tentativas.

## Funcionalidades
- **Desenho da Forca:** Contém um desenho de uma forca, onde cada vez que o jogador errar a letra, será acrescentado parte de um personagem em Stick(palito).
- **Tema secreto aleatória:** Caso não seja selecionado um tema nas configurações, o jogo selecionará um tema aleatório.
- **Palavra secreta aleatória:** Todo início de partida, o jogo irá sortear uma palavra aleatória de acordo com o tema atual.
- **Visualização da palavra:** A palavra sorteada é formada e exibida na tela conforme o jogador acerta as letras.
- **Contagem de erros:** É mostrado ao jogador quantas vezes ele errou até o momento.

## Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
  
## Tecnologias
[![Tecnologias](https://skillicons.dev/icons?i=git,github,visualstudio,cs,dotnet)](https://skillicons.dev)

## Como utilizar
1. **Clone o Repositório**
```
git clone https://github.com/gsvsantos/JogoDaForca.git
```
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz do Jogo.
3. Utilize o comando abaixo para restaurar as dependências do projeto.
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
