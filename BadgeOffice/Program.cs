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
System.Console.Write("Full name: ");
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
int studentID = rng.Next(100000, 1000000);
int lockerID = rng.Next(1, 501);
System.Console.WriteLine("\nStudent ID: " + studentID);
System.Console.WriteLine("Locker: " + lockerID);

// Asks for dorm and class coordinates, as well as student's walking speed.
System.Console.Write("\nDorm x: ");
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

// Check digit calculation and get padding length
int checkDigit = studentID % 9;

/* This part ended up being unused, but I was trying to figure out if there was some way to dynamically get the length of each section and figure out the padding from there, but I found a much easier solution.
int namePadding = fullName.Length;
int userPadding = userName.Length;
int idPadding = studentID.ToString().Length + 2;
int lockerPadding = lockerID.ToString().Length;
int walkPadding = walkMinutes.ToString().Length + walkSeconds.ToString().Length;
*/

// Final Badge Output
System.Console.WriteLine("\n==================================");
System.Console.WriteLine("        ETSU Student Badge");
System.Console.WriteLine("==================================");
System.Console.WriteLine("NAME".PadRight(10) + fullName.ToString());
System.Console.WriteLine("USERNAME".PadRight(10) + userName.ToString());
System.Console.WriteLine("ID".PadRight(10) + studentID.ToString() + "-" + checkDigit);
System.Console.WriteLine("LOCKER".PadRight(10) + lockerID.ToString());
System.Console.WriteLine("WALK".PadRight(10) + walkMinutes.ToString() + " min " + walkSeconds.ToString() + " sec");
System.Console.WriteLine("==================================");