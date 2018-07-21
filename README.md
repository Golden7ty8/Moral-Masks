# Our-Many-Masks
PolyFolds Project

## Controls (For Testers):

Escape to go back to main menu, if already on main menu or lock screen, will quit game.


## Code Orginization (For Contributors):

 - Script Naming:
 Many scripts should try to stay in 'groups' when it comes to naming the script with a prefix, for example 'MenuLockScreen' and 'MenuMainMenu' both share the prefix 'Menu' at the beginning of the name. This will alphabetcly sort similarly functioning scripts together for increased orginization.

 - Script Header:
Scripts should contain a comment header describing what the script does and the date created and modified as well as who created/modified it.

 
 - Variable and Method Naming:
 This is more personal preference but is best kept somewhat consistent across contributors for neatness sake so if you wish do deviate from this, please comunicate with other contributors and figure out a common ground. Variables are named without a capital for the first letter, but if it contains more then one word in it, instead of spaces, each new word is indicated with a capital letter at the start of each new word, this is something Unity reeconizes and displays in the inspector. For example naming a variable say "Wooden horse" would be 'woodenHorse' as a variable.
 Methods are capitalized the same except they also start with a capital letter.
 On top of this, variable and method names should (to the best of your ability) fasilitate comprihension of your code. If you think that a variable or method (particularly a public one) cannot be understood just by it's name, I would recommend for variables adding a tooltip by placing Tooltip[("Explanation of variable goes here.")] above the variable. For methods, you can add a triple slash ( /// ) which will add a block of commented text allowing you to put a summery of the method above the function that will be viewable whenever the method is used.
