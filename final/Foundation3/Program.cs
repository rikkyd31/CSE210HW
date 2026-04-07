using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        // Attributes
        // Lecture Event
        string eventTitle = "Brother Gibbons 18 Hour Lecture";
        string eventDescription = "An enthralling dive into the world of data structures, lists, arrays, and big O notation.";
        DateOnly date = new DateOnly(2026, 3, 31);
        TimeOnly time = new TimeOnly(9, 54);
        string address = "5468 East Side Drive";
        string city = "Rexburg";
        string state = "Idaho";
        string zipCode = "83440";
        string lectureSpeaker = "Brother Gibbons";
        int speakerCapacity = 100;
        List<Event> eventList = new List<Event>();

        // Reception Event
        string eventTitle2 = "Brad's Wedding Reception";
        string eventDescription2 = "The Cake is Delcious";
        DateOnly date2 = new DateOnly(2026, 5, 20);
        TimeOnly time2 = new TimeOnly(14, 30);
        string address2 = "333 North Side Lane";
        string city2 = "Idaho Falls";
        string state2 = "Idaho";
        string zipCode2 = "83401";
        string email = "brad@wedding.com";

        // Outdoor Event
        string eventTitle3 = "Unicyclist Race";
        string eventDescription3 = "Watch 50 unicyclists race across the ocean.";
        DateOnly date3 = new DateOnly(2026, 3, 31);
        TimeOnly time3 = new TimeOnly(9, 54);
        string address3 = "22242 West Side Avenue";
        string city3 = "Pocatello";
        string state3 = "Idaho";
        string zipCode3 = "83201";
        string weather = "Cloudy with a chance of rain and snow.";   

        // Create Lecture Event
        Lecture myLecture = new Lecture();

        myLecture.SetTitle(eventTitle);
        myLecture.SetDescription(eventDescription);
        myLecture.SetDate(date);
        myLecture.SetTime(time);
        myLecture.SetSpeaker(lectureSpeaker);
        myLecture.SetCapacity(speakerCapacity);
        myLecture.SetAddress(address, city, state, zipCode);

        eventList.Add(myLecture);

        // Create Reception Event
        Receptions myReceptions = new Receptions();

        myReceptions.SetTitle(eventTitle2);
        myReceptions.SetDescription(eventDescription2);
        myReceptions.SetDate(date2);
        myReceptions.SetTime(time2);
        myReceptions.SetAddress(address2, city2, state2, zipCode2);
        myReceptions.SetEmail(email);

        eventList.Add(myReceptions);

        // Create Outdoor Event
        Outdoor myOutdoor = new Outdoor();

        myOutdoor.SetTitle(eventTitle3);
        myOutdoor.SetDescription(eventDescription3);
        myOutdoor.SetDate(date3);
        myOutdoor.SetTime(time3);
        myOutdoor.SetAddress(address3, city3, state3, zipCode3);
        myOutdoor.SetWeather(weather);

        eventList.Add(myOutdoor);

        // Iterate and display each event.
        foreach(Event myEvent in eventList)
        {
            // Display the three types of details for each event.
            myEvent.StandardDetails();
            myEvent.FullDetails();
            myEvent.ShortDescription();
        }
        

    }
}