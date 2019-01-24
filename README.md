# TimePerson

What is the purpose of the program?

The purpose of the app is to be able to view information about Time's person of the year based on a range of years of yur choice.

How do I run the program?

When you get to the home page, you enter a begin year and an end year and then click the submit button.  This will show all the people of the years for all the dates in you selection. 

The applications takes in a csv file, I created a class based on the properties in the csv file.  When the user inputs year range, the app will loop through a list I created of instances of the Time Person class, and use LinQ to filter the results to only include time persons within the year range provided by the user.

The new lest of requested time persons is sent to the results page, where I use a loop to loop through the list and render the results in the form of a tabe.

The user can then return to the home page to conduct a new search if they choose to do so.

What does the program look like? (visual)
![image](https://github.com/omence/TimePerson/blob/master/Screenshot%20(10).png)
![image](https://github.com/omence/TimePerson/blob/master/Screenshot%20(11).png)
