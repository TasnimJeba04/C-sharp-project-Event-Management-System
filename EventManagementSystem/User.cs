// ============================================================
// File: User.cs
// Purpose: Abstract base class demonstrating OOP principles.
//   - ABSTRACTION: abstract class + abstract method GetDashboardName()
//   - ENCAPSULATION: private fields exposed via public properties
//   - INHERITANCE: SuperAdmin, Admin, Customer derive from this
//   - POLYMORPHISM: derived classes override GetDashboardName()
// Also stores the currently logged-in user (CurrentUser) so any
// form can access it from anywhere in the application.
// ============================================================
using System;

namespace EventManagementSystem
{
    public abstract class User
    {
        // ENCAPSULATION : private backing fields
        private int _userId;
        private string _fullName;
        private string _email;
        private string _password;
        private string _phone;
        private string _userType;

        // PROPERTIES (public read/write with validation where needed)
        public int UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full name cannot be empty.");
                _fullName = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("A valid email is required.");
                _email = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                    throw new ArgumentException("Password must be at least 4 characters.");
                _password = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string UserType
        {
            get { return _userType; }
            protected set { _userType = value; }   // only subclasses can set
        }

        // ABSTRACTION : every subclass MUST implement this
        public abstract string GetDashboardName();

        // POLYMORPHISM example : virtual method that subclasses can override
        public virtual string GetWelcomeMessage()
        {
            return "Welcome, " + FullName + " (" + UserType + ")";
        }

        // ----- static reference to the currently logged-in user -----
        public static User CurrentUser { get; set; }
    }
}
