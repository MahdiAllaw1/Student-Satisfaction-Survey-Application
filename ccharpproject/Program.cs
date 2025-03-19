using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

public class User
{
    private string Username;
    private string Password;
    private List<User> Friends;
    private List<User> Request;
    private List<Post> Posts;

    public User()
    {
        Friends = new List<User>();
        Request = new List<User>();
        Posts = new List<Post>();
    }

    public User(string username, string password) : this()
    {
        Username = username;
        Password = password;
    }

    public void SendRequest(User a)
    {
        a.Request.Add(this);

        //
        string path = "UsersInfo.txt";
        string[] lines = File.ReadAllLines(path);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] userData = lines[i].Split('|');
            if (userData.Length >= 4 && userData[0] == this.GetUsername())
            {
                if (userData[2] == "") // If the Friends field is empty
                    a.WriteInTheRequest(this);   //add it  to the request            
                else
                {
                    string[] friends = userData[2].Split('>');
                    bool found = false;

                    foreach (string fr in friends)
                    {
                        if (fr == this.GetUsername())
                        {
                            found = true;
                            break; //don't
                        }
                    }

                    if (!found)
                        a.WriteInTheRequest(this);   //add it  to the request            
                }
                break;
            }
        }
        File.WriteAllLines(path, lines);
        //
    }

    public void WriteInTheRequest(User a)
    {
        string path = "UsersInfo.txt";
        string[] lines = File.ReadAllLines(path);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] userData = lines[i].Split('|');
            if (userData.Length >= 4 && userData[0] == this.GetUsername())
            {
                if (userData[3] == "")
                {
                    lines[i] += a.GetUsername();
                }
                else
                {
                    string[] requests = userData[3].Split('>');
                    bool found = false;

                    foreach (string req in requests)
                    {
                        if (req == a.GetUsername())
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        lines[i] += ">" + a.GetUsername();
                }
                break;
            }
        }
        File.WriteAllLines(path, lines);
    }

    public void AcceptUser()
    {
        Console.WriteLine(this.GetUsername());
        foreach (User it in Request)
        {
            try
            {
                Console.Write("Write 'Yes' to accept " + it.GetUsername() + ", 'No' to reject: ");
                string y_n = Console.ReadLine().ToLower();
                if (y_n == "yes")
                {
                    Friends.Add(it);
                    it.Friends.Add(this);

                    string path = "UsersInfo.txt";
                    string[] lines = File.ReadAllLines(path);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] userData = lines[i].Split('|'); // userData = username|password|...

                        if (userData.Length >= 4 && userData[0] == this.GetUsername()) // this = current user
                        {
                            if (userData[2] == "") // If the Friends field is empty
                            {
                                lines[i] = userData[0] + "|" + userData[1] + "|" + it.GetUsername() + "|" + userData[3];
                            }
                            else
                            {
                                string[] friends = userData[2].Split('>');
                                bool found = false;

                                foreach (string fr in friends)
                                {
                                    if (fr == it.GetUsername())
                                    {
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found)
                                    lines[i] = userData[0] + "|" + userData[1] + "|" + userData[2] + ">" + it.GetUsername() + "|" + userData[3];
                            }
                            break;
                        }
                    }
                    File.WriteAllLines(path, lines);
                }
                else if (y_n != "no")
                {
                    throw new Exception("You did not give me Yes or No!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            Run.Print(this);
            foreach (User itr in Friends)
            {
                Run.Print(itr);
            }
        }
        if (this.Request.Count != 0)
            Request.Clear();
    }



    



    public void CreatePost()
    {
        string y_n = "yes";
        string ch;
        do
        {
            if (y_n == "yes")
            {
                Console.WriteLine("Write a post:");
                ch = Console.ReadLine();
                var currentTime = DateTime.Now;

                Post a = new Post(ch, currentTime);
                Posts.Add(a);
                Console.WriteLine($"{Username}'s posts: {a.GetContent()}");
                Console.WriteLine($"Current timestamp: {currentTime}");
                Console.Write("Write 'Yes' if you want to write another post, 'No' if you don't: ");
                y_n = Console.ReadLine().ToLower();
            }
            else if (y_n != "no")
            {
                Console.WriteLine("Error reading input.");
            } 
        } while (y_n == "yes");
    }

    public void ShowPost(User a)
    {
        foreach (Post it in a.Posts)
        {
            Console.WriteLine(it.GetContent());

            Console.Write("Write 'Yes' if you like this post: ");
            string y_n = Console.ReadLine().ToLower();
            if (y_n == "yes")
            {
                it.GetLikes().Add(this);
            }
            else
            {
                Console.WriteLine("Nothing to do 👾");
            }

            try
            {
                do
                {
                    Console.Write("Write 'Yes' if you want to leave a comment, 'No' if you don't: ");
                    y_n = Console.ReadLine().ToLower();
                    if (y_n == "yes")
                    {
                        Console.Write("Write your comment: ");
                        string comment = Console.ReadLine();
                        if (!it.GetComments().ContainsKey(this))
                        {
                            it.GetComments()[this] = new List<string>();
                        }
                        it.GetComments()[this].Add(comment);
                    }
                    else if (y_n != "no")
                    {
                        throw new Exception("ERROR 404______NO COMMENT 👾");
                    }
                } while (y_n == "yes");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
        }
    }

    public void search()
    {

    }

    public string GetUsername()
    {
        return Username;
    }
    public string GetPassword()
    {
        return Password;
    }
    public List<User> GetFriends()
    {
        return Friends;
    }
    public List<User> GetRequest()
    {
        return Request;
    }
    public List<Post> GetPosts()
    {
        return Posts;
    }

    
}

public class Post
{
    private string Content;
    private DateTime Timestamp;
    private List<User> Likes;
    private Dictionary<User, List<string>> Comments;

    public Post()
    {
        Likes = new List<User>();
        Comments = new Dictionary<User, List<string>>();
    }

    public Post(string content, DateTime timestamp) : this()
    {
        Content = content;
        Timestamp = timestamp;
    }

    public string GetContent()
    {
        return Content;
    }

    public DateTime GetTimestamp()
    {
        return Timestamp;
    }

    public List<User> GetLikes()
    {
        return Likes;
    }

    public Dictionary<User, List<string>> GetComments()
    {
        return Comments;
    }
}

class Run
{
    public static void LogIn(User a)
    {
        string path = "UsersInfo.txt";
        if (File.Exists(path))
        {
            StreamReader Reader = new StreamReader(path);
            string str = Reader.ReadLine();
            while (str != null)
            {
                string[] Data = str.Split('|');
                if (Data.Length >= 2)
                {
                    string username = Data[0];
                    string password = Data[1];
                    
                    if (a.GetUsername() == username)
                    {
                        if (a.GetPassword() == password)
                            Console.WriteLine("successful log in!");
                        else
                            Console.WriteLine("incorrect password!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid user data format: " + str);
                }
                
            }
            Reader.Close();
        }
    }
    public static void SignIn(User a)
    {
        try
        {
            string path = "UsersInfo.txt";
            if (!File.Exists(path))
            {
                StreamWriter Pen = new StreamWriter(path);
                Pen.Write(a.GetUsername() + "|" + a.GetPassword() + "|" + "|");               
                Pen.Write("\n");
                Pen.Close();
            }
            else
            {
                StreamReader Reader = new StreamReader(path);
                string str = Reader.ReadLine();
                while (str != null)
                {
                    string[] Data = str.Split('|');
                    if (Data.Length >= 1)
                    {
                        string username_ = Data[0];
                        if (a.GetUsername() == username_)
                            break;
                        else
                            str = Reader.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid user data format: " + str);
                    }
                }
                Reader.Close();
                if (str == null)
                {
                    StreamWriter Pen = File.AppendText(path);
                    Pen.Write(a.GetUsername() + "|" + a.GetPassword() + "|" + "|");                    
                    Pen.Write("\n");
                    Pen.Close();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing user data: " + ex.Message);
        }
    }
    public static void Print(User a)
    {
        if (a.GetFriends().Count == 0)
        {
            Console.WriteLine($"No friends :(");
        }
        else
        {
            Console.WriteLine($"Friends of {a.GetUsername()}:");
            foreach (User it in a.GetFriends())
            {
                Console.WriteLine(it.GetUsername());
            }
        }
    }
}


class Program
{

    static void Main(string[] args)
    {
        /* User A = new User("Ali", "alimakka1");
         User B = new User("Fatima", "fatimaismail1");
         User C = new User("Mahdi", "mahdiallaw7");
         Run.SignIn(A);
         Run.SignIn(B);
         Run.SignIn(C);


         //Run.LogIn("Mahdi", "mahdiallaw7");


         // when an object is created write it in a file

         A.SendRequest(B);
         C.SendRequest(B);
         B.AcceptUser();
         //A.CreatePost();
         //B.ShowPost(A);
         Run.LogIn(A);*/
        DateTime currentTimestamp = DateTime.Now;

        // Display the current timestamp in various formats
        Console.WriteLine("Current Timestamp:");
        Console.WriteLine("Full DateTime: " + currentTimestamp); // Full date and time
        Console.WriteLine("Short Date: " + currentTimestamp.ToShortDateString()); // Short date format
        Console.WriteLine("Long Time: " + currentTimestamp.ToLongTimeString()); // Long time format
        Console.WriteLine("Custom Format: " + currentTimestamp.ToString("yyyy-MM-dd HH:mm:ss")); // Custom format

        // Get timestamp as Unix timestamp (seconds since Unix epoch)
        long unixTimestamp = ((DateTimeOffset)currentTimestamp).ToUnixTimeSeconds();
        Console.WriteLine("Unix Timestamp (seconds): " + unixTimestamp);

        // Wait for user input to exit
        Console.ReadLine();
    }
}
