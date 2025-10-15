**Select2MVC**

---

**1. Project Overview**
- Project Name: Select2MVC  
- Project Type: ASP.NET Core 8 MVC  
- Frontend Styling: Bootstrap 5 + Select2 + Bootstrap Icons  
- Purpose: Demonstrates login/logout session handling, a Top page with Select2 dropdown inside a Bootstrap Accordion, and modern UI styling.

---

**2. Folder Structure**
```
/Select2MVC
│
├─ Controllers
│   ├─ AccountController.cs   // Handles login & logout
│   └─ TopController.cs       // Handles Top page
│
├─ Models
│   └─ LoginViewModel.cs      // Login form data
│
├─ Views
│   ├─ Shared
│   │   └─ _Layout.cshtml     // Main layout with Bootstrap, jQuery, Select2, Icons
│   │
│   ├─ Account
│   │   └─ Login.cshtml        // Login page view
│   │
│   └─ Top
│       └─ Index.cshtml        // Top page view with Select2 inside Accordion
│
├─ wwwroot
│   ├─ lib/bootstrap/...       // Bootstrap CSS/JS
│   ├─ lib/jquery/...          // jQuery
│   └─ css/site.css            // Custom styles
│
├─ Program.cs                  // App configuration & session setup
└─ Select2MVC.csproj           // Project file
```

---

**3. Project Setup**
1. Created ASP.NET Core 8 MVC project.  
2. Installed Bootstrap 5 via LibMan.  
3. Added jQuery (required for Select2).  
4. Integrated Select2 (searchable select dropdown).  
5. Added Bootstrap Icons for modern UI elements (eye icon, etc.).

---

**4. Pages / Views**
| Page       | View File           | Purpose |
|------------|-------------------|---------|
| Login      | Views/Account/Login.cshtml | User login form with Login ID and Password. Eye icon toggle added for password. |
| Top        | Views/Top/Index.cshtml     | Shows welcome message, Logout button, and Select2 dropdown inside Bootstrap Accordion. |
| Layout     | Views/Shared/_Layout.cshtml | Contains header, navbar, scripts, CSS, Select2, jQuery, Bootstrap, icons. Shared by all pages. |

---

**5. Controllers**
| Controller       | Actions                       | Purpose |
|-----------------|--------------------------------|---------|
| AccountController | Login (GET/POST) <br> Logout (GET) | Handles login form display, login authentication, session creation, and logout. |
| TopController    | Index (GET)                  | Displays Top page, checks session, and redirects to login if user is not authenticated. |

---

**6. Model**
| Model            | Properties             | Purpose |
|-----------------|------------------------|---------|
| LoginViewModel   | LoginId (string) <br> Password (string) | Stores user input from Login form. |

---

**7. Navigation & Flow**
1. Login Page: URL: /Account/Login  
   - User enters credentials (dummy login: admin01 / admin@1234).  
   - If valid, session variable UserName is set.  
2. Top Page: URL: /Top/Index  
   - Session checked via HttpContext.Session.GetString("UserName").  
   - Displays "Welcome, [LoginId]!"  
   - Logout button clears session and redirects back to login.  
3. Access Control:  
   - If a user tries to access Top page without a session, they are redirected to Login.

---

**8. Login / Logout Handling**
- Login: HttpContext.Session.SetString("UserName", model.LoginId);  
- Logout: HttpContext.Session.Clear();  
- Session Duration: 30 minutes idle timeout, set in Program.cs.

---

**9. Scripts & Libraries Used**
| Library         | Purpose                                  | Source |
|-----------------|------------------------------------------|--------|
| jQuery           | Required by Select2                      | CDN / wwwroot/lib/jquery |
| Bootstrap 5      | UI styling, Accordion, responsive layout | wwwroot/lib/bootstrap |
| Bootstrap Icons  | Eye icon toggle and other icons          | CDN |
| Select2          | Searchable dropdown inside Accordion     | CDN |
| site.js          | Custom JS (currently minimal)           | wwwroot/js |

---

**10. Key Features**
- Session-based login/logout with dummy credentials.  
- Top page shows user login ID.  
- Bootstrap Accordion contains Select2 dropdown with dummy options.  
- Modern UI with Bootstrap 5 utility classes, shadows, rounded cards, gradients, and responsive design.  
- Eye icon toggle for password visibility on Login page.  
- Fully functional and ready for extension (real authentication, database, or API integration).

---

**Summary:**  
The Select2MVC project demonstrates a clean, modern ASP.NET Core 8 MVC app with session-based login, Bootstrap 5 styling, Select2 dropdown, Accordion integration, and reusable _Layout for consistent UI. The folder structure, scripts, and views are organized for maintainability.
