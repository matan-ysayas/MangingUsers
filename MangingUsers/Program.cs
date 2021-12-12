using MangingUsers;

List<User> usersList = new List<User>();

void createUser()
{
    int count = 0;
    while (count < 4)
    {

        Console.WriteLine("enter first name");
        string userFisrtName = Console.ReadLine();
        Console.WriteLine("enter last name");
        string userlastName = Console.ReadLine();
        Console.WriteLine("enter year of birth");
        int userYearOfBirth = int.Parse(Console.ReadLine());
        Console.WriteLine("enter email name");
        string userEmail = Console.ReadLine();

        User newUser = new User(userFisrtName, userlastName, userYearOfBirth, userEmail);
        usersList.Add(newUser);
        count++;

    }
    usersList.Sort();
    foreach (User user in usersList)
    {
        Console.WriteLine(user.YearOfBirth);
    }

}

static void crateFile(List<User> someList)
{
    FileStream fs = new FileStream($@"c:\test\allUsers.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        foreach (User user in someList)
        {
            writer.WriteLine($"{user.FirstName}|| {user.LastName}||{user.YearOfBirth}||{user.Email}");
        }
    }
};

static void readFromFile()
{
    FileStream fs = new FileStream($@"c:\test\allUsers.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(fs))
    {
        reader.ReadToEnd();
    }
};



static void crateFileForList(List<User> someList)
{
    foreach (User user in someList)
    {
        FileStream fs = new FileStream($@"c:\test\{user.FirstName}.txt", FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine($"{user.FirstName}|| {user.LastName}||{user.YearOfBirth}||{user.Email}");
        }
    }
};


static void readFromFileByFileName(string fileName)
{
    FileStream fs = new FileStream($@"c:\test\{fileName}", FileMode.Open);
    using (StreamReader reader = new StreamReader(fs))
    {
        reader.ReadToEnd();
    }
}



static void crateUserFile(User someUser)
{
    FileStream fs = new FileStream($@"c:\test\{someUser.FirstName}.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {


        writer.WriteLine($"{someUser.FirstName}|| {someUser.LastName}||{someUser.YearOfBirth}||{someUser.Email}");

    }
};



static void AddUser()
{
    try
    {
        Console.WriteLine("enter first name");
        string userFisrtName = Console.ReadLine();
        Console.WriteLine("enter last name");
        string userlastName = Console.ReadLine();
        Console.WriteLine("enter year of birth");
        int userYearOfBirth = int.Parse(Console.ReadLine());
        Console.WriteLine("enter email name");
        string userEmail = Console.ReadLine();

        User newUser = new User(userFisrtName, userlastName, userYearOfBirth, userEmail);

        crateUserFile(newUser);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
        AddUser();

    }


}

static void editUser()
{
    try
    {
        Console.WriteLine("enter first name");
        string userFisrtName = Console.ReadLine();
        Console.WriteLine("enter last name");
        string userlastName = Console.ReadLine();
        Console.WriteLine("enter year of birth");
        int userYearOfBirth = int.Parse(Console.ReadLine());
        Console.WriteLine("enter email name");
        string userEmail = Console.ReadLine();

        User newUser = new User(userFisrtName, userlastName, userYearOfBirth, userEmail);
        FileStream fs = new FileStream($@"c:\test\{newUser.FirstName}.txt", FileMode.Create);
        using (StreamWriter writer = new StreamWriter(fs))
        {


            writer.WriteLine($"{newUser.FirstName}|| {newUser.LastName}||{newUser.YearOfBirth}||{newUser.Email}");

        }
    }catch(FormatException ex)
    {
        Console.WriteLine(ex.Message);
        editUser();
    }


}


static void deleteUser()
{
    try
    {
        Console.WriteLine("enter user name");
        string userName = Console.ReadLine();
        if (File.Exists($@"c:\test\{userName}.txt"))
        {
            File.Delete($@"c:\test\{userName}.txt");
            Console.WriteLine("file deleted");
        }
        else Console.WriteLine("file not exists");
    }catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}


static void showUser()
{
    try
    {
        Console.WriteLine("enter user first name");
        string userName = Console.ReadLine();
        if (File.Exists($@"c:\test\{userName}.txt"))
        {
            FileStream fs = new FileStream($@"c:\test\{userName}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fs))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        else Console.WriteLine("file not exists");
    }catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}






void UserApp()
{
    Console.WriteLine("for add user press 1\n for edit user press 2 \n for delete user press 3 \n for showing user press 4");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            AddUser();

            UserApp();

            break;
        case 2:

            editUser();
            UserApp();
            break;
        case 3:
            deleteUser();
            UserApp();
            break;

        case 4:
            showUser();
            UserApp();

            break;

    }


}

UserApp();