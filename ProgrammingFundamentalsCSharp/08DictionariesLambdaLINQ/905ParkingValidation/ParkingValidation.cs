using System;
using System.Collections.Generic;
using System.Linq;

class ParkingValidation
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> userLicenseNum = new Dictionary<string, string> { };

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine()
            .Trim()
            .Split(new string[] { " " }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

            string user = command[1];

            if (command[0] == "register")
            {
                if (userLicenseNum.ContainsKey(user))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {userLicenseNum[user]}");
                    continue;
                }

                string licenseNum = command[2];

                char[] plateCheck = licenseNum.ToCharArray();

                if (licenseNum.Length != 8)
                {
                    Console.WriteLine($"ERROR: invalid license plate {licenseNum.ToString()}");
                    continue;
                }
                else
                {
                    char[] letterCap = { plateCheck[0], plateCheck[1], plateCheck[6], plateCheck[7] };

                    char[] digits = { plateCheck[2], plateCheck[3], plateCheck[4], plateCheck[5] };

                    bool notValid = letterCap.Any(x => x < 65 || x > 90)
                                    || digits.Any(x => x < 48 || x > 57);

                    if (notValid)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseNum}");
                        continue;
                    }
                }

                if (userLicenseNum.ContainsValue(licenseNum))
                {
                    Console.WriteLine($"ERROR: license plate {licenseNum} is busy");
                    continue;
                }

                userLicenseNum.Add(user, licenseNum);

                Console.WriteLine($"{user} registered {licenseNum} successfully");
            }

            if (command[0] == "unregister")
            {
                if (!userLicenseNum.ContainsKey(user))
                {
                    Console.WriteLine($"ERROR: user {user} not found");
                    continue;
                }

                userLicenseNum.Remove(user);

                Console.WriteLine($"user {user} unregistered successfully");
            }
        }

        foreach (var user in userLicenseNum)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}
