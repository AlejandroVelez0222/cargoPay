# CargoPay Authorization System

## 📌 Descripción del Proyecto
Este proyecto es una API RESTful desarrollada en **C# y .NET 8** para gestionar tarjetas y aplicar tarifas de pago de manera segura y eficiente. La API permite:
- Crear.
- Realizar pagos y actualizar saldos.
- Calcular tarifas de pago con un servicio aleatorio simulado.
- Implementar autenticación segura mediante **JWT**.
- Optimizar el rendimiento con **multithreading**.
- Asegurar recursos compartidos con **patrones de diseño**.

## 📂 Estructura del Proyecto
```
CargoPayAuth/
│── API/
│   ├── Controllers/         # Controladores de la API
│   ├── CQRS/ 
│   ├── LoginFake/         # Prueba de JWT
│── Domain/
│   ├── Models/            # Modelos de datos
│   ├── Enums/             # Enums de Errores
│── Application/
│   ├── Handlers/            # Manejadores CQRS
│   ├── Services/            # Objetos de transferencia de datos
│   ├── Auth/            # Configuración de JWT y autenticación
│   ├── DTOs/            # Objetos de transferencia de datosv
│   ├── Exceptions/            # Exceptions personalizadas
│   ├── Querys/            # Modelos de Querys y Response
│── Infrastructure/
│   ├── UEF/                # servicio aleatorio simulado
│── Program.cs               # Punto de entrada de la aplicación
│── appsettings.json         # Configuración de variables
│── README.md                # Documentación
│── CargoPay API.postman_collection               # Postman
```

## 🚀 Tecnologías Utilizadas
- **.NET 8**
- **C#**
- **JWT (JSON Web Token)**
- **CQRS con Mediator**
- **Multithreading**

## 📦 Instalación y Configuración
### 1️⃣ Clonar el repositorio
```bash
git clone https://github.com/AlejandroVelez0222/cargoPay.git
cd CargoPayAuth
```

### 2️⃣ Configurar Dependencias
```bash
dotnet restore
```

### 3️⃣ Configurar Variables de Entorno
Modificar `appsettings.json` con:
```json
"Jwt": {
  "SecretKey": "TU_CLAVE_SECRETA",
  "Issuer": "tu-api",
  "Audience": "tu-api-client"
}
```

### 4️⃣ Ejecutar el Proyecto
```bash
dotnet run
```

## 🛠️ Endpoints Principales
### 1️⃣ **Módulo de Gestión de Tarjetas**
| Método  | Endpoint | Descripción |
|----------|----------|-------------|
| `POST`   | `/api/v1/create` | Crear una nueva tarjeta |
| `POST`   | `/api/v1/pay` | Realizar un pago con tarjeta |
| `GET`    | `/api/v1/balanceCard?Request.CardNumber={cardNumber}` | Obtener el saldo de una tarjeta |

### 2️⃣ **Módulo de Tarifas de Pago**
| Método  | Endpoint | Descripción |
|----------|----------|-------------|
| `GET`   | `/api/v1/fees` | Obtener la tarifa actual |

###  **Módulo de LoginFake**
| Método  | Endpoint | Descripción |
|----------|----------|-------------|
| `GET`   | `/api/v1/auth/login` | simulado de login para Obtener el token de JWT|

## 🔐 Autenticación con JWT
Para acceder a los endpoints protegidos, se requiere un token JWT.
1. Obtener un token (**Ejemplo con Postman**):
```json
{
  "username": "admin",
  "password": "123456"
}
```
2. Incluir el token en la cabecera de las peticiones:
```http
Authorization: Bearer TU_TOKEN_AQUI
```

## 🏆 Bonus Implementado
✅ **Autenticación segura con JWT**
✅ **Optimización de rendimiento con multithreading**
✅ **Manejo seguro de recursos compartidos con patrones de diseño**

📈 Posibles Mejoras

Por razones de tiempo, no se lograron implementar algunas mejoras adicionales que podrían optimizar y escalar la aplicación:

⚡ Persistencia de datos: Migrar de almacenamiento en memoria a una base de datos relacional (PostgreSQL/MySQL).

⚙ Mejor estructura de carpetas: Refinar la organización del proyecto para mejorar la mantenibilidad.

🔍 Logging: Implementar logs con herramientas como Serilog para mejor trazabilidad.

✅ Tests unitarios: Agregar pruebas automatizadas para validar la funcionalidad y robustez del sistema.

## 📝 Notas Finales
- Se relaizo con la creación de las tarjetas en memoria.
- Se ha implementado **CQRS con Mediator** para una mejor separación de responsabilidades.
- Se incluye un servicio simulado (**Singleton**) para calcular tarifas de pago de forma aleatoria.

📩 **Contacto:** Si tienes dudas, contáctame en velezalejandro.0222@gmail.com

---


