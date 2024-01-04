namespace Exercise25
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a password and I'll tell you its strength: ");
            Console.Write("Enter the password: ");
            string? password = Console.ReadLine();

            if (password != null)
            {
                PasswordStrength strength = PasswordValidator(password);

                Console.WriteLine($"The password '{password}' is a {strength} password.");
            }
        }

        enum PasswordStrength
        {
            VeryWeak,
            Weak,
            Strong,
            VeryStrong
        }

        static PasswordStrength PasswordValidator(string password)
        {
            bool hasLetters = false;
            bool hasNumbers = false;
            bool hasSpecialCharacters = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    hasLetters = true;
                }
                else if (char.IsNumber(c))
                {
                    hasNumbers = true;
                }
                else if (!char.IsWhiteSpace(c))
                {
                    hasSpecialCharacters = true;
                }
            }

            if (!hasLetters && hasNumbers && password.Length < 8)
            {
                return PasswordStrength.VeryWeak;
            }
            else if (hasLetters && !hasNumbers && password.Length < 8)
            {
                return PasswordStrength.Weak;
            }
            else if (hasLetters && hasNumbers && password.Length >= 8 && !hasSpecialCharacters)
            {
                return PasswordStrength.Strong;
            }
            else if (hasLetters && hasNumbers && hasSpecialCharacters && password.Length >= 8)
            {
                return PasswordStrength.VeryStrong;
            }
            else
            {
                throw new ArgumentException("Invalid password");
            }
        }
    }
}