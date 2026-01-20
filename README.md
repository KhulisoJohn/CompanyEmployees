

<div align="center">

# 🏢 CompanyEmployee

### ⚙️ A Full-Stack Open-Source Project for Mastering Onion Architecture

**Built with .NET, Supabase, and React**

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)]()
[![Stack](https://img.shields.io/badge/stack-.NET%20%7C%20React%20%7C%20Supabase-orange.svg)]()

</div>

---

## 📌 Project Overview

**CompanyEmployee** is an **open-source full-stack application** designed specifically to **master clean architecture principles**, with a strong focus on **Onion Architecture** and real-world backend patterns.

This project is not built to chase features.
It is built to **chase correctness**.

The goal is to develop a **production-grade backend**, integrate it with a modern frontend, and maintain **strict architectural boundaries** throughout the system.

---

## 🎯 Purpose of the Project

This project exists to:

* Deeply understand **Onion Architecture**
* Apply **Domain-Driven Design (DDD)** concepts
* Build a clean, testable **ASP.NET Core Web API**
* Integrate a real database (**Supabase / PostgreSQL**)
* Build a modern **React frontend**
* Learn full-stack data flow end-to-end
* Avoid “tutorial hell” and shallow demos

This is a **learning-by-building** project, open to the community.

---

## 🧩 Problem This Project Addresses

Many developers:

* Learn architecture **theoretically**, not practically
* Copy clean architecture diagrams without understanding **why**
* Build CRUD apps with tight coupling
* Struggle with separation of concerns
* Never see Onion Architecture implemented fully in a real project

**CompanyEmployee** solves this by being:

* Opinionated
* Well-structured
* Incremental
* Transparent

Every decision is intentional.

---

## ✨ What the System Does

At its core, CompanyEmployee manages:

* Companies
* Employees
* Relationships between them

But the **real value** is *how* it does this:

* Clean domain models
* Repository pattern
* Service abstraction
* Dependency inversion
* DTO mapping
* Validation and error handling
* API-first design

The business logic lives **where it should live** — in the **Domain and Application layers**.

---

## 🏗️ Architecture (Onion Architecture)

```
┌─────────────────────────┐
│ 🎨 React Frontend       │
└────────────┬────────────┘
             │ REST API
             ▼
┌─────────────────────────────────────┐
│ 🚪 API Layer (ASP.NET Core)          │
│ • Controllers                        │
│ • DTOs                              │
│ • Middleware                        │
└────────────┬────────────────────────┘
             │
             ▼
┌─────────────────────────────────────┐
│ 🧠 Application Layer                 │
│ • Interfaces                        │
│ • Services                          │
│ • Business rules                    │
└────────────┬────────────────────────┘
             │
             ▼
┌─────────────────────────────────────┐
│ 🏛️ Domain Layer                      │
│ • Entities                          │
│ • Value Objects                     │
│ • Domain logic                      │
└────────────┬────────────────────────┘
             │
             ▼
┌─────────────────────────────────────┐
│ 🗄️ Infrastructure Layer             │
│ • Supabase (PostgreSQL)              │
│ • EF Core                           │
│ • Repository implementations        │
└─────────────────────────────────────┘
```

**Key rule:**
Dependencies always point **inward**.

---

## 🛠️ Technology Stack

### Backend

* **C#**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **Onion Architecture**
* **FluentValidation**
* **AutoMapper**
* **Supabase (PostgreSQL)**

### Frontend

* **React**
* **TypeScript**
* **Axios**
* **Modern component architecture**

### Tooling

* **Docker**
* **GitHub Actions**
* **Swagger / OpenAPI**
* **Postman**

---

## 📁 Project Structure

```
CompanyEmployee/
│
├── CompanyEmployee.Domain
│   ├── Entities
│   ├── Interfaces
│   └── Exceptions
│
├── CompanyEmployee.Application
│   ├── Interfaces
│   ├── Services
│   └── DTOs
│
├── CompanyEmployee.Infrastructure
│   ├── Persistence
│   ├── Repositories
│   └── Configurations
│
├── CompanyEmployee.API
│   ├── Controllers
│   ├── Middleware
│   └── Program.cs
│
└── CompanyEmployee.Client
    └── React Frontend
```

---

## 🔐 Core Engineering Principles

* Separation of concerns
* Dependency inversion
* Single responsibility
* Explicit boundaries
* Testability over convenience
* Clarity over cleverness

This project intentionally avoids shortcuts.

---

## 📈 Learning Outcomes

By building and studying this project, a developer will learn:

* How Onion Architecture works **in practice**
* How to structure real .NET solutions
* How backend and frontend communicate cleanly
* How to design maintainable APIs
* How to scale a codebase without chaos

This is **career-grade learning**, not a toy app.

---

## 🚀 Roadmap

* [ ] Authentication & authorization
* [ ] Role-based access control
* [ ] Pagination & filtering
* [ ] Domain events
* [ ] Unit & integration testing
* [ ] CI/CD pipeline
* [ ] Dockerized deployment

---

## 🌍 Open Source Philosophy

This project is:

* Open
* Educational
* Community-driven
* Improvement-focused

Contributions, discussions, and critiques are welcome.

---

## 👤 Author

**Khulyso John**
Software Developer | .NET & Full-Stack Engineering

This project reflects a deliberate journey toward **clean architecture mastery**.

---

## 📄 License

MIT License — free to use, learn from, and improve.

---

<div align="center">

### ⭐ Built to understand architecture, not just code.

**CompanyEmployee**
*Clean structure. Real learning. No shortcuts.*

</div>


