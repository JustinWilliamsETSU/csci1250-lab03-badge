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