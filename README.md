# CloudLab Software Development Kit (SDK) para integração com API da Solides <!-- omit in toc -->
Este projeto representa o SDK que oferece as ferramentas para a integração com as [APIs da Solides](https://gestaoapidocs.solides.com.br/), que define um conjunto de integrações das funcionalidades existentes nos sistemas de sua plataforma.

[![CodeQL](https://github.com/cloudlabtech/SDK-Solides-API/actions/workflows/codeql.yml/badge.svg)](https://github.com/cloudlabtech/SDK-Solides-API/actions/workflows/codeql.yml)
![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/cloudlabtech/SDK-Solides-API?include_prereleases)

![GitHub tag (latest by date)](https://img.shields.io/github/v/tag/cloudlabtech/SDK-Solides-API)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/cloudlabtech/SDK-Solides-API)

- [O que é a Solides?](#o-que-é-a-solides)
- [O que é a API da Solides?](#o-que-é-a-api-da-solides)
- [O que são os *Webhooks* da Solides?](#o-que-são-os-webhooks-da-solides)
- [O que é o SDK para a API da Sólides?](#o-que-é-o-sdk-para-a-api-da-sólides)
- [Instalação](#instalação)
- [Compilação a partir do código](#compilação-a-partir-do-código)
- [Documentação do SDK](#documentação-do-sdk)
- [Features](#features)
- [Roadmap](#roadmap)
- [Como posso contribuir?](#como-posso-contribuir)
- [Bugs e Issues](#bugs-e-issues)
- [Licença de uso](#licença-de-uso)

## O que é a Solides?
*Extraído do [Blog da Solides](https://blog.solides.com.br/sobre-a-solides/)*

> A Sólides, maior HR Tech do Brasil, oferece em sua plataforma completa todas as soluções para os Recursos Humanos de pequenas, médias e grandes empresas. Tudo que o RH precisa em um só lugar – da atração à retenção de talentos.
> 
> O propósito é descomplicar a vida do RH e transformar as empresas por meio das pessoas, potencializando o capital humano de forma inovadora, com muita inteligência de dados. 
>
> Hoje, já são mais de 12 mil clientes e mais de 3 milhões de vidas impactadas pelas soluções da Sólides, que otimiza processos internos de RH, eleva a performance de equipes e revoluciona negócios. 
> 
> Através do [Sólides Profiler](https://blog.solides.com.br/tudo-sobre-profiler/) e Sólides Gestão é possível aumentar a produtividade, reduzir a rotatividade, melhorar o clima organizacional e muito mais.
>
> A metodologia elaborada por nossa startup une as principais teorias comportamentais — como o DISC — gerando uma aplicação mais rápida e um relatório mais completo. 
>
> A avaliação é testada e aprovada pela Universidade de São Paulo (USP) e pela Universidade Federal de Minas Gerais (UFMG), com resultados atingindo 97% de precisão.

Para mais informações, visite o [site da Solides](https://solides.com.br/)

## O que é a API da Solides?
A API Sólides é RESTful, e oferece um conjunto de funcionalidades de seus sistemas para ter uma boa integração junto com o sistema da sua empresa. A API de integração funciona em conjunto com as ferramentas do sistema Solides Gestão, oferecendo a criação, edição, atualização de registros importantes para sua empresa.

Com estas APIs é possível realizar integrações das informações de:
- Ocorrências
- Colaboradores
- Departamentos
- Passaportes
- Currículos
- Vagas
- Motivos de demissões
- Cargos
- Absenteísmos
- Profiler
- Questionários
- Avaliações avançadas
- Avaliações de desempenho
- CBOs
- Tipos de contrato

## O que são os *Webhooks* da Solides?
A Solides oferece um conjunto de ***webhooks*** onde é possível realizar a integração e sincronização de informações entre a Solides e sistemas externos através de eventos ocorridos com as informações nos sistemas da plataforma da Solides.

Os webhooks funcionam utilizando da ligação dos identificadores únicos das informações da Solides com os identificadores únicos dos sistemas de destino, sendo necessária apenas a configuração de duas chaves: *target_system* que define o sistema de destino da informação e o *externo_id* que identifica o identificador único do sistema de destino.

Com os webhooks é possível receber notificações quando alguns eventos acontecem dentro da plataforma da Solides, sendo eles:
- Cargos
- Colaboradores
- Currículos
- Departamentos
- Sucessão
- Unidades
- Vínculos externos
- Profiler
- Links genéricos

## O que é o SDK para a API da Sólides?
Com as funcionalidades existentes nas APIs e nos Webhooks, temos um ecossistema de integração a partir dos quais qualquer ferramenta, plataforma ou aplicação pode se beneficiar, seja consumindo os dados produzidos pela Solides ou fornecendo suas próprias informações para a Solides, a partir de origens de dados, plataforma e sistemas externos que estão sob o controle da empresa que consome estas integrações ou informações.

**Essa é a definição e responsabilidade do nosso SDK.**

O objetivo do SDK é fornecer ao desenvolvedor, um *pacote nuget* contendo todas as funcionalidades descritas nas APIs que possam ser consumidas e implementadas em suas aplicações.

Adicionalmente, fornecemos a implementação de uma API personalizada e customizável onde o desenvolvedor pode construir um gateway de entrada para o consumo das APIs da Solides, dando maior flexibilidade e controle destas chamadas e consumos de APIs em sua aplicação ou em seu ecossistema de aplicações.

As implementações foram realizadas em C#, e são compatíveis com as versões 6/7 e 8 do dotnet framework.

Os pacotes estão disponíveis no [Nuget.org](https://www.nuget.org/) e no [GitHub Packages](https://github.com/orgs/cloudlabtech/packages?repo_name=SDK-Solides-API).

## Instalação
TODO

## Compilação a partir do código
TODO

## Documentação do SDK
TODO

## Features
As seguintes funcionalidades estão mapeadas
| Funcionalidade | Categoria | Status | Issue # | Release |
|--------------- | --------- | ------ | ------- | ------- |
| Autenticação | Segurança | ![status][badge_doing] | [#2](https://github.com/cloudlabtech/SDK-Solides-API/issues/2) | N/A |

## Roadmap
As interações, datas e calendário da implementação das funcionalidades estão disponíveis em nosso [Roadmap](https://github.com/orgs/cloudlabtech/projects/1/views/5)

## Como posso contribuir?
TODO

## Bugs e Issues
TODO

## Licença de uso
Este projeto é open-source e licenciado sob a [MIT Licence](LICENSE).

[badge_backlog]: https://img.shields.io/badge/-Backlog-sucess
[badge_doing]: https://img.shields.io/badge/-Em%20desenvolvimento-sucess
[badge_done]: https://img.shields.io/badge/-Em%20desenvolvimento-sucess