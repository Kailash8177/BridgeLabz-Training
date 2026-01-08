using System;
using System.Collections.Generic;
using System.Text;

namespace social_media_friends
{

    /*
     * UserNode represents a single user in the system.
     * Each node stores user details and a reference to the next user.
     */
    class UserNode
    {
        public int UserId;
        public string Name;
        public UserNode Next;

        // Constructor to initialize user details
        public UserNode(int id, string name)
        {
            UserId = id;
            Name = name;
            Next = null;
        }
    }

}
