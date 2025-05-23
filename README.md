# LUNA
a lightweight notepad application.

## Description
LUNA, or Lightweight Universal Notes Application, was originally created for myself because I couldn't find a plaintext editor that I liked enough. LUNA aims to provide a simple, no-nonsense way to create and edit text files. It can also import and export formats like .md and .rtf. txt and md files have been tested and should work smoothly with LUNA. rtf files can be imported and exported, but LUNA itself will not render them and will display the data in plaintext instead.

LUNA now has a button that will highlight basic markdown syntax when pressed. Please note that there is currently a small bug where, if your cursor is immediately next to or selecting characters such as *, #, etc, the next text you type will also be in that color. This is unintentional and I'm planning to fix it if I can. Furthermore, note that this will not actually break the file- the highlighting is just for the sake of visually discerning markdown. Pressing the button will not modify the file's actual text.

![LUNA](https://img.itch.zone/aW1hZ2UvMzMzMjkzOC8yMDU3MDQzNi5wbmc=/347x500/Kt6Pdp.png)

![LUNA](https://img.itch.zone/aW1hZ2UvMzMzMjkzOC8yMDYwNDEwMi5wbmc=/347x500/VrJG3i.png)

---

## Features

- opens, saves, and exports .txt, .md, and .rtf files
- plaintext editing/writing
- cursor can be controlled by a mouse or with arrow keys
- allows exporting a file in a different file extension than the original
- original file data is never overwritten unless you intentionally replace the file with a new save
- clicking 'new' wipes the text box clean and, again, does not override file data
- clicking 'highlight markdown' displays common markdown syntax, such as #, in different colors
- both light and dark modes

---

## Getting Started

### Dependencies
- So far, I can say with absolute certainty that LUNA will function on Windows 11 and Windows 10. I have not yet been able to test it on other versions of Windows, MacOS, or Linux.
- It seems that LUNA may also work with Wine on Linux systems.
- LUNA is also available for download on [itch.io](https://kumori-arashi.itch.io/luna).
  
### Installing / Executing
- You should not need to downlad anything else to run LUNA. Simply download the .exe from the releases and run it. Please let me know if you run into any issues.

## Technologies used (so far)
- C#
- WinForms
- Visual Studio

## Credits 
- Programming, UI, icon: @DragonCloudBurst / kumori (you are here)
- README template: @DomPizzie | [link](https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc)
- this one person on microsoft forums | [link](https://learn.microsoft.com/en-us/answers/questions/530055/how-to-color-a-specific-string-s-in-richtextbox-te)
