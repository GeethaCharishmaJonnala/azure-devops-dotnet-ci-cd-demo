# Azure DevOps CI/CD Automation Pipeline Demo

---

## 📌 Overview

This is a full-stack **enterprise-style CI/CD project** demonstrating modern DevOps practices using:

- ASP.NET Core Web API (Backend)
- React.js (Frontend)
- Docker + Docker Compose (Containerization)
- Azure DevOps (CI/CD Pipeline)
- GitHub Actions (Backup CI/CD)

It simulates a real-world production deployment pipeline used in cloud engineering teams.

---

## 🏗️ Architecture

React Frontend
    ↓
ASP.NET Core Web API
    ↓
Docker Containers
    ↓
CI/CD Pipeline (Azure DevOps / GitHub Actions)
    ↓
Deployment (Azure App Service / Cloud)

---

## 🚀 Features

### 🔧 CI/CD Automation
- Multi-stage Azure DevOps pipeline
- Build → Test → Deploy workflow
- Triggered on every push to `main`

### 🐳 Docker Support
- Backend containerized (.NET API)
- Frontend containerized (React)
- Docker Compose for full system execution

### 🌐 Frontend (React)
- REST API integration using Axios
- Dashboard-style UI structure
- Runs on port 3000

### 🔙 Backend (.NET API)
- ASP.NET Core Web API
- RESTful endpoints
- Clean architecture structure
- Ready for cloud deployment

---

## 🧰 Tech Stack

### Backend
- ASP.NET Core Web API
- C#
- .NET 8
- REST APIs

### Frontend
- React.js
- JavaScript
- Axios

### DevOps
- Azure DevOps Pipelines
- GitHub Actions
- Docker
- Docker Compose

---

## 📁 Project Structure

azure-devops-dotnet-ci-cd-demo/
│
├── backend/
│   └── CiCdDemo.Api/
│       ├── Controllers/
│       ├── Program.cs
│       ├── Dockerfile
│
├── frontend/
│   ├── src/
│   ├── public/
│   ├── Dockerfile
│   └── package.json
│
├── docker-compose.yml
├── azure-pipelines.yml
└── README.md

---

## ▶️ How to Run Locally

### 1. Clone Repository

git clone https://github.com/GeethaCharishmaJonnala/azure-devops-dotnet-ci-cd-demo.git
cd azure-devops-dotnet-ci-cd-demo

---

### 2. Run using Docker Compose (Recommended)

docker compose up --build

---

### 3. Access Applications

Frontend:
http://localhost:3000

Backend API:
http://localhost:5000

---

## 🔌 API Endpoints

### Health Check
GET /api/health

### Sample Endpoint
GET /api/demo

---

## 🚀 CI/CD Pipeline (Azure DevOps)

### Stages

1. Build
2. Test
3. Deploy

### Trigger

- Automatic on push to `main`

---

## 🔁 GitHub Actions (Backup Pipeline)

Location:
.github/workflows/ci-cd.yml

### Features:
- Builds backend (.NET)
- Builds frontend (React)
- Runs on every push

---

## 🐳 Docker Setup

### Backend Dockerfile
backend/CiCdDemo.Api/Dockerfile

### Frontend Dockerfile
frontend/Dockerfile

### Run Full System
docker compose up --build

---

## ☁️ Deployment Targets

This project is ready for:

- Azure App Service
- Azure Container Apps
- Kubernetes (AKS)
- Docker Hub / Azure Container Registry

---

## 📌 Key Learnings

- CI/CD automation with Azure DevOps
- Full-stack containerization using Docker
- React + .NET integration
- Cloud deployment readiness
- DevOps pipeline design

---

## 📈 Resume Highlights

- Built CI/CD pipeline using Azure DevOps
- Containerized full-stack application using Docker
- Designed React + ASP.NET Core integration
- Automated build and deployment workflows
- Implemented production-ready DevOps architecture

---

## 👨‍💻 Author

Geetha Charishma Jonnala

---

## ⭐ Future Enhancements

- Kubernetes deployment (AKS)
- Terraform infrastructure automation
- Azure monitoring (Application Insights)
- JWT Authentication
- Production-grade logging system

---
