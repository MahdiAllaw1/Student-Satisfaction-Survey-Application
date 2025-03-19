using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class User
{
    public string Username { get; set; }
    public List<User> Friends { get; set; }
    public List<User> Requests { get; set; }
    public List<Post> Posts { get; set; }

    public User(string username)
    {
        Username = username;
        Friends = new List<User>();
        Requests = new List<User>();
        Posts = new List<Post>();
    }

    public void SendRequest(User recipient)
    {
        recipient.Requests.Add(this);
        // Add UI logic here for handling requests
    }

    public void AcceptRequest(User requester)
    {
        Friends.Add(requester);
        requester.Friends.Add(this);
        Requests.Remove(requester);
        // Add UI logic here for accepting requests
    }

    public void CreatePost(string content)
    {
        var currentTime = DateTime.Now;
        var post = new Post(content, currentTime);
        Posts.Add(post);
        // Add UI logic here for creating and displaying posts
    }
    public string GetUsername()
    {
        return Username;
    }

    public List<User> GetFriends()
    {
        return Friends;
    }

}

public class Post
{
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public List<User> Likes { get; set; }
    public Dictionary<User, string> Comments { get; set; }

    public Post(string content, DateTime timestamp)
    {
        Content = content;
        Timestamp = timestamp;
        Likes = new List<User>();
        Comments = new Dictionary<User, string>();
    }
}



public class UserForm : Form
{
    private User currentUser;
    private ListBox friendListBox;
    private TextBox postTextBox;
    private Button createPostButton;

    public UserForm(User user)
    {
        currentUser = user;
        InitializeComponents();
        DisplayFriends();
    }

    private void InitializeComponents()
    {
        // Initialize form and controls
        Text = currentUser.GetUsername();
        friendListBox = new ListBox();
        postTextBox = new TextBox();
        createPostButton = new Button();

        // Set control properties
        friendListBox.Dock = DockStyle.Left;
        friendListBox.Width = 150;
        friendListBox.SelectedIndexChanged += FriendSelected;

        postTextBox.Dock = DockStyle.Top;

        createPostButton.Dock = DockStyle.Bottom;
        createPostButton.Text = "Create Post";
        createPostButton.Click += CreatePostClicked;

        // Add controls to the form
        Controls.Add(friendListBox);
        Controls.Add(postTextBox);
        Controls.Add(createPostButton);
    }

    private void DisplayFriends()
    {
        // Display friends in the list box
        foreach (User friend in currentUser.GetFriends())
        {
            friendListBox.Items.Add(friend.GetUsername());
        }
    }

    private void FriendSelected(object sender, EventArgs e)
    {
        // Handle friend selection event
        // Show selected friend's posts or perform other actions
        string selectedFriend = friendListBox.SelectedItem?.ToString();
        if (selectedFriend != null)
        {
            // Retrieve the selected friend and show posts or other actions
            // Example: User selectedFriendUser = FindUserByUsername(selectedFriend);
            // Perform actions with selectedFriendUser
        }
    }

    private void CreatePostClicked(object sender, EventArgs e)
    {
        // Handle create post button click event
        string postContent = postTextBox.Text;
        // Create post with postContent for the currentUser
        // Example: currentUser.CreatePost(postContent);
        // Update UI to display the newly created post
    }
}

// Your existing User and Post classes remain unchanged

class Program
{
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        User A = new User("Ali");
        User B = new User("Fatima");
        User C = new User("Mahdi");

        A.SendRequest(B);
        C.SendRequest(B);
        B.AcceptRequest(A);
        B.AcceptRequest(C);

        Application.Run(new UserForm(A)); // Show the GUI for User A
    }
}


