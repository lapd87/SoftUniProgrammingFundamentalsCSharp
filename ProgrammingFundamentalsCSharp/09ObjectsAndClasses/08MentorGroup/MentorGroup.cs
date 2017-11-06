namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<GroupMember> myGroup = ReadGroupMembers();

            myGroup = AddComments(myGroup);

            PrintReport(myGroup);
        }

        private static void PrintReport(List<GroupMember> myGroup)
        {
            foreach (var user in myGroup.OrderBy(n => n.Username))
            {
                Console.WriteLine(user.Username);
                Console.WriteLine("Comments:");

                foreach (var comment in user.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in user.DatesAttended.OrderBy(d => d.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }

        private static List<GroupMember> AddComments(List<GroupMember> myGroup)
        {
            string input = Console.ReadLine();

            while (input != "end of comments")
            {
                string[] userComment = input
                                  .Trim()
                                  .Split(new string[] { "-" }, StringSplitOptions
                                  .RemoveEmptyEntries)
                                  .ToArray();

                string username = userComment[0];
                string comment = userComment[1];

                if (myGroup.Any(n => n.Username == username))
                {
                    int index = myGroup.IndexOf(myGroup.Where(n => n.Username == username).FirstOrDefault());

                    myGroup[index].Comments.Add(comment);
                }

                input = Console.ReadLine();
            }

            return myGroup;
        }

        private static List<GroupMember> ReadGroupMembers()
        {
            string input = Console.ReadLine();

            List<GroupMember> myGroup = new List<GroupMember> { };

            while (input != "end of dates")
            {

                string[] userDates = input
                                  .Trim()
                                  .Split(new string[] { " ", "," }, StringSplitOptions
                                  .RemoveEmptyEntries)
                                  .ToArray();

                GroupMember currentMember = new GroupMember();

                currentMember.Username = userDates[0];

                if (!myGroup.Any(u => u.Username == currentMember.Username))
                {
                    currentMember.DatesAttended = new List<DateTime> { };
                    currentMember.Comments = new List<string> { };

                    myGroup.Add(currentMember);
                }

                int index = myGroup.IndexOf(myGroup.Where(n => n.Username == currentMember.Username).FirstOrDefault());

                for (int i = 1; i < userDates.Length; i++)
                {
                    myGroup[index].DatesAttended.Add(DateTime.ParseExact(userDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                input = Console.ReadLine();
            }

            return myGroup;
        }
    }

    class GroupMember
    {
        public string Username { get; set; }
        public List<DateTime> DatesAttended { get; set; }
        public List<string> Comments { get; set; }
    }
}
