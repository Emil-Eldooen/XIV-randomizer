# Preface
This README is meant to document what the point of the project was and some of my observations about the process overall, I'd encourage you to read this if you're interested in the development process and assumptions made during development!

# What's the program about?
This is a small simple randomizer program I made in .NET using C# and XAML.

The program is very simple, it has checkboxes for each of the jobs in Final Fantasy XIV that can be unchecked to remove a class or checked to add the class. Once the "Pick a class" button is clicked, the C# script will select a random class from the list and return the output, update text and the meteor image to the relevant job. In the event no jobs are selected, an error is displayed on screen requesting the user to add jobs before trying again.

The program starts with all jobs selected, and has role checkboxes to easily remove every class in a specific role.

Note that this only includes all the jobs in the game, as such the classes that upgrade into their respective jobs are not accessible. I went for this solution for the following reasons:

1. Jobs upgrade already at level 30, and after the first expansion all the new jobs start at lvl 30 or above. This means that classes become obsolete very quickly, and by the time such a randomizer would be relevant for a player they should already be well familiar with the system.
2. The software was intended from the start to be for players that already have some experience with the game, and as such would most likely know which classes become which jobs.
3. By the time a randomizer would even be relevant for a player, they would most likely have all jobs at or close to level 30, at which point the inclusion of them (and subsequently forcing any players with those classes upgraded) to always have to untick their boxes.

A potential middle solution would be to have the output be "You got class/job" and display both images, but for the sake of a uniform design and output I decided against working around the exception for such a small hypothetical userbase.

# TODO:
Work more on documentation to make the code more readable
Update with Dawntrail jobs
Test on different screen sizes

I was simply very late with uploading the project to github and will look into making these adjustments asap.

# Challenges regarding this project:
One consideration was allowing for users to input jobs on their own, but considering how difficult it'd be to manage user input, handling exceptions etc checkboxes became a much preferred solutiion to easily allow the user to customize which jobs and roles the randomizer should pick from. This also made controlling input a lot easier, and handling exceptions.
At first I made the assumption that it would be best to store job and role relations assuming that I couldn't alter checkbox states from the C# script. However once I realized this was possible, the dictionary became pointless and putting all the roles in a single list was more workable and caused a lot fewer edge cases as well as less need for extra "master lists" to ensure integrity as users removed jobs.
Getting things to look the way I wanted was also quite annoying, eventually I settled on storing all the checkboxes in a grid withini a vertical stack layout to keep everything centered. This way I could avoid nesting several stack layouts in an attempt to create what grid simply allowed me to make with rows and columns
Lastly DRY, this could be my inexperience with front end development, but it was quite frustrating having to repeat the same code for essentially all checkboxes and simply editing their position in the grid.

# Things that went well:
Connecting the backend and front end was quite fun and interesting to learn during this project, as well as altering the front end with code was a rewarding experience that I look forward to learning even more about in the future.
Finding the assets for this project was also quite simple as Square Enix has an asset pack available for download [here](https://na.finalfantasyxiv.com/lodestone/special/fankit/desktop_wallpaper/4_0/). This includes a lot more, but was where I found the class images and endwalker png.
Programming in C# in general is still as fun and rewarding as I remember it being

#What's next?
My next project will be to port this to a website using .NET's BLAZOR as practice and hopefully host it as a website so it's easier to distribute and share with others.
