# 🌦️ Weather API with .NET 9 & Redis

A simple **Weather API** built with **.NET 9 Web API** that fetches weather data from a 3rd party provider (e.g., [Visual Crossing Weather API](https://www.visualcrossing.com/weather-api)) and uses **Redis caching** for performance.  

This project is made for Roadmap project - https://roadmap.sh/projects/weather-api-wrapper-service

This project is part of the **roadmap.sh community project** and focuses on:
- ✅ Working with **3rd party APIs**  
- ✅ Using **environment variables** for sensitive data  
- ✅ Implementing **Redis cache** with expiration  
- ✅ Error handling & clean API design  

---

## 🚀 Features
- Fetches **real-time weather data** from a 3rd party API  
- Uses **Redis** to cache responses (reducing API calls)  
- Stores secrets (API keys, Redis connection) in **environment variables**  
- Implements **cache expiration** (default: 12 hours)  
- Structured **.NET 9 Web API project**  

---

## 🛠️ Tech Stack
- **.NET 9 Web API**  
- **Redis** (via `StackExchange.Redis` & `Microsoft.Extensions.Caching.StackExchangeRedis`)  
- **3rd Party Weather API** (e.g., Visual Crossing)  
- **Docker** (optional, for Redis container)  

---

## ⚙️ Setup & Installation

### 1. Clone the Repo
```bash
git clone https://github.com/damonsahil26/Weather.git
cd weather
