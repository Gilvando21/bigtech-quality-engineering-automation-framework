
# bigtech-quality-engineering-automation-framework

Enterprise QA Automation Framework inspired by engineering practices used in
Big Tech and Fintech companies (Nubank, Mercado Livre, etc).

## Stack

- .NET 8
- NUnit
- Playwright (UI Automation)
- RestSharp (API Automation)
- WireMock (Service Virtualization)
- SpecFlow ready (BDD)
- PactNet (Contract Testing ready)
- Allure Reports
- k6 Performance Testing
- Docker Test Environment
- Grafana Observability Dashboards
- Parallel Test Execution
- Screenshot + Video recording

## Architecture

src
 ├── core
 ├── api
 ├── ui
 ├── fixtures
 ├── factories
 ├── contracts
 ├── observability

## Run Tests

dotnet restore
dotnet build
dotnet test

## Run Performance Tests

k6 run performance/k6_simulacao_test.js

## Run Docker Environment

docker-compose up
