# Event Management System

A C# Windows Forms desktop application that brings hall booking and event service management online. Customers can search for halls, check live availability and pricing, book a hall for any event (wedding, birthday, corporate conference, seminar, etc.), pay through a simulated payment gateway (bKash / Nagad / Rocket / Visa / Mastercard / Cash), track booking history, and leave reviews. Hall owners and a Super Admin manage the platform from their own dashboards.

> Course: **Object Oriented Programming - 2 (CSC2210)**
> Semester: **Spring 2025-2026** &nbsp;|&nbsp; Section: **K**
> Tech: **C# . NET Framework 4.7.2 + Windows Forms + SQL Server (LocalDB) + ADO.NET**

---

## Table of Contents

1. [Features](#features)
2. [Screenshots](#screenshots)
3. [System Architecture](#system-architecture)
4. [Tech Stack](#tech-stack)
5. [Database Design](#database-design)
6. [Project Structure](#project-structure)
7. [Setup & Installation](#setup--installation)
8. [Default Login Credentials](#default-login-credentials)
9. [How to Use](#how-to-use)
10. [Object-Oriented Concepts](#object-oriented-concepts-used)
11. [Validation & Error Handling](#validation--error-handling)
12. [Future Improvements](#future-improvements)
13. [Team](#team)

---

## Features

### Authentication
- Sign-up form with email format validation, password confirmation, phone-number format check, and role selection (Customer / Admin / SuperAdmin).
- Secure login that loads the correct dashboard based on user role.
- "Show / Hide password" toggle on every password field.

### Customer
- Browse all halls in a card-based grid with image, name, location, capacity, price, supported event types, and average rating.
- Filter halls by **category, event type, location, price range, and capacity** using multiple combo boxes plus a free-text search box.
- Open any hall to see full details, then book it.
- Booking form lets the customer pick **preferred date, start time, end time, event type, number of guests, contact phone, special requests, and apply a coupon code**. Total price is recalculated live.
- Payment screen with six payment options: **bKash, Nagad, Rocket, Visa, Mastercard, Cash** (dummy redirect / OTP simulation, similar to a real gateway).
- Receipt is generated as a `.txt` file after successful payment.
- Booking history page with status filter (`All / Pending / Confirmed / Cancelled`) and the option to leave a review or cancel a confirmed booking.
- Star-rating review system (1-5 stars) with comments.

### Admin / Hall Owner
- Dashboard showing live stats: number of halls owned, bookings received, earnings, pending requests.
- Manage own halls: **add, edit, delete**, set price, capacity, image, supported event types.
- See all bookings made for own halls and **approve, confirm, or cancel** them.
- See payment history per hall and resolve dispute requests from customers.
- Stock visibility: total seats vs. seats already booked per hall, so the admin can see "available vs. sold-out" capacity at a glance.

### Super Admin
- Full system control - manages all users, all halls, all bookings, and all payments.
- **User management**: create / edit / delete users of any role; halt or unblock a vendor's membership when bad reviews accumulate.
- **Review moderation**: remove inappropriate or fake reviews.
- **Sales analytics**: weekly sales, monthly sales, top-earning halls.
- **Discounts**: create new coupon codes, set percentage and expiry, activate / deactivate.
- Activity log of all recent bookings and payments across the platform.

### Other features
- Centralised `DatabaseConnection` helper class so the connection string lives in exactly one place.
- Parameterised SQL queries everywhere — protection against SQL injection.
- Try-catch error handling on every database operation with user-friendly message boxes.
- Custom-painted gradient UI (blue → purple cards) and a reusable `GradientButton` control.
- Image fallback: if a hall / payment image is missing, a coloured letter logo is auto-drawn so the UI never breaks.

---


## System Architecture

```
+--------------------+       +--------------------------+       +-----------------------+
|  Windows Forms UI  | <---> |  C# Business Logic       | <---> |  SQL Server LocalDB   |
|  (Customer / Admin |       |  (User, Customer, Admin, |       |  EventManagementDB    |
|   / Super Admin)   |       |   SuperAdmin classes)    |       |  6 normalised tables  |
+--------------------+       +--------------------------+       +-----------------------+
                              ^                       ^
                              |                       |
                              +----- DatabaseConnection (ADO.NET helper)
```

---

## Tech Stack

| Layer | Technology |
| --- | --- |
| Language | C# (.NET Framework 4.7.2) |
| UI | Windows Forms (WinForms), GDI+ for custom painting |
| Database | Microsoft SQL Server LocalDB (`(localdb)\MSSQLLocalDB`) |
| Data Access | ADO.NET (`System.Data.SqlClient`) |
| IDE | Visual Studio 2019 / 2022 |
| Database Tool | SQL Server Management Studio (SSMS) |

---

## Database Design

The database is normalised up to **3NF** and contains six tables linked by foreign keys.

| Table | Purpose |
| --- | --- |
| `Users` | All system users (SuperAdmin / Admin / Customer) |
| `Events` | Halls / venues. Owned by an Admin (`OrganizerID`) |
| `Discounts` | Coupon codes with percent and expiry |
| `Bookings` | A customer reserving a hall with date/time/event-type details |
| `Payments` | One record per paid booking, with method and status |
| `Reviews` | 1-5 star ratings with optional comment |

ER diagram and full schema diagram are committed as `ER_Diagram.png` and `Database_Schema_Diagram.png`.

---

## Project Structure

```
EventManagementSystem/
├── EventManagementSystem.sln
├── EventManagementSystem/
│   ├── Program.cs                   # entry point - opens LoginForm
│   ├── App.config
│   ├── DatabaseConnection.cs        # central ADO.NET helper
│   ├── User.cs                      # abstract base class (OOP)
│   ├── Customer.cs
│   ├── Admin.cs
│   ├── SuperAdmin.cs
│   ├── GradientButton.cs            # custom UI control
│   ├── LoginForm.cs / .Designer.cs / .resx
│   ├── RegisterForm.cs ...
│   ├── CustomerDashboardForm.cs ...
│   ├── BookEventForm.cs ...
│   ├── PaymentForm.cs ...
│   ├── BookingHistoryForm.cs ...
│   ├── ReviewForm.cs ...
│   ├── AdminDashboardForm.cs ...
│   ├── ManageEventsForm.cs ...
│   ├── ManageUsersForm.cs ...
│   ├── SuperAdminDashboardForm.cs ...
│   ├── Properties/AssemblyInfo.cs
│   └── Images/                      # hall photos, payment logos, login_bg
└── packages/                        # NuGet (System.Data.SqlClient)

Repo root:
├── README.md                        # this file
├── sql.txt                          # complete database backup script
├── 01_CreateDatabase.sql            # (legacy, kept for reference)
├── 02_SampleData.sql                # (legacy, kept for reference)
├── ER_Diagram.png
├── Database_Schema_Diagram.png
└── Project Report.pdf
```

---

## Setup & Installation

### Requirements

- Windows 10 / 11
- Visual Studio 2019 or 2022 (Community edition is fine) with the **.NET desktop development** workload
- SQL Server Express LocalDB (installed with Visual Studio by default)
- SQL Server Management Studio (SSMS) — free download from Microsoft

### Step 1 — Clone the repository

```bash
git clone https://github.com/<your-username>/EventManagementSystem.git
cd EventManagementSystem
```

### Step 2 — Create the database

1. Open **SSMS** and connect to `(localdb)\MSSQLLocalDB` with Windows Authentication.
2. Click **New Query**, open `sql.txt` from the repo root, paste the entire content, and press **F5**.
3. You should see `Database EventManagementDB is ready to use.` in the output panel.

### Step 3 — Open the project in Visual Studio

1. Double-click `EventManagementSystem/EventManagementSystem.sln`.
2. Visual Studio will automatically restore the `System.Data.SqlClient` NuGet package on the first build.
3. Press **F5** (Start Debugging).

The login form should open with a gradient card. Use one of the [default credentials](#default-login-credentials) below.

> **Connection string used by the project** (in `DatabaseConnection.cs`):
> `Server=(localdb)\MSSQLLocalDB;Database=EventManagementDB;Integrated Security=True;`
> Edit this line if your SQL Server uses a different instance name.

---

## Default Login Credentials

| Role | Email | Password |
| --- | --- | --- |
| Super Admin | `super@event.com` | `super123` |
| Admin (Hall Owner) | `admin@event.com` | `admin123` |
| Admin (Hall Owner) | `admin2@event.com` | `admin123` |
| Customer | `customer@event.com` | `cust123` |
| Customer | `nabila@event.com` | `cust123` |
| Customer | `sadia@event.com` | `cust123` |

---

## How to Use

### As a customer
1. Sign up or log in with `customer@event.com / cust123`.
2. On the dashboard, browse hall cards or use the filters (category, event type, location, price, capacity).
3. Click a hall → fill out the booking form → apply a coupon (e.g. `NEW10`, `SUMMER20`) if you have one → click **Book Now**.
4. Choose a payment method on the next screen → simulate the payment → a receipt `.txt` file is saved automatically.
5. Open **Booking History** to see all your bookings, filter by status, or leave a review on a confirmed booking.

### As an admin / hall owner
1. Log in with `admin@event.com / admin123`.
2. Dashboard shows your owned halls, total bookings, and revenue.
3. Open **Manage Halls** to add a new hall, edit prices, change images, or delete a hall.
4. Open **Bookings** to confirm pending bookings or mark them as cancelled.

### As the super admin
1. Log in with `super@event.com / super123`.
2. See platform-wide stats: total users, total halls, total bookings, total revenue.
3. **Manage Users** — add, edit, or delete any user; halt a vendor's membership.
4. **Manage Halls** — full control over every hall on the platform.
5. **Discounts** — create and toggle coupons.
6. **Reviews** — remove inappropriate reviews.

---

## Object-Oriented Concepts Used

| OOP Concept | Where It Is Used |
| --- | --- |
| **Abstraction** | `User.cs` is an `abstract` class with the abstract method `GetDashboardName()`. |
| **Encapsulation** | All user fields (`_userId`, `_fullName`, …) are `private` and exposed via validated properties. The connection string in `DatabaseConnection` is `private readonly`. |
| **Inheritance** | `Customer`, `Admin`, and `SuperAdmin` all derive from `User`. |
| **Polymorphism** | Each subclass overrides `GetDashboardName()` and `GetWelcomeMessage()`. |
| **Static members** | `User.CurrentUser` is a static reference to the logged-in user, available to every form. |
| **Exception handling** | Every database call is wrapped in `try / catch` and shows a user-friendly `MessageBox` instead of crashing. |

---

## Validation & Error Handling

- Required fields cannot be empty.
- Email must match a regex (`^[^@\s]+@[^@\s]+\.[^@\s]+$`).
- Bangladesh phone format is validated on registration.
- Password must be at least 4 characters; password and confirm-password must match.
- Capacity, price, ticket count must be positive numbers.
- Event date cannot be in the past.
- Rating must be between 1 and 5.
- Booking conflicts and duplicate coupon codes are caught at the database level via `CHECK` and `UNIQUE` constraints.
- All SQL queries use parameterised commands (`SqlParameter`) — no string concatenation, no SQL injection risk.

---

## Future Improvements

- Web-based and mobile versions
- Real payment integration (SSLCommerz, bKash, Stripe)
- Email and SMS notifications on booking confirmation
- AI-based hall recommendation system
- Advanced analytics dashboard for hall owners

---

## Team

| Serial | Name | Student ID 
| :-: | --- | --- 
| 01 | Tasnim Mahmud Jeba       | 24-57331-2
| 02 | Mehrah Khan              | 24-57323-2 
| 03 | Halimatus Sadia          | 24-57448-2 
| 04 | Jannatul Ferdus Natasha  | 24-57973-2 

> Update the contribution percentages above to match what is submitted on the Google Form.

---

## License

This project is submitted as a course requirement for **CSC2210 - Object Oriented Programming 2** at AIUB. It is for educational purposes only.
