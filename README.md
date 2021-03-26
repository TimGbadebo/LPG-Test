# LPG-Test: API Documentation.
This project consist of an API (GoCityAPI) and a UI (GoCityUI) Automation projects. 
To complete the GoCity API project, certain packages were required: A. NUnit template framework and B. RestSharp. 
An object of RestClient was created to hold the URL
An object of RestRequest was created to hold arguements i.e endpoints and methods.
Further parameters was set to accept JSON only.
The content of the request was deserialised into a C# object for both requests (Locations & Attractions).
The first request was straight forward to get all cities.
The second request was also straight forward to get all attractions in New York using the CityID.
The last request had to be queried using Type = MUSEUM.
After successful deserialisation, an assertion was made to assert the correct values. 
The last request, assertion was made to get the total count from the query.
