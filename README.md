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
------------------------------------------------------------------------------------------------------------------------------------------------------------------------



--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
LPG-Test: UI Documentation
To complete the GoCity UI Automation project, certain packages were required: A. NUnit template framework, B. Selenium webdriver & Support, C. Chrome driver.
A resource file called "Path" was added to make it data driven. 
Page object style was implemented as part of this project. All pages are added to the "Pages" folder. 
A static Custom method was added as an extension for IWebElements.
A seperate static driver class was created to hold one instance of the IWebdriver interface.
The concept behind this automation framework is for usability, collaberation, reduced code duplication amongst others. FYI. This framework can be developed much better. 
The unit test consist of two test which demonstrates users journey and NUnit test adaptor 3 was required for test execution from the test explorer window.
The first test method was focused on user getting a 1 day all inclusive pass for an adult.
The second test method was focused on user getting a 2 days all inclusive pass for both an adult and a child. 
Both test was carried along till the "Payment" section where user had to enter their credit card credentials. 
For both step automation test was carried out for user, A. picking what type of pass needed, B. Amount of passes needed, C, Whom the pass is being bought for (Adult or Child), D. Date of visit. 
Assertions were used to verify test credibility. 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

To run both test, make sure you clean and build solution. 
You can pick what test you want to run via test explorer 
Test can be run in debug mode for indepth understanding of code and what they do. 
Or you can Simply click the run button to run the test

What needs been done to finish the user experience 
Payment carried out and user should recieve the correct detail of the pass paid for
