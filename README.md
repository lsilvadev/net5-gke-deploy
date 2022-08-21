# CI / CD de aplicação .NET no Google Kubernetes Engine (GKE)

Este repositório contém uma API de teste e as pipelines usadas no CI (Continuous Integration).

As pipelines do CI são executadas através do GitHub Actions.

A estratégia de ramificação em uso é o Trunk-based Development. No <a href="https://medium.com/unicoidtech/trunk-based-development-vs-git-flow-390a2fdecc15">Trunk-based Development</a> os desenvolvedores concentram-se em fazer o trabalho na branch main (linha principal).

<img width="485" alt="image" src="https://user-images.githubusercontent.com/26820527/185773832-9dd9eb43-a94f-4646-9432-4d6987060e7b.png">

A pasta <a href="https://github.com/lsilvadev/net5-gke-deploy/tree/main/.github/workflows">.github/workflows/</a> contém três pipelines:
- `merge-main.yml`: tem o objetivo de validar o novo código candidato a produção e realizar deploy em ambiente de desenvolvimento (dev).
- `tag-main.yml`: responsável pelo versionamento da aplicação que será aplicada em ambiente de teste.
- `release-prerelease.yml`: tem o objetivo de lançar uma prerelease com base no nome da tag recebida.
