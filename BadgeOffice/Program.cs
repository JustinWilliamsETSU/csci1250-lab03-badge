/*
 * Name:        Justin Williams
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 03, The Badge Office
 * Date:        September 30, 2026
 * Description: Builds a student badge from a name, two random assignments, and the walking distance to a first class.
 */

// Random object to be used throughout the assignment
Random rng = new Random();

// Gets the user's full name
System.Console.Write("Please input your first and last name with a space inbetween: ");
string fullName = Console.ReadLine();

// Generates the username based on their full name
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string firstLetter = fullName.Substring(0, 1);
string userName = firstLetter.ToLower() + lastName.ToLower();

// Gets their initials. We already made firstLetter above, so we only need to make lastLetter here.
string lastLetter = lastName.Substring(0, 1);

// Calculates the letters in their last name.
int numberOfLetters = lastName.Length;

// Output for name
System.Console.WriteLine("Name on badge: " + fullName.ToUpper());
System.Console.WriteLine("Username: " + userName.ToString());
System.Console.WriteLine("Initials: " + firstLetter.ToUpper() + "." + lastLetter.ToUpper() + ".");
System.Console.WriteLine("Letters in last name: " + numberOfLetters.ToString());

// Student ID and Locker Number
System.Console.WriteLine("Student ID: " + rng.Next(100000, 1000000));
System.Console.WriteLine("Locker: " + rng.Next(1, 501));

// Asks for dorm and class coordinates, as well as student's walking speed.
System.Console.Write("Dorm x: ");
int dormX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Dorm y: ");
int dormY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Classroom x: ");
int classX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Classroom y: ");
int classY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Walking speed in feet per second: ");
double feetPerSecond = Convert.ToDouble(Console.ReadLine());

// Calculates distance and walk time.
double distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));
double walkTime = Math.Round(distance / feetPerSecond);
int walkMinutes = Convert.ToInt32(walkTime) / 60;
int walkSeconds = Convert.ToInt32(walkTime) % 60;

// Outputs distance and walk time
System.Console.WriteLine("Distance: " + distance.ToString("F1") + " feet");
System.Console.WriteLine("Walk time: " + walkMinutes.ToString() + " minutes and " + walkSeconds.ToString() + " seconds.");