namespace MangingUsers
{
    internal class User : IComparable
    {
        string firstName;
        string lastName;
        int yearOfBirth;
        string email;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }

        public string Email { get { return email; } set { email = value; } }
        User() { }
        public User(string firstName, string lastName, int yearOfBirth, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.email = email;
        }


      protected virtual void  PrintAllDetail()
        {
            Console.WriteLine($"first name: {this.firstName}|| last name:{this.lastName}|| year of birth:{this.yearOfBirth}|| email:{this.email} ");
        }


        public int CompareTo(object obj) 
        { User u = (User)obj; 
            if (this.yearOfBirth < u.yearOfBirth)
                return 1; 
            if (this.yearOfBirth > u.yearOfBirth)
                return -1;
            return 0; }
    }


}

