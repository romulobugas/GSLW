# 🔐 GSLW – Gerenciador de Secrets Local e Web

[![Release](https://img.shields.io/github/v/release/romulobugas/GSLW?style=flat-square)](https://github.com/romulobugas/GSLW/releases)
[![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?style=flat-square)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Mac%20%7C%20Linux%20%7C%20Android%20%7C%20iOS-success?style=flat-square)]()

---

## ✨ Sobre o Projeto

O **GSLW** é um cofre digital open source multiplataforma para **armazenamento seguro de secrets**, senhas, tokens, anotações e outros dados sensíveis, totalmente offline e local, com possibilidade de sincronização e backup seguro em nuvem no futuro.

### **Destaques do projeto:**

- **Armazenamento 100% criptografado**: Nenhum dado é salvo em claro, seja local ou exportado.
- **Cofre Local e API Local**: Toda manipulação de secrets é feita via app desktop (MAUI) e backend local (API .NET).
- **Exportação/Importação Segura**: Permite exportar ou importar secrets usando um QR Code protegido por senha e uma seed de 12 palavras (padrão BIP39, como carteiras BTC).
- **Zero Knowledge**: Apenas o usuário possui as chaves para descriptografar seus dados.
- **Design moderno**: Multiplataforma via .NET MAUI (Windows, Mac, Linux, Android, iOS).
- **Preparado para nuvem**: Planejado para permitir backup/sync com Google Drive ou outros serviços, mantendo a privacidade do usuário.
- **Documentação e código limpos**, boas práticas, testes, CI/CD e organização de tarefas por milestones/issues.

---

## 🚀 Funcionalidades (v1)

- Cadastro, leitura, atualização e remoção de secrets (senhas, tokens, notas, etc)
- Criptografia forte (AES-GCM, chaves locais)
- Exportação dos dados do cofre (individual ou total) em formato criptografado, protegido por senha + 12 palavras (seed)
- Geração de QR Code seguro para importação/exportação rápida e offline
- Importação usando QR Code + seed para restaurar ou migrar o cofre em outro dispositivo
- Interface desktop multiplataforma (MAUI)
- Integração com API local para controle do armazenamento e orquestração da criptografia

---

## 🔒 Segurança

- **Criptografia ponta-a-ponta**: Todos os dados são criptografados antes de sair do dispositivo.
- **Seed de 12 palavras**: O backup/exportação é protegido com uma seed semelhante às carteiras de criptomoedas (BIP39), facilitando recuperação e portabilidade.
- **Senha mestre**: Proteção adicional para acesso ao cofre e exportação/importação de dados.
- **Zero knowledge**: Nem mesmo os desenvolvedores ou possíveis serviços de nuvem terão acesso aos dados em claro.

---

## 🗂️ Estrutura do Projeto

/GSLW.sln # Solução principal .NET
/GSLW.Api/ # API local (ASP.NET Core WebAPI)
/GSLW.Desktop/ # App desktop multiplataforma (MAUI)
/GSLW.Core/ # Biblioteca de lógica, serviços, models, helpers


---

## ⚡ Como rodar localmente

> Requisitos: [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0), Visual Studio 2022+ ou VSCode

1. **Clone o repositório:**
   ```sh
   git clone https://github.com/romulobugas/GSLW.git
2. **Abra a solução no Visual Studio 2022+**
ou navegue até a pasta no terminal.

3. **Rode a API local:**

cd GSLW.Api
dotnet run

4. **Rode o app Desktop (MAUI):**

cd GSLW.Desktop
dotnet build
dotnet run

5. **Siga as instruções na interface para criar, importar ou exportar seus secrets.**

📅 Roadmap

 Estruturação do projeto e organização da base (core, api, desktop)

 CRUD seguro de secrets (criptografia local)

 Exportação/importação com QR Code e seed de 12 palavras

 Interface amigável para gerenciamento dos secrets

 Documentação completa e testes automatizados

 Integração futura com backup/sync seguro em nuvem (Google Drive, etc)

🤝 Contribua!
Pull requests, sugestões, discussões e issues são muito bem-vindos.
Veja as milestones e issues para saber por onde começar ou abrir novas ideias.

📜 Licença
Este projeto está sob a licença MIT.

Feito por romulobugas e colaboradores.
Orgulhosamente desenvolvido em .NET para o mundo!
