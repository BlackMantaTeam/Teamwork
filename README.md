# Teamwork
Teamwork in Windows Applications course @ TelerikAcademy

## Application: JustPlay

**Purpose**: Playing songs

Implemented functionality:
- The user can choose different categories of songs from a side bar.
- When selected – the list of songs from the chosen category appear in a list.
- When the user click on a song – the sound plays.
- On a second click – pause a song is implemented.
- There is a search tool for searching a song the user want.
- Each song has picture and title.
- Page transition
- Tab Event

Server: Implemented WebApi with database and get and post requests, but not related to UI.


## Application: Music Player

**Purpose**: Playing songs

Implemented functionality:
- User register: the user registers with username, password and picture, which is taken from device Camera. Can choose to register -redirects to playlist page, or cancel -redirects to main page
- Login – no notification, but the user redirects to playlist page
- From the upbar the user can choose to create a new playlist.
- Creating a playlist is implemented on a new page, where the user inputs title and genre of the playlist, then chooses songs to add, finally saves the playlist or cancel. Both lead to PlaylistPage
- On PlaylistPage is the list with playlists of the user. Choosing a playlist redirects to Play page where on a list of songs, the user can choose a song to play. Currently own playlist and songs of the user and playing a specific song is not implemented.

Server: Parse is used. All Put requests are implemented, get requests are not implemented

**Team**:
- Tectonik (Martin Ali)
- zvet80 (Tsvetanka Chipilova)

**Github**:https://github.com/BlackMantaTeam
**YouTube**:
- JustPlay https://www.youtube.com/watch?v=HPSOYmi4op0
- MusicPlayer https://www.youtube.com/watch?v=GcWZLmjCX6s

