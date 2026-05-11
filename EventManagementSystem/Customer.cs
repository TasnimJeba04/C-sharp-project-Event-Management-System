// ============================================================
// File: Customer.cs
// Purpose: Customer user type. Inherits from User.
// ============================================================
namespace EventManagementSystem
{
    public class Customer : User
    {
        public Customer()
        {
            UserType = "Customer";
        }

        public override string GetDashboardName()
        {
            return "CustomerDashboardForm";
        }

        public override string GetWelcomeMessage()
        {
            return "Welcome " + FullName + "! Browse and book exciting events.";
        }
    }
}
