# Simulador de Scan para CLP Schneider M221
Este código em C# realiza um scan para verificar se o simulador do CLP Schneider M221 está em execução. O objetivo é estabelecer uma conexão TCP/IP com o simulador e verificar se a conexão é bem-sucedida.

## Funcionalidade
O código contém as seguintes funcionalidades:

Estabelece uma conexão TCP/IP com o simulador do CLP Schneider M221 usando um endereço IP e uma porta específicos.
Verifica se a conexão foi estabelecida com sucesso.
Exibe a mensagem "Simulador em execução" se o scan detectar que o simulador está em execução.
Exibe a mensagem "Nada encontrado" se o scan não conseguir estabelecer a conexão com o simulador.

## Uso
Crie um projeto no EcoStruxure Machine Expert - Basic.
Edite o programa e ative o modo simulação.
Abra o código em um editor de texto ou uma IDE que suporte C#.
Certifique-se de ter as configurações corretas para o endereço IP e a porta do simulador do CLP Schneider M221.
Execute o código.
Verifique a saída no console para determinar se o simulador está em execução ou não.

## Requisitos
.NET Framework ou .NET Core instalado.
Configurações corretas do endereço IP e da porta do simulador do CLP Schneider M221.

## Observações
Este código apenas realiza uma tentativa de conexão com o simulador do CLP Schneider M221 e não verifica a funcionalidade completa do CLP.
