namespace ProfileManager
{
    class Program
    {
        static void Main()
        {
            string firstName = "Mian Hamid";
            string lastName = "Ur Rehman";
            int age = 25;
            double heightInFeet = 6;
            int employeeId = 6426;
            char departmentCode = 'H';

            bool isActiveEmployee = true;
            bool hasCompletedTraining = false;
            bool wantsEmailNotifications = true;
            bool isRemoteEligible = true;

            int yearsUntilRetirement = 65 - age;
            double heightInInches = heightInFeet * 12;
            string displayId = departmentCode + employeeId.ToString();

            string fullName = firstName + " " + lastName;
            string emailAddress = firstName.Substring(0, 1).ToLower() + lastName.ToLower() + "@company.com";
            string formattedHeight = heightInFeet + " feet";
            string trainingStatus = hasCompletedTraining ? "Training Complete" : "Training Required";

            Console.WriteLine("=== EMPLOYEE PROFILE ===");
            Console.WriteLine($"Name: {fullName}");
            Console.WriteLine($"Employee ID: {displayId}");
            Console.WriteLine($"Email: {emailAddress}");
            Console.WriteLine();
            Console.WriteLine("--- Personal Information ---");
            Console.WriteLine($"Age: {age} years old");
            Console.WriteLine($"Height: {formattedHeight} ({heightInInches} inches)");
            Console.WriteLine($"Years until retirement: {yearsUntilRetirement}");
            Console.WriteLine();
            Console.WriteLine("--- Status & Preferences ---");
            Console.WriteLine($"Active Employee: {isActiveEmployee}");
            Console.WriteLine($"Training Status: {trainingStatus}");
            Console.WriteLine($"Email Notifications: {wantsEmailNotifications}");
            Console.WriteLine($"Remote Work Eligible: {isRemoteEligible}");
        }
    }
}