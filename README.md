# Gerenciador de Eventos

Este projeto em C# é um sistema de gerenciamento de eventos, permitindo a criação, remoção e registro de participantes em eventos do tipo Conferência ou Workshop. A interface foi desenvolvida em Windows Forms, proporcionando uma experiência de usuário intuitiva.

## Funcionalidades
- **Criação de Eventos:** Permite adicionar eventos com título, data e tipo (Conferência ou Workshop).
- **Remoção de Eventos:** Facilita a remoção de eventos previamente cadastrados.
- **Registro de Participantes:** Possibilita registrar e desregistrar participantes em eventos.
- **Listagem:** Exibe listas de eventos e de participantes associados a cada evento.

## Estrutura do Projeto
- `Conference.cs` e `Workshop.cs`: Definição das classes para os tipos de eventos.
- `ConferenceFactory.cs` e `WorkshopFactory.cs`: Factories para criação de instâncias dos eventos.
- `EventManager.cs`: Lógica central de gerenciamento de eventos.
- `IEvent.cs` e `IEventFactory.cs`: Interfaces para padronização das classes de eventos.
- `IEventObserver.cs`: Interface para implementação do padrão Observer.
- `Participante.cs`: Classe que representa os participantes dos eventos.
- `Form1.cs`: Interface gráfica principal.
- `Program.cs`: Ponto de entrada do programa.
