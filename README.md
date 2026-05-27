Aplicativo de reservas de hotel desenvolvido em **.NET MAUI**, como atividade prática da **Agenda 13** do curso Técnico em Desenvolvimento de Sistemas.

Centro Paula Souza — ETEC — GEEaD 2026

---

## Telas do Aplicativo

### 1. Tela Principal — Reserva
Formulário completo de reserva com os seguintes campos:
- **Nome do Hóspede** — Entry de texto
- **Data de Check-in** — DatePicker (formato dd/MM/yyyy)
- **Data de Check-out** — DatePicker (formato dd/MM/yyyy)
- **Tipo de Quarto** — Picker com 4 opções
- **Número de Hóspedes** — Stepper (mínimo 1, máximo 6)

### 2. Tela de Confirmação
Exibe um resumo da reserva utilizando **BindingContext** para transferir os dados da tela principal, mostrando todos os detalhes incluindo o número de diárias calculado automaticamente.

### 3. Tela Sobre
Informações do aplicativo e do desenvolvedor:
- Tadeu Souza Santos
- Ano de desenvolvimento (2026)
- Tecnologias utilizadas (.NET MAUI, C# 12, XAML, .NET 8.0)

---


## Estrutura do projeto

```
MauiAppHotel/
├── MainPage.xaml           # Tela principal — formulário de reserva
├── MainPage.xaml.cs        # Lógica da tela principal
├── ConfirmacaoPage.xaml    # Tela de confirmação da reserva
├── ConfirmacaoPage.xaml.cs # Lógica com BindingContext
├── SobrePage.xaml          # Tela Sobre com info do desenvolvedor
├── SobrePage.xaml.cs       # Lógica da tela Sobre
├── Reserva.cs              # Modelo de dados da reserva
├── AppShell.xaml           # Shell com rotas de navegação
├── AppShell.xaml.cs        # Registro de rotas
└── README.md               # Este arquivo
```

---

## Tecnologias

| Tecnologia | Versão |
|---|---|
| .NET MAUI | .NET 8.0 |
| C# | 12 |
| XAML | — |
| Visual Studio | 2022 |



---

## Autor

Desenvolvido por Tadeu Souza Santos, aluno do curso Técnico em Desenvolvimento de Sistemas — ETEC  
Baseado no material da **Agenda 13** de autoria de **Tiago Antonio da Silva** e **Kelly Cristiane de Oliveira Dal Pozzo**

