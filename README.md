# 👟 Cloud Strider — ASP.NET Core Sneaker Shop

**Cloud Strider** is a high-performance, brutalist-inspired e-commerce platform built with **ASP.NET Core 10**. It combines a raw, bold aesthetic with cutting-edge frontend interactions, specifically its signature 3D sneaker deconstruction scroll experience.

> [!NOTE]
> This project has recently undergone a comprehensive security audit and performance optimization pass to ensure 60fps interactivity and enterprise-grade protection.

---

## ✨ Signature Features

### 🧊 3D Sneaker Deconstruction
The centerpiece of the platform is a high-performance, scroll-based animation that "deconstructs" sneakers as the user moves down the page.
*   **RAM-Cached Frame Scrubbing**: To avoid the latency of video decoding, the engine fetches video assets into memory as Blobs and pre-extracts frames into an in-memory cache.
*   **60FPS Interactivity**: Uses `requestAnimationFrame` and Canvas-based rendering to ensure buttery-smooth scrubbing regardless of scroll speed.
*   **Three.js Integration**: Ambient particle systems provide depth and a premium "layered" feel to the background.
*   **GSAP Orchestration**: Complex multi-stage text overlays and camera transitions managed via GSAP ScrollTrigger.

### 🛡️ Hardened Security
Following a full-scale security audit, the application implements:
*   **Rate Limiting & Brute-Force Protection**: Mitigation against credential stuffing and automated attacks.
*   **XSS & CSRF Mitigation**: Secure handling of user inputs and request validation tokens.
*   **PCI-DSS Compliance Measures**: Standardized handling for payment data and session security.
*   **Security Service**: A secondary **Node.js/Express** microservice dedicated to specialized security logic and PostgreSQL-backed audit logging.
*   **Hardened Headers**: Strict Content Security Policy (CSP), HSTS, and X-Frame-Options enabled.

### 🎨 Brutalist UI/UX
Designed with a "Raw & Bold" philosophy:
*   **Modern Typography**: Oversized, high-contrast headings and monospaced accents.
*   **High-Contrast Palette**: Sharp Black, White, and Neon accents for a premium look.
*   **Hard-Edged Design**: Grid-based layouts with visible "raw" borders and minimal border-radius.
*   **Micro-Animations**: Subtle hover effects and interactive elements that make the interface feel "alive."

---

## 🛠️ Tech Stack

*   **Backend**: .NET 10 (ASP.NET Core MVC)
*   **Security Microservice**: Node.js / Express
*   **Databases**: 
    *   **MS SQL Server**: Primary store for products, orders, and identity.
    *   **PostgreSQL**: Secondary store for security logs and audit trails.
*   **ORM**: Entity Framework Core
*   **Frontend**: 
    *   **Engines**: Three.js (WebGL), GSAP (Animations), Canvas API.
    *   **UI Framework**: Bootstrap 5 (Customized for Brutalist theme).
    *   **Templating**: Razor Views (`.cshtml`).
*   **Authentication**: ASP.NET Core Identity + Google/Facebook OAuth 2.0.

---

## 📂 Project Structure

*   `/Controllers`: ASP.NET MVC Controllers.
*   `/server`: Source code for the Node.js Security Service.
*   `/wwwroot/js/deconstruct.js`: The core logic for the 3D scroll animation.
*   `/Data`: Database contexts and seeding logic.
*   `PROJECT_GUIDELINES.md`: Detailed coding standards and architecture documentation.

---

## 🚀 Performance Optimization

*   **Video Compression**: Source assets are pre-optimized for fast frame extraction without sacrificing visual fidelity.
*   **Non-Blocking Extraction**: Frame extraction happens in the background using `requestIdleCallback` to keep the UI responsive during initial load.
*   **Asset Lazy-Loading**: Only loads heavy 3D assets when the user reaches the interaction zones.

---

**Developed by Ilian Blagov**
