// ============================================================
// File: Admin.cs
// Purpose: Admin / Event Organizer user type. Inherits from User.
// ============================================================
namespace EventManagementSystem
{
    public class Admin : User
    {
        public Admin()
        {
            UserType = "Admin";
        }

        public override string GetDashboardName()
        {
            return "AdminDashboardForm";
        }

        public override string GetWelcomeMessage()
        {
            return "Welcome Organizer " + FullName + " — manage your events and bookings.";
        }
    }
}
