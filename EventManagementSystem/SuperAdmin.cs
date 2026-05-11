// ============================================================
// File: SuperAdmin.cs
// Purpose: SuperAdmin user type. Inherits from User.
// ============================================================
namespace EventManagementSystem
{
    public class SuperAdmin : User
    {
        public SuperAdmin()
        {
            UserType = "SuperAdmin";
        }

        // POLYMORPHISM : override abstract method
        public override string GetDashboardName()
        {
            return "SuperAdminDashboardForm";
        }

        public override string GetWelcomeMessage()
        {
            return "Welcome Super Admin " + FullName + " — full system control.";
        }
    }
}
