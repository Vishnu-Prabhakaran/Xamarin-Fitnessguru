##################################################
Fitness Guru
##################################################
A fitness App to help you work out on the go. You can mark down the completed workouts and add your photo weekly to see the work out progress.

#Development:
Created using Xamarin forms, using C#.

#Platform:
Mainly for Android. from version 4.4 above.
No age restrictions.

#Views/ Activity
Login - To login
Register - to register new users
Reset - To reset Passwords
Mainpage - Which holds the HomePage, ProfilePage, WorkoutPage, ProgressPage, MenuPage
HomePage - Landing Page for the app.
ProfilePage - Users profile page
WorkoutPage - Loads the workout activity
ProgressPage - Camera Button with the library of images taken
Menupage - Hold all additional pages
      - LoginPage
      - reset
      - Workout level
      - Eating Habits
      - Set Workout Days
      - Logout

#Features to be added in future
- Linking Set workout days to the profile pages
- Posting back the workouts done to the API
- sectioning workouts with workout days.
- score page to keep score
- workout with click to read instructions.
- api with quotes and Images on landing page.


##################################################
Configuring Git
##################################################

MAC:
If you're on Mac, it's already installed, you just need to configure it:
https://youtu.be/rfAJR8YfB_M

Test that you can read a basic index.html file first, before moving to GIT setup.

Hello!

GIT is a code repository protocol, a place where we can store our code, and all access it / share it / upload it without conflicts.
It also stores all versions of uploads, so we can rollback to a previous version in case anyone messes up a file.

The particular server we'll be using is called BitBucket (as it's free with university email accounts).

(1) Create an account on bitbucket (https://bitbucket.org). Write down your username + email address

(2) Install Tools (if on Windows)
For Windows: https://git-for-windows.github.io/
For Mac: Tools are already installed on command-line.

Alternatively, try a GUI client, and Clone the existing Bitbucket repository:
https://tortoisegit.org/docs/tortoisegit/tgit-dug-clone.html


(3) Configure your username + email on your computer (use deakin email)
# Open Command-Line/Terminal
# Use username + email you use on bitbucket
# Type the following two commands:
> git config --global user.name "Firstname Lastname"
> git config --global user.email YOURNAME@deakin.edu.au

(4)
# Create a directory for your web-app projects. It could just be in your home directory/Sites.


# Open Command-Line/Terminal
# Change to your web-app project directory
> cd Sites/Web-Apps/

# Download the existing project

> git clone https://VishnuPrabhakaran@bitbucket.org/VishnuPrabhakaran/fitnessguru.git

(5) Now open that directory in Atom

(6) Add the Atom package "git-control"
After it has installed, open the git:control window by going to Atom menu -> Packages -> git-control -> toggle

##################################################
Daily GIT Usage
##################################################

(A)
(A1) Whenever you start your daily session, download the latest updates:
git:control -> fetch
(A2) if it finds changes, the Pull icon next to it will become available, so click that next:
git:control -> pull

# Now you're up to date.

(B)
(B1) When you are finished for the day, FIRST, do another Fetch + Pull, to make sure you get any changes that happened while you were working.
git:control -> fetch
git:control -> pull

(B2) commit + push back up to the server:
git:control: select all files that have changed that you want to upload (usually all)
git:control -> commit (saves to your local GIT database)
git:control -> push (pushes your local GIT database changes up to BitBucket server)

# Now your files will be up on the server.

# You can confirm that by accessing the website:
git clone https://bitbucket.org/VishnuPrabhakaran/fitnessguru/commits
# All done!
