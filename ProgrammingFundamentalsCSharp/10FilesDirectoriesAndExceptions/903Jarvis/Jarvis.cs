namespace Jarvis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            BigInteger maxEnergy = BigInteger.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Robot myRobot = new Robot();

            myRobot.Name = "Jarvis";
            myRobot.Arm = new List<Arms> { };
            myRobot.Leg = new List<Legs> { };
            myRobot.Body = new List<Torso> { };
            myRobot.Head = new List<Head> { };

            BigInteger currentEnergy = maxEnergy;

            while (input != "Assemble!")
            {
                string[] inputArray = input
                                .Trim()
                                .Split(new string[] { " " }, StringSplitOptions
                                .RemoveEmptyEntries)
                                .ToArray();

                string currentComponent = inputArray[0];

                switch (currentComponent)
                {
                    case "Arm":

                        Arms currentArm = new Arms();

                        currentArm.Energy = int.Parse(inputArray[1]);
                        currentArm.Reach = int.Parse(inputArray[2]);
                        currentArm.Fingers = int.Parse(inputArray[3]);

                        if (myRobot.Arm.Count < 2)
                        {
                            currentEnergy -= currentArm.Energy;

                            myRobot.Arm.Add(currentArm);
                        }
                        else if (currentArm.Energy < Math.Min(myRobot.Arm[0].Energy, myRobot.Arm[1].Energy))
                        {
                            currentEnergy += (myRobot.Arm[0].Energy - currentArm.Energy);

                            myRobot.Arm[0] = currentArm;
                        }
                        else if (currentArm.Energy < myRobot.Arm[1].Energy)
                        {
                            currentEnergy += (myRobot.Arm[1].Energy - currentArm.Energy);

                            myRobot.Arm[1] = currentArm;
                        }
                        break;

                    case "Leg":

                        Legs currentLeg = new Legs();

                        currentLeg.Energy = int.Parse(inputArray[1]);
                        currentLeg.Strength = int.Parse(inputArray[2]);
                        currentLeg.Speed = int.Parse(inputArray[3]);

                        if (myRobot.Leg.Count < 2)
                        {
                            currentEnergy -= currentLeg.Energy;

                            myRobot.Leg.Add(currentLeg);
                        }
                        else if (currentLeg.Energy < Math.Min(myRobot.Leg[0].Energy, myRobot.Leg[1].Energy))
                        {
                            currentEnergy += (myRobot.Leg[0].Energy - currentLeg.Energy);

                            myRobot.Leg[0] = currentLeg;
                        }
                        else if (currentLeg.Energy < myRobot.Leg[1].Energy)
                        {
                            currentEnergy += (myRobot.Leg[1].Energy - currentLeg.Energy);

                            myRobot.Leg[1] = currentLeg;
                        }
                        break;

                    case "Torso":

                        Torso currentBody = new Torso();

                        currentBody.Energy = int.Parse(inputArray[1]);
                        currentBody.ProcessorSize = double.Parse(inputArray[2]);
                        currentBody.Material = inputArray[3];


                        if (myRobot.Body.Count < 1)
                        {
                            currentEnergy -= currentBody.Energy;

                            myRobot.Body.Add(currentBody);
                        }
                        else if (currentBody.Energy < myRobot.Body[0].Energy)
                        {
                            currentEnergy += (myRobot.Body[0].Energy - currentBody.Energy);

                            myRobot.Body[0] = currentBody;
                        }
                        break;

                    case "Head":

                        Head currentHead = new Head();

                        currentHead.Energy = int.Parse(inputArray[1]);
                        currentHead.IQ = int.Parse(inputArray[2]);
                        currentHead.Material = inputArray[3];

                        if (myRobot.Head.Count < 1)
                        {
                            currentEnergy -= currentHead.Energy;

                            myRobot.Head.Add(currentHead);
                        }
                        else if (currentHead.Energy < myRobot.Head[0].Energy)
                        {
                            currentEnergy += (myRobot.Head[0].Energy - currentHead.Energy);

                            myRobot.Head[0] = currentHead;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            bool needParts = myRobot.Arm.Count < 2
                            || myRobot.Leg.Count < 2
                            || myRobot.Body.Count < 1
                            || myRobot.Head.Count < 1;

            if (currentEnergy < 0)
            {
                Console.WriteLine("We need more power!");
            }
            else if (needParts)
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                Console.WriteLine($"{myRobot.Name}:");

                Console.WriteLine("#Head:");
                Console.WriteLine($"###Energy consumption: {myRobot.Head[0].Energy}");
                Console.WriteLine($"###IQ: {myRobot.Head[0].IQ}");
                Console.WriteLine($"###Skin material: {myRobot.Head[0].Material}");

                Console.WriteLine("#Torso:");
                Console.WriteLine($"###Energy consumption: {myRobot.Body[0].Energy}");
                Console.WriteLine($"###Processor size: {myRobot.Body[0].ProcessorSize:f1}");
                Console.WriteLine($"###Corpus material: {myRobot.Body[0].Material}");

                int armFirstIndex = myRobot.Arm.IndexOf(myRobot.Arm.OrderBy(e => e.Energy).FirstOrDefault());

                int legFirstIndex = myRobot.Leg.IndexOf(myRobot.Leg.OrderBy(e => e.Energy).FirstOrDefault());

                Console.WriteLine("#Arm:");
                Console.WriteLine($"###Energy consumption: {myRobot.Arm[armFirstIndex].Energy}");
                Console.WriteLine($"###Reach: {myRobot.Arm[armFirstIndex].Reach}");
                Console.WriteLine($"###Fingers: {myRobot.Arm[armFirstIndex].Fingers}");

                Console.WriteLine("#Arm:");
                Console.WriteLine($"###Energy consumption: {myRobot.Arm[1 - armFirstIndex].Energy}");
                Console.WriteLine($"###Reach: {myRobot.Arm[1 - armFirstIndex].Reach}");
                Console.WriteLine($"###Fingers: {myRobot.Arm[1 - armFirstIndex].Fingers}");

                Console.WriteLine("#Leg:");
                Console.WriteLine($"###Energy consumption: {myRobot.Leg[legFirstIndex].Energy}");
                Console.WriteLine($"###Strength: {myRobot.Leg[legFirstIndex].Strength}");
                Console.WriteLine($"###Speed: {myRobot.Leg[legFirstIndex].Speed}");

                Console.WriteLine("#Leg:");
                Console.WriteLine($"###Energy consumption: {myRobot.Leg[1 - legFirstIndex].Energy}");
                Console.WriteLine($"###Strength: {myRobot.Leg[1 - legFirstIndex].Strength}");
                Console.WriteLine($"###Speed: {myRobot.Leg[1 - legFirstIndex].Speed}");
            }
        }
    }

    internal class Robot
    {
        public string Name { get; set; }
        public List<Arms> Arm { get; set; }
        public List<Legs> Leg { get; set; }
        public List<Torso> Body { get; set; }
        public List<Head> Head { get; set; }
    }

    public class Torso
    {
        public int Energy { get; set; }
        public double ProcessorSize { get; set; }
        public string Material { get; set; }
    }

    public class Head
    {
        public int Energy { get; set; }
        public int IQ { get; set; }
        public string Material { get; set; }
    }

    public class Legs
    {
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }

    public class Arms
    {
        public int Energy { get; set; }
        public int Reach { get; set; }
        public int Fingers { get; set; }
    }
}