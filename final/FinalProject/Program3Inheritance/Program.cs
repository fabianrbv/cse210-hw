// using System;

// // Address class to store address information
// class Address
// {
//     public string Street { get; set; }
//     public string City { get; set; }
//     public string State { get; set; }
//     public string Country { get; set; }

//     public string GetAddressDetails()
//     {
//         return $"{Street}, {City}, {State}, {Country}";
//     }
// }

// // Base Event class
// class Event
// {
//     public string Title { get; set; }
//     public string Description { get; set; }
//     public DateTime Date { get; set; }
//     public string Time { get; set; }
//     public Address Location { get; set; }

//     public virtual string GetStandardDetails()
//     {
//         return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nLocation: {Location.GetAddressDetails()}";
//     }

//     public virtual string GetFullDetails()
//     {
//         return GetStandardDetails();
//     }

//     public virtual string GetShortDescription()
//     {
//         return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
//     }
// }

// // Derived Lecture class
// class Lecture : Event
// {
//     public string Speaker { get; set; }
//     public int Capacity { get; set; }

//     public override string GetFullDetails()
//     {
//         return $"{base.GetFullDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
//     }
// }

// // Derived Reception class
// class Reception : Event
// {
//     public string RsvpEmail { get; set; }

//     public override string GetFullDetails()
//     {
//         return $"{base.GetFullDetails()}\nRSVP Email: {RsvpEmail}";
//     }
// }

// // Derived OutdoorGathering class
// class OutdoorGathering : Event
// {
//     public string WeatherForecast { get; set; }

//     public override string GetFullDetails()
//     {
//         return $"{base.GetFullDetails()}\nWeather Forecast: {WeatherForecast}";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create instances of each event type
//         Lecture lecture = new Lecture
//         {
//             Title = "Public Speaking Workshop",
//             Description = "Learn the art of public speaking",
//             Date = DateTime.Now.AddDays(10),
//             Time = "10:00 AM",
//             Location = new Address { Street = "123 Main St", City = "Anytown", State = "CA", Country = "USA" },
//             Speaker = "John Doe",
//             Capacity = 50
//         };

//         Reception reception = new Reception
//         {
//             Title = "Summer Mixer",
//             Description = "Join us for a fun evening!",
//             Date = DateTime.Now.AddDays(15),
//             Time = "6:00 PM",
//             Location = new Address { Street = "456 Oak St", City = "Otherville", State = "NY", Country = "USA" },
//             RsvpEmail = "rsvp@example.com"
//         };

//         OutdoorGathering gathering = new OutdoorGathering
//         {
//             Title = "Community Picnic",
//             Description = "Enjoy a day outdoors with friends and family",
//             Date = DateTime.Now.AddDays(20),
//             Time = "12:00 PM",
//             Location = new Address { Street = "789 Elm St", City = "Sometown", State = "TX", Country = "USA" },
//             WeatherForecast = "Sunny"
//         };

//         // Display marketing messages for each event
//         Console.WriteLine("Standard Details:");
//         Console.WriteLine(lecture.GetStandardDetails());
//         Console.WriteLine();

//         Console.WriteLine("Full Details:");
//         Console.WriteLine(reception.GetFullDetails());
//         Console.WriteLine();

//         Console.WriteLine("Short Description:");
//         Console.WriteLine(gathering.GetShortDescription());
//     }
// }
