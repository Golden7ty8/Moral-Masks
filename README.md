# Our-Many-Masks
PolyFolds Project.

## Controls (For Testers):

 - Escape: Return to main menu, if already on main menu or lock screen, will quit game.
 - Shift: Toggle Debug Display.


## Code Orginization (For Contributors):

 - Script Naming:
 Many scripts should try to stay in 'groups' when it comes to naming the script with a prefix, for example 'MenuLockScreen' and 'MenuMainMenu' both share the prefix 'Menu' at the beginning of the name. This will alphabetcly sort similarly functioning scripts together for increased orginization.

 - Script Header:
Scripts should contain a comment header describing what the script does and the date created and modified as well as who created/modified it.

 - Variable and Method Naming:
 This is more personal preference but is best kept somewhat consistent across contributors for neatness sake so if you wish to deviate from this, please comunicate with other contributors and figure out a common ground. Variables are named without a capital for the first letter, but if it contains more then one word in it, instead of spaces, each new word is indicated with a capital letter at the start of each new word, this is something Unity reconizes and displays in the inspector. For example naming a variable say "Wooden horse" would be 'woodenHorse' as a variable.
 Methods are capitalized the same except they also start with a capital letter.
 On top of this, variable and method names should (to the best of your ability) fasilitate comprihension of your code. If you think that a variable or method (particularly a public one) cannot be understood just by it's name, I would recommend for variables adding a tooltip by placing Tooltip[("Explanation of variable goes here.")] directly above the variable. For methods, you can add a triple slash ( /// ) directly above the method which will add a block of commented text allowing you to put a summery of the method above the function that will be viewable whenever the method is used.
 But don't sweat it too much, I myself am not perfect, especially with that last one, so don't stress it too much while still trying to do the best you can!
 
 - Code Organization with Methods:
 If at any time you find yourself placing a lot of code within a start, update or similar method, I would recommend placing such code in a new method instead and placing a call to that method in the the method the code was in previously for increased organization especially if the script in question is doing multiple different tasks, keeping them separate in other methods will help comprehension. An example of this in the project is the script 'MenuToolbar' where the Update method has a call to the UpdateDisplay method.

## Source Control (For Contributors):

'Pulling' refers to downloading the repository (in other words the files stored here) to your local device, i.e your windows or mac or whatever device you will end up storing the files on.
'Pushing' is uploading changes you made to the repository.

 - First of all, I highly recommend downloading GitHub desktop (easily searchable on google), just uploading files to the repository though your browser is very limiting as you will not be able to delete files, and you will not be able to upload lots of files at once, meaning you will have to manually know and remember which files you changed and upload them, making things more difficult. On top of that, the accuracy of your changes will end up being less reliable. With GitHub desktop, once setup (you can use this video as a guide: https://www.youtube.com/watch?v=77W2JSL7-r8&t=5s ) it will automatically detect changes you made to the project on your device and you can easily commit your changes to the repository after naming your changes. After clicking "commit to master", make sure you also upload your commit to the repository by clicking the "fetch origin" button on the top bar of GitHub desktop, the button will indicate if you have changes to upload. If you are unsure you did it correctly, you can simply check here to see your change is reflected in the repository commit history.
 
 - If you have made changes, please don't delay in pushing them, especially if you stop making changes for any length of time. The longer you leave it, the more likely someone else will be making changes to the same files you changed, and there will be conflicts when it comes time to merge the changes onto the repository.
 
 - Please let everyone else who is contributing know when you are making changes and if asked, let them know which files you are changing (something GitHub desktop makes really easy).
 
Thanks!
