# 🛡️ WebApplication5 - ASP.NET MVC with Server-Side Validation & Modular CRUD

**WebApplication5** is an ASP.NET MVC 5 project that implements server-side validation for the `User` module, along with full CRUD operations. It follows the MVC pattern with modular structure using **Areas**, and separates concerns via layered **DAL (Data Access Layer)** and **BAL (Business Access Layer)**. The application also integrates **RESTful API consumption** using `HttpClient` for smooth backend communication.

---

## 🚀 Features

- ✅ CRUD functionality for `User` module
- 🛡️ Server-side form validation
- 🔗 RESTful API integration via `HttpClient`
- 🧩 Modular structure using Areas:
  - Organized Controllers, Views, and Models
- 🔄 Clean separation using:
  - **DAL (Data Access Layer)**
  - **BAL (Business Access Layer)**
- 🖼️ Razor Views for a dynamic and responsive UI
- ⚙️ Built using Visual Studio

---

## 🛠️ Tech Stack

- 💻 ASP.NET MVC 5 / .NET Framework
- 🌐 RESTful APIs with `HttpClient`
- 🗃️ Entity Framework (Code First or DB First)
- 💾 SQL Server / LocalDB
- 🖼️ Razor Views
- ⚙️ Visual Studio IDE

---

## 📁 Folder Structure

WebApplication5/ ├── Areas/ │ └── User/ │ ├── Controllers/ │ ├── Models/ │ └── Views/ ├── DAL/ ├── BAL/ ├── Controllers/ ├── Models/ ├── Views/ ├── App_Start/ └── Web.config

---

## 📦 Setup Instructions

1. Clone the repository  
   `git clone https://github.com/Arman-Gilani/WebApplication5.git`

2. Open the solution in **Visual Studio**.

3. Restore NuGet packages.

4. Configure your **SQL Server / LocalDB** connection string in `Web.config`.

5. Build and run the project.

---

## 🙌 Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests to improve features or fix bugs.

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).
