# 🛒 Sistema de Gestão de Produtos

Sistema desktop desenvolvido em **C# Windows Forms** com banco de dados **MySQL**, permitindo cadastro, consulta, edição e exclusão de produtos com suporte a imagens.

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte da disciplina de **Programação Comercial** do Prof. Pablo R. Gonçalves, com o objetivo de aplicar conceitos de:

- Conexão com banco de dados MySQL
- Formulários Windows Forms com múltiplos componentes
- Operações CRUD (Cadastrar, Consultar, Editar e Excluir)
- Mecanismo de busca por Nome, ID e Período de datas

---

## 🖥️ Telas do Sistema

### Cadastro de Produtos
- Cadastro de novos produtos com imagem
- Edição de produtos existentes
- Validação de campos obrigatórios
- Navegação para a tela de consulta

### Consulta de Produtos
- Busca por **Nome** (filtro parcial)
- Busca por **ID** do produto
- Busca por **Período** (entre duas datas)
- Exibição da imagem do produto selecionado
- Edição e exclusão direta da listagem

---

## 🧩 Componentes Utilizados

| Componente | Uso |
|---|---|
| `SplitContainer` | Divide a tela em painel de busca e painel de detalhes |
| `ComboBox` | Seleção do tipo de busca |
| `ListBox` | Lista de produtos encontrados |
| `PictureBox` | Exibição da imagem do produto |
| `DateTimePicker` | Seleção de período para filtro por data |
| `GroupBox` | Agrupamento dos controles |

---

## 🗃️ Banco de Dados

**SGBD:** MySQL

**Banco:** `Produtos`

> O script completo está disponível no arquivo `produtos.sql`

---

## 🛠️ Tecnologias

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

---
