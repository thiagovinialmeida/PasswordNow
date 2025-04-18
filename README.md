# PasswordNow
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
![Render](https://img.shields.io/badge/Render-%46E3B7.svg?style=for-the-badge&logo=render&logoColor=white)
## Descrição

<p style="text-align:justify">A PasswordNow é uma simples Api que cria rápidamente uma senha forte de várias formas para os seus projetos. Abrangendo senhas com letras maiusculas, minusculoas, números e simbulos, podendo gerar somente uma única senha ou uma lista com várias senhas diferentes.</p>

<p style="text-align:justify">O app foi desenvolvido utilizando Api minima com c#, buscando a simplicidade e velocidade.</p>

<p style="text-align:justify">A PassowordNow foi criada para ajudar na criação de senas rápidamente e sem burocracia, ao mesmo tempo que mantem a segurança.</p>

## Instrução de instalação

### Pré requisitos 

  - Net 8.0

### Etapas

```bash
git clone https://github.com/thiagovinialmeida/PasswordNow.git 
```
```bash
cd PasswordNow 
```

## Instrução de Uso

A APi está atualmente hospedada na Render e para acessar a mesma, basta efetuar uma requisição no seguinte IP passando o JSON:

[https://passwordnow.onrender.com/](https://passwordnow.onrender.com/)

```json
{
  "quantidade": 0,
  "comprimento": 30,
  "maiuscula": true,
  "minuscula": true,
  "numero": true,
  "simbulo": true
}
```

* Quantidade - Determina quantas vezes a senha será criada.
* Comprimento - Delimita o tamanho da senha, passando quantos caracteres ela terá.
* Maiuscula - Informa se a senha vai possuir letras maiusculas
    * (True = sim/False = não)
* Minuscula - Informa se a senha vai possuir letras minusculas
    * (True = sim/False = não)
* Número - Informa se a senha vai possuir números
    * (True = sim/False = não)
* Simbulo - Informa se a senha vai possuir simbulos
    * (True = sim/False = não)

## Licença
[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)
