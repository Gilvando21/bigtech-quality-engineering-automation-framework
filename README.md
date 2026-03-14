
# BigTech Quality Engineering Automation Framework

Enterprise Quality Engineering Automation Framework designed to demonstrate scalable testing architecture used in fintech and high-scale technology environments.

![CI](https://github.com/Gilvando21/bigtech-quality-engineering-automation-framework/actions/workflows/tests.yml/badge.svg)
![GitHub Repo stars](https://img.shields.io/github/stars/Gilvando21/bigtech-quality-engineering-automation-framework?style=social)
![GitHub forks](https://img.shields.io/github/forks/Gilvando21/bigtech-quality-engineering-automation-framework?style=social)
![GitHub issues](https://img.shields.io/github/issues/Gilvando21/bigtech-quality-engineering-automation-framework)
![GitHub last commit](https://img.shields.io/github/last-commit/Gilvando21/bigtech-quality-engineering-automation-framework)
![GitHub language](https://img.shields.io/github/languages/top/Gilvando21/bigtech-quality-engineering-automation-framework)

This repository demonstrates how modern **Quality Engineering frameworks** can be structured using practices commonly found in fintech and large-scale technology companies.

---

# Tech Stack

- .NET 8
- NUnit
- Playwright
- RestSharp
- WireMock (Service Virtualization)
- PactNet (Contract Testing)
- k6 (Performance Testing)
- Docker (Test Environment)
- Grafana (Observability)
- GitHub Actions (CI/CD)
- Allure Reports

---

# Key Features

- API Automation
- UI Automation (Playwright)
- Screenshot & Video recording
- Service Virtualization
- Contract Testing
- Performance Testing
- CI/CD Ready
- Observability Metrics
- Parallel Test Execution
- Docker Test Environment

---

# Project Architecture

```
src
 ├── core
 ├── api
 ├── ui
 ├── fixtures
 ├── factories
 ├── contracts
 ├── observability
```

This architecture separates infrastructure, automation layers and observability components to support scalable automation frameworks.

---

# How to Run the Project

## Clone repository

```bash
git clone https://github.com/Gilvando21/bigtech-quality-engineering-automation-framework.git
cd bigtech-quality-engineering-automation-framework
```

## Install dependencies

Ensure installed:

- .NET 8 SDK
- Node.js
- Docker (optional)
- k6 (optional)
- Allure CLI

```bash
dotnet restore
```

## Build project

```bash
cd src
dotnet build
```

## Run automated tests

```bash
dotnet test
```

---

# Test Reports (Allure)

After running tests generate the report with:

```bash
cd ..
allure serve src/bin/Debug/net8.0/allure-results
```

---

# Performance Testing

```bash
k6 run performance/k6_simulacao_test.js
```

---

# Docker Test Environment

```bash
docker-compose up
```

Access Grafana:

http://localhost:3000

---

# Author

Gilvando Matos

Senior QA Engineer | QA Lead | Quality Engineering Specialist

LinkedIn  
https://www.linkedin.com/in/gilvando-matos-3a259821/

GitHub  
https://github.com/Gilvando21
