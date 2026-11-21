# zelda2texteditor
Text editor for the NES ROM Zelda II - The Adventure of Link<br/>

<img width="759" height="487" alt="image" src="https://github.com/user-attachments/assets/dafa0d77-91b2-4cfa-b856-9e3cecf42f58" /><br/>

<img width="566" height="438" alt="image" src="https://github.com/user-attachments/assets/cc89c052-8dac-4820-9fe3-41b382510b9c" /><br/>

<img width="455" height="310" alt="image" src="https://github.com/user-attachments/assets/0f7323af-c35c-48fc-82bd-56711718a586" /><br/>


Zelda II NES ROM Text Editor
Programmed by: Shawn M. Crawford [sleepy]
Last Update: October 15th, 2019
Latest Build: 2.0.0.24468
 ----

Features:
	* edit every line of text in the game (spells, character text, registration screen, end credits, story, and general game)
	* this version only works with US rom (Zelda 2 - The Adventure of Link (U).nes), might work with other versions but untested because it relies on offsets in the ROM

Requires:
	* .Net Framework 3.5, tested on Windows 10/8/8.1/7 x64, Windows Vista x32, and Windows XP x32

Usage:
	*Open the Rom (Zelda 2 - The Adventure of Link (U).nes), change text, click update, make sure you have a backup in case something breaks.
	*Recommended to change a section at a time, then backup the ROM, and verify the changes.
	*Feel free to email bugs to sleepy3d@gmail.com

2.0.0.24468 October 15th, 2019
 ----
- Completely re-factored code

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
