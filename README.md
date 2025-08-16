# Satisfy - EM DESENVOLVIMENTO

**Satisfy** é um projeto em C#/.NET que permite gerenciar feedbacks de usuários de forma simples e rápida, oferecendo endpoints para criar, consultar, atualizar e remover feedbacks.  

---

## ✨ Visão Geral

Satisfy permite que você:

- Crie feedbacks com nome, email, nota e comentário
- Consulte todos os feedbacks ou apenas por ID
- Atualize feedbacks existentes
- Remova feedbacks de forma segura
- Utilize uma API REST pronta para integração com front-end ou apps

---

<img width="1490" height="499" alt="{18CCE5B7-4325-4BD0-8E2B-A98CF64A3C9B}" src="https://github.com/user-attachments/assets/69c2a9f3-8ccd-4f40-9196-50e532e5cd32" />

---

## 📁 Tecnologias Utilizadas

| Tecnologia       | Função                                    |
|-----------------|-------------------------------------------|
| C# / .NET 9     | Linguagem e framework principal do projeto|
| ASP.NET Core     | Criação da API REST                       |
| [Futuro] EF Core | Futuro: persistência em banco de dados  |

---

## 🧑‍🎓 Público-Alvo
- Desenvolvedores que precisam de uma API de feedback simples  
- Projetos de avaliação de serviços ou produtos  
- Sistemas que desejam registrar e consultar opiniões de usuários  

---

## 📂 Estrutura do Projeto

```plaintext
APIFEEDBACK/
├─ Satisfy/
│  ├─ Controllers/
│  │  └─ FeedbackController.cs   # Endpoints da API
│  │
│  ├─ Models/
│  │  └─ Feedback.cs              # Modelo de Feedback
│  │
│  ├─ Data/                       # Futuro: DbContext e repositórios
│  │
│  ├─ Properties/
│  │  └─ launchSettings.json      # Configurações de debug
│  │
│  ├─ appsettings.json            # Configurações gerais
│  ├─ Program.cs                  # Inicialização da API
│  ├─ Satisfy.csproj              # Projeto .NET
│  └─ Satisfy.http                # Testes ou requisições HTTP
│
├─ ApiFeedback.sln                # Solução .NET
└─.gitignore                      # Gitignore

```
