# ByteDev.PasswordMask

Small windows application to help selecting the certain characters from a given password.  Application requires .NET Framework 4.6.2.

## Why?

A number of websites require the user to type in say the 1st, 3rd and 6th character from their password.  When the password is long and random this can be a pain to find out often resulting in the user pasting the password into notepad and then counting along.  

This application helps speed up the process of selecting the particular numbered characters.

## Code

The repo can be cloned from git bash:

`git clone https://github.com/ByteDev/ByteDev.PasswordMask`

## Usage

![](https://raw.githubusercontent.com/ByteDev/ByteDev.PasswordMask/master/images/screen1.png)

Run the PasswordMask.exe executable.

The application will automatically paste in the last thing in the clipboard into the password textbox.  Edit the password if need be.

Click the eye icon to toggle whether the password text is hidden or not.

Click the Pwned? button if you have an internet connection to check if the password has check been pwned.  This sends a partial hash of your password to the [Have I Been Pwned API](https://haveibeenpwned.com/).

Change any of the four numbers to expose the corresponding character of the password.
