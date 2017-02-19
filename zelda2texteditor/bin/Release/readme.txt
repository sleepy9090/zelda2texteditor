Zelda II NES ROM Text Editor
Programmed by: Shawn M. Crawford
Last Update: June 25th, 2016 in C#
Latest Build: 1.2.1.32055
 ----

Features:
	* edit every line of text in the game (spells, character text, registration screen, end credits, story, etc, etc)
	* this version only works with US rom (Zelda 2 - The Adventure of Link (U).nes), might work with other versions but untested because it relies on offsets in the ROM

Requires:
	* .Net Framework 3.5, tested on windows 8/8.1 x64, Windows 7 x64, Windows Vista x32, and Windows XP x32

Usage:
	*Open the Rom (Zelda 2 - The Adventure of Link (U).nes), change text, click update, make sure you have a backup in case something breaks.
	*Feel free to email bugs to sleepy3d@gmail.com

TODO:
	* refactor more form code to use backend class, clean up junk code
        * Fix tab order

1.2.1.32055 June 25th, 2016
 ----
- Fixed a bug when updating in-game text the filesize would grow. This was due to an incorrect offset. (thanks for reporting Geoffrey/itemdrop)

1.2.0.27039 April 9th, 2016
 ----
- Fixed location editing, previous builds did not set the text properly on location signs (town names, etc) (thanks
Manuel García López for reporting)
- Cleaned up some image stuff
- Incoporated a common class and started refactoring code

1.1.0.32099  March 26th, 2016
 ----
-updated form "Edit In Game Text" per request so that it fits 1024x768 Resolution per request
-updated all forms to fix a crashing when change filename after loading, and to disable textboxes until rom text is loaded
-removed disassemble button and menu item, added auto disassemble when ROM is loaded

 ----
1.1.0.21257  March 16th, 2016

-fixed a bug in spell text,  "DESERT USE" "THIS MAGIC" "TO SURVIVE" incorrectly written on update (thanks again for reporting it szemigi)

 ----
1.1.0.20646  March 14th, 2016
-fixed a bug in spell text, "IN PARAPA" wrote to the wrong offset (thanks for reporting it szemigi)

 ----
1.0.0.21865  June 17th, 2010
-fixed bug in story text
-fixed tab order
-added town names
-minor code optimization

 ----
1.0.0.19516  June 9th, 2010
-initial release
 ----