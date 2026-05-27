# DonationsRivera
📌 Project Overview

DonationsRivera es una aplicación web orientada a la gestión de donaciones online utilizando una arquitectura moderna basada en Blazor Interactive Server y ASP.NET Core Identity.

La aplicación permite que los usuarios:

Registren cuentas y autentiquen sesión.
Realicen donaciones utilizando Stripe Checkout.
Sean redirigidos a la pasarela oficial de pagos de Stripe.
Registren automáticamente sus donaciones en SQL Server.
Actualicen el estado de las donaciones mediante Webhooks de Stripe.
🧰 Technology Stack
Visual Studio 2026
.NET 10
C# 14
Blazor Web App (Unified Template)
Interactive Server Render Mode
ASP.NET Core Identity
Entity Framework Core
SQL Server LocalDB
Stripe.net SDK
Stripe CLI
Git
GitHub
🏗️ Project Architecture

El proyecto utiliza la plantilla unificada de Blazor Web App con renderizado interactivo del lado del servidor.

Características principales:

Single project structure
Interactive Server rendering
ASP.NET Core Identity integrado
Entity Framework Core con SQL Server
Stripe Checkout Integration
Stripe Webhooks
Persistencia de pagos y estados de donación
🔐 Authentication & Authorization

La autenticación y autorización se manejan mediante:

ASP.NET Core Identity
Individual Accounts
SQL Server Database
AuthenticationStateProvider
Identity Cookies

Los usuarios deben iniciar sesión para acceder a la página de donaciones.

💳 Stripe Integration

El sistema utiliza Stripe Checkout para procesar pagos de prueba y pagos reales.

Implementaciones realizadas:

Stripe Checkout Sessions
Stripe.net SDK
Stripe CLI
Webhooks
Validación de firma Webhook
Actualización automática de pagos

Las claves privadas se almacenan utilizando User Secrets para evitar exponer información sensible en GitHub.

🗄️ Database Structure

La base de datos incluye las tablas de Identity y la tabla personalizada:

Donations

Campos principales:

Id
UserId
Amount
Currency
Status
StripeSessionId
CreatedAt

Estados utilizados:

Pending
Completed
📄 Main Features
Registro y Login de usuarios
Página de donaciones interactiva
Stripe Checkout
Páginas Success y Cancel
Registro histórico de donaciones
Actualización automática mediante Webhooks
Persistencia en SQL Server
